using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Xml;
using LAZYSHELL.Properties;

namespace LAZYSHELL
{
    /// <summary>
    /// Represents a ROM address range with start (inclusive) and end (exclusive).
    /// </summary>
    public struct RomRange
    {
        public int Start;
        public int End;
        public RomRange(int start, int end) { Start = start; End = end; }
        public int Size { get { return End - Start; } }
        public override string ToString() { return Start.ToString("X6") + "-" + End.ToString("X6"); }
        public static RomRange Parse(string s)
        {
            string[] parts = s.Split('-');
            return new RomRange(
                Convert.ToInt32(parts[0].Trim(), 16),
                Convert.ToInt32(parts[1].Trim(), 16));
        }
    }

    /// <summary>
    /// Central configuration hub for all ROM layout settings.
    /// Reads from Settings.Default and provides typed properties for use by all editors.
    /// All defaults match the original vanilla SMRPG ROM.
    /// </summary>
    public static class RomConfig
    {
        private static Settings settings { get { return Settings.Default; } }

        // Sprite BPP graphics ranges (absolute ROM addresses)
        // Vanilla: single range 0x280000-0x330000
        public static List<RomRange> SpriteGraphicsRanges
        {
            get { return ParseRanges(settings.SpriteGraphicsRanges); }
            set { settings.SpriteGraphicsRanges = ToStringCollection(value); }
        }

        // Animation bank ranges (absolute ROM addresses)
        // Vanilla: 4 banks for animation data
        public static List<RomRange> AnimationBanks
        {
            get { return ParseRanges(settings.AnimationBanks); }
            set { settings.AnimationBanks = ToStringCollection(value); }
        }

        // Animation pointer table start (absolute ROM address)
        // Vanilla: 0x252000
        public static int AnimationPointerTable
        {
            get { return settings.AnimationPointerTable; }
            set { settings.AnimationPointerTable = value; }
        }

        // Partition table start (absolute ROM address)
        // Vanilla: 0x1DDE00
        public static int PartitionTableStart
        {
            get { return settings.PartitionTableStart; }
            set { settings.PartitionTableStart = value; }
        }

        // Number of partition entries
        // Vanilla: 120
        public static int PartitionCount
        {
            get { return settings.PartitionCount; }
            set { settings.PartitionCount = value; }
        }

        // Item description write ranges (absolute ROM addresses, bank 0x3A)
        // Vanilla: single range 0x3A3120-0x3A40F1
        public static List<RomRange> ItemDescriptionRanges
        {
            get { return ParseRanges(settings.ItemDescriptionRanges); }
            set { settings.ItemDescriptionRanges = ToStringCollection(value); }
        }

        // Spell description write ranges (absolute ROM addresses, bank 0x3A)
        // Vanilla: single range 0x3A2BB6-0x3A2F20
        public static List<RomRange> SpellDescriptionRanges
        {
            get { return ParseRanges(settings.SpellDescriptionRanges); }
            set { settings.SpellDescriptionRanges = ToStringCollection(value); }
        }

        // Psychopath message write ranges (absolute ROM addresses, bank 0x39)
        // Vanilla: single range 0x39A1D1-0x39B641
        public static List<RomRange> PsychopathMessageRanges
        {
            get { return ParseRanges(settings.PsychopathMessageRanges); }
            set { settings.PsychopathMessageRanges = ToStringCollection(value); }
        }

        // Number of NPC property entries
        // Vanilla: 512
        public static int NPCPropertiesCount
        {
            get { return settings.NPCPropertiesCount; }
            set { settings.NPCPropertiesCount = value; }
        }

        // Number of NPC packets
        // Vanilla: 255
        public static int NPCPacketCount
        {
            get { return settings.NPCPacketCount; }
            set { settings.NPCPacketCount = value; }
        }

        // Whether the custom 0xCE opcode (spell learn) is enabled
        // Vanilla: false (0xCE is unused in vanilla)
        public static bool Enable0xCE
        {
            get { return settings.Enable0xCE; }
            set { settings.Enable0xCE = value; }
        }

        // Computed: total sprite graphics buffer size across all ranges
        public static int SpriteGraphicsTotalSize
        {
            get
            {
                int total = 0;
                foreach (var r in SpriteGraphicsRanges)
                    total += r.Size;
                return total;
            }
        }

        // Computed: first sprite graphics range start address
        public static int SpriteGraphicsBaseAddress
        {
            get
            {
                var ranges = SpriteGraphicsRanges;
                return ranges.Count > 0 ? ranges[0].Start : 0x280000;
            }
        }

        // Animation bank cumulative end indices for assembly
        // Returns the max animation index for each bank (used in Sprites.cs assembly)
        public static int[] AnimationBankEndIndices
        {
            get
            {
                var banks = AnimationBanks;
                // Vanilla: 42, 107, 249, 444
                if (banks.Count == 4)
                    return new int[] { 42, 107, 249, 444 };
                // For custom configs, distribute evenly
                int totalAnims = 444;
                int[] result = new int[banks.Count];
                int perBank = totalAnims / banks.Count;
                for (int i = 0; i < banks.Count; i++)
                    result[i] = Math.Min(totalAnims, (i + 1) * perBank);
                if (result.Length > 0)
                    result[result.Length - 1] = totalAnims;
                return result;
            }
        }

        #region Helper Methods

        public static List<RomRange> ParseRanges(StringCollection sc)
        {
            var list = new List<RomRange>();
            if (sc == null || sc.Count == 0)
                return list;
            foreach (string s in sc)
            {
                if (string.IsNullOrEmpty(s)) continue;
                try { list.Add(RomRange.Parse(s)); }
                catch { }
            }
            return list;
        }

        public static StringCollection ToStringCollection(List<RomRange> ranges)
        {
            var sc = new StringCollection();
            foreach (var r in ranges)
                sc.Add(r.ToString());
            return sc;
        }

        /// <summary>
        /// Applies custom label overrides from a newline-separated string.
        /// Format: one label per line, line number = index (0-based).
        /// Empty lines keep the default.
        /// </summary>
        public static void ApplyCustomLabels(string[] baseArray, string customText)
        {
            if (string.IsNullOrEmpty(customText))
                return;
            string[] lines = customText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length && i < baseArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(lines[i]))
                    baseArray[i] = lines[i];
            }
        }

        #endregion

        #region Config File Save/Load

        /// <summary>
        /// Saves all ROM layout settings to a config file (XML format).
        /// </summary>
        public static void SaveConfigFile(string filePath)
        {
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.IndentChars = "  ";
            xmlSettings.Encoding = Encoding.UTF8;
            using (XmlWriter writer = XmlWriter.Create(filePath, xmlSettings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("LazyShellConfig");
                writer.WriteAttributeString("version", "1");

                // ROM Layout
                writer.WriteStartElement("RomLayout");
                WriteRangeList(writer, "SpriteGraphicsRanges", SpriteGraphicsRanges);
                WriteRangeList(writer, "AnimationBanks", AnimationBanks);
                writer.WriteElementString("AnimationPointerTable", AnimationPointerTable.ToString("X6"));
                writer.WriteElementString("PartitionTableStart", PartitionTableStart.ToString("X6"));
                writer.WriteElementString("PartitionCount", PartitionCount.ToString());
                WriteRangeList(writer, "ItemDescriptionRanges", ItemDescriptionRanges);
                WriteRangeList(writer, "SpellDescriptionRanges", SpellDescriptionRanges);
                WriteRangeList(writer, "PsychopathMessageRanges", PsychopathMessageRanges);
                writer.WriteElementString("NPCPropertiesCount", NPCPropertiesCount.ToString());
                writer.WriteElementString("NPCPacketCount", NPCPacketCount.ToString());
                writer.WriteEndElement(); // RomLayout

                // Advanced
                writer.WriteStartElement("Advanced");
                writer.WriteElementString("Enable0xCE", Enable0xCE.ToString());
                writer.WriteEndElement(); // Advanced

                // Custom Labels
                writer.WriteStartElement("CustomLabels");
                WriteOptionalElement(writer, "SpriteNames", settings.CustomSpriteNames);
                WriteOptionalElement(writer, "EventLabels", settings.CustomEventLabels);
                WriteOptionalElement(writer, "EventDescriptions", settings.CustomEventDescriptions);
                WriteOptionalElement(writer, "ActionLabels", settings.CustomActionLabels);
                WriteOptionalElement(writer, "ActionDescriptions", settings.CustomActionDescriptions);
                WriteOptionalElement(writer, "PacketNames", settings.CustomPacketNames);
                WriteOptionalElement(writer, "EffectNames", settings.CustomEffectNames);
                WriteOptionalElement(writer, "BattleEventNames", settings.CustomBattleEventNames);
                WriteOptionalElement(writer, "LevelNames", settings.CustomLevelNames);
                WriteOptionalElement(writer, "MusicNames", settings.CustomMusicNames);
                WriteOptionalElement(writer, "SoundNames", settings.CustomSoundNames);
                WriteOptionalElement(writer, "BattleSoundNames", settings.CustomBattleSoundNames);
                WriteOptionalElement(writer, "BattlefieldNames", settings.CustomBattlefieldNames);
                writer.WriteEndElement(); // CustomLabels

                writer.WriteEndElement(); // LazyShellConfig
                writer.WriteEndDocument();
            }
        }

        /// <summary>
        /// Loads all ROM layout settings from a config file (XML format).
        /// </summary>
        public static void LoadConfigFile(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode root = doc.SelectSingleNode("LazyShellConfig");
            if (root == null) return;

            // ROM Layout
            XmlNode layout = root.SelectSingleNode("RomLayout");
            if (layout != null)
            {
                var ranges = ReadRangeList(layout, "SpriteGraphicsRanges");
                if (ranges != null) SpriteGraphicsRanges = ranges;

                ranges = ReadRangeList(layout, "AnimationBanks");
                if (ranges != null) AnimationBanks = ranges;

                ReadHexElement(layout, "AnimationPointerTable", v => settings.AnimationPointerTable = v);
                ReadHexElement(layout, "PartitionTableStart", v => settings.PartitionTableStart = v);
                ReadIntElement(layout, "PartitionCount", v => settings.PartitionCount = v);

                ranges = ReadRangeList(layout, "ItemDescriptionRanges");
                if (ranges != null) ItemDescriptionRanges = ranges;

                ranges = ReadRangeList(layout, "SpellDescriptionRanges");
                if (ranges != null) SpellDescriptionRanges = ranges;

                ranges = ReadRangeList(layout, "PsychopathMessageRanges");
                if (ranges != null) PsychopathMessageRanges = ranges;

                ReadIntElement(layout, "NPCPropertiesCount", v => settings.NPCPropertiesCount = v);
                ReadIntElement(layout, "NPCPacketCount", v => settings.NPCPacketCount = v);
            }

            // Advanced
            XmlNode advanced = root.SelectSingleNode("Advanced");
            if (advanced != null)
            {
                XmlNode node = advanced.SelectSingleNode("Enable0xCE");
                if (node != null)
                {
                    bool val;
                    if (bool.TryParse(node.InnerText, out val))
                        settings.Enable0xCE = val;
                }
            }

            // Custom Labels
            XmlNode labels = root.SelectSingleNode("CustomLabels");
            if (labels != null)
            {
                ReadStringElement(labels, "SpriteNames", v => settings.CustomSpriteNames = v);
                ReadStringElement(labels, "EventLabels", v => settings.CustomEventLabels = v);
                ReadStringElement(labels, "EventDescriptions", v => settings.CustomEventDescriptions = v);
                ReadStringElement(labels, "ActionLabels", v => settings.CustomActionLabels = v);
                ReadStringElement(labels, "ActionDescriptions", v => settings.CustomActionDescriptions = v);
                ReadStringElement(labels, "PacketNames", v => settings.CustomPacketNames = v);
                ReadStringElement(labels, "EffectNames", v => settings.CustomEffectNames = v);
                ReadStringElement(labels, "BattleEventNames", v => settings.CustomBattleEventNames = v);
                ReadStringElement(labels, "LevelNames", v => settings.CustomLevelNames = v);
                ReadStringElement(labels, "MusicNames", v => settings.CustomMusicNames = v);
                ReadStringElement(labels, "SoundNames", v => settings.CustomSoundNames = v);
                ReadStringElement(labels, "BattleSoundNames", v => settings.CustomBattleSoundNames = v);
                ReadStringElement(labels, "BattlefieldNames", v => settings.CustomBattlefieldNames = v);
            }

            settings.Save();
        }

        /// <summary>
        /// Resets all ROM layout settings to vanilla defaults.
        /// </summary>
        public static void ResetToDefaults()
        {
            settings.SpriteGraphicsRanges = GetDefaultStringCollection("280000-330000");
            settings.AnimationBanks = GetDefaultAnimationBanks();
            settings.AnimationPointerTable = 0x252000;
            settings.PartitionTableStart = 0x1DDE00;
            settings.PartitionCount = 120;
            settings.ItemDescriptionRanges = GetDefaultStringCollection("3A3120-3A40F1");
            settings.SpellDescriptionRanges = GetDefaultStringCollection("3A2BB6-3A2F20");
            settings.PsychopathMessageRanges = GetDefaultStringCollection("39A1D1-39B641");
            settings.NPCPropertiesCount = 512;
            settings.NPCPacketCount = 255;
            settings.Enable0xCE = false;
            settings.CustomSpriteNames = "";
            settings.CustomEventLabels = "";
            settings.CustomEventDescriptions = "";
            settings.CustomActionLabels = "";
            settings.CustomActionDescriptions = "";
            settings.CustomPacketNames = "";
            settings.CustomEffectNames = "";
            settings.CustomBattleEventNames = "";
            settings.CustomLevelNames = "";
            settings.CustomMusicNames = "";
            settings.CustomSoundNames = "";
            settings.CustomBattleSoundNames = "";
            settings.CustomBattlefieldNames = "";
            settings.Save();
        }

        #region XML Helpers

        private static void WriteRangeList(XmlWriter writer, string name, List<RomRange> ranges)
        {
            writer.WriteStartElement(name);
            foreach (var r in ranges)
                writer.WriteElementString("Range", r.ToString());
            writer.WriteEndElement();
        }

        private static void WriteOptionalElement(XmlWriter writer, string name, string value)
        {
            if (!string.IsNullOrEmpty(value))
                writer.WriteElementString(name, value);
        }

        private static List<RomRange> ReadRangeList(XmlNode parent, string name)
        {
            XmlNode node = parent.SelectSingleNode(name);
            if (node == null) return null;
            var list = new List<RomRange>();
            foreach (XmlNode child in node.SelectNodes("Range"))
            {
                try { list.Add(RomRange.Parse(child.InnerText)); }
                catch { }
            }
            return list.Count > 0 ? list : null;
        }

        private static void ReadHexElement(XmlNode parent, string name, Action<int> setter)
        {
            XmlNode node = parent.SelectSingleNode(name);
            if (node != null)
            {
                int val;
                if (int.TryParse(node.InnerText, System.Globalization.NumberStyles.HexNumber, null, out val))
                    setter(val);
            }
        }

        private static void ReadIntElement(XmlNode parent, string name, Action<int> setter)
        {
            XmlNode node = parent.SelectSingleNode(name);
            if (node != null)
            {
                int val;
                if (int.TryParse(node.InnerText, out val))
                    setter(val);
            }
        }

        private static void ReadStringElement(XmlNode parent, string name, Action<string> setter)
        {
            XmlNode node = parent.SelectSingleNode(name);
            if (node != null)
                setter(node.InnerText);
        }

        private static StringCollection GetDefaultStringCollection(params string[] values)
        {
            var sc = new StringCollection();
            foreach (string v in values)
                sc.Add(v);
            return sc;
        }

        private static StringCollection GetDefaultAnimationBanks()
        {
            var sc = new StringCollection();
            sc.Add("259000-25FFFF");
            sc.Add("260000-26FFFF");
            sc.Add("270000-27FFFF");
            sc.Add("360000-36FFFF");
            return sc;
        }

        #endregion
        #endregion
    }
}
