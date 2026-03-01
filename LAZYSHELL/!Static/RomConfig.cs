using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Xml;

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
    /// Reads from Model.Project (ProjectDB) and provides typed properties for use by all editors.
    /// Falls back to vanilla defaults when no project is loaded.
    /// </summary>
    public static class RomConfig
    {
        private static ProjectDB project { get { return Model.Project; } }

        // Sprite BPP graphics ranges (absolute ROM addresses)
        // Vanilla: single range 0x280000-0x330000
        public static List<RomRange> SpriteGraphicsRanges
        {
            get
            {
                if (project != null && project.SpriteGraphicsRanges != null)
                    return ParseRangesFromStrings(project.SpriteGraphicsRanges);
                return new List<RomRange> { new RomRange(0x280000, 0x330000) };
            }
            set
            {
                if (project != null)
                    project.SpriteGraphicsRanges = ToStringList(value);
            }
        }

        // Animation bank ranges (absolute ROM addresses)
        // Vanilla: 4 banks for animation data
        public static List<RomRange> AnimationBanks
        {
            get
            {
                if (project != null && project.AnimationBanks != null)
                    return ParseRangesFromStrings(project.AnimationBanks);
                return new List<RomRange>
                {
                    new RomRange(0x259000, 0x25FFFF),
                    new RomRange(0x260000, 0x26FFFF),
                    new RomRange(0x270000, 0x27FFFF),
                    new RomRange(0x360000, 0x36FFFF)
                };
            }
            set
            {
                if (project != null)
                    project.AnimationBanks = ToStringList(value);
            }
        }

        // Animation pointer table start (absolute ROM address)
        // Vanilla: 0x252000
        public static int AnimationPointerTable
        {
            get { return project != null ? project.AnimationPointerTable : 0x252000; }
            set { if (project != null) project.AnimationPointerTable = value; }
        }

        // Partition table start (absolute ROM address)
        // Vanilla: 0x1DDE00
        public static int PartitionTableStart
        {
            get { return project != null ? project.PartitionTableStart : 0x1DDE00; }
            set { if (project != null) project.PartitionTableStart = value; }
        }

        // Number of partition entries
        // Vanilla: 120
        public static int PartitionCount
        {
            get { return project != null ? project.PartitionCount : 120; }
            set { if (project != null) project.PartitionCount = value; }
        }

        // Item description write ranges (absolute ROM addresses, bank 0x3A)
        // Vanilla: single range 0x3A3120-0x3A40F1
        public static List<RomRange> ItemDescriptionRanges
        {
            get
            {
                if (project != null && project.ItemDescriptionRanges != null)
                    return ParseRangesFromStrings(project.ItemDescriptionRanges);
                return new List<RomRange> { new RomRange(0x3A3120, 0x3A40F1) };
            }
            set
            {
                if (project != null)
                    project.ItemDescriptionRanges = ToStringList(value);
            }
        }

        // Spell description write ranges (absolute ROM addresses, bank 0x3A)
        // Vanilla: single range 0x3A2BB6-0x3A2F20
        public static List<RomRange> SpellDescriptionRanges
        {
            get
            {
                if (project != null && project.SpellDescriptionRanges != null)
                    return ParseRangesFromStrings(project.SpellDescriptionRanges);
                return new List<RomRange> { new RomRange(0x3A2BB6, 0x3A2F20) };
            }
            set
            {
                if (project != null)
                    project.SpellDescriptionRanges = ToStringList(value);
            }
        }

        // Psychopath message write ranges (absolute ROM addresses, bank 0x39)
        // Vanilla: single range 0x39A1D1-0x39B641
        public static List<RomRange> PsychopathMessageRanges
        {
            get
            {
                if (project != null && project.PsychopathMessageRanges != null)
                    return ParseRangesFromStrings(project.PsychopathMessageRanges);
                return new List<RomRange> { new RomRange(0x39A1D1, 0x39B641) };
            }
            set
            {
                if (project != null)
                    project.PsychopathMessageRanges = ToStringList(value);
            }
        }

        // Number of NPC property entries
        // Vanilla: 512
        public static int NPCPropertiesCount
        {
            get { return project != null ? project.NPCPropertiesCount : 512; }
            set { if (project != null) project.NPCPropertiesCount = value; }
        }

        // Number of NPC packets
        // Vanilla: 99
        public static int NPCPacketCount
        {
            get { return project != null ? project.NPCPacketCount : 99; }
            set { if (project != null) project.NPCPacketCount = value; }
        }

        // Whether the custom 0xCE opcode (spell learn) is enabled
        // Vanilla: false (0xCE is unused in vanilla)
        public static bool Enable0xCE
        {
            get { return project != null ? project.Enable0xCE : false; }
            set { if (project != null) project.Enable0xCE = value; }
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

        public static List<RomRange> ParseRangesFromStrings(List<string> strings)
        {
            var list = new List<RomRange>();
            if (strings == null || strings.Count == 0)
                return list;
            foreach (string s in strings)
            {
                if (string.IsNullOrEmpty(s)) continue;
                try { list.Add(RomRange.Parse(s)); }
                catch { }
            }
            return list;
        }

        public static List<string> ToStringList(List<RomRange> ranges)
        {
            var list = new List<string>();
            foreach (var r in ranges)
                list.Add(r.ToString());
            return list;
        }

        // Keep for backwards compatibility with old code paths
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

                writer.WriteEndElement(); // LazyShellConfig
                writer.WriteEndDocument();
            }
        }

        /// <summary>
        /// Loads all ROM layout settings from a config file (XML format).
        /// </summary>
        public static void LoadConfigFile(string filePath)
        {
            if (project == null) return;

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

                ReadHexElement(layout, "AnimationPointerTable", v => project.AnimationPointerTable = v);
                ReadHexElement(layout, "PartitionTableStart", v => project.PartitionTableStart = v);
                ReadIntElement(layout, "PartitionCount", v => project.PartitionCount = v);

                ranges = ReadRangeList(layout, "ItemDescriptionRanges");
                if (ranges != null) ItemDescriptionRanges = ranges;

                ranges = ReadRangeList(layout, "SpellDescriptionRanges");
                if (ranges != null) SpellDescriptionRanges = ranges;

                ranges = ReadRangeList(layout, "PsychopathMessageRanges");
                if (ranges != null) PsychopathMessageRanges = ranges;

                ReadIntElement(layout, "NPCPropertiesCount", v => project.NPCPropertiesCount = v);
                ReadIntElement(layout, "NPCPacketCount", v => project.NPCPacketCount = v);
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
                        project.Enable0xCE = val;
                }
            }
        }

        /// <summary>
        /// Resets all ROM layout settings to vanilla defaults.
        /// </summary>
        public static void ResetToDefaults()
        {
            if (project == null) return;
            project.SpriteGraphicsRanges = new List<string> { "280000-330000" };
            project.AnimationBanks = new List<string> { "259000-25FFFF", "260000-26FFFF", "270000-27FFFF", "360000-36FFFF" };
            project.AnimationPointerTable = 0x252000;
            project.PartitionTableStart = 0x1DDE00;
            project.PartitionCount = 120;
            project.ItemDescriptionRanges = new List<string> { "3A3120-3A40F1" };
            project.SpellDescriptionRanges = new List<string> { "3A2BB6-3A2F20" };
            project.PsychopathMessageRanges = new List<string> { "39A1D1-39B641" };
            project.NPCPropertiesCount = 512;
            project.NPCPacketCount = 99;
            project.Enable0xCE = false;
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

        #endregion
        #endregion
    }
}
