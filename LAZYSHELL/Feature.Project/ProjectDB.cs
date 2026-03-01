using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LAZYSHELL
{
    [Serializable()]
    public class ProjectDB
    {
        // project information
        private string title; public string Title { get { return title; } set { title = value; } }
        private string author; public string Author { get { return author; } set { author = value; } }
        private string date; public string Date { get { return date; } set { date = value; } }
        private string webpage; public string Webpage { get { return webpage; } set { webpage = value; } }
        private string description; public string Description { get { return description; } set { description = value; } }
        private string generalNotes; public string OtherInfo { get { return generalNotes; } set { generalNotes = value; } }
        // element notes
        private List<EIndex> actionScripts; public List<EIndex> ActionScripts { get { return actionScripts; } set { actionScripts = value; } }
        private List<EIndex> attacks; public List<EIndex> Attacks { get { return attacks; } set { attacks = value; } }
        private List<EIndex> allies; public List<EIndex> Allies { get { return allies; } set { allies = value; } }
        private List<EIndex> battlefields; public List<EIndex> Battlefields { get { return battlefields; } set { battlefields = value; } }
        private List<EIndex> dialogues; public List<EIndex> Dialogues { get { return dialogues; } set { dialogues = value; } }
        private List<EIndex> effects; public List<EIndex> Effects { get { return effects; } set { effects = value; } }
        private List<EIndex> eventScripts; public List<EIndex> EventScripts { get { return eventScripts; } set { eventScripts = value; } }
        private List<EIndex> formations; public List<EIndex> Formations { get { return formations; } set { formations = value; } }
        private List<EIndex> items; public List<EIndex> Items { get { return items; } set { items = value; } }
        private List<EIndex> levels; public List<EIndex> Levels { get { return levels; } set { levels = value; } }
        private List<EIndex> memoryBits; public List<EIndex> MemoryBits { get { return memoryBits; } }
        private List<EIndex> monsters; public List<EIndex> Monsters { get { return monsters; } set { monsters = value; } }
        private List<EIndex> packs; public List<EIndex> Packs { get { return packs; } set { packs = value; } }
        private List<EIndex> shops; public List<EIndex> Shops { get { return shops; } set { shops = value; } }
        private List<EIndex> spells; public List<EIndex> Spells { get { return spells; } set { spells = value; } }
        private List<EIndex> sprites; public List<EIndex> Sprites { get { return sprites; } set { sprites = value; } }
        private List<EIndex> monsterBehaviorAnims; public List<EIndex> MonsterBehaviorAnims { get { return monsterBehaviorAnims; } set { monsterBehaviorAnims = value; } }
        private List<EIndex> battleEvents; public List<EIndex> BattleEvents { get { return battleEvents; } set { battleEvents = value; } }
        private List<EIndex> packets; public List<EIndex> Packets { get { return packets; } set { packets = value; } }
        // ROM layout
        private List<string> spriteGraphicsRanges; public List<string> SpriteGraphicsRanges { get { return spriteGraphicsRanges; } set { spriteGraphicsRanges = value; } }
        private List<string> animationBanks; public List<string> AnimationBanks { get { return animationBanks; } set { animationBanks = value; } }
        private int animationPointerTable; public int AnimationPointerTable { get { return animationPointerTable; } set { animationPointerTable = value; } }
        private int partitionTableStart; public int PartitionTableStart { get { return partitionTableStart; } set { partitionTableStart = value; } }
        private int partitionCount; public int PartitionCount { get { return partitionCount; } set { partitionCount = value; } }
        private List<string> itemDescriptionRanges; public List<string> ItemDescriptionRanges { get { return itemDescriptionRanges; } set { itemDescriptionRanges = value; } }
        private List<string> spellDescriptionRanges; public List<string> SpellDescriptionRanges { get { return spellDescriptionRanges; } set { spellDescriptionRanges = value; } }
        private List<string> psychopathMessageRanges; public List<string> PsychopathMessageRanges { get { return psychopathMessageRanges; } set { psychopathMessageRanges = value; } }
        private int npcPropertiesCount; public int NPCPropertiesCount { get { return npcPropertiesCount; } set { npcPropertiesCount = value; } }
        private int npcPacketCount; public int NPCPacketCount { get { return npcPacketCount; } set { npcPacketCount = value; } }
        // advanced
        private bool enable0xCE; public bool Enable0xCE { get { return enable0xCE; } set { enable0xCE = value; } }
        // element lists
        private List<EList> elists; public List<EList> ELists { get { return elists; } set { elists = value; } }
        // keystrokes
        private string[] keystrokes; public string[] Keystrokes { get { return keystrokes; } set { keystrokes = value; } }
        private string[] keystrokesMenu; public string[] KeystrokesMenu { get { return keystrokesMenu; } set { keystrokesMenu = value; } }
        private string[] keystrokesDesc; public string[] KeystrokesDesc { get { return keystrokesDesc; } set { keystrokesDesc = value; } }
        // constructor
        public ProjectDB()
        {
            // project information
            title = "";
            author = "";
            date = "";
            webpage = "";
            description = "";
            generalNotes = "";
            // element notes
            actionScripts = new List<EIndex>();
            attacks = new List<EIndex>();
            allies = new List<EIndex>();
            battlefields = new List<EIndex>();
            dialogues = new List<EIndex>();
            effects = new List<EIndex>();
            eventScripts = new List<EIndex>();
            formations = new List<EIndex>();
            items = new List<EIndex>();
            levels = new List<EIndex>();
            memoryBits = new List<EIndex>();
            monsters = new List<EIndex>();
            packs = new List<EIndex>();
            shops = new List<EIndex>();
            spells = new List<EIndex>();
            sprites = new List<EIndex>();
            battleEvents = new List<EIndex>();
            monsterBehaviorAnims = new List<EIndex>();
            packets = new List<EIndex>();
            // ROM layout
            spriteGraphicsRanges = new List<string> { "280000-330000" };
            animationBanks = new List<string> { "259000-25FFFF", "260000-26FFFF", "270000-27FFFF", "360000-36FFFF" };
            animationPointerTable = 0x252000;
            partitionTableStart = 0x1DDE00;
            partitionCount = 120;
            itemDescriptionRanges = new List<string> { "3A3120-3A40F1" };
            spellDescriptionRanges = new List<string> { "3A2BB6-3A2F20" };
            psychopathMessageRanges = new List<string> { "39A1D1-39B641" };
            npcPropertiesCount = 512;
            npcPacketCount = 99;
            enable0xCE = false;
            // element lists
            elists = new List<EList>();
            foreach (EList elist in Model.ELists)
                elists.Add(elist.Copy());
            //
            keystrokes = Model.Keystrokes;
            keystrokesMenu = Model.KeystrokesMenu;
            keystrokesDesc = Model.KeystrokesDesc;
        }
        /// <summary>
        /// Fills in vanilla defaults for ROM layout fields that are null/0
        /// (from old .lsproj files deserialized before these fields existed).
        /// </summary>
        public void EnsureRomLayoutDefaults()
        {
            if (spriteGraphicsRanges == null || spriteGraphicsRanges.Count == 0)
                spriteGraphicsRanges = new List<string> { "280000-330000" };
            if (animationBanks == null || animationBanks.Count == 0)
                animationBanks = new List<string> { "259000-25FFFF", "260000-26FFFF", "270000-27FFFF", "360000-36FFFF" };
            if (animationPointerTable == 0)
                animationPointerTable = 0x252000;
            if (partitionTableStart == 0)
                partitionTableStart = 0x1DDE00;
            if (partitionCount == 0)
                partitionCount = 120;
            if (itemDescriptionRanges == null || itemDescriptionRanges.Count == 0)
                itemDescriptionRanges = new List<string> { "3A3120-3A40F1" };
            if (spellDescriptionRanges == null || spellDescriptionRanges.Count == 0)
                spellDescriptionRanges = new List<string> { "3A2BB6-3A2F20" };
            if (psychopathMessageRanges == null || psychopathMessageRanges.Count == 0)
                psychopathMessageRanges = new List<string> { "39A1D1-39B641" };
            if (npcPropertiesCount == 0)
                npcPropertiesCount = 512;
            if (npcPacketCount == 0)
                npcPacketCount = 99;
            if (packets == null)
                packets = new List<EIndex>();
            // Keystrokes: fill from ROM data if empty (e.g. converted from .lscfg)
            if (keystrokes == null || keystrokes.Length == 0)
                keystrokes = Lists.Copy(Lists.Keystrokes);
            if (keystrokesMenu == null || keystrokesMenu.Length == 0)
                keystrokesMenu = Lists.Copy(Lists.KeystrokesMenu);
            if (keystrokesDesc == null || keystrokesDesc.Length == 0)
                keystrokesDesc = Lists.Copy(Lists.KeystrokesDesc);
            // Ensure project has all EList categories that Model.ELists expects
            if (elists == null)
                elists = new List<EList>();
            foreach (EList modelEList in Model.ELists)
            {
                bool found = false;
                foreach (EList projectEList in elists)
                {
                    if (projectEList.Name == modelEList.Name)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    elists.Add(modelEList.Copy());
            }
        }
        // public functions
        public void AddIndex(int index, List<EIndex> arrayList)
        {
            arrayList.Insert(index, new EIndex());
        }
        public void DeleteIndex(int index, List<EIndex> arrayList)
        {
            arrayList.RemoveAt(index);
        }
        public void SwitchIndex(int index, List<EIndex> arrayList)
        {
            arrayList.Reverse(index, 2);
        }
    }
    [Serializable()]
    public class EIndex
    {
        private int index; public int Index { get { return index; } set { index = value; } }
        private string label; public string Label { get { return label; } set { label = value; } }
        private string description; public string Description { get { return description; } set { description = value; } }
        private int address; public int Address { get { return address; } set { address = value; } }
        private int addressBit; public int AddressBit { get { return addressBit; } set { addressBit = value; } }
        public EIndex()
        {
            this.index = 0;
            this.label = "(no label)";
            this.description = "(no description)";
            this.address = 0x7000;
            this.addressBit = 0;
        }
        public EIndex(string label, int index)
        {
            this.index = index;
            this.label = label;
            this.description = "(no description)";
            this.address = 0x7000;
            this.addressBit = 0;
        }
        public EIndex(NotesDB.Index index)
        {
            this.index = index.IndexNumber;
            this.label = index.IndexLabel;
            this.description = index.IndexDescription;
            this.address = index.Address;
            this.addressBit = index.AddressBit;
        }
        public override string ToString()
        {
            return label;
        }
    }
    [Serializable()]
    public class EList
    {
        public string Name;
        public string[] Labels
        {
            get
            {
                string[] labels = new string[Indexes.Length];
                for (int i = 0; i < labels.Length; i++)
                    labels[i] = Indexes[i].Label;
                return labels;
            }
        }
        public EIndex[] Indexes;
        public EList(string name, string[] labels)
        {
            Name = name;
            Indexes = new EIndex[labels.Length];
            for (int i = 0; i < labels.Length; i++)
                Indexes[i] = new EIndex(labels[i], i);
        }
        public EList Copy()
        {
            return new EList(Name, Lists.Copy(Labels));
        }
        public void Reset()
        {
            EList source = Model.ELists.Find(delegate(EList list)
            {
                return list.Name == Name;
            });
            if (source == null)
                return;
            for (int i = 0; i < source.Indexes.Length && i < Indexes.Length; i++)
            {
                Indexes[i].Address = source.Indexes[i].Address;
                Indexes[i].AddressBit = source.Indexes[i].AddressBit;
                Indexes[i].Description = source.Indexes[i].Description;
                Indexes[i].Label = source.Indexes[i].Label;
                Indexes[i].Index = source.Indexes[i].Index;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
