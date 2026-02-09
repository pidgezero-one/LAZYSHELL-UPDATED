using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Net.PeerToPeer.Collaboration;
using System.Security.Cryptography;
using System.Timers;

namespace LAZYSHELL
{
    public static class Lists
    {
        #region Variables
        #region Other
        public static string[] ShopNames = new string[]
        {
            "Mushroom Kingdom",
            "Rose Town Items",
            "Rose Town Armor",
            "Frog Disciple Shop",
            "Moleville Shop",
            "Marrymore Shop",
            "Frog Coin Emporium",
            "Sea Item shop",
            "Seaside Town Items (pre-Yaridovich)",
            "Juice Bar (no card)",
            "Juice Bar (alto card)",
            "Juice Bar (tenor card)",
            "Juice Bar (soprano card)",
            "Seaside Weapons",
            "Seaside Armor",
            "Seaside Accessory",
            "Seaside Health Foods",
            "Monstro Town shop",
            "Hinopio's Item Shop",
            "Hinopio's Armor Shop",
            "Baby Goomba shop",
            "Nimbus Land Shop",
            "Croco's Shop 1",
            "Croco's Shop 2",
            "Toad's Shop",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY"
        };
        public static string[] AnimationCommands = new string[]
        {
            "New object: sprite = {xx}, coords (AMEM $32)",			// 0x00
            "AMEM $32 = coords (x,y,z)",			// 0x01
            "Exit battle",			// 0x02
            "Sprite = {xx}, coords (AMEM $32)",			// 0x03
            "Pause script until...",			// 0x04
            "Remove object",			// 0x05
            "{06}",			// 0x06
            "Return object queue",			// 0x07
            "Move object: speed = {xx}",			// 0x08
            "Jump to address $xxxx",			// 0x09
            "Pause script for 1 frame",			// 0x0A
            "AMEM $40 = coords (x,y,z)",			// 0x0B
            "Move sprite to coords (AMEM $40)",			// 0x0C
            "{0D}",			// 0x0D
            "Reset target mapping memory",			// 0x0E
            "Reset object mapping memory",			// 0x0F
			
            "Jump to subroutine $xxxx",			// 0x10
            "Return subroutine",			// 0x11
            "{12}",			// 0x12
            "{13}",			// 0x13
            "{14}",			// 0x14
            "{15}",			// 0x15
            "{16}",			// 0x16
            "{17}",			// 0x17
            "{18}",			// 0x18
            "{19}",			// 0x19
            "Visibility on",			// 0x1A
            "Visibility off",			// 0x1B
            "{1C}",			// 0x1C
            "{1D}",			// 0x1D
            "{1E}",			// 0x1E
            "{1F}",			// 0x1F
			
            "AMEM (8-bit) $xx = variable {xx}",			// 0x20
            "AMEM (16-bit) $xx = variable {xx}",			// 0x21
            "Variable {xx} = AMEM (8-bit) $xx",			// 0x22
            "Variable {xx} = AMEM (16-bit) $xx",			// 0x23
            "If AMEM (8-bit) $xx = {xx} ...",			// 0x24
            "If AMEM (16-bit) $xx = {xx} ...",			// 0x25
            "If AMEM (8-bit) $xx != {xx} ...",			// 0x26
            "If AMEM (16-bit) $xx != {xx} ...",			// 0x27
            "If AMEM (8-bit) $xx < {xx} ...",			// 0x28
            "If AMEM (16-bit) $xx < {xx} ...",			// 0x29
            "If AMEM (8-bit) $xx >= {xx} ...",			// 0x2A
            "If AMEM (16-bit) $xx >= {xx} ...",			// 0x2B
            "AMEM (8-bit) $xx += {xx}",			// 0x2C
            "AMEM (16-bit) $xx += {xx}",			// 0x2D
            "AMEM (8-bit) $xx -= {xx}",			// 0x2E
            "AMEM (16-bit) $xx -= {xx}",			// 0x2F
			
            "Increment AMEM (8-bit) $xx",			// 0x30
            "Increment AMEM (16-bit) $xx",			// 0x31
            "Decrement AMEM (8-bit) $xx",			// 0x32
            "Decrement AMEM (16-bit) $xx",			// 0x33
            "Clear AMEM (8-bit) $xx",			// 0x34
            "Clear AMEM (16-bit) $xx",			// 0x35
            "Set AMEM $xx bits {xx}",			// 0x36
            "Clear AMEM $xx bits {xx}",			// 0x37
            "If AMEM $xx bits {xx} set...",			// 0x38
            "If AMEM $xx bits {xx} clear...",			// 0x39
            "Attack timer begins",			// 0x3A
            "{3B}",			// 0x3B
            "{3C}",			// 0x3C
            "{3D}",			// 0x3D
            "{3E}",			// 0x3E
            "{3F}",			// 0x3F
			
            "Pause script until AMEM $xx bits {xx} set",			// 0x40
            "Pause script until AMEM $xx bits {xx} clear",			// 0x41
            "{42}",			// 0x42
            "Sprite sequence = {xx}",			// 0x43
            "{44}",			// 0x44
            "AMEM $60 = current target",			// 0x45
            "Check ally mortal status, if all allies down set game over",			// 0x46
            "Object queue [$offset] index = AMEM $xx",			// 0x47
            "{48}",			// 0x48
            "{49}",			// 0x49
            "{4A}",			// 0x4A
            "{4B}",			// 0x4B
            "{4C}",			// 0x4C
            "{4D}",			// 0x4D
            "Pause script until sprite sequence done",			// 0x4E
            "{4F}",			// 0x4F
			
            "If target disabled, jump to address $xxxx",			// 0x50
            "If target alive, jump to address $xxxx",			// 0x51
            "{52}",			// 0x52
            "{53}",			// 0x53
            "{54}",			// 0x54
            "{55}",			// 0x55
            "{56}",			// 0x56
            "{57}",			// 0x57
            "{58}",			// 0x58
            "{59}",			// 0x59
            "{5A}",			// 0x5A
            "{5B}",			// 0x5B
            "{5C}",			// 0x5C
            "Sprite queue [$offset] (sprite = {xx})",			// 0x5D
            "Return sprite queue",			// 0x5E
            "{5F}",			// 0x5F
			
            "{60}",			// 0x60
            "{61}",			// 0x61
            "{62}",			// 0x62
            "Display {xx} message @ OMEM $60",			// 0x63
            "Object queue [$offset] index = AMEM $60",			// 0x64
            "{65}",			// 0x65
            "{66}",			// 0x66
            "{67}",			// 0x67
            "Object queue [$offset, AMEM $60] index = {xx}",			// 0x68
            "OMEM $60 = memory $072C",			// 0x69
            "AMEM $xx = random # between 0 and {xx}",			// 0x6A
            "AMEM $xx = random # between 0 and {xx}",			// 0x6B
            "{6C}",			// 0x6C
            "{6D}",			// 0x6D
            "{6E}",			// 0x6E
            "{6F}",			// 0x6F
			
            "Overlap all",			// 0x70
            "Overlap none",			// 0x71
            "New object: effect = ...",			// 0x72
            "Pause script for 2 frames",			// 0x73
            "Pause script until {xx} complete...",			// 0x74
            "Pause script until bits clear...",			// 0x75
            "Clear effect index",			// 0x76
            "L3 on...",			// 0x77
            "L3 off...",			// 0x78
            "{79}",			// 0x79
            "Display message...",			// 0x7A
            "Pause script until dialogue closed",			// 0x7B
            "{7C}",			// 0x7C
            "{7D}",			// 0x7D
            "Fade out object, duration = ...",			// 0x7E
            "Reset sprite sequence",			// 0x7F
			
            "Shine effect...",			// 0x80
            "{81}",			// 0x81
            "{82}",			// 0x82
            "{83}",			// 0x83
            "{84}",			// 0x84
            "Fade object {xx}, amount = ...",			// 0x85
            "Shake object...",			// 0x86
            "Stop shaking object",			// 0x87
            "{88}",			// 0x88
            "{89}",			// 0x89
            "{8A}",			// 0x8A
            "{8B}",			// 0x8B
            "{8C}",			// 0x8C
            "{8D}",			// 0x8D
            "Screen flash {xx} color, duration = ...",			// 0x8E
            "Screen flash {xx} color",			// 0x8F
			
            "{90}",			// 0x90
            "{91}",			// 0x91
            "{92}",			// 0x92
            "{93}",			// 0x93
            "{94}",			// 0x94
            "Initialize bonus message sequence",			// 0x95
            "Display bonus message...",			// 0x96
            "Pause script until bonus message complete",			// 0x97
            "{98}",			// 0x98
            "{99}",			// 0x99
            "{9A}",			// 0x9A
            "{9B}",			// 0x9B
            "Battlefield wavy effect...",			// 0x9C
            "Stop battlefield wavy effect",			// 0x9D
            "{9E}",			// 0x9E
            "{9F}",			// 0x9F
			
            "{A0}",			// 0xA0
            "{A1}",			// 0xA1
            "{A2}",			// 0xA2
            "Screen effect...",			// 0xA3
            "{A4}",			// 0xA4
            "{A5}",			// 0xA5
            "{A6}",			// 0xA6
            "On Successfully Timed-Hit, jump to address $xxxx",			// 0xA7
            "{A8}",			// 0xA8
            "{A9}",			// 0xA9
            "{AA}",			// 0xAA
            "Play sound (ch.6,7)...",			// 0xAB
            "{AC}",			// 0xAC
            "{AD}",			// 0xAD
            "Play sound (ch.4,5)...",			// 0xAE
            "{AF}",			// 0xAF
			
            "Play music {xx} (current volume)",			// 0xB0
            "Play music {xx} (volume = {xx})",			// 0xB1
            "Stop current sound effect",			// 0xB2
            "{B3}",			// 0xB3
            "{B4}",			// 0xB4
            "{B5}",			// 0xB5
            "Fade out current music to {xx} volume...",			// 0xB6
            "{B7}",			// 0xB7
            "{B8}",			// 0xB8
            "{B9}",			// 0xB9
            "{BA}",			// 0xBA
            "Set target...",			// 0xBB
            "Modify item inventory...",			// 0xBC
            "Modify special item inventory...",			// 0xBD
            "Coins += ...",			// 0xBE
            "Store to item inventory {xx}'s Yoshi Cookie",			// 0xBF
			
            "{C0}",			// 0xC0
            "{C1}",			// 0xC1
            "{C2}",			// 0xC2
            "Mask effect...",			// 0xC3
            "{C4}",			// 0xC4
            "{C5}",			// 0xC5
            "Mask coords = ...",			// 0xC6
            "{C7}",			// 0xC7
            "{C8}",			// 0xC8
            "{C9}",			// 0xC9
            "{CA}",			// 0xCA
            "Sprite sequence speed = ...",			// 0xCB
            "Start tracking for Ally Button Timing",			// 0xCC
            "End tracking for Ally Button Timing",			// 0xCD
            "Timing for One Button Press: Just-OK/Perfect range",			// 0xCE
            "Timing for One Button Press: Any timing range",			// 0xCF
            "Timing for Multiple Button Presses: Wait # frames, then jump",			// 0xD0
            "Timing for Button Mash: ???",			// 0xD1
            "Timing for Button Mash: Possible Power-ups range",			// 0xD2
            "Timing for Rotation: Frame range, Possible Power-ups range",			// 0xD3
            "Timing for Held Button: Hold for frame range",			// 0xD4

            "Summon monster...",			// 0xD5
            "{D6}",			// 0xD6
            "{D7}",			// 0xD7
            "Timing for Mute: ??? then jump",			// 0xD8
            "Display \"Can\'t run\" dialogue",			// 0xD9
            "{DA}",			// 0xDA
            "{DB}",			// 0xDB
            "{DC}",			// 0xDC
            "{DD}",			// 0xDD
            "{DE}",			// 0xDE
            "{DF}",			// 0xDF
			
            "Store OMEM $60 to item inventory",			// 0xE0
            "Run battle event...",			// 0xE1
            "{E2}",			// 0xE2
            "{E3}",			// 0xE3
            "{E4}",			// 0xE4
            "{E5}",			// 0xE5
            "{E6}",			// 0xE6
            "{E7}",			// 0xE7
            "{E8}",			// 0xE8
            "{E9}",			// 0xE9
            "{EA}",			// 0xEA
            "{EB}",			// 0xEB
            "{EC}",			// 0xEC
            "{ED}",			// 0xED
            "{EE}",			// 0xEE
            "{EF}",			// 0xEF
			
            "{F0}",			// 0xF0
            "{F1}",			// 0xF1
            "{F2}",			// 0xF2
            "{F3}",			// 0xF3
            "{F4}",			// 0xF4
            "{F4}",			// 0xF4
            "{F6}",			// 0xF6
            "{F7}",			// 0xF7
            "{F8}",			// 0xF8
            "{F9}",			// 0xF9
            "{FA}",			// 0xFA
            "{FB}",			// 0xFB
            "{FC}",			// 0xFC
            "{FD}",			// 0xFD
            "{FE}",			// 0xFE
            "{FF}"			// 0xFF
        };
        public static string[] Tutorials = new string[]
        {
            "How to equip",
            "How to use items",
            "How to switch allies",
            "How to play beetle mania"
        };
        public static string[] EntranceNames = new string[]
        {
            "no movement for \"Escape\"",
            "slide backward when hit",
            "Bowser Clone sprite",
            "Mario Clone sprite",
            "no reaction when hit",
            "sprite shadow",
            "floating, sprite shadow",
            "floating",
            "floating, slide backward when hit",
            "floating, slide backward when hit",
            "fade out death, floating",
            "fade out death",
            "fade out death",
            "fade out death, Smithy spell cast",
            "fade out death, no \"Escape\" movement",
            "fade out death, no \"Escape\" transition",
            "(normal)",
            "no reaction when hit"
        };
        public static string[] CoinSizes = new string[]
        {
            "none","small","big"
        };
        public static string[] SpriteBehaviors = new string[] {
            "no movement for \"Escape\"",
            "slide backward when hit",
            "Bowser Clone sprite",
            "Mario Clone sprite",
            "no reaction when hit",
            "sprite shadow",
            "floating, sprite shadow",
            "floating",
            "floating, slide backward when hit",
            "floating, slide backward when hit",
            "fade out death, floating",
            "fade out death",
            "fade out death",
            "fade out death, Smithy spell cast",
            "fade out death, no \"Escape\" movement",
            "fade out death, no \"Escape\" transition",
            "(normal)",
            "no reaction when hit"
        };
        public static string[] MonsterSoundStrike = new string[]
        {
            "bite",
            "pierce",
            "claw",
            "blade",
            "slap",
            "knock",
            "smash",
            "wallop 2",
            "wallop",
            "bonk",
            "flopping hit",
            "wallop 3",
            "wallop 4",
            "wallop 4"
        };
        public static string[] MonsterSoundOther = new string[]
        {
            "none",
            "Starslap, Spikey, Enigma",
            "Sparky, Goomba, Birdy",
            "Amanita, Terrapin",
            "Guerilla",
            "Pulsar",
            "Dry Bones",
            "Torte"
        };
        public static string[] CharacterNames
        {
            get
            {
                string[] characterNames = new string[Model.Characters.Length];
                for (int i = 0; i < Model.Characters.Length; i++)
                    characterNames[i] = Model.CharacterNames.GetUnsortedName(i);
                return characterNames;
            }
        }
        public static string[] SpellNames = new string[]
        {
            "Jump",
            "Fire Orb",
            "Super Jump",
            "Super Flame",
            "Ultra Jump",
            "Ultra Flame",
            "Therapy",
            "Group Hug",
            "Sleepy Time",
            "Come Back",
            "Mute",
            "Psych Bomb",
            "Terrorize",
            "Poison Gas",
            "Crusher",
            "Bowser Crush",
            "Geno Beam",
            "Geno Boost",
            "Geno Whirl",
            "Geno Blast",
            "Geno Flash",
            "Thunderbolt",
            "HP Rain",
            "Psychopath",
            "Shocker",
            "Snowy",
            "Star Rain"
        };
        public static string[] ButtonNames = new string[]
        {
            "left", "right", "down", "up", "X", "A", "Y", "B"
        };
        public static string[] Directions = new string[]
        {
            "east","southeast","south","southwest",
            "west","northwest","north","northeast"
        };
        public static string[] ColorNames = new string[]
        {
            "black", "blue", "red", "pink", "green", "aqua", "yellow", "white"
        };
        public static string[] LayerNames = new string[]
        {
            "L1", "L2", "L3", "L4", "NPC", "BG", "½ intensity", "Minus sub"
        };
        public static string[] MenuNames = new string[]
        {
            "open game select menu",
            "open overworld menu",
            "open location",
            "open shop menu",
            "open save game menu",
            "open items maxed out menu",
            "UNKNOWN",
            "run menu tutorial",
            "add star piece",
            "run Moleville Mountain",
            "close menu and refresh VRAM",
            "run Moleville Mountain intro",
            "close menu and refresh VRAM",
            "run star piece end sequence",
            "run garden intro sequence",
            "enter gate to Smithy Factory",
            "run world map event sequence"
        };
        #endregion
        #region Maps
        public static string[] WorldMapNames = new string[]
        {
            "Bowser\'s Keep",
            "Mushroom Kingdom",
            "Rose Town",
            "Booster Tower",
            "Seaside Town",
            "Land\'s End",
            "Nimbus Land",
            "Barrel Volcano",
            "Yo\'ster Isle"
        };
        public static string[] MapNames = new string[]
        {
            "To Mario's Pad (before)",
            "Bowser's Keep (before)",
            "To Mario's Pad",
            "Vista Hill",
            "Bowser's Keep",
            "Gate",
            "To Nimbus Land",
            "To Bowser's Keep",
            "Mario's Pad",
            "Mushroom Way",
            "Mushroom Kingdom",
            "Bandit's Way",
            "Kero Sewers",
            "To Mushroom Kingdom",
            "Kero Sewers",
            "Midas River",
            "Tadpole Pond",
            "Rose Way",
            "Rose Town",
            "Forest Maze",
            "Pipe Vault",
            "To Yo'ster Isle",
            "To Moleville",
            "To Pipe Vault",
            "Moleville",
            "Booster Pass",
            "Booster Tower",
            "Booster Hill",
            "Marrymore",
            "To Star Hill",
            "To Marrymore",
            "Star Hill",
            "Seaside Town",
            "Sea",
            "Sunken Ship",
            "To Land's End",
            "To Seaside Town",
            "Land's End",
            "Monstro Town",
            "Bean Valley",
            "Grate Guy's Casino",
            "To Nimbus Land",
            "To Seaside Town",
            "Land's End",
            "Monstro Town",
            "Bean Valley",
            "Grate Guy's Casino",
            "To Nimbus Land",
            "To Bean Valley",
            "Nimbus Land",
            "Barrel Volcano",
            "To Bowser's Keep",
            "Yo'ster Isle",
            "To Pipe Vault",
            "Coal Mines (Bowser's Keep)",
            "Factory (Bowser's Keep)"
        };
        public static string[] objectNames = new string[]
        {
            "Mario",// 0x00
            "Toadstool",			// 0x01
            "Bowser",			// 0x02
            "Geno",// 0x03
            "Mallow",			// 0x04
            "DUMMY 0x05",			// 0x05
            "DUMMY 0x06",			// 0x06
            "DUMMY 0x07",			// 0x07
            "Character in Slot 1",// 0x08
            "Character in Slot 2",// 0x09
            "Character in Slot 3",// 0x0A
            "DUMMY 0x0B",			// 0x0B
            "Screen Focus",			// 0x0C
            "Layer 1",			// 0x0D
            "Layer 2",			// 0x0E
            "Layer 3",			// 0x0F
            			
            "Mem $70A8",			// 0x10
            "Mem $70A9",			// 0x11
            "Mem $70AA",			// 0x12
            "Mem $70AB",			// 0x13
            "NPC #0",			// 0x14
            "NPC #1",			// 0x15
            "NPC #2",			// 0x16
            "NPC #3",			// 0x17
            "NPC #4",			// 0x18
            "NPC #5",			// 0x19
            "NPC #6",			// 0x1A
            "NPC #7",			// 0x1B
            "NPC #8",			// 0x1C
            "NPC #9",			// 0x1D
            "NPC #10",			// 0x1E
            "NPC #11",			// 0x1F
            			
            "NPC #12",			// 0x20
            "NPC #13",			// 0x21
            "NPC #14",			// 0x22
            "NPC #15",			// 0x23
            "NPC #16",			// 0x24
            "NPC #17",			// 0x25
            "NPC #18",			// 0x26
            "NPC #19",			// 0x27
            "NPC #20",			// 0x28
            "NPC #21",			// 0x29
            "NPC #22",			// 0x2A
            "NPC #23",			// 0x2B
            "NPC #24",			// 0x2C
            "NPC #25",			// 0x2D
            "NPC #26",			// 0x2E
            "NPC #27"			// 0x2F
        };

        public static string[] ObjectNames
        {
            get
            {
                for (int i = 0; i < Model.Characters.Length; i++)
                    objectNames[i] = Model.CharacterNames.GetUnsortedName(i);
                return objectNames;
            }
        }
        #endregion
        #region Audio
        public static int[] SMWSamples = new int[]{
            82, 65, 104,78, 44, 66, 23, 96, 100,56,
            18, 65, 109,39, 101,17, 38, 113,65, 0,
            0,  51, 52, 53, 67, 67, 51, 51, 51, 69
        };
        public static int[] SMWPercussives = new int[]{
            -1,-1,-1,-1,-1,-1,-1,-1,-1,-1,
            0, -1,1, -1,-1,-1,-1,-1,-1,-1,
            -1,2, 3, 4, 5, 6, 7, 8, -1,9
        };
        public static int[] SMWOctaveLimits = new int[]{
            5,6,6,6,4,5,6,5,5,5,
            4,6,6,5,5,6,6,6,4,4,
            4,4,4,4,4,4,4,4,4,4
        };
        public static bool[] SMRPGPercussives = new bool[]
        {
            false,false,false,false,false,false,false,false,false,false,
            false,false,false,false,false,false,false,false,true, false,
            false,false,false,false,false,true, true, false,false,false,
            false,false,true, true, true, true, false,false,false,false,
            false,false,true, true, false,true, true, true, false,false,
            false,true, true, true, true, false,false,false,false,false,
            true, true, true, false,false,false,false,true, true, true,
            false,false,true, true, false,true, true, true, false,true,
            true, true, false,false,true, false,false,false,false,false,
            false,true, false,false,false,false,false,true, true, true,
            false,false,false,false,false,false,true, true, true, true,
            false,false,false,false,true, false
        };
        public static int[] SMRPGtoSMWSamples = new int[]{
          /*0   1   2   3   4   5   6   7   8   9*/
            29, 29, 29, 29, 29, 29, 29, 29, 29, 29,  // 0
            29, 29, 29, 29, 29, 29, 29, 15, 10, 0,   // 10
            8,  6,  0,  6,  6,  26, 25, 0,  0,  6,   // 20
            0,  11, 15, 23, 2,  22, 22, 26, 16, 13,  // 30
            13, 9,  10, 10, 6,  26, 28, 12, 29, 0,   // 40
            11, 27, 23, 23, 26, 3,  9,  9,  29, 1,   // 50
            10, 10, 12, 11, 2,  1,  5,  24, 26, 10,  // 60
            8,  1,  23, 10, 13, 23, 12, 12, 3,  10,  // 70
            0,  25, 0,  6,  23, 0,  29, 9,  4,  4,   // 80
            10, 12, 8,  16, 6,  0,  7,  23, 23, 25,  // 90
            8,  14, 11, 2,  2,  2,  29, 12, 12, 12,  // 100
            17, 29, 29, 17, 30, 5
        };
        public static string[] SPCCommands = new string[]
        {
            "Note",
            "Note, duration = ",
            "Octave up",
            "Octave down",
            "Octave = ",
            "Slur next note",
            "Noise on, channels = ",
            "Noise on, all channels",
            "Noise off",
            "Frequency mode on",
            "Frequency mode off",
            "Play channel 0 of SFX = ",
            "Play channel 1 of SFX = ",
            "Transpose 1/16 pitch = ",
            "Terminate script",
            "Beat duration = ",
            "Audio memory $69 = ",
            "{D3-xx}",
            "Begin repeat",
            "End repeat",
            "Repeat ending start",
            "Begin infinite repeat",
            "ADSR reset",
            "ADSR attack = ",
            "ADSR decay = ",
            "ADSR sustain = ",
            "ADSR release = ",
            "Sample length = ",
            "Sample = ",
            "Noise transpose, pitch = ",
            "Sample fadeout = ",
            "{E1-xx}",
            "Volume = ",
            "Volume shift, amount = ",
            "Volume slide, duration = ",
            "Portamento, duration = ",
            "Portamento looping",
            "Speaker balance = ",
            "Pansweep, duration = ",
            "Pansweep loop, duration = ",
            "{EA}",
            "{EB}",
            "Transpose 1/4 pitch from 0 = ",
            "Transpose 1/4 pitch = ",
            "Percussion mode on",
            "Percussion mode off",
            "Tremolo = ",
            "Vibrato = ",
            "Beat duration, change = ",
            "Vibrato off",
            "Growling, roughness = ",
            "{F5}",
            "Portamento on = ",
            "Growling off",
            "Dizziness on",
            "Dizziness off",
            "Reverb on",
            "Reverb off",
            "Reverb = ",
            "{FD}",
            "{FE}",
            "{FF}"
        };
        public static string[] Pitches = new string[]
        {
            "C0",
            "C#0",
            "D0",
            "D#0",
            "E0",
            "F0",
            "F#0",
            "G0",
            "G#0",
            "A0",
            "A#0",
            "B0",
            "C1",
            "C#1",
            "D1",
            "D#1",
            "E1",
            "F1",
            "F#1",
            "G1",
            "G#1",
            "A1",
            "A#1",
            "B1",
            "C2",
            "C#2",
            "D2",
            "D#2",
            "E2",
            "F2",
            "F#2",
            "G2",
            "G#2",
            "A2",
            "A#2",
            "B2",
            "C3",
            "C#3",
            "D3",
            "D#3",
            "E3",
            "F3",
            "F#3",
            "G3",
            "G#3",
            "A3",
            "A#3",
            "B3",
            "C4",
            "C#4",
            "D4",
            "D#4",
            "E4",
            "F4",
            "F#4",
            "G4",
            "G#4",
            "A4",
            "A#4",
            "B4",
            "C5",
            "C#5",
            "D5",
            "D#5",
            "E5",
            "F5",
            "F#5",
            "G5",
            "G#5",
            "A5",
            "A#5",
            "B5",
            "C6",
            "C#6",
            "D6",
            "D#6",
            "E6",
            "F6",
            "F#6",
            "G6",
            "G#6",
            "A6",
            "A#6",
            "B6",
            "C7",
            "C#7",
            "D7",
            "D#7",
            "E7",
            "F7",
            "F#7",
            "G7",
            "G#7",
            "A7",
            "A#7",
            "B7",
            "C8",
            "C#8",
            "D8",
            "D#8",
            "E8",
            "F8",
            "F#8",
            "G8",
            "G#8",
            "A8",
            "A#8",
            "B8"
        };
        public static string[] SampleNames = new string[]
        {
            "SOUND FX",
            "SOUND FX",
            "SOUND FX",
            "SOUND FX",
            "SOUND FX",
            "SOUND FX",
            "SOUND FX",
            "SOUND FX",
            "SOUND FX",
            "SOUND FX: shell kick",
            "SILENCE",
            "SILENCE",
            "SILENCE",
            "SILENCE",
            "SILENCE",
            "SILENCE",
            "Timpani",
            "Orchestra Hit",
            "Snare",
            "Clarinet",
            "Synth Bass",
            "Baritone Sax",
            "Bassoon",
            "Muted Trumpet",
            "Brass Section",
            "Metronome 1",
            "Metronome 2",
            "Oboe",
            "Bassoon",
            "Tuba",
            "Flute",
            "String Section 1",
            "DJ scratch",
            "Tambourine",
            "Bell",
            "Drum & cymbal",
            "Crash Cymbal",
            "Synth Drum",
            "Harp 1",
            "Harp 2",
            "Pizzicato",
            "Old Piano",
            "Fat Snare",
            "Drum Roll",
            "Trumpet",
            "Slap",
            "Melodic Tom",
            "Drum",
            "Jungle Drums Riff",
            "Pipe",
            "Accordion",
            "Bass Drum",
            "Pedal Hi-Hat",
            "Closed Hi-Hat",
            "Clap",
            "Marimba",
            "Honky Tonk Piano 1",
            "Honky Tonk Piano 2",
            "Square",
            "Sawtooth",
            "Drum",
            "Gated Snare",
            "Tap",
            "Choir Aahs",
            "Celesta",
            "Violin",
            "Clean Guitar",
            "Woodblock",
            "Kick Drum",
            "Snare",
            "Synth Bass",
            "Electric Violin",
            "Open Hi-Hat",
            "Shaker",
            "Electric Piano",
            "Maraca",
            "Tom-tom 1",
            "Tom-tom 2",
            "Xylophone",
            "Drum",
            "Pea Whistle",
            "Cowbell",
            "Recorder",
            "French Horn",
            "Open Hi-Hat",
            "Synth Rain",
            "Synth Orchestra",
            "Acoustic Piano",
            "Organ",
            "Cello",
            "Drum",
            "Drum",
            "Bass Guitar",
            "Pizzicato",
            "Saxophone",
            "Flute",
            "Steel Drums",
            "Guiro 1",
            "Guiro 2",
            "Agogo",
            "Acoustic Bass Guitar",
            "Fretless Bass",
            "String Section 2",
            "Bell",
            "Glockenspiel",
            "Vibraphone",
            "Seashore",
            "Dry Tom",
            "Tap",
            "Tom-tom",
            "Lead Guitar",
            "Laugh 1",
            "Laugh 2",
            "Distortion Guitar",
            "Metal Hammer",
            "Harpsichord"
        };
        public static string[] MusicNames = new string[]
        {
            "{CURRENT}",
            "Dodo\'s Coming",
            "Mushroom Kingdom",
            "Fight Against Stronger Monster",
            "Yo\'ster Island",
            "Seaside Town",
            "Fight Against Monsters",
            "Pipe Vault",
            "Invincible Star",
            "Victory",
            "In The Flower Garden",
            "Bowser\'s Castle (1st time)",
            "Fight Against Bowser",
            "Road Is Full Of Dangers",
            "Mario\'s Pad",
            "Here\'s Some Weapons",
            "Let\'s Race",
            "Tadpole Pond",
            "Rose Town",
            "Race Training",
            "Shock!",
            "Sad Song",
            "Midas River",
            "Got A Star Piece (part 1)",
            "Got A Star Piece (part 2)",
            "Fight Against An Armed Boss",
            "Forest Maze",
            "Dungeon Is Full Of Monsters",
            "Let\'s Play Geno",
            "Start Slot Menu",
            "Long Long Ago",
            "Booster\'s Tower",
            "And My Name\'s Booster",
            "Moleville",
            "Star Hill",
            "Mountain Railroad",
            "Explanation",
            "Booster Hill (start)",
            "Booster Hill",
            "Marrymore",
            "New Partner",
            "Sunken Ship",
            "Still The Road Is Full Of Monsters",
            "{SILENCE}",
            "Sea",
            "Heart Beating A Little Faster (part 1)",
            "Heart Beating A Little Faster (part 2)",
            "Grate Guy\'s Casino",
            "Geno Awakens",
            "Celebrational",
            "Nimbus Land",
            "Monstro Town",
            "Toadofsky",
            "{SILENCE}",
            "Happy Adventure, Delighful Adventure",
            "World Map",
            "Factory",
            "Sword Crashes And Stars Scatter",
            "Conversation With Culex",
            "Fight Against Culex",
            "Victory Against Culex",
            "Valentina",
            "Barrel Volcano",
            "Axem Rangers Drop In",
            "The End",
            "Gate",
            "Bowser\'s Castle (2nd time)",
            "Weapons Factory",
            "Fight Against Smithy 1",
            "Fight Against Smithy 2",
            "Ending Part 1",
            "Ending Part 2",
            "Ending Part 3",
            "Ending Part 4"
        };
        public static string[] SoundNames = new string[]
        {
            "{SILENCE}",
            "menu select",
            "menu cancel",
            "menu scroll",
            "jump",
            "block switch",
            "running water",
            "gushing water",
            "waterfall",
            "green switch",
            "trampoline",
            "whoosh away",
            "dizziness",
            "coin",
            "item get",
            "birds tweeting",
            "open door",
            "open front gate",
            "sudden stop",
            "long fall",
            "lighting bolt",
            "rumbling",
            "close door",
            "helicopter",
            "tapping feet",
            "heel click",
            "laughing Bowser",
            "found an item",
            "pipe entrance",
            "alarm clock",
            "surprised monster",
            "spinning flower",
            "underground warp",
            "jumping bouncing fish",
            "squirm writhe",
            "running water",
            "*Tadpole Pond staff: Do",
            "*Tadpole Pond staff: Re",
            "*Tadpole Pond staff: Mi",
            "*Tadpole Pond staff: Fa",
            "*Tadpole Pond staff: So",
            "*Tadpole Pond staff: La",
            "*Tadpole Pond staff: Ti",
            "slipping",
            "ghost float",
            "Goomba taunt",
            "marching troops",
            "snooze",
            "rolling",
            "big shell hit",
            "water droplet",
            "moving yellow switch",
            "deep bounce",
            "bounce",
            "goodnight",
            "coin shower lose fountain",
            "shake head",
            "finger snap",
            "insert",
            "hovering Frogfucius",
            "dynamite bomb explosion",
            "deep uh-oh",
            "big yoshi talk",
            "yoshi talk",
            "spinning copters",
            "thwomp stomp 1",
            "kick ball shell",
            "sword in keep",
            "*Mallow yelling at Croco",
            "*Mallow falling landing",
            "*Mallow sliding on wall",
            "mushroom cure",
            "syrup cure",
            "thwomp stomp 2",
            "Boosters train",
            "rocketing blast",
            "Boosters train horn",
            "Bowyer arrows dancing",
            "click",
            "*yelp in distance",
            "star explanation",
            "star",
            "screeching stop",
            "weird laugh",
            "smoked fireball",
            "1-up flower",
            "big bounce",
            "correct signal",
            "wrong signal",
            "lit fuse",
            "curtain",
            "tumbling boulders",
            "*Lakitu attaches Frogfucius",
            "water splash",
            "frog coin",
            "level up with star",
            "swinging fist",
            "engage in battle",
            "*puzzle game timer",
            "tapping feet",
            "minecart ride",
            "Terrapin attack",
            "time running out",
            "Toadstool crying",
            "chomp spinning",
            "surprise",
            "off balance",
            "drum roll",
            "drum roll end",
            "big shell hit",
            "abstract Star Hill music",
            "water jumping",
            "draining water",
            "Bullet Bill ignition",
            "*orchestra hit A",
            "*orchestra hit A#",
            "*orchestra hit B",
            "Dry Bones crumble",
            "beckoning Tentacle",
            "Czar Dragon roar",
            "Axem Rangers strike!",
            "Axem Ranger teleport",
            "Sky Troopas approaching",
            "chain rumbling noise",
            "Sgt. Flutter flight",
            "enter Star Hill warp",
            "exit Star Hill warp",
            "Yoshi egg hatch",
            "vine growing",
            "baby yoshi",
            "big baby yoshi",
            "*jump on organ",
            "honking horn",
            "march single",
            "curtain sweep",
            "impending blast",
            "*Toadofsky composition: Do",
            "*Toadofsky composition: Re",
            "*Toadofsky composition: Mi",
            "*Toadofsky composition: Fa",
            "*Toadofsky composition: So",
            "*Toadofsky composition: La",
            "*Toadofsky composition: Ti",
            "metronome upbeat ding",
            "click",
            "blacksmith hammer strike",
            "machine transform",
            "Troopa shell poof hide",
            "Yaridovich tranforms",
            "secret hint",
            "jump on save box",
            "open chapel doors",
            "shuffle cards",
            "slot machines",
            "big squish",
            "whistling Mario theme",
            "Link fanfare",
            "firework ascending",
            "firework bang",
            "firework bang big",
            "chomping",
            "ghost",
            "closing gate door"
        };
        public static string[] BattleSoundNames = new string[]
        {
            "{SILENCE}",
            "menu select",
            "menu cancel",
            "menu scroll",
            "jump",
            "birdie tweet",
            "bonus flower status up",
            "error incorrect answer",
            "get dizzy",
            "arrow sling",
            "Mallow punch 1",
            "swoosh run away",
            "bomb explosion",
            "coin",
            "item get",
            "spike sting",
            "bite",
            "Star Gun shoot",
            "Super Jump hit 1",
            "Drain Beam",
            "Aurora Flash",
            "Scarecrow birdies",
            "Corona descends",
            "small laser?",
            "{NULL}",
            "slap big",
            "Flame Wall",
            "item 1-UP",
            "Flame",
            "fire shoot",
            "fire throw",
            "fire hit",
            "fire burn",
            "insert",
            "Muku Muku~",
            "spell power up",
            "snow",
            "monster item toss",
            "frying pan hit 2",
            "claw",
            "pierce",
            "Super Jump hit 4",
            "blade",
            "coin showers into fountain",
            "Bolt",
            "HP Rain cloud",
            "plasma bounce",
            "dry clunk",
            "Mallow punch 2",
            "cymbal crash",
            "Super Jump hit 5",
            "fire throw big",
            "Finger Shot bullets",
            "Thwomp hit ground",
            "hammer hit 1",
            "hammer hit 2",
            "Super Jump hit 1-UP",
            "fire spout__",
            "Super Jump hit 2",
            "Super Jump hit 3",
            "cymbal resonance",
            "item use",
            "monster run away",
            "Geno Blast ignition",
            "egg hatch",
            "Yoshi cant make cookie",
            "Recover HP",
            "Recover FP",
            "Recover Drink",
            "Geno power up",
            "Geno Beam",
            "Psychopath drum roll",
            "Psychopath cloud appears",
            "Psychopath message",
            "quack__",
            "Yoshi talk",
            "stat boost (single)",
            "stat boost (multi)",
            "timed stat boost",
            "rumble (single)",
            "wallop 1",
            "wallop 2",
            "wallop 3",
            "frying pan hit 1",
            "wallop 4",
            "wallop 5",
            "long fall",
            "big bounce",
            "ticking bomb",
            "common monster explosion",
            "birdie call?__",
            "{NULL}",
            "Spear Rain (single)",
            "Bowyer arrow lock button",
            "Shocker",
            "Bowsers Crusher?__",
            "rumble (multi)",
            "plasma toss",
            "click",
            "Willy Wisp",
            "Electroshock sparks",
            "Stench",
            "Static E!",
            "Crystal hits",
            "Blizzard",
            "Rock Candy",
            "Light Beam",
            "bubble pop",
            "Howl",
            "Geno Hand Cannon shoot",
            "huge explosion",
            "Sledge",
            "swing",
            "Geno Finger Shot hit",
            "Spikey attack",
            "transform",
            "Terrapin swing",
            "sting?__",
            "Geno Blast end",
            "Meteor Swarm",
            "deep swallow",
            "big swing",
            "poisoned",
            "Chomp bite",
            "Goomba roll",
            "spike shot",
            "flopping hit",
            "liquid droplet",
            "Amanita curls",
            "throw?__",
            "Valor Up Vigor Up",
            "echoing bubble__",
            "stinger poison",
            "Lullaby Sad Song",
            "Boo disappears",
            "Boo appears",
            "Boo approaches",
            "Bowser Crush stomp!",
            "Endobubble",
            "guitar string",
            "S'crow Bell",
            "Lullaby Mario Theme",
            "Dry Bones attack",
            "toss",
            "Lightning Orb",
            "Artichoker spines",
            "slap",
            "{NULL}",
            "Smithy bullet fingers",
            "enemy jumps high",
            "enemy taunts then hits",
            "spores",
            "hit",
            "Guerrilla thinks",
            "buzzing bee",
            "Sparky hit",
            "Chomp bite",
            "Enigma scatters",
            "yelp__",
            "big deep hit",
            "slap",
            "Spore Chimes Doom Reverb",
            "{NULL}",
            "{NULL}",
            "Carroboscis attack",
            "Sky Troopa flaps",
            "tapping feet",
            "Belome eats",
            "Terrapin attack",
            "teleport attack",
            "submerged under",
            "slap powerful",
            "weapon timing",
            "Terrorize",
            "Solidify",
            "Deathsickle",
            "boss fade out death",
            "Poison Gas 1",
            "Poison Gas 2",
            "Sleepy Bomb",
            "Sleepy Time timed",
            "Lamb's Lure (single)",
            "Sheep Attack 1",
            "floating lamb",
            "Sheep Attack 2 (multi)",
            "Geno Flash shoot",
            "Geno Flash explosion",
            "Mute balloon rises",
            "Petal Blast",
            "Pollen Nap",
            "Come Back",
            "Mute balloon fails",
            "big shell kick",
            "big shell hit 1",
            "big shell hit 2",
            "explosive hit",
            "Geno Flash transformation",
            "Geno Star Gun hit",
            "Ice Rock",
            "Arrow Rain",
            "Spear Rain (multi)",
            "Sword Rain",
            "Corona flash",
            "Mega Drain (single)",
            "chomping",
            "Jinxed",
            "monster swing",
            "monster taunt",
            "Smithy Form 1 - light up",
            "Smithy Form 1 - transform",
            "Booster Express train horn"
        };
        #endregion
        #region Battles
        public static int[] BattleLengths = new int[]
        {
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
            4,0,2,2,0,2,3,4,2,0,4,3,1,2,0,2,
            4,2,3,3,4,0,0,0,0,0,0,1,4,1,1,1
        };
        public static byte[] BattleOpcodes = new byte[]
        {
            0xF3,0xF3,0x00,0xE0,0xF0,0xEF,0xEC,0xED,
            0xFC,0xFC,0xFC,0xFC,0xFC,0xFC,0xFC,0xFC,
            0xFC,0xFC,0xFC,0xFC,0xFC,0xFC,0xFC,0xFC,
            0xFC,0xFC,0xE8,0xE7,0xE6,0xE6,0xE7,0xE3,
            0xE5,0xF1,0xF4,0xEA,0xF2,0xF2,0xEB,0xEA,
            0xE2,0xEB,0xFD,0xFE
        };
        public static byte[] BattleParams = new byte[]
        {
            0x01,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
            0x0A,0x05,0x01,0x04,0x03,0x02,0x07,0x13,
            0x12,0x11,0x0D,0x0C,0x14,0x08,0x10,0x10,
            0x06,0x09,0x00,0x01,0x01,0x00,0x00,0x00,
            0x00,0x00,0x00,0x01,0x00,0x01,0x01,0x00,
            0x00,0x00,0x00,0x00
        };
        public static string[] BattlefieldNames = new string[]
        {
            "Forest Maze",
            "Forest Maze: Bowyer\'s Pad",
            "Bean Valley: Beanstalks",
            "Sunken Ship: King Calamari\'s Cellar",
            "Sunken Ship",
            "Moleville Mines",
            "___mines",
            "Bowser\'s Keep",
            "Barrel Volcano: Czar Dragon\'s Pad",
            "Grasslands",
            "Mountains",
            "Mushroom Kingdom House",
            "Booster Tower",
            "Mushroom Kingdom Castle",
            "Kero Sewers: Underwater",
            "Mushroom Kingdom Castle",
            "Bowser\'s Keep Turret: Exor",
            "Booster Tower: Balcony",
            "Smithy Factory: Count Down\'s Pad",
            "Smithy Factory",
            "Barrel Volcano",
            "Kero Sewers",
            "Nimbus Castle",
            "Nimbus Castle: Birdo\'s Room",
            "Nimbus Land",
            "Underground",
            "___uses Mushroom Kingdom tiles",
            "___forested area with unique trees",
            "Mushroom Kingdom",
            "Bowser\'s Keep: Chandeliers",
            "Forest Maze: Path to Bowyer",
            "Level Up foreground",
            "Level Up background",
            "Plateaus",
            "___sea enclave",
            "Marrymore Chapel Sanctuary",
            "Star Hill",
            "Seaside Town Beach",
            "Sea",
            "Blade: Axem Rangers",
            "Smithy Factory: Domino & Cloaker\'s Pad",
            "Bean Valley: Grasslands",
            "Belome Temple",
            "Land\'s End Desert",
            "Factory Grounds: Smithy\'s Pad",
            "Smithy\'s Final Form",
            "Jinx\'s Dojo",
            "Culex",
            "Factory Grounds",
            "Bean Valley: Pipe Room",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____",
            "_____"
        };
        public static string[] BattleEventNames = new string[]
        {
            "Mallow belts Croco, gets back frog coin",
            "Kinklink flashes, loses grip and Bowser falls",
            "Belome swallows Mallow",
            "Geno fights Bowyer, Mario and Mallow run to help",
            "Mack jumps out of battle off screen",
            "Mack returns to battle",
            "Belome spits out Mallow",
            "Countdown runs schedule, 1:00,3:00,5:00,6:00,7:00",
            "Countdown runs schedule, 6:00,9:00,10:00,12:00",
            "Punchinello interludes and prepares to summon Bob-ombs",
            "Punchinello interludes and prepares to summon Mezzo Bombs",
            "Punchinello summons King Bomb which then explodes",
            "___dialogue from Booster fight",
            "___",
            "INTRO SCENE: Punchinello fight",
            "Croco steals items: \"You want them back?\"",
            "Croco returns items: \"Enough! Here's your junk...\"",
            "INTRO SCENE: Knife Guy & Grate Guy fight",
            "Knife Guy & Grate Guy pair up piggy-back",
            "Knife Guy & Grate Guy separate: \"Yikes! They're pretty tough\"",
            "Mario and party run off of balcony after Knife Guy & Grate Guy fight",
            "Johnny challenges Mario to a one-on-one",
            "Yaridovich 'Mirage Attack'",
            "Yaridovich mirage is destroyed, return to single form",
            "Machine Made Yaridovich 'Multiplier'",
            "Drill Bit",
            "INTRO SCENE: Tentacles rise from holes",
            "beat Tentacles, move on to next",
            "beat Tentacles, move on to King Calamari",
            "jump down King Calamari's cellar hole",
            "jump up King Calamari's cellar hole",
            "Bundt moves, Assistant pokes Torte",
            "Bundt moves again, both cooks run away",
            "candles appear on Bundt",
            "\"Blow those candles out!\"",
            "Raspberry is beaten, Snifits & Booster run in and eat cake",
            "Tentacles throw character off screen",
            "GAME INTRO: Mario hammers Sky Troopa",
            "GAME INTRO: Mario stomps Goomba",
            "GAME INTRO: Mallow uses Thunderbolt",
            "GAME INTRO: Geno attacks",
            "GAME INTRO: Geno uses Geno Beam",
            "Bb-bombs explode",
            "Toad's battle mechanics tutorial",
            "Czar Dragon dies",
            "Zombone dies",
            "Czar Dragon summons Helios",
            "___",
            "Valentina summons Dodo, Dodo carries off middle character",
            "Dodo flutters and leaves battle",
            "Dodo returns to Valentina's formation",
            "Valentina & Dodo are beaten",
            "INTRO SCENE: Domino & Cloaker's introduction",
            "Domino teams up with Mad Adder",
            "Cloaker teams up with Earthlink",
            "Shy Away waters Smilax: part 1",
            "Shy Away waters Smilax: part 2",
            "Shy Away waters Smilax: part 3",
            "Thrax is there",
            "Belome confronts a character: \"You all LOOK delicious...\"",
            "Belome clones someone",
            "only Mario is there",
            "Axem Rangers intro scene",
            "Axem Pink quits",
            "Axem Black quits",
            "Axem Yellow quits",
            "Axem Green quits",
            "Axem Rangers group formation",
            "Axem Red quits",
            "Axem Rangers are defeated",
            "Jinx uses Jinxed",
            "Jinx uses Triple Kick",
            "Jinx uses Quicksilver",
            "Jinx uses Bombs Away",
            "Culex summons crystals",
            "Formless changes into Mokura",
            "Boomer is defeated, chandelier crashing scene",
            "___screen flashes white",
            "Dodo flutters and exits battle",
            "Magikoopa summons monster",
            "no one there",
            "Exor is defeated, cries and opens mouth",
            "Smithy (1st Form) is beaten, ground shakes etc.",
            "___screen flashes white",
            "___screen flashes white",
            "___Fear Roulette",
            "Smelter pours molten liquid, Smithy welds",
            "Smithy transforms into Tank Head",
            "Smithy transforms into Magic Head",
            "Smithy transforms into Chest Head",
            "Smithy transforms into Box Head",
            "Smithy's head fades before transforming into other head",
            "Shelly breaks, Birdo appears",
            "beam of light forms around Smithy head before body appears",
            "Punchinello's bombs explode if still alive",
            "bombs explode",
            "___nothing",
            "Smithy waits before transforming head",
            "Smithy is defeated",
            "___",
            "Earthlink/Mad Adder collapses and dies",
            "___Magikoopa is there",
            "<NONE>"
        };
        public static string[] targetNames = new string[]
        {
            "Mario",
            "Toadstool",
            "Bowser",
            "Geno",
            "Mallow",
            "____",
            "____",
            "____",
            "____",
            "____",
            "____",
            "____",
            "____",
            "____",
            "____",
            "____",
            "character in slot 1",
            "character in slot 2",
            "character in slot 3",
            "monster 1 (set)",
            "monster 2 (set)",
            "monster 3 (set)",
            "monster 4 (set)",
            "monster 5 (set)",
            "monster 6 (set)",
            "monster 7 (set)",
            "monster 8 (set)",
            "self",
            "all allies, not self",
            "random ally, not self",
            "all allies, and self",
            "random ally, or self",
            "____",
            "____",
            "____",
            "all opponents",
            "at least one opponent",
            "random opponent",
            "____",
            "at least one ally",
            "monster 1 (call)",
            "monster 2 (call)",
            "monster 3 (call)",
            "monster 4 (call)",
            "monster 5 (call)",
            "monster 6 (call)",
            "monster 7 (call)",
            "monster 8 (call)"
        };
        public static string[] TargetNames
        {
            get
            {
                for (int i = 0; i < Model.Characters.Length; i++)
                    targetNames[i] = Model.CharacterNames.GetUnsortedName(i);
                return targetNames;
            }
        }
        private static string[] monsterBehaviors = new string[0];
        public static string[] MonsterBehaviors
        {
            get
            {
                if (monsterBehaviors.Length == 54)
                    return monsterBehaviors;
                monsterBehaviors = new string[]
                {
                    "Initialize in Battle (behavior set 0, 1, 2, 3, 4)",
                    "Idle/On Hit (behavior set 0)",
                    "Idle/On Hit (behavior set 1)",
                    "Idle/On Hit (behavior set 2)",
                    "Idle/On Hit (behavior set 3)",
                    "Idle/On Hit (behavior set 4)",
                    "Cast Spell (behavior set 0, 1, 2, 3, 4)",
                    "Move Toward Target (behavior set 0, 1, 2, 3, 4)",
                    "Escape (behavior set 0, 4)",
                    "Escape (behavior set 1, 2, 3)",
                    "KOed (behavior set 0, 1, 2, 3)",
                    "KOed (behavior set 4)",
                    "Initialize in Battle (behavior set 5)",
                    "Idle/On Hit (behavior set 5)",
                    "Cast Spell (behavior set 5)",
                    "Move Toward Target (behavior set 5)",
                    "Escape (behavior set 5)",
                    "KOed (behavior set 5)",
                    "Initialize in Battle (behavior set 6)",
                    "Initialize in Battle (behavior set 7)",
                    "Idle/On Hit (behavior set 6, 7)",
                    "Cast Spell (behavior set 6, 7)",
                    "Move Toward Target (behavior set 6, 7)",
                    "Escape (behavior set 6)",
                    "Escape (behavior set 7)",
                    "KOed (behavior set 6, 7)",
                    "Initialize in Battle (behavior set 8, 9, 10)",
                    "Idle/On Hit (behavior set 8, 9)",
                    "Idle/On Hit (behavior set 10)",
                    "Cast Spell (behavior set 8, 9)",
                    "Cast Spell (behavior set 10)",
                    "Move Toward Target (behavior set 8, 9, 10)",
                    "Escape (behavior set 8)",
                    "Escape (behavior set 9)",
                    "Escape (behavior set 10)",
                    "KOed (behavior set 8, 9, 10)",
                    "Initialize in Battle (behavior set 11, 12, 13, 14)",
                    "Idle/On Hit (behavior set 11, 12, 13, 14)",
                    "Cast Spell (behavior set 11, 13, 14)",
                    "Cast Spell (behavior set 12)",
                    "Move Toward Target (behavior set 11, 12, 13, 14)",
                    "Escape (behavior set 11, 12)",
                    "Escape (behavior set 13)",
                    "Escape (behavior set 14)",
                    "KOed (behavior set 11, 12, 13, 14)",
                    "Initialize in Battle (behavior set 15, 16, 17)",
                    "Idle/On Hit (behavior set 15)",
                    "Idle/On Hit (behavior set 16)",
                    "Idle/On Hit (behavior set 17)",
                    "Cast Spell (behavior set 15, 16, 17)",
                    "Move Toward Target (behavior set 15, 16, 17)",
                    "Escape (behavior set 15)",
                    "Escape (behavior set 16, 17)",
                    "KOed (behavior set 15, 16, 17)",
                };
                // MonsterBehaviors always use defaults (no custom overrides)
                return monsterBehaviors;
            }

        }
        #endregion

        #region Monsters
        public static string[] MonsterNames = new string[]
        {
            "Terrapin",
            "Spikey",
            "Sky Troopa",
            "Mad Mallet",
            "Shaman",
            "Crook",
            "Goomba",
            "Piranha Plant",
            "Amanita",
            "Goby",
            "Bloober",
            "Bandana Red",
            "Lakitu",
            "Birdy",
            "Pinwheel",
            "Rat Funk",
            "K-9",
            "Magmite",
            "The Big Boo",
            "Dry Bones",
            "Greaper",
            "Sparky",
            "Chomp",
            "Pandorite",
            "Shy Ranger",
            "Bob-Omb",
            "Spookum",
            "Hammer Bro",
            "Buzzer",
            "Ameboid",
            "Gecko",
            "Wiggler",
            "Crusty",
            "Magikoopa",
            "Leuko",
            "Jawful",
            "Enigma",
            "Blaster",
            "Guerrilla",
            "Baba Yaga",
            "Hobgoblin",
            "Reacher",
            "Shogun",
            "Orb User",
            "Heavy Troopa",
            "Shadow",
            "Cluster",
            "Bahamutt",
            "Octolot",
            "Frogog",
            "Clerk",
            "Gunyolk",
            "Boomer",
            "Remo Con",
            "Snapdragon",
            "Stumpet",
            "Dodo (2nd time)",
            "Jester",
            "Artichoker",
            "Arachne",
            "Carroboscis",
            "Hippopo",
            "Mastadoom",
            "Corkpedite",
            "Terra Cotta",
            "Spikester",
            "Malakoopa",
            "Pounder",
            "Poundette",
            "Sackit",
            "Gu Goomba",
            "Chewy",
            "Fireball",
            "Mr.Kipper",
            "Factory Chief",
            "Bandana Blue",
            "Manager",
            "Bluebird",
            "__nothing",
            "Alley Rat",
            "Chow",
            "Magmus",
            "Li{xx}L Boo",
            "Vomer",
            "Glum Reaper",
            "Pyrosphere",
            "Chomp Chomp",
            "Hidon",
            "Sling Shy",
            "Rob-Omb",
            "Shy Guy",
            "Ninja",
            "Stinger",
            "Goombette",
            "Geckit",
            "Jabit",
            "Star Cruster",
            "Merlin",
            "Muckle",
            "Forkies",
            "Gorgon",
            "Big Bertha",
            "Chained Kong",
            "Fautso",
            "Straw Head",
            "Juju",
            "Armored Ant",
            "Orbison",
            "Tub-O-Troopa",
            "Doppel",
            "Pulsar",
            "__purple Bahamutt",
            "Octovader",
            "Ribbite",
            "Director",
            "__Gunyolk (yellow)",
            "__Boomer (blue)",
            "Puppox",
            "Fink Flower",
            "Lumbler",
            "Springer",
            "Harlequin",
            "Kriffid",
            "Spinthra",
            "Radish",
            "Crippo",
            "Mastablasta",
            "Pile Driver",
            "Apprentice",
            "__nothing",
            "__nothing",
            "__nothing",
            "__Geno redemption",
            "__little bird",
            "Box Boy",
            "Shelly",
            "Super Spike",
            "Dodo",
            "Oerlikon",
            "Chester",
            "Body",
            "__Pile Driver (body)",
            "Torte",
            "Shy Away",
            "Jinx Clone",
            "Machine Made (Shyster)",
            "Machine Made (Drill Bit)",
            "Formless",
            "Mokura",
            "Fire Crystal",
            "Water Crystal",
            "Earth Crystal",
            "Wind Crystal",
            "Mario Clone",
            "Toadstool 2",
            "Bowser Clone",
            "Geno Clone",
            "Mallow Clone",
            "Shyster",
            "Kinklink",
            "__Toadstool (captive)",
            "Hangin{xx} Shy",
            "Smelter",
            "Machine Made (Mack)",
            "Machine Made (Bowyer)",
            "Machine Made (Yaridovich)",
            "Machine Made (Axem Pink)",
            "Machine Made (Axem Black)",
            "Machine Made (Axem Red)",
            "Machine Made (Axem Yellow)",
            "Machine Made (Axem Green)",
            "Goomba (Intro)",
            "Hammer Bro (Intro)",
            "Birdo (Intro)",
            "Bb-Bomb",
            "Magidragon",
            "Starslap",
            "Mukumuku",
            "Zeostar",
            "Jagger",
            "Chompweed",
            "Smithy (Tank Head)",
            "Smithy (Box Head)",
            "__Corkpedite",
            "Microbomb",
            "__Thwomp",
            "Grit",
            "Neosquid",
            "Yaridovich (mirage)",
            "Helio",
            "Right Eye",
            "Left Eye",
            "Knife Guy",
            "Grate Guy",
            "Bundt",
            "Jinx (1st time)",
            "Jinx (2nd time)",
            "Count Down",
            "Ding-A-Ling",
            "Belome (1st time)",
            "Belome (2nd time)",
            "__Belome",
            "Smilax",
            "Thrax        ",
            "Megasmilax",
            "Birdo",
            "Eggbert",
            "Axem Yellow",
            "Punchinello",
            "Tentacles (right)",
            "Axem Red",
            "Axem Green",
            "King Bomb",
            "Mezzo Bomb",
            "__Bundt object",
            "Raspberry",
            "King Calamari",
            "Tentacles (left)",
            "Jinx (3rd time)",
            "Zombone",
            "Czar Dragon",
            "Cloaker (1st time)",
            "Domino (2nd time)",
            "Mad Adder",
            "Mack",
            "Bodyguard",
            "Yaridovich",
            "Drill Bit",
            "Axem Pink",
            "Axem Black",
            "Bowyer",
            "Aero",
            "__Exor (mouth)",
            "Exor",
            "Smithy (1st Form)",
            "Shyper",
            "Smithy (Body)",
            "Smithy (Head)",
            "Smithy (Magic Head)",
            "Smithy (Chest Head)",
            "Croco (1st time)",
            "Croco (2nd time)",
            "__Croco",
            "Earth Link",
            "Bowser",
            "Axem Rangers",
            "Booster",
            "Booster",
            "Snifit",
            "Johnny",
            "Johnny",
            "Valentina",
            "Cloaker (2nd time)",
            "Domino (2nd time)",
            "Candle",
            "Culex",
        };
        #endregion
        #region Sprites
        public static string[] SpriteNames = new string[]
        {
            "Mario (walking, down-left)",
            "Mario (jump, front)",
            "Mario (walking, up-right)",
            "Mario (surprise, left)",
            "Mario (attack, up-right)",
            "Mario (hammer attack, up-right)",
            "Mario (crouch, up-right)",
            "Toadstool (walking, down-left)",
            "Toadstool (walking, up-right)",
            "Toadstool (surprise)",
            "Toadstool (slap attack)",
            "Toadstool (frying pan attack)",
            "Toadstool (fallen/crying)",
            "Bowser (walking, down-left)",
            "Bowser (walking, up-right)",
            "Bowser (surprise)",
            "Bowser (claw attack)",
            "Bowser (swing ball-chain)",
            "Bowser (cast spell)",
            "Mallow (walking, down-left)",
            "Mallow (walking, up-right)",
            "Mallow (surprise)",
            "Mallow (punch)",
            "Mallow (swing stick)",
            "Mallow (still, up-right)",
            "Geno (walking, down-left)",
            "Geno (walking, up-right)",
            "Geno (surprise)",
            "Geno (elbow shot)",
            "Geno (finger shot)",
            "Geno (morph into cannon)",
            "Hammer",
            "Froggie Stick",
            "Cymbals",
            "Chomp",
            "Frying Pan",
            "Parasol",
            "War Fan",
            "Red Mushroom",
            "Red Scarecrow",
            "Mario's battle portrait",
            "Toadstool's battle portrait",
            "Bowser's battle portrait",
            "Mallow's battle portrait",
            "Geno's battle portrait",
            "Yellow Yoshi",
            "Pink Yoshi",
            "Boshi",
            "Croco",
            "Green Yoshi",
            "Booster",
            "Green Yoshi (walk)",
            "Green Yoshi (laying egg)",
            "King Nimbus",
            "Queen Nimbus",
            "Jonathan Jones",
            "Valentina",
            "Magikoopa",
            "Frogfucius",
            "Tadpole",
            "Thwomp",
            "Big Thwomp",
            "Microbomb",
            "Valentina Statue",
            "Toad",
            "Wallet Guy (also casino assistants)",
            "Raini",
            "Old Man",
            "Old Woman",
            "Green/Brown Toad",
            "Chancellor",
            "Pa Mole",
            "Ma Mole",
            "Girl Mole (pink bow)",
            "Girl Mole (yellow bow)",
            "Nimbusite (blue)",
            "Nimbusite (red)",
            "Nimbusite (brown/green)",
            "Nimbusite (yellow/green)",
            "Nimbus Guard",
            "Toadofsky",
            "Mario Doll (Booster's Castle)",
            "Blue Star Piece",
            "Purple Star Piece",
            "Red Star Piece",
            "Gold Star Piece",
            "Green Star Piece",
            "Light Blue Star Piece",
            "Yellow Star Piece",
            "Geno Doll",
            "Bowser Doll",
            "Mario Doll",
            "Toadstool Doll",
            "Blue Stepping Block",
            "Treasure Chest",
            "Empty Treasure Chest",
            "Mario Doll (surprised)",
            "Snifit's Parachute",
            "Rolling Barrel",
            "Trampoline (Warp)",
            "Trampoline (Jump)",
            "Teeter-totter",
            "Save Point",
            "Corkpedite",
            "J Puzzle Block",
            "Yellow Stepping Block",
            "Whirlpool (water)",
            "Hinopio",
            "Factory Hex-Nut",
            "Green Switch",
            "Treasure Chest (bad palette)",
            "Nimbusland Bus Driver",
            "Mushroom Boy",
            "Marrymore Man (green)",
            "Marrymore Woman (yellow)",
            "Marrymore Woman (green)",
            "Marrymore Kid (purple)",
            "Marrymore Kid (blue/green)",
            "Marrymore Bright Card buyer (brown/grey)",
            "Rose Town Gardener (green/grey)",
            "Old Woman (green/grey)",
            "Old Woman (purple/grey)",
            "Fat Yoshi Baby",
            "Yoshi Baby Egg",
            "Gameboy Kid",
            "Frogfucius Student",
            "Chomp (behind)",
            "Wiggler (head)",
            "Block Shadow",
            "Red Magikoopa",
            "Wiggler (body segment)",
            "Dodo (as parson)",
            "Moleville Mine Cart",
            "Knife Guy Juggler (still, red balls)",
            "Knife Guy Juggler",
            "Mine Cart (Seq7 Overworld Sprite)",
            "Mario in Mine Cart",
            "Fireball (surface from lava)",
            "Piranha Plant",
            "Goomba",
            "Bullet Bill",
            "Golden Bullet Bill",
            "Factory Clerk (green)",
            "Land's End Cannon",
            "Apple (Yo'ster Isle intro sequence)",
            "Bob-omb",
            "Commander Troopa",
            "Golden Belome",
            "Birdy Statue",
            "Shyguy in Bowser's Helicopter",
            "Machine Made Bowyer",
            "Machine Made Yaridovich (out of battle)",
            "Machine Made Axem Red",
            "Gunyolk (top section)",
            "Gunyolk (outer section)",
            "Factory Crane",
            "Blue-Green Star Piece (spinning)",
            "Smithy's Hammer",
            "Smithy's Chest",
            "Poison Toxic Gas",
            "Shelly (bottom section)",
            "Dyna and Mite",
            "Seaside Town Fake (green)",
            "Seaside Town Fake Elder (green)",
            "Seaside Town Elder (yellow/green)",
            "Monstermama (golden/brown/red)",
            "Nimbus Guard",
            "Factory Manager (blue)",
            "Factory Director (red)",
            "Boomer (red)",
            "Dr.Topper (green)",
            "Sparkles from Star Piece",
            "Geno Doll",
            "Smelter (back section)",
            "Mario on Nimbus Busman (Bowser's Keep cutscene)",
            "Golden Chomp (back)",
            "Chomp (front)",
            "Grate Guy (from casino)",
            "Marrymore Inn Keeper (blue, striped hat)",
            "Rose Town Treasure Holder",
            "Rose Town Woman (blue/pink, braids)",
            "Marrymore Woman (yellow)",
            "Rose Town Old Man (blue/grey)",
            "Old Woman (grey/red)",
            "Kid (red, striped hat)",
            "Gaz (purple)",
            "(nothing)",
            "(nothing)",
            "Cannon Ball",
            "Croco (still)",
            "Bowser w/Toadstool in Helicopter",
            "Miniature Toad",
            "Coin",
            "Small Coin",
            "Frog Coin",
            "Flower",
            "Big Flower",
            "Sparkle (sideways)",
            "Sparkle (downwards)",
            "Sparkle (circular winding)",
            "Explosion",
            "Mokura's Cloud (blue)",
            "Small Frog Coin",
            "Level Up text from Invincible Star",
            "Grey Explosion (when encountering Fireballs)",
            "Miniature Axem Red",
            "Terrapin (still)",
            "Jinx (walk)",
            "Axem Red",
            "Axem Black",
            "Axem Pink",
            "Axem Yellow",
            "Axem Green",
            "Axem Red teleport",
            "Stumpet (head)",
            "Stumpet (roots, right)",
            "Czar Dragon (body)",
            "Growing Vine Beanstalk",
            "Brick Beanstalk Block",
            "Whirlpool (desert)",
            "Yellow Letter",
            "Yaridovich (out of battle)",
            "Toadstool Marrymore Accessories",
            "Tentacle (extending)",
            "Snifit (black, back)",
            "Level Up Bonus Selection Box",
            "Booster's Tower Entrance Door",
            "Light Green Pipe (top edge)",
            "Level Up Bonus Text",
            "Level Up Bonus Flower",
            "Level Up Bonus Pow Power",
            "Level Up Bonus Star Magic",
            "Level Up Bonus HP",
            "Falling Stepping Bridge Block",
            "Old Classic Mario",
            "Booster's Choo-Choo Train",
            "Magikoopa (blue, walking)",
            "Terrapin (walking)",
            "Splash Water Droplets",
            "Small Sea Fish",
            "Splash Water Geyser",
            "Bowyer",
            "White Gas Cloud",
            "Machine Made Drill Bit",
            "Mushroom House Decor Mailbox",
            "Link Sleeping in Rose Town Inn",
            "Samus Sleeping in Mushroom Kingdom",
            "Grey Stepping Stone",
            "Hinopio's Model Airplane (blue/grey)",
            "Grey Stone Block",
            "Small Black Fence",
            "Wooden Bridge Bowser's Keep (right section)",
            "Grey Stone Bridge Bowser's Keep (right section)",
            "Toadstool Hand Captive from Rope",
            "Plywood Brown Door Bowser's Keep",
            "Beetle",
            "Terrapin",
            "Spikey",
            "Sky Troopa",
            "Mad Mallet",
            "Shaman",
            "Crook",
            "Goomba",
            "Piranha Plant",
            "Amanita",
            "Goby",
            "Bloober",
            "Bandana Red",
            "Lakitu",
            "Birdy",
            "Pinwheel",
            "Rat Funk",
            "K-9",
            "Magmite",
            "The Big Boo",
            "Dry Bones",
            "Greaper",
            "Sparky",
            "Chomp",
            "Pandorite",
            "Shy Ranger",
            "Bob-Omb",
            "Spookum",
            "Hammer Bro",
            "Buzzer",
            "Ameboid",
            "Gecko",
            "Wiggler",
            "Crusty",
            "Magikoopa",
            "Leuko",
            "Jawful",
            "Enigma",
            "Blaster",
            "Guerrilla",
            "Baba Yaga",
            "Hobgoblin",
            "Reacher",
            "Shogun",
            "Orb User",
            "Heavy Troopa",
            "Shadow",
            "Cluster",
            "Bahamutt",
            "Octolot",
            "Frogog",
            "Clerk",
            "Gunyolk",
            "Boomer",
            "Remo Con",
            "Snapdragon",
            "Stumpet",
            "Dodo (2nd time)",
            "Jester",
            "Artichoker",
            "Arachne",
            "Carroboscis",
            "Hippopo",
            "Mastadoom",
            "Corkpedite",
            "Terra Cotta",
            "Spikester",
            "Malakoopa",
            "Pounder",
            "Poundette",
            "Sackit",
            "Gu Goomba",
            "Chewy",
            "Fireball",
            "Mr.Kipper",
            "Factory Chief",
            "Bandana Blue",
            "Manager",
            "Bluebird",
            "__nothing",
            "Alley Rat",
            "Chow",
            "Magmus",
            "Li{xx}L Boo",
            "Vomer",
            "Glum Reaper",
            "Pyrosphere",
            "Chomp Chomp",
            "Hidon",
            "Sling Shy",
            "Rob-Omb",
            "Shy Guy",
            "Ninja",
            "Stinger",
            "Goombette",
            "Geckit",
            "Jabit",
            "Star Cruster",
            "Merlin",
            "Muckle",
            "Forkies",
            "Gorgon",
            "Big Bertha",
            "Chained Kong",
            "Fautso",
            "Straw Head",
            "Juju",
            "Armored Ant",
            "Orbison",
            "Tub-O-Troopa",
            "Doppel",
            "Pulsar",
            "__purple Bahamutt",
            "Octovader",
            "Ribbite",
            "Director",
            "__Gunyolk (yellow)",
            "__Boomer (blue)",
            "Puppox",
            "Fink Flower",
            "Lumbler",
            "Springer",
            "Harlequin",
            "Kriffid",
            "Spinthra",
            "Radish",
            "Crippo",
            "Mastablasta",
            "Pile Driver",
            "Apprentice",
            "__nothing",
            "__nothing",
            "__nothing",
            "__Geno redemption",
            "__little bird",
            "Box Boy",
            "Shelly",
            "Super Spike",
            "Dodo",
            "Oerlikon",
            "Chester",
            "Body",
            "__Pile Driver (body)",
            "Torte",
            "Shy Away",
            "Jinx Clone",
            "Machine Made (Shyster)",
            "Machine Made (Drill Bit)",
            "Formless",
            "Mokura",
            "Fire Crystal",
            "Water Crystal",
            "Earth Crystal",
            "Wind Crystal",
            "Mario Clone",
            "Toadstool 2",
            "Bowser Clone",
            "Geno Clone",
            "Mallow Clone",
            "Shyster",
            "Kinklink",
            "__Toadstool (captive)",
            "Hangin{xx} Shy",
            "Smelter",
            "Machine Made (Mack)",
            "Machine Made (Bowyer)",
            "Machine Made (Yaridovich)",
            "Machine Made (Axem Pink)",
            "Machine Made (Axem Black)",
            "Machine Made (Axem Red)",
            "Machine Made (Axem Yellow)",
            "Machine Made (Axem Green)",
            "Goomba (Intro)",
            "Hammer Bro (Intro)",
            "Birdo (Intro)",
            "Bb-Bomb",
            "Magidragon",
            "Starslap",
            "Mukumuku",
            "Zeostar",
            "Jagger",
            "Chompweed",
            "Smithy (Tank Head)",
            "Smithy (Box Head)",
            "__Corkpedite",
            "Microbomb",
            "__Thwomp",
            "Grit",
            "Neosquid",
            "Yaridovich (mirage)",
            "Helio",
            "Right Eye",
            "Left Eye",
            "Knife Guy",
            "Grate Guy",
            "Bundt",
            "Jinx (1st time)",
            "Jinx (2nd time)",
            "Count Down",
            "Ding-A-Ling",
            "Belome (1st time)",
            "Belome (2nd time)",
            "__Belome",
            "Smilax",
            "Thrax        ",
            "Megasmilax",
            "Birdo",
            "Eggbert",
            "Axem Yellow",
            "Punchinello",
            "Tentacles (right)",
            "Axem Red",
            "Axem Green",
            "King Bomb",
            "Mezzo Bomb",
            "__Bundt object",
            "Raspberry",
            "King Calamari",
            "Tentacles (left)",
            "Jinx (3rd time)",
            "Zombone",
            "Czar Dragon",
            "Cloaker (1st time)",
            "Domino (2nd time)",
            "Mad Adder",
            "Mack",
            "Bodyguard",
            "Yaridovich",
            "Drill Bit",
            "Axem Pink",
            "Axem Black",
            "Bowyer",
            "Aero",
            "__Exor (mouth)",
            "Exor",
            "Smithy (1st Form)",
            "Shyper",
            "Smithy (Body)",
            "Smithy (Head)",
            "Smithy (Magic Head)",
            "Smithy (Chest Head)",
            "Croco (1st time)",
            "Croco (2nd time)",
            "__Croco",
            "Earth Link",
            "Bowser",
            "Axem Rangers",
            "Booster",
            "Booster",
            "Snifit",
            "Johnny",
            "Johnny",
            "Valentina",
            "Cloaker (2nd time)",
            "Domino (2nd time)",
            "Candle",
            "Culex",
            "ABXY action button selection in battle",
            "Rainbow Explosion",
            "Blue Explosion",
            "Green Explosion",
            "Enemy Defeated Explosion Stars",
            "Bomb Explosion",
            "Small White Cloud",
            "Drain Explosion",
            "flower bonus alphabet + symbols",
            "Battle stars (on hit)",
            "Come Back rainbow star",
            "yellow cure stars",
            "....",
            "Bowyer's arrow",
            "Geno's Star Form (Ending Credits)",
            "Geno's Bullets and Star Gun",
            "very small black dot",
            "HP Rain cloud",
            "stat-boost arrows",
            "black rolling coal rock",
            "blue spark",
            "yellow spark",
            "green spark",
            "red spark",
            "rainbow rain",
            "mushroom spores",
            "Lazy shell, Heavy Troopa, nok-nok shell",
            "Orange Lazy Shell",
            "Green Lazy Shell (Tub-O-Troopa)",
            "Snowy eyes",
            "blinking yellow light circle",
            "purple petal",
            "small pink petal",
            "thrown hammer",
            "Bombs Away electric ball",
            "Fire Orb fireball",
            "Willy Wisp purple electric ball",
            "spore (pink/green)",
            "bolt (hardware-wise)",
            "Mute balloon",
            "'Thank You' red dialogue bubble",
            "'Thank You' purple dialogue bubble",
            "'Thank You' blue dialogue bubble",
            "'Thank You' green dialogue bubble",
            "'Thank You' yellow dialogue bubble",
            "'Psychopath' question mark cloud",
            "thrown shuriken",
            "green cure stars",
            "red cure stars",
            "blue cure stars",
            "yellow reusable item sprite with letter I",
            "ABXY buttons from Bowyer's Button Lock",
            "Bowser's spike shot",
            "Geno Flash squinting eyes",
            "green item collection",
            "red item collection",
            "blue item collection",
            "yellow item collection",
            "green spore",
            "'Fear' exclamation point",
            "....",
            "Mokura",
            "Drain",
            "sparkles",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "yellow lightning ball",
            "Fire Orb hit explosion",
            "egg",
            "Lightning Orb blue lightning ball",
            "small yellow spike",
            "large yellow spike",
            "white gas cloud",
            "Blast orange gas cloud",
            "Star Egg little brown bird",
            "Poison Gas green gas cloud",
            "white stars",
            "purple gas cloud",
            "yellow star",
            "Diamond Saw snowflake",
            "blue gas cloud",
            "bone throw",
            "spritz bomb",
            "Wind Crystal and Fire Crystal",
            "green shine web",
            "Mecha-Koopa (Bowser Crush) eyes",
            "Water Crystal and Earth Crystal",
            "plasm water droplet (blue-green)",
            "Ice Rock",
            "black rock",
            "big pink heart",
            "dark red/yellow fireball",
            "light green stars",
            "light orange stars",
            "Sleepy Time sheep/ram",
            "Geno Beam/Blast/Flash red power-up star",
            "....",
            "blue/green bubbles/circles",
            "sleep ZZZ's",
            "backwards yellow spike",
            "Water Blast water spouts",
            "Gunk Ball / Ink Blast",
            "water spout (red)",
            "Royal Flush card",
            "yellow shaking bell",
            "....",
            "blue music note",
            "white pixel dot",
            "....",
            "blue water surfacing/diving droplets",
            "green water surfacing/diving droplets",
            "yellow water surfacing/diving droplets",
            "....",
            "....",
            "....",
            "....",
            "....",
            "Magikoopa's triangle/circle/X cast magic",
            "....",
            "....",
            "....",
            "....",
            "....",
            "flower bonus",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "marching Luigi",
            "marching Toads",
            "conducting Toadofsky",
            "waving Mallow",
            "waving King & Queen Nimbus",
            "Nimbus Busman, Lakitu & Frogfucius",
            "Tadpole",
            "trumpeting Piranhas",
            "Mole miners & star",
            "Dyna & Mite",
            "Hammer Bros & Chomps",
            "Crook & Croco",
            "Bowser in helicopter chasing",
            "Dodo carrying Valentina",
            "red balloon",
            "Booster riding train",
            "Snifits chasing beetle",
            "bouncing Shysters",
            "Mack, Yaridovich, Bowyer",
            "Smithy",
            "Johnny & mates",
            "blue/red/green Toads",
            "riding Yoshi",
            "waving Mario & Toadstool",
            "sparkle",
            "poof",
            "purple firework",
            "smaller red firework",
            "Geno in Star Form (Ending Credits)",
            "The End background (Ending Credits)",
            "Geno's Star's glow effect (Ending Credits)",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "....",
            "...."
        };
        public static string[] NPCPackets = new string[]
        {
            "FLASHING_POOF_FLOWER",                         // 0
            "FLASHING_POOF_MUSHROOM",                       // 1
            "FLOWER_PACK_CHEST_ITEM",                       // 2
            "BRIEF_STAR",                                   // 3
            "MIMIC_POOF_ON_DEFEAT",                         // 4
            "BRIEF_POOF_BAG",                               // 5
            "FEATHER_CHEST",                                // 6
            "STAR_PIECE_CHEST",                             // 7
            "RED_CHEST_ITEM",                               // 8
            "GREEN_CHEST_ITEM",                             // 9
            "BLUE_CHEST_ITEM",                              // 10
            "YELLOW_CHEST_ITEM",                            // 11
            "FLOWER_STATIC",                                // 12
            "MUSHROOM_STATIC",                              // 13
            "FLOWER_COLLECTION",                            // 14
            "SMALL_FROG_COIN_STILL",                        // 15
            "BIG_COIN_BEING_COLLECTED",                     // 16
            "SMALL_MINIGAME_COIN",                          // 17
            "SMALL_COIN_BEING_COLLECTED",                   // 18
            "FROG_COIN_BEING_COLLECTED",                    // 19
            "BAG_STATIC",                                   // 20
            "FLASHING_SMALL_EXPLOSION",                     // 21
            "RECURSIVE_SPARKLES",                           // 22
            "LOOPING_SINGLE_SPARKLE",                       // 23
            "REGULAR_SOUND_EXPLOSION",                      // 24
            "RING_CHEST",                                   // 25
            "SUNKEN_SHIP_TRAMPOLINE_PUZZLE",                // 26
            "SUNKEN_SHIP_TROOPA_PUZZLE",                    // 27
            "MUSHROOM_THROWN_SOUTHWEST",                    // 28
            "SUNKEN_SHIP_3D_MAZE",                          // 29
            "WATER_SPLASH_DROPS_SFX",                       // 30
            "LEVELUP_TEXT",                                 // 31
            "BLUE_CLOUD",                                   // 32
            "BOMB_EXPLOSION",                               // 33
            "GREY_EXPLOSION_SFX",                           // 34
            "SUNKEN_SHIP_CANNONBALL_PUZZLE",                // 35
            "BARREL_PUZZLE_PRIZE",                          // 36
            "SHIP_STAIRCASE",                               // 37
            "BOOSTER_HILL_PRIZE_0",                         // 38
            "BOOSTER_HILL_PRIZE_1",                         // 39
            "BROOCH_CHEST",                                 // 40
            "BOOSTER_HILL_PRIZE_2",                         // 41
            "BOOSTER_HILL_PRIZE_3",                         // 42
            "SHOES_CHEST",                                  // 43
            "BOOSTER_HILL_PRIZE_4",                         // 44
            "TELEPORTATION_SHINE",                          // 45
            "BOOSTER_HILL_PRIZE_5",                         // 46
            "BLUE_FIRE_TRAIL",                              // 47
            "BANANA_CHEST",                                 // 48
            "HAMMER_SPARKS_SFX",                            // 49
            "WATER_BLAST_SFX",                              // 50
            "DRILL_BIT",                                    // 51
            "BOMB_EXPLOSION_FASTER",                        // 52
            "CROWN_CHEST",                                  // 53
            "LEVELUP_BONUS_POW",                            // 54
            "LEVELUP_BONUS_S",                              // 55
            "LEVELUP_BONUS_HP",                             // 56
            "BOOSTER_HILL_PRIZE_6",                         // 57
            "BOOSTER_HILL_PRIZE_7",                         // 58
            "BOOSTER_HILL_PRIZE_8",                         // 59
            "BOOSTER_HILL_PRIZE_9",                         // 60
            "BOOSTER_HILL_PRIZE_10",                        // 61
            "BOOSTER_HILL_PRIZE_11",                        // 62
            "BOOSTER_HILL_PRIZE_12",                        // 63
            "FROG_COIN_CHEST_STILL",                        // 64
            "BOOSTER_HILL_PRIZE_13",                        // 65
            "BOOSTER_HILL_PRIZE_14",                        // 66
            "BOMB_CHEST",                                   // 67
            "BOOSTER_HILL_PRIZE_15",                        // 68
            "BOOSTER_HILL_PRIZE_STANDING_0",                // 69
            "EGG_CHEST",                                    // 70
            "BOOSTER_HILL_PRIZE_STANDING_1",                // 71
            "BOOSTER_HILL_PRIZE_STANDING_2",                // 72
            "COOKIE_CHEST",                                 // 73
            "BOOSTER_HILL_PRIZE_STANDING_3",                // 74
            "BOOSTER_HILL_PRIZE_STANDING_4",                // 75
            "BERRY_CHEST",                                  // 76
            "BOOSTER_HILL_PRIZE_STANDING_5",                // 77
            "BOOSTER_HILL_PRIZE_STANDING_6",                // 78
            "CARD_CHEST",                                   // 79
            "BOOSTER_HILL_PRIZE_STANDING_7",                // 80
            "BOOSTER_HILL_PRIZE_STANDING_8",                // 81
            "BOOSTER_HILL_PRIZE_STANDING_9",                // 82
            "BOOSTER_HILL_PRIZE_STANDING_10",               // 83
            "BOOSTER_HILL_PRIZE_STANDING_11",               // 84
            "BOOSTER_HILL_PRIZE_STANDING_12",               // 85
            "BOOSTER_HILL_PRIZE_STANDING_13",               // 86
            "BOOSTER_HILL_PRIZE_STANDING_14",               // 87
            "BOOSTER_HILL_PRIZE_STANDING_15",               // 88
            "BEETLE_CHEST",                                 // 89
            "SMALL_COIN_STILL",                             // 90
            "CHEST_COIN_STILL",                             // 91
            "GLOVE_CHEST",                                  // 92
            "CRYSTAL_CHEST",                                // 93
            "FIRE_SPELL_CHEST",                             // 94
            "BLUE_SPELL_CHEST",                             // 95
            "GREEN_SPELL_CHEST",                            // 96
            "YELLOW_SPELL_CHEST",                           // 97
            "GRAY_SPELL_CHEST",                             // 98
        
        };
        #endregion
        #region Effects
        public static string[] EffectNames = new string[]
        {
            "___DUMMY",
            "___DUMMY",
            "Thundershock",
            "Thundershock (BG mask)",
            "Crusher",
            "Meteor Blast",
            "Bolt",
            "Star Rain",
            "Flame (fire engulf)",
            "Mute (balloon)",
            "Flame Stone",
            "Bowser Crush",
            "spell cast spade",
            "spell cast heart",
            "spell cast club",
            "spell cast diamond",
            "spell cast star",
            "Terrorize",
            "Snowy (snow BG, 4bpp)",
            "Snowy (snow FG, 2bpp)",
            "Endobubble (black ball/orb)",
            "___DUMMY",
            "Solidify",
            "___DUMMY",
            "___DUMMY",
            "Psych Bomb (BG)",
            "___DUMMY",
            "Dark Star",
            "Willy Wisp (blue orb/ball BG)",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "Geno Whirl",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "blank white flash (2bpp)",
            "blank white flash (4bpp)",
            "Boulder",
            "black ball/orb",
            "blank blue flash (2bpp)",
            "blank red flash (2bpp)",
            "blank blue flash (4bpp)",
            "blank red flash (4bpp)",
            "___DUMMY",
            "blank dark blue flash (2bpp)",
            "blank dark blue flash (4bpp)",
            "Meteor Shower (snow/confetti)",
            "purple/violet flash (4bpp)",
            "brown flash (4bpp)",
            "dark red blast",
            "dark blue blast",
            "snow/confetti, green",
            "light blue blast",
            "black ball/orb",
            "red ball/orb",
            "green ball/orb",
            "snow/confetti, slate green",
            "snow/confetti, red",
            "orange/red blast (Fire Bomb)",
            "Ice bomb/Solidify BG (blue freeze)",
            "Static E! (electric blast)",
            "green star bunches",
            "blue star bunches",
            "pink star bunches",
            "yellow star bunches",
            "Aurora Flash",
            "Storm",
            "Electroshock",
            "Smithy Treasure Head spell, red",
            "Smithy Treasure Head spell, green",
            "Smithy Treasure Head spell, blue",
            "Smithy Treasure Head spell, yellow",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "Flame Wall (orange/red fire)",
            "Petal Blast 1",
            "Petal Blast 2",
            "Drain Beam BG (4bpp)",
            "Drain Beam FG (2bpp)",
            "___DUMMY",
            "electric bolt",
            "Sand Storm BG (2bpp)",
            "___DUMMY",
            "Pollen Nap (yellow pollen)",
            "Geno Beam, blue",
            "Geno Beam, red",
            "Geno Beam, gold",
            "Geno Beam, yellow",
            "Geno Beam, green",
            "Thunderbolt",
            "Light Beam",
            "Meteor Shower",
            "S\'Crow Dust (purple pollen)",
            "HP Rain BG",
            "HP Rain FG",
            "wavy dark blue lines",
            "wavy blue lines",
            "wavy red lines",
            "wavy brown lines",
            "Sand Storm FG (4bpp)",
            "Sledge",
            "Arrow Rain",
            "Spear Rain",
            "Sword Rain",
            "Lightning Orb (BG waves)",
            "Echofinder",
            "Poison Gas FG 1",
            "Poison Gas FG 2",
            "Poison Gas BG",
            "Smithy Transforms (beam effect)",
            "Smelter\'s molten metal",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY",
            "___DUMMY"
        };
        #endregion
        #region Levels
        public static string[] LevelNames = new string[]
        {
            "Debug Room",
            "____blue BG, nothing there",
            "Bowser's Keep, outside (Mario enters at beginning of game)",
            "Bowser's Keep 1st time, Area 01",
            "Bowser's Keep 1st time, Area 02",
            "Marrymore, outside (during Booster)",
            "Marrymore Inn, 2F",
            "Marrymore Inn, 1F",
            "Bowser's Keep, Area 09 (tall room, w/o save point this time)",
            "Marrymore Inn, regular room",
            "Bowser's Keep 1st time, Area 04 (Throne Room)",
            "Marrymore Inn, 3F",
            "Marrymore Inn, Suite room",
            "Barrel Volcano, falling into Volcano",
            "Booster Hill",
            "Vista Hill",
            "Mario's Pad",
            "Mushroom Kingdom Castle, Main Hall",
            "Mushroom Kingdom Castle, Throne Room",
            "Mushroom Kingdom Castle, Stair Room to Toadstool's room",
            "Mushroom Kingdom Castle, Toadstool's room",
            "Mushroom Kingdom Castle, branch room to Vault/Guest Room",
            "Mushroom Kingdom Castle, Guest room",
            "Mushroom Kingdom, before Croco, Outside",
            "Sunken Ship, post-KC Area 15 (Bandana Red room w/long stairwell)",
            "Sunken Ship, post-KC Area 16 (Entrance to Johnny's room)",
            "Sunken Ship, post-KC Area 12 (underwater room w/stairwell and Zeostars)",
            "Sunken Ship, post-KC Area 13 (large underwater room with a Bloober)",
            "Sunken Ship, post-KC Area 17 (Johnny's room)",
            "Mushroom Kingdom Castle, Throne Room (Toadstool returns)",
            "Mushroom Kingdom Castle, Toadstool's room (Toadstool returns)",
            "Mushroom Kingdom Castle, Vault",
            "Mushroom Kingdom Castle, Entrance to Toadstool's room",
            "Yo'ster Isle, entrance from Pipe Vault",
            "Yo'ster Isle",
            "Booster Tower, 7F (3-level w/parachuting Spookums)",
            "Booster Tower, 6F Area 04 (3-level w/Thwomp on teeter-totter)",
            "Booster Tower, 4F (3-level room w/jumping Spookums)",
            "Booster Tower, 9F (Booster's bomb-throwing room w/rail tracks)",
            "Booster Tower, 5F (Knife Guy's juggling room)",
            "Booster Tower, 5F (Knife Guy's juggline room, after defeat)",
            "Booster Tower, 8F Area 01 (‘minesweeper' room w/coins and hidden Fireballs)",
            "Booster Tower, 3F Area 02 (NES Mario room)",
            "Booster Tower, 1F Area 01 (main room)",
            "Mushroom Kingdom, before Croco, jumping kid's house (1F)",
            "Mushroom Kingdom, before Croco, jumping kid's house (2F)",
            "Mushroom Kingdom, before Croco, Raz and Raini's house",
            "Mushroom Kingdom, before Croco, Item Shop (top floor)",
            "Booster Tower, 8F Area 02 (Zoom Shoes room)",
            "Mushroom Kingdom, before Croco, Inn (1F)",
            "____blue BG, nothing there",
            "Mushroom Kingdom, before Croco, running kid's house",
            "Mushroom Kingdom, Inn (2F)",
            "Mushroom Kingdom, before Croco, Item Shop (basement)",
            "Booster Hill ____dummy",
            "Pipe Vault Entrance",
            "Kero Sewers, Area 02 (long room w/three pipes)",
            "Kero Sewers, Area 03 (large water room w/pipe in center)",
            "Kero Sewers, Area 06 (long water room w/Rat Funks in a line)",
            "Kero Sewers, Area 05 (super star room w/four Rat Funks)",
            "Kero Sewers, Area 04 (large room w/Pandorite and hiding Rat Funks)",
            "Nimbus Land, outside (during Valentina right before fight)",
            "Kero Sewers, Area 01 (water room w/save)",
            "Marrymore Scene",
            "Marrymore, outside",
            "Marrymore Chapel, sanctuary",
            "Rose Way, exit Area where Bowser's Troops gathered",
            "Midas River, business transaction Area",
            "Midas River, barrel jumping river",
            "Midas River, waterfall",
            "Midas River, 1st tunnel",
            "Midas River, 2nd tunnel (both left and right)",
            "Midas River, 3rd tunnel (on left)",
            "Midas River, 4th tunnel (on very bottom right)",
            "Tadpole Pond, Area 02",
            "Tadpole Pond, Area 01",
            "Bandit's Way, Area 01",
            "Bandit's Way, Area 03",
            "Bandit's Way, Area 04",
            "Rose Way, main Area",
            "Rose Way, two fast-floating platforms",
            "Rose Way, treasure chests w/coins Area",
            "Rose Way, winding path w/Crooks",
            "Rose Town, during Bowyer outside",
            "Rose Town, outside",
            "Rose Town, during Bowyer Inn (1F)",
            "Rose Town, Inn (1F)",
            "Rose Town, Item Shop",
            "Smithy's Final Form Defeat: Geno's Redemption",
            "Rose Town, during Bowyer three grandkids' house",
            "Rose Town, three grandkids' house",
            "Rose Town, couple's house",
            "Grate Guy's Casino, inside casino",
            "Rose Town, during Bowyer treasure house (1F)",
            "Rose Town, treasure house (1F)",
            "Rose Town, during Bowyer Inn (2F)",
            "Rose Town, Inn (2F)",
            "Rose Town, during Bowyer treasure house (2F)",
            "Rose Town, treasure house (2F)",
            "Rose Town, Geno Awakens in Inn (1F)",
            "Booster Pass, Area 01",
            "Booster Pass, Area 02",
            "Moleville, Outside (at exit from Mines)",
            "Smithy Factory, Area 17 (Domino and Cloaker's room)",
            "Grate Guy's Casino, front door",
            "Moleville, Dyna and Mite's House ____dummy",
            "Grate Guy's Casino, outside",
            "Nimbus Castle, Area 09 (Statue Room, after Valentina)",
            "Moleville, Outside",
            "Nimbus Castle, Area 01 (entrance hall)",
            "Nimbus Castle, Area 18 (Dodo's statue-polishing room)",
            "Nimbus Castle, Area 04 (left of 4-way path, right-angle red brick path w/ treasure)",
            "Nimbus Castle, Area 17 (right of 4-way path, Save Point)",
            "Nimbus Castle, Area 16 (small two-door room w/treasure, from Area 15)",
            "Nimbus Castle, Area 10 (red brick 2-level room w/treasure from Birdo's room)",
            "Nimbus Castle, Area 03 (4-way path, during Valentina)",
            "Nimbus Castle, Area 02 (left of Area 01)",
            "Nimbus Castle, Area 15 (front of 4-way path, large right-angle room w/ plant)",
            "Nimbus Castle, Area 05 (long 5-exit room, during Valentina)",
            "Nimbus Castle, Area 06 (left-most front door from Area 05)",
            "Nimbus Castle, Area 13 (Throne Room, during Valentina)",
            "Nimbus Castle, path after Throne Room (2nd)",
            "Nimbus Castle, Area 12 (entrance to throne room)",
            "Pipe Vault, Area 01",
            "Pipe Vault, Area 03 (line of pipes)",
            "Pipe Vault, Area 04 (line of coins, 2 hidden treasures)",
            "Pipe Vault, Area 06 (line of red pipes)",
            "Pipe Vault, Area 02",
            "Pipe Vault, Area 07 (long path w/moving platforms)",
            "Pipe Vault, Area 05",
            "Sea, Area 02 (large room with shop)",
            "Sea, Area 04 (bunch of Zeostars)",
            "Sea, Area 05 (from Area 02 w/save point)",
            "Sea, Area 06 (water room w/whirlpools)",
            "Sea, Area 03 (super star room)",
            "Sea, Area 01 (entrance)",
            "Sea, Area 07 (small underwater room)",
            "Land's End, Area 01",
            "Land's End, Area 02",
            "Land's End, Area 03 (Geckits playing cannonball)",
            "Land's End, Area 01,2 (nothing there, unused?)",
            "Land's End, Area 04 (rotating flowers)",
            "Land's End, Area 05 (sky bridge)",
            "Pipe Vault, Goomba-thumping room",
            "Bowser's Keep 6-door, treasure after each room",
            "Star Hill, Area 01",
            "Pipe Vault, Area 02 ___dummy",
            "GAME INTRO: Midas River, water tunnel",
            "GAME INTRO: Bandit's Way, Area 04",
            "GAME INTRO: Midas River, Barrel Jumping",
            "GAME INTRO: Moleville, outside during Bowser's troop scene",
            "GAME INTRO: Booster Hill",
            "Marrymore Chapel, main hall",
            "Marrymore Chapel, entrance to sanctuary",
            "Marrymore Chapel, sanctuary (during Booster)",
            "Marrymore Chapel, kitchen",
            "Marrymore Chapel, kitchen (no sprites/exits, unused?)",
            "Star Hill, Area 03",
            "Star Hill, Area 02",
            "Star Hill, Area 04",
            "Sunken Ship, Area 01",
            "Sunken Ship, Area 03 (Greapers)",
            "Sunken Ship, Area 04 (Greapers & Dry Bones)",
            "Sunken Ship, puzzle room 2",
            "Sunken Ship, Area 02 (from entrance w/save point)",
            "Sunken Ship, Area 06 (puzzle room passageway)",
            "Sunken Ship, puzzle room 1",
            "Sunken Ship, Area 05 (long stairwell with running Alley Rats)",
            "Sunken Ship, puzzle room 3",
            "Sunken Ship, Area 07 (puzzle room passageway branch room w/Shaman)",
            "Sunken Ship, Area 14 ____dummy",
            "Sunken Ship, puzzle room 4",
            "Sunken Ship, puzzle room 5",
            "Sunken Ship, post-KC Area 01 (small room w/Trampoline)",
            "Sea, Area 08 (shore with Sunken Ship)",
            "Sunken Ship, post-KC Area 05 (w/Dry Bones, linked by Mario mirror room)",
            "Sunken Ship, Area 08 (w/save point and green switch for barrel)",
            "Sunken Ship, Area 09 (Password room)",
            "Sunken Ship, post-KC Area 04 (long stairwell w/running Alley Rats)",
            "Sunken Ship, post-KC Area 06 (Mario Mirror room)",
            "Sunken Ship, post-KC Area 02 (small 2-level room)",
            "Sunken Ship, post-KC Area 03 (Alley Rats on cannons)",
            "Sunken Ship, post-KC Area 07 (three Dry Bones)",
            "Sunken Ship, post-KC Area 08 (secret room with Frog Coin)",
            "Sunken Ship, post-KC Area 09 (Hidon's room w/save point)",
            "Sunken Ship, post-KC Area 14 (secret Safety Ring)",
            "Sunken Ship, post-KC Area 18 (warp room from Johnny's room)",
            "Sunken Ship, post-KC Area 10 (water room with frog coins)",
            "Sunken Ship, post-KC Area 11 (water room with whirlpool)",
            "Mario's Pipehouse",
            "Mushroom Kingdom, during Mack, Outside",
            "Mushroom Kingdom, Outside",
            "Booster Tower, 9F Area 02 (Booster's curtain game room)",
            "Booster Tower, 2F Area 03 (steps w/circling Bob-ombs)",
            "Booster Tower, 2F Area 02 (Booster's railway room)",
            "Booster Tower, 6F Area 02 (Booster's Ancestor Game room)",
            "Booster Tower, 2F Area 01 (w/constantly appearing Spookums)",
            "Booster Tower, 1F Area 02 (high Masher room w/teeter-totter)",
            "Booster Tower, 8F Area 03 (3-level w/one Chomp)",
            "Booster Tower, 9F Area 01 (three yellow platforms w/save point)",
            "Booster Tower, 6F Area 03 (Elder's Room w/Chomp)",
            "Booster Tower, 6F Area 01 (small room w/save point)",
            "Booster Tower Entrance",
            "Mushroom Way, Area 01",
            "Mushroom Way, Area 02",
            "Mushroom Way, Area 03",
            "Bandit's Way, Area 05",
            "Bandit's Way, Area 02",
            "Seaside Town, during Yaridovich Outside",
            "Seaside Town, during Yaridovich Inn (1F)",
            "Seaside Town, during Yaridovich Inn (2F)",
            "Seaside Town, during Yaridovich Elder's House (1F)",
            "Seaside Town, during Yaridovich Elder's House (2F)",
            "Seaside Town, during Yaridovich Beetles Are Us/Bomb Shop",
            "Seaside Town, during Yaridovich Weapons and Armor Shop",
            "Seaside Town, during Yaridovich Health Food Store (left-most)",
            "Seaside Town, during Yaridovich Mushroom Boy Shop (middle)",
            "Seaside Town, during Yaridovich Accessory Shop (right-most)",
            "Seaside Town, during Yaridovich Shed (unused b/c inaccessible)",
            "GAME INTRO: Sea, shore with Sunken Ship",
            "Smithy Factory, Area 02 (w/save point)",
            "Smithy Factory, Area 04 (green switch w/Ameboids)",
            "Smithy Factory, Area 03 (Glum Reapers)",
            "Smithy Factory, Area 07 (Count Down's room)",
            "Forest Maze, Area 01",
            "Forest Maze, Area 05 (tree trunk Area)",
            "Forest Maze, Area 02",
            "Forest Maze, Area 09 (leads to 4-path maze)",
            "Forest Maze, Area 04",
            "Forest Maze, Area 06",
            "Forest Maze, 4-way path from Area 09",
            "Forest Maze, Secret entrance",
            "Forest Maze, Bowyer's practice pad",
            "Forest Maze, Area 03 (underground)",
            "Forest Maze, Secret",
            "Forest Maze, Area 08 (underground)",
            "Forest Maze, Area 07 (underground w/sleeping Wiggler)",
            "Smithy Factory, Area 05 (w/save point)",
            "Smithy Factory, fall from lugnut rooms (Area 06 & prior)",
            "Smithy Factory, Area 06 (Ultra Hammer)",
            "Volcano, Area 21 ____dummy",
            "Volcano, Area 02 ____dummy",
            "Forest Maze, all tree trunk underground areas",
            "GAME INTRO: Mushroom Kingdom Castle, Throne Room",
            "GAME INTRO: Yo'ster Isle, talk to Yoshi & run around",
            "GAME INTRO: Pipe Vault, Area 02 (w/Thwomp)",
            "GAME INTRO: Kero Sewers, Entrance",
            "GAME INTRO: Tadpole Pond, Mario summons tadpoles",
            "GAME INTRO: Mushroom Way, Area 01",
            "GAME INTRO: Vista Hill",
            "GAME INTRO: Booster Tower, balcony with Toadstool crying",
            "Bean Valley, piranha pipe Area",
            "Bean Valley, main Area",
            "Bean Valley, magic brick to Beanstalk Area",
            "Bean Valley, Smilax Area",
            "Monstro Town, Jinx's Dojo",
            "Forest Maze, Small area w/tree trunk (unused?)",
            "GAME INTRO: Forest Maze, fighting Magikoopa at Bowyer's Pad",
            "Booster Tower, Balcony at top floor",
            "Booster Tower, 3F Area 01 (green switch for BP secret)",
            "GAME INTRO: Forest Maze, jumping on Wiggler",
            "Bowser's Keep 1st time, Area 03 (lava room w/bridge)",
            "Land's End Underground, Area 04 (buy super stars)",
            "Land's End Underground, Area 01",
            "Land's End Underground, Area 02",
            "Land's End Underground, Area 03",
            "Bowser's Keep, Area 10 (Magikoopa's room)",
            "Monstro Town, entrance",
            "Belome Temple, Area 08 (Belome's room)",
            "ENDING CREDITS: Nimbus Land, Prince Mallow",
            "Land's End secret underground, Area 01 (leads to Kero Sewers)",
            "Moleville Mines, Area 17 (Punchinello's room, after battle)",
            "Moleville Mines, Area 11 (bombed room w/singing Moles)",
            "Moleville Mines, Area 04 (w/trampoline)",
            "Moleville Mines, Area 02",
            "Moleville Mines, Area 06 (small room leading to Area 06)",
            "Moleville Mines, Area 01 (entrance)",
            "Moleville Mines, Area 05 (left of trampoline room)",
            "Moleville Mines, Area 03 (leads back to Area 1)",
            "Moleville Mines, Area 08 (Croco's bombed room)",
            "Moleville Mines, Area 15 (2-level room w/Sparky and 10-coin TC)",
            "Moleville Mines, Area 07 (from Croco's bombed room)",
            "Moleville Mines, Area 10 (small room w/minecart tracks)",
            "Moleville Mines, Area 09 (leads left to Croco's bombed room)",
            "Moleville Mines, Area 18 (minecart room)",
            "Moleville Mines, Area 13 (long minecart tracks room)",
            "Moleville Mines, Area 12 (2-level room, leads to long minecart tracks room)",
            "Moleville Mines, Area 14 (2-level room from long minecart tracks room)",
            "Moleville Mines, Area 16 (large save-point room w/four Bob-ombs)",
            "Moleville Mines, Area 17 (Punchinello's room, before battle)",
            "Moleville Mines, Area 19 (from outside after paying)",
            "GAME INTRO: Booster Tower, 7F (parachuting Spookums)",
            "____unmapped house room",
            "____unmapped house room",
            "____unmapped house room",
            "____unmapped house room",
            "____unmapped house room",
            "____unmapped outside townplace (resembles Seaside Town)",
            "____unmapped house room",
            "____unmapped house room",
            "____unmapped house room",
            "Kero Sewers, Area 07 (water switch room w/Boos)",
            "Kero Sewers, Area 08 (Belome's Room)",
            "Kero Sewers, Area 08 (Belome's Room, after defeat)",
            "Seaside Town, Outside",
            "Seaside Town, Inn (1F)",
            "Seaside Town, Inn (2F)",
            "Seaside Town, Elder's house (1F)",
            "Seaside Town, Elder's house (2F)",
            "Seaside Town, Beetles Are Us",
            "Seaside Town, Weapon and Armor shop",
            "Seaside Town, Health Food Store",
            "Seaside Town, Mushroom Boy's Shop",
            "Seaside Town, Accessory Shop",
            "Seaside Town, Shed",
            "Seaside Town, during Yaridovich Beach",
            "Seaside Town, Beach",
            "Land's End Desert, Area 01",
            "Land's End Desert, Area 02",
            "Land's End Desert, Area 06",
            "Mushroom Kingdom Castle, Entrance to Throne room",
            "Bowser's Keep 6-door, Action Room 2-A (slow elevating platforms)",
            "Bowser's Keep 6-door, Action Room 1-A (jumping Terrapin)",
            "Mushroom Kingdom Castle, during Mack entrance to Throne Room",
            "Monstro Town, outside",
            "Mushroom Kingdom Castle, during Mack Main Hall",
            "Mushroom Kingdom Castle, during Mack Throne Room",
            "Mushroom Kingdom Castle, during Mack stairwell to Toadstool's Room",
            "Mushroom Kingdom Castle, during Mack Toadstool's Room",
            "Mushroom Kingdom Castle, during Mack branch room to Vault/Guest Room",
            "Mushroom Kingdom Castle, during Mack Guest room",
            "Mushroom Kingdom Castle, during Mack Vault",
            "Mushroom Kingdom Castle, during Mack entrance to Toadstool's room",
            "Kero Sewers Entrance",
            "Bean Valley pipe room, left-most pipe",
            "Bean Valley pipe room, right-most pipe (large room)",
            "Moleville, Item Shop",
            "Moleville, Inn",
            "Moleville, Dyna and Mite's house",
            "Moleville, Fireworks shop",
            "Moleville, Special item-trading shop",
            "Nimbus Land, Garro's House",
            "Nimbus Land, lower house",
            "Nimbus Land, Inn",
            "Nimbus Land, Item Shop",
            "Nimbus Land, top-right house (Croco drops Signal Ring)",
            "Nimbus Land, Inn (bedroom)",
            "Bean Valley pipe room, top pipe (leads to Grate Guy's Casino)",
            "Bean Valley pipe room, bottom left",
            "Bean Valley pipe room, bottom right",
            "Smithy Factory, Area 01",
            "Culex's Room",
            "Volcano, Area 21 (Czar Dragon's room)",
            "Volcano, Area 18 (Hino Mart)",
            "Volcano, Area 01",
            "Volcano, Area 03 (secret w/two flowers)",
            "Volcano, Area 08",
            "Volcano, Post-CD Area 01",
            "Volcano, Area 11",
            "Volcano, Area 02",
            "Volcano, Area 04 (bunch of steps)",
            "Volcano, Area 09",
            "Volcano, Area 07 (stomping Corkpedite)",
            "Volcano, Area 15 (stomping Corkpedite)",
            "Volcano, Area 14",
            "Volcano, Post-CD Area 03",
            "Volcano, Area 13 (w/save point)",
            "Volcano, Area 17 (leads to Hinopio's Shop)",
            "Nimbus Land, Royal Bus station",
            "Nimbus Land, entrance (w/warp trampoline)",
            "Nimbus Land, entrance to hot springs",
            "Nimbus Land, fall from platform (1st)",
            "Nimbus Land, fall from platform (2nd)",
            "Nimbus Land, fall from platform (3rd)",
            "Nimbus Land, fall from platform (4th)",
            "ENDING CREDITS: Vista Hill (Exor vanishes from the world)",
            "Bowser's Keep 6-door, Battle Room 2-B (1st fight: Chewy)",
            "Bowser's Keep 6-door, Battle Room 2-C (1st fight: Sparky)",
            "Bean Valley Beanstalks, Area 01",
            "Bean Valley Beanstalks, Area 02",
            "Bean Valley Beanstalks, Area 03 (from right beanstalk of Area 02)",
            "Bean Valley Beanstalks, Area 04 (from left beanstalk of Area 02)",
            "Nimbus Land, entrance (no trampolines/exits)",
            "Volcano, Area 10 (jumping Pyrospheres)",
            "Volcano, Area 05",
            "Volcano, Area 06",
            "Volcano, Area 12 (erupting Stumpet)",
            "Volcano, Area 19 (from Hino Mart w/save point)",
            "Volcano, Post-CD Area 02",
            "Volcano, Area 20 (jumping Pyrospheres)",
            "Volcano, Area 16 (erupting Stumpet)",
            "Volcano, Post-CD Area 04",
            "Volcano, Post-CD Area 06",
            "Volcano, Post-CD Area 07 (warp to World Map)",
            "Volcano, Post-CD Area 05",
            "Monstro Town, Monstermama's house (1F)",
            "Monstro Town, Monstermama's house (2F)",
            "Monstro Town, super-jumping room",
            "Monstro Town, Weapon and Armor Shop",
            "Monstro Town, 3 Musty Fears Inn",
            "Bowser's Keep, Area 13 (2nd throne room, Boomer's room)",
            "Land's End secret underground, Area 02 (leads to Kero Sewers)",
            "Land's End Desert, Area 03",
            "Land's End Desert, Area 05",
            "Land's End Desert, Area 04",
            "Booster Pass, Secret",
            "Factory Grounds, Area 01 (with Toad)",
            "Land's End Cliff (climb w/Sky Troopas)",
            "Nimbus Castle, Area 14 (right-most front door of long 5-exit room) ",
            "Nimbus Castle, Area 09 (Birdo's Room)",
            "Nimbus Castle, Area 07 (straight from Area 06 w/long staircase)",
            "Nimbus Castle, path after Throne room (1st)",
            "Nimbus Castle, Area 11 (long hallway, door to King's Cellar)",
            "Nimbus Castle, King's locked cellar",
            "Nimbus Castle, Area 08 (from Area 07, get Room Key 1 here)",
            "Nimbus Land, small platform after Nimbus Castle throne paths",
            "Nimbus Land, outside (before Valentina)",
            "Gardener's House, outside",
            "Gardener's House",
            "Lazy Shell cloud",
            "Belome Temple, Area 02 (Fortune Room)",
            "Belome Temple, Area 04 (room determined by fortune)",
            "Belome Temple, Area 09 (Belome's Treasure room)",
            "Belome Temple, Area 06 (Belome's fortune room w/elevating platform)",
            "Belome Temple, Area 03 (pipe to room determined by fortune)",
            "Belome Temple, Area 05 (from Fortune Room)",
            "Belome Temple, Area 07 (pipe to Belome's room)",
            "Belome Temple, Area 10 (pipe to Monstro Town)",
            "Belome Temple, Area 01 (w/Warp Trampoline)",
            "GAME INTRO: Nimbus Land, outside with patrolling Birdies",
            "Nimbus Land, outside (during Valentina)",
            "Bowser's Keep 6-door, Puzzle Rooms",
            "ENDING CREDITS: Johnny looking out at sunset on beach shore",
            "Smithy Factory, Area 01 ____dummy",
            "Smithy Factory, Area 09 (falling Axem Reds on conveyor belts)",
            "ENDING CREDITS: Bowser's Keep, Bowser & troops repair",
            "Smithy Factory, Area 01 ____dummy",
            "Nimbus Castle, path after Throne room (3rd)",
            "Nimbus Land, outside (after Valentina)",
            "Bowser's Keep, outside (talk to Exor)",
            "Nimbus Castle, Area 13 (Throne room, after Valentina)",
            "ENDING CREDITS: Toadofsky conducts choir",
            "Smithy Factory, Area 11 (conveyor belts spawning Drill Bits and Macks)",
            "Smithy Factory, Area 16 (small room w/two treasures after falling Yaridovich room)",
            "Smithy Factory, Area 09 ____dummy",
            "Smithy Factory, Area 10 (fall from Area 09)",
            "Bowser's Keep 6-door, exit room after finishing 4 doors",
            "Nimbus Land, hot springs",
            "Bowser's Keep, Area 09 (tall room, w/save point)",
            "Bowser's Keep, Area 11 (Thwomp/Bullet room after Magikoopa's room)",
            "Bowser's Keep, Area 12 (Croco's Shop 2, after Magikoopa's room)",
            "Bowser's Keep, Area 07 (150 coins and a mushroom)",
            "Bowser's Keep, Area 06 (save point w/Croco shop)",
            "Bowser's Keep, Area 05 (dark tunnel, after throne room)",
            "Bowser's Keep, Area 08 (room with 6 doors)",
            "Bowser's Keep 6-door, Action Room 2-C (very slow moving circling platforms)",
            "Bowser's Keep 6-door, Action Room 1-C (Gorilla throwing barrels)",
            "Bowser's Keep 6-door, Action Room 2-B (cannonball riding)",
            "Bowser's Keep 6-door, Action Room 1-B (moving platforms)",
            "Bowser's Keep 6-door, Battle Room 1-A (1st fight: Terra Cotta)",
            "Bowser's Keep 6-door, Battle Room 1-B (1st fight: Alley Rat)",
            "Bowser's Keep 6-door, Battle Room 1-C (1st fight: Bob-Omb)",
            "Bowser's Keep 6-door, Battle Room 2-A (1st fight: Gu Goomba)",
            "Bowser's Keep 6-door, Puzzle Room 1-B (barrel-counting)",
            "Bowser's Keep 6-door, Puzzle Room 1-A (quiz)",
            "Bowser's Keep 6-door, Puzzle Room 2-B (green switches)",
            "Bowser's Keep 6-door, Puzzle Room 1-C (word problem)",
            "Bowser's Keep 6-door, Puzzle Room 2-A (coin collecting)",
            "Bowser's Keep 6-door, Puzzle Room 2-C (ball solitaire)",
            "Factory Grounds, Area 01",
            "Factory Grounds, Area 04 (Gun Yolk's room)",
            "Factory Grounds, Area 02",
            "Factory Grounds, Area 03",
            "Smithy Factory, Area 13 (Bowyers falling down conveyor belts)",
            "Smithy Factory, Area 15 (falling Yaridovichs)",
            "Smithy Factory, Area 12 (lots of consecutive conveyor belts and LIL{xx}BOOS)",
            "Bowser's Keep 2nd Time, Area 01",
            "Bowser's Keep 2nd Time, Area 02",
            "Bowser's Keep 2nd Time, Area 03 (lava room w/bridge)",
            "Bowser's Keep 2nd Time, Area 04 (Throne Room)",
            "Mushroom Kingdom, during Mack, jumping kid's house (1F)",
            "Mushroom Kingdom, during Mack, jumping kid's house (2F)",
            "Mushroom Kingdom, during Mack, Raz and Raini's house",
            "Mushroom Kingdom, during Mack, Item Shop (top floor)",
            "Mushroom Kingdom, during Mack, Item Shop (basement)",
            "Mushroom Kingdom, during Mack, Inn (1F)",
            "ENDING CREDITS: Star Pieces (Rose Town), last star piece to ‘Thank You'",
            "Mushroom Kingdom, during Mack, running kid's house",
            "Mushroom Kingdom, jumping kid's house (1F)",
            "Mushroom Kingdom, jumping kid's house (2F)",
            "Mushroom Kingdom, Raz and Raini's house",
            "Mushroom Kingdom, Item Shop (top floor)",
            "Mushroom Kingdom, Item Shop (basement)",
            "Mushroom Kingdom, Inn (1F)",
            "Mushroom Kingdom, Inn (2F)",
            "Mushroom Kingdom, running kid's house",
            "ENDING CREDITS: Factory Grounds, fight with Smithy",
            "Nimbus Castle, Area 06 ____dummy",
            "Nimbus Castle, Area 10 ____dummy",
            "Nimbus Castle, Area 05 (long 5-exit room, after Valentina)",
            "Nimbus Castle, Area 04 ____dummy",
            "Nimbus Castle, Area 03 (4-way path, after Valentina)",
            "Nimbus Land, Dream Cushion Dream: small cloud, person cheers on Mario/bed floats",
            "Nimbus Land, Dream Cushion Dream: Heavy Troopa laying on Mario",
            "Nimbus Land, Dream Cushion Dream: Tortes are seasoning Mario",
            "ENDING CREDITS: Yo'ster Isle, Croco racing Yoshi",
            "ENDING CREDITS: Marrymore Chapel, Booster wedding Valentina",
            "Smithy Factory, Area 08 (Trampoline after Count Down)",
            "Smithy Factory, Area 14 (w/save point)",
            "Factory Grounds, Smithy's Pad"
        };
        public static string[] GraphicSetNames = new string[]
        {
            "{NONE}",
            "Keep walls",
            "Keep wall decor",
            "Keep doormat, doors",
            "Rope bridge, lava",
            "Keep window grates",
            "Gargoyles and pillars",
            "Barrel Volcano",
            "Royal Bus",
            "Kingdom houses",
            "Castle exterior",
            "Castle doors, fireplace",
            "Keep turrets",
            "Keep gargoyle hill",
            "Keep ground",
            "Keep body",
            "Keep body edges",
            "House interior",
            "Grates, stoves",
            "Crates, boxes",
            "Beds",
            "Shacks interior",
            "House exterior",
            "House doors",
            "Mines plywood",
            "Mines crates, lanterns",
            "Town decor",
            "Castle walls",
            "Castle wall decor",
            "Castle interior",
            "Tower wall decor",
            "Tower curtains",
            "Casino interior",
            "Tower floor",
            "____",
            "Forest terrain",
            "Forest tree trunks",
            "Forest battlefield",
            "Forest dirt",
            "Seashells",
            "Ship walls,doors",
            "Ship interior",
            "Ship pipes",
            "Shark emblem",
            "Doors",
            "Desert decor",
            "____",
            "Temple floors",
            "Temple walls",
            "Temple pillars",
            "Temple steps",
            "Shacks",
            "Mountain",
            "Mountain decor",
            "Mines floor",
            "Mines railing",
            "Stalactites/stalagmites",
            "Molten lava",
            "Arrow signs",
            "Palm trees, hills 1",
            "Palm trees, seat",
            "Seashore rocks",
            "Seashore cliffs",
            "Dojo walls, floor",
            "Grassland hills",
            "Grassland grass",
            "Grassland ground",
            "Pipehouse roof",
            "Pipehouse porch",
            "Tower, exterior",
            "Tower, entrance 1",
            "____",
            "Palm trees, hills 2",
            "Tower, entrance 2",
            "Seashore Ship",
            "Yo’ster Isle",
            "Marrymore Scene",
            "Ground puddle",
            "Plains hills, trees",
            "Plains ground, rock",
            "Rotating flowers",
            "Countryside",
            "____",
            "Plains escarpment",
            "Booster Hill sand",
            "Booster Hill cactus",
            "Booster Hill BG",
            "Nimbus Castle, exterior",
            "Nimbus leaves",
            "Nimbus leaves, briar",
            "Exor Battlefield",
            "Exor's hilt",
            "Exor's head",
            "Exor's face",
            "Exor's arms",
            "Ground/Mist",
            "“Hollow” sign",
            "Nimbus exterior",
            "Nimbus Castle walls",
            "Nimbus Castle interior 1",
            "Nimbus Castle interior 2",
            "Smithy Factory, floor",
            "Smithy Factory, pillar top",
            "Smithy Factory, pillar lower",
            "Smithy Factory, pillar floor",
            "Conveyor belts",
            "Seashore Ship, seafloor",
            "Sanctuary walls",
            "Sanctuary organ",
            "Nimbus house interior 1",
            "Nimbus house interior 2",
            "The Blade",
            "Shelly, nest",
            "Birdo's egg, nest",
            "Keep, throne walls",
            "Keep, throne steps",
            "Keep, throne floor",
            "Keep, throne gargoyles",
            "Chandeliers",
            "____",
            "River water",
            "Star Hill exterior",
            "Star Hill decor",
            "Vista Hill Keep",
            "Beanstalks",
            "Seashore Sunset",
            "Factory floor, crane",
            "Factory structures",
            "Stump battlefield top",
            "Stump battlefield lower",
            "Factory conveyor belts",
            "Mist/clouds",
            "Beanstalk leaf (top)",
            "Beanstalk leaf (lower)",
            "Beanstalk vine (top)",
            "Beanstalk leaf (right)",
            "Ship cellar (top)",
            "Ship cellar (bottom)",
            "Ship, barrels",
            "Mines interior",
            "Factory walls",
            "Keep repairs",
            "Czar Dragon gargoyles",
            "Grasslands grass",
            "Grasslands hills",
            "Mountain bushes",
            "House interior corners",
            "Tower, backdoor",
            "Water sewer walls",
            "Tower balcony clouds",
            "Beanstalk leaf (left)",
            "Castle candle holders",
            "Beanstalk clouds",
            "Dirt mountains",
            "Dirt mountains",
            "Tower balcony top",
            "Tower balcony lower",
            "Countdown",
            "Sewers back wall",
            "____palette tiles",
            "Nimbus Castle interior 3",
            "Birdo's nest egg",
            "Birdo's nest",
            "Nimbus briar",
            "Nimbus leaves",
            "____forest vines",
            "____unknown",
            "Town 2, exterior",
            "Keep carpet, walls",
            "Town 2, decor",
            "Forest path",
            "Level-Up FG",
            "Menu BG 1",
            "Menu BG 2",
            "Plains palm trees",
            "Sea Enclave",
            "Sanctuary organ",
            "Level-Up BG",
            "Star Hill",
            "Beach rocks, sunset",
            "Blade Roof",
            "Blade Roof, BG",
            "Blade Roof, BG",
            "Giant snake body",
            "Desert cactus, floor",
            "Factory floor/walls",
            "Factory chains/bolts",
            "Factory structure",
            "Smithy 2, head/pipes",
            "Smithy 2, small heads",
            "Smithy 2, big heads",
            "Culex battlefield BG",
            "Factory metals",
            "Factory chains/bolts",
            "Nimbus throne",
            "Yo’ster Isle flowers",
            "Desk, floors, boxes",
            "Count Down",
            "____",
            "Vista Hill Exor"
        };
        public static string[] TileSetL3Names = new string[]
        {
            "{NOTHING}",
            "Booster Tower",
            "Mansion, inside",
            "Forest Maze",
            "Sunken Ship",
            "Kero Sewers",
            "____",
            "Water",
            "Grasslands",
            "River",
            "____",
            "Waterfall",
            "Clouds",
            "Yo\'ster Isle",
            "Maps",
            "Towns 2",
            "Sewers",
            "Houses, inside",
            "Grasslands 2",
            "Keep, throne",
            "Booster Hill",
            "Star Hill",
            "Marrymore Scene",
            "Nimbus Land",
            "Keep, inside",
            "Temples",
            "Desert",
            "____",
            "Smithy Factory",
            "____",
            "Smithy 2",
            "____",
            "____",
            "____"
        };
        public static string[] TileSetNames = new string[]
        {
            "Houses, inside  (L1)",
            "Houses, inside  (L2)",
            "____",
            "Keep, puzzles (L2)",
            "Towns 1 (L1)",
            "Towns 1 (L2)",
            "Grasslands 1 (L1)",
            "Towns 2 (L1)",
            "Towns 2 (L2)",
            "Sewers (L1)",
            "Sewers (L2)",
            "Keep, outside (L1)",
            "____",
            "____",
            "Tower, entrance (L1)",
            "Tower, entrance (L2)",
            "Keep, puzzles (L1)",
            "Keep, inside (L1,2)",
            "Pipe Rooms (L1,2)",
            "Mansion (L1)",
            "Mansion (L2)",
            "Forest Maze (L1)",
            "Forest Maze (L2)",
            "Sunken Ship (L1)",
            "Sunken Ship (L2)",
            "Mountains (L1)",
            "Mountains (L2)",
            "Underground (L1,2)",
            "Underground (L1,2)",
            "Tower, inside (L1)",
            "Tower, inside (L2)",
            "Seashore (L1)",
            "Seashore (L2)",
            "Plains (L1,2)",
            "Underground 2 (L1)",
            "Underground 2 (L2)",
            "Riverside (L1)",
            "Riverside (L2)",
            "Clouds (L1)",
            "Clouds (L2)",
            "____",
            "Culex (L1)",
            "Culex (L2)",
            "Grasslands 2 (L1)",
            "Grasslands 2 (L2)",
            "Waterfall (L1)",
            "Waterfall (L2)",
            "Nimbus Castle (L1)",
            "Nimbus Castle (L2)",
            "Yo'ster Isle (L1)",
            "Yo'ster Isle (L2)",
            "Smithy Factory (L1,2)",
            "____",
            "____",
            "Count Down (L1)",
            "____",
            "Sanctuary (L1)",
            "Sanctuary (L2)",
            "Keep, inside (L1,2)",
            "____",
            "____",
            "Shacks (L1)",
            "Grasslands 1 (L2)",
            "Keep, outside (L2)",
            "Keep, throne (L1)",
            "Keep, throne (L2)",
            "Keep, inside (L1)",
            "Keep, inside (L2)",
            "Midas River (L2)",
            "Water Tunnels (L1)",
            "Water Tunnels (L2)",
            "Suite (L1)",
            "Volcano Map (L1)",
            "Star Hill (L1,2)",
            "Vista Hill (L1,2)",
            "Marrymore Scene (L1,2)",
            "Tower Balcony (L1,2)",
            "Bean Valley (L1)",
            "Bean Valley (L2)",
            "Nimbus Land (L1)",
            "Nimbus Land (L2)",
            "Volcano, Map (L2)",
            "Jinx's Dojo (L1,2)",
            "Factory Grounds (L1,2)",
            "____",
            "Ending, Seashore (L1,2)",
            "Ending, Keep (L1,2)",
            "Ending, Toadofsky (L1)",
            "Ending, Toadofsky (L2)",
            "____",
            "Ending, Yo'ster Isle (L1)",
            "Ending, Yo'ster Isle (L2)",
            "____"
        };
        public static string[] TileMapNames = new string[]
        {
            "Bowser’s Keep, outside (L2)",
            "____",
            "Chapel Kitchen (L1)",
            "Chapel Kitchen (L2)",
            "Land's End 1 (L1)",
            "Land's End 1 (L2)",
            "Booster Tower 1 (L1)",
            "Booster Tower 1 (L2)",
            "____",
            "____",
            "Mushroom Kingdom houses (L1)",
            "Mushroom Kingdom houses (L2)",
            "Mario's Pad, outside (L1)",
            "Mario's Pad, outside (L2)",
            "Grate Guy's Casino, outside (L1)",
            "Grate Guy's Casino, outside (L2)",
            "Bowser's Keep 1 (L1)",
            "Bowser's Keep 1 (L2)",
            "Forest Maze 1 (L1)",
            "Forest Maze 1 (L2)",
            "____",
            "____",
            "Rose Town (L1)",
            "Rose Town (L2)",
            "Kero Sewers 1 (L1)",
            "Kero Sewers 1 (L2)",
            "____",
            "____",
            "Tadpole Pond 1 (L1)",
            "Tadpole Pond 1 (L2)",
            "Beach (L1)",
            "Beach (L2)",
            "Castle Rooms (L1)",
            "Castle Rooms (L2)",
            "Sunken Ship 1 (L1)",
            "Sunken Ship 1 (L2)",
            "Forest Maze 1 (L1)",
            "Forest Maze 1 (L2)",
            "Forest Maze 2 (L1)",
            "Forest Maze 2 (L2)",
            "Forest Maze 3 (L1)",
            "Forest Maze 3 (L2)",
            "____",
            "____",
            "Sunken Ship 2 (L1)",
            "Sunken Ship 2 (L2)",
            "Debug Room (L1)",
            "Debug Room (L2)",
            "Barrel Volcano 1 (L1)",
            "Barrel Volcano 1 (L2)",
            "Barrel Volcano 2 (L1)",
            "Barrel Volcano 2 (L2)",
            "Kero Sewers 2 (L1)",
            "Kero Sewers 2 (L2)",
            "Rose Town houses (L1)",
            "Rose Town houses (L2)",
            "Booster Pass secret (L1)",
            "Booster Pass secret (L2)",
            "Booster Tower entrance (L1)",
            "Booster Tower entrance (L2)",
            "Seashore (L1)",
            "Seashore (L2)",
            "Booster Tower 1 (L1)",
            "Booster Tower 1 (L2)",
            "Mushroom Kingdom (L1)",
            "Mushroom Kingdom (L2)",
            "Bowser's Keep outside(L1)",
            "____",
            "Seaside Town houses (L1)",
            "Seaside Town houses (L2)",
            "Moleville shacks (L1)",
            "Moleville shacks (L2)",
            "Forest Maze underground (L1)",
            "Forest Maze underground (L2)",
            "Forest Maze, area 7 (L1)",
            "Forest Maze, area 7 (L2)",
            "Land's End underground (L1)",
            "Land's End underground (L2)",
            "Moleville Mines 1 (L1)",
            "Moleville Mines 1 (L2)",
            "____",
            "____",
            "____",
            "____",
            "Land's End grasslands (L1)",
            "Land's End grasslands (L2)",
            "Moleville Mines 2 (L1)",
            "Moleville Mines 2 (L2)",
            "Moleville Mines 3 (L1)",
            "Moleville Mines 3 (L2)",
            "____",
            "____",
            "Plains (L1)",
            "Plains (L2)",
            "Booster Hill (L1)",
            "Booster Hill (L2)",
            "Tadpole Pond 2 (L1)",
            "Tadpole Pond 2 (L2)",
            "Clouds (L1)",
            "Clouds (L2)",
            "____",
            "____",
            "Bowser's Keep 2 (L1)",
            "Bowser's Keep 2 (L2)",
            "___forest (L1)",
            "___forest (L2)",
            "Midas River (L1)",
            "Midas River (L2)",
            "Yo'ster Isle (L1)",
            "Yo'ster Isle (L2)",
            "Suite (L1)",
            "Suite (L2)",
            "Waterfall (L1)",
            "Waterfall (L2)",
            "___underground (L1)",
            "___underground (L2)",
            "Rose Way (L1)",
            "Rose Way (L2)",
            "____",
            "____",
            "Marrymore (L1)",
            "Marrymore (L2)",
            "Nimbus Castle 1 (L1)",
            "Nimbus Castle 1 (L2)",
            "Nimbus Castle 2 (L1)",
            "Nimbus Castle 2 (L2)",
            "Bowser's Keep Bridge (L1)",
            "Bowser's Keep Bridge (L2)",
            "Sea (L1)",
            "Sea (L2)",
            "Pipe Vault (L1)",
            "Pipe Vault (L2)",
            "____",
            "____",
            "Booster Tower balcony (L1)",
            "Beanstalks (L1)",
            "Smithy Factory 1 (L1)",
            "Smithy Factory 1 (L2)",
            "Smithy Factory 2 (L1)",
            "Smithy Factory 2 (L2)",
            "Smithy Factory 3 (L1)",
            "Smithy Factory 3 (L2)",
            "Nimbus Land houses (L1)",
            "Nimbus Land houses (L2)",
            "Star Hill 2 (L1)",
            "Star Hill 2 (L2)",
            "Bean Valley pipes (L1)",
            "Bean Valley pipes (L2)",
            "____",
            "____",
            "Chapel, main hall (L1)",
            "Chapel, main hall (L2)",
            "Chapel sanctuary (L1)",
            "Chapel sanctuary (L2)",
            "Belome Temple 1 (L1)",
            "Belome Temple 1 (L2)",
            "____",
            "____",
            "____",
            "____",
            "Bandit's Way 1 (L1)",
            "Bandit's Way 1 (L2)",
            "Bandit's Way 2 (L1)",
            "Bandit's Way 2 (L2)",
            "Mario's Pipehouse (L1)",
            "Mario's Pipehouse (L2)",
            "Mushroom Way 1 (L1)",
            "Mushroom Way 1 (L2)",
            "____",
            "____",
            "Kero Sewers, area 1 (L1)",
            "Kero Sewers, area 1 (L2)",
            "Rose Way, area 1 (L1)",
            "Rose Way, area 2 (L2)",
            "Midas River tunnels (L1)",
            "Midas River tunnels (L2)",
            "Booster Pass 1 (L1)",
            "Booster Pass 1 (L2)",
            "Moleville (L1)",
            "Moleville (L2)",
            "Volcano Map (L1)",
            "Volcano Map (L2)",
            "Sunken Ship 3 (L1)",
            "Sunken Ship 3 (L2)",
            "Vista Hill (L1)",
            "Vista Hill (L2)",
            "Marrymore Scene (L1)",
            "Marrymore Scene (L2)",
            "Bean Valley (L1)",
            "Bean Valley (L2)",
            "Beanstalks (L2)",
            "Land's End Underground 2 (L1)",
            "Land's End Underground 2 (L2)",
            "Land's End Desert (L1)",
            "Land's End Desert (L2)",
            "Barrel Volcano 1 (L1)",
            "Barrel Volcano 1 (L2)",
            "Jinx's Dojo (L1)",
            "Factory Grounds 1 (L1)",
            "Monstro Town houses (L1)",
            "Monstro Town houses (L2)",
            "Monstro Town (L1)",
            "Monstro Town (L2)",
            "Bowser's Keep 6-doors 1 (L1)",
            "Bowser's Keep 6-doors 1 (L2)",
            "Culex's Room (L1)",
            "Culex's Room (L2)",
            "Bowser's Keep 6-doors 2 (L1)",
            "Bowser's Keep 6-doors 2 (L2)",
            "Bowser's Keep 3 (L1)",
            "Bowser's Keep 3 (L2)",
            "Bowser's Keep 6-doors 3 (L1)",
            "Bowser's Keep 6-doors 3 (L2)",
            "Bowser's Keep, Magikoopa (L1)",
            "Bowser's Keep, Magikoopa (L1)",
            "Bowser's Keep 6-doors 4 (L1)",
            "Bowser's Keep 6-doors 4 (L2)",
            "Bowser's Keep 6-doors 5 (L1)",
            "Bowser's Keep 6-doors 5 (L2)",
            "Ending: Seashore (L1 & 2)",
            "Factory Grounds 1 (L2)",
            "Factory Grounds 2 (L1)",
            "Factory Grounds 2 (L2)",
            "Ending: Keep repairs (L1)",
            "Ending: Keep repairs (L2)",
            "Ending: Toadofsky (L1)",
            "Ending: Toadofsky (L2)",
            "Bowser's Keep 4 (L1)",
            "Bowser's Keep 4 (L2)",
            "Nimbus clouds 2 (L1)",
            "Nimbus clouds 2 (L2)",
            "Smithy Factory 4 (L1)",
            "Smithy Factory 4 (L2)",
            "____",
            "Ending: Yo'ster Isle (L1)",
            "Ending: Yo'ster Isle (L2)",
            "____",
            "___nothing (L1)",
            "___nothing (L2)",
            "Grate Guy's Casino (L1)",
            "Grate Guy's Casino (L2)",
            "Star Hill 1 (L1)",
            "Star Hill 1 (L2)",
            "____",
            "____"
        };
        public static string[] TileMapL3Names = new string[]
        {
            "{NOTHING}",
            "Booster\'s Tower 1 ",
            "Tadpole Pond 2 ",
            "Mushroom Kingdom Castle ",
            "Forest Maze 1",
            "Forest Maze 2",
            "Sunken Ship 1 ",
            "Kero Sewers 1",
            "Sunken Ship 2 ",
            "Booster\'s Tower 2 ",
            "____",
            "Seashore",
            "Midas River ",
            "____",
            "Waterfall ",
            "____",
            "various areas…",
            "Sea",
            "Tadpole Pond 1 ",
            "Nimbus Clouds",
            "Chapel, main hall ",
            "Plains",
            "Yo\'ster Isle ",
            "Maps",
            "Mushroom Kingdom",
            "Sewers",
            "Pipehouse ",
            "Houses 1",
            "Bowser\'s Keep Throne",
            "Rose Way, area 1 ",
            "Houses 2",
            "____",
            "Rose Way",
            "Moleville shacks ",
            "Houses 3",
            "Suite",
            "Sunken Ship 3",
            "Star Hill 2",
            "Vista Hill ",
            "Seaside Town beach ",
            "Grasslands 2",
            "Marrymore Scene",
            "____",
            "Nimbus Land houses ",
            "Jinx\'s Dojo ",
            "Monstro Town houses",
            "Bowser\'s Keep 6-doors 1",
            "Pipe Rooms",
            "Culex\'s Room ",
            "Bowser\'s Keep 6-doors 2",
            "Bowser\'s Keep 2",
            "Bowser\'s Keep 3",
            "Bowser\'s Keep 6-doors 3",
            "Bowser\'s Keep 6-doors 4",
            "Belome Temple",
            "Land\'s End Desert",
            "Bowser\'s Keep 4",
            "Nimbus Land springs ",
            "Smithy Factory",
            "____",
            "Smithy 2",
            "___nothing",
            "Star Hill 1",
            "____"};
        public static string[] SolidityMapNames = new string[]
        {
            "Debug Room",
            "{NOTHING}",
            "Kero Sewers 1",
            "Bowser\'s Keep 1",
            "____",
            "Mushroom Kingdom Castle",
            "____",
            "____",
            "Gardener\'s House",
            "Seaside Town",
            "____",
            "Forest Maze 3",
            "Midas River, waterfall",
            "Forest Maze 4",
            "Rose Town",
            "____",
            "Forest Maze 2",
            "___underground areas",
            "Sunken Ship 1",
            "Sunken Ship 2",
            "Tadpole Pond 2",
            "____",
            "____",
            "Mushroom Kingdom",
            "Mushroom Kingdom houses",
            "Bowser\'s Keep Throne",
            "Booster\'s Tower 2",
            "Booster\'s Tower 1",
            "Booster\'s Tower entrance",
            "Rose Way",
            "Moleville Mines 1",
            "Moleville Mines 2",
            "Moleville Mines 3",
            "Seaside Town houses",
            "____",
            "Barrel Volcano 1",
            "Barrel Volcano 2",
            "Mario\'s Pad",
            "Rose Town houses",
            "Moleville shacks",
            "Kero Sewers 2",
            "____",
            "____",
            "Bowser\'s Keep 3",
            "Grate Guy\'s Casino",
            "Midas River",
            "Plains",
            "Grasslands",
            "Forest Maze Underground",
            "Forest Maze, area 7",
            "Land\'s End Underground",
            "Suite",
            "____",
            "Nimbus clouds",
            "Nimbus Castle 1",
            "Nimbus Castle 2",
            "Barrel Volcano 3",
            "____",
            "Sea",
            "Pipe Vault",
            "Seashore",
            "____",
            "Smithy Factory 2",
            "Smithy Factory 3",
            "Smithy Factory 1",
            "Tadpole Pond 1",
            "Nimbus Land houses",
            "Star Hill 2",
            "Pipe Rooms",
            "____",
            "____",
            "Chapel, main hall",
            "Chapel sanctuary",
            "Bowser\'s Keep Bridge",
            "Belome\'s Temple 1",
            "____",
            "____",
            "Bandit\'s Way 1",
            "Bandit\'s Way 2",
            "Pipehouse",
            "Mushroom Way 1",
            "____",
            "Kero Sewers 1",
            "Rose Way 1",
            "Waterfall tunnels",
            "Booster Pass 1",
            "Moleville",
            "Marrymore",
            "Marrymore houses",
            "Volcano map",
            "Sunken Ship 2",
            "Vista Hill",
            "Booster Hill",
            "Seaside Town beach",
            "Seaside Town",
            "Land\'s End 1",
            "Land\'s End 2",
            "Bean Valley",
            "Beanstalks",
            "____",
            "Land\'s End 3",
            "Land\'s End desert",
            "Monstro Town houses",
            "Monstro Town",
            "Jinx\'s Dojo",
            "Bowser’s Keep 6-door 1",
            "____",
            "Booster Pass secret",
            "Bowser\'s Keep 4",
            "Bowser\'s Keep 6-door 2",
            "Bowser\'s Keep Magikoopa",
            "Bowser\'s Keep 6-door 3",
            "Bowser\'s Keep 6-door 4",
            "Bowser\'s Keep 6-door 5",
            "Factory Grounds 1",
            "Factory Grounds 2",
            "Bowser\'s Keep 5",
            "Nimbus Clouds 2",
            "Smithy Factory 4",
            "Star Hill 1"};
        public static string[] PaletteSetNames = new string[]
        {
            "Bowser\'s Keep Throne",
            "____",
            "Moleville shacks",
            "Rose Town",
            "____",
            "____",
            "Grasslands 1",
            "____",
            "Bowser\'s Keep Lava",
            "Bowser\'s Keep, outside",
            "Mushroom Kingdom Castle",
            "Forest Maze",
            "Sunken Ship",
            "Sewers",
            "Mountains",
            "Mushroom Kingdom",
            "Marrymore",
            "____",
            "Booster Tower 1",
            "Underground",
            "Bowser\'s Keep 1",
            "Houses",
            "____",
            "____",
            "____",
            "Seaside Town",
            "Booster Tower entrance",
            "Seashore",
            "____",
            "Booster Hill",
            "Rose Way",
            "Nimbus Clouds",
            "Grasslands 2",
            "Culex\'s Room",
            "Plains 1",
            "Plains 2",
            "Nimbus Castle",
            "Grasslands 3",
            "Smithy Factory",
            "____",
            "Sea",
            "Tadpole Pond",
            "Yo\'ster Isle",
            "____",
            "Count Down",
            "Chapel Sanctuary",
            "Bowser\'s Keep Lava",
            "Pipe Rooms",
            "____",
            "Mushroom Kingdom dark",
            "Pipehouse",
            "Waterfall tunnels",
            "Rose Town houses",
            "Rose Town houses",
            "Sewers Gate",
            "Rose Town dark",
            "Booster Tower 2",
            "Suite",
            "Volcano Map",
            "Houses",
            "Star Hill",
            "Marrymore houses",
            "Sunken Ship 2",
            "Vista Hill",
            "Johnny\'s Room",
            "Marrymore Scene",
            "Booster Tower Balcony",
            "Bean Valley",
            "Nimbus Land houses",
            "Jinx\'s Dojo",
            "Monstro Town houses",
            "Monstro Town",
            "Bowser\'s Keep puzzles",
            "Beanstalks",
            "Land\'s End Desert",
            "Seashore sunset",
            "Belome Temple",
            "Nimbus Land",
            "Factory Grounds 2",
            "Factory Grounds 1",
            "Bowser\'s Keep repairs",
            "Nimbus Castle 2",
            "Ending: Toadofsky",
            "Nimbus Land springs",
            "Nimbus Land clouds",
            "Smithy 2",
            "____",
            "Ending: Yo\'ster Isle",
            "Smithy Pad",
            "____",
            "Ending: Nimbus Land",
            "Casino entrance",
            "Casino, inside",
            "Count Down"};
        #endregion
        #region Events
        private static string[] eventLabels = new string[0];
        private static string[] actionLabels = new string[0];
   /*
                  +1731 - Waypoint Event If $074E:3 skip #143 and go to #1746
                   +143 - Waypoint Event
                    +154 - Battle Pack 202 Seaside Town Beach BG(Hex 25 / Dec 37), Goto Event #3839 Via #143
                    +3839 - Sea Shore intro area
                     +145 - Waypoint Event
                      +155 -> Battle Pack 197 Mountains BG(Dec 10 / Hex A), Goto #997 via #145
                      +997 - Intro level Nimbus Land w/ birdbrains
                       +146 - Waypoint Event
                        +156 -> Battle Czar Dragon(204) His BG(8), Goto #2290 Via #146
                        +2290 - Booster Tower, Peach's Intro
                         +141 - Goto #2291
                          +2291 - Open Vista Hill level
                           +147 - Goto #996
                            +996 - Pipe Vault Area 01 (not faded in), "In...' text, Return.  ==END OF SCRIPTS EXECUTION HERE==
            */
        public static string[] EventLabels
        {
            get
            {
                if (eventLabels.Length == 4096)
                    return eventLabels;
                eventLabels = new string[4096];
                for (int i = 0; i < eventLabels.Length; i++)
                {
                    switch (i)
                    {
                        case 0: eventLabels[i] = "Empty"; break;
                        case 1: eventLabels[i] = "Empty"; break;
                        case 2: eventLabels[i] = "Empty"; break;
                        case 3: eventLabels[i] = "Empty"; break;
                        case 4: eventLabels[i] = "Launch Prologue"; break;
                        case 5: eventLabels[i] = "Set 70A7 To Random Tier 1 Consumable"; break;
                        case 6: eventLabels[i] = "Set 70A7 To Random Tier 2 Consumable"; break;
                        case 7: eventLabels[i] = "Set 70A7 To Random Tier 3 Consumable"; break;
                        case 8: eventLabels[i] = "Set 70A7 To Random Tier 4 Consumable"; break;
                        case 9: eventLabels[i] = "Set 70A7 To Random Tier 1 Equip"; break;
                        case 10: eventLabels[i] = "Set 70A7 To Random Tier 2 Equip"; break;
                        case 11: eventLabels[i] = "Set 70A7 To Random Tier 3 Equip"; break;
                        case 12: eventLabels[i] = "Set 70A7 To Random Tier 4 Equip"; break;
                        case 13: eventLabels[i] = "Base Rom Only Fix Map And Party"; break;
                        case 14: eventLabels[i] = "Standard Room Loader"; break;
                        case 15: eventLabels[i] = "Standard Room Loader"; break;
                        case 16: eventLabels[i] = "Fight Remove Permanently"; break;
                        case 17: eventLabels[i] = "Fight Remove Temporarily"; break;
                        case 18: eventLabels[i] = "Fight Do Not Remove"; break;
                        case 19: eventLabels[i] = "Fight Remove Permanently Blink On Run"; break;
                        case 20: eventLabels[i] = "Fight Remove Temporarily Blink On Run"; break;
                        case 21: eventLabels[i] = "Forest Maze Mushroom Grant"; break;
                        case 22: eventLabels[i] = "Better Tip Granter"; break;
                        case 23: eventLabels[i] = "Mushroom Selection"; break;
                        case 24: eventLabels[i] = "Battle Result Check"; break;
                        case 25: eventLabels[i] = "Battle Result Check Blinking"; break;
                        case 26: eventLabels[i] = "Grant Tier 1 Consumable Or Equip"; break;
                        case 27: eventLabels[i] = "Grant Tier 2 Consumable Or Equip"; break;
                        case 28: eventLabels[i] = "Grant Tier 3 Consumable Or Equip"; break;
                        case 29: eventLabels[i] = "Grant Tier 4 Consumable Or Equip"; break;
                        case 30: eventLabels[i] = "Empty"; break;
                        case 31: eventLabels[i] = "Empty"; break;
                        case 32: eventLabels[i] = "Non Coin Chest Container"; break;
                        case 33: eventLabels[i] = "Open Chest"; break;
                        case 34: eventLabels[i] = "Coin Chest Container"; break;
                        case 35: eventLabels[i] = "Mimic Or Slot Chest Container"; break;
                        case 36: eventLabels[i] = "Grant Any Consumable"; break;
                        case 37: eventLabels[i] = "Grant Any Equip"; break;
                        case 38: eventLabels[i] = "Grant Any Consumable Or Equip"; break;
                        case 39: eventLabels[i] = "Grant Any Consumable Or Equip Tier 3 Cap"; break;
                        case 40: eventLabels[i] = "Grant Any Equip Tier 3 Cap"; break;
                        case 41: eventLabels[i] = "Grant Any Consumable Tier 3 Cap"; break;
                        case 42: eventLabels[i] = "Grant Any Consumable Tier 2 Cap"; break;
                        case 43: eventLabels[i] = "Grant Any Equip Tier 2 Cap"; break;
                        case 44: eventLabels[i] = "Grant Any Consumable Or Equip Tier 2 Cap"; break;
                        case 45: eventLabels[i] = "Grant Any Consumable Exclude Worst"; break;
                        case 46: eventLabels[i] = "Grant Any Equip Exclude Worst"; break;
                        case 47: eventLabels[i] = "Grant Any Consumable Or Equip Exclude Worst"; break;
                        case 48: eventLabels[i] = "Grant Any Consumable Exclude Worst Tier 3 Cap"; break;
                        case 49: eventLabels[i] = "Grant Any Equip Exclude Worst Tier 3 Cap"; break;
                        case 50: eventLabels[i] = "Grant Any Equip Or Consumable Exclude Worst Tier 3 Cap"; break;
                        case 51: eventLabels[i] = "Empty"; break;
                        case 52: eventLabels[i] = "Empty"; break;
                        case 53: eventLabels[i] = "Empty"; break;
                        case 54: eventLabels[i] = "Empty"; break;
                        case 55: eventLabels[i] = "Empty"; break;
                        case 56: eventLabels[i] = "Empty"; break;
                        case 57: eventLabels[i] = "Empty"; break;
                        case 58: eventLabels[i] = "Empty"; break;
                        case 59: eventLabels[i] = "Empty"; break;
                        case 60: eventLabels[i] = "Empty"; break;
                        case 61: eventLabels[i] = "Empty"; break;
                        case 62: eventLabels[i] = "Empty"; break;
                        case 63: eventLabels[i] = "Empty"; break;
                        case 64: eventLabels[i] = "Empty"; break;
                        case 65: eventLabels[i] = "Trampoline Subroutine"; break;
                        case 66: eventLabels[i] = "Pipe Down Subroutine"; break;
                        case 67: eventLabels[i] = "Empty"; break;
                        case 68: eventLabels[i] = "Empty"; break;
                        case 69: eventLabels[i] = "Empty"; break;
                        case 70: eventLabels[i] = "Empty"; break;
                        case 71: eventLabels[i] = "Empty"; break;
                        case 72: eventLabels[i] = "Empty"; break;
                        case 73: eventLabels[i] = "Empty"; break;
                        case 74: eventLabels[i] = "Empty"; break;
                        case 75: eventLabels[i] = "Empty"; break;
                        case 76: eventLabels[i] = "Empty"; break;
                        case 77: eventLabels[i] = "Empty"; break;
                        case 78: eventLabels[i] = "Unknown"; break;
                        case 79: eventLabels[i] = "Unknown"; break;
                        case 80: eventLabels[i] = "Save Block Subroutine"; break;
                        case 81: eventLabels[i] = "Mario Lands Subroutine"; break;
                        case 82: eventLabels[i] = "Three Musty Fears Greaper Dialog"; break;
                        case 83: eventLabels[i] = "Three Musty Fears Boo Dialog"; break;
                        case 84: eventLabels[i] = "Three Musty Fears Bones Dialog"; break;
                        case 85: eventLabels[i] = "Invisible Item Check 1"; break;
                        case 86: eventLabels[i] = "Invisible Item Check 2"; break;
                        case 87: eventLabels[i] = "Invisible Item Check 3"; break;
                        case 88: eventLabels[i] = "Invisible Item Check 1 Container"; break;
                        case 89: eventLabels[i] = "Invisible Item Check 2 Container"; break;
                        case 90: eventLabels[i] = "Invisible Item Check 3 Container"; break;
                        case 91: eventLabels[i] = "Invisible Item Summoner"; break;
                        case 92: eventLabels[i] = "Pipe Vault Closed Note"; break;
                        case 93: eventLabels[i] = "Background Event For Slot Machine"; break;
                        case 94: eventLabels[i] = "Out Of Order Note"; break;
                        case 95: eventLabels[i] = "Revert All Clone Chests Mimic 1"; break;
                        case 96: eventLabels[i] = "Revert All Clone Chests Mimic 2"; break;
                        case 97: eventLabels[i] = "Empty"; break;
                        case 98: eventLabels[i] = "Empty"; break;
                        case 99: eventLabels[i] = "Empty"; break;
                        case 100: eventLabels[i] = "Empty"; break;
                        case 101: eventLabels[i] = "Empty"; break;
                        case 102: eventLabels[i] = "Empty"; break;
                        case 103: eventLabels[i] = "Empty"; break;
                        case 104: eventLabels[i] = "Empty"; break;
                        case 105: eventLabels[i] = "Empty"; break;
                        case 106: eventLabels[i] = "Empty"; break;
                        case 107: eventLabels[i] = "Empty"; break;
                        case 108: eventLabels[i] = "Empty"; break;
                        case 109: eventLabels[i] = "Empty"; break;
                        case 110: eventLabels[i] = "Empty"; break;
                        case 111: eventLabels[i] = "Empty"; break;
                        case 112: eventLabels[i] = "Empty"; break;
                        case 113: eventLabels[i] = "Empty"; break;
                        case 114: eventLabels[i] = "Empty"; break;
                        case 115: eventLabels[i] = "Empty"; break;
                        case 116: eventLabels[i] = "Empty"; break;
                        case 117: eventLabels[i] = "Empty"; break;
                        case 118: eventLabels[i] = "Empty"; break;
                        case 119: eventLabels[i] = "Empty"; break;
                        case 120: eventLabels[i] = "Empty"; break;
                        case 121: eventLabels[i] = "Empty"; break;
                        case 122: eventLabels[i] = "Empty"; break;
                        case 123: eventLabels[i] = "Empty"; break;
                        case 124: eventLabels[i] = "Empty"; break;
                        case 125: eventLabels[i] = "Empty"; break;
                        case 126: eventLabels[i] = "Empty"; break;
                        case 127: eventLabels[i] = "Empty"; break;
                        case 128: eventLabels[i] = "Abort Attract Mode"; break;
                        case 129: eventLabels[i] = "Empty"; break;
                        case 130: eventLabels[i] = "Empty"; break;
                        case 131: eventLabels[i] = "Empty"; break;
                        case 132: eventLabels[i] = "Empty"; break;
                        case 133: eventLabels[i] = "Empty"; break;
                        case 134: eventLabels[i] = "Empty"; break;
                        case 135: eventLabels[i] = "Empty"; break;
                        case 136: eventLabels[i] = "Empty"; break;
                        case 137: eventLabels[i] = "Empty"; break;
                        case 138: eventLabels[i] = "Empty"; break;
                        case 139: eventLabels[i] = "Empty"; break;
                        case 140: eventLabels[i] = "Empty"; break;
                        case 141: eventLabels[i] = "Empty"; break;
                        case 142: eventLabels[i] = "Empty"; break;
                        case 143: eventLabels[i] = "Empty"; break;
                        case 144: eventLabels[i] = "Empty"; break;
                        case 145: eventLabels[i] = "Empty"; break;
                        case 146: eventLabels[i] = "Empty"; break;
                        case 147: eventLabels[i] = "Empty"; break;
                        case 148: eventLabels[i] = "Empty"; break;
                        case 149: eventLabels[i] = "Empty"; break;
                        case 150: eventLabels[i] = "Empty"; break;
                        case 151: eventLabels[i] = "Empty"; break;
                        case 152: eventLabels[i] = "Empty"; break;
                        case 153: eventLabels[i] = "Empty"; break;
                        case 154: eventLabels[i] = "Npc Quest 7 Container"; break;
                        case 155: eventLabels[i] = "Packet Decider Container"; break;
                        case 156: eventLabels[i] = "Packet Decider"; break;
                        case 157: eventLabels[i] = "Npc Quest Grant 1 Frog Coin"; break;
                        case 158: eventLabels[i] = "Npc Quest Grant Multi Frog Coin"; break;
                        case 159: eventLabels[i] = "Npc Quest Grant Coins"; break;
                        case 160: eventLabels[i] = "Npc Quest Grant Item"; break;
                        case 161: eventLabels[i] = "Npc Quest Grant Beetlemania"; break;
                        case 162: eventLabels[i] = "Chest Grant Beetlemania"; break;
                        case 163: eventLabels[i] = "Chest Grant Star Piece"; break;
                        case 164: eventLabels[i] = "Npc Quest Grant Star Piece"; break;
                        case 165: eventLabels[i] = "Freestanding Grant Item Bag"; break;
                        case 166: eventLabels[i] = "Freestanding Grant Star Piece"; break;
                        case 167: eventLabels[i] = "Boss Grant Star Piece"; break;
                        case 168: eventLabels[i] = "Boss Grant Star Piece Container"; break;
                        case 169: eventLabels[i] = "Mimic 1 Grant Star Piece Container"; break;
                        case 170: eventLabels[i] = "Mimic 2 Grant Star Piece Container"; break;
                        case 171: eventLabels[i] = "Mimic 3 Grant Star Piece Container"; break;
                        case 172: eventLabels[i] = "Chest 1 Container"; break;
                        case 173: eventLabels[i] = "Chest 2 Container"; break;
                        case 174: eventLabels[i] = "Chest 3 Container"; break;
                        case 175: eventLabels[i] = "Chest 4 Container"; break;
                        case 176: eventLabels[i] = "Chest 5 Container"; break;
                        case 177: eventLabels[i] = "Chest 6 Container"; break;
                        case 178: eventLabels[i] = "Npc Quest 1 Container"; break;
                        case 179: eventLabels[i] = "Npc Quest 2 Container"; break;
                        case 180: eventLabels[i] = "Npc Quest 3 Container"; break;
                        case 181: eventLabels[i] = "Npc Quest 4 Container"; break;
                        case 182: eventLabels[i] = "Npc Quest 5 Container"; break;
                        case 183: eventLabels[i] = "Npc Quest 6 Container"; break;
                        case 184: eventLabels[i] = "Npc Quest Grant Single Fireworks"; break;
                        case 185: eventLabels[i] = "Npc Quest Grant Progressive Fireworks"; break;
                        case 186: eventLabels[i] = "Party Join Logic"; break;
                        case 187: eventLabels[i] = "Mario Joins"; break;
                        case 188: eventLabels[i] = "Mallow Joins"; break;
                        case 189: eventLabels[i] = "Geno Joins"; break;
                        case 190: eventLabels[i] = "Bowser Joins"; break;
                        case 191: eventLabels[i] = "Toadstool Joins"; break;
                        case 192: eventLabels[i] = "Gating And Party Join Logic"; break;
                        case 193: eventLabels[i] = "Mario Joins Container"; break;
                        case 194: eventLabels[i] = "Mallow Joins Container"; break;
                        case 195: eventLabels[i] = "Geno Joins Container"; break;
                        case 196: eventLabels[i] = "Bowser Joins Container"; break;
                        case 197: eventLabels[i] = "Toadstool Joins Container"; break;
                        case 198: eventLabels[i] = "Unlock Tower If Gated By Moleville"; break;
                        case 199: eventLabels[i] = "Unlock Bandits If Gated By Mushroom Way"; break;
                        case 200: eventLabels[i] = "Unlock Forest If Gated By Marrymore Character"; break;
                        case 201: eventLabels[i] = "Unlock Forest If Gated By Moleville Character"; break;
                        case 202: eventLabels[i] = "Unlock Forest If Gated By Mushroom Way Character"; break;
                        case 203: eventLabels[i] = "Unlock Forest If Gated By Cricket Pie"; break;
                        case 204: eventLabels[i] = "Unlock Marrymore If Gated By Booster Hill"; break;
                        case 205: eventLabels[i] = "Unlock Marrymore If Gated By Tower Boss"; break;
                        case 206: eventLabels[i] = "Unlock Sea If Gated By Star Pieces"; break;
                        case 207: eventLabels[i] = "Unlock Keep If Gated By Star Pieces"; break;
                        case 208: eventLabels[i] = "Unlock Keep If Gated By Volcano Boss"; break;
                        case 209: eventLabels[i] = "Unlock Switch Menu If Enough Members"; break;
                        case 210: eventLabels[i] = "Unlock Seaside Boss If Gated By Ship Boss"; break;
                        case 211: eventLabels[i] = "Unlock Pipe Vault If Gated By Forest Maze"; break;
                        case 212: eventLabels[i] = "Npc Quest 7 Container"; break;
                        case 213: eventLabels[i] = "Booster Hill Prize Container Event"; break;
                        case 214: eventLabels[i] = "Hill Get Flower"; break;
                        case 215: eventLabels[i] = "Hill Item"; break;
                        case 216: eventLabels[i] = "Get Flower From Npc"; break;
                        case 217: eventLabels[i] = "Hill Fireworks"; break;
                        case 218: eventLabels[i] = "Hill Beetlemania"; break;
                        case 219: eventLabels[i] = "Hill Grant Logic"; break;
                        case 220: eventLabels[i] = "Empty"; break;
                        case 221: eventLabels[i] = "Empty"; break;
                        case 222: eventLabels[i] = "Empty"; break;
                        case 223: eventLabels[i] = "Empty"; break;
                        case 224: eventLabels[i] = "Empty"; break;
                        case 225: eventLabels[i] = "Check Voucher Unlock"; break;
                        case 226: eventLabels[i] = "Npc Quest 7 Grant"; break;
                        case 227: eventLabels[i] = "Freestanding 15 Grant"; break;
                        case 228: eventLabels[i] = "Freestanding 14 Grant"; break;
                        case 229: eventLabels[i] = "Freestanding 13 Grant"; break;
                        case 230: eventLabels[i] = "Freestanding 12 Grant"; break;
                        case 231: eventLabels[i] = "Freestanding 11 Grant"; break;
                        case 232: eventLabels[i] = "Freestanding 10 Grant"; break;
                        case 233: eventLabels[i] = "Freestanding 9 Grant"; break;
                        case 234: eventLabels[i] = "Freestanding 8 Grant"; break;
                        case 235: eventLabels[i] = "Freestanding 7 Grant"; break;
                        case 236: eventLabels[i] = "Freestanding 6 Grant"; break;
                        case 237: eventLabels[i] = "Freestanding 5 Grant"; break;
                        case 238: eventLabels[i] = "Freestanding 4 Grant"; break;
                        case 239: eventLabels[i] = "Freestanding 3 Grant"; break;
                        case 240: eventLabels[i] = "Freestanding 2 Grant"; break;
                        case 241: eventLabels[i] = "Freestanding 1 Grant"; break;
                        case 242: eventLabels[i] = "Chest 6 Grant"; break;
                        case 243: eventLabels[i] = "Chest 5 Grant"; break;
                        case 244: eventLabels[i] = "Chest 4 Grant"; break;
                        case 245: eventLabels[i] = "Chest 3 Grant"; break;
                        case 246: eventLabels[i] = "Chest 2 Grant"; break;
                        case 247: eventLabels[i] = "Chest 1 Grant"; break;
                        case 248: eventLabels[i] = "Npc Quest 6 Grant"; break;
                        case 249: eventLabels[i] = "Npc Quest 5 Grant"; break;
                        case 250: eventLabels[i] = "Npc Quest 4 Grant"; break;
                        case 251: eventLabels[i] = "Npc Quest 3 Grant"; break;
                        case 252: eventLabels[i] = "Npc Quest 2 Grant"; break;
                        case 253: eventLabels[i] = "Npc Quest 1 Grant"; break;
                        case 254: eventLabels[i] = "Exp Star Hit Subroutine"; break;
                        case 255: eventLabels[i] = "Exp Star Hit"; break;
                        case 256: eventLabels[i] = "Return"; break;
                        case 257: eventLabels[i] = "Fade In Async"; break;
                        case 258: eventLabels[i] = "Empty"; break;
                        case 259: eventLabels[i] = "Unknown"; break;
                        case 260: eventLabels[i] = "Unknown"; break;
                        case 261: eventLabels[i] = "Fade Music Room Loader"; break;
                        case 262: eventLabels[i] = "Fade Music Room Loader"; break;
                        case 263: eventLabels[i] = "Bounce On Bed"; break;
                        case 264: eventLabels[i] = "Return"; break;
                        case 265: eventLabels[i] = "Occupied Mk Inn Loader"; break;
                        case 266: eventLabels[i] = "Unknown"; break;
                        case 267: eventLabels[i] = "Unknown"; break;
                        case 268: eventLabels[i] = "Unknown"; break;
                        case 269: eventLabels[i] = "Pipe Up Subroutine"; break;
                        case 270: eventLabels[i] = "Trampoline Or Pipe Subroutine"; break;
                        case 271: eventLabels[i] = "Unknown"; break;
                        case 272: eventLabels[i] = "Pause Active Until A Pressed"; break;
                        case 273: eventLabels[i] = "Sleep In Inns"; break;
                        case 274: eventLabels[i] = "Check If Have Enough Coins"; break;
                        case 275: eventLabels[i] = "Unknown"; break;
                        case 276: eventLabels[i] = "Refocus Camera On Self"; break;
                        case 277: eventLabels[i] = "Unknown"; break;
                        case 278: eventLabels[i] = "Unknown"; break;
                        case 279: eventLabels[i] = "Unknown"; break;
                        case 280: eventLabels[i] = "Sleep In Nimbus Inn"; break;
                        case 281: eventLabels[i] = "Clear Exp Star Bits"; break;
                        case 282: eventLabels[i] = "Unknown Pipe Vault"; break;
                        case 283: eventLabels[i] = "Get Frog Coin No Dialog Possibly Unused"; break;
                        case 284: eventLabels[i] = "Open Mushroom Kingdom Shop"; break;
                        case 285: eventLabels[i] = "Unknown"; break;
                        case 286: eventLabels[i] = "Await B Press"; break;
                        case 287: eventLabels[i] = "Reset Game"; break;
                        case 288: eventLabels[i] = "Unknown Rose Town"; break;
                        case 289: eventLabels[i] = "Inns Container"; break;
                        case 290: eventLabels[i] = "Mushroom Kingdom Shop Logic"; break;
                        case 291: eventLabels[i] = "Mushroom Kingdom Outer Castle Guards"; break;
                        case 292: eventLabels[i] = "Mushroom Kingdom West Blue Toad"; break;
                        case 293: eventLabels[i] = "Unused"; break;
                        case 294: eventLabels[i] = "Mushroom Kingdom Inn Npc"; break;
                        case 295: eventLabels[i] = "Go To Mushroom Kingdom Outside"; break;
                        case 296: eventLabels[i] = "Mushroom Kingdom Grandma"; break;
                        case 297: eventLabels[i] = "Mushroom Kingdom Running Kid"; break;
                        case 298: eventLabels[i] = "Mushroom Kingdom Pink Toad"; break;
                        case 299: eventLabels[i] = "Empty"; break;
                        case 300: eventLabels[i] = "Generic No Help Message"; break;
                        case 301: eventLabels[i] = "Mushroom Kingdom Mom"; break;
                        case 302: eventLabels[i] = "Mushroom Kingdom Dad"; break;
                        case 303: eventLabels[i] = "Mushroom Kingdom Jumping Kid"; break;
                        case 304: eventLabels[i] = "Unknown"; break;
                        case 305: eventLabels[i] = "Unknown"; break;
                        case 306: eventLabels[i] = "Mushroom Kingdom Brother"; break;
                        case 307: eventLabels[i] = "Unknown"; break;
                        case 308: eventLabels[i] = "Empty"; break;
                        case 309: eventLabels[i] = "Empty"; break;
                        case 310: eventLabels[i] = "Mushroom Kingdom Grandpa"; break;
                        case 311: eventLabels[i] = "Mushroom Kingdom East Guard"; break;
                        case 312: eventLabels[i] = "Mushroom Kingdom Occupied Running Kid"; break;
                        case 313: eventLabels[i] = "Mushroom Kingdom Occupied Grandma"; break;
                        case 314: eventLabels[i] = "Empty"; break;
                        case 315: eventLabels[i] = "Empty"; break;
                        case 316: eventLabels[i] = "Mushroom Kingdom Occupied Dad"; break;
                        case 317: eventLabels[i] = "Mushroom Kingdom Occupied Mom"; break;
                        case 318: eventLabels[i] = "Mushroom Kingdom Occupied Castle Toad"; break;
                        case 319: eventLabels[i] = "Toadstool Antechamber Loader"; break;
                        case 320: eventLabels[i] = "Mushroom Kingdom Main Hall Loader"; break;
                        case 321: eventLabels[i] = "Bellhop While Guiding"; break;
                        case 322: eventLabels[i] = "Mushroom Kingdom Throne Room Loader"; break;
                        case 323: eventLabels[i] = "Unknown"; break;
                        case 324: eventLabels[i] = "Kingdom Main Hall Flip Veranda"; break;
                        case 325: eventLabels[i] = "Detect Main Hall Door Opened"; break;
                        case 326: eventLabels[i] = "Mushroom Kingdom Castle Generic Toad"; break;
                        case 327: eventLabels[i] = "Mushroom Kingdom Castle Throne Room Toad"; break;
                        case 328: eventLabels[i] = "Detect Main Hall Door Opened"; break;
                        case 329: eventLabels[i] = "Kingdom Main Hall Flip Upper"; break;
                        case 330: eventLabels[i] = "Chancellor"; break;
                        case 331: eventLabels[i] = "Empty"; break;
                        case 332: eventLabels[i] = "Empty"; break;
                        case 333: eventLabels[i] = "Empty"; break;
                        case 334: eventLabels[i] = "Empty"; break;
                        case 335: eventLabels[i] = "Unknown"; break;
                        case 336: eventLabels[i] = "Unknown"; break;
                        case 337: eventLabels[i] = "Mushroom Kingdom Shop Bookshelf"; break;
                        case 338: eventLabels[i] = "Mushroom Kingdom Shopkeeper"; break;
                        case 339: eventLabels[i] = "Mushroom Kingdom Occupied Raz Raini House Loader"; break;
                        case 340: eventLabels[i] = "Mushroom Kingdom Occupied Raz Raini House Shake"; break;
                        case 341: eventLabels[i] = "Empty"; break;
                        case 342: eventLabels[i] = "Empty"; break;
                        case 343: eventLabels[i] = "Empty"; break;
                        case 344: eventLabels[i] = "Mushroom Kingdom Raz Raini House Loader"; break;
                        case 345: eventLabels[i] = "Mushroom Kingdom Toadstools Room Guard"; break;
                        case 346: eventLabels[i] = "Toadstools Room Item"; break;
                        case 347: eventLabels[i] = "Toadstools Room Loader"; break;
                        case 348: eventLabels[i] = "Mushroom Kingdom Main Hall Toad"; break;
                        case 349: eventLabels[i] = "Mushroom Kingdom Antechamber Exit"; break;
                        case 350: eventLabels[i] = "Kingdom Hallway Shyguy"; break;
                        case 351: eventLabels[i] = "Gameboy Kid"; break;
                        case 352: eventLabels[i] = "Mushroom Kingdom Occupied Shopkeeper"; break;
                        case 353: eventLabels[i] = "Boss Battle"; break;
                        case 354: eventLabels[i] = "Boss Battle Container"; break;
                        case 355: eventLabels[i] = "Boss Hunt Bit Setter"; break;
                        case 356: eventLabels[i] = "Boss Hunt Bit Setter Container"; break;
                        case 357: eventLabels[i] = "Exp Star Music Experiment"; break;
                        case 358: eventLabels[i] = "Mushroom Kingdom Npc Behind House"; break;
                        case 359: eventLabels[i] = "Chest Clones"; break;
                        case 360: eventLabels[i] = "Empty"; break;
                        case 361: eventLabels[i] = "Empty"; break;
                        case 362: eventLabels[i] = "Empty"; break;
                        case 363: eventLabels[i] = "Empty"; break;
                        case 364: eventLabels[i] = "Empty"; break;
                        case 365: eventLabels[i] = "Empty"; break;
                        case 366: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Forced Off Minion"; break;
                        case 367: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Forced Off Minion"; break;
                        case 368: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Loader"; break;
                        case 369: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Exit"; break;
                        case 370: eventLabels[i] = "Empty"; break;
                        case 371: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Loader"; break;
                        case 372: eventLabels[i] = "Mushroom Kingdom Boss Fight Cutscene"; break;
                        case 373: eventLabels[i] = "Mushroom Kingdom Boss Fight"; break;
                        case 374: eventLabels[i] = "Empty"; break;
                        case 375: eventLabels[i] = "Talk To Chancellor After Mushroom Kingdom Boss"; break;
                        case 376: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Loader"; break;
                        case 377: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Repeating Shysters Position"; break;
                        case 378: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Shyster Chasing Toad"; break;
                        case 379: eventLabels[i] = "Mushroom Kingdom Occupied Guest Room Grant"; break;
                        case 380: eventLabels[i] = "Mushroom Kingdom Occupied Vault Guard Toad"; break;
                        case 381: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Antechamber Fight"; break;
                        case 382: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Loader"; break;
                        case 383: eventLabels[i] = "Toad Wishes You Well"; break;
                        case 384: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Antechamber Loader"; break;
                        case 385: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Antechamber Toad"; break;
                        case 386: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Toad 1"; break;
                        case 387: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Toad 2"; break;
                        case 388: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Toad 3"; break;
                        case 389: eventLabels[i] = "Mushroom Kingdom Occupied Left Stairway Shyster"; break;
                        case 390: eventLabels[i] = "Mushroom Kingdom Occupied Left Stairway Toad"; break;
                        case 391: eventLabels[i] = "Mushroom Kingdom Occupied Left Stairway Loader"; break;
                        case 392: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Repeating Shysters Position"; break;
                        case 393: eventLabels[i] = "Mushroom Kingdom During Mack Jumping Kids House 1F Loader"; break;
                        case 394: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Pink Toad"; break;
                        case 395: eventLabels[i] = "Wallet Toad 2"; break;
                        case 396: eventLabels[i] = "Mushroom Kingdom Occupied Rescued Eastern Guard"; break;
                        case 397: eventLabels[i] = "Heal In Toadstools Room"; break;
                        case 398: eventLabels[i] = "Empty"; break;
                        case 399: eventLabels[i] = "Empty"; break;
                        case 400: eventLabels[i] = "Guest Room Guard"; break;
                        case 401: eventLabels[i] = "Guest Room Antechamber Loader"; break;
                        case 402: eventLabels[i] = "Shyster Harassing Eastern Guard"; break;
                        case 403: eventLabels[i] = "Shyster Harassing Wallet Guy"; break;
                        case 404: eventLabels[i] = "Mushroom Kingdom Occupied Shop Loader"; break;
                        case 405: eventLabels[i] = "Table Shyster"; break;
                        case 406: eventLabels[i] = "Younger Brother"; break;
                        case 407: eventLabels[i] = "Countertop Shyster"; break;
                        case 408: eventLabels[i] = "Mushroom Kingdom Occupied Older Brother"; break;
                        case 409: eventLabels[i] = "Mushroom Kingdom Occupied Jumping Kids House 2F Loader"; break;
                        case 410: eventLabels[i] = "Bed Shyster"; break;
                        case 411: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Repeating Shysters"; break;
                        case 412: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Repeating Shysters"; break;
                        case 413: eventLabels[i] = "Clear Temp 7044 0"; break;
                        case 414: eventLabels[i] = "Set Temp 7044 0"; break;
                        case 415: eventLabels[i] = "Pipe Vault Room 1 Exit"; break;
                        case 416: eventLabels[i] = "Pipe Vault Thwomp Room Entrance"; break;
                        case 417: eventLabels[i] = "Pipe Vault Thwomp Room Exit Pipe"; break;
                        case 418: eventLabels[i] = "Pipe Vault Pipes Room Entrance Pipe"; break;
                        case 419: eventLabels[i] = "Empty"; break;
                        case 420: eventLabels[i] = "Pipe Vault Crouch Room Exit Trampoline"; break;
                        case 421: eventLabels[i] = "Pipe Vault Pipes Room Exit Pipe"; break;
                        case 422: eventLabels[i] = "Pipe Vault Platforming Room Entrance Pipe"; break;
                        case 423: eventLabels[i] = "Pipe Vault Platforming Room Exit Pipe"; break;
                        case 424: eventLabels[i] = "Pipe Vault Red Room Entrance Pipe"; break;
                        case 425: eventLabels[i] = "Pipe Vault Red Room Exit Pipe"; break;
                        case 426: eventLabels[i] = "Pipe Vault Chompweed Room Entrance Pipe"; break;
                        case 427: eventLabels[i] = "Pipe Vault Chompweed Room Exit Pipe"; break;
                        case 428: eventLabels[i] = "Pipe Vault Thwomp Room Loader"; break;
                        case 429: eventLabels[i] = "Pipe Vault Thwomp Room Loader Background"; break;
                        case 430: eventLabels[i] = "Pipe Vault Mario Hit By Thwomp"; break;
                        case 431: eventLabels[i] = "Pipe Vault Goomba Thumpin Entrance Pipe"; break;
                        case 432: eventLabels[i] = "Pipe Vault Goomba Thumpin Exit Trampoline"; break;
                        case 433: eventLabels[i] = "Pipe Vault Chompweed"; break;
                        case 434: eventLabels[i] = "Pipe Vault Red Room Loader"; break;
                        case 435: eventLabels[i] = "Pipe Vault Room 1 Loader"; break;
                        case 436: eventLabels[i] = "Pipe Vault Fireball 1"; break;
                        case 437: eventLabels[i] = "Pipe Vault Fireball 2"; break;
                        case 438: eventLabels[i] = "Pipe Vault Fireball 3"; break;
                        case 439: eventLabels[i] = "Pipe Vault Fireball 4"; break;
                        case 440: eventLabels[i] = "Pipe Vault Fireball Background"; break;
                        case 441: eventLabels[i] = "Pipe Vault Chompweed Room Chompweeds"; break;
                        case 442: eventLabels[i] = "Empty"; break;
                        case 443: eventLabels[i] = "Pipe Vault Chompweed Room Loader"; break;
                        case 444: eventLabels[i] = "Goomba Thumpin Administrator"; break;
                        case 445: eventLabels[i] = "Goomba Thumpin Begins"; break;
                        case 446: eventLabels[i] = "Goomba Thumpin Scorekeeping"; break;
                        case 447: eventLabels[i] = "Goomba Thumpin Spawns"; break;
                        case 448: eventLabels[i] = "Goomba Thumpin Goomba 1"; break;
                        case 449: eventLabels[i] = "Goomba Thumpin Goomba 2"; break;
                        case 450: eventLabels[i] = "Goomba Thumpin Goomba 3"; break;
                        case 451: eventLabels[i] = "Goomba Thumpin Goomba 4"; break;
                        case 452: eventLabels[i] = "Empty"; break;
                        case 453: eventLabels[i] = "Empty"; break;
                        case 454: eventLabels[i] = "Goomba Thumpin Room Loader"; break;
                        case 455: eventLabels[i] = "Resummon Pipe Vault Enemies"; break;
                        case 456: eventLabels[i] = "Yoshi Talks To Other Yoshi"; break;
                        case 457: eventLabels[i] = "Mushroom Derby Unknown"; break;
                        case 458: eventLabels[i] = "Mushroom Derby Begins"; break;
                        case 459: eventLabels[i] = "Upper Right Yoshi"; break;
                        case 460: eventLabels[i] = "Cookie Storage Yoshi"; break;
                        case 461: eventLabels[i] = "Yoshi On Track"; break;
                        case 462: eventLabels[i] = "Yoshi Mom"; break;
                        case 463: eventLabels[i] = "Free Cookie Yoshi"; break;
                        case 464: eventLabels[i] = "Empty"; break;
                        case 465: eventLabels[i] = "Mushroom Derby Business Logic"; break;
                        case 466: eventLabels[i] = "Mushroom Derby Business Logic Extension"; break;
                        case 467: eventLabels[i] = "Pipe Vault Platforming Room Loader"; break;
                        case 468: eventLabels[i] = "Mushroom Derby Use Yoshi Cookie"; break;
                        case 469: eventLabels[i] = "Yoster Isle Background"; break;
                        case 470: eventLabels[i] = "Green Yoshi"; break;
                        case 471: eventLabels[i] = "Boshi"; break;
                        case 472: eventLabels[i] = "Empty"; break;
                        case 473: eventLabels[i] = "Empty"; break;
                        case 474: eventLabels[i] = "Empty"; break;
                        case 475: eventLabels[i] = "Mushroom Derby Unknown"; break;
                        case 476: eventLabels[i] = "Initiate Mushroom Derby From Talking To Boshi"; break;
                        case 477: eventLabels[i] = "Dismount Yoshi 1"; break;
                        case 478: eventLabels[i] = "Dismount Yoshi 2"; break;
                        case 479: eventLabels[i] = "Dismount Yoshi 3"; break;
                        case 480: eventLabels[i] = "Dismount Yoshi 4"; break;
                        case 481: eventLabels[i] = "Empty"; break;
                        case 482: eventLabels[i] = "Yoster Isle Unknown"; break;
                        case 483: eventLabels[i] = "Empty"; break;
                        case 484: eventLabels[i] = "Empty"; break;
                        case 485: eventLabels[i] = "Pipe Vault Crouch Room Entrance Pipe"; break;
                        case 486: eventLabels[i] = "Empty"; break;
                        case 487: eventLabels[i] = "Pipe Vault Chompweed Room Exit Pipe Reverse"; break;
                        case 488: eventLabels[i] = "Red Room Piranha 1"; break;
                        case 489: eventLabels[i] = "Red Room Piranha 2"; break;
                        case 490: eventLabels[i] = "Red Room Piranha 3"; break;
                        case 491: eventLabels[i] = "Red Room Piranha 4"; break;
                        case 492: eventLabels[i] = "Pipe Vault Piranha Timer 1"; break;
                        case 493: eventLabels[i] = "Pipe Vault Piranha Bit"; break;
                        case 494: eventLabels[i] = "Pipe Vault Piranha Timer 2"; break;
                        case 495: eventLabels[i] = "Pipe Vault Piranha Timer 3"; break;
                        case 496: eventLabels[i] = "Pipe Vault Piranha Timer 4"; break;
                        case 497: eventLabels[i] = "Pipe Vault Piranha Timer 5"; break;
                        case 498: eventLabels[i] = "Pipe Vault First Goomba"; break;
                        case 499: eventLabels[i] = "Pipe Vault Entrance Trampoline"; break;
                        case 500: eventLabels[i] = "Pipe Vault Hidden Platform"; break;
                        case 501: eventLabels[i] = "Empty"; break;
                        case 502: eventLabels[i] = "Pipe Vault Crouch Item Init"; break;
                        case 503: eventLabels[i] = "Pipe Vault Crouch Item Confirm"; break;
                        case 504: eventLabels[i] = "Pipe Vault Small Coin"; break;
                        case 505: eventLabels[i] = "Pipe Vault Mario Thwomp Tumble"; break;
                        case 506: eventLabels[i] = "Pipe Vault Summon First Goomba"; break;
                        case 507: eventLabels[i] = "Pipe Vault Piranha Bit"; break;
                        case 508: eventLabels[i] = "Unknown"; break;
                        case 509: eventLabels[i] = "Pipe Vault Crouch Item Reset"; break;
                        case 510: eventLabels[i] = "Pipe Vault Crouch Room Clear Bits"; break;
                        case 511: eventLabels[i] = "Empty"; break;
                        case 512: eventLabels[i] = "Rose Town Occupied Inn Loader"; break;
                        case 513: eventLabels[i] = "Empty"; break;
                        case 514: eventLabels[i] = "Gaz Item Grant"; break;
                        case 515: eventLabels[i] = "Empty"; break;
                        case 516: eventLabels[i] = "Occupied Rose Town Gaz"; break;
                        case 517: eventLabels[i] = "Rose Town Occupied Exit"; break;
                        case 518: eventLabels[i] = "Rose Town Occupied Stairway"; break;
                        case 519: eventLabels[i] = "Empty"; break;
                        case 520: eventLabels[i] = "Rose Town Occupied Exterior Pink Toad"; break;
                        case 521: eventLabels[i] = "Rose Town Occupied Exterior Blue Toad Left"; break;
                        case 522: eventLabels[i] = "Empty"; break;
                        case 523: eventLabels[i] = "Empty"; break;
                        case 524: eventLabels[i] = "Rose Town Occupied Exterior Grandpa"; break;
                        case 525: eventLabels[i] = "Rose Town Item Shop"; break;
                        case 526: eventLabels[i] = "Rose Town Equip Shop"; break;
                        case 527: eventLabels[i] = "Rose Town Shop Red Toad"; break;
                        case 528: eventLabels[i] = "Rose Town Shop Yellow Toad"; break;
                        case 529: eventLabels[i] = "Rose Town Occupied Exterior Loader"; break;
                        case 530: eventLabels[i] = "Rose Town Occupied Background 1"; break;
                        case 531: eventLabels[i] = "Rose Town Occupied Inn 2F Loader"; break;
                        case 532: eventLabels[i] = "Empty"; break;
                        case 533: eventLabels[i] = "Empty"; break;
                        case 534: eventLabels[i] = "Rose Town Dad"; break;
                        case 535: eventLabels[i] = "Rose Town Son"; break;
                        case 536: eventLabels[i] = "Empty"; break;
                        case 537: eventLabels[i] = "Rose Town Treasure House 2F Loader"; break;
                        case 538: eventLabels[i] = "Rose Town Pink Toad In House"; break;
                        case 539: eventLabels[i] = "Rose Town Shop Unknown"; break;
                        case 540: eventLabels[i] = "Unused Hint Dialog"; break;
                        case 541: eventLabels[i] = "Debug Dialog"; break;
                        case 542: eventLabels[i] = "Rose Town Occupied Grandma"; break;
                        case 543: eventLabels[i] = "Rose Town Occupied Kid 1"; break;
                        case 544: eventLabels[i] = "Rose Town Occupied Kid 2"; break;
                        case 545: eventLabels[i] = "Rose Town Occupied Kid 3"; break;
                        case 546: eventLabels[i] = "Rose Town Occupied Blue Toad Right"; break;
                        case 547: eventLabels[i] = "Rose Town Occupied Arrow Control 1"; break;
                        case 548: eventLabels[i] = "Rose Town Occupied Arrow Animate"; break;
                        case 549: eventLabels[i] = "Rose Town Occupied Arrow Control 2"; break;
                        case 550: eventLabels[i] = "Rose Town Occupied Arrow Control 3"; break;
                        case 551: eventLabels[i] = "Rose Town Occupied Mods"; break;
                        case 552: eventLabels[i] = "Rose Town Occupied Intro Toad Movement"; break;
                        case 553: eventLabels[i] = "Rose Town Occupied Arrow Control 4"; break;
                        case 554: eventLabels[i] = "Rose Town Occupied Exterior Yellow Toad"; break;
                        case 555: eventLabels[i] = "Rose Town Inn Toad Item Grant"; break;
                        case 556: eventLabels[i] = "Rose Town Liberated Loader"; break;
                        case 557: eventLabels[i] = "Rose Town Liberated Loader Background"; break;
                        case 558: eventLabels[i] = "Rose Town Shop Exit"; break;
                        case 559: eventLabels[i] = "Rose Town Couples House Exit"; break;
                        case 560: eventLabels[i] = "Old Key Item Manager"; break;
                        case 561: eventLabels[i] = "Place Link In Rose Town"; break;
                        case 562: eventLabels[i] = "Rose Town Liberated Kids Indoors"; break;
                        case 563: eventLabels[i] = "Summons Husband In Rose Town Couples House"; break;
                        case 564: eventLabels[i] = "Rose Town Liberated Kid Outdoors"; break;
                        case 565: eventLabels[i] = "Rose Town Liberated 3Rd Kid Outdoors"; break;
                        case 566: eventLabels[i] = "Rose Town Liberated Grandpa"; break;
                        case 567: eventLabels[i] = "Rose Town Liberated Grandma"; break;
                        case 568: eventLabels[i] = "Rose Rown Liberated Water Pump House Loader"; break;
                        case 569: eventLabels[i] = "Rose Town Liberated Pink Toad"; break;
                        case 570: eventLabels[i] = "Rose Town Liberated Right Blue Toad"; break;
                        case 571: eventLabels[i] = "Rose Town Liberated Yellow Toad"; break;
                        case 572: eventLabels[i] = "Rose Town Liberated Husband"; break;
                        case 573: eventLabels[i] = "Rose Town Liberated Wife"; break;
                        case 574: eventLabels[i] = "Empty"; break;
                        case 575: eventLabels[i] = "Rose Town Liberated Couples House Loader"; break;
                        case 576: eventLabels[i] = "Rose Town Treasure House Chest 1"; break;
                        case 577: eventLabels[i] = "Rose Town Treasure House Chest 2"; break;
                        case 578: eventLabels[i] = "Rose Town Liberated Upper Hidden Npc"; break;
                        case 579: eventLabels[i] = "Rose Town Liberated Left Blue Toad"; break;
                        case 580: eventLabels[i] = "Rose Town Occupied Treasure House 1F Loader"; break;
                        case 581: eventLabels[i] = "Rose Town Liberated Lower Hidden Npc"; break;
                        case 582: eventLabels[i] = "Rose Town Occupied Treasure House Bedroom Chest"; break;
                        case 583: eventLabels[i] = "Rose Town Liberated Treasure House Bedroom Chest"; break;
                        case 584: eventLabels[i] = "Goomba Thumpin Gold Goomba 1"; break;
                        case 585: eventLabels[i] = "Goomba Thumpin Gold Goomba 2"; break;
                        case 586: eventLabels[i] = "Goomba Thumpin Gold Goomba 3"; break;
                        case 587: eventLabels[i] = "Goomba Thumpin Gold Goomba 4"; break;
                        case 588: eventLabels[i] = "Goomba Thumpin Spiny 1"; break;
                        case 589: eventLabels[i] = "Goomba Thumpin Spiny 2"; break;
                        case 590: eventLabels[i] = "Goomba Thumpin Spiny 3"; break;
                        case 591: eventLabels[i] = "Goomba Thumpin Spiny 4"; break;
                        case 592: eventLabels[i] = "Mines Boss Room Loader Before Defeat"; break;
                        case 593: eventLabels[i] = "Mines Boss Room Loader After Defeat"; break;
                        case 594: eventLabels[i] = "Mines Boss Shoves You"; break;
                        case 595: eventLabels[i] = "Mines Boss Room Exit"; break;
                        case 596: eventLabels[i] = "Mines Boss Room Background Explosions"; break;
                        case 597: eventLabels[i] = "Mines Boss Room Explosion Recoil"; break;
                        case 598: eventLabels[i] = "Mines Initiate Final Boss Fight"; break;
                        case 599: eventLabels[i] = "Mines Boss Room Entrance Reverse"; break;
                        case 600: eventLabels[i] = "Marrymore Occupied Chapel Loader"; break;
                        case 601: eventLabels[i] = "Marrymore Back Door Enter Chapel"; break;
                        case 602: eventLabels[i] = "Marrymore Inn Manager"; break;
                        case 603: eventLabels[i] = "Marrymore Bellhop Lobby While Guest"; break;
                        case 604: eventLabels[i] = "Marrymore Inn Bright Card Enthusiast"; break;
                        case 605: eventLabels[i] = "Marrymore Inn Lobby Guest 1"; break;
                        case 606: eventLabels[i] = "Marrymore Inn Lobby Guest 2"; break;
                        case 607: eventLabels[i] = "Locked Door"; break;
                        case 608: eventLabels[i] = "Marrymore Inn 3F Hallway Loader"; break;
                        case 609: eventLabels[i] = "Marrymore Inn 3F Hallway Bellhop"; break;
                        case 610: eventLabels[i] = "Marrymore Occupied Exterior Loader"; break;
                        case 611: eventLabels[i] = "Marrymore Inn Lobby Loader"; break;
                        case 612: eventLabels[i] = "Marrymore Inn 2F Hallway Loader"; break;
                        case 613: eventLabels[i] = "Marrymore Suite Loader"; break;
                        case 614: eventLabels[i] = "Marrymore Suite Tip Bellhop"; break;
                        case 615: eventLabels[i] = "Marrymore Lamp"; break;
                        case 616: eventLabels[i] = "Marrymore Inn Lobby Exit"; break;
                        case 617: eventLabels[i] = "Mario As Bellhop Main Event"; break;
                        case 618: eventLabels[i] = "Mario As Bellhop Tries To Go Upstairs Without Guest"; break;
                        case 619: eventLabels[i] = "Real Bellhop Blocks Exit 1"; break;
                        case 620: eventLabels[i] = "Real Bellhop Blocks Exit 2"; break;
                        case 621: eventLabels[i] = "Marrymore Inn Elderly Guest"; break;
                        case 622: eventLabels[i] = "Marrymore Inn Elderly Guest Tip Subroutine 1"; break;
                        case 623: eventLabels[i] = "Marrymore Inn Employed Guest Leaves"; break;
                        case 624: eventLabels[i] = "Marrymore Inn Lobby Stairs"; break;
                        case 625: eventLabels[i] = "Marrymore Inn Something"; break;
                        case 626: eventLabels[i] = "Marrymore Inn Elderly Guest Tip Subroutine Flowerbox"; break;
                        case 627: eventLabels[i] = "Marrymore Sanctuary Exit To Antechamber"; break;
                        case 628: eventLabels[i] = "Marrymore Kitchen Loader"; break;
                        case 629: eventLabels[i] = "Empty"; break;
                        case 630: eventLabels[i] = "Marrymore Kitchen Chef 1"; break;
                        case 631: eventLabels[i] = "Marrymore Kitchen Chef 2"; break;
                        case 632: eventLabels[i] = "Marrymore Exterior Chapel Locked Front Door"; break;
                        case 633: eventLabels[i] = "Marrymore Chapel Lobby Exit To Exterior"; break;
                        case 634: eventLabels[i] = "Empty"; break;
                        case 635: eventLabels[i] = "Marrymore Inn Elderly Guest Tip Sunroutine 3"; break;
                        case 636: eventLabels[i] = "Empty"; break;
                        case 637: eventLabels[i] = "Empty"; break;
                        case 638: eventLabels[i] = "Empty"; break;
                        case 639: eventLabels[i] = "Empty"; break;
                        case 640: eventLabels[i] = "Empty"; break;
                        case 641: eventLabels[i] = "Marrymore Antechamber Loader Extension"; break;
                        case 642: eventLabels[i] = "Marrymore Antechamber Entrance Reverse"; break;
                        case 643: eventLabels[i] = "Empty"; break;
                        case 644: eventLabels[i] = "Empty"; break;
                        case 645: eventLabels[i] = "Empty"; break;
                        case 646: eventLabels[i] = "Marrymore Shop Event Container"; break;
                        case 647: eventLabels[i] = "Marrymore Sanctuary Candle 1"; break;
                        case 648: eventLabels[i] = "Marrymore Sanctuary Candle 2"; break;
                        case 649: eventLabels[i] = "Marrymore Sanctuary Candle 3"; break;
                        case 650: eventLabels[i] = "Marrymore Sanctuary Candle 4"; break;
                        case 651: eventLabels[i] = "Marrymore Sanctuary Candle 5"; break;
                        case 652: eventLabels[i] = "Marrymore Sanctuary Candle 6"; break;
                        case 653: eventLabels[i] = "Marrymore Sanctuary Candle 7"; break;
                        case 654: eventLabels[i] = "Marrymore Sanctuary Candle 8"; break;
                        case 655: eventLabels[i] = "Marrymore Gear Grant Crown"; break;
                        case 656: eventLabels[i] = "Empty"; break;
                        case 657: eventLabels[i] = "Empty"; break;
                        case 658: eventLabels[i] = "Empty"; break;
                        case 659: eventLabels[i] = "Empty"; break;
                        case 660: eventLabels[i] = "Empty"; break;
                        case 661: eventLabels[i] = "Bowsers Keep Button Room Forfeit"; break;
                        case 662: eventLabels[i] = "Empty"; break;
                        case 663: eventLabels[i] = "Initiate Marrymore Boss Fight If All Gear Collected"; break;
                        case 664: eventLabels[i] = "Empty"; break;
                        case 665: eventLabels[i] = "Empty"; break;
                        case 666: eventLabels[i] = "Empty"; break;
                        case 667: eventLabels[i] = "Empty"; break;
                        case 668: eventLabels[i] = "Summon Marrymore Boss To Room"; break;
                        case 669: eventLabels[i] = "Enter Unoccupied Marrymore Sanctuary"; break;
                        case 670: eventLabels[i] = "Marrymore Unoccupied Exterior Loader"; break;
                        case 671: eventLabels[i] = "Marrymore Back Area Exit To Exterior"; break;
                        case 672: eventLabels[i] = "Marrymore Occupied Exterior Chapel Front Entrance"; break;
                        case 673: eventLabels[i] = "Marrymore Chapel Lobby Exit To Antechamber"; break;
                        case 674: eventLabels[i] = "Marrymore Unoccupied Exterior Open Front Chapel Entrance"; break;
                        case 675: eventLabels[i] = "Empty"; break;
                        case 676: eventLabels[i] = "Empty"; break;
                        case 677: eventLabels[i] = "Marrymore Unoccupied Sanctuary Loader"; break;
                        case 678: eventLabels[i] = "Marrymore Jump On Organ Pipe"; break;
                        case 679: eventLabels[i] = "Marrymore Liberated Exterior Pathway Red Toad"; break;
                        case 680: eventLabels[i] = "Marrymore Liberated Exterior Pathway Yellow Toad"; break;
                        case 681: eventLabels[i] = "Marrymore Liberated Exterior Kid"; break;
                        case 682: eventLabels[i] = "Marrymore Liberated Exterior Mom"; break;
                        case 683: eventLabels[i] = "Marrymore Liberated Exterior Green Toad"; break;
                        case 684: eventLabels[i] = "Marrymore Liberated Exterior Husband"; break;
                        case 685: eventLabels[i] = "Marrymore Liberated Exterior Wife"; break;
                        case 686: eventLabels[i] = "Marrymore Liberated Exterior Red Toad"; break;
                        case 687: eventLabels[i] = "Empty"; break;
                        case 688: eventLabels[i] = "Marrymore Raz"; break;
                        case 689: eventLabels[i] = "Marrymore Raini"; break;
                        case 690: eventLabels[i] = "Marrymore Red Toad 1"; break;
                        case 691: eventLabels[i] = "Marrymore Yellow Toad 1"; break;
                        case 692: eventLabels[i] = "Empty"; break;
                        case 693: eventLabels[i] = "Marrymore Grey Toad"; break;
                        case 694: eventLabels[i] = "Marrymore Red Toad 2"; break;
                        case 695: eventLabels[i] = "Marrymore Green Kid"; break;
                        case 696: eventLabels[i] = "Marrymore Yellow Toad 2"; break;
                        case 697: eventLabels[i] = "Marrymore Entrance Toad"; break;
                        case 698: eventLabels[i] = "Marrymore Photographer"; break;
                        case 699: eventLabels[i] = "Empty"; break;
                        case 700: eventLabels[i] = "Empty"; break;
                        case 701: eventLabels[i] = "Pastor Mario"; break;
                        case 702: eventLabels[i] = "Marrymore Take Photo"; break;
                        case 703: eventLabels[i] = "Empty"; break;
                        case 704: eventLabels[i] = "Empty"; break;
                        case 705: eventLabels[i] = "Marrymore Liberated Chapel Green Toad"; break;
                        case 706: eventLabels[i] = "Marrymore Liberated Chapel Pink Kid"; break;
                        case 707: eventLabels[i] = "Marrymore Raz Raini"; break;
                        case 708: eventLabels[i] = "Marrymore Tip Decision Subroutine"; break;
                        case 709: eventLabels[i] = "Empty"; break;
                        case 710: eventLabels[i] = "Empty"; break;
                        case 711: eventLabels[i] = "Empty"; break;
                        case 712: eventLabels[i] = "Empty"; break;
                        case 713: eventLabels[i] = "Empty"; break;
                        case 714: eventLabels[i] = "Empty"; break;
                        case 715: eventLabels[i] = "Empty"; break;
                        case 716: eventLabels[i] = "Enter Jumping Kids House"; break;
                        case 717: eventLabels[i] = "Empty"; break;
                        case 718: eventLabels[i] = "Empty"; break;
                        case 719: eventLabels[i] = "Empty"; break;
                        case 720: eventLabels[i] = "Old Star Piece Script"; break;
                        case 721: eventLabels[i] = "Peachs Grandma"; break;
                        case 722: eventLabels[i] = "Empty"; break;
                        case 723: eventLabels[i] = "Mushroom Kingdom Unoccupied Exterior Loader"; break;
                        case 724: eventLabels[i] = "Nimbus Croco House Loader"; break;
                        case 725: eventLabels[i] = "Empty"; break;
                        case 726: eventLabels[i] = "Empty"; break;
                        case 727: eventLabels[i] = "Empty"; break;
                        case 728: eventLabels[i] = "Empty"; break;
                        case 729: eventLabels[i] = "Several Marrymore Room Loaders"; break;
                        case 730: eventLabels[i] = "Empty"; break;
                        case 731: eventLabels[i] = "Empty"; break;
                        case 732: eventLabels[i] = "Empty"; break;
                        case 733: eventLabels[i] = "Empty"; break;
                        case 734: eventLabels[i] = "Mway Chest"; break;
                        case 735: eventLabels[i] = "Forest Underground Chest"; break;
                        case 736: eventLabels[i] = "Rose Town Inn Sleep Subroutine"; break;
                        case 737: eventLabels[i] = "Garros House Loader"; break;
                        case 738: eventLabels[i] = "Nimbus Land Final Boss Fight Town Square Loader"; break;
                        case 739: eventLabels[i] = "Nimbus Land Inn Hint Guy"; break;
                        case 740: eventLabels[i] = "Nimbus Land Occupied Castle Front Entrance"; break;
                        case 741: eventLabels[i] = "Empty"; break;
                        case 742: eventLabels[i] = "Nimbus Land Liberated Castle Main Hallway Woman"; break;
                        case 743: eventLabels[i] = "Nimbus Land Liberated Castle Main Hallway Man"; break;
                        case 744: eventLabels[i] = "Nimbus Land Liberated Castle Inner Cellar Reward"; break;
                        case 745: eventLabels[i] = "Mushroom Kingdom Inn Sleeping Guy"; break;
                        case 746: eventLabels[i] = "Mushroom Kingdom Inn 2F Downward Stairs"; break;
                        case 747: eventLabels[i] = "Mushroom Kingdom Inn 2F Loader"; break;
                        case 748: eventLabels[i] = "Empty"; break;
                        case 749: eventLabels[i] = "Vine Field"; break;
                        case 750: eventLabels[i] = "Vine Field"; break;
                        case 751: eventLabels[i] = "Vine Field"; break;
                        case 752: eventLabels[i] = "Vine Field"; break;
                        case 753: eventLabels[i] = "Rose Town Innkeeper Over Counter"; break;
                        case 754: eventLabels[i] = "Mushroom Kingdom Shop Basement Stairway"; break;
                        case 755: eventLabels[i] = "Mushroom Way Area 03 Shuffled Npc Animation Loader"; break;
                        case 756: eventLabels[i] = "Bandits Way Area 02 Shuffled Npc Animation Loader"; break;
                        case 757: eventLabels[i] = "Bandits Way Area 01 Shuffled Npc Animation Loader"; break;
                        case 758: eventLabels[i] = "Bandits Way Area 03 Shuffled Npc Animation Loader"; break;
                        case 759: eventLabels[i] = "Bandits Way Area 04 Shuffled Npc Animation Loader"; break;
                        case 760: eventLabels[i] = "Bandits Way Area 05 Shuffled Npc Animation Loader"; break;
                        case 761: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Shuffled Npc Animation Loader"; break;
                        case 762: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Shuffled Npc Animation Loader"; break;
                        case 763: eventLabels[i] = "Mushroom Kingdom Occupied Throne Antechamber Shuffled Npc Animation Loader"; break;
                        case 764: eventLabels[i] = "Mushroom Kingdom Occupied Throne Antechamber Loader"; break;
                        case 765: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Shuffled Npc Animation Loader"; break;
                        case 766: eventLabels[i] = "Mushroom Kingdom Occupied Stairway Shuffled Npc Animation Loader"; break;
                        case 767: eventLabels[i] = "Mushroom Kingdom Occupied East Hall Loader"; break;
                        case 768: eventLabels[i] = "Mushroom Kingdom Occupied East Hall Shuffled Npc Animation Loader"; break;
                        case 769: eventLabels[i] = "Mushroom Kingdom Occupied Peachs Antechamber Shuffled Npc Animation Loader"; break;
                        case 770: eventLabels[i] = "Mushroom Kingdom Occupied Jumping Kids House 1F Shuffled Npc Animation Loader"; break;
                        case 771: eventLabels[i] = "Mushroom Kingdom Occupied Jumping Kids House 2F Shuffled Npc Animation Loader"; break;
                        case 772: eventLabels[i] = "Kero Sewers Belome Room Shuffled Npc Animation Loader"; break;
                        case 773: eventLabels[i] = "Kero Sewers Belome Room Loader Container"; break;
                        case 774: eventLabels[i] = "Forest Maze Boss Room Loader"; break;
                        case 775: eventLabels[i] = "Forest Maze Boss Room Shuffled Npc Animation Loader"; break;
                        case 776: eventLabels[i] = "Mines Trampoline Room Loader"; break;
                        case 777: eventLabels[i] = "Mines Trampoline Room Shuffled Npc Animation Loader"; break;
                        case 778: eventLabels[i] = "Mines Left Of Trampoline Room Loader"; break;
                        case 779: eventLabels[i] = "Mines Left Of Trampoline Room Shuffled Npc Animation Loader"; break;
                        case 780: eventLabels[i] = "Mines Tiny Room 2 Left Of Trampoline Room Loader"; break;
                        case 781: eventLabels[i] = "Mines Tiny Room 2 Left Of Trampoline Room Shuffled Npc Animation Loader"; break;
                        case 782: eventLabels[i] = "Mines Room That Splits To Pa Mole Path Loader"; break;
                        case 783: eventLabels[i] = "Mines Room That Splits To Pa Mole Path Shuffled Npc Animation Loader"; break;
                        case 784: eventLabels[i] = "Mines Small North Room In Miniboss Path Loader"; break;
                        case 785: eventLabels[i] = "Mines Small North Room In Miniboss Path Shuffled Npc Animation Loader"; break;
                        case 786: eventLabels[i] = "Mines Long Room In Miniboss Path Loader"; break;
                        case 787: eventLabels[i] = "Mines Long Room In Miniboss Path Shuffled Npc Animation Loader"; break;
                        case 788: eventLabels[i] = "Mines Boss Room Shuffled Npc Animation Loader"; break;
                        case 789: eventLabels[i] = "Tower Curtain Game Room Shuffled Npc Animation Loader"; break;
                        case 790: eventLabels[i] = "Marrymore Occupied Sanctuary Shuffled Npc Animation Loader"; break;
                        case 791: eventLabels[i] = "Tower Ancestor Game Room Shuffled Npc Animation Loader"; break;
                        case 792: eventLabels[i] = "Tower First Bobomb Staircase Shuffled Npc Animation Loader"; break;
                        case 793: eventLabels[i] = "Tower First Bobomb Staircase Loader"; break;
                        case 794: eventLabels[i] = "Tower Balcony Shuffled Npc Animation Loader"; break;
                        case 795: eventLabels[i] = "Ending Credits Chapel Shuffled Npc Animation Loader"; break;
                        case 796: eventLabels[i] = "Marrymore Kitchen Shuffled Npc Animation Loader"; break;
                        case 797: eventLabels[i] = "Tower Lobby Shuffled Npc Animation Loader"; break;
                        case 798: eventLabels[i] = "Tower First Rail Room Shuffled Npc Animation Loader"; break;
                        case 799: eventLabels[i] = "Tower Jumping Spookum Room Shuffled Npc Animation Loader"; break;
                        case 800: eventLabels[i] = "Ship Password Room Shuffled Npc Animation Loader"; break;
                        case 801: eventLabels[i] = "Ship Boss Room Shuffled Npc Animation Loader"; break;
                        case 802: eventLabels[i] = "Seaside Occupied Beach Shuffled Npc Animation Loader"; break;
                        case 803: eventLabels[i] = "Ship 1St Preboss Battle Room Shuffled Npc Animation Loader"; break;
                        case 804: eventLabels[i] = "Ship 2Nd Preboss Battle Room Shuffled Npc Animation Loader"; break;
                        case 805: eventLabels[i] = "Seaside Occupied Elder House 1F Shuffled Npc Animation Loader"; break;
                        case 806: eventLabels[i] = "Seaside Occupied Exterior Shuffled Npc Animation Loader"; break;
                        case 807: eventLabels[i] = "Seaside Occupied Inn 1F Shuffled Npc Animation Loader"; break;
                        case 808: eventLabels[i] = "Seaside Occupied Inn 2F Shuffled Npc Animation Loader"; break;
                        case 809: eventLabels[i] = "Seaside Occupied Bomb Shop Shuffled Npc Animation Loader"; break;
                        case 810: eventLabels[i] = "Seaside Occupied Wpn Arm Shop Shuffled Npc Animation Loader"; break;
                        case 811: eventLabels[i] = "Seaside Occupied Health Store Shuffled Npc Animation Loader"; break;
                        case 812: eventLabels[i] = "Seaside Occupied Mushroom Boy Shop Shuffled Npc Animation Loader"; break;
                        case 813: eventLabels[i] = "Seaside Occupied Accessory Shop Shuffled Npc Animation Loader"; break;
                        case 814: eventLabels[i] = "Temple Boss Room Shuffled Npc Animation Loader"; break;
                        case 815: eventLabels[i] = "Dojo Shuffled Npc Animation Loader"; break;
                        case 816: eventLabels[i] = "Monstro Superboss Shuffled Npc Animation Loader"; break;
                        case 817: eventLabels[i] = "Bean Valley Boss Room Shuffled Npc Animation Loader"; break;
                        case 818: eventLabels[i] = "Nimbus Castle Statue Polisher Boss Room Shuffled Npc Animation Loader"; break;
                        case 819: eventLabels[i] = "Nimbus Castle Statue Polishing Room Shuffled Npc Animation Loader"; break;
                        case 820: eventLabels[i] = "Nimbus Castle Final Hallway Shuffled Npc Animation Loader"; break;
                        case 821: eventLabels[i] = "Garros House Shuffled Npc Animation Loader"; break;
                        case 822: eventLabels[i] = "Nimbus Land Occupied Exterior Final Boss Room Shuffled Npc Animation Loader"; break;
                        case 823: eventLabels[i] = "Nimbus Castle Main Hallway Shuffled Npc Animation Loader"; break;
                        case 824: eventLabels[i] = "Nimbus Castle Occupied 4Way Path Shuffled Npc Animation Loader"; break;
                        case 825: eventLabels[i] = "Nimbus Castle Throne Room Antechamber Shuffled Npc Animation Loader"; break;
                        case 826: eventLabels[i] = "Nimbus Castle Occupied Throne Room Shuffled Npc Animation Loader"; break;
                        case 827: eventLabels[i] = "Nimbus Castle Single Bird Statue Room Shuffled Npc Animation Loader"; break;
                        case 828: eventLabels[i] = "Nimbus Castle Single Bird Statue Room Loader"; break;
                        case 829: eventLabels[i] = "Nimbus Castle Early West Shaman Path Shuffled Npc Animation Loader"; break;
                        case 830: eventLabels[i] = "Nimbus Castle Early East Shaman Path Shuffled Npc Animation Loader"; break;
                        case 831: eventLabels[i] = "Nimbus Castle Liberated Throne Room Shuffled Npc Animation Loader"; break;
                        case 832: eventLabels[i] = "Nimbus Land Hot Springs Shuffled Npc Animation Loader"; break;
                        case 833: eventLabels[i] = "Nimbus Castle Liberated Inner Cellar Hallway Loader"; break;
                        case 834: eventLabels[i] = "Nimbus Castle Liberated Inner Cellar Hallway Shuffled Npc Animation Loader"; break;
                        case 835: eventLabels[i] = "Nimbus Castle Liberated 5 Door Room Shuffled Npc Animation Loader"; break;
                        case 836: eventLabels[i] = "Nimbus Castle Liberated 4Way Path Shuffled Npc Animation Loader"; break;
                        case 837: eventLabels[i] = "Nimbus Castle Liberated 4Way Path Loader"; break;
                        case 838: eventLabels[i] = "Nimbus Castle First Post Throne Hallway Shuffled Npc Animation Loader"; break;
                        case 839: eventLabels[i] = "Nimbus Castle Second Post Throne Hallway Shuffled Npc Animation Loader"; break;
                        case 840: eventLabels[i] = "Volcano First Boss Room Shuffled Npc Animation Loader"; break;
                        case 841: eventLabels[i] = "Volcano Final Pre Exit Room Loader"; break;
                        case 842: eventLabels[i] = "Volcano Final Pre Exit Room Shuffled Npc Animation Loader"; break;
                        case 843: eventLabels[i] = "Volcano Post Boss Room With Enemy Warps Shuffled Npc Animation Loader"; break;
                        case 844: eventLabels[i] = "Volcano Exit Room Shuffled Npc Animation Loader"; break;
                        case 845: eventLabels[i] = "Volcano Brief Henchman Room Shuffled Npc Animation Loader"; break;
                        case 846: eventLabels[i] = "Keep Battle Door 1C Shuffled Npc Animation Loader"; break;
                        case 847: eventLabels[i] = "Keep First Boss Room Shuffled Npc Animation Loader"; break;
                        case 848: eventLabels[i] = "Keep Battle Door 2B Shuffled Npc Animation Loader"; break;
                        case 849: eventLabels[i] = "Keep Battle Door 2C Shuffled Npc Animation Loader"; break;
                        case 850: eventLabels[i] = "Keep Battle Door 1A Shuffled Npc Animation Loader"; break;
                        case 851: eventLabels[i] = "Keep Battle Door 1B Shuffled Npc Animation Loader"; break;
                        case 852: eventLabels[i] = "Keep Battle Door 2A Shuffled Npc Animation Loader"; break;
                        case 853: eventLabels[i] = "Keep Final Boss Room Shuffled Npc Animation Loader"; break;
                        case 854: eventLabels[i] = "Abyss 1St Boss Room Shuffled Npc Animation Loader"; break;
                        case 855: eventLabels[i] = "Inner Factory 1St Room Shuffled Npc Animation Loader"; break;
                        case 856: eventLabels[i] = "Inner Factory 2Nd Room Shuffled Npc Animation Loader"; break;
                        case 857: eventLabels[i] = "Inner Factory 3Rd Room Shuffled Npc Animation Loader"; break;
                        case 858: eventLabels[i] = "Inner Factory 4Th Room Shuffled Npc Animation Loader"; break;
                        case 859: eventLabels[i] = "Inner Factory 1St Room Post Fight Shuffled Npc Animation Loader"; break;
                        case 860: eventLabels[i] = "Mines Boss Shove Subroutine"; break;
                        case 861: eventLabels[i] = "Dojo 1St Boss Challenge Subroutine"; break;
                        case 862: eventLabels[i] = "Dojo 2Nd Boss Challenge Subroutine"; break;
                        case 863: eventLabels[i] = "Dojo 2Nd Boss Challenge Deescalate"; break;
                        case 864: eventLabels[i] = "Dojo 3Rd Boss Challenge Subroutine"; break;
                        case 865: eventLabels[i] = "Dojo 3Rd Boss Challenge Deescalate"; break;
                        case 866: eventLabels[i] = "Dojo 4Th Boss Challenge Subroutine"; break;
                        case 867: eventLabels[i] = "Dojo 5Th Boss Challenge Subroutine"; break;
                        case 868: eventLabels[i] = "Dojo 5Th Boss Challenge Deescalate"; break;
                        case 869: eventLabels[i] = "Test Script 3"; break;
                        case 870: eventLabels[i] = "Test Script 4"; break;
                        case 871: eventLabels[i] = "Test Script 5"; break;
                        case 872: eventLabels[i] = "Test Script 6"; break;
                        case 873: eventLabels[i] = "Test Script 7"; break;
                        case 874: eventLabels[i] = "Test Script 8"; break;
                        case 875: eventLabels[i] = "Test Script 9"; break;
                        case 876: eventLabels[i] = "Test Script 10"; break;
                        case 877: eventLabels[i] = "Test Script 11"; break;
                        case 878: eventLabels[i] = "Tower Exterior Shuffled Npc Animation Loader"; break;
                        case 879: eventLabels[i] = "Ship Trampoline Loader Override"; break;
                        case 880: eventLabels[i] = "Booster Pass Secret Room Shuffled Npc Animation Loader"; break;
                        case 881: eventLabels[i] = "Booster Pass Seesaw Chest Room Shuffled Npc Animation Loader"; break;
                        case 882: eventLabels[i] = "Chest Flower Item Collection"; break;
                        case 883: eventLabels[i] = "Chest Item Bag Packet"; break;
                        case 884: eventLabels[i] = "Chest Feather Packet"; break;
                        case 885: eventLabels[i] = "Chest Star Piece Packet"; break;
                        case 886: eventLabels[i] = "Chest Ring Packet"; break;
                        case 887: eventLabels[i] = "Chest Brooch Packet"; break;
                        case 888: eventLabels[i] = "Chest Shoes Packet"; break;
                        case 889: eventLabels[i] = "Chest Banana Peel Packet"; break;
                        case 890: eventLabels[i] = "Chest Crown Packet"; break;
                        case 891: eventLabels[i] = "Chest Bomb Packet"; break;
                        case 892: eventLabels[i] = "Chest Egg Packet"; break;
                        case 893: eventLabels[i] = "Chest Cookie Packet"; break;
                        case 894: eventLabels[i] = "Chest Berry Packet"; break;
                        case 895: eventLabels[i] = "Chest Card Packet"; break;
                        case 896: eventLabels[i] = "Chest Green Item Collection"; break;
                        case 897: eventLabels[i] = "Chest Red Item Collection"; break;
                        case 898: eventLabels[i] = "Chest Blue Item Collection"; break;
                        case 899: eventLabels[i] = "Chest Yellow Item Collection"; break;
                        case 900: eventLabels[i] = "Chest Spell 1"; break;
                        case 901: eventLabels[i] = "Chest Spell 2"; break;
                        case 902: eventLabels[i] = "Chest Spell 3"; break;
                        case 903: eventLabels[i] = "Chest Spell 4"; break;
                        case 904: eventLabels[i] = "Chest Spell 5"; break;
                        case 905: eventLabels[i] = "Chest Spell 6"; break;
                        case 906: eventLabels[i] = "Chest Spell 7"; break;
                        case 907: eventLabels[i] = "Chest Spell 8"; break;
                        case 908: eventLabels[i] = "Chest Spell 9"; break;
                        case 909: eventLabels[i] = "Chest Spell 10"; break;
                        case 910: eventLabels[i] = "Chest Spell 11"; break;
                        case 911: eventLabels[i] = "Chest Spell 12"; break;
                        case 912: eventLabels[i] = "Chest Spell 13"; break;
                        case 913: eventLabels[i] = "Chest Spell 14"; break;
                        case 914: eventLabels[i] = "Chest Spell 15"; break;
                        case 915: eventLabels[i] = "Chest Spell 16"; break;
                        case 916: eventLabels[i] = "Chest Spell 17"; break;
                        case 917: eventLabels[i] = "Chest Beetle Packet"; break;
                        case 918: eventLabels[i] = "Chest Spell 18"; break;
                        case 919: eventLabels[i] = "Chest Spell 19"; break;
                        case 920: eventLabels[i] = "Chest Spell 20"; break;
                        case 921: eventLabels[i] = "Chest Spell 21"; break;
                        case 922: eventLabels[i] = "Chest Spell 22"; break;
                        case 923: eventLabels[i] = "Chest Spell 23"; break;
                        case 924: eventLabels[i] = "Chest Spell 24"; break;
                        case 925: eventLabels[i] = "Chest Spell 25"; break;
                        case 926: eventLabels[i] = "Chest Spell 26"; break;
                        case 927: eventLabels[i] = "Chest Spell 27"; break;
                        case 928: eventLabels[i] = "Unused"; break;
                        case 929: eventLabels[i] = "Unused"; break;
                        case 930: eventLabels[i] = "Yoshi Cookie Storage Business Logic"; break;
                        case 931: eventLabels[i] = "Initatie Yoshi Race For Gambling"; break;
                        case 932: eventLabels[i] = "Fat Yoshi"; break;
                        case 933: eventLabels[i] = "Fat Yoshi Present Generator"; break;
                        case 934: eventLabels[i] = "Progressive Firework Chest Packet"; break;
                        case 935: eventLabels[i] = "Marrymore Inn Regular Room Loader"; break;
                        case 936: eventLabels[i] = "Peck Subroutine Left Statue"; break;
                        case 937: eventLabels[i] = "Peck Subroutine Middle Statue"; break;
                        case 938: eventLabels[i] = "Peck Subroutine Right Statue"; break;
                        case 939: eventLabels[i] = "Statue Subroutine 1"; break;
                        case 940: eventLabels[i] = "Statue Subroutine 2"; break;
                        case 941: eventLabels[i] = "Keep First Boss Set Script"; break;
                        case 942: eventLabels[i] = "Keep First Boss Summon Chest"; break;
                        case 943: eventLabels[i] = "Keep Second Boss Animation Subroutine"; break;
                        case 944: eventLabels[i] = "Final Boss Animation Subroutine 1"; break;
                        case 945: eventLabels[i] = "Final Boss Animation Subroutine 2"; break;
                        case 946: eventLabels[i] = "Final Boss Animation Subroutine 3"; break;
                        case 947: eventLabels[i] = "Frogfucius Hint Main Checks"; break;
                        case 948: eventLabels[i] = "Frogfucius Hint Expansion"; break;
                        case 949: eventLabels[i] = "Frogfucius Hint Treasure Chests"; break;
                        case 950: eventLabels[i] = "Chest Glove Packet"; break;
                        case 951: eventLabels[i] = "Crystal Chest Packet"; break;
                        case 952: eventLabels[i] = "Npc Spell 1"; break;
                        case 953: eventLabels[i] = "Npc Spell 2"; break;
                        case 954: eventLabels[i] = "Npc Spell 3"; break;
                        case 955: eventLabels[i] = "Npc Spell 4"; break;
                        case 956: eventLabels[i] = "Npc Spell 5"; break;
                        case 957: eventLabels[i] = "Npc Spell 6"; break;
                        case 958: eventLabels[i] = "Npc Spell 7"; break;
                        case 959: eventLabels[i] = "Npc Spell 8"; break;
                        case 960: eventLabels[i] = "Npc Spell 9"; break;
                        case 961: eventLabels[i] = "Npc Spell 10"; break;
                        case 962: eventLabels[i] = "Npc Spell 11"; break;
                        case 963: eventLabels[i] = "Npc Spell 12"; break;
                        case 964: eventLabels[i] = "Npc Spell 13"; break;
                        case 965: eventLabels[i] = "Npc Spell 14"; break;
                        case 966: eventLabels[i] = "Npc Spell 16"; break;
                        case 967: eventLabels[i] = "Npc Spell 17"; break;
                        case 968: eventLabels[i] = "Npc Spell 18"; break;
                        case 969: eventLabels[i] = "Npc Spell 19"; break;
                        case 970: eventLabels[i] = "Npc Spell 20"; break;
                        case 971: eventLabels[i] = "Npc Spell 21"; break;
                        case 972: eventLabels[i] = "Npc Spell 22"; break;
                        case 973: eventLabels[i] = "Npc Spell 23"; break;
                        case 974: eventLabels[i] = "Npc Spell 24"; break;
                        case 975: eventLabels[i] = "Npc Spell 25"; break;
                        case 976: eventLabels[i] = "Npc Spell 26"; break;
                        case 977: eventLabels[i] = "Npc Spell 27"; break;
                        case 978: eventLabels[i] = "Freestanding Spell 1"; break;
                        case 979: eventLabels[i] = "Frogfucius Hint Optional Marrymore"; break;
                        case 980: eventLabels[i] = "Frogfucius Hint Marrymore Suite"; break;
                        case 981: eventLabels[i] = "Frogfucius Hint Optional 1"; break;
                        case 982: eventLabels[i] = "Frogfucius Hint Optional 2"; break;
                        case 983: eventLabels[i] = "Frogfucius Hint Optional 3"; break;
                        case 984: eventLabels[i] = "Frogfucius Hint Optional 4"; break;
                        case 985: eventLabels[i] = "Frogfucius Hint Optional 5"; break;
                        case 986: eventLabels[i] = "Frogfucius Hint Optional 6"; break;
                        case 987: eventLabels[i] = "Frogfucius Hint Optional 7"; break;
                        case 988: eventLabels[i] = "Frogfucius Hint Optional 8"; break;
                        case 989: eventLabels[i] = "Frogfucius Hint Optional 9"; break;
                        case 990: eventLabels[i] = "Frogfucius Hint Optional 10"; break;
                        case 991: eventLabels[i] = "Frogfucius Hint Dialogues"; break;
                        case 992: eventLabels[i] = "Freestanding Spell 2"; break;
                        case 993: eventLabels[i] = "Freestanding Spell 3"; break;
                        case 994: eventLabels[i] = "Freestanding Spell 4"; break;
                        case 995: eventLabels[i] = "Freestanding Spell 5"; break;
                        case 996: eventLabels[i] = "Freestanding Spell 6"; break;
                        case 997: eventLabels[i] = "Freestanding Spell 7"; break;
                        case 998: eventLabels[i] = "Set Star Hill As Checked"; break;
                        case 999: eventLabels[i] = "Freestanding Spell 8"; break;
                        case 1000: eventLabels[i] = "Freestanding Spell 9"; break;
                        case 1001: eventLabels[i] = "Freestanding Spell 10"; break;
                        case 1002: eventLabels[i] = "Freestanding Spell 11"; break;
                        case 1003: eventLabels[i] = "Freestanding Spell 12"; break;
                        case 1004: eventLabels[i] = "Freestanding Spell 13"; break;
                        case 1005: eventLabels[i] = "Freestanding Spell 14"; break;
                        case 1006: eventLabels[i] = "Freestanding Spell 16"; break;
                        case 1007: eventLabels[i] = "Freestanding Spell 17"; break;
                        case 1008: eventLabels[i] = "Post Mines Boss Subroutine"; break;
                        case 1009: eventLabels[i] = "Unknown"; break;
                        case 1010: eventLabels[i] = "Shyster Subroutine"; break;
                        case 1011: eventLabels[i] = "Post Mines Boss Check If Won"; break;
                        case 1012: eventLabels[i] = "Freestanding Spell 18"; break;
                        case 1013: eventLabels[i] = "Freestanding Spell 19"; break;
                        case 1014: eventLabels[i] = "Freestanding Spell 20"; break;
                        case 1015: eventLabels[i] = "Freestanding Spell 21"; break;
                        case 1016: eventLabels[i] = "Freestanding Spell 22"; break;
                        case 1017: eventLabels[i] = "Freestanding Spell 23"; break;
                        case 1018: eventLabels[i] = "Freestanding Spell 24"; break;
                        case 1019: eventLabels[i] = "Freestanding Spell 25"; break;
                        case 1020: eventLabels[i] = "Freestanding Spell 26"; break;
                        case 1021: eventLabels[i] = "Freestanding Spell 27"; break;
                        case 1022: eventLabels[i] = "Hill River Spell 1"; break;
                        case 1023: eventLabels[i] = "Hill River Spell 2"; break;
                        case 1024: eventLabels[i] = "Hill River Spell 3"; break;
                        case 1025: eventLabels[i] = "Hill River Spell 4"; break;
                        case 1026: eventLabels[i] = "Hill River Spell 5"; break;
                        case 1027: eventLabels[i] = "Hill River Spell 6"; break;
                        case 1028: eventLabels[i] = "Hill River Spell 7"; break;
                        case 1029: eventLabels[i] = "Hill River Spell 8"; break;
                        case 1030: eventLabels[i] = "Hill River Spell 9"; break;
                        case 1031: eventLabels[i] = "Hill River Spell 10"; break;
                        case 1032: eventLabels[i] = "Hill River Spell 11"; break;
                        case 1033: eventLabels[i] = "Hill River Spell 12"; break;
                        case 1034: eventLabels[i] = "Hill River Spell 13"; break;
                        case 1035: eventLabels[i] = "Hill River Spell 14"; break;
                        case 1036: eventLabels[i] = "Hill River Spell 16"; break;
                        case 1037: eventLabels[i] = "Hill River Spell 17"; break;
                        case 1038: eventLabels[i] = "Hill River Spell 18"; break;
                        case 1039: eventLabels[i] = "Hill River Spell 19"; break;
                        case 1040: eventLabels[i] = "Hill River Spell 20"; break;
                        case 1041: eventLabels[i] = "Hill River Spell 21"; break;
                        case 1042: eventLabels[i] = "Hill River Spell 22"; break;
                        case 1043: eventLabels[i] = "Hill River Spell 23"; break;
                        case 1044: eventLabels[i] = "Hill River Spell 24"; break;
                        case 1045: eventLabels[i] = "Hill River Spell 25"; break;
                        case 1046: eventLabels[i] = "Hill River Spell 26"; break;
                        case 1047: eventLabels[i] = "Hill River Spell 27"; break;
                        case 1048: eventLabels[i] = "Npc Spell 15"; break;
                        case 1049: eventLabels[i] = "Freestanding Spell 15"; break;
                        case 1050: eventLabels[i] = "Hill River Spell 15"; break;
                        case 1051: eventLabels[i] = "Empty"; break;
                        case 1052: eventLabels[i] = "Empty"; break;
                        case 1053: eventLabels[i] = "Empty"; break;
                        case 1054: eventLabels[i] = "Empty"; break;
                        case 1055: eventLabels[i] = "Empty"; break;
                        case 1056: eventLabels[i] = "Empty"; break;
                        case 1057: eventLabels[i] = "Empty"; break;
                        case 1058: eventLabels[i] = "Empty"; break;
                        case 1059: eventLabels[i] = "Empty"; break;
                        case 1060: eventLabels[i] = "Empty"; break;
                        case 1061: eventLabels[i] = "Empty"; break;
                        case 1062: eventLabels[i] = "Empty"; break;
                        case 1063: eventLabels[i] = "Empty"; break;
                        case 1064: eventLabels[i] = "Empty"; break;
                        case 1065: eventLabels[i] = "Empty"; break;
                        case 1066: eventLabels[i] = "Empty"; break;
                        case 1067: eventLabels[i] = "Empty"; break;
                        case 1068: eventLabels[i] = "Empty"; break;
                        case 1069: eventLabels[i] = "Empty"; break;
                        case 1070: eventLabels[i] = "Empty"; break;
                        case 1071: eventLabels[i] = "Begin Melody Bay Tadpoles"; break;
                        case 1072: eventLabels[i] = "Melody Bay Loader"; break;
                        case 1073: eventLabels[i] = "Melody Bay Jump On Tadpoles"; break;
                        case 1074: eventLabels[i] = "Melody Bay Song Judged"; break;
                        case 1075: eventLabels[i] = "Toadofsky"; break;
                        case 1076: eventLabels[i] = "Empty"; break;
                        case 1077: eventLabels[i] = "Empty"; break;
                        case 1078: eventLabels[i] = "Melody Bay Final Song"; break;
                        case 1079: eventLabels[i] = "Melody Bay Song 1 Validator"; break;
                        case 1080: eventLabels[i] = "Melody Bay Song 2 Validator"; break;
                        case 1081: eventLabels[i] = "Melody Bay Song 3 Validator"; break;
                        case 1082: eventLabels[i] = "Melody Bay Song 1 Input"; break;
                        case 1083: eventLabels[i] = "Melody Bay Song 2 Input"; break;
                        case 1084: eventLabels[i] = "Melody Bay Song 3 Input"; break;
                        case 1085: eventLabels[i] = "Melody Bay Jump Animation"; break;
                        case 1086: eventLabels[i] = "Melody Bay Swim Animation"; break;
                        case 1087: eventLabels[i] = "Melody Bay Exit Water Animation"; break;
                        case 1088: eventLabels[i] = "Melody Bay Third Song Hint"; break;
                        case 1089: eventLabels[i] = "Empty"; break;
                        case 1090: eventLabels[i] = "Empty"; break;
                        case 1091: eventLabels[i] = "Empty"; break;
                        case 1092: eventLabels[i] = "Empty"; break;
                        case 1093: eventLabels[i] = "Empty"; break;
                        case 1094: eventLabels[i] = "Empty"; break;
                        case 1095: eventLabels[i] = "Empty"; break;
                        case 1096: eventLabels[i] = "Empty"; break;
                        case 1097: eventLabels[i] = "Empty"; break;
                        case 1098: eventLabels[i] = "Empty"; break;
                        case 1099: eventLabels[i] = "Empty"; break;
                        case 1100: eventLabels[i] = "Empty"; break;
                        case 1101: eventLabels[i] = "Empty"; break;
                        case 1102: eventLabels[i] = "Empty"; break;
                        case 1103: eventLabels[i] = "Empty"; break;
                        case 1104: eventLabels[i] = "Tadpole Pond Loader"; break;
                        case 1105: eventLabels[i] = "Tadpole Bridge Summon"; break;
                        case 1106: eventLabels[i] = "Tadpole Bridge Summon"; break;
                        case 1107: eventLabels[i] = "Tadpole Bridge Jumping"; break;
                        case 1108: eventLabels[i] = "Frogfucius Scroll"; break;
                        case 1109: eventLabels[i] = "Empty"; break;
                        case 1110: eventLabels[i] = "Empty"; break;
                        case 1111: eventLabels[i] = "Frogfucius"; break;
                        case 1112: eventLabels[i] = "Frog Coin Emporium"; break;
                        case 1113: eventLabels[i] = "Song Hint Tadpole"; break;
                        case 1114: eventLabels[i] = "Summon Tadpole Shops"; break;
                        case 1115: eventLabels[i] = "Summon Hint Tadpole"; break;
                        case 1116: eventLabels[i] = "Juice Bar"; break;
                        case 1117: eventLabels[i] = "Empty"; break;
                        case 1118: eventLabels[i] = "Empty"; break;
                        case 1119: eventLabels[i] = "Seaside Occupied Exterior Loader"; break;
                        case 1120: eventLabels[i] = "Empty"; break;
                        case 1121: eventLabels[i] = "Seaside Occupied Inn 1F Loader"; break;
                        case 1122: eventLabels[i] = "Seaside Occupied Inn 2F Loader"; break;
                        case 1123: eventLabels[i] = "Seaside Occupied Elders House Loader"; break;
                        case 1124: eventLabels[i] = "Frog Shop Room Loader"; break;
                        case 1125: eventLabels[i] = "Seaside Occupied Bomb Shop Loader"; break;
                        case 1126: eventLabels[i] = "Seaside Occupied Armor Shop Loader"; break;
                        case 1127: eventLabels[i] = "Seaside Occupied Health Store Loader"; break;
                        case 1128: eventLabels[i] = "Seaside Occupied Mushroom Boy Shop Loader"; break;
                        case 1129: eventLabels[i] = "Seaside Occupied Accessory Shop Loader"; break;
                        case 1130: eventLabels[i] = "Empty"; break;
                        case 1131: eventLabels[i] = "Empty"; break;
                        case 1132: eventLabels[i] = "Seaside Occupied Innkeeper"; break;
                        case 1133: eventLabels[i] = "Seaside Occupied Accessory Shop Occupant"; break;
                        case 1134: eventLabels[i] = "Fake Elder"; break;
                        case 1135: eventLabels[i] = "Seaside Occupied Mushroom Boy Shop Occupant 1"; break;
                        case 1136: eventLabels[i] = "Seaside Occupied Mushroom Boy Shop Occupant 2"; break;
                        case 1137: eventLabels[i] = "Seaside Occupied Health Store Occupant"; break;
                        case 1138: eventLabels[i] = "Seaside Occupied Wpn Arm Shop Occupant 1"; break;
                        case 1139: eventLabels[i] = "Seaside Occupied Wpn Arm Shop Occupant 2"; break;
                        case 1140: eventLabels[i] = "Seaside Occupied Bomb Shop"; break;
                        case 1141: eventLabels[i] = "Seaside Occupied Bomb Shop Customer"; break;
                        case 1142: eventLabels[i] = "Seaside Shed Guard 1"; break;
                        case 1143: eventLabels[i] = "Seaside Shed Guard 2"; break;
                        case 1144: eventLabels[i] = "Shed Window"; break;
                        case 1145: eventLabels[i] = "Seaside Occupied Beach Loader"; break;
                        case 1146: eventLabels[i] = "Seaside Initiate Boss Fight"; break;
                        case 1147: eventLabels[i] = "Seaside Initiate Boss Fight Animation"; break;
                        case 1148: eventLabels[i] = "Frog Shop"; break;
                        case 1149: eventLabels[i] = "Empty"; break;
                        case 1150: eventLabels[i] = "Empty"; break;
                        case 1151: eventLabels[i] = "Empty"; break;
                        case 1152: eventLabels[i] = "Empty"; break;
                        case 1153: eventLabels[i] = "Seaside Liberated Inn 1F Loader"; break;
                        case 1154: eventLabels[i] = "Empty"; break;
                        case 1155: eventLabels[i] = "Seaside Liberated Elders House Loader"; break;
                        case 1156: eventLabels[i] = "Empty"; break;
                        case 1157: eventLabels[i] = "Empty"; break;
                        case 1158: eventLabels[i] = "Seaside Liberated Wpn Arm Shop Loader"; break;
                        case 1159: eventLabels[i] = "Seaside Liberated Health Store Loader"; break;
                        case 1160: eventLabels[i] = "Seaside Liberated Mushroom Boy Loader"; break;
                        case 1161: eventLabels[i] = "Seaside Liberated Accessory Shop Loader"; break;
                        case 1162: eventLabels[i] = "Seaside Liberated Shed Loader"; break;
                        case 1163: eventLabels[i] = "Seaside Liberated Beach"; break;
                        case 1164: eventLabels[i] = "Empty"; break;
                        case 1165: eventLabels[i] = "Seaside Liberated Beach Letter"; break;
                        case 1166: eventLabels[i] = "Shed Key Door"; break;
                        case 1167: eventLabels[i] = "Seaside Elder"; break;
                        case 1168: eventLabels[i] = "Seaside Liberated Innkeeper"; break;
                        case 1169: eventLabels[i] = "Open Lands End If Gated By Elder"; break;
                        case 1170: eventLabels[i] = "Seaside Health Food Shop"; break;
                        case 1171: eventLabels[i] = "Seaside Accessory Shop"; break;
                        case 1172: eventLabels[i] = "Mushroom Boy"; break;
                        case 1173: eventLabels[i] = "Seaside Weapon Shop"; break;
                        case 1174: eventLabels[i] = "Seaside Armor Shop"; break;
                        case 1175: eventLabels[i] = "Empty"; break;
                        case 1176: eventLabels[i] = "Empty"; break;
                        case 1177: eventLabels[i] = "Empty"; break;
                        case 1178: eventLabels[i] = "Seaside Grant Shed Item"; break;
                        case 1179: eventLabels[i] = "Juice Bar No Card"; break;
                        case 1180: eventLabels[i] = "Juice Bar Alto Card"; break;
                        case 1181: eventLabels[i] = "Juice Bar Tenor Card"; break;
                        case 1182: eventLabels[i] = "Juice Bar Soprano Card"; break;
                        case 1183: eventLabels[i] = "Volcano Item Shop"; break;
                        case 1184: eventLabels[i] = "Volcano Armor Shop"; break;
                        case 1185: eventLabels[i] = "Toad Shop"; break;
                        case 1186: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1187: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1188: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1189: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1190: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1191: eventLabels[i] = "Ending Credits Cliff Shuffled Npc Animation Loader"; break;
                        case 1192: eventLabels[i] = "Ending Credits Keep Shuffled Npc Animation Loader"; break;
                        case 1193: eventLabels[i] = "Ending Credits Yoster Shuffled Npc Animation Loader"; break;
                        case 1194: eventLabels[i] = "Mushroom Way Boss Unlocks"; break;
                        case 1195: eventLabels[i] = "Bandits Way Boss Unlocks"; break;
                        case 1196: eventLabels[i] = "Mushroom Kingdom Boss Unlocks"; break;
                        case 1197: eventLabels[i] = "Kero Sewer Boss Unlocks"; break;
                        case 1198: eventLabels[i] = "Forest Maze Boss Unlocks"; break;
                        case 1199: eventLabels[i] = "Outer Mnes Boss Unlocks"; break;
                        case 1200: eventLabels[i] = "Inner Mines Boss Unlocks"; break;
                        case 1201: eventLabels[i] = "Tower Curtain Boss Unlocks"; break;
                        case 1202: eventLabels[i] = "Postgame Tower Curtain Boss Unlocks"; break;
                        case 1203: eventLabels[i] = "Tower Balcony Boss Unlocks"; break;
                        case 1204: eventLabels[i] = "Chapel Boss Unlocks"; break;
                        case 1205: eventLabels[i] = "Postgame Chapel Boss Unlocks"; break;
                        case 1206: eventLabels[i] = "Seaside Boss Unlocks"; break;
                        case 1207: eventLabels[i] = "Ship Mid Boss Unlocks"; break;
                        case 1208: eventLabels[i] = "Ship End Boss Unlocks"; break;
                        case 1209: eventLabels[i] = "Postgame Ship End Boss Unlocks"; break;
                        case 1210: eventLabels[i] = "Cloud Boss Unlocks"; break;
                        case 1211: eventLabels[i] = "Temple Boss Unlocks"; break;
                        case 1212: eventLabels[i] = "Postgame Temple Boss Unlocks"; break;
                        case 1213: eventLabels[i] = "Dojo 1 Boss Unlocks"; break;
                        case 1214: eventLabels[i] = "Dojo 2 Boss Unlocks"; break;
                        case 1215: eventLabels[i] = "Dojo 3 Boss Unlocks"; break;
                        case 1216: eventLabels[i] = "Dojo 4 Boss Unlocks"; break;
                        case 1217: eventLabels[i] = "Dojo 5 Boss Unlocks"; break;
                        case 1218: eventLabels[i] = "Monstro Sealed Boss Unlocks"; break;
                        case 1219: eventLabels[i] = "Postgame Monstro Sealed Boss Unlocks"; break;
                        case 1220: eventLabels[i] = "Starting Character 1"; break;
                        case 1221: eventLabels[i] = "Starting Character 2"; break;
                        case 1222: eventLabels[i] = "Starting Character 3"; break;
                        case 1223: eventLabels[i] = "Starting Character 4"; break;
                        case 1224: eventLabels[i] = "Starting Character 5"; break;
                        case 1225: eventLabels[i] = "Mushroom Way Character"; break;
                        case 1226: eventLabels[i] = "Forest Maze Character"; break;
                        case 1227: eventLabels[i] = "Moleville Character"; break;
                        case 1228: eventLabels[i] = "Marrymore Character"; break;
                        case 1229: eventLabels[i] = "Bean Valley Boss Unlocks"; break;
                        case 1230: eventLabels[i] = "Statue Boss Unlocks"; break;
                        case 1231: eventLabels[i] = "Egg Boss Unlocks"; break;
                        case 1232: eventLabels[i] = "Nimbus Boss Unlocks"; break;
                        case 1233: eventLabels[i] = "Volcano Mid Boss Unlocks"; break;
                        case 1234: eventLabels[i] = "Volcano Boss Unlocks"; break;
                        case 1235: eventLabels[i] = "Obstacle Course Boss Unlocks"; break;
                        case 1236: eventLabels[i] = "Keep 1 Boss Unlocks"; break;
                        case 1237: eventLabels[i] = "Keep Chandelier Boss Unlocks"; break;
                        case 1238: eventLabels[i] = "Keep Exit Boss Unlocks"; break;
                        case 1239: eventLabels[i] = "Outer Factory 1 Boss Unlocks"; break;
                        case 1240: eventLabels[i] = "Outer Factory 2 Boss Unlocks"; break;
                        case 1241: eventLabels[i] = "Inner Factory 1 Boss Unlocks"; break;
                        case 1242: eventLabels[i] = "Inner Factory 2 Boss Unlocks"; break;
                        case 1243: eventLabels[i] = "Inner Factory 3 Boss Unlocks"; break;
                        case 1244: eventLabels[i] = "Inner Factory 4 Boss Unlocks"; break;
                        case 1245: eventLabels[i] = "Inner Factory 5 Boss Unlocks"; break;
                        case 1246: eventLabels[i] = "Invisible Grant 1"; break;
                        case 1247: eventLabels[i] = "Invisible Grant 2"; break;
                        case 1248: eventLabels[i] = "Invisible Grant 3"; break;
                        case 1249: eventLabels[i] = "Mimic 1 Boss Unlocks"; break;
                        case 1250: eventLabels[i] = "Mimic 2 Boss Unlocks"; break;
                        case 1251: eventLabels[i] = "Mimic 3 Boss Unlocks"; break;
                        case 1252: eventLabels[i] = "Flag Specific Housekeeping Game Start"; break;
                        case 1253: eventLabels[i] = "Postgame Mines Boss Unlocks"; break;
                        case 1254: eventLabels[i] = "Unlock Sewer By Rfc"; break;
                        case 1255: eventLabels[i] = "Unlock Forest By Pie"; break;
                        case 1256: eventLabels[i] = "Unlock Moleville If Gated By Boshi"; break;
                        case 1257: eventLabels[i] = "Empty"; break;
                        case 1258: eventLabels[i] = "Empty"; break;
                        case 1259: eventLabels[i] = "Empty"; break;
                        case 1260: eventLabels[i] = "Empty"; break;
                        case 1261: eventLabels[i] = "Empty"; break;
                        case 1262: eventLabels[i] = "Empty"; break;
                        case 1263: eventLabels[i] = "Empty"; break;
                        case 1264: eventLabels[i] = "Empty"; break;
                        case 1265: eventLabels[i] = "Empty"; break;
                        case 1266: eventLabels[i] = "Empty"; break;
                        case 1267: eventLabels[i] = "Empty"; break;
                        case 1268: eventLabels[i] = "Empty"; break;
                        case 1269: eventLabels[i] = "Empty"; break;
                        case 1270: eventLabels[i] = "Empty"; break;
                        case 1271: eventLabels[i] = "Empty"; break;
                        case 1272: eventLabels[i] = "Empty"; break;
                        case 1273: eventLabels[i] = "Empty"; break;
                        case 1274: eventLabels[i] = "Ship Boss Room Rightmost Henchman"; break;
                        case 1275: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Henchman"; break;
                        case 1276: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Henchman"; break;
                        case 1277: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Henchman"; break;
                        case 1278: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Henchman"; break;
                        case 1279: eventLabels[i] = "Empty"; break;
                        case 1280: eventLabels[i] = "Empty"; break;
                        case 1281: eventLabels[i] = "Empty"; break;
                        case 1282: eventLabels[i] = "Tower Balcony Loader After Marrymore"; break;
                        case 1283: eventLabels[i] = "Tower Balcony Loader Before Marrymore"; break;
                        case 1284: eventLabels[i] = "Empty"; break;
                        case 1285: eventLabels[i] = "Empty"; break;
                        case 1286: eventLabels[i] = "Empty"; break;
                        case 1287: eventLabels[i] = "Empty"; break;
                        case 1288: eventLabels[i] = "Empty"; break;
                        case 1289: eventLabels[i] = "Empty"; break;
                        case 1290: eventLabels[i] = "Empty"; break;
                        case 1291: eventLabels[i] = "Empty"; break;
                        case 1292: eventLabels[i] = "Empty"; break;
                        case 1293: eventLabels[i] = "Collect Freestanding Small Coin"; break;
                        case 1294: eventLabels[i] = "Collect Freestanding Small Frog Coin"; break;
                        case 1295: eventLabels[i] = "Tower Checkerboard Room Loader"; break;
                        case 1296: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1297: eventLabels[i] = "Empty"; break;
                        case 1298: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1299: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1300: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1301: eventLabels[i] = "Empty"; break;
                        case 1302: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1303: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1304: eventLabels[i] = "Empty"; break;
                        case 1305: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1306: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1307: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1308: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1309: eventLabels[i] = "Empty"; break;
                        case 1310: eventLabels[i] = "Tower Checkerboard Collect Key Item"; break;
                        case 1311: eventLabels[i] = "Tower Checkerboard Locked Door"; break;
                        case 1312: eventLabels[i] = "Tower Lobby Loader"; break;
                        case 1313: eventLabels[i] = "Empty"; break;
                        case 1314: eventLabels[i] = "Tower Boss 1 Hides Behind Doorway In Lobby 1"; break;
                        case 1315: eventLabels[i] = "Tower Boss 1 Hides Behind Doorway In Lobby 2"; break;
                        case 1316: eventLabels[i] = "Lobby Portrait 1"; break;
                        case 1317: eventLabels[i] = "Lobby Portrait 2"; break;
                        case 1318: eventLabels[i] = "Lobby Portrait 3"; break;
                        case 1319: eventLabels[i] = "Lobby Portrait 4"; break;
                        case 1320: eventLabels[i] = "Lobby Portrait 5"; break;
                        case 1321: eventLabels[i] = "Lobby Portrait 6"; break;
                        case 1322: eventLabels[i] = "Nimbus 5 Door Chest Liberated"; break;
                        case 1323: eventLabels[i] = "Tower Lobby Henchman"; break;
                        case 1324: eventLabels[i] = "Empty"; break;
                        case 1325: eventLabels[i] = "Empty"; break;
                        case 1326: eventLabels[i] = "Empty"; break;
                        case 1327: eventLabels[i] = "Empty"; break;
                        case 1328: eventLabels[i] = "Tower Exterior Loader"; break;
                        case 1329: eventLabels[i] = "Hill Unlocks"; break;
                        case 1330: eventLabels[i] = "Tower Exterior Door"; break;
                        case 1331: eventLabels[i] = "Tower Break Down Door"; break;
                        case 1332: eventLabels[i] = "Portrait Game 1"; break;
                        case 1333: eventLabels[i] = "Portrait Game 2"; break;
                        case 1334: eventLabels[i] = "Portrait Game 3"; break;
                        case 1335: eventLabels[i] = "Portrait Game 4"; break;
                        case 1336: eventLabels[i] = "Portrait Game 5"; break;
                        case 1337: eventLabels[i] = "Portrait Game 6"; break;
                        case 1338: eventLabels[i] = "Portrait Game Incorrect"; break;
                        case 1339: eventLabels[i] = "Portrait Game Room Loader"; break;
                        case 1340: eventLabels[i] = "Portrait Game Room Locked Door"; break;
                        case 1341: eventLabels[i] = "Elder Key Prize Room Loader"; break;
                        case 1342: eventLabels[i] = "Elder Key Prize Granter"; break;
                        case 1343: eventLabels[i] = "Portrait Game Instructions"; break;
                        case 1344: eventLabels[i] = "Tower Henchman 2 Room Loader"; break;
                        case 1345: eventLabels[i] = "Empty"; break;
                        case 1346: eventLabels[i] = "Tower Henchman 2"; break;
                        case 1347: eventLabels[i] = "Tower Henchman 2 Room Hidden Item"; break;
                        case 1348: eventLabels[i] = "Empty"; break;
                        case 1349: eventLabels[i] = "Empty"; break;
                        case 1350: eventLabels[i] = "Empty"; break;
                        case 1351: eventLabels[i] = "Empty"; break;
                        case 1352: eventLabels[i] = "Empty"; break;
                        case 1353: eventLabels[i] = "Tower Checkerboard Room Locked Door"; break;
                        case 1354: eventLabels[i] = "Empty"; break;
                        case 1355: eventLabels[i] = "Empty"; break;
                        case 1356: eventLabels[i] = "Empty"; break;
                        case 1357: eventLabels[i] = "Empty"; break;
                        case 1358: eventLabels[i] = "Curtain Game Begins Npcs Walk Into Room"; break;
                        case 1359: eventLabels[i] = "Curtain Game Room Loader"; break;
                        case 1360: eventLabels[i] = "Curtain 1"; break;
                        case 1361: eventLabels[i] = "Curtain 2"; break;
                        case 1362: eventLabels[i] = "Curtain 3"; break;
                        case 1363: eventLabels[i] = "Curtain 4"; break;
                        case 1364: eventLabels[i] = "Curtain Room Exit To Balcony"; break;
                        case 1365: eventLabels[i] = "Curtain Game Business Logic 1"; break;
                        case 1366: eventLabels[i] = "Curtain Game Business Logic 2"; break;
                        case 1367: eventLabels[i] = "Curtain Game Success 1"; break;
                        case 1368: eventLabels[i] = "Curtain Game Success 2"; break;
                        case 1369: eventLabels[i] = "Curtain Game Success Failure Fight Boss"; break;
                        case 1370: eventLabels[i] = "Curtain Game Success Failure General"; break;
                        case 1371: eventLabels[i] = "Unlock Marrymore If Gated By Tower Balcony Fight"; break;
                        case 1372: eventLabels[i] = "Toad Voucher Grant"; break;
                        case 1373: eventLabels[i] = "Empty"; break;
                        case 1374: eventLabels[i] = "Empty"; break;
                        case 1375: eventLabels[i] = "Empty"; break;
                        case 1376: eventLabels[i] = "Empty"; break;
                        case 1377: eventLabels[i] = "Empty"; break;
                        case 1378: eventLabels[i] = "Empty"; break;
                        case 1379: eventLabels[i] = "Empty"; break;
                        case 1380: eventLabels[i] = "Empty"; break;
                        case 1381: eventLabels[i] = "Empty"; break;
                        case 1382: eventLabels[i] = "Empty"; break;
                        case 1383: eventLabels[i] = "Empty"; break;
                        case 1384: eventLabels[i] = "Empty"; break;
                        case 1385: eventLabels[i] = "Vista Hill Loader"; break;
                        case 1386: eventLabels[i] = "Vista Hill Loader Continued"; break;
                        case 1387: eventLabels[i] = "Empty"; break;
                        case 1388: eventLabels[i] = "Empty"; break;
                        case 1389: eventLabels[i] = "Empty"; break;
                        case 1390: eventLabels[i] = "Empty"; break;
                        case 1391: eventLabels[i] = "Empty"; break;
                        case 1392: eventLabels[i] = "Marios House Interior Loader"; break;
                        case 1393: eventLabels[i] = "Empty"; break;
                        case 1394: eventLabels[i] = "Four Digit Coin Value Handler"; break;
                        case 1395: eventLabels[i] = "Marios House Lamp"; break;
                        case 1396: eventLabels[i] = "Empty"; break;
                        case 1397: eventLabels[i] = "Empty"; break;
                        case 1398: eventLabels[i] = "Empty"; break;
                        case 1399: eventLabels[i] = "Empty"; break;
                        case 1400: eventLabels[i] = "Empty"; break;
                        case 1401: eventLabels[i] = "Empty"; break;
                        case 1402: eventLabels[i] = "Empty"; break;
                        case 1403: eventLabels[i] = "Empty"; break;
                        case 1404: eventLabels[i] = "Empty"; break;
                        case 1405: eventLabels[i] = "Empty"; break;
                        case 1406: eventLabels[i] = "Marios Pad Open Door"; break;
                        case 1407: eventLabels[i] = "Marios Pad Close Door"; break;
                        case 1408: eventLabels[i] = "Marios Pad Exterior Loader"; break;
                        case 1409: eventLabels[i] = "Empty"; break;
                        case 1410: eventLabels[i] = "Empty"; break;
                        case 1411: eventLabels[i] = "Empty"; break;
                        case 1412: eventLabels[i] = "Empty"; break;
                        case 1413: eventLabels[i] = "Empty"; break;
                        case 1414: eventLabels[i] = "Empty"; break;
                        case 1415: eventLabels[i] = "Empty"; break;
                        case 1416: eventLabels[i] = "Empty"; break;
                        case 1417: eventLabels[i] = "Empty"; break;
                        case 1418: eventLabels[i] = "Empty"; break;
                        case 1419: eventLabels[i] = "Mushroom Way 1 Exit To World Map"; break;
                        case 1420: eventLabels[i] = "Empty"; break;
                        case 1421: eventLabels[i] = "Empty"; break;
                        case 1422: eventLabels[i] = "Rescue Toad Mushroom Way 2"; break;
                        case 1423: eventLabels[i] = "Mushroom Way 2 Loader"; break;
                        case 1424: eventLabels[i] = "Mushroom Way 2 Lone Troopa"; break;
                        case 1425: eventLabels[i] = "Summon Left Goomba In Mushroom Way 2"; break;
                        case 1426: eventLabels[i] = "Summon Right Goomba In Mushroom Way 2"; break;
                        case 1427: eventLabels[i] = "Mushroom Way 1 Loader"; break;
                        case 1428: eventLabels[i] = "Rescue Toad Mushroom Way 1"; break;
                        case 1429: eventLabels[i] = "Summon Jumping Goomba Mushroom Way 2"; break;
                        case 1430: eventLabels[i] = "Mushroom Way 2 Spinning Flower"; break;
                        case 1431: eventLabels[i] = "Summon Middle Goomba In Mushroom Way 2"; break;
                        case 1432: eventLabels[i] = "Rescue Toad Extended"; break;
                        case 1433: eventLabels[i] = "Clone Reserved"; break;
                        case 1434: eventLabels[i] = "Clone Reserved"; break;
                        case 1435: eventLabels[i] = "Clone Reserved"; break;
                        case 1436: eventLabels[i] = "Clone Reserved"; break;
                        case 1437: eventLabels[i] = "Clone Reserved"; break;
                        case 1438: eventLabels[i] = "Clone Reserved"; break;
                        case 1439: eventLabels[i] = "Clone Reserved"; break;
                        case 1440: eventLabels[i] = "Clone Reserved"; break;
                        case 1441: eventLabels[i] = "Clone Reserved"; break;
                        case 1442: eventLabels[i] = "Clone Reserved"; break;
                        case 1443: eventLabels[i] = "Clone Reserved"; break;
                        case 1444: eventLabels[i] = "Clone Reserved"; break;
                        case 1445: eventLabels[i] = "Clone Reserved"; break;
                        case 1446: eventLabels[i] = "Clone Reserved"; break;
                        case 1447: eventLabels[i] = "Clone Reserved"; break;
                        case 1448: eventLabels[i] = "Clone Reserved"; break;
                        case 1449: eventLabels[i] = "Clone Reserved"; break;
                        case 1450: eventLabels[i] = "Clone Reserved"; break;
                        case 1451: eventLabels[i] = "Clone Reserved"; break;
                        case 1452: eventLabels[i] = "Clone Reserved"; break;
                        case 1453: eventLabels[i] = "Clone Reserved"; break;
                        case 1454: eventLabels[i] = "Clone Reserved"; break;
                        case 1455: eventLabels[i] = "Clone Reserved"; break;
                        case 1456: eventLabels[i] = "Clone Reserved"; break;
                        case 1457: eventLabels[i] = "Clone Reserved"; break;
                        case 1458: eventLabels[i] = "Clone Reserved"; break;
                        case 1459: eventLabels[i] = "Clone Reserved"; break;
                        case 1460: eventLabels[i] = "Clone Reserved"; break;
                        case 1461: eventLabels[i] = "Clone Reserved"; break;
                        case 1462: eventLabels[i] = "Clone Reserved"; break;
                        case 1463: eventLabels[i] = "Clone Reserved"; break;
                        case 1464: eventLabels[i] = "Clone Reserved"; break;
                        case 1465: eventLabels[i] = "Clone Reserved"; break;
                        case 1466: eventLabels[i] = "Clone Reserved"; break;
                        case 1467: eventLabels[i] = "Clone Reserved"; break;
                        case 1468: eventLabels[i] = "Clone Reserved"; break;
                        case 1469: eventLabels[i] = "Clone Reserved"; break;
                        case 1470: eventLabels[i] = "Clone Reserved"; break;
                        case 1471: eventLabels[i] = "Clone Reserved"; break;
                        case 1472: eventLabels[i] = "Clone Reserved"; break;
                        case 1473: eventLabels[i] = "Clone Reserved"; break;
                        case 1474: eventLabels[i] = "Clone Reserved"; break;
                        case 1475: eventLabels[i] = "Clone Reserved"; break;
                        case 1476: eventLabels[i] = "Clone Reserved"; break;
                        case 1477: eventLabels[i] = "Clone Reserved"; break;
                        case 1478: eventLabels[i] = "Clone Reserved"; break;
                        case 1479: eventLabels[i] = "Clone Reserved"; break;
                        case 1480: eventLabels[i] = "Clone Reserved"; break;
                        case 1481: eventLabels[i] = "Clone Reserved"; break;
                        case 1482: eventLabels[i] = "Clone Reserved"; break;
                        case 1483: eventLabels[i] = "Clone Reserved"; break;
                        case 1484: eventLabels[i] = "Clone Reserved"; break;
                        case 1485: eventLabels[i] = "Clone Reserved"; break;
                        case 1486: eventLabels[i] = "Clone Reserved"; break;
                        case 1487: eventLabels[i] = "Clone Reserved"; break;
                        case 1488: eventLabels[i] = "Clone Reserved"; break;
                        case 1489: eventLabels[i] = "Clone Reserved"; break;
                        case 1490: eventLabels[i] = "Clone Reserved"; break;
                        case 1491: eventLabels[i] = "Clone Reserved"; break;
                        case 1492: eventLabels[i] = "Clone Reserved"; break;
                        case 1493: eventLabels[i] = "Clone Reserved"; break;
                        case 1494: eventLabels[i] = "Clone Reserved"; break;
                        case 1495: eventLabels[i] = "Clone Reserved"; break;
                        case 1496: eventLabels[i] = "Clone Reserved"; break;
                        case 1497: eventLabels[i] = "Clone Reserved"; break;
                        case 1498: eventLabels[i] = "Clone Reserved"; break;
                        case 1499: eventLabels[i] = "Clone Reserved"; break;
                        case 1500: eventLabels[i] = "Clone Reserved"; break;
                        case 1501: eventLabels[i] = "Clone Reserved"; break;
                        case 1502: eventLabels[i] = "Clone Reserved"; break;
                        case 1503: eventLabels[i] = "Clone Reserved"; break;
                        case 1504: eventLabels[i] = "Clone Reserved"; break;
                        case 1505: eventLabels[i] = "Clone Reserved"; break;
                        case 1506: eventLabels[i] = "Clone Reserved"; break;
                        case 1507: eventLabels[i] = "Clone Reserved"; break;
                        case 1508: eventLabels[i] = "Clone Reserved"; break;
                        case 1509: eventLabels[i] = "Clone Reserved"; break;
                        case 1510: eventLabels[i] = "Clone Reserved"; break;
                        case 1511: eventLabels[i] = "Clone Reserved"; break;
                        case 1512: eventLabels[i] = "Clone Reserved"; break;
                        case 1513: eventLabels[i] = "Clone Reserved"; break;
                        case 1514: eventLabels[i] = "Clone Reserved"; break;
                        case 1515: eventLabels[i] = "Clone Reserved"; break;
                        case 1516: eventLabels[i] = "Clone Reserved"; break;
                        case 1517: eventLabels[i] = "Clone Reserved"; break;
                        case 1518: eventLabels[i] = "Clone Reserved"; break;
                        case 1519: eventLabels[i] = "Clone Reserved"; break;
                        case 1520: eventLabels[i] = "Clone Reserved"; break;
                        case 1521: eventLabels[i] = "Clone Reserved"; break;
                        case 1522: eventLabels[i] = "Clone Reserved"; break;
                        case 1523: eventLabels[i] = "Clone Reserved"; break;
                        case 1524: eventLabels[i] = "Clone Reserved"; break;
                        case 1525: eventLabels[i] = "Clone Reserved"; break;
                        case 1526: eventLabels[i] = "Clone Reserved"; break;
                        case 1527: eventLabels[i] = "Clone Reserved"; break;
                        case 1528: eventLabels[i] = "Clone Reserved"; break;
                        case 1529: eventLabels[i] = "Clone Reserved"; break;
                        case 1530: eventLabels[i] = "Clone Reserved"; break;
                        case 1531: eventLabels[i] = "Clone Reserved"; break;
                        case 1532: eventLabels[i] = "Clone Reserved"; break;
                        case 1533: eventLabels[i] = "Clone Reserved"; break;
                        case 1534: eventLabels[i] = "Clone Reserved"; break;
                        case 1535: eventLabels[i] = "Clone Reserved"; break;
                        case 1536: eventLabels[i] = "Empty"; break;
                        case 1537: eventLabels[i] = "Spinning Flower Core Logic"; break;
                        case 1538: eventLabels[i] = "Bandits Way Star Chest Camera And Dogs"; break;
                        case 1539: eventLabels[i] = "Empty"; break;
                        case 1540: eventLabels[i] = "Unknown"; break;
                        case 1541: eventLabels[i] = "Unknown"; break;
                        case 1542: eventLabels[i] = "Forest Maze Pipe"; break;
                        case 1543: eventLabels[i] = "Chest Camera Shift"; break;
                        case 1544: eventLabels[i] = "Sand Whirlpool"; break;
                        case 1545: eventLabels[i] = "Sand Whirlpool"; break;
                        case 1546: eventLabels[i] = "Lands End First Two Chests"; break;
                        case 1547: eventLabels[i] = "Lands End Third Chest"; break;
                        case 1548: eventLabels[i] = "Empty"; break;
                        case 1549: eventLabels[i] = "Sky Bridge Donut Lift"; break;
                        case 1550: eventLabels[i] = "Clear Bucket Warp Bit"; break;
                        case 1551: eventLabels[i] = "Bank 1F Return Event"; break;
                        case 1552: eventLabels[i] = "Forest Tree Trunk Area Loader"; break;
                        case 1553: eventLabels[i] = "Forest Tree Trunk Area Loader Contd"; break;
                        case 1554: eventLabels[i] = "Forest First Wiggler Room Loader"; break;
                        case 1555: eventLabels[i] = "Forest First Wiggler Room Loader Contd"; break;
                        case 1556: eventLabels[i] = "Wiggler Jump"; break;
                        case 1557: eventLabels[i] = "Forest Maze Past Trunk Area Room Loader"; break;
                        case 1558: eventLabels[i] = "Lands End Spinny Flower 1"; break;
                        case 1559: eventLabels[i] = "Lands End Spinny Flower 2"; break;
                        case 1560: eventLabels[i] = "Lands End Spinny Flower 3"; break;
                        case 1561: eventLabels[i] = "Lands End Geckit Cannon Room Loader"; break;
                        case 1562: eventLabels[i] = "Lands End Cannon"; break;
                        case 1563: eventLabels[i] = "Lands End Mario Oob"; break;
                        case 1564: eventLabels[i] = "Lands End Cannon Contd"; break;
                        case 1565: eventLabels[i] = "Empty"; break;
                        case 1566: eventLabels[i] = "Lands End Dog Pit"; break;
                        case 1567: eventLabels[i] = "Lands End 2 Loader"; break;
                        case 1568: eventLabels[i] = "Midas River Begin Barrel Section"; break;
                        case 1569: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1570: eventLabels[i] = "Midas River Fish"; break;
                        case 1571: eventLabels[i] = "Midas River Barrel Section Business Logic"; break;
                        case 1572: eventLabels[i] = "Midas River Coin"; break;
                        case 1573: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1574: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1575: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1576: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1577: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1578: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1579: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1580: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1581: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1582: eventLabels[i] = "Lands End Trampoline To Sewer"; break;
                        case 1583: eventLabels[i] = "Lands End Underground Trampoline To Desert"; break;
                        case 1584: eventLabels[i] = "Temple Final Room Loader"; break;
                        case 1585: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1586: eventLabels[i] = "Midas River Barrel Fish Movement"; break;
                        case 1587: eventLabels[i] = "Bandits Way 4 Right Chest"; break;
                        case 1588: eventLabels[i] = "Lands End Grotto Chest"; break;
                        case 1589: eventLabels[i] = "Lands End Grotto Trampoline To Surface"; break;
                        case 1590: eventLabels[i] = "Sewer Pipe To Lands End Subroutine"; break;
                        case 1591: eventLabels[i] = "Lands End Grotto Barrel Kick"; break;
                        case 1592: eventLabels[i] = "Belome Statue"; break;
                        case 1593: eventLabels[i] = "Empty"; break;
                        case 1594: eventLabels[i] = "Empty"; break;
                        case 1595: eventLabels[i] = "Empty"; break;
                        case 1596: eventLabels[i] = "Empty"; break;
                        case 1597: eventLabels[i] = "Empty"; break;
                        case 1598: eventLabels[i] = "Empty"; break;
                        case 1599: eventLabels[i] = "Empty"; break;
                        case 1600: eventLabels[i] = "Empty"; break;
                        case 1601: eventLabels[i] = "Lands End 1St Room Exit To World Map"; break;
                        case 1602: eventLabels[i] = "Exp Star Subroutine Cancel Npc Event Do Not Remove From Level"; break;
                        case 1603: eventLabels[i] = "Exp Star Subroutine Cancel Tile Event"; break;
                        case 1604: eventLabels[i] = "Exp Star Subroutine Cancel Npc Event Remove From Level"; break;
                        case 1605: eventLabels[i] = "Tower Exterior Cancel Exp Star"; break;
                        case 1606: eventLabels[i] = "Empty"; break;
                        case 1607: eventLabels[i] = "Empty"; break;
                        case 1608: eventLabels[i] = "Empty"; break;
                        case 1609: eventLabels[i] = "Empty"; break;
                        case 1610: eventLabels[i] = "Empty"; break;
                        case 1611: eventLabels[i] = "Empty"; break;
                        case 1612: eventLabels[i] = "Summon Geckits In Cannon Room"; break;
                        case 1613: eventLabels[i] = "Empty"; break;
                        case 1614: eventLabels[i] = "Moleville Swap Shop Loader"; break;
                        case 1615: eventLabels[i] = "Moleville Swap Shop Tutorial"; break;
                        case 1616: eventLabels[i] = "Moleville Inn Loader"; break;
                        case 1617: eventLabels[i] = "Moleville Occupied Pa Mole In House"; break;
                        case 1618: eventLabels[i] = "Empty"; break;
                        case 1619: eventLabels[i] = "Occupied Moleville Exterior Npc Trigger Cutscene"; break;
                        case 1620: eventLabels[i] = "Occupied Moleville Exterior Npc At Mtn Base"; break;
                        case 1621: eventLabels[i] = "Occupied Moleville Exterior Npc At Mtn Top"; break;
                        case 1622: eventLabels[i] = "Bucket Warp"; break;
                        case 1623: eventLabels[i] = "Belome Fortune Brick"; break;
                        case 1624: eventLabels[i] = "Moleville Shop"; break;
                        case 1625: eventLabels[i] = "Moleville Tower Unlock Condition Hint"; break;
                        case 1626: eventLabels[i] = "Moleville Carbo Cookie Trader"; break;
                        case 1627: eventLabels[i] = "Dyna House Loader"; break;
                        case 1628: eventLabels[i] = "Moleville Inn Girl"; break;
                        case 1629: eventLabels[i] = "Ma Mole"; break;
                        case 1630: eventLabels[i] = "Moleville Liberated Pa Mole In House"; break;
                        case 1631: eventLabels[i] = "Dyna In House"; break;
                        case 1632: eventLabels[i] = "Moleville Minecart Freeplay Ending Landing"; break;
                        case 1633: eventLabels[i] = "Moleville Inn"; break;
                        case 1634: eventLabels[i] = "Fireworks House Left Girl"; break;
                        case 1635: eventLabels[i] = "Fireworks House Right Girl"; break;
                        case 1636: eventLabels[i] = "Moleville Swap Shop Logic"; break;
                        case 1637: eventLabels[i] = "Moleville Swap Shop Girl"; break;
                        case 1638: eventLabels[i] = "Moleville Liberated Npc At Mtn Base 1"; break;
                        case 1639: eventLabels[i] = "Moleville Liberated Npc At Mtn Base 2"; break;
                        case 1640: eventLabels[i] = "Initiate Minecart Freeplay"; break;
                        case 1641: eventLabels[i] = "Tells You Minecart Pb"; break;
                        case 1642: eventLabels[i] = "Booster Pass Secret Hint Guy"; break;
                        case 1643: eventLabels[i] = "Purtend Store"; break;
                        case 1644: eventLabels[i] = "Moleville Occupied Exterior Loader"; break;
                        case 1645: eventLabels[i] = "Bucket Girl"; break;
                        case 1646: eventLabels[i] = "Moleville Song Hint Girl"; break;
                        case 1647: eventLabels[i] = "Moleville Minecart Freeplay Entrance"; break;
                        case 1648: eventLabels[i] = "Minecart Ending"; break;
                        case 1649: eventLabels[i] = "Moleville Liberated Exterior Loader"; break;
                        case 1650: eventLabels[i] = "Moleville Liberated Exterior Loader Contd"; break;
                        case 1651: eventLabels[i] = "Mario Crash Thru Moleville Roof"; break;
                        case 1652: eventLabels[i] = "Empty"; break;
                        case 1653: eventLabels[i] = "Exit Barrel Count Timer"; break;
                        case 1654: eventLabels[i] = "Empty"; break;
                        case 1655: eventLabels[i] = "Empty"; break;
                        case 1656: eventLabels[i] = "Empty"; break;
                        case 1657: eventLabels[i] = "Empty"; break;
                        case 1658: eventLabels[i] = "Empty"; break;
                        case 1659: eventLabels[i] = "Empty"; break;
                        case 1660: eventLabels[i] = "Empty"; break;
                        case 1661: eventLabels[i] = "Empty"; break;
                        case 1662: eventLabels[i] = "Empty"; break;
                        case 1663: eventLabels[i] = "Empty"; break;
                        case 1664: eventLabels[i] = "Empty"; break;
                        case 1665: eventLabels[i] = "Empty"; break;
                        case 1666: eventLabels[i] = "Empty"; break;
                        case 1667: eventLabels[i] = "Empty"; break;
                        case 1668: eventLabels[i] = "Empty"; break;
                        case 1669: eventLabels[i] = "Nimbus Final Hallway Miniboss Collision"; break;
                        case 1670: eventLabels[i] = "Lands End 2 Summon Invisible Platform"; break;
                        case 1671: eventLabels[i] = "Lands End 1 Invisible Platform"; break;
                        case 1672: eventLabels[i] = "Lands End 2 Summon Invisible Platform"; break;
                        case 1673: eventLabels[i] = "Lands End 2 Invisible Platform Upper"; break;
                        case 1674: eventLabels[i] = "Lands End Enter Grotto"; break;
                        case 1675: eventLabels[i] = "Mario Bumped Off Cannon"; break;
                        case 1676: eventLabels[i] = "Lands End Grotto Room 1 Loader"; break;
                        case 1677: eventLabels[i] = "Temple Pipe To Monstro"; break;
                        case 1678: eventLabels[i] = "Open Lands End Grotto"; break;
                        case 1679: eventLabels[i] = "Lands End Trampoline In Lower Underground Gecko Room"; break;
                        case 1680: eventLabels[i] = "Temple Pipe To Fortune Result Room"; break;
                        case 1681: eventLabels[i] = "Temple Trampoline In Fortune Result Room"; break;
                        case 1682: eventLabels[i] = "Trampoline Shaman"; break;
                        case 1683: eventLabels[i] = "Temple Exit Warp Trampoline"; break;
                        case 1684: eventLabels[i] = "Temple Elevator Lower Exit"; break;
                        case 1685: eventLabels[i] = "Temple Fortune Head 1"; break;
                        case 1686: eventLabels[i] = "Temple Fortune Head 2"; break;
                        case 1687: eventLabels[i] = "Temple Fortune Head 3"; break;
                        case 1688: eventLabels[i] = "Temple Fortune Heads Room Loader"; break;
                        case 1689: eventLabels[i] = "Temple Pipe To Boss Fight"; break;
                        case 1690: eventLabels[i] = "Temple Boss Room Trampoline"; break;
                        case 1691: eventLabels[i] = "Empty"; break;
                        case 1692: eventLabels[i] = "Temple Fortune Scroll"; break;
                        case 1693: eventLabels[i] = "Temple Final Fortune Head"; break;
                        case 1694: eventLabels[i] = "Temple Elevator"; break;
                        case 1695: eventLabels[i] = "Bandits Way Goomba"; break;
                        case 1696: eventLabels[i] = "Bandits Way Chest Platforms 1"; break;
                        case 1697: eventLabels[i] = "Bandits Way Chest Platforms 2"; break;
                        case 1698: eventLabels[i] = "Bandits Way 4 Loader"; break;
                        case 1699: eventLabels[i] = "Bandits Way 4 Loader Background"; break;
                        case 1700: eventLabels[i] = "Bandits Way 2 Left Platform"; break;
                        case 1701: eventLabels[i] = "Bandits Way 2 Right Platform"; break;
                        case 1702: eventLabels[i] = "Bandits Way 2 Loader"; break;
                        case 1703: eventLabels[i] = "Bandits Way 2 Spinny Flower 1"; break;
                        case 1704: eventLabels[i] = "Bandits Way 2 Spinny Flower 2"; break;
                        case 1705: eventLabels[i] = "Bandits Way 2 Dogs Background"; break;
                        case 1706: eventLabels[i] = "Bandits Way Left Chest Star Check"; break;
                        case 1707: eventLabels[i] = "Bandits Way 5 Loader Background"; break;
                        case 1708: eventLabels[i] = "Bandits Way 5 Loader"; break;
                        case 1709: eventLabels[i] = "Bandits Way 5 Loader Background 2"; break;
                        case 1710: eventLabels[i] = "Bandits Way 5 Loader Background Boss Fight"; break;
                        case 1711: eventLabels[i] = "Bandits Way Trampoline"; break;
                        case 1712: eventLabels[i] = "Bandits Way 2 Dog"; break;
                        case 1713: eventLabels[i] = "Bandits Way 3 Loader"; break;
                        case 1714: eventLabels[i] = "Bandits Way 1 Loader"; break;
                        case 1715: eventLabels[i] = "Bandits Way 4 Platform Subroutine"; break;
                        case 1716: eventLabels[i] = "Bandits Way 5 Chase Catch Boss"; break;
                        case 1717: eventLabels[i] = "Bandits Way 4 Manage Dog Collision"; break;
                        case 1718: eventLabels[i] = "Empty"; break;
                        case 1719: eventLabels[i] = "Empty"; break;
                        case 1720: eventLabels[i] = "Empty"; break;
                        case 1721: eventLabels[i] = "Empty"; break;
                        case 1722: eventLabels[i] = "Sky Bridge Room Loader"; break;
                        case 1723: eventLabels[i] = "Empty"; break;
                        case 1724: eventLabels[i] = "Empty"; break;
                        case 1725: eventLabels[i] = "Empty"; break;
                        case 1726: eventLabels[i] = "Empty"; break;
                        case 1727: eventLabels[i] = "Empty"; break;
                        case 1728: eventLabels[i] = "Empty"; break;
                        case 1729: eventLabels[i] = "Empty"; break;
                        case 1730: eventLabels[i] = "Empty"; break;
                        case 1731: eventLabels[i] = "Empty"; break;
                        case 1732: eventLabels[i] = "Sky Bridge Background"; break;
                        case 1733: eventLabels[i] = "Empty"; break;
                        case 1734: eventLabels[i] = "Empty"; break;
                        case 1735: eventLabels[i] = "Empty"; break;
                        case 1736: eventLabels[i] = "Empty"; break;
                        case 1737: eventLabels[i] = "Sky Bridge Donut Lift"; break;
                        case 1738: eventLabels[i] = "Empty"; break;
                        case 1739: eventLabels[i] = "Refocus Camera"; break;
                        case 1740: eventLabels[i] = "Empty"; break;
                        case 1741: eventLabels[i] = "Empty"; break;
                        case 1742: eventLabels[i] = "Empty"; break;
                        case 1743: eventLabels[i] = "Empty"; break;
                        case 1744: eventLabels[i] = "Empty"; break;
                        case 1745: eventLabels[i] = "Whirlpool Shogun"; break;
                        case 1746: eventLabels[i] = "Empty"; break;
                        case 1747: eventLabels[i] = "Empty"; break;
                        case 1748: eventLabels[i] = "Mines Postgame Fight"; break;
                        case 1749: eventLabels[i] = "Ship Postgame Boss"; break;
                        case 1750: eventLabels[i] = "Temple Boss Postgame"; break;
                        case 1751: eventLabels[i] = "Lands End Desert 1 Left Whirlpool"; break;
                        case 1752: eventLabels[i] = "Lands End Desert 1 Right Whirlpool"; break;
                        case 1753: eventLabels[i] = "Lands End Final Whirlpool 1"; break;
                        case 1754: eventLabels[i] = "Lands End Final Whirlpool 2"; break;
                        case 1755: eventLabels[i] = "Lands End Shy Away Whirlpool 1"; break;
                        case 1756: eventLabels[i] = "Lands End Shy Away Whirlpool 2"; break;
                        case 1757: eventLabels[i] = "Lands End Shy Away Whirlpool 3"; break;
                        case 1758: eventLabels[i] = "Lands End Penultimate Whirlpool 1"; break;
                        case 1759: eventLabels[i] = "Lands End Penultimate Whirlpool 2"; break;
                        case 1760: eventLabels[i] = "Lands End Stage 2 Whirlpool 1"; break;
                        case 1761: eventLabels[i] = "Lands End Stage 2 Whirlpool 2"; break;
                        case 1762: eventLabels[i] = "Lands End Stage 2 Whirlpool 3"; break;
                        case 1763: eventLabels[i] = "Lands End Bee Whirlpool 1"; break;
                        case 1764: eventLabels[i] = "Lands End Bee Whirlpool 2"; break;
                        case 1765: eventLabels[i] = "Lands End Bee Whirlpool 3"; break;
                        case 1766: eventLabels[i] = "Temple Elevator Room Loader"; break;
                        case 1767: eventLabels[i] = "Temple Fortune Results Room Gate Opens"; break;
                        case 1768: eventLabels[i] = "Temple Boss"; break;
                        case 1769: eventLabels[i] = "Temple Summon Green Button"; break;
                        case 1770: eventLabels[i] = "Temple Fortune Results Room Loader"; break;
                        case 1771: eventLabels[i] = "Temple Boss Room Loader"; break;
                        case 1772: eventLabels[i] = "Lands End Bullet Bill"; break;
                        case 1773: eventLabels[i] = "Lands End Bullet Bill Background"; break;
                        case 1774: eventLabels[i] = "Empty"; break;
                        case 1775: eventLabels[i] = "Sky Troopa Platform"; break;
                        case 1777: eventLabels[i] = "Lands End Cliff Loader"; break;
                        case 1778: eventLabels[i] = "Temple Generic Pipe Room Loader"; break;
                        case 1779: eventLabels[i] = "Lands End Underground 1 Loader"; break;
                        case 1780: eventLabels[i] = "Lands End Flower Loader"; break;
                        case 1781: eventLabels[i] = "Empty"; break;
                        case 1782: eventLabels[i] = "Lands End Desert 1 Loader"; break;
                        case 1783: eventLabels[i] = "Lands End Final Whirlpool Room Loader"; break;
                        case 1784: eventLabels[i] = "Lands End Desert 1 Left Whirlpool Subroutine"; break;
                        case 1785: eventLabels[i] = "Lands End Final Whirlpool 1 Subroutine"; break;
                        case 1786: eventLabels[i] = "Lands End Shy Away Whirlpool 1 Subroutine"; break;
                        case 1787: eventLabels[i] = "Lands End Desert 1 Right Whirlpool Subroutine"; break;
                        case 1788: eventLabels[i] = "Lands End Underground Dog Wall Room Loader Background"; break;
                        case 1789: eventLabels[i] = "Whirlpool Shogun Subroutine"; break;
                        case 1790: eventLabels[i] = "Lands End Underground Upper Pit Room Loader Background"; break;
                        case 1791: eventLabels[i] = "Lands End Underground Dog Wall Room Loader"; break;
                        case 1792: eventLabels[i] = "Lands End Underground Upper Pit Room Loader"; break;
                        case 1793: eventLabels[i] = "Lands End Purchasable Chest 1 Subroutine"; break;
                        case 1794: eventLabels[i] = "Lands End Buy Chest"; break;
                        case 1795: eventLabels[i] = "Lands End Underground Lower Level Loader"; break;
                        case 1796: eventLabels[i] = "Lands End Desert 1 Trampoline"; break;
                        case 1797: eventLabels[i] = "Lands End Sky Bridge Room Exit To Desert"; break;
                        case 1798: eventLabels[i] = "Lands End Cliff Mouse Hint"; break;
                        case 1799: eventLabels[i] = "Temple Final Fortune Scroll"; break;
                        case 1800: eventLabels[i] = "Temple Mouse Monstro Town Access Hint"; break;
                        case 1801: eventLabels[i] = "Freestanding Flower"; break;
                        case 1802: eventLabels[i] = "Empty"; break;
                        case 1803: eventLabels[i] = "Empty"; break;
                        case 1804: eventLabels[i] = "Empty"; break;
                        case 1805: eventLabels[i] = "Temple 3 Fortune Shaman"; break;
                        case 1806: eventLabels[i] = "Temple Fortune Results Dog Fight"; break;
                        case 1807: eventLabels[i] = "Temple Fortune Results Shy Away Fight"; break;
                        case 1808: eventLabels[i] = "Belome Fortune Prize Chest 1 Subroutine"; break;
                        case 1809: eventLabels[i] = "Lands End Cliff Exit To World Map"; break;
                        case 1810: eventLabels[i] = "Temple Vault Loader"; break;
                        case 1811: eventLabels[i] = "Temple Four Chest Room Loader"; break;
                        case 1812: eventLabels[i] = "Empty"; break;
                        case 1813: eventLabels[i] = "Save Box In Rooms With Exp Stars"; break;
                        case 1814: eventLabels[i] = "Start Troopa Cliff Timer"; break;
                        case 1815: eventLabels[i] = "Troopa Cliff Timer"; break;
                        case 1816: eventLabels[i] = "Troopa Cliff Finish"; break;
                        case 1817: eventLabels[i] = "Troopa Cliff Fall"; break;
                        case 1818: eventLabels[i] = "Lands End Desert Mouse"; break;
                        case 1819: eventLabels[i] = "Shy Away Early Lands End"; break;
                        case 1820: eventLabels[i] = "Empty"; break;
                        case 1821: eventLabels[i] = "Empty"; break;
                        case 1822: eventLabels[i] = "Empty"; break;
                        case 1823: eventLabels[i] = "Lands End Grotto First Room Upper Chest"; break;
                        case 1824: eventLabels[i] = "Keep Set Platform Properties"; break;
                        case 1825: eventLabels[i] = "Keep Rotating Room Loader"; break;
                        case 1826: eventLabels[i] = "Keep Invisible Floor Room Loader"; break;
                        case 1827: eventLabels[i] = "Keep Linear Platform Room Loader"; break;
                        case 1828: eventLabels[i] = "Keep Mario Falls In Lava"; break;
                        case 1829: eventLabels[i] = "Keep Display Remaining Tries"; break;
                        case 1830: eventLabels[i] = "Keep Handle Room Reload After Lava Fall"; break;
                        case 1831: eventLabels[i] = "Keep Invisible Floor Room Background 1"; break;
                        case 1832: eventLabels[i] = "Keep Invisible Floor Room Background 2"; break;
                        case 1833: eventLabels[i] = "Keep Linear Platform Room Background"; break;
                        case 1834: eventLabels[i] = "Keep Cannonball"; break;
                        case 1835: eventLabels[i] = "Keep Cannonball Room Loader"; break;
                        case 1836: eventLabels[i] = "Keep Donkey Room Loader"; break;
                        case 1837: eventLabels[i] = "Unknown"; break;
                        case 1838: eventLabels[i] = "Empty"; break;
                        case 1839: eventLabels[i] = "Unknown"; break;
                        case 1840: eventLabels[i] = "Platform Subroutine"; break;
                        case 1841: eventLabels[i] = "Keep Invisible Floor Chest 1"; break;
                        case 1842: eventLabels[i] = "Keep Invisible Floor Coin 1"; break;
                        case 1843: eventLabels[i] = "Keep Invisible Floor Show Floor"; break;
                        case 1844: eventLabels[i] = "Summon Cloud Boss"; break;
                        case 1845: eventLabels[i] = "Cloud Boss"; break;
                        case 1846: eventLabels[i] = "Safe Donut Lift Jump"; break;
                        case 1847: eventLabels[i] = "Cannonball Room Bomb 1"; break;
                        case 1848: eventLabels[i] = "Cannonball Room Bomb 2"; break;
                        case 1849: eventLabels[i] = "Cannonball Room Bomb 1 Contd"; break;
                        case 1850: eventLabels[i] = "Cannonball Room Bomb 2 Contd"; break;
                        case 1851: eventLabels[i] = "Lands End Grotto Directional Bit"; break;
                        case 1852: eventLabels[i] = "Sky Bridge Admin Shaman"; break;
                        case 1853: eventLabels[i] = "Sky Bridge Ride Shaman"; break;
                        case 1854: eventLabels[i] = "Keep Donkey Room Background"; break;
                        case 1855: eventLabels[i] = "Keep Donkey Room Barrel"; break;
                        case 1856: eventLabels[i] = "Moleville Shop Loader"; break;
                        case 1857: eventLabels[i] = "Moleville Shop Exit To Exterior"; break;
                        case 1858: eventLabels[i] = "Moleville Inn Exit To Exterior"; break;
                        case 1859: eventLabels[i] = "Fireworks House Exit To Exterior"; break;
                        case 1860: eventLabels[i] = "Moleville Swap Shop Exit To Exterior"; break;
                        case 1861: eventLabels[i] = "Keep Donkey Room Donkey"; break;
                        case 1862: eventLabels[i] = "Croco Shop 1"; break;
                        case 1863: eventLabels[i] = "Croco Shop 2"; break;
                        case 1864: eventLabels[i] = "Bowser Door Ultimate Failure Animation"; break;
                        case 1865: eventLabels[i] = "Empty"; break;
                        case 1866: eventLabels[i] = "Keep Invisible Floor Chest 2"; break;
                        case 1867: eventLabels[i] = "Empty"; break;
                        case 1868: eventLabels[i] = "Lands End Flower Room Exit To Sky Bridge"; break;
                        case 1869: eventLabels[i] = "Sky Bridge Loader"; break;
                        case 1870: eventLabels[i] = "Keep Invisible Floor Chest 3"; break;
                        case 1871: eventLabels[i] = "Fireworks House Loader"; break;
                        case 1872: eventLabels[i] = "Fireworks House Buy Item"; break;
                        case 1873: eventLabels[i] = "Midas River Sign After Bucket Warp"; break;
                        case 1874: eventLabels[i] = "Temple Elevator Room Shaman"; break;
                        case 1875: eventLabels[i] = "Keep Rotating Room Platform 1"; break;
                        case 1876: eventLabels[i] = "Keep Rotating Room Platform 2"; break;
                        case 1877: eventLabels[i] = "Keep Rotating Room Loader Contd"; break;
                        case 1878: eventLabels[i] = "Keep Cannonball Room Exit To Previous"; break;
                        case 1879: eventLabels[i] = "Keep Linear Platform Room Exit To Previous"; break;
                        case 1880: eventLabels[i] = "Keep Invisible Floor Chest 4"; break;
                        case 1881: eventLabels[i] = "Keep Invisible Floor Coin 2"; break;
                        case 1882: eventLabels[i] = "Keep Invisible Floor Coin 3"; break;
                        case 1883: eventLabels[i] = "Whirlpool Shogun 1"; break;
                        case 1884: eventLabels[i] = "Whirlpool Shogun 2"; break;
                        case 1885: eventLabels[i] = "Whirlpool Shogun 3"; break;
                        case 1886: eventLabels[i] = "Whirlpool Shogun 4"; break;
                        case 1887: eventLabels[i] = "Whirlpool Shogun 5"; break;
                        case 1888: eventLabels[i] = "Abyss Axem Pit Room Loader"; break;
                        case 1889: eventLabels[i] = "Abyss Side Treasure Rooms Loader"; break;
                        case 1890: eventLabels[i] = "Determine Side Treasure Room To Load"; break;
                        case 1891: eventLabels[i] = "Abyss Big Conveyor Room Loader"; break;
                        case 1892: eventLabels[i] = "Abyss Boss 1 Defeated Temp Room Loader"; break;
                        case 1893: eventLabels[i] = "Abyss Boss 2 Room Loader"; break;
                        case 1894: eventLabels[i] = "Abyss Boss 2"; break;
                        case 1895: eventLabels[i] = "Abyss After Boss 1 Trampoline Backward"; break;
                        case 1896: eventLabels[i] = "Abyss Axem Pit Trampoline"; break;
                        case 1897: eventLabels[i] = "Abyss Upper Machine Yarid Room Loader"; break;
                        case 1898: eventLabels[i] = "Abyss Boss 2 Room Trampoline"; break;
                        case 1899: eventLabels[i] = "Abyss Axem Pit Room Fall"; break;
                        case 1900: eventLabels[i] = "Abyss Big Conveyor Room Fall"; break;
                        case 1901: eventLabels[i] = "Abyss Axem Pit Platforms"; break;
                        case 1902: eventLabels[i] = "Abyss Exit To Side Treasure Rooms"; break;
                        case 1903: eventLabels[i] = "Abyss Side Treasure Rooms Exit"; break;
                        case 1904: eventLabels[i] = "Abyss Machine Yarid Upper"; break;
                        case 1905: eventLabels[i] = "Abyss Exit To Boss 2 Room"; break;
                        case 1906: eventLabels[i] = "Turn Off Mario Shadow"; break;
                        case 1907: eventLabels[i] = "Abyss Machine Yarid Lower"; break;
                        case 1908: eventLabels[i] = "Abyss Machine Axem Red"; break;
                        case 1909: eventLabels[i] = "Abyss Conveyor Belt Jabit Or Bowyer"; break;
                        case 1910: eventLabels[i] = "Abyss Conveyor Belt Shyper"; break;
                        case 1911: eventLabels[i] = "Abyss Machine Mack"; break;
                        case 1912: eventLabels[i] = "Abyss Machine Arrow Hit"; break;
                        case 1913: eventLabels[i] = "Abyss Machine Arrow Animate"; break;
                        case 1914: eventLabels[i] = "Abyss Machine Arrow Reset"; break;
                        case 1915: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1916: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1917: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1918: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1919: eventLabels[i] = "Abyss Big Conveyor Platform"; break;
                        case 1920: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1921: eventLabels[i] = "Abyss Machine Bowyer"; break;
                        case 1922: eventLabels[i] = "Abyss Set Machine Bowyer Spawn Point"; break;
                        case 1923: eventLabels[i] = "Abyss Set Machine Bowyer Spawn Point"; break;
                        case 1924: eventLabels[i] = "World Map Inner Factory"; break;
                        case 1925: eventLabels[i] = "Postgame Tower Fight"; break;
                        case 1926: eventLabels[i] = "Tower Balcony Loader"; break;
                        case 1927: eventLabels[i] = "Tower Balcony Jump Off"; break;
                        case 1928: eventLabels[i] = "Balcony Is Locked"; break;
                        case 1929: eventLabels[i] = "Keep Invisible Floor Coin 4"; break;
                        case 1930: eventLabels[i] = "Mackskip Maybe"; break;
                        case 1931: eventLabels[i] = "Treasure Chest Failure Mimic Fight"; break;
                        case 1932: eventLabels[i] = "Belome Fortune Prize Chest 2"; break;
                        case 1933: eventLabels[i] = "Belome Fortune Prize Chest 3"; break;
                        case 1934: eventLabels[i] = "Belome Fortune Prize Chest 4"; break;
                        case 1935: eventLabels[i] = "Keep Rotating Room Exit To Previous"; break;
                        case 1936: eventLabels[i] = "Keep Rotating Room Chest 1"; break;
                        case 1937: eventLabels[i] = "Keep Rotating Room Chest 2"; break;
                        case 1938: eventLabels[i] = "Keep Rotating Room Chest 3"; break;
                        case 1939: eventLabels[i] = "Keep Rotating Room Chest 4"; break;
                        case 1940: eventLabels[i] = "Keep Rotating Room Chest 5"; break;
                        case 1941: eventLabels[i] = "Keep Rotating Room Chest 6"; break;
                        case 1942: eventLabels[i] = "Keep Vertical Platform Room Exit To Previous"; break;
                        case 1943: eventLabels[i] = "Keep Invisible Floor Room Exit"; break;
                        case 1944: eventLabels[i] = "Keep Chewy Battle Room Exit"; break;
                        case 1945: eventLabels[i] = "Keep Cannonball Room Exit"; break;
                        case 1946: eventLabels[i] = "Keep Donkey Room Exit To Previous"; break;
                        case 1947: eventLabels[i] = "Keep Linear Platform Room Exit"; break;
                        case 1948: eventLabels[i] = "Keep Terra Corra Battle Room Exit"; break;
                        case 1949: eventLabels[i] = "Keep Alley Rat Battle Room Exit"; break;
                        case 1950: eventLabels[i] = "Keep Goomba Battle Room Exit"; break;
                        case 1951: eventLabels[i] = "Keep Barrel Count Room Exit Container"; break;
                        case 1952: eventLabels[i] = "Keep Enter Marathon Puzzle Room"; break;
                        case 1953: eventLabels[i] = "Keep Quiz Room Exit Container"; break;
                        case 1954: eventLabels[i] = "Keep Enter Barrel Count Room"; break;
                        case 1955: eventLabels[i] = "Keep Coin Game Room Exit Container"; break;
                        case 1956: eventLabels[i] = "Keep Enter Button Game Room"; break;
                        case 1957: eventLabels[i] = "Keep Door 5 Container"; break;
                        case 1958: eventLabels[i] = "Keep Enter Vertical Platform Room"; break;
                        case 1959: eventLabels[i] = "Keep Door 4 Container"; break;
                        case 1960: eventLabels[i] = "Keep Enter Invisible Floor Room"; break;
                        case 1961: eventLabels[i] = "Keep Door 6 Container"; break;
                        case 1962: eventLabels[i] = "Keep Enter Terra Cotta Battle Room"; break;
                        case 1963: eventLabels[i] = "Keep Door 3 Container"; break;
                        case 1964: eventLabels[i] = "Keep Enter Goomba Battle Room"; break;
                        case 1965: eventLabels[i] = "Keep Door 1 Container"; break;
                        case 1966: eventLabels[i] = "Keep Enter Quiz Room"; break;
                        case 1967: eventLabels[i] = "Keep Door 2 Container"; break;
                        case 1968: eventLabels[i] = "Keep Enter Coin Game Room"; break;
                        case 1969: eventLabels[i] = "Check If Star Pieces For Factory Boss Collected"; break;
                        case 1970: eventLabels[i] = "Boshi Odds Calculator"; break;
                        case 1971: eventLabels[i] = "Mushroom Boy Grants Rock Candy"; break;
                        case 1972: eventLabels[i] = "Mushroom Boy Odds"; break;
                        case 1973: eventLabels[i] = "Clone Reserved"; break;
                        case 1974: eventLabels[i] = "Clone Reserved"; break;
                        case 1975: eventLabels[i] = "Clone Reserved"; break;
                        case 1976: eventLabels[i] = "Clone Reserved"; break;
                        case 1977: eventLabels[i] = "Clone Reserved"; break;
                        case 1978: eventLabels[i] = "Clone Reserved"; break;
                        case 1979: eventLabels[i] = "Clone Reserved"; break;
                        case 1980: eventLabels[i] = "Clone Reserved"; break;
                        case 1981: eventLabels[i] = "Clone Reserved"; break;
                        case 1982: eventLabels[i] = "Clone Reserved"; break;
                        case 1983: eventLabels[i] = "Clone Reserved"; break;
                        case 1984: eventLabels[i] = "Clone Reserved"; break;
                        case 1985: eventLabels[i] = "Clone Reserved"; break;
                        case 1986: eventLabels[i] = "Clone Reserved"; break;
                        case 1987: eventLabels[i] = "Clone Reserved"; break;
                        case 1988: eventLabels[i] = "Clone Reserved"; break;
                        case 1989: eventLabels[i] = "Clone Reserved"; break;
                        case 1990: eventLabels[i] = "Clone Reserved"; break;
                        case 1991: eventLabels[i] = "Clone Reserved"; break;
                        case 1992: eventLabels[i] = "Clone Reserved"; break;
                        case 1993: eventLabels[i] = "Clone Reserved"; break;
                        case 1994: eventLabels[i] = "Clone Reserved"; break;
                        case 1995: eventLabels[i] = "Clone Reserved"; break;
                        case 1996: eventLabels[i] = "Clone Reserved"; break;
                        case 1997: eventLabels[i] = "Clone Reserved"; break;
                        case 1998: eventLabels[i] = "Clone Reserved"; break;
                        case 1999: eventLabels[i] = "Clone Reserved"; break;
                        case 2000: eventLabels[i] = "Clone Reserved"; break;
                        case 2001: eventLabels[i] = "Clone Reserved"; break;
                        case 2002: eventLabels[i] = "Clone Reserved"; break;
                        case 2003: eventLabels[i] = "Clone Reserved"; break;
                        case 2004: eventLabels[i] = "Clone Reserved"; break;
                        case 2005: eventLabels[i] = "Clone Reserved"; break;
                        case 2006: eventLabels[i] = "Clone Reserved"; break;
                        case 2007: eventLabels[i] = "Clone Reserved"; break;
                        case 2008: eventLabels[i] = "Clone Reserved"; break;
                        case 2009: eventLabels[i] = "Clone Reserved"; break;
                        case 2010: eventLabels[i] = "Clone Reserved"; break;
                        case 2011: eventLabels[i] = "Clone Reserved"; break;
                        case 2012: eventLabels[i] = "Clone Reserved"; break;
                        case 2013: eventLabels[i] = "Clone Reserved"; break;
                        case 2014: eventLabels[i] = "Clone Reserved"; break;
                        case 2015: eventLabels[i] = "Clone Reserved"; break;
                        case 2016: eventLabels[i] = "Clone Reserved"; break;
                        case 2017: eventLabels[i] = "Clone Reserved"; break;
                        case 2018: eventLabels[i] = "Clone Reserved"; break;
                        case 2019: eventLabels[i] = "Clone Reserved"; break;
                        case 2020: eventLabels[i] = "Clone Reserved"; break;
                        case 2021: eventLabels[i] = "Clone Reserved"; break;
                        case 2022: eventLabels[i] = "Clone Reserved"; break;
                        case 2023: eventLabels[i] = "Clone Reserved"; break;
                        case 2024: eventLabels[i] = "Clone Reserved"; break;
                        case 2025: eventLabels[i] = "Clone Reserved"; break;
                        case 2026: eventLabels[i] = "Clone Reserved"; break;
                        case 2027: eventLabels[i] = "Clone Reserved"; break;
                        case 2028: eventLabels[i] = "Clone Reserved"; break;
                        case 2029: eventLabels[i] = "Clone Reserved"; break;
                        case 2030: eventLabels[i] = "Clone Reserved"; break;
                        case 2031: eventLabels[i] = "Clone Reserved"; break;
                        case 2032: eventLabels[i] = "Clone Reserved"; break;
                        case 2033: eventLabels[i] = "Clone Reserved"; break;
                        case 2034: eventLabels[i] = "Clone Reserved"; break;
                        case 2035: eventLabels[i] = "Clone Reserved"; break;
                        case 2036: eventLabels[i] = "Clone Reserved"; break;
                        case 2037: eventLabels[i] = "Clone Reserved"; break;
                        case 2038: eventLabels[i] = "Clone Reserved"; break;
                        case 2039: eventLabels[i] = "Clone Reserved"; break;
                        case 2040: eventLabels[i] = "Clone Reserved"; break;
                        case 2041: eventLabels[i] = "Clone Reserved"; break;
                        case 2042: eventLabels[i] = "Clone Reserved"; break;
                        case 2043: eventLabels[i] = "Clone Reserved"; break;
                        case 2044: eventLabels[i] = "Clone Reserved"; break;
                        case 2045: eventLabels[i] = "Clone Reserved"; break;
                        case 2046: eventLabels[i] = "Clone Reserved"; break;
                        case 2047: eventLabels[i] = "Clone Reserved"; break;
                        case 2048: eventLabels[i] = "Monstro Town Exterior Loader"; break;
                        case 2049: eventLabels[i] = "Monstro Super Jump House Loader"; break;
                        case 2050: eventLabels[i] = "Monstro Thwomp"; break;
                        case 2051: eventLabels[i] = "Monstro Shop Loader"; break;
                        case 2052: eventLabels[i] = "Chapel Postgame Boss"; break;
                        case 2053: eventLabels[i] = "Monstro Goombette Shop"; break;
                        case 2054: eventLabels[i] = "Monstro Main Shop"; break;
                        case 2055: eventLabels[i] = "Monstro Trampoline"; break;
                        case 2056: eventLabels[i] = "Monstro Ledge Item"; break;
                        case 2057: eventLabels[i] = "Monstromama House 1F Loader"; break;
                        case 2058: eventLabels[i] = "Monstro Fan Setting"; break;
                        case 2059: eventLabels[i] = "Monstromama"; break;
                        case 2060: eventLabels[i] = "Monstromama House 2F Loader"; break;
                        case 2061: eventLabels[i] = "Monstro Town Star"; break;
                        case 2062: eventLabels[i] = "Monstro Mimic"; break;
                        case 2063: eventLabels[i] = "Super Jump Prize Grant"; break;
                        case 2064: eventLabels[i] = "Dojo Loader"; break;
                        case 2065: eventLabels[i] = "Dojo Loader First Time Animation"; break;
                        case 2066: eventLabels[i] = "Dojo Boss 1"; break;
                        case 2067: eventLabels[i] = "Dojo Fight 1 Finished"; break;
                        case 2068: eventLabels[i] = "Dojo Boss 2"; break;
                        case 2069: eventLabels[i] = "Monstro Mouse"; break;
                        case 2070: eventLabels[i] = "Monstromama House Exit To Exterior"; break;
                        case 2071: eventLabels[i] = "Empty"; break;
                        case 2072: eventLabels[i] = "Empty"; break;
                        case 2073: eventLabels[i] = "Empty"; break;
                        case 2074: eventLabels[i] = "Enter Monstro Sealed Room"; break;
                        case 2075: eventLabels[i] = "Monstro Sealed Door"; break;
                        case 2076: eventLabels[i] = "Dojo Boss 3"; break;
                        case 2077: eventLabels[i] = "Dojo Boss 4"; break;
                        case 2078: eventLabels[i] = "Monstro Save Box"; break;
                        case 2079: eventLabels[i] = "Monstro Town Exterior Loader From Save Box"; break;
                        case 2080: eventLabels[i] = "Musty Fears Room Loader"; break;
                        case 2081: eventLabels[i] = "Musty Fears Lamp"; break;
                        case 2082: eventLabels[i] = "Nimbus Missable Chest 1"; break;
                        case 2083: eventLabels[i] = "Musty Fears Away Note"; break;
                        case 2084: eventLabels[i] = "Marios Room Invisible Item"; break;
                        case 2085: eventLabels[i] = "Empty"; break;
                        case 2086: eventLabels[i] = "Monstro Piranha"; break;
                        case 2087: eventLabels[i] = "Empty"; break;
                        case 2088: eventLabels[i] = "Empty"; break;
                        case 2089: eventLabels[i] = "Sky Troopas Ad"; break;
                        case 2090: eventLabels[i] = "Monstro Entrance Loader"; break;
                        case 2091: eventLabels[i] = "Empty"; break;
                        case 2092: eventLabels[i] = "Monstro Town Back Exit"; break;
                        case 2093: eventLabels[i] = "Empty"; break;
                        case 2094: eventLabels[i] = "Empty"; break;
                        case 2095: eventLabels[i] = "Empty"; break;
                        case 2096: eventLabels[i] = "Hino Mart Loader"; break;
                        case 2097: eventLabels[i] = "Move Hinopio To Item Shop"; break;
                        case 2098: eventLabels[i] = "Move Hinopio To Inn"; break;
                        case 2099: eventLabels[i] = "Move Hinopio To Armor Shop"; break;
                        case 2100: eventLabels[i] = "Hinopio"; break;
                        case 2101: eventLabels[i] = "Empty"; break;
                        case 2102: eventLabels[i] = "Empty"; break;
                        case 2103: eventLabels[i] = "Empty"; break;
                        case 2104: eventLabels[i] = "Empty"; break;
                        case 2105: eventLabels[i] = "Empty"; break;
                        case 2106: eventLabels[i] = "Empty"; break;
                        case 2107: eventLabels[i] = "Empty"; break;
                        case 2108: eventLabels[i] = "Nimbus Castle Statue Polisher Boss Fight Room Loader"; break;
                        case 2109: eventLabels[i] = "Empty"; break;
                        case 2110: eventLabels[i] = "Empty"; break;
                        case 2111: eventLabels[i] = "Empty"; break;
                        case 2112: eventLabels[i] = "Nimbus Castle Statue Game Room Loader"; break;
                        case 2113: eventLabels[i] = "Empty"; break;
                        case 2114: eventLabels[i] = "Empty"; break;
                        case 2115: eventLabels[i] = "Statue 1 Shake"; break;
                        case 2116: eventLabels[i] = "Statue 2 Shake"; break;
                        case 2117: eventLabels[i] = "Statue 4 Shake"; break;
                        case 2118: eventLabels[i] = "Initiate Statue Polisher Manual Boss Fight"; break;
                        case 2119: eventLabels[i] = "Empty"; break;
                        case 2120: eventLabels[i] = "Empty"; break;
                        case 2121: eventLabels[i] = "Empty"; break;
                        case 2122: eventLabels[i] = "Star Hill Star Piece"; break;
                        case 2123: eventLabels[i] = "Empty"; break;
                        case 2124: eventLabels[i] = "Choose Marrymore Sanctuary State"; break;
                        case 2125: eventLabels[i] = "Empty"; break;
                        case 2126: eventLabels[i] = "Empty"; break;
                        case 2127: eventLabels[i] = "Empty"; break;
                        case 2128: eventLabels[i] = "Empty"; break;
                        case 2129: eventLabels[i] = "Empty"; break;
                        case 2130: eventLabels[i] = "Empty"; break;
                        case 2131: eventLabels[i] = "Empty"; break;
                        case 2132: eventLabels[i] = "Empty"; break;
                        case 2133: eventLabels[i] = "Nimbus Castle Statue Polisher Boss Fight Room Exit To 4Way Path"; break;
                        case 2134: eventLabels[i] = "Empty"; break;
                        case 2135: eventLabels[i] = "Empty"; break;
                        case 2136: eventLabels[i] = "Empty"; break;
                        case 2137: eventLabels[i] = "Empty"; break;
                        case 2138: eventLabels[i] = "Empty"; break;
                        case 2139: eventLabels[i] = "Empty"; break;
                        case 2140: eventLabels[i] = "Empty"; break;
                        case 2141: eventLabels[i] = "Empty"; break;
                        case 2142: eventLabels[i] = "Empty"; break;
                        case 2143: eventLabels[i] = "Empty"; break;
                        case 2144: eventLabels[i] = "Keep 2Nd Room Loader"; break;
                        case 2145: eventLabels[i] = "Keep Donut Bridge Room Loader"; break;
                        case 2146: eventLabels[i] = "Keep Donut Lift"; break;
                        case 2147: eventLabels[i] = "Keep Original Throne Room Loader"; break;
                        case 2148: eventLabels[i] = "Keep Move Goombas In Original Throne Room"; break;
                        case 2149: eventLabels[i] = "Keep Resummon Enemies On Exit"; break;
                        case 2150: eventLabels[i] = "Empty"; break;
                        case 2151: eventLabels[i] = "Empty"; break;
                        case 2152: eventLabels[i] = "Empty"; break;
                        case 2153: eventLabels[i] = "Empty"; break;
                        case 2154: eventLabels[i] = "Empty"; break;
                        case 2155: eventLabels[i] = "Empty"; break;
                        case 2156: eventLabels[i] = "Empty"; break;
                        case 2157: eventLabels[i] = "Empty"; break;
                        case 2158: eventLabels[i] = "Empty"; break;
                        case 2159: eventLabels[i] = "Empty"; break;
                        case 2160: eventLabels[i] = "Keep Terra Cotta Battle Room Loader"; break;
                        case 2161: eventLabels[i] = "Keep Terra Cotta Battle Room Summon 1St Battle"; break;
                        case 2162: eventLabels[i] = "Keep Terra Cotta Battle Room Summon 2Nd Battle"; break;
                        case 2163: eventLabels[i] = "Keep Terra Cotta Battle Room Summon 3Rd Battle"; break;
                        case 2164: eventLabels[i] = "Keep Terra Cotta Battle Room Summon 4Th Battle"; break;
                        case 2165: eventLabels[i] = "Keep Alley Rat Battle Room Loader"; break;
                        case 2166: eventLabels[i] = "Keep Alley Rat Battle Room Summon 1St Battle"; break;
                        case 2167: eventLabels[i] = "Keep Alley Rat Battle Room Summon 2Nd Battle"; break;
                        case 2168: eventLabels[i] = "Keep Alley Rat Battle Room Summon 3Rd Battle"; break;
                        case 2169: eventLabels[i] = "Keep Alley Rat Battle Room Summon 4Th Battle"; break;
                        case 2170: eventLabels[i] = "Keep Bobomb Battle Room Loader"; break;
                        case 2171: eventLabels[i] = "Keep Bobomb Battle Room Summon 1St Battle"; break;
                        case 2172: eventLabels[i] = "Keep Bobomb Battle Room Summon 2Nd Battle"; break;
                        case 2173: eventLabels[i] = "Keep Bobomb Battle Room Summon 3Rd Battle"; break;
                        case 2174: eventLabels[i] = "Keep Bobomb Battle Room Summon 4Th Battle"; break;
                        case 2175: eventLabels[i] = "Keep Goomba Battle Room Loader"; break;
                        case 2176: eventLabels[i] = "Keep Goomba Battle Room Summon 1St Battle"; break;
                        case 2177: eventLabels[i] = "Keep Goomba Battle Room Summon 2Nd Battle"; break;
                        case 2178: eventLabels[i] = "Keep Goomba Battle Room Summon 3Rd Battle"; break;
                        case 2179: eventLabels[i] = "Keep Goomba Battle Room Summon 4Th Battle"; break;
                        case 2180: eventLabels[i] = "Keep Chewy Battle Room Loader"; break;
                        case 2181: eventLabels[i] = "Keep Chewy Battle Room Summon 1St Battle"; break;
                        case 2182: eventLabels[i] = "Keep Chewy Battle Room Summon 2Nd Battle"; break;
                        case 2183: eventLabels[i] = "Keep Chewy Battle Room Summon 3Rd Battle"; break;
                        case 2184: eventLabels[i] = "Keep Chewy Battle Room Summon 4Th Battle"; break;
                        case 2185: eventLabels[i] = "Keep Sparky Battle Room Loader"; break;
                        case 2186: eventLabels[i] = "Keep Sparky Battle Room Summon 1St Battle"; break;
                        case 2187: eventLabels[i] = "Keep Sparky Battle Room Summon 2Nd Battle"; break;
                        case 2188: eventLabels[i] = "Keep Sparky Battle Room Summon 3Rd Battle"; break;
                        case 2189: eventLabels[i] = "Keep Sparky Battle Room Summon 4Th Battle"; break;
                        case 2190: eventLabels[i] = "Battle Door Mimic Boss Animation"; break;
                        case 2191: eventLabels[i] = "Empty"; break;
                        case 2192: eventLabels[i] = "Empty"; break;
                        case 2193: eventLabels[i] = "Empty"; break;
                        case 2194: eventLabels[i] = "Empty"; break;
                        case 2195: eventLabels[i] = "Empty"; break;
                        case 2196: eventLabels[i] = "Empty"; break;
                        case 2197: eventLabels[i] = "Empty"; break;
                        case 2198: eventLabels[i] = "Empty"; break;
                        case 2199: eventLabels[i] = "Empty"; break;
                        case 2200: eventLabels[i] = "Empty"; break;
                        case 2201: eventLabels[i] = "Empty"; break;
                        case 2202: eventLabels[i] = "Empty"; break;
                        case 2203: eventLabels[i] = "Empty"; break;
                        case 2204: eventLabels[i] = "Empty"; break;
                        case 2205: eventLabels[i] = "Empty"; break;
                        case 2206: eventLabels[i] = "Empty"; break;
                        case 2207: eventLabels[i] = "Empty"; break;
                        case 2208: eventLabels[i] = "Keep 1St Boss Room Loader"; break;
                        case 2209: eventLabels[i] = "Keep 1St Boss Fight"; break;
                        case 2210: eventLabels[i] = "Keep 1St Boss Heals You"; break;
                        case 2211: eventLabels[i] = "Empty"; break;
                        case 2212: eventLabels[i] = "Empty"; break;
                        case 2213: eventLabels[i] = "Empty"; break;
                        case 2214: eventLabels[i] = "Empty"; break;
                        case 2215: eventLabels[i] = "Empty"; break;
                        case 2216: eventLabels[i] = "Empty"; break;
                        case 2217: eventLabels[i] = "Empty"; break;
                        case 2218: eventLabels[i] = "Empty"; break;
                        case 2219: eventLabels[i] = "Empty"; break;
                        case 2220: eventLabels[i] = "Empty"; break;
                        case 2221: eventLabels[i] = "Empty"; break;
                        case 2222: eventLabels[i] = "Empty"; break;
                        case 2223: eventLabels[i] = "Empty"; break;
                        case 2224: eventLabels[i] = "Keep Final Boss Room Loader"; break;
                        case 2225: eventLabels[i] = "Keep 2Nd Boss"; break;
                        case 2226: eventLabels[i] = "Keep 3Rd Boss"; break;
                        case 2227: eventLabels[i] = "Empty"; break;
                        case 2228: eventLabels[i] = "Keep Dark Room Loader"; break;
                        case 2229: eventLabels[i] = "Keep Dark Room Summon Goomba 1"; break;
                        case 2230: eventLabels[i] = "Keep Dark Room Summon Goomba 2"; break;
                        case 2231: eventLabels[i] = "Keep Dark Room Summon Goomba 3"; break;
                        case 2232: eventLabels[i] = "Empty"; break;
                        case 2233: eventLabels[i] = "Keep 1St Room Loader"; break;
                        case 2234: eventLabels[i] = "Empty"; break;
                        case 2235: eventLabels[i] = "Empty"; break;
                        case 2236: eventLabels[i] = "Empty"; break;
                        case 2237: eventLabels[i] = "Empty"; break;
                        case 2238: eventLabels[i] = "Empty"; break;
                        case 2239: eventLabels[i] = "Empty"; break;
                        case 2240: eventLabels[i] = "Sets Seaside Inn State"; break;
                        case 2241: eventLabels[i] = "Sets Seaside Elders House State"; break;
                        case 2242: eventLabels[i] = "Sets Seaside Wpn Arm Shop State 1"; break;
                        case 2243: eventLabels[i] = "Sets Seaside Wpn Arm Shop State 2"; break;
                        case 2244: eventLabels[i] = "Sets Seaside Health Store State"; break;
                        case 2245: eventLabels[i] = "Sets Mushroom Boy Shop State"; break;
                        case 2246: eventLabels[i] = "Sets Seaside Accessory Shop State"; break;
                        case 2247: eventLabels[i] = "Dojo Boss 5"; break;
                        case 2248: eventLabels[i] = "Empty"; break;
                        case 2249: eventLabels[i] = "Empty"; break;
                        case 2250: eventLabels[i] = "Empty"; break;
                        case 2251: eventLabels[i] = "Empty"; break;
                        case 2252: eventLabels[i] = "Empty"; break;
                        case 2253: eventLabels[i] = "Empty"; break;
                        case 2254: eventLabels[i] = "Empty"; break;
                        case 2255: eventLabels[i] = "Empty"; break;
                        case 2256: eventLabels[i] = "Empty"; break;
                        case 2257: eventLabels[i] = "Empty"; break;
                        case 2258: eventLabels[i] = "Empty"; break;
                        case 2259: eventLabels[i] = "Empty"; break;
                        case 2260: eventLabels[i] = "Empty"; break;
                        case 2261: eventLabels[i] = "Empty"; break;
                        case 2262: eventLabels[i] = "Empty"; break;
                        case 2263: eventLabels[i] = "Empty"; break;
                        case 2264: eventLabels[i] = "Empty"; break;
                        case 2265: eventLabels[i] = "Empty"; break;
                        case 2266: eventLabels[i] = "Empty"; break;
                        case 2267: eventLabels[i] = "Empty"; break;
                        case 2268: eventLabels[i] = "Empty"; break;
                        case 2269: eventLabels[i] = "Empty"; break;
                        case 2270: eventLabels[i] = "Empty"; break;
                        case 2271: eventLabels[i] = "Empty"; break;
                        case 2272: eventLabels[i] = "Moleville Treasure Shop"; break;
                        case 2273: eventLabels[i] = "Empty"; break;
                        case 2274: eventLabels[i] = "Empty"; break;
                        case 2275: eventLabels[i] = "Empty"; break;
                        case 2276: eventLabels[i] = "Empty"; break;
                        case 2277: eventLabels[i] = "Empty"; break;
                        case 2278: eventLabels[i] = "Balcony Loader After Nimbus Castle"; break;
                        case 2279: eventLabels[i] = "Empty"; break;
                        case 2280: eventLabels[i] = "Empty"; break;
                        case 2281: eventLabels[i] = "Empty"; break;
                        case 2282: eventLabels[i] = "Empty"; break;
                        case 2283: eventLabels[i] = "Empty"; break;
                        case 2284: eventLabels[i] = "Empty"; break;
                        case 2285: eventLabels[i] = "Empty"; break;
                        case 2286: eventLabels[i] = "Empty"; break;
                        case 2287: eventLabels[i] = "Empty"; break;
                        case 2288: eventLabels[i] = "Empty"; break;
                        case 2289: eventLabels[i] = "Empty"; break;
                        case 2290: eventLabels[i] = "Empty"; break;
                        case 2291: eventLabels[i] = "Empty"; break;
                        case 2292: eventLabels[i] = "Ending Credits Toadofsky"; break;
                        case 2293: eventLabels[i] = "Empty"; break;
                        case 2294: eventLabels[i] = "Ending Credits Wedding Loader"; break;
                        case 2295: eventLabels[i] = "Ending Credits Wedding Logic"; break;
                        case 2296: eventLabels[i] = "Empty"; break;
                        case 2297: eventLabels[i] = "Empty"; break;
                        case 2298: eventLabels[i] = "Empty"; break;
                        case 2299: eventLabels[i] = "Empty"; break;
                        case 2300: eventLabels[i] = "Empty"; break;
                        case 2301: eventLabels[i] = "Empty"; break;
                        case 2302: eventLabels[i] = "Empty"; break;
                        case 2303: eventLabels[i] = "Empty"; break;
                        case 2304: eventLabels[i] = "Bank 1F Return Event 2"; break;
                        case 2305: eventLabels[i] = "Slot Chest Template"; break;
                        case 2306: eventLabels[i] = "Empty"; break;
                        case 2307: eventLabels[i] = "Tower Button"; break;
                        case 2308: eventLabels[i] = "Booster Pass 1St Room Loader"; break;
                        case 2309: eventLabels[i] = "Booster Pass Lakitu Tosses Spiny"; break;
                        case 2310: eventLabels[i] = "Empty"; break;
                        case 2311: eventLabels[i] = "Booster Pass Artichoker Encounter 1"; break;
                        case 2312: eventLabels[i] = "Booster Pass Spiny Coin Button"; break;
                        case 2313: eventLabels[i] = "Booster Pass Artichoker Encounter 2"; break;
                        case 2314: eventLabels[i] = "Empty"; break;
                        case 2315: eventLabels[i] = "Tower Parachute Room Loader"; break;
                        case 2316: eventLabels[i] = "Gardener Exterior Loader"; break;
                        case 2317: eventLabels[i] = "Gardener Cloud Loader"; break;
                        case 2318: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2319: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2320: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2321: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2322: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2323: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2324: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2325: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2326: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2327: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2328: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2329: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2330: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2331: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2332: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2333: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2334: eventLabels[i] = "Empty"; break;
                        case 2335: eventLabels[i] = "Tower First Staircase Loader"; break;
                        case 2336: eventLabels[i] = "Tower First Staircase Spookum Direction 1"; break;
                        case 2337: eventLabels[i] = "Tower First Staircase Spookum Direction 2"; break;
                        case 2338: eventLabels[i] = "Tower Button Room Loader"; break;
                        case 2339: eventLabels[i] = "Tower First Staircase Controls Npc Behind Curtain"; break;
                        case 2340: eventLabels[i] = "Tower Seesaw Chest Room Loader"; break;
                        case 2341: eventLabels[i] = "Tower Seesaw Chest"; break;
                        case 2342: eventLabels[i] = "Tower Seesaw Chest Contd"; break;
                        case 2343: eventLabels[i] = "Tower Seesaw Room Set Origin"; break;
                        case 2344: eventLabels[i] = "Tower Thwomp Seesaw Room Loader"; break;
                        case 2345: eventLabels[i] = "Tower Thwomp Seesaw"; break;
                        case 2346: eventLabels[i] = "Tower Thwomp Seesaw Contd"; break;
                        case 2347: eventLabels[i] = "Tower Top Floor Dummy Chest"; break;
                        case 2348: eventLabels[i] = "Tower Bullet Bill Room Loader"; break;
                        case 2349: eventLabels[i] = "Tower Spookum Jumps Out"; break;
                        case 2350: eventLabels[i] = "Climb Gardener Beanstalk"; break;
                        case 2351: eventLabels[i] = "Tower Start Bullet Bills Animation"; break;
                        case 2352: eventLabels[i] = "Tower Start Bullet Bills"; break;
                        case 2353: eventLabels[i] = "Tower Henchman 3"; break;
                        case 2354: eventLabels[i] = "Empty"; break;
                        case 2355: eventLabels[i] = "Empty"; break;
                        case 2356: eventLabels[i] = "Empty"; break;
                        case 2357: eventLabels[i] = "Empty"; break;
                        case 2358: eventLabels[i] = "Tower Thwomp Seesaw Room Loader Contd"; break;
                        case 2359: eventLabels[i] = "Abyss 1St Save Room Loader"; break;
                        case 2360: eventLabels[i] = "Abyss 1St Trampoline Catcher Loader"; break;
                        case 2361: eventLabels[i] = "Abyss Ameboid Button Room Loader"; break;
                        case 2362: eventLabels[i] = "Abyss Four Bolt Room Loader"; break;
                        case 2363: eventLabels[i] = "Abyss 1St Boss Room Loader"; break;
                        case 2364: eventLabels[i] = "Tower Top Floor Chest Room Loader"; break;
                        case 2365: eventLabels[i] = "Empty"; break;
                        case 2366: eventLabels[i] = "Empty"; break;
                        case 2367: eventLabels[i] = "Empty"; break;
                        case 2368: eventLabels[i] = "Empty"; break;
                        case 2369: eventLabels[i] = "Abyss Bolt"; break;
                        case 2370: eventLabels[i] = "Abyss Bolt"; break;
                        case 2371: eventLabels[i] = "Abyss Bolt"; break;
                        case 2372: eventLabels[i] = "Abyss Bolt"; break;
                        case 2373: eventLabels[i] = "Empty"; break;
                        case 2374: eventLabels[i] = "Empty"; break;
                        case 2375: eventLabels[i] = "Empty"; break;
                        case 2376: eventLabels[i] = "Empty"; break;
                        case 2377: eventLabels[i] = "Empty"; break;
                        case 2378: eventLabels[i] = "Tower Parachute Room Hidden Item"; break;
                        case 2379: eventLabels[i] = "Abyss 1St Save Room Background"; break;
                        case 2380: eventLabels[i] = "Abyss Bolt Near Side"; break;
                        case 2381: eventLabels[i] = "Abyss Bolt Far Side"; break;
                        case 2382: eventLabels[i] = "Abyss Bolt Near Side"; break;
                        case 2383: eventLabels[i] = "Abyss Bolt Far Side"; break;
                        case 2384: eventLabels[i] = "Gardeners House Loader"; break;
                        case 2385: eventLabels[i] = "Abyss Four Bolt Room Background"; break;
                        case 2386: eventLabels[i] = "Abyss Four Bolt Room Bolt"; break;
                        case 2387: eventLabels[i] = "Bean Valley Boss Prize Pickup"; break;
                        case 2388: eventLabels[i] = "Abyss Ameboid Button"; break;
                        case 2389: eventLabels[i] = "Empty"; break;
                        case 2390: eventLabels[i] = "Abyss 1St Save Point"; break;
                        case 2391: eventLabels[i] = "Beanstalk From Inside Gardeners House"; break;
                        case 2392: eventLabels[i] = "Gardener"; break;
                        case 2393: eventLabels[i] = "Abyss Exit Trampoline"; break;
                        case 2394: eventLabels[i] = "Empty"; break;
                        case 2395: eventLabels[i] = "Empty"; break;
                        case 2396: eventLabels[i] = "Empty"; break;
                        case 2397: eventLabels[i] = "Empty"; break;
                        case 2398: eventLabels[i] = "Empty"; break;
                        case 2399: eventLabels[i] = "Abyss Room 1 Loader"; break;
                        case 2400: eventLabels[i] = "Empty"; break;
                        case 2401: eventLabels[i] = "Begin 8Bit"; break;
                        case 2402: eventLabels[i] = "8Bit Background"; break;
                        case 2403: eventLabels[i] = "8Bit End East"; break;
                        case 2404: eventLabels[i] = "8Bit End West"; break;
                        case 2405: eventLabels[i] = "Star Hill Final Area Loader"; break;
                        case 2406: eventLabels[i] = "Empty"; break;
                        case 2407: eventLabels[i] = "Star Hill Final Exit"; break;
                        case 2408: eventLabels[i] = "Abyss Bolt Near Side"; break;
                        case 2409: eventLabels[i] = "Abyss Room Before 1St Boss Loader"; break;
                        case 2410: eventLabels[i] = "Forest Tree Generic Underground Trampoline"; break;
                        case 2411: eventLabels[i] = "Forest Underground 2 Exit Trampoline"; break;
                        case 2412: eventLabels[i] = "Forest Secret Trampoline"; break;
                        case 2413: eventLabels[i] = "Forest Underground 2 Entrance Trampoline"; break;
                        case 2414: eventLabels[i] = "Forest Underground 1 Exit Trampoline"; break;
                        case 2415: eventLabels[i] = "Forest Underground 1 Entrance Trampoline"; break;
                        case 2416: eventLabels[i] = "Forest Trampoline Business Logic"; break;
                        case 2417: eventLabels[i] = "Tower Chomp Stairway Loader"; break;
                        case 2418: eventLabels[i] = "Forest Underground 1 Loader"; break;
                        case 2419: eventLabels[i] = "Empty"; break;
                        case 2420: eventLabels[i] = "Empty"; break;
                        case 2421: eventLabels[i] = "Empty"; break;
                        case 2422: eventLabels[i] = "Abyss Room Before 1St Boss Lower Trampoline"; break;
                        case 2423: eventLabels[i] = "Abyss Trampoline To 1St Boss"; break;
                        case 2424: eventLabels[i] = "Forest Arrow Hits You"; break;
                        case 2425: eventLabels[i] = "Forest Maze Secret Loader"; break;
                        case 2426: eventLabels[i] = "Forest Mushroom Pickup"; break;
                        case 2427: eventLabels[i] = "Forest Underground 2 Loader"; break;
                        case 2428: eventLabels[i] = "Empty"; break;
                        case 2429: eventLabels[i] = "Forest Unknown Summoner"; break;
                        case 2430: eventLabels[i] = "Forest Premaze Save Room Loader"; break;
                        case 2431: eventLabels[i] = "Forest Maze Area Loader"; break;
                        case 2432: eventLabels[i] = "Forest Maze Transition"; break;
                        case 2433: eventLabels[i] = "Forest Maze Transition"; break;
                        case 2434: eventLabels[i] = "Forest Maze Transition"; break;
                        case 2435: eventLabels[i] = "Forest Maze Transition"; break;
                        case 2436: eventLabels[i] = "Forest Boss Room Exit To Maze"; break;
                        case 2437: eventLabels[i] = "Forest Boss Room Exit To World Map"; break;
                        case 2438: eventLabels[i] = "Forest Secret Trunk"; break;
                        case 2439: eventLabels[i] = "Forest Secret Area Exit"; break;
                        case 2440: eventLabels[i] = "Forest Final Wiggler Pipe"; break;
                        case 2441: eventLabels[i] = "Forest 1St Trunk"; break;
                        case 2442: eventLabels[i] = "Forest Initiate Maze"; break;
                        case 2443: eventLabels[i] = "Forest Room Before Trunks Area Trunk"; break;
                        case 2444: eventLabels[i] = "Forest Premaze Save Room Trunk"; break;
                        case 2445: eventLabels[i] = "Tower Small Save Room Loader"; break;
                        case 2446: eventLabels[i] = "Forest Boss Henchmen Bounce"; break;
                        case 2447: eventLabels[i] = "Forest Summon Fast Amanita"; break;
                        case 2448: eventLabels[i] = "Forest Boss Fight"; break;
                        case 2449: eventLabels[i] = "Forest Trunk Room Rightmost Trunk"; break;
                        case 2450: eventLabels[i] = "Forest Trunk Room Lowest Trunk"; break;
                        case 2451: eventLabels[i] = "Forest Trunk Room Middle Right Trunk"; break;
                        case 2452: eventLabels[i] = "Forest Trunk Room Middle Left Trunk"; break;
                        case 2453: eventLabels[i] = "Forest Trunk Room Upper Left Trunk"; break;
                        case 2454: eventLabels[i] = "Forest Trunk Room Upper Right Trunk"; break;
                        case 2455: eventLabels[i] = "Forest Trunk Room Wiggler Trunk"; break;
                        case 2456: eventLabels[i] = "Awaken Sleeping Wiggler"; break;
                        case 2457: eventLabels[i] = "Star Hill 1St Room Summon South Sackit"; break;
                        case 2458: eventLabels[i] = "Star Hill 1St Room Summon North Sackit"; break;
                        case 2459: eventLabels[i] = "Star Hill 1St Room Summon Northwest Sackit"; break;
                        case 2460: eventLabels[i] = "Star Hill 1St Room Summon Southeast Sackit"; break;
                        case 2461: eventLabels[i] = "Star Hill 2Nd Room Summon North Sackit"; break;
                        case 2462: eventLabels[i] = "Star Hill 2Nd Room Summon East Sackit"; break;
                        case 2463: eventLabels[i] = "Star Hill 2Nd Room Summon West Sackit"; break;
                        case 2464: eventLabels[i] = "Star Hill 2Nd Room Summon Central Sackit"; break;
                        case 2465: eventLabels[i] = "Empty"; break;
                        case 2466: eventLabels[i] = "Bean Valley 1St Room Loader"; break;
                        case 2467: eventLabels[i] = "Bean Valley Pipe To Dead End"; break;
                        case 2468: eventLabels[i] = "Bean Valley Dead End Pipe"; break;
                        case 2469: eventLabels[i] = "Bean Valley 1St Progression Pipe"; break;
                        case 2470: eventLabels[i] = "Bean Valley 1St Progression Pipe Reverse"; break;
                        case 2471: eventLabels[i] = "Bean Valley 2Nd Progression Pipe"; break;
                        case 2472: eventLabels[i] = "Bean Valley 2Nd Progression Pipe Reverse"; break;
                        case 2473: eventLabels[i] = "Bean Valley Pipe To 1St Chest"; break;
                        case 2474: eventLabels[i] = "Bean Valley 1St Chest Pipe"; break;
                        case 2475: eventLabels[i] = "Star Hill 3Rd Room Summon Sackit"; break;
                        case 2476: eventLabels[i] = "Bean Valley 5 Pipe Area Loader"; break;
                        case 2477: eventLabels[i] = "Bean Valley Piranha Plant Animations"; break;
                        case 2478: eventLabels[i] = "Bean Valley Beanstalk Room Loader"; break;
                        case 2479: eventLabels[i] = "Bean Valley Bottom Left Piranha"; break;
                        case 2480: eventLabels[i] = "Bean Valley Bottom Right Piranha"; break;
                        case 2481: eventLabels[i] = "Bean Valley Rightmost Piranha"; break;
                        case 2482: eventLabels[i] = "Bean Valley Top Piranha"; break;
                        case 2483: eventLabels[i] = "Bean Valley Leftmost Piranha"; break;
                        case 2484: eventLabels[i] = "Bean Valley Top Pipe"; break;
                        case 2485: eventLabels[i] = "Bean Valley Leftmost Pipe"; break;
                        case 2486: eventLabels[i] = "Bean Valley Bottom Left Pipe"; break;
                        case 2487: eventLabels[i] = "Bean Valley Rightmost Pipe"; break;
                        case 2488: eventLabels[i] = "Bean Valley Bottom Right Pipe"; break;
                        case 2489: eventLabels[i] = "Bean Valley Leftmost Pipe Basement Loader"; break;
                        case 2490: eventLabels[i] = "Bean Valley Leftmost Pipe Basement Original Slot Machine"; break;
                        case 2491: eventLabels[i] = "Bean Valley Bottom Left Pipe Basement Original Slot Machine"; break;
                        case 2492: eventLabels[i] = "Bean Valley Bottom Right Pipe Basement Original Slot Machine"; break;
                        case 2493: eventLabels[i] = "Mimic 3"; break;
                        case 2494: eventLabels[i] = "Empty"; break;
                        case 2495: eventLabels[i] = "Empty"; break;
                        case 2496: eventLabels[i] = "Start Game"; break;
                        case 2497: eventLabels[i] = "Additional Gating Logic Start Playing"; break;
                        case 2498: eventLabels[i] = "Empty"; break;
                        case 2499: eventLabels[i] = "Empty"; break;
                        case 2500: eventLabels[i] = "Empty"; break;
                        case 2501: eventLabels[i] = "Empty"; break;
                        case 2502: eventLabels[i] = "Empty"; break;
                        case 2503: eventLabels[i] = "Star Hill 3Rd Room Top Left Flower"; break;
                        case 2504: eventLabels[i] = "Star Hill 3Rd Room Bottom Left Flower"; break;
                        case 2505: eventLabels[i] = "Star Hill 3Rd Room Door Front Flower"; break;
                        case 2506: eventLabels[i] = "Star Hill 3Rd Room Door Back Flower"; break;
                        case 2507: eventLabels[i] = "Star Hill 3Rd Room Top Right Flower"; break;
                        case 2508: eventLabels[i] = "Star Hill 3Rd Room Bottom Right Flower"; break;
                        case 2509: eventLabels[i] = "Star Hill 3Rd Room Open Door"; break;
                        case 2510: eventLabels[i] = "Star Hill 1St Room Top Left Flower"; break;
                        case 2511: eventLabels[i] = "Star Hill 1St Room Bottom Left Flower"; break;
                        case 2512: eventLabels[i] = "Star Hill 1St Room Bottom Middle Flower"; break;
                        case 2513: eventLabels[i] = "Star Hill 1St Room Top Right Flower"; break;
                        case 2514: eventLabels[i] = "Star Hill 1St Room Bottom Right Flower"; break;
                        case 2515: eventLabels[i] = "Star Hill 1St Room Open Door"; break;
                        case 2516: eventLabels[i] = "Star Hill 2Nd Room Top Left Flower"; break;
                        case 2517: eventLabels[i] = "Star Hill 2Nd Room Bottom Left Flower"; break;
                        case 2518: eventLabels[i] = "Star Hill 2Nd Room Central Left Flower"; break;
                        case 2519: eventLabels[i] = "Star Hill 2Nd Room Central Right Flower"; break;
                        case 2520: eventLabels[i] = "Star Hill 2Nd Room Top Right Flower"; break;
                        case 2521: eventLabels[i] = "Star Hill 2Nd Room Bottom Right Flower"; break;
                        case 2522: eventLabels[i] = "Star Hill 2Nd Room Open Door"; break;
                        case 2523: eventLabels[i] = "Star Hill 1St Room Use Door"; break;
                        case 2524: eventLabels[i] = "Star Hill 2Nd Room Loader"; break;
                        case 2525: eventLabels[i] = "Star Hill 2Nd Room Use Door"; break;
                        case 2526: eventLabels[i] = "Star Hill 1St Room Loader"; break;
                        case 2527: eventLabels[i] = "Star Hill 1St Room Wish In Front Of Door"; break;
                        case 2528: eventLabels[i] = "Star Hill 1St Room Wish Southeast Of Door"; break;
                        case 2529: eventLabels[i] = "Star Hill 1St Room Wish Top Left"; break;
                        case 2530: eventLabels[i] = "Star Hill 1St Room Wish Bottom Right"; break;
                        case 2531: eventLabels[i] = "Star Hill 2Nd Room Wish Bottom Right"; break;
                        case 2532: eventLabels[i] = "Star Hill 2Nd Room Wish Bottom Left"; break;
                        case 2533: eventLabels[i] = "Star Hill 2Nd Room Wish In Front Of Door"; break;
                        case 2534: eventLabels[i] = "Star Hill 2Nd Room Wish Top Right"; break;
                        case 2535: eventLabels[i] = "Star Hill 2Nd Room Wish Top Left"; break;
                        case 2536: eventLabels[i] = "Star Hill 3Rd Room Wish Top Left"; break;
                        case 2537: eventLabels[i] = "Star Hill 3Rd Room Wish Behind Door Left"; break;
                        case 2538: eventLabels[i] = "Star Hill 3Rd Room Wish Behind Door Right"; break;
                        case 2539: eventLabels[i] = "Bean Valley Leftmost Pipe Basement Trampoline"; break;
                        case 2540: eventLabels[i] = "Bean Valley Top Pipe Basement Trampoline"; break;
                        case 2541: eventLabels[i] = "Bean Valley Top Pipe Basement Loader"; break;
                        case 2542: eventLabels[i] = "Bean Valley Bottom Left Pipe Basement Trampoline"; break;
                        case 2543: eventLabels[i] = "Bean Valley Bottom Left Pipe Basement Loader"; break;
                        case 2544: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Loader"; break;
                        case 2545: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Trampoline To Five Pipe Room"; break;
                        case 2546: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Trampoline To Lone Chest"; break;
                        case 2547: eventLabels[i] = "Bean Valley Rightmost Pipe"; break;
                        case 2548: eventLabels[i] = "Bean Valley Bottom Right Pipe"; break;
                        case 2549: eventLabels[i] = "Bean Valley Bottom Right Pipe Basement Loader"; break;
                        case 2550: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Geckit Runs At You"; break;
                        case 2551: eventLabels[i] = "Empty"; break;
                        case 2552: eventLabels[i] = "Empty"; break;
                        case 2553: eventLabels[i] = "Empty"; break;
                        case 2554: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Staircase Item"; break;
                        case 2555: eventLabels[i] = "Bean Valley Boss Room Loader"; break;
                        case 2556: eventLabels[i] = "Bean Valley Boss Fight"; break;
                        case 2557: eventLabels[i] = "Bean Valley Waters Boss"; break;
                        case 2558: eventLabels[i] = "Bean Valley Boss Room Pipe"; break;
                        case 2559: eventLabels[i] = "Bean Valley Beanstalk Room Pipe"; break;
                        case 2560: eventLabels[i] = "Empty"; break;
                        case 2561: eventLabels[i] = "Empty"; break;
                        case 2562: eventLabels[i] = "Empty"; break;
                        case 2563: eventLabels[i] = "Reveal Bean Valley Beanstalk"; break;
                        case 2564: eventLabels[i] = "Booster Pass Bush Item"; break;
                        case 2565: eventLabels[i] = "Empty"; break;
                        case 2566: eventLabels[i] = "Empty"; break;
                        case 2567: eventLabels[i] = "Empty"; break;
                        case 2568: eventLabels[i] = "Booster Pass Exit To Secret"; break;
                        case 2569: eventLabels[i] = "Booster Pass Secret Exit"; break;
                        case 2570: eventLabels[i] = "Booster Pass Secret Loader"; break;
                        case 2571: eventLabels[i] = "Booster Pass Secret Background"; break;
                        case 2572: eventLabels[i] = "Booster Pass Exit From Room 1 To Room 2"; break;
                        case 2573: eventLabels[i] = "Empty"; break;
                        case 2574: eventLabels[i] = "Tower First Staircase Chest"; break;
                        case 2575: eventLabels[i] = "Tower 8Bit Music"; break;
                        case 2576: eventLabels[i] = "Tower 8Bit Room Loader"; break;
                        case 2577: eventLabels[i] = "Empty"; break;
                        case 2578: eventLabels[i] = "Booster Tower Small Save Room Back Exit"; break;
                        case 2579: eventLabels[i] = "Empty"; break;
                        case 2580: eventLabels[i] = "Empty"; break;
                        case 2581: eventLabels[i] = "Empty"; break;
                        case 2582: eventLabels[i] = "Empty"; break;
                        case 2583: eventLabels[i] = "Empty"; break;
                        case 2584: eventLabels[i] = "Empty"; break;
                        case 2585: eventLabels[i] = "Empty"; break;
                        case 2586: eventLabels[i] = "Booster Pass Apprentice Fight"; break;
                        case 2587: eventLabels[i] = "Snifit 4"; break;
                        case 2588: eventLabels[i] = "Snifit 5"; break;
                        case 2589: eventLabels[i] = "Snifit 6"; break;
                        case 2590: eventLabels[i] = "Snifit 7"; break;
                        case 2591: eventLabels[i] = "Snifit 8"; break;
                        case 2592: eventLabels[i] = "Abyss Fall Off Before First Boss"; break;
                        case 2593: eventLabels[i] = "Abyss Pre First Boss Bolt"; break;
                        case 2594: eventLabels[i] = "Abyss Pre First Boss Bolt"; break;
                        case 2595: eventLabels[i] = "Abyss Save Room With Chest Loader"; break;
                        case 2596: eventLabels[i] = "Abyss 1St Boss Fight"; break;
                        case 2597: eventLabels[i] = "Abyss Pre First Boss Bolt"; break;
                        case 2598: eventLabels[i] = "Forest Secret Entrance Loader"; break;
                        case 2599: eventLabels[i] = "Empty"; break;
                        case 2600: eventLabels[i] = "Empty"; break;
                        case 2601: eventLabels[i] = "Factory 4Th Room Loader"; break;
                        case 2602: eventLabels[i] = "Bean Valley Exit To World Map"; break;
                        case 2603: eventLabels[i] = "Factory 4Th Boss Fight"; break;
                        case 2604: eventLabels[i] = "Abyss Chest Before 1St Boss"; break;
                        case 2605: eventLabels[i] = "Factory 1St Room Before Fight Loader"; break;
                        case 2606: eventLabels[i] = "Factory 1St Boss"; break;
                        case 2607: eventLabels[i] = "Empty"; break;
                        case 2608: eventLabels[i] = "Factory 1St Room Exit To 2Nd Room"; break;
                        case 2609: eventLabels[i] = "Empty"; break;
                        case 2610: eventLabels[i] = "Empty"; break;
                        case 2611: eventLabels[i] = "Empty"; break;
                        case 2612: eventLabels[i] = "Empty"; break;
                        case 2613: eventLabels[i] = "Empty"; break;
                        case 2614: eventLabels[i] = "Empty"; break;
                        case 2615: eventLabels[i] = "Empty"; break;
                        case 2616: eventLabels[i] = "Factory 4Th Room Green Button"; break;
                        case 2617: eventLabels[i] = "Factory 2Nd Room Loader"; break;
                        case 2618: eventLabels[i] = "Factory 2Nd Boss"; break;
                        case 2619: eventLabels[i] = "Ending Credits Sunset"; break;
                        case 2620: eventLabels[i] = "Factory 3Rd Room Background Npcs Bonk Conveyor"; break;
                        case 2621: eventLabels[i] = "Factory 3Rd Room Loader"; break;
                        case 2622: eventLabels[i] = "Ending Credits Keep"; break;
                        case 2623: eventLabels[i] = "Empty"; break;
                        case 2624: eventLabels[i] = "Empty"; break;
                        case 2625: eventLabels[i] = "Empty"; break;
                        case 2626: eventLabels[i] = "Empty"; break;
                        case 2627: eventLabels[i] = "Factory 3Rd Boss Fight"; break;
                        case 2628: eventLabels[i] = "Ending Credits Sunset Opener"; break;
                        case 2629: eventLabels[i] = "Ending Credits Keep Opener"; break;
                        case 2630: eventLabels[i] = "Blackjack Table"; break;
                        case 2631: eventLabels[i] = "Casino Slot Machine"; break;
                        case 2632: eventLabels[i] = "Blackjack Guy"; break;
                        case 2633: eventLabels[i] = "Casino Interior Loader"; break;
                        case 2634: eventLabels[i] = "Casino Slot Machine"; break;
                        case 2635: eventLabels[i] = "Casino Doorway Loader"; break;
                        case 2636: eventLabels[i] = "Casino Guard"; break;
                        case 2637: eventLabels[i] = "Casino Grate Guy"; break;
                        case 2638: eventLabels[i] = "Empty"; break;
                        case 2639: eventLabels[i] = "Empty"; break;
                        case 2640: eventLabels[i] = "Booster Pass Right Chest"; break;
                        case 2641: eventLabels[i] = "Factory 1St Room Loader After Fight"; break;
                        case 2642: eventLabels[i] = "Empty"; break;
                        case 2643: eventLabels[i] = "Toad Shop"; break;
                        case 2644: eventLabels[i] = "Empty"; break;
                        case 2645: eventLabels[i] = "Casino Subroutine"; break;
                        case 2646: eventLabels[i] = "Casino Grate Guy Await Button"; break;
                        case 2647: eventLabels[i] = "Empty"; break;
                        case 2648: eventLabels[i] = "Casino Exterior Loader"; break;
                        case 2649: eventLabels[i] = "Casino Grate Guy Random Prize Granter"; break;
                        case 2650: eventLabels[i] = "Casino Grate Guy Check If Sidequest Completed"; break;
                        case 2651: eventLabels[i] = "Bucket Warp Check Granter"; break;
                        case 2652: eventLabels[i] = "Seaside Exit To Beach"; break;
                        case 2653: eventLabels[i] = "Empty"; break;
                        case 2654: eventLabels[i] = "Empty"; break;
                        case 2655: eventLabels[i] = "Empty"; break;
                        case 2656: eventLabels[i] = "Empty"; break;
                        case 2657: eventLabels[i] = "Empty"; break;
                        case 2658: eventLabels[i] = "Empty"; break;
                        case 2659: eventLabels[i] = "Empty"; break;
                        case 2660: eventLabels[i] = "Empty"; break;
                        case 2661: eventLabels[i] = "Empty"; break;
                        case 2662: eventLabels[i] = "Empty"; break;
                        case 2663: eventLabels[i] = "Empty"; break;
                        case 2664: eventLabels[i] = "Empty"; break;
                        case 2665: eventLabels[i] = "Empty"; break;
                        case 2666: eventLabels[i] = "Empty"; break;
                        case 2667: eventLabels[i] = "Empty"; break;
                        case 2668: eventLabels[i] = "Knife Guy Second Grant"; break;
                        case 2669: eventLabels[i] = "Empty"; break;
                        case 2670: eventLabels[i] = "Tower Knife Guy Consolation Prize"; break;
                        case 2671: eventLabels[i] = "Tower Knife Guy Check If Sidequest Completed"; break;
                        case 2672: eventLabels[i] = "Tower Knife Guy Minigame Business Logic"; break;
                        case 2673: eventLabels[i] = "Tower Knife Guy Minigame Business Logic Subroutine"; break;
                        case 2674: eventLabels[i] = "Tower Knife Guy Minigame Business Logic Subroutine"; break;
                        case 2675: eventLabels[i] = "Clone Reserved"; break;
                        case 2676: eventLabels[i] = "Clone Reserved"; break;
                        case 2677: eventLabels[i] = "Clone Reserved"; break;
                        case 2678: eventLabels[i] = "Clone Reserved"; break;
                        case 2679: eventLabels[i] = "Clone Reserved"; break;
                        case 2680: eventLabels[i] = "Clone Reserved"; break;
                        case 2681: eventLabels[i] = "Clone Reserved"; break;
                        case 2682: eventLabels[i] = "Clone Reserved"; break;
                        case 2683: eventLabels[i] = "Clone Reserved"; break;
                        case 2684: eventLabels[i] = "Clone Reserved"; break;
                        case 2685: eventLabels[i] = "Clone Reserved"; break;
                        case 2686: eventLabels[i] = "Clone Reserved"; break;
                        case 2687: eventLabels[i] = "Clone Reserved"; break;
                        case 2688: eventLabels[i] = "Clone Reserved"; break;
                        case 2689: eventLabels[i] = "Clone Reserved"; break;
                        case 2690: eventLabels[i] = "Clone Reserved"; break;
                        case 2691: eventLabels[i] = "Clone Reserved"; break;
                        case 2692: eventLabels[i] = "Clone Reserved"; break;
                        case 2693: eventLabels[i] = "Clone Reserved"; break;
                        case 2694: eventLabels[i] = "Clone Reserved"; break;
                        case 2695: eventLabels[i] = "Clone Reserved"; break;
                        case 2696: eventLabels[i] = "Clone Reserved"; break;
                        case 2697: eventLabels[i] = "Clone Reserved"; break;
                        case 2698: eventLabels[i] = "Clone Reserved"; break;
                        case 2699: eventLabels[i] = "Clone Reserved"; break;
                        case 2700: eventLabels[i] = "Clone Reserved"; break;
                        case 2701: eventLabels[i] = "Clone Reserved"; break;
                        case 2702: eventLabels[i] = "Clone Reserved"; break;
                        case 2703: eventLabels[i] = "Clone Reserved"; break;
                        case 2704: eventLabels[i] = "Clone Reserved"; break;
                        case 2705: eventLabels[i] = "Clone Reserved"; break;
                        case 2706: eventLabels[i] = "Clone Reserved"; break;
                        case 2707: eventLabels[i] = "Clone Reserved"; break;
                        case 2708: eventLabels[i] = "Clone Reserved"; break;
                        case 2709: eventLabels[i] = "Clone Reserved"; break;
                        case 2710: eventLabels[i] = "Clone Reserved"; break;
                        case 2711: eventLabels[i] = "Clone Reserved"; break;
                        case 2712: eventLabels[i] = "Clone Reserved"; break;
                        case 2713: eventLabels[i] = "Clone Reserved"; break;
                        case 2714: eventLabels[i] = "Clone Reserved"; break;
                        case 2715: eventLabels[i] = "Clone Reserved"; break;
                        case 2716: eventLabels[i] = "Clone Reserved"; break;
                        case 2717: eventLabels[i] = "Clone Reserved"; break;
                        case 2718: eventLabels[i] = "Clone Reserved"; break;
                        case 2719: eventLabels[i] = "Clone Reserved"; break;
                        case 2720: eventLabels[i] = "Clone Reserved"; break;
                        case 2721: eventLabels[i] = "Clone Reserved"; break;
                        case 2722: eventLabels[i] = "Clone Reserved"; break;
                        case 2723: eventLabels[i] = "Clone Reserved"; break;
                        case 2724: eventLabels[i] = "Clone Reserved"; break;
                        case 2725: eventLabels[i] = "Clone Reserved"; break;
                        case 2726: eventLabels[i] = "Clone Reserved"; break;
                        case 2727: eventLabels[i] = "Clone Reserved"; break;
                        case 2728: eventLabels[i] = "Clone Reserved"; break;
                        case 2729: eventLabels[i] = "Clone Reserved"; break;
                        case 2730: eventLabels[i] = "Clone Reserved"; break;
                        case 2731: eventLabels[i] = "Clone Reserved"; break;
                        case 2732: eventLabels[i] = "Clone Reserved"; break;
                        case 2733: eventLabels[i] = "Clone Reserved"; break;
                        case 2734: eventLabels[i] = "Clone Reserved"; break;
                        case 2735: eventLabels[i] = "Clone Reserved"; break;
                        case 2736: eventLabels[i] = "Clone Reserved"; break;
                        case 2737: eventLabels[i] = "Clone Reserved"; break;
                        case 2738: eventLabels[i] = "Clone Reserved"; break;
                        case 2739: eventLabels[i] = "Clone Reserved"; break;
                        case 2740: eventLabels[i] = "Clone Reserved"; break;
                        case 2741: eventLabels[i] = "Clone Reserved"; break;
                        case 2742: eventLabels[i] = "Clone Reserved"; break;
                        case 2743: eventLabels[i] = "Clone Reserved"; break;
                        case 2744: eventLabels[i] = "Clone Reserved"; break;
                        case 2745: eventLabels[i] = "Clone Reserved"; break;
                        case 2746: eventLabels[i] = "Clone Reserved"; break;
                        case 2747: eventLabels[i] = "Clone Reserved"; break;
                        case 2748: eventLabels[i] = "Clone Reserved"; break;
                        case 2749: eventLabels[i] = "Clone Reserved"; break;
                        case 2750: eventLabels[i] = "Clone Reserved"; break;
                        case 2751: eventLabels[i] = "Clone Reserved"; break;
                        case 2752: eventLabels[i] = "Clone Reserved"; break;
                        case 2753: eventLabels[i] = "Clone Reserved"; break;
                        case 2754: eventLabels[i] = "Clone Reserved"; break;
                        case 2755: eventLabels[i] = "Clone Reserved"; break;
                        case 2756: eventLabels[i] = "Clone Reserved"; break;
                        case 2757: eventLabels[i] = "Clone Reserved"; break;
                        case 2758: eventLabels[i] = "Clone Reserved"; break;
                        case 2759: eventLabels[i] = "Clone Reserved"; break;
                        case 2760: eventLabels[i] = "Clone Reserved"; break;
                        case 2761: eventLabels[i] = "Clone Reserved"; break;
                        case 2762: eventLabels[i] = "Clone Reserved"; break;
                        case 2763: eventLabels[i] = "Clone Reserved"; break;
                        case 2764: eventLabels[i] = "Clone Reserved"; break;
                        case 2765: eventLabels[i] = "Clone Reserved"; break;
                        case 2766: eventLabels[i] = "Clone Reserved"; break;
                        case 2767: eventLabels[i] = "Clone Reserved"; break;
                        case 2768: eventLabels[i] = "Clone Reserved"; break;
                        case 2769: eventLabels[i] = "Clone Reserved"; break;
                        case 2770: eventLabels[i] = "Clone Reserved"; break;
                        case 2771: eventLabels[i] = "Clone Reserved"; break;
                        case 2772: eventLabels[i] = "Clone Reserved"; break;
                        case 2773: eventLabels[i] = "Clone Reserved"; break;
                        case 2774: eventLabels[i] = "Clone Reserved"; break;
                        case 2775: eventLabels[i] = "Clone Reserved"; break;
                        case 2776: eventLabels[i] = "Clone Reserved"; break;
                        case 2777: eventLabels[i] = "Clone Reserved"; break;
                        case 2778: eventLabels[i] = "Clone Reserved"; break;
                        case 2779: eventLabels[i] = "Clone Reserved"; break;
                        case 2780: eventLabels[i] = "Clone Reserved"; break;
                        case 2781: eventLabels[i] = "Clone Reserved"; break;
                        case 2782: eventLabels[i] = "Clone Reserved"; break;
                        case 2783: eventLabels[i] = "Clone Reserved"; break;
                        case 2784: eventLabels[i] = "Clone Reserved"; break;
                        case 2785: eventLabels[i] = "Clone Reserved"; break;
                        case 2786: eventLabels[i] = "Clone Reserved"; break;
                        case 2787: eventLabels[i] = "Clone Reserved"; break;
                        case 2788: eventLabels[i] = "Clone Reserved"; break;
                        case 2789: eventLabels[i] = "Clone Reserved"; break;
                        case 2790: eventLabels[i] = "Clone Reserved"; break;
                        case 2791: eventLabels[i] = "Clone Reserved"; break;
                        case 2792: eventLabels[i] = "Clone Reserved"; break;
                        case 2793: eventLabels[i] = "Star Hill Entrance Loader"; break;
                        case 2794: eventLabels[i] = "Star Hill Marrymore Exit Sign"; break;
                        case 2795: eventLabels[i] = "Star Hill Progress Sign"; break;
                        case 2796: eventLabels[i] = "Star Hill Marrymore Exit Flower"; break;
                        case 2797: eventLabels[i] = "Star Hill Progress Flower"; break;
                        case 2798: eventLabels[i] = "Star Hill Exit To World Map"; break;
                        case 2799: eventLabels[i] = "Star Hill Entrance To 1St Room"; break;
                        case 2800: eventLabels[i] = "Casino Exit To World Map"; break;
                        case 2801: eventLabels[i] = "Bean Valley Exit To Casino"; break;
                        case 2802: eventLabels[i] = "Bean Valley Top Pipe Basement Loader"; break;
                        case 2803: eventLabels[i] = "Bean Valley North Pipe Directional Bit"; break;
                        case 2804: eventLabels[i] = "Bean Valley North Pipe Directional Bit"; break;
                        case 2805: eventLabels[i] = "Tower Apprentice Room Loader"; break;
                        case 2806: eventLabels[i] = "Forest Maze Room Before Trunk Room Loader"; break;
                        case 2807: eventLabels[i] = "Mushroom Way 3 Exit To World Map"; break;
                        case 2808: eventLabels[i] = "Mushroom Way Boss Fight"; break;
                        case 2809: eventLabels[i] = "Mushroom Way Boss Threatens You"; break;
                        case 2810: eventLabels[i] = "Empty"; break;
                        case 2811: eventLabels[i] = "Mushroom Way 3 Lower Quick Spiny"; break;
                        case 2812: eventLabels[i] = "Mushroom Way 3 Upper Quick Spiny"; break;
                        case 2813: eventLabels[i] = "Mushroom Way 3 Summon Spinys"; break;
                        case 2814: eventLabels[i] = "Mushroom Way 3 Loader"; break;
                        case 2815: eventLabels[i] = "Empty"; break;
                        case 2816: eventLabels[i] = "Async No Animation Frog Coin"; break;
                        case 2817: eventLabels[i] = "Async No Animation Flower"; break;
                        case 2818: eventLabels[i] = "Async No Animation 10 Coin"; break;
                        case 2819: eventLabels[i] = "Async No Animation 1 Coin"; break;
                        case 2820: eventLabels[i] = "Async No Animation Item"; break;
                        case 2821: eventLabels[i] = "Async No Animation Star Piece"; break;
                        case 2822: eventLabels[i] = "Async No Animation Mushroom"; break;
                        case 2823: eventLabels[i] = "Clone Reserved"; break;
                        case 2824: eventLabels[i] = "Clone Reserved"; break;
                        case 2825: eventLabels[i] = "Clone Reserved"; break;
                        case 2826: eventLabels[i] = "Clone Reserved"; break;
                        case 2827: eventLabels[i] = "Clone Reserved"; break;
                        case 2828: eventLabels[i] = "Clone Reserved"; break;
                        case 2829: eventLabels[i] = "Clone Reserved"; break;
                        case 2830: eventLabels[i] = "Clone Reserved"; break;
                        case 2831: eventLabels[i] = "Clone Reserved"; break;
                        case 2832: eventLabels[i] = "Clone Reserved"; break;
                        case 2833: eventLabels[i] = "Clone Reserved"; break;
                        case 2834: eventLabels[i] = "Clone Reserved"; break;
                        case 2835: eventLabels[i] = "Clone Reserved"; break;
                        case 2836: eventLabels[i] = "Clone Reserved"; break;
                        case 2837: eventLabels[i] = "Clone Reserved"; break;
                        case 2838: eventLabels[i] = "Clone Reserved"; break;
                        case 2839: eventLabels[i] = "Clone Reserved"; break;
                        case 2840: eventLabels[i] = "Clone Reserved"; break;
                        case 2841: eventLabels[i] = "Clone Reserved"; break;
                        case 2842: eventLabels[i] = "Clone Reserved"; break;
                        case 2843: eventLabels[i] = "Clone Reserved"; break;
                        case 2844: eventLabels[i] = "Clone Reserved"; break;
                        case 2845: eventLabels[i] = "Clone Reserved"; break;
                        case 2846: eventLabels[i] = "Clone Reserved"; break;
                        case 2847: eventLabels[i] = "Clone Reserved"; break;
                        case 2848: eventLabels[i] = "Clone Reserved"; break;
                        case 2849: eventLabels[i] = "Clone Reserved"; break;
                        case 2850: eventLabels[i] = "Clone Reserved"; break;
                        case 2851: eventLabels[i] = "Clone Reserved"; break;
                        case 2852: eventLabels[i] = "Clone Reserved"; break;
                        case 2853: eventLabels[i] = "Clone Reserved"; break;
                        case 2854: eventLabels[i] = "Clone Reserved"; break;
                        case 2855: eventLabels[i] = "Clone Reserved"; break;
                        case 2856: eventLabels[i] = "Clone Reserved"; break;
                        case 2857: eventLabels[i] = "Clone Reserved"; break;
                        case 2858: eventLabels[i] = "Clone Reserved"; break;
                        case 2859: eventLabels[i] = "Clone Reserved"; break;
                        case 2860: eventLabels[i] = "Clone Reserved"; break;
                        case 2861: eventLabels[i] = "Clone Reserved"; break;
                        case 2862: eventLabels[i] = "Clone Reserved"; break;
                        case 2863: eventLabels[i] = "Clone Reserved"; break;
                        case 2864: eventLabels[i] = "Clone Reserved"; break;
                        case 2865: eventLabels[i] = "Clone Reserved"; break;
                        case 2866: eventLabels[i] = "Clone Reserved"; break;
                        case 2867: eventLabels[i] = "Clone Reserved"; break;
                        case 2868: eventLabels[i] = "Clone Reserved"; break;
                        case 2869: eventLabels[i] = "Clone Reserved"; break;
                        case 2870: eventLabels[i] = "Clone Reserved"; break;
                        case 2871: eventLabels[i] = "Clone Reserved"; break;
                        case 2872: eventLabels[i] = "Clone Reserved"; break;
                        case 2873: eventLabels[i] = "Clone Reserved"; break;
                        case 2874: eventLabels[i] = "Clone Reserved"; break;
                        case 2875: eventLabels[i] = "Clone Reserved"; break;
                        case 2876: eventLabels[i] = "Clone Reserved"; break;
                        case 2877: eventLabels[i] = "Clone Reserved"; break;
                        case 2878: eventLabels[i] = "Clone Reserved"; break;
                        case 2879: eventLabels[i] = "Clone Reserved"; break;
                        case 2880: eventLabels[i] = "Clone Reserved"; break;
                        case 2881: eventLabels[i] = "Clone Reserved"; break;
                        case 2882: eventLabels[i] = "Clone Reserved"; break;
                        case 2883: eventLabels[i] = "Clone Reserved"; break;
                        case 2884: eventLabels[i] = "Clone Reserved"; break;
                        case 2885: eventLabels[i] = "Clone Reserved"; break;
                        case 2886: eventLabels[i] = "Clone Reserved"; break;
                        case 2887: eventLabels[i] = "Clone Reserved"; break;
                        case 2888: eventLabels[i] = "Clone Reserved"; break;
                        case 2889: eventLabels[i] = "Clone Reserved"; break;
                        case 2890: eventLabels[i] = "Clone Reserved"; break;
                        case 2891: eventLabels[i] = "Clone Reserved"; break;
                        case 2892: eventLabels[i] = "Clone Reserved"; break;
                        case 2893: eventLabels[i] = "Clone Reserved"; break;
                        case 2894: eventLabels[i] = "Clone Reserved"; break;
                        case 2895: eventLabels[i] = "Clone Reserved"; break;
                        case 2896: eventLabels[i] = "Clone Reserved"; break;
                        case 2897: eventLabels[i] = "Clone Reserved"; break;
                        case 2898: eventLabels[i] = "Clone Reserved"; break;
                        case 2899: eventLabels[i] = "Clone Reserved"; break;
                        case 2900: eventLabels[i] = "Clone Reserved"; break;
                        case 2901: eventLabels[i] = "Clone Reserved"; break;
                        case 2902: eventLabels[i] = "Clone Reserved"; break;
                        case 2903: eventLabels[i] = "Clone Reserved"; break;
                        case 2904: eventLabels[i] = "Clone Reserved"; break;
                        case 2905: eventLabels[i] = "Clone Reserved"; break;
                        case 2906: eventLabels[i] = "Clone Reserved"; break;
                        case 2907: eventLabels[i] = "Clone Reserved"; break;
                        case 2908: eventLabels[i] = "Clone Reserved"; break;
                        case 2909: eventLabels[i] = "Clone Reserved"; break;
                        case 2910: eventLabels[i] = "Clone Reserved"; break;
                        case 2911: eventLabels[i] = "Clone Reserved"; break;
                        case 2912: eventLabels[i] = "Clone Reserved"; break;
                        case 2913: eventLabels[i] = "Clone Reserved"; break;
                        case 2914: eventLabels[i] = "Clone Reserved"; break;
                        case 2915: eventLabels[i] = "Clone Reserved"; break;
                        case 2916: eventLabels[i] = "Clone Reserved"; break;
                        case 2917: eventLabels[i] = "Clone Reserved"; break;
                        case 2918: eventLabels[i] = "Clone Reserved"; break;
                        case 2919: eventLabels[i] = "Clone Reserved"; break;
                        case 2920: eventLabels[i] = "Clone Reserved"; break;
                        case 2921: eventLabels[i] = "Clone Reserved"; break;
                        case 2922: eventLabels[i] = "Clone Reserved"; break;
                        case 2923: eventLabels[i] = "Clone Reserved"; break;
                        case 2924: eventLabels[i] = "Clone Reserved"; break;
                        case 2925: eventLabels[i] = "Clone Reserved"; break;
                        case 2926: eventLabels[i] = "Clone Reserved"; break;
                        case 2927: eventLabels[i] = "Clone Reserved"; break;
                        case 2928: eventLabels[i] = "Clone Reserved"; break;
                        case 2929: eventLabels[i] = "Clone Reserved"; break;
                        case 2930: eventLabels[i] = "Clone Reserved"; break;
                        case 2931: eventLabels[i] = "Clone Reserved"; break;
                        case 2932: eventLabels[i] = "Clone Reserved"; break;
                        case 2933: eventLabels[i] = "Clone Reserved"; break;
                        case 2934: eventLabels[i] = "Clone Reserved"; break;
                        case 2935: eventLabels[i] = "Clone Reserved"; break;
                        case 2936: eventLabels[i] = "Clone Reserved"; break;
                        case 2937: eventLabels[i] = "Clone Reserved"; break;
                        case 2938: eventLabels[i] = "Clone Reserved"; break;
                        case 2939: eventLabels[i] = "Clone Reserved"; break;
                        case 2940: eventLabels[i] = "Clone Reserved"; break;
                        case 2941: eventLabels[i] = "Clone Reserved"; break;
                        case 2942: eventLabels[i] = "Clone Reserved"; break;
                        case 2943: eventLabels[i] = "Clone Reserved"; break;
                        case 2944: eventLabels[i] = "Clone Reserved"; break;
                        case 2945: eventLabels[i] = "Clone Reserved"; break;
                        case 2946: eventLabels[i] = "Clone Reserved"; break;
                        case 2947: eventLabels[i] = "Clone Reserved"; break;
                        case 2948: eventLabels[i] = "Clone Reserved"; break;
                        case 2949: eventLabels[i] = "Clone Reserved"; break;
                        case 2950: eventLabels[i] = "Clone Reserved"; break;
                        case 2951: eventLabels[i] = "Clone Reserved"; break;
                        case 2952: eventLabels[i] = "Clone Reserved"; break;
                        case 2953: eventLabels[i] = "Clone Reserved"; break;
                        case 2954: eventLabels[i] = "Clone Reserved"; break;
                        case 2955: eventLabels[i] = "Clone Reserved"; break;
                        case 2956: eventLabels[i] = "Clone Reserved"; break;
                        case 2957: eventLabels[i] = "Clone Reserved"; break;
                        case 2958: eventLabels[i] = "Clone Reserved"; break;
                        case 2959: eventLabels[i] = "Clone Reserved"; break;
                        case 2960: eventLabels[i] = "Clone Reserved"; break;
                        case 2961: eventLabels[i] = "Clone Reserved"; break;
                        case 2962: eventLabels[i] = "Clone Reserved"; break;
                        case 2963: eventLabels[i] = "Clone Reserved"; break;
                        case 2964: eventLabels[i] = "Clone Reserved"; break;
                        case 2965: eventLabels[i] = "Clone Reserved"; break;
                        case 2966: eventLabels[i] = "Clone Reserved"; break;
                        case 2967: eventLabels[i] = "Clone Reserved"; break;
                        case 2968: eventLabels[i] = "Clone Reserved"; break;
                        case 2969: eventLabels[i] = "Clone Reserved"; break;
                        case 2970: eventLabels[i] = "Clone Reserved"; break;
                        case 2971: eventLabels[i] = "Clone Reserved"; break;
                        case 2972: eventLabels[i] = "Clone Reserved"; break;
                        case 2973: eventLabels[i] = "Clone Reserved"; break;
                        case 2974: eventLabels[i] = "Clone Reserved"; break;
                        case 2975: eventLabels[i] = "Clone Reserved"; break;
                        case 2976: eventLabels[i] = "Clone Reserved"; break;
                        case 2977: eventLabels[i] = "Clone Reserved"; break;
                        case 2978: eventLabels[i] = "Clone Reserved"; break;
                        case 2979: eventLabels[i] = "Clone Reserved"; break;
                        case 2980: eventLabels[i] = "Clone Reserved"; break;
                        case 2981: eventLabels[i] = "Clone Reserved"; break;
                        case 2982: eventLabels[i] = "Clone Reserved"; break;
                        case 2983: eventLabels[i] = "Clone Reserved"; break;
                        case 2984: eventLabels[i] = "Clone Reserved"; break;
                        case 2985: eventLabels[i] = "Clone Reserved"; break;
                        case 2986: eventLabels[i] = "Clone Reserved"; break;
                        case 2987: eventLabels[i] = "Clone Reserved"; break;
                        case 2988: eventLabels[i] = "Clone Reserved"; break;
                        case 2989: eventLabels[i] = "Clone Reserved"; break;
                        case 2990: eventLabels[i] = "Clone Reserved"; break;
                        case 2991: eventLabels[i] = "Clone Reserved"; break;
                        case 2992: eventLabels[i] = "Clone Reserved"; break;
                        case 2993: eventLabels[i] = "Clone Reserved"; break;
                        case 2994: eventLabels[i] = "Clone Reserved"; break;
                        case 2995: eventLabels[i] = "Clone Reserved"; break;
                        case 2996: eventLabels[i] = "Clone Reserved"; break;
                        case 2997: eventLabels[i] = "Clone Reserved"; break;
                        case 2998: eventLabels[i] = "Clone Reserved"; break;
                        case 2999: eventLabels[i] = "Clone Reserved"; break;
                        case 3000: eventLabels[i] = "Clone Reserved"; break;
                        case 3001: eventLabels[i] = "Clone Reserved"; break;
                        case 3002: eventLabels[i] = "Clone Reserved"; break;
                        case 3003: eventLabels[i] = "Clone Reserved"; break;
                        case 3004: eventLabels[i] = "Clone Reserved"; break;
                        case 3005: eventLabels[i] = "Clone Reserved"; break;
                        case 3006: eventLabels[i] = "Clone Reserved"; break;
                        case 3007: eventLabels[i] = "Clone Reserved"; break;
                        case 3008: eventLabels[i] = "Clone Reserved"; break;
                        case 3009: eventLabels[i] = "Clone Reserved"; break;
                        case 3010: eventLabels[i] = "Clone Reserved"; break;
                        case 3011: eventLabels[i] = "Clone Reserved"; break;
                        case 3012: eventLabels[i] = "Clone Reserved"; break;
                        case 3013: eventLabels[i] = "Clone Reserved"; break;
                        case 3014: eventLabels[i] = "Clone Reserved"; break;
                        case 3015: eventLabels[i] = "Clone Reserved"; break;
                        case 3016: eventLabels[i] = "Clone Reserved"; break;
                        case 3017: eventLabels[i] = "Clone Reserved"; break;
                        case 3018: eventLabels[i] = "Clone Reserved"; break;
                        case 3019: eventLabels[i] = "Clone Reserved"; break;
                        case 3020: eventLabels[i] = "Clone Reserved"; break;
                        case 3021: eventLabels[i] = "Clone Reserved"; break;
                        case 3022: eventLabels[i] = "Clone Reserved"; break;
                        case 3023: eventLabels[i] = "Clone Reserved"; break;
                        case 3024: eventLabels[i] = "Clone Reserved"; break;
                        case 3025: eventLabels[i] = "Clone Reserved"; break;
                        case 3026: eventLabels[i] = "Clone Reserved"; break;
                        case 3027: eventLabels[i] = "Clone Reserved"; break;
                        case 3028: eventLabels[i] = "Clone Reserved"; break;
                        case 3029: eventLabels[i] = "Clone Reserved"; break;
                        case 3030: eventLabels[i] = "Clone Reserved"; break;
                        case 3031: eventLabels[i] = "Clone Reserved"; break;
                        case 3032: eventLabels[i] = "Clone Reserved"; break;
                        case 3033: eventLabels[i] = "Clone Reserved"; break;
                        case 3034: eventLabels[i] = "Clone Reserved"; break;
                        case 3035: eventLabels[i] = "Clone Reserved"; break;
                        case 3036: eventLabels[i] = "Clone Reserved"; break;
                        case 3037: eventLabels[i] = "Clone Reserved"; break;
                        case 3038: eventLabels[i] = "Clone Reserved"; break;
                        case 3039: eventLabels[i] = "Clone Reserved"; break;
                        case 3040: eventLabels[i] = "Clone Reserved"; break;
                        case 3041: eventLabels[i] = "Clone Reserved"; break;
                        case 3042: eventLabels[i] = "Clone Reserved"; break;
                        case 3043: eventLabels[i] = "Clone Reserved"; break;
                        case 3044: eventLabels[i] = "Clone Reserved"; break;
                        case 3045: eventLabels[i] = "Clone Reserved"; break;
                        case 3046: eventLabels[i] = "Clone Reserved"; break;
                        case 3047: eventLabels[i] = "Clone Reserved"; break;
                        case 3048: eventLabels[i] = "Clone Reserved"; break;
                        case 3049: eventLabels[i] = "Clone Reserved"; break;
                        case 3050: eventLabels[i] = "Clone Reserved"; break;
                        case 3051: eventLabels[i] = "Clone Reserved"; break;
                        case 3052: eventLabels[i] = "Clone Reserved"; break;
                        case 3053: eventLabels[i] = "Clone Reserved"; break;
                        case 3054: eventLabels[i] = "Clone Reserved"; break;
                        case 3055: eventLabels[i] = "Clone Reserved"; break;
                        case 3056: eventLabels[i] = "Clone Reserved"; break;
                        case 3057: eventLabels[i] = "Clone Reserved"; break;
                        case 3058: eventLabels[i] = "Clone Reserved"; break;
                        case 3059: eventLabels[i] = "Clone Reserved"; break;
                        case 3060: eventLabels[i] = "Clone Reserved"; break;
                        case 3061: eventLabels[i] = "Clone Reserved"; break;
                        case 3062: eventLabels[i] = "Clone Reserved"; break;
                        case 3063: eventLabels[i] = "Clone Reserved"; break;
                        case 3064: eventLabels[i] = "Clone Reserved"; break;
                        case 3065: eventLabels[i] = "Clone Reserved"; break;
                        case 3066: eventLabels[i] = "Clone Reserved"; break;
                        case 3067: eventLabels[i] = "Clone Reserved"; break;
                        case 3068: eventLabels[i] = "Clone Reserved"; break;
                        case 3069: eventLabels[i] = "Clone Reserved"; break;
                        case 3070: eventLabels[i] = "Clone Reserved"; break;
                        case 3071: eventLabels[i] = "Clone Reserved"; break;
                        case 3072: eventLabels[i] = "Flower Star Fc Or Mushroom Chest"; break;
                        case 3073: eventLabels[i] = "Item Chest"; break;
                        case 3074: eventLabels[i] = "Coin Chest Multi Hit 1"; break;
                        case 3075: eventLabels[i] = "Heal Flash"; break;
                        case 3076: eventLabels[i] = "Exp Star Chest Background"; break;
                        case 3077: eventLabels[i] = "Ship Puzzle Mushroom"; break;
                        case 3078: eventLabels[i] = "Mimic Or Slot Chest"; break;
                        case 3079: eventLabels[i] = "Exp Star Levelup Screen"; break;
                        case 3080: eventLabels[i] = "Coin Chest Quick Hit"; break;
                        case 3081: eventLabels[i] = "You Missed"; break;
                        case 3082: eventLabels[i] = "Frog Coin Chest Multi Hit 1"; break;
                        case 3083: eventLabels[i] = "Freestanding Shuffled Frog Coin"; break;
                        case 3084: eventLabels[i] = "Frog Coin Chest Quick Hit"; break;
                        case 3085: eventLabels[i] = "Freestanding Shuffled Coin"; break;
                        case 3086: eventLabels[i] = "Juice Bar Card Upgrade"; break;
                        case 3087: eventLabels[i] = "Progressive Egg Upgrade"; break;
                        case 3088: eventLabels[i] = "Empty"; break;
                        case 3089: eventLabels[i] = "Grant Item From Chest"; break;
                        case 3090: eventLabels[i] = "Open Lands End If Gated By Star Pieces"; break;
                        case 3091: eventLabels[i] = "Multi Frog Coin Chest Single Hit"; break;
                        case 3092: eventLabels[i] = "Star Piece Grant"; break;
                        case 3093: eventLabels[i] = "Open Abyss If Star Piece Threshold Met"; break;
                        case 3094: eventLabels[i] = "Star Piece Chest Animation"; break;
                        case 3095: eventLabels[i] = "Empty"; break;
                        case 3096: eventLabels[i] = "Empty"; break;
                        case 3097: eventLabels[i] = "Juice Bar Card Npc Grant"; break;
                        case 3098: eventLabels[i] = "Progressive Egg Npc Grant"; break;
                        case 3099: eventLabels[i] = "Shuffle Fireworks Chest Grant"; break;
                        case 3100: eventLabels[i] = "Progressive Fireworks Chest Grant"; break;
                        case 3101: eventLabels[i] = "Star Piece Hunt End Game"; break;
                        case 3102: eventLabels[i] = "Exit Jumping Kids House"; break;
                        case 3103: eventLabels[i] = "Enter Mk Guest Room"; break;
                        case 3104: eventLabels[i] = "Exit Mk Guest Room"; break;
                        case 3105: eventLabels[i] = "Enter Mk Staircase"; break;
                        case 3106: eventLabels[i] = "Exit Mk Staircase"; break;
                        case 3107: eventLabels[i] = "Empty"; break;
                        case 3108: eventLabels[i] = "Empty"; break;
                        case 3109: eventLabels[i] = "Freestanding Beetlemania Grant"; break;
                        case 3110: eventLabels[i] = "Freestanding Juice Bar Card Grant"; break;
                        case 3111: eventLabels[i] = "Freestanding Progressive Egg Grant"; break;
                        case 3112: eventLabels[i] = "Freestanding Shuffle Fireworks Grant"; break;
                        case 3113: eventLabels[i] = "Freestanding Progressive Fireworks Grant"; break;
                        case 3114: eventLabels[i] = "Hill Progressive Egg"; break;
                        case 3115: eventLabels[i] = "Hill Progressive Card"; break;
                        case 3116: eventLabels[i] = "Change Music In Moleville Mines When Backtracking"; break;
                        case 3117: eventLabels[i] = "Empty"; break;
                        case 3118: eventLabels[i] = "Water State"; break;
                        case 3119: eventLabels[i] = "Goby Battle"; break;
                        case 3120: eventLabels[i] = "Empty"; break;
                        case 3121: eventLabels[i] = "Sewer Boss Fight"; break;
                        case 3122: eventLabels[i] = "Sewer Boss Room Trampoline"; break;
                        case 3123: eventLabels[i] = "Sewer Drain Water"; break;
                        case 3124: eventLabels[i] = "Mimic 1 Chest"; break;
                        case 3125: eventLabels[i] = "Sewer Pipe To Lands End"; break;
                        case 3126: eventLabels[i] = "Mimic 2 Chest"; break;
                        case 3127: eventLabels[i] = "Sewer Exit Trampoline"; break;
                        case 3128: eventLabels[i] = "Empty"; break;
                        case 3129: eventLabels[i] = "Empty"; break;
                        case 3130: eventLabels[i] = "Sewer Tutorial Note"; break;
                        case 3131: eventLabels[i] = "Moleville Toad In Mines"; break;
                        case 3132: eventLabels[i] = "Moleville Miners Song"; break;
                        case 3133: eventLabels[i] = "Pa Mole In Mines"; break;
                        case 3134: eventLabels[i] = "Resummon Enemies In Sewer"; break;
                        case 3135: eventLabels[i] = "Sewers Generic Loader"; break;
                        case 3136: eventLabels[i] = "Sewers Overworld Pipe"; break;
                        case 3137: eventLabels[i] = "Sewers 1St Water Room Pipe To Tutorial Room"; break;
                        case 3138: eventLabels[i] = "Sewers 1St Water Room Pipe To 3Rd Water Room"; break;
                        case 3139: eventLabels[i] = "Sewers 4 Rat Room Pipe To 1St Water Room"; break;
                        case 3140: eventLabels[i] = "1St Water Toom Pipe To Sewers 4 Rat Room"; break;
                        case 3141: eventLabels[i] = "3Rd Water Room Pipe To 1St Water Room"; break;
                        case 3142: eventLabels[i] = "Pipe To Boss"; break;
                        case 3143: eventLabels[i] = "Rose Way Main Room Platforms"; break;
                        case 3144: eventLabels[i] = "Rose Way Main Room Platforms Background"; break;
                        case 3145: eventLabels[i] = "Sewers Flippable Chest"; break;
                        case 3146: eventLabels[i] = "Freestanding Big Coin"; break;
                        case 3147: eventLabels[i] = "Rose Way Tutorial"; break;
                        case 3148: eventLabels[i] = "Rose Way Main Room Loader"; break;
                        case 3149: eventLabels[i] = "Empty"; break;
                        case 3150: eventLabels[i] = "Rose Way Swing Chest"; break;
                        case 3151: eventLabels[i] = "Rose Way Tossed Shyguys"; break;
                        case 3152: eventLabels[i] = "Rose Way Five Chests"; break;
                        case 3153: eventLabels[i] = "Old Chest Granter"; break;
                        case 3154: eventLabels[i] = "Resummon Rose Way Npcs"; break;
                        case 3155: eventLabels[i] = "Empty"; break;
                        case 3156: eventLabels[i] = "Minecart Room Loader"; break;
                        case 3157: eventLabels[i] = "Minecart Room Loader Background"; break;
                        case 3158: eventLabels[i] = "Item Behind Ship Upper Stairs Tile"; break;
                        case 3159: eventLabels[i] = "Pa Mole After Bambino Bomb"; break;
                        case 3160: eventLabels[i] = "Mines Long Track Room Lower Backward Exit"; break;
                        case 3161: eventLabels[i] = "Mines Check If Shyguy Moved"; break;
                        case 3162: eventLabels[i] = "Mines Area 2 Lower Backward Exit If Mines Cleared"; break;
                        case 3163: eventLabels[i] = "Sewers Tutorial Room Exit To Exterior"; break;
                        case 3164: eventLabels[i] = "Sewers Tutorial Room Pipe To First Water Room"; break;
                        case 3165: eventLabels[i] = "Active Minecart Mario Collision Check"; break;
                        case 3166: eventLabels[i] = "Active Minecart Mario Collision Check Properties"; break;
                        case 3167: eventLabels[i] = "Mines Final Save Room Loader"; break;
                        case 3168: eventLabels[i] = "Sewers 3Rd Water Room Pipe To Water Switch Room"; break;
                        case 3169: eventLabels[i] = "Sewers Stair Room Pipe To Third Water Room"; break;
                        case 3170: eventLabels[i] = "Sewers Four Rat Room Pipe To Stair Room"; break;
                        case 3171: eventLabels[i] = "Sewers Stair Room Pipe To Four Rat Room"; break;
                        case 3172: eventLabels[i] = "Sewers 3Rd Water Room Pipe To Stair Room"; break;
                        case 3173: eventLabels[i] = "Sewers Four Rat Room Pipe To Rat Line Room"; break;
                        case 3174: eventLabels[i] = "Sewers 3Rd Water Room Pipe To Water Switch Room"; break;
                        case 3175: eventLabels[i] = "Sewers Water Switch Room Pipe To 3Rd Water Room"; break;
                        case 3176: eventLabels[i] = "Sewers Rat Line Room Pipe To 3Rd Water Room"; break;
                        case 3177: eventLabels[i] = "Sewers Stair Room Pipe To Four Rat Room"; break;
                        case 3178: eventLabels[i] = "Sewers 3Rd Water Toom Pipe To Rat Line Room"; break;
                        case 3179: eventLabels[i] = "Sewers Four Rat Room Pipe To Stair Room"; break;
                        case 3180: eventLabels[i] = "Sewers Rat Line Room Pipe To Four Rat Room"; break;
                        case 3181: eventLabels[i] = "Sewers Water Switch Room Pipe To 3Rd Water Room"; break;
                        case 3182: eventLabels[i] = "Minecart Paid Lobby Room Loader"; break;
                        case 3183: eventLabels[i] = "Minecart Paid Lobby Trampoline To Exterior"; break;
                        case 3184: eventLabels[i] = "Mines First Room Loader"; break;
                        case 3185: eventLabels[i] = "Pa Mole In Deep Mines"; break;
                        case 3186: eventLabels[i] = "Moles In First Mines Room"; break;
                        case 3187: eventLabels[i] = "Minecart Tutorial"; break;
                        case 3188: eventLabels[i] = "Mount Minecart"; break;
                        case 3189: eventLabels[i] = "Fall To Minecart Room From Lobby"; break;
                        case 3190: eventLabels[i] = "Activate Post Mines Boss First Minecart Session Continued"; break;
                        case 3191: eventLabels[i] = "Activate Post Mines Boss First Minecart Session"; break;
                        case 3192: eventLabels[i] = "Mines Left Henchman"; break;
                        case 3193: eventLabels[i] = "Mines Right Henchman"; break;
                        case 3194: eventLabels[i] = "Mines Center Henchman"; break;
                        case 3195: eventLabels[i] = "Parked Minecart Mario Collision Check"; break;
                        case 3196: eventLabels[i] = "Parked Minecart Mario Collision Check Properties"; break;
                        case 3197: eventLabels[i] = "Mines Final Save Room Exit To Boss Room"; break;
                        case 3198: eventLabels[i] = "Shyguy Cart Pushes Mario Into Smaller Room"; break;
                        case 3199: eventLabels[i] = "Shyguy Cart Prize Grant"; break;
                        case 3200: eventLabels[i] = "Mines Trampoline"; break;
                        case 3201: eventLabels[i] = "Mines 1St Boss Fight"; break;
                        case 3202: eventLabels[i] = "Minecart Room Exit To Boss Room"; break;
                        case 3203: eventLabels[i] = "Empty"; break;
                        case 3204: eventLabels[i] = "Empty"; break;
                        case 3205: eventLabels[i] = "Empty"; break;
                        case 3206: eventLabels[i] = "Sea Pipe To Ship"; break;
                        case 3207: eventLabels[i] = "Ship Exit Trampoline"; break;
                        case 3208: eventLabels[i] = "Water Whirlpool"; break;
                        case 3209: eventLabels[i] = "Sleeping Dry Bones"; break;
                        case 3210: eventLabels[i] = "Ship Trampoline Puzzle Block"; break;
                        case 3211: eventLabels[i] = "Ship 3D Maze Room Loader"; break;
                        case 3212: eventLabels[i] = "Ship 3D Maze Forfeit Listener"; break;
                        case 3213: eventLabels[i] = "Ship Post 1St Boss Trampoline Back Up"; break;
                        case 3214: eventLabels[i] = "Ship 1St Boss"; break;
                        case 3215: eventLabels[i] = "Ship Coin Snake Puzzle Header Coin"; break;
                        case 3216: eventLabels[i] = "Ship Coin Snake Puzzle Tail Coin"; break;
                        case 3217: eventLabels[i] = "Ship Cannonball Puzzle Cannonball"; break;
                        case 3218: eventLabels[i] = "Ship Submit Password"; break;
                        case 3219: eventLabels[i] = "Ship Barrel Puzzle Button"; break;
                        case 3220: eventLabels[i] = "Ship Barrel Puzzle Barrel Movement"; break;
                        case 3221: eventLabels[i] = "Ship 3D Maze Hit Button"; break;
                        case 3222: eventLabels[i] = "Ship Troopa Puzzle Loader"; break;
                        case 3223: eventLabels[i] = "Ship Troopa Puzzle"; break;
                        case 3224: eventLabels[i] = "Ship Password Room Loader"; break;
                        case 3225: eventLabels[i] = "Ship Password Box Dialog"; break;
                        case 3226: eventLabels[i] = "Ship Generic Loader"; break;
                        case 3227: eventLabels[i] = "Ship Clone Room Loader"; break;
                        case 3228: eventLabels[i] = "Ship Clone Control"; break;
                        case 3229: eventLabels[i] = "Ship Clone Transform"; break;
                        case 3230: eventLabels[i] = "Cancel Star In Sea"; break;
                        case 3231: eventLabels[i] = "Ship Cannonball Puzzle Initiator Block"; break;
                        case 3232: eventLabels[i] = "Ship Password Box 1"; break;
                        case 3233: eventLabels[i] = "Ship Password Box 2"; break;
                        case 3234: eventLabels[i] = "Ship Password Box 3"; break;
                        case 3235: eventLabels[i] = "Ship Password Box 4"; break;
                        case 3236: eventLabels[i] = "Ship Password Box 5"; break;
                        case 3237: eventLabels[i] = "Ship Password Box 6"; break;
                        case 3238: eventLabels[i] = "Freestanding Frog Coin"; break;
                        case 3239: eventLabels[i] = "Ship Open Door To Room Behind Box Wall"; break;
                        case 3240: eventLabels[i] = "Ship Troopa Puzzle Hint"; break;
                        case 3241: eventLabels[i] = "Ship Trampoline Puzzle Hint"; break;
                        case 3242: eventLabels[i] = "Ship 3D Maze Hint"; break;
                        case 3243: eventLabels[i] = "Ship Coin Snake Hint"; break;
                        case 3244: eventLabels[i] = "Ship Cannonball Puzzle Hint"; break;
                        case 3245: eventLabels[i] = "Ship Barrel Puzzle Hint"; break;
                        case 3246: eventLabels[i] = "Dry Bones Fight"; break;
                        case 3247: eventLabels[i] = "Item Behind Ship Upper Stairs Granter"; break;
                        case 3248: eventLabels[i] = "Ship Entrance Open Right Door"; break;
                        case 3249: eventLabels[i] = "Ship Entrance Open Left Door"; break;
                        case 3250: eventLabels[i] = "Ship 1St Greaper Room Open Upper Door"; break;
                        case 3251: eventLabels[i] = "Ship 2Nd Greaper Room Open Upper Door"; break;
                        case 3252: eventLabels[i] = "Ship Puzzle Hub Room Open Upper Exit Door"; break;
                        case 3253: eventLabels[i] = "Ship Puzzle Hub Room Open Troopa Puzzle Door"; break;
                        case 3254: eventLabels[i] = "Ship Puzzle Hub Room Open Trampoline Puzzle Door"; break;
                        case 3255: eventLabels[i] = "Ship Puzzle Hub Room Open 3D Maze Door"; break;
                        case 3256: eventLabels[i] = "Ship Puzzle Hub Room Open Lower Exit Door"; break;
                        case 3257: eventLabels[i] = "Ship Puzzle Hub Room Open Cannonball Puzzle Door"; break;
                        case 3258: eventLabels[i] = "Ship Puzzle Hub Room Open Coin Snake Puzzle Door"; break;
                        case 3259: eventLabels[i] = "Ship Shop Room Open Upper Door"; break;
                        case 3260: eventLabels[i] = "Ship Shop Room Open Lower Door"; break;
                        case 3261: eventLabels[i] = "Ship Barrel Puzzle Room Open Exit Door"; break;
                        case 3262: eventLabels[i] = "Ship Password Room Open Door To Boss"; break;
                        case 3263: eventLabels[i] = "Ship Lower First Trampoline Room Open Exit Door"; break;
                        case 3264: eventLabels[i] = "Ship Lower First Drybones Room Open Upper Door"; break;
                        case 3265: eventLabels[i] = "Ship Lower First Drybones Room Open Lower Door"; break;
                        case 3266: eventLabels[i] = "Ship Lower Rat Stairway Open Upper Door"; break;
                        case 3267: eventLabels[i] = "Ship Lower Rat Stairway Open Lower Door"; break;
                        case 3268: eventLabels[i] = "Ship Outer Clone Room Open Left Door"; break;
                        case 3269: eventLabels[i] = "Ship Outer Clone Room Open Right Door"; break;
                        case 3270: eventLabels[i] = "Ship Room With Box Wall Open Right Door"; break;
                        case 3271: eventLabels[i] = "Ship Final Save Room Open Exit Door"; break;
                        case 3272: eventLabels[i] = "Ship 1St Water Room Open Upper Door"; break;
                        case 3273: eventLabels[i] = "Ship 1St Water Room Open Underwater Door"; break;
                        case 3274: eventLabels[i] = "Ship Upper Whirlpool Room Open Underwater Door"; break;
                        case 3275: eventLabels[i] = "Ship Zeostar Stairway Open Underwater Door"; break;
                        case 3276: eventLabels[i] = "Ship Big Water Room Open Upper Door"; break;
                        case 3277: eventLabels[i] = "Ship Big Water Room Open Hidden Door"; break;
                        case 3278: eventLabels[i] = "Ship Open Door To Final Boss Room"; break;
                        case 3279: eventLabels[i] = "Ship Open Door In Final Boss Room"; break;
                        case 3280: eventLabels[i] = "Ship Lower Henchman Room Loader"; break;
                        case 3281: eventLabels[i] = "Ship Upper Henchman Room Loader"; break;
                        case 3282: eventLabels[i] = "Ship Boss Room Loader"; break;
                        case 3283: eventLabels[i] = "Empty"; break;
                        case 3284: eventLabels[i] = "Ship Save Rooms Loader"; break;
                        case 3285: eventLabels[i] = "Sea Single Chest Room Loader"; break;
                        case 3286: eventLabels[i] = "Ship Interact With Boss After Winning"; break;
                        case 3287: eventLabels[i] = "Ship Upper Henchman Room Talk To Guard After Winning"; break;
                        case 3288: eventLabels[i] = "Ship Spawn Prize In Troopa Puzzle Room"; break;
                        case 3289: eventLabels[i] = "Ship Collect Trampoline Prize"; break;
                        case 3290: eventLabels[i] = "Ship Collect 3D Maze Prize"; break;
                        case 3291: eventLabels[i] = "Ship Collect Cannonball Prize"; break;
                        case 3292: eventLabels[i] = "Lower Ship Generic Loader"; break;
                        case 3293: eventLabels[i] = "Ship Bullet Collision"; break;
                        case 3294: eventLabels[i] = "Ship Bullet Collision Background"; break;
                        case 3295: eventLabels[i] = "Ship Collect Barrel Prize"; break;
                        case 3296: eventLabels[i] = "Sea Entrance Trampoline"; break;
                        case 3297: eventLabels[i] = "Sea Shop"; break;
                        case 3298: eventLabels[i] = "Sea Reverse Whirlpool To Lone Chest"; break;
                        case 3299: eventLabels[i] = "Outer Sea Whirlpool"; break;
                        case 3300: eventLabels[i] = "Ship Entrance Note"; break;
                        case 3301: eventLabels[i] = "Ship Boss Room Inner Left Henchman"; break;
                        case 3302: eventLabels[i] = "Ship Boss Room Inner Right Henchman"; break;
                        case 3303: eventLabels[i] = "Ship 1St Save Room Hint Note"; break;
                        case 3304: eventLabels[i] = "Ship 1St Greaper Room Hint Note"; break;
                        case 3305: eventLabels[i] = "Ship 2Nd Greaper Room Hint Note"; break;
                        case 3306: eventLabels[i] = "Ship Lower Henchman Room Loader Continued"; break;
                        case 3307: eventLabels[i] = "Ship Password Tutorial"; break;
                        case 3308: eventLabels[i] = "Ship Boss Room Drink"; break;
                        case 3309: eventLabels[i] = "Ship Spawn Hidden Chest"; break;
                        case 3310: eventLabels[i] = "Ship Hidden Chest"; break;
                        case 3311: eventLabels[i] = "Ship Shop"; break;
                        case 3312: eventLabels[i] = "Sewers 1St Water Room Exit To Rat Line Room"; break;
                        case 3313: eventLabels[i] = "Sewers Rat Line Room Exit To 1St Water Room"; break;
                        case 3314: eventLabels[i] = "Sewers Rat Line Room Exit To 3Rd Water Room"; break;
                        case 3315: eventLabels[i] = "Sewers 3Rd Water Room Exit To Rat Line Room"; break;
                        case 3316: eventLabels[i] = "Ship Boss Room Leftmost Henchman"; break;
                        case 3317: eventLabels[i] = "Mines Final Chest"; break;
                        case 3318: eventLabels[i] = "Set Oerlikon Pack"; break;
                        case 3319: eventLabels[i] = "Set Vomer Pack"; break;
                        case 3320: eventLabels[i] = "Empty"; break;
                        case 3321: eventLabels[i] = "Volcano Enter 1St Room"; break;
                        case 3322: eventLabels[i] = "Volcano 1St Room Trampoline"; break;
                        case 3323: eventLabels[i] = "Volcano 1St Room Loader"; break;
                        case 3324: eventLabels[i] = "Volcano 3 Lift Room Donut Lift"; break;
                        case 3325: eventLabels[i] = "Stumpet Room Loader"; break;
                        case 3326: eventLabels[i] = "Stumpet Eruption"; break;
                        case 3327: eventLabels[i] = "Stumpet Fight"; break;
                        case 3328: eventLabels[i] = "Volcano Generic Loader 1"; break;
                        case 3329: eventLabels[i] = "Jumping Fireballs"; break;
                        case 3330: eventLabels[i] = "Volcano 1St Boss Room Loader"; break;
                        case 3331: eventLabels[i] = "Volcano 1St Boss Fight"; break;
                        case 3332: eventLabels[i] = "Volcano 1St Boss Path Room Loader"; break;
                        case 3333: eventLabels[i] = "Volcano Generic Loader 2"; break;
                        case 3334: eventLabels[i] = "Volcano Enter Shop Area"; break;
                        case 3335: eventLabels[i] = "Corkpedite Collision"; break;
                        case 3336: eventLabels[i] = "Corkpedite Room Loader"; break;
                        case 3337: eventLabels[i] = "Corkpedite Animation"; break;
                        case 3338: eventLabels[i] = "Volcano Trampoline To 2Nd Boss"; break;
                        case 3339: eventLabels[i] = "Volcano 2Nd Boss Path Room Loader"; break;
                        case 3340: eventLabels[i] = "Volcano 3Rd Boss Path Room Loader"; break;
                        case 3341: eventLabels[i] = "Volcano Small Boss Path Room Loader"; break;
                        case 3342: eventLabels[i] = "Volcano 5Th Boss Path Room Loader"; break;
                        case 3343: eventLabels[i] = "Volcano Final Boss Path Room Loader"; break;
                        case 3344: eventLabels[i] = "Volcano Final Trampoline Room Loader"; break;
                        case 3345: eventLabels[i] = "Volcano Chase Seqeunce"; break;
                        case 3346: eventLabels[i] = "Volcano 1St Boss Screen Tint"; break;
                        case 3347: eventLabels[i] = "Empty"; break;
                        case 3348: eventLabels[i] = "Keep Door Reward Chest"; break;
                        case 3349: eventLabels[i] = "Keep 6 Door Lobby Exit To Prev Room"; break;
                        case 3350: eventLabels[i] = "Keep All Door Paths Exit To Reward Room"; break;
                        case 3351: eventLabels[i] = "Empty"; break;
                        case 3352: eventLabels[i] = "Dr Topper Quiz"; break;
                        case 3353: eventLabels[i] = "Keep Enter Ball Solitaire Room"; break;
                        case 3354: eventLabels[i] = "Keep Barrel Count Loader"; break;
                        case 3355: eventLabels[i] = "Keep Barrel Count Loader Contd"; break;
                        case 3356: eventLabels[i] = "Keep Respawn In Lobby Upon Failure"; break;
                        case 3357: eventLabels[i] = "Keep Button Game Loader"; break;
                        case 3358: eventLabels[i] = "Keep Ball Solitaire Loader"; break;
                        case 3359: eventLabels[i] = "Keep Initiate Coin Game"; break;
                        case 3360: eventLabels[i] = "Keep Coin Game Chest"; break;
                        case 3361: eventLabels[i] = "Keep Exit Completed Doors To Boss Antechamber"; break;
                        case 3362: eventLabels[i] = "Keep Button Game Press Button"; break;
                        case 3363: eventLabels[i] = "Keep Ball Solitaire Kick Ball"; break;
                        case 3364: eventLabels[i] = "Keep Logic Game Loader"; break;
                        case 3365: eventLabels[i] = "Keep Logic Game Finalize Answer"; break;
                        case 3366: eventLabels[i] = "Keep Logic Game Boo"; break;
                        case 3367: eventLabels[i] = "Keep Logic Game Goo"; break;
                        case 3368: eventLabels[i] = "Keep Logic Game Bones"; break;
                        case 3369: eventLabels[i] = "Keep Logic Game Kipp"; break;
                        case 3370: eventLabels[i] = "Volcano Bridge Donut Lift"; break;
                        case 3371: eventLabels[i] = "Volcano Bridge Donut Lift No Falling"; break;
                        case 3372: eventLabels[i] = "Keep Get Crushed By Huge Thwomp"; break;
                        case 3373: eventLabels[i] = "Keep Thwomp Room Loader"; break;
                        case 3374: eventLabels[i] = "Keep Thwomp Room Background"; break;
                        case 3375: eventLabels[i] = "Keep Set Door Order"; break;
                        case 3376: eventLabels[i] = "Keep 6 Door Lobby Loader"; break;
                        case 3377: eventLabels[i] = "Keep Open Door 1"; break;
                        case 3378: eventLabels[i] = "Keep Open Door 2"; break;
                        case 3379: eventLabels[i] = "Keep Open Door 3"; break;
                        case 3380: eventLabels[i] = "Keep Open Door 4"; break;
                        case 3381: eventLabels[i] = "Keep Open Door 5"; break;
                        case 3382: eventLabels[i] = "Keep Open Door 6"; break;
                        case 3383: eventLabels[i] = "Ship Trampoline Prize Packet Grant"; break;
                        case 3384: eventLabels[i] = "Ship Troopa Prize Packet Grant"; break;
                        case 3385: eventLabels[i] = "Ship Upper Stairway Item Packet Grant"; break;
                        case 3386: eventLabels[i] = "Ship 3D Maze Spawn Prize"; break;
                        case 3387: eventLabels[i] = "Ship Cannonball Puzzle Spawn Prize"; break;
                        case 3388: eventLabels[i] = "Ship Boss Room Periscope"; break;
                        case 3389: eventLabels[i] = "Ship Barrel Puzzle Spawn Prize"; break;
                        case 3390: eventLabels[i] = "Keep Lava Patform Room Chest Camera"; break;
                        case 3391: eventLabels[i] = "Volcano 1St Save Room Lower Chest"; break;
                        case 3392: eventLabels[i] = "Volcano 1St Save Room Upper Chest"; break;
                        case 3393: eventLabels[i] = "Super Jump Compare For 1St Prize"; break;
                        case 3394: eventLabels[i] = "Super Jump Compare For 2Nd Prize"; break;
                        case 3395: eventLabels[i] = "Midas Cave Beetlemania Granter"; break;
                        case 3396: eventLabels[i] = "Midas Cave Progressive Card Granter"; break;
                        case 3397: eventLabels[i] = "Midas Cave Progressive Egg Granter"; break;
                        case 3398: eventLabels[i] = "Midas Cave Single Firework Granter"; break;
                        case 3399: eventLabels[i] = "Midas Cave Progressive Firework Granter"; break;
                        case 3400: eventLabels[i] = "Restart Music After Star Piece Sequence"; break;
                        case 3401: eventLabels[i] = "Coin Chest Multi Hit 2"; break;
                        case 3402: eventLabels[i] = "Coin Chest Multi Hit 3"; break;
                        case 3403: eventLabels[i] = "Coin Chest Multi Hit 4"; break;
                        case 3404: eventLabels[i] = "Coin Chest Multi Hit 5"; break;
                        case 3405: eventLabels[i] = "Coin Chest Multi Hit 6"; break;
                        case 3406: eventLabels[i] = "Frog Coin Chest Multi Hit 2"; break;
                        case 3407: eventLabels[i] = "Frog Coin Chest Multi Hit 3"; break;
                        case 3408: eventLabels[i] = "Frog Coin Chest Multi Hit 4"; break;
                        case 3409: eventLabels[i] = "Frog Coin Chest Multi Hit 5"; break;
                        case 3410: eventLabels[i] = "Frog Coin Chest Multi Hit 6"; break;
                        case 3411: eventLabels[i] = "Ship Password Correctness Check"; break;
                        case 3412: eventLabels[i] = "Empty"; break;
                        case 3413: eventLabels[i] = "Mines Shyguy Collide With Boxes"; break;
                        case 3414: eventLabels[i] = "Rose Way Main Room 2Nd Freestanding Item"; break;
                        case 3415: eventLabels[i] = "Tower Stacked Chests On Top Floor"; break;
                        case 3416: eventLabels[i] = "Empty"; break;
                        case 3417: eventLabels[i] = "Empty"; break;
                        case 3418: eventLabels[i] = "Empty"; break;
                        case 3419: eventLabels[i] = "Empty"; break;
                        case 3420: eventLabels[i] = "Empty"; break;
                        case 3421: eventLabels[i] = "Empty"; break;
                        case 3422: eventLabels[i] = "Empty"; break;
                        case 3423: eventLabels[i] = "Empty"; break;
                        case 3424: eventLabels[i] = "Empty"; break;
                        case 3425: eventLabels[i] = "Empty"; break;
                        case 3426: eventLabels[i] = "Empty"; break;
                        case 3427: eventLabels[i] = "Empty"; break;
                        case 3428: eventLabels[i] = "Empty"; break;
                        case 3429: eventLabels[i] = "Empty"; break;
                        case 3430: eventLabels[i] = "Empty"; break;
                        case 3431: eventLabels[i] = "Empty"; break;
                        case 3432: eventLabels[i] = "Empty"; break;
                        case 3433: eventLabels[i] = "Empty"; break;
                        case 3434: eventLabels[i] = "Empty"; break;
                        case 3435: eventLabels[i] = "Empty"; break;
                        case 3436: eventLabels[i] = "Empty"; break;
                        case 3437: eventLabels[i] = "Empty"; break;
                        case 3438: eventLabels[i] = "Empty"; break;
                        case 3439: eventLabels[i] = "Empty"; break;
                        case 3440: eventLabels[i] = "Empty"; break;
                        case 3441: eventLabels[i] = "Empty"; break;
                        case 3442: eventLabels[i] = "Empty"; break;
                        case 3443: eventLabels[i] = "Empty"; break;
                        case 3444: eventLabels[i] = "Empty"; break;
                        case 3445: eventLabels[i] = "Empty"; break;
                        case 3446: eventLabels[i] = "Empty"; break;
                        case 3447: eventLabels[i] = "Empty"; break;
                        case 3448: eventLabels[i] = "Empty"; break;
                        case 3449: eventLabels[i] = "Empty"; break;
                        case 3450: eventLabels[i] = "Empty"; break;
                        case 3451: eventLabels[i] = "Empty"; break;
                        case 3452: eventLabels[i] = "Empty"; break;
                        case 3453: eventLabels[i] = "Empty"; break;
                        case 3454: eventLabels[i] = "Empty"; break;
                        case 3455: eventLabels[i] = "Empty"; break;
                        case 3456: eventLabels[i] = "Empty"; break;
                        case 3457: eventLabels[i] = "Empty"; break;
                        case 3458: eventLabels[i] = "Empty"; break;
                        case 3459: eventLabels[i] = "Empty"; break;
                        case 3460: eventLabels[i] = "Empty"; break;
                        case 3461: eventLabels[i] = "Empty"; break;
                        case 3462: eventLabels[i] = "Empty"; break;
                        case 3463: eventLabels[i] = "Empty"; break;
                        case 3464: eventLabels[i] = "Empty"; break;
                        case 3465: eventLabels[i] = "Empty"; break;
                        case 3466: eventLabels[i] = "Empty"; break;
                        case 3467: eventLabels[i] = "Empty"; break;
                        case 3468: eventLabels[i] = "Empty"; break;
                        case 3469: eventLabels[i] = "Empty"; break;
                        case 3470: eventLabels[i] = "Empty"; break;
                        case 3471: eventLabels[i] = "Empty"; break;
                        case 3472: eventLabels[i] = "Empty"; break;
                        case 3473: eventLabels[i] = "Empty"; break;
                        case 3474: eventLabels[i] = "Empty"; break;
                        case 3475: eventLabels[i] = "Empty"; break;
                        case 3476: eventLabels[i] = "Empty"; break;
                        case 3477: eventLabels[i] = "Kingdom Hallway Chest"; break;
                        case 3478: eventLabels[i] = "Midas River Trampoline"; break;
                        case 3479: eventLabels[i] = "Midas River Score Submission"; break;
                        case 3480: eventLabels[i] = "Midas River Waterfall Loader"; break;
                        case 3481: eventLabels[i] = "Midas River Tunnel Warp Check"; break;
                        case 3482: eventLabels[i] = "Midas River Top Tunnel Loader"; break;
                        case 3483: eventLabels[i] = "Midas River Mid Left Or Mid Right Loader"; break;
                        case 3484: eventLabels[i] = "Midas River Bottom Left Loader"; break;
                        case 3485: eventLabels[i] = "Midas River Bottom Right Loader"; break;
                        case 3486: eventLabels[i] = "Midas River Base Area Loader"; break;
                        case 3487: eventLabels[i] = "Midas River Frog Coin"; break;
                        case 3488: eventLabels[i] = "Midas River Coin"; break;
                        case 3489: eventLabels[i] = "Midas River Waterfall Listen For Button Inputs"; break;
                        case 3490: eventLabels[i] = "Midas Small Mario Coord Calc"; break;
                        case 3491: eventLabels[i] = "Midas River Top Tunnel Animation And Exit"; break;
                        case 3492: eventLabels[i] = "Midas River Mid Left Tunnel Animation And Exit"; break;
                        case 3493: eventLabels[i] = "Midas River Mid Right Tunnel Animation And Exit"; break;
                        case 3494: eventLabels[i] = "Midas River Bottom Left Tunnel Animation And Exit"; break;
                        case 3495: eventLabels[i] = "Midas River Bottom Right Tunnel Animation And Exit"; break;
                        case 3496: eventLabels[i] = "Midas River Mid Right Tunnel Animation And Exit Background"; break;
                        case 3497: eventLabels[i] = "Midas River Bottom Left Tunnel Item Granter"; break;
                        case 3498: eventLabels[i] = "Midas River Bottom Right Tunnel Background"; break;
                        case 3499: eventLabels[i] = "Booster Hill 1St Pass Loader"; break;
                        case 3500: eventLabels[i] = "Booster Hill 1St Pass Snifit Jumps"; break;
                        case 3501: eventLabels[i] = "Booster Hill Barrel Interaction"; break;
                        case 3502: eventLabels[i] = "Booster Hill End"; break;
                        case 3503: eventLabels[i] = "Booster Hill Barrel Summoner"; break;
                        case 3504: eventLabels[i] = "Booster Hill Henchman Interaction"; break;
                        case 3505: eventLabels[i] = "Booster Hill Unknown"; break;
                        case 3506: eventLabels[i] = "Booster Hill Get Flower"; break;
                        case 3507: eventLabels[i] = "Booster Hill 2Nd Pass Loader"; break;
                        case 3508: eventLabels[i] = "Booster Hill Return"; break;
                        case 3509: eventLabels[i] = "Empty"; break;
                        case 3510: eventLabels[i] = "Booster Hill Exit To World Map"; break;
                        case 3511: eventLabels[i] = "Booster Hill 2Nd Pass Background"; break;
                        case 3512: eventLabels[i] = "Booster Hill Flower Pickup"; break;
                        case 3513: eventLabels[i] = "Midas River Bottom Right Tunnel Item Granter"; break;
                        case 3514: eventLabels[i] = "Nimbus Castle Egg Room Exit To Previous Room"; break;
                        case 3515: eventLabels[i] = "Nimbus Castle Egg Room Exit To Next Room"; break;
                        case 3516: eventLabels[i] = "Chest Differentiator Npc 3 Or Other"; break;
                        case 3517: eventLabels[i] = "Chest Differentiator Npc 1 2 3 Or Other"; break;
                        case 3518: eventLabels[i] = "Chest Differentiator Npc 2 3 4 5 6 Or Other"; break;
                        case 3519: eventLabels[i] = "Chest Differentiator Npc 4 Or Other"; break;
                        case 3520: eventLabels[i] = "Chest Differentiator Npc 12 13 Or Other Camera A"; break;
                        case 3521: eventLabels[i] = "Chest Differentiator Npc 12 13 Or Other Camera B"; break;
                        case 3522: eventLabels[i] = "Chest Differentiator Npc 9 Or Other Camera A"; break;
                        case 3523: eventLabels[i] = "Empty"; break;
                        case 3524: eventLabels[i] = "Empty"; break;
                        case 3525: eventLabels[i] = "Empty"; break;
                        case 3526: eventLabels[i] = "Empty"; break;
                        case 3527: eventLabels[i] = "Empty"; break;
                        case 3528: eventLabels[i] = "Empty"; break;
                        case 3529: eventLabels[i] = "Empty"; break;
                        case 3530: eventLabels[i] = "Empty"; break;
                        case 3531: eventLabels[i] = "Empty"; break;
                        case 3532: eventLabels[i] = "Empty"; break;
                        case 3533: eventLabels[i] = "Empty"; break;
                        case 3534: eventLabels[i] = "Empty"; break;
                        case 3535: eventLabels[i] = "Empty"; break;
                        case 3536: eventLabels[i] = "Empty"; break;
                        case 3537: eventLabels[i] = "Empty"; break;
                        case 3538: eventLabels[i] = "Empty"; break;
                        case 3539: eventLabels[i] = "Empty"; break;
                        case 3540: eventLabels[i] = "Empty"; break;
                        case 3541: eventLabels[i] = "Empty"; break;
                        case 3542: eventLabels[i] = "Empty"; break;
                        case 3543: eventLabels[i] = "Empty"; break;
                        case 3544: eventLabels[i] = "Empty"; break;
                        case 3545: eventLabels[i] = "Empty"; break;
                        case 3546: eventLabels[i] = "Empty"; break;
                        case 3547: eventLabels[i] = "Empty"; break;
                        case 3548: eventLabels[i] = "Empty"; break;
                        case 3549: eventLabels[i] = "Empty"; break;
                        case 3550: eventLabels[i] = "Empty"; break;
                        case 3551: eventLabels[i] = "Empty"; break;
                        case 3552: eventLabels[i] = "Empty"; break;
                        case 3553: eventLabels[i] = "Empty"; break;
                        case 3554: eventLabels[i] = "Empty"; break;
                        case 3555: eventLabels[i] = "Empty"; break;
                        case 3556: eventLabels[i] = "Empty"; break;
                        case 3557: eventLabels[i] = "Empty"; break;
                        case 3558: eventLabels[i] = "Empty"; break;
                        case 3559: eventLabels[i] = "Empty"; break;
                        case 3560: eventLabels[i] = "Empty"; break;
                        case 3561: eventLabels[i] = "Empty"; break;
                        case 3562: eventLabels[i] = "Empty"; break;
                        case 3563: eventLabels[i] = "Empty"; break;
                        case 3564: eventLabels[i] = "Empty"; break;
                        case 3565: eventLabels[i] = "Empty"; break;
                        case 3566: eventLabels[i] = "Empty"; break;
                        case 3567: eventLabels[i] = "Empty"; break;
                        case 3568: eventLabels[i] = "Empty"; break;
                        case 3569: eventLabels[i] = "Empty"; break;
                        case 3570: eventLabels[i] = "Empty"; break;
                        case 3571: eventLabels[i] = "Empty"; break;
                        case 3572: eventLabels[i] = "Empty"; break;
                        case 3573: eventLabels[i] = "Empty"; break;
                        case 3574: eventLabels[i] = "Empty"; break;
                        case 3575: eventLabels[i] = "Empty"; break;
                        case 3576: eventLabels[i] = "Empty"; break;
                        case 3577: eventLabels[i] = "Empty"; break;
                        case 3578: eventLabels[i] = "Empty"; break;
                        case 3579: eventLabels[i] = "Empty"; break;
                        case 3580: eventLabels[i] = "Empty"; break;
                        case 3581: eventLabels[i] = "Empty"; break;
                        case 3582: eventLabels[i] = "Empty"; break;
                        case 3583: eventLabels[i] = "Empty"; break;
                        case 3584: eventLabels[i] = "Bank 20 Return Event"; break;
                        case 3585: eventLabels[i] = "Nimbus Fade In Async"; break;
                        case 3586: eventLabels[i] = "Nimbus Inn Lobby Loader From Save Point"; break;
                        case 3587: eventLabels[i] = "Set 70Ae To 70A8"; break;
                        case 3588: eventLabels[i] = "Signal Ring Activator"; break;
                        case 3589: eventLabels[i] = "Empty"; break;
                        case 3590: eventLabels[i] = "Rose Town Chimney"; break;
                        case 3591: eventLabels[i] = "Empty"; break;
                        case 3592: eventLabels[i] = "Empty"; break;
                        case 3593: eventLabels[i] = "Get Item From Chapel Henchman 3"; break;
                        case 3594: eventLabels[i] = "Get Item From Chapel Henchman 1"; break;
                        case 3595: eventLabels[i] = "Get Item From Chapel Henchman 2"; break;
                        case 3596: eventLabels[i] = "Empty"; break;
                        case 3597: eventLabels[i] = "Yoster Empty Mailbox"; break;
                        case 3598: eventLabels[i] = "Empty"; break;
                        case 3599: eventLabels[i] = "Mushroom Derby Prize Calculator"; break;
                        case 3600: eventLabels[i] = "Mushroom Derby Goal Tile"; break;
                        case 3601: eventLabels[i] = "Mushroom Derby Yoshi Autoplay"; break;
                        case 3602: eventLabels[i] = "Mushroom Kingdom Raz Raini Note"; break;
                        case 3603: eventLabels[i] = "Empty"; break;
                        case 3604: eventLabels[i] = "Pipe Vault Triple Chest Room Loader"; break;
                        case 3605: eventLabels[i] = "Pipe Vault Pipe To Triple Chest Room"; break;
                        case 3606: eventLabels[i] = "Chest Differentiator Npc 1 Or Other Camera A"; break;
                        case 3607: eventLabels[i] = "Coin Differentiator Npc 8 Through 15"; break;
                        case 3608: eventLabels[i] = "Lands End Purchasable Chest"; break;
                        case 3609: eventLabels[i] = "Keep Invisible Floor Chests"; break;
                        case 3610: eventLabels[i] = "Keep Invisible Floor Coins"; break;
                        case 3611: eventLabels[i] = "Chest Differentiator Npc 2 Or Other"; break;
                        case 3612: eventLabels[i] = "Chest Differentiator Npc 1 Or Other Camera B"; break;
                        case 3613: eventLabels[i] = "Chest Differentiator Npc 11 Or Other"; break;
                        case 3614: eventLabels[i] = "Belome Fortune Prize Chest"; break;
                        case 3615: eventLabels[i] = "Climb Up Valley Beanstalk Into Vine Clouds"; break;
                        case 3616: eventLabels[i] = "Nimbus Inn Loader From Door"; break;
                        case 3617: eventLabels[i] = "Nimbus Inn Bedroom Loader"; break;
                        case 3618: eventLabels[i] = "Nimbus Exterior Open Inn Door"; break;
                        case 3619: eventLabels[i] = "Nimbus Exterior Open Shop Door"; break;
                        case 3620: eventLabels[i] = "Nimbus Exterior Open Garros Door"; break;
                        case 3621: eventLabels[i] = "Nimbus Exterior Open South House Door"; break;
                        case 3622: eventLabels[i] = "Nimbus Exterior Open Northeast House Door"; break;
                        case 3623: eventLabels[i] = "Empty"; break;
                        case 3624: eventLabels[i] = "Nimbus Shop Loader"; break;
                        case 3625: eventLabels[i] = "Empty"; break;
                        case 3626: eventLabels[i] = "Nimbus Shop Chest Camera Shift"; break;
                        case 3627: eventLabels[i] = "Empty"; break;
                        case 3628: eventLabels[i] = "Nimbus Exterior Blue Guy In Front Of Castle Entrance"; break;
                        case 3629: eventLabels[i] = "Nimbus Exterior Blue Guy Near Shop"; break;
                        case 3630: eventLabels[i] = "Nimbus Exterior Blue Guy Near Invisible Path"; break;
                        case 3631: eventLabels[i] = "Nimbus Exterior Blue Guy Near Garros House"; break;
                        case 3632: eventLabels[i] = "Nimbus Exterior Woman Near Invisible Path"; break;
                        case 3633: eventLabels[i] = "Nimbus Exterior Woman Near Inn"; break;
                        case 3634: eventLabels[i] = "Nimbus Exterior Woman Near Entrance"; break;
                        case 3635: eventLabels[i] = "Nimbus Exterior Woman In Front Of Castle Entrance"; break;
                        case 3636: eventLabels[i] = "Nimbus Bird Guard"; break;
                        case 3637: eventLabels[i] = "Temple Backdoor Locked"; break;
                        case 3638: eventLabels[i] = "Empty"; break;
                        case 3639: eventLabels[i] = "Empty"; break;
                        case 3640: eventLabels[i] = "Statue Game"; break;
                        case 3641: eventLabels[i] = "Empty"; break;
                        case 3642: eventLabels[i] = "Nimbus Exterior Occupied Loader"; break;
                        case 3643: eventLabels[i] = "Nimbus Shop"; break;
                        case 3644: eventLabels[i] = "Nimbus Innkeeper"; break;
                        case 3645: eventLabels[i] = "Nimbus Exterior Exit To Vines"; break;
                        case 3646: eventLabels[i] = "Nimbus Exterior Guard Near Entrance"; break;
                        case 3647: eventLabels[i] = "Nimbus Exterior Guard Near Castle"; break;
                        case 3648: eventLabels[i] = "Nimbus Occupied Northeast House Right Guy"; break;
                        case 3649: eventLabels[i] = "Nimbus Occupied Northeast House Left Woman"; break;
                        case 3650: eventLabels[i] = "Nimbus Occupied Northeast House Right Woman"; break;
                        case 3651: eventLabels[i] = "Nimbus Northeast House Croco"; break;
                        case 3652: eventLabels[i] = "Nimbus Occupied Northeast House Left Guard"; break;
                        case 3653: eventLabels[i] = "Nimbus South House Guy"; break;
                        case 3654: eventLabels[i] = "Nimbus South House Woman"; break;
                        case 3655: eventLabels[i] = "Nimbus Exterior Southernmost Blue Guy"; break;
                        case 3656: eventLabels[i] = "Empty"; break;
                        case 3657: eventLabels[i] = "Room Service Menu"; break;
                        case 3658: eventLabels[i] = "Empty"; break;
                        case 3659: eventLabels[i] = "Nimbus Deep Castle Note"; break;
                        case 3660: eventLabels[i] = "Nimbus Repopulate Castle Upon Liberation"; break;
                        case 3661: eventLabels[i] = "Bathrobe"; break;
                        case 3662: eventLabels[i] = "Nimbus Castle Left Fan Room Exit To Bridge Room"; break;
                        case 3663: eventLabels[i] = "Nimbus Castle Left Shaman Room Exit To 5 Door Room"; break;
                        case 3664: eventLabels[i] = "Nimbus Castle Right Shaman Room Exit To 5 Door Room"; break;
                        case 3665: eventLabels[i] = "Nimbus Castle Right Shaman Room Exit To Two Level Chest Room"; break;
                        case 3666: eventLabels[i] = "Nimbus Castle Note Hallway Exit To Two Level Chest Room"; break;
                        case 3667: eventLabels[i] = "Nimbus Castle Antechamber Left Guard"; break;
                        case 3668: eventLabels[i] = "Nimbus Castle Antechamber Right Guard"; break;
                        case 3669: eventLabels[i] = "Nimbus Castle Solo Bird Statue Room Exit To 5 Door Room"; break;
                        case 3670: eventLabels[i] = "Nimbus Castle Main Hall Loader"; break;
                        case 3671: eventLabels[i] = "Nimbus Castle First Post Throne Hall Exit To Throne Room"; break;
                        case 3672: eventLabels[i] = "Nimbus Castle Back Exit Fall"; break;
                        case 3673: eventLabels[i] = "Nimbus Liberated Town Square Loader"; break;
                        case 3674: eventLabels[i] = "Nimbus Castle Two Level Chest Room Lower Chest"; break;
                        case 3675: eventLabels[i] = "Nimbus Castle Bridge Room Lower Npc"; break;
                        case 3676: eventLabels[i] = "Nimbus Castle Two Level Chest Room Female Npc"; break;
                        case 3677: eventLabels[i] = "Royal Bus Platform Loader"; break;
                        case 3678: eventLabels[i] = "Royal Bus Attendant"; break;
                        case 3679: eventLabels[i] = "Nimbus Castle Egg Room Loader"; break;
                        case 3680: eventLabels[i] = "Nimbus Castle Egg Post Defeat"; break;
                        case 3681: eventLabels[i] = "Birdy Becomes Platform"; break;
                        case 3682: eventLabels[i] = "Empty"; break;
                        case 3683: eventLabels[i] = "Vine Instructions"; break;
                        case 3684: eventLabels[i] = "Empty"; break;
                        case 3685: eventLabels[i] = "Nimbus Get Crocos Item"; break;
                        case 3686: eventLabels[i] = "Marrymore Shower"; break;
                        case 3687: eventLabels[i] = "Marrymore Shower Door"; break;
                        case 3688: eventLabels[i] = "Marrymore Service Bell"; break;
                        case 3689: eventLabels[i] = "Link"; break;
                        case 3690: eventLabels[i] = "Nimbus Castle Main Hall Exit To Exterior"; break;
                        case 3691: eventLabels[i] = "Garros House Exit"; break;
                        case 3692: eventLabels[i] = "Nimbus Lower House Exit To Exterior"; break;
                        case 3693: eventLabels[i] = "Nimbus Inn Exit To Exterior"; break;
                        case 3694: eventLabels[i] = "Nimbus Shop Exit"; break;
                        case 3695: eventLabels[i] = "Nimbus Croco House Exit"; break;
                        case 3696: eventLabels[i] = "Nimbus Castle West Lower Hall Loader"; break;
                        case 3697: eventLabels[i] = "Nimbus Castle West Lower Hall Pinwheel Animations"; break;
                        case 3698: eventLabels[i] = "Nimbus Castle West Lower Hall Pinwheel"; break;
                        case 3699: eventLabels[i] = "Nimbus Castle West Lower Hall Mario Blown By Fan Bit"; break;
                        case 3700: eventLabels[i] = "Nimbus Castle West Lower Hall Mario Blown By Fan Bit"; break;
                        case 3701: eventLabels[i] = "Nimbus Castle Left Shaman Room Loader"; break;
                        case 3702: eventLabels[i] = "Nimbus Castle Right Shaman Room Loader"; break;
                        case 3703: eventLabels[i] = "Nimbus Castle Two Level Chest Room Loader"; break;
                        case 3704: eventLabels[i] = "Nimbus Castle Occupied 5 Door Room Loader"; break;
                        case 3705: eventLabels[i] = "Jawful Battle"; break;
                        case 3706: eventLabels[i] = "Activate Jawful Extended Hitboxes"; break;
                        case 3707: eventLabels[i] = "Nimbus Castle West Staircase Loader"; break;
                        case 3708: eventLabels[i] = "Open Castlekey1 Door"; break;
                        case 3709: eventLabels[i] = "Empty"; break;
                        case 3710: eventLabels[i] = "Empty"; break;
                        case 3711: eventLabels[i] = "Nimbus Castle Bridge Room Loader"; break;
                        case 3712: eventLabels[i] = "Nimbus Castle Bridge Room Npc Animations"; break;
                        case 3713: eventLabels[i] = "Nimbus Castle Angled Plant Room Npc Animations"; break;
                        case 3714: eventLabels[i] = "Nimbus Castle Angled Plant Room Loader"; break;
                        case 3715: eventLabels[i] = "Nimbus Castle Angled Plant Room Right Fan Gust Path"; break;
                        case 3716: eventLabels[i] = "Nimbus Castle Angled Plant Room Right Fan Gust"; break;
                        case 3717: eventLabels[i] = "Nimbus Castle Two Level Chest Room Fan Gust Path"; break;
                        case 3718: eventLabels[i] = "Nimbus Castle Angled Plant Room Right Fan Battle"; break;
                        case 3719: eventLabels[i] = "Nimbus Castle Right Red Cellar Woman"; break;
                        case 3720: eventLabels[i] = "Nimbus Castle Outer Cellar Blue Gift Guy"; break;
                        case 3721: eventLabels[i] = "Nimbus Castle Rightmost Outer Cellar Guy"; break;
                        case 3722: eventLabels[i] = "Nimbus Castle Left Cellar Woman"; break;
                        case 3723: eventLabels[i] = "Nimbus Castle Outer Cellar Gift Guard"; break;
                        case 3724: eventLabels[i] = "Nimbus Castle Outer Cellar Loader"; break;
                        case 3725: eventLabels[i] = "Nimbus Castle Note Hallway Loader"; break;
                        case 3726: eventLabels[i] = "Nimbus Castle Antechamber Loader"; break;
                        case 3727: eventLabels[i] = "Nimbus Castle Stairway Guard"; break;
                        case 3728: eventLabels[i] = "Empty"; break;
                        case 3729: eventLabels[i] = "Nimbus Castle Occupied Throne Room Loader"; break;
                        case 3730: eventLabels[i] = "Nimbus Castle Occupied 4 Path Room Loader"; break;
                        case 3731: eventLabels[i] = "Empty"; break;
                        case 3732: eventLabels[i] = "Nimbus Castle Final Chest Hallway Loader"; break;
                        case 3733: eventLabels[i] = "Nimbus Castle Final Chest Hallway Platform"; break;
                        case 3734: eventLabels[i] = "Nimbus Castle Final Chest Hallway Exit To Final Hallway"; break;
                        case 3735: eventLabels[i] = "Nimbus Castle Final Hallway Apply Mod"; break;
                        case 3736: eventLabels[i] = "Nimbus Castle Final Hallway Loader"; break;
                        case 3737: eventLabels[i] = "Nimbus Castle Back Exit Loader"; break;
                        case 3738: eventLabels[i] = "Empty"; break;
                        case 3739: eventLabels[i] = "Nimbus Castle Throne Room Exit To Antechamber"; break;
                        case 3740: eventLabels[i] = "Nimbus Castle Liberated Throne Room Loader"; break;
                        case 3741: eventLabels[i] = "Nimbus Castle Antechamber Exit To Note Hallway"; break;
                        case 3742: eventLabels[i] = "Nimbus Castle Antechamber Exit To Throne Room"; break;
                        case 3743: eventLabels[i] = "Nimbus Castle Right Shaman Hallway Liberated Npc"; break;
                        case 3744: eventLabels[i] = "Nimbus Exterior Shy Away"; break;
                        case 3745: eventLabels[i] = "Nimbus Back Exit Initiate Falling Sequence"; break;
                        case 3746: eventLabels[i] = "Hot Springs Trampoline To Mezzanine"; break;
                        case 3747: eventLabels[i] = "Nimbus Hot Spring Guards"; break;
                        case 3748: eventLabels[i] = "Empty"; break;
                        case 3749: eventLabels[i] = "Nimbus Mezzanine Trampoline To Town Square"; break;
                        case 3750: eventLabels[i] = "Nimbus Mezzanine Fall To Hot Springs"; break;
                        case 3751: eventLabels[i] = "Nimbus Land Hot Springs Lobby Exit"; break;
                        case 3752: eventLabels[i] = "Hot Springs Exit To Lobby"; break;
                        case 3753: eventLabels[i] = "Hot Springs Lobby Loader"; break;
                        case 3754: eventLabels[i] = "Hot Springs Fall To Volcano"; break;
                        case 3755: eventLabels[i] = "Hot Springs Note"; break;
                        case 3756: eventLabels[i] = "Hot Springs Loader"; break;
                        case 3757: eventLabels[i] = "King Nimbus"; break;
                        case 3758: eventLabels[i] = "Queen Nimbus"; break;
                        case 3759: eventLabels[i] = "Nimbus Castle Left Shaman Hallway Liberated Npc"; break;
                        case 3760: eventLabels[i] = "Nimbus Mezzanine Trampoline To World Map"; break;
                        case 3761: eventLabels[i] = "Nimbus Mezzanine Loader"; break;
                        case 3762: eventLabels[i] = "Nimbus Castle Liberated 5 Door Room Loader"; break;
                        case 3763: eventLabels[i] = "Nimbus Back Exit Mario Fall Animation"; break;
                        case 3764: eventLabels[i] = "Nimbus First Fall Room Load 2Nd Room"; break;
                        case 3765: eventLabels[i] = "Bean Valley Upper Chest Room Fall To Lower Chest Room"; break;
                        case 3766: eventLabels[i] = "Bean Valley Lower Chest Room Fall To Hot Springs Mezzanine"; break;
                        case 3767: eventLabels[i] = "Nimbus Castle Angled Plant Room Exit To 4 Path Room"; break;
                        case 3768: eventLabels[i] = "Nimbus Castle Main Hall Exit To 4 Way Path"; break;
                        case 3769: eventLabels[i] = "Nimbus Castle Liberated Bridge Room Loader"; break;
                        case 3770: eventLabels[i] = "Bean Valley 1St Vine Room Loader"; break;
                        case 3771: eventLabels[i] = "Samus"; break;
                        case 3772: eventLabels[i] = "Hot Springs Water"; break;
                        case 3773: eventLabels[i] = "Hot Springs Eject From Water"; break;
                        case 3774: eventLabels[i] = "Hot Springs Reset Ejection Timer"; break;
                        case 3775: eventLabels[i] = "Unused Nimbus Dialog"; break;
                        case 3776: eventLabels[i] = "Empty"; break;
                        case 3777: eventLabels[i] = "Royal Bus Platform Exit"; break;
                        case 3778: eventLabels[i] = "Ball Solitaire Set Puzzle"; break;
                        case 3779: eventLabels[i] = "Bean Valley 1St Vine Room Exit To 2Nd Vine Room"; break;
                        case 3780: eventLabels[i] = "Bean Valley 2Nd Vine Room Exit To East Vine Room"; break;
                        case 3781: eventLabels[i] = "Bean Valley East Vine Room Exit To Nimbus Mezzanine"; break;
                        case 3782: eventLabels[i] = "Bean Valley Upper Chest Room Fall To West Vine Room"; break;
                        case 3783: eventLabels[i] = "Bean Valley East Vine Room Exit To 2Nd Vine Room"; break;
                        case 3784: eventLabels[i] = "Bean Valley 2Nd Vine Room Exit To 1St Vine Room"; break;
                        case 3785: eventLabels[i] = "Bean Valley 1St Vine Room Exit To Ground Level"; break;
                        case 3786: eventLabels[i] = "Bean Valley West Vine Room Exit To Upper Chest Room"; break;
                        case 3787: eventLabels[i] = "Nimbus Mezzanine Fall To East Vine Room"; break;
                        case 3788: eventLabels[i] = "Bean Valley West Vine Room Summon Platform"; break;
                        case 3789: eventLabels[i] = "Bean Valley West Vine Room Platform"; break;
                        case 3790: eventLabels[i] = "Bean Valley 2Nd Vine Room Exit To West Vine Room"; break;
                        case 3791: eventLabels[i] = "Open Factory Final Boss Room"; break;
                        case 3792: eventLabels[i] = "Factory Final Boss Room Loader"; break;
                        case 3793: eventLabels[i] = "Factory Smelter Animation"; break;
                        case 3794: eventLabels[i] = "Factory Final Boss Fight"; break;
                        case 3795: eventLabels[i] = "Empty"; break;
                        case 3796: eventLabels[i] = "Empty"; break;
                        case 3797: eventLabels[i] = "Ending Credits Room Loader"; break;
                        case 3798: eventLabels[i] = "Ending Credits Orange Star"; break;
                        case 3799: eventLabels[i] = "Ending Credits Purple Star"; break;
                        case 3800: eventLabels[i] = "Ending Credits Indigo Star"; break;
                        case 3801: eventLabels[i] = "Ending Credits Red Star"; break;
                        case 3802: eventLabels[i] = "Ending Credits Yellow Star"; break;
                        case 3803: eventLabels[i] = "Ending Credits Green Star"; break;
                        case 3804: eventLabels[i] = "Ending Credits Coronation Npcs"; break;
                        case 3805: eventLabels[i] = "Ending Credits Coronation Loader"; break;
                        case 3806: eventLabels[i] = "Ending Credits Race Npcs"; break;
                        case 3807: eventLabels[i] = "Ending Credits Race Loader"; break;
                        case 3808: eventLabels[i] = "Ending Credits Race Audience"; break;
                        case 3809: eventLabels[i] = "Marrymore Sanctuary Begin Wedding Gear Sequence"; break;
                        case 3810: eventLabels[i] = "Empty"; break;
                        case 3811: eventLabels[i] = "Nimbus Inner Cellar Loader"; break;
                        case 3812: eventLabels[i] = "Empty"; break;
                        case 3813: eventLabels[i] = "Nimbus Inn Guest"; break;
                        case 3814: eventLabels[i] = "Mushroom Kingdom Liberated Loader"; break;
                        case 3815: eventLabels[i] = "Empty"; break;
                        case 3816: eventLabels[i] = "Empty"; break;
                        case 3817: eventLabels[i] = "Empty"; break;
                        case 3818: eventLabels[i] = "World Map Mushroom Way"; break;
                        case 3819: eventLabels[i] = "Lands End First Room Loader"; break;
                        case 3820: eventLabels[i] = "Forced Tower Boss 1 Fight"; break;
                        case 3821: eventLabels[i] = "Empty"; break;
                        case 3822: eventLabels[i] = "Rose Town Sign Item Granter"; break;
                        case 3823: eventLabels[i] = "Yoster Isle Goalpost Item Granter"; break;
                        case 3824: eventLabels[i] = "Yoster Isle Loader"; break;
                        case 3825: eventLabels[i] = "Nimbus Final Chest Room Platform Bit"; break;
                        case 3826: eventLabels[i] = "Empty"; break;
                        case 3827: eventLabels[i] = "Grant Item Standard Sound"; break;
                        case 3828: eventLabels[i] = "Empty"; break;
                        case 3829: eventLabels[i] = "Empty"; break;
                        case 3830: eventLabels[i] = "Mushroom Kingdom Shop Cellar Npc"; break;
                        case 3831: eventLabels[i] = "Mushroom Kingdom Shop Cellar Mod"; break;
                        case 3832: eventLabels[i] = "Empty"; break;
                        case 3833: eventLabels[i] = "Empty"; break;
                        case 3834: eventLabels[i] = "Empty"; break;
                        case 3835: eventLabels[i] = "Empty"; break;
                        case 3836: eventLabels[i] = "Empty"; break;
                        case 3837: eventLabels[i] = "Empty"; break;
                        case 3838: eventLabels[i] = "Keep Anti Softlock Trampoline"; break;
                        case 3839: eventLabels[i] = "Empty"; break;
                        case 3840: eventLabels[i] = "Starter Debug Items"; break;
                        case 3841: eventLabels[i] = "World Map Marios Pad"; break;
                        case 3842: eventLabels[i] = "Booster Hill Star Piece Signal"; break;
                        case 3843: eventLabels[i] = "World Map Mushroom Kingdom"; break;
                        case 3844: eventLabels[i] = "World Map Bandits Way"; break;
                        case 3845: eventLabels[i] = "World Map Kero Sewers"; break;
                        case 3846: eventLabels[i] = "World Map Midas River"; break;
                        case 3847: eventLabels[i] = "World Map Tadpole Pond"; break;
                        case 3848: eventLabels[i] = "World Map Pipe Vault"; break;
                        case 3849: eventLabels[i] = "World Map Rose Way"; break;
                        case 3850: eventLabels[i] = "World Map Rose Town"; break;
                        case 3851: eventLabels[i] = "World Map Forest Maze"; break;
                        case 3852: eventLabels[i] = "World Map Yoster Isle"; break;
                        case 3853: eventLabels[i] = "World Map Moleville"; break;
                        case 3854: eventLabels[i] = "World Map Booster Pass"; break;
                        case 3855: eventLabels[i] = "World Map Booster Tower"; break;
                        case 3856: eventLabels[i] = "World Map Marrymore"; break;
                        case 3857: eventLabels[i] = "World Map Star Hill"; break;
                        case 3858: eventLabels[i] = "World Map Seaside Town"; break;
                        case 3859: eventLabels[i] = "World Map Sea"; break;
                        case 3860: eventLabels[i] = "World Map Ship"; break;
                        case 3861: eventLabels[i] = "World Map Lands End"; break;
                        case 3862: eventLabels[i] = "World Map Montro Town"; break;
                        case 3863: eventLabels[i] = "World Map Bean Valley"; break;
                        case 3864: eventLabels[i] = "World Map Nimbus Land"; break;
                        case 3865: eventLabels[i] = "World Map Barrel Volcano"; break;
                        case 3866: eventLabels[i] = "World Map Vista Hill"; break;
                        case 3867: eventLabels[i] = "World Map Booster Hill"; break;
                        case 3868: eventLabels[i] = "World Map Bowsers Keep"; break;
                        case 3869: eventLabels[i] = "World Map Abyss"; break;
                        case 3870: eventLabels[i] = "World Map Grate Guys Casino"; break;
                        case 3871: eventLabels[i] = "Nimbus Castle Two Chest Room Guard"; break;
                        case 3872: eventLabels[i] = "Nimbus Castle 5 Door Room Left Guard"; break;
                        case 3873: eventLabels[i] = "Nimbus Castle 5 Door Room Right Guard"; break;
                        case 3874: eventLabels[i] = "Nimbus Castle Bridge Room Guard"; break;
                        case 3875: eventLabels[i] = "Nimbus Unused Dialog"; break;
                        case 3876: eventLabels[i] = "Nimbus Castlle 4 Way Path Left Guard"; break;
                        case 3877: eventLabels[i] = "Nimbus Castle Two Chest Room Upper Chest"; break;
                        case 3878: eventLabels[i] = "Casino Trampoline"; break;
                        case 3879: eventLabels[i] = "Nimbus Castle Bridge Room Chest"; break;
                        case 3880: eventLabels[i] = "Sea Chests"; break;
                        case 3881: eventLabels[i] = "Chest Differentiator Npc 1 Or Other"; break;
                        case 3882: eventLabels[i] = "Chest Differentiator Npc 3 4 Or Other"; break;
                        case 3883: eventLabels[i] = "Inner Factory Exit Trampoline"; break;
                        case 3884: eventLabels[i] = "Ball Solitaire Set Puzzle Configuration Value"; break;
                        case 3885: eventLabels[i] = "End Game"; break;
                        case 3886: eventLabels[i] = "End Game Container From Alt Win Conditions"; break;
                        case 3887: eventLabels[i] = "Marios Pad Star Piece Signal"; break;
                        case 3888: eventLabels[i] = "Mushroom Way Star Piece Signal"; break;
                        case 3889: eventLabels[i] = "Mushroom Kingdom Star Piece Signal"; break;
                        case 3890: eventLabels[i] = "Bandits Way Star Piece Signal"; break;
                        case 3891: eventLabels[i] = "Sewers Star Piece Signal"; break;
                        case 3892: eventLabels[i] = "Midas River Star Piece Signal"; break;
                        case 3893: eventLabels[i] = "Tadpole Pond Star Piece Signal"; break;
                        case 3894: eventLabels[i] = "Rose Way Star Piece Signal"; break;
                        case 3895: eventLabels[i] = "Rose Town Star Piece Signal"; break;
                        case 3896: eventLabels[i] = "Forest Maze Star Piece Signal"; break;
                        case 3897: eventLabels[i] = "Moleville Star Piece Signal"; break;
                        case 3898: eventLabels[i] = "Booster Pass Star Piece Signal"; break;
                        case 3899: eventLabels[i] = "Booster Tower Star Piece Signal"; break;
                        case 3900: eventLabels[i] = "Pipe Vault Star Piece Signal"; break;
                        case 3901: eventLabels[i] = "Yoster Isle Star Piece Signal"; break;
                        case 3902: eventLabels[i] = "Marrymore Star Piece Signal"; break;
                        case 3903: eventLabels[i] = "Star Hill Star Piece Signal"; break;
                        case 3904: eventLabels[i] = "Seaside Town Star Piece Signal"; break;
                        case 3905: eventLabels[i] = "Sea Star Piece Signal"; break;
                        case 3906: eventLabels[i] = "Ship Star Piece Signal"; break;
                        case 3907: eventLabels[i] = "Lands End Star Piece Signal"; break;
                        case 3908: eventLabels[i] = "Temple Star Piece Signal"; break;
                        case 3909: eventLabels[i] = "Monstro Star Piece Signal"; break;
                        case 3910: eventLabels[i] = "Casino Star Piece Signal"; break;
                        case 3911: eventLabels[i] = "Bean Valley Star Piece Signal"; break;
                        case 3912: eventLabels[i] = "Nimbus Star Piece Signal"; break;
                        case 3913: eventLabels[i] = "Volcano Star Piece Signal"; break;
                        case 3914: eventLabels[i] = "Keep Star Piece Signal"; break;
                        case 3915: eventLabels[i] = "Factory Star Piece Signal"; break;
                        case 3916: eventLabels[i] = "Inner Factory Star Piece Signal"; break;
                        case 3917: eventLabels[i] = "Rose Way Back Entrance Loader"; break;
                        case 3918: eventLabels[i] = "Forest Maze Entrance Loader"; break;
                        case 3919: eventLabels[i] = "Booster Pass Back Entrance Loader"; break;
                        case 3920: eventLabels[i] = "Sea Save Room Loader"; break;
                        case 3921: eventLabels[i] = "Ship First Save Room Loader"; break;
                        case 3922: eventLabels[i] = "Temple Set Signal Ring Directional Bit"; break;
                        case 3923: eventLabels[i] = "Volcano Save Room Loader"; break;
                        case 3924: eventLabels[i] = "Keep 1St Save Room Loader"; break;
                        case 3925: eventLabels[i] = "Factory Save Room Loaders"; break;
                        case 3926: eventLabels[i] = "Temple Back Entrance"; break;
                        case 3927: eventLabels[i] = "Nimbus Castle Exit Hallway Save Room Loader"; break;
                        case 3928: eventLabels[i] = "Nimbus Castlle 4 Way Path Right Guard"; break;
                        case 3929: eventLabels[i] = "Lands End Purchasable Chest 2 Subroutine"; break;
                        case 3930: eventLabels[i] = "Marrymore Gear Preloader"; break;
                        case 3931: eventLabels[i] = "Get Shoes"; break;
                        case 3932: eventLabels[i] = "Get Brooch"; break;
                        case 3933: eventLabels[i] = "Get Ring"; break;
                        case 3934: eventLabels[i] = "Get Crown"; break;
                        case 3935: eventLabels[i] = "Freestanding Shoes"; break;
                        case 3936: eventLabels[i] = "Freestanding Brooch"; break;
                        case 3937: eventLabels[i] = "Freestanding Ring"; break;
                        case 3938: eventLabels[i] = "Freestanding Crown"; break;
                        case 3939: eventLabels[i] = "River Shoes"; break;
                        case 3940: eventLabels[i] = "River Brooch"; break;
                        case 3941: eventLabels[i] = "River Ring"; break;
                        case 3942: eventLabels[i] = "River Crown"; break;
                        case 3943: eventLabels[i] = "Shoes Chest"; break;
                        case 3944: eventLabels[i] = "Brooch Chest"; break;
                        case 3945: eventLabels[i] = "Ring Chest"; break;
                        case 3946: eventLabels[i] = "Crown Chest"; break;
                        case 3947: eventLabels[i] = "Empty"; break;
                        case 3948: eventLabels[i] = "Empty"; break;
                        case 3949: eventLabels[i] = "Empty"; break;
                        case 3950: eventLabels[i] = "Post Final Boss Init"; break;
                        case 3951: eventLabels[i] = "Star Piece Credits Init"; break;
                        case 3952: eventLabels[i] = "Clone Reserved"; break;
                        case 3953: eventLabels[i] = "Clone Reserved"; break;
                        case 3954: eventLabels[i] = "Clone Reserved"; break;
                        case 3955: eventLabels[i] = "Clone Reserved"; break;
                        case 3956: eventLabels[i] = "Clone Reserved"; break;
                        case 3957: eventLabels[i] = "Clone Reserved"; break;
                        case 3958: eventLabels[i] = "Clone Reserved"; break;
                        case 3959: eventLabels[i] = "Clone Reserved"; break;
                        case 3960: eventLabels[i] = "Clone Reserved"; break;
                        case 3961: eventLabels[i] = "Clone Reserved"; break;
                        case 3962: eventLabels[i] = "Clone Reserved"; break;
                        case 3963: eventLabels[i] = "Clone Reserved"; break;
                        case 3964: eventLabels[i] = "Clone Reserved"; break;
                        case 3965: eventLabels[i] = "Clone Reserved"; break;
                        case 3966: eventLabels[i] = "Clone Reserved"; break;
                        case 3967: eventLabels[i] = "Clone Reserved"; break;
                        case 3968: eventLabels[i] = "Clone Reserved"; break;
                        case 3969: eventLabels[i] = "Clone Reserved"; break;
                        case 3970: eventLabels[i] = "Clone Reserved"; break;
                        case 3971: eventLabels[i] = "Clone Reserved"; break;
                        case 3972: eventLabels[i] = "Clone Reserved"; break;
                        case 3973: eventLabels[i] = "Clone Reserved"; break;
                        case 3974: eventLabels[i] = "Clone Reserved"; break;
                        case 3975: eventLabels[i] = "Clone Reserved"; break;
                        case 3976: eventLabels[i] = "Clone Reserved"; break;
                        case 3977: eventLabels[i] = "Clone Reserved"; break;
                        case 3978: eventLabels[i] = "Clone Reserved"; break;
                        case 3979: eventLabels[i] = "Clone Reserved"; break;
                        case 3980: eventLabels[i] = "Clone Reserved"; break;
                        case 3981: eventLabels[i] = "Clone Reserved"; break;
                        case 3982: eventLabels[i] = "Clone Reserved"; break;
                        case 3983: eventLabels[i] = "Clone Reserved"; break;
                        case 3984: eventLabels[i] = "Clone Reserved"; break;
                        case 3985: eventLabels[i] = "Clone Reserved"; break;
                        case 3986: eventLabels[i] = "Clone Reserved"; break;
                        case 3987: eventLabels[i] = "Clone Reservedclone Reserved"; break;
                        case 3988: eventLabels[i] = "Clone Reserved"; break;
                        case 3989: eventLabels[i] = "Clone Reserved"; break;
                        case 3990: eventLabels[i] = "Clone Reserved"; break;
                        case 3991: eventLabels[i] = "Clone Reserved"; break;
                        case 3992: eventLabels[i] = "Clone Reserved"; break;
                        case 3993: eventLabels[i] = "Clone Reserved"; break;
                        case 3994: eventLabels[i] = "Clone Reserved"; break;
                        case 3995: eventLabels[i] = "Clone Reserved"; break;
                        case 3996: eventLabels[i] = "Clone Reserved"; break;
                        case 3997: eventLabels[i] = "Clone Reserved"; break;
                        case 3998: eventLabels[i] = "Clone Reserved"; break;
                        case 3999: eventLabels[i] = "Clone Reserved"; break;
                        case 4000: eventLabels[i] = "Clone Reserved"; break;
                        case 4001: eventLabels[i] = "Clone Reserved"; break;
                        case 4002: eventLabels[i] = "Clone Reserved"; break;
                        case 4003: eventLabels[i] = "Clone Reserved"; break;
                        case 4004: eventLabels[i] = "Clone Reserved"; break;
                        case 4005: eventLabels[i] = "Clone Reserved"; break;
                        case 4006: eventLabels[i] = "Clone Reserved"; break;
                        case 4007: eventLabels[i] = "Clone Reserved"; break;
                        case 4008: eventLabels[i] = "Clone Reserved"; break;
                        case 4009: eventLabels[i] = "Clone Reserved"; break;
                        case 4010: eventLabels[i] = "Clone Reserved"; break;
                        case 4011: eventLabels[i] = "Clone Reserved"; break;
                        case 4012: eventLabels[i] = "Clone Reserved"; break;
                        case 4013: eventLabels[i] = "Clone Reserved"; break;
                        case 4014: eventLabels[i] = "Clone Reserved"; break;
                        case 4015: eventLabels[i] = "Clone Reserved"; break;
                        case 4016: eventLabels[i] = "Clone Reserved"; break;
                        case 4017: eventLabels[i] = "Clone Reserved"; break;
                        case 4018: eventLabels[i] = "Clone Reserved"; break;
                        case 4019: eventLabels[i] = "Clone Reserved"; break;
                        case 4020: eventLabels[i] = "Clone Reserved"; break;
                        case 4021: eventLabels[i] = "Clone Reserved"; break;
                        case 4022: eventLabels[i] = "Clone Reserved"; break;
                        case 4023: eventLabels[i] = "Clone Reserved"; break;
                        case 4024: eventLabels[i] = "Clone Reserved"; break;
                        case 4025: eventLabels[i] = "Clone Reserved"; break;
                        case 4026: eventLabels[i] = "Clone Reserved"; break;
                        case 4027: eventLabels[i] = "Clone Reserved"; break;
                        case 4028: eventLabels[i] = "Clone Reserved"; break;
                        case 4029: eventLabels[i] = "Clone Reserved"; break;
                        case 4030: eventLabels[i] = "Clone Reserved"; break;
                        case 4031: eventLabels[i] = "Clone Reserved"; break;
                        case 4032: eventLabels[i] = "Clone Reserved"; break;
                        case 4033: eventLabels[i] = "Clone Reserved"; break;
                        case 4034: eventLabels[i] = "Clone Reserved"; break;
                        case 4035: eventLabels[i] = "Clone Reserved"; break;
                        case 4036: eventLabels[i] = "Clone Reserved"; break;
                        case 4037: eventLabels[i] = "Clone Reserved"; break;
                        case 4038: eventLabels[i] = "Clone Reserved"; break;
                        case 4039: eventLabels[i] = "Clone Reserved"; break;
                        case 4040: eventLabels[i] = "Clone Reserved"; break;
                        case 4041: eventLabels[i] = "Clone Reserved"; break;
                        case 4042: eventLabels[i] = "Clone Reserved"; break;
                        case 4043: eventLabels[i] = "Clone Reserved"; break;
                        case 4044: eventLabels[i] = "Clone Reserved"; break;
                        case 4045: eventLabels[i] = "Clone Reserved"; break;
                        case 4046: eventLabels[i] = "Clone Reserved"; break;
                        case 4047: eventLabels[i] = "Clone Reserved"; break;
                        case 4048: eventLabels[i] = "Clone Reserved"; break;
                        case 4049: eventLabels[i] = "Clone Reserved"; break;
                        case 4050: eventLabels[i] = "Clone Reserved"; break;
                        case 4051: eventLabels[i] = "Clone Reserved"; break;
                        case 4052: eventLabels[i] = "Clone Reserved"; break;
                        case 4053: eventLabels[i] = "Clone Reserved"; break;
                        case 4054: eventLabels[i] = "Clone Reserved"; break;
                        case 4055: eventLabels[i] = "Clone Reserved"; break;
                        case 4056: eventLabels[i] = "Clone Reserved"; break;
                        case 4057: eventLabels[i] = "Clone Reserved"; break;
                        case 4058: eventLabels[i] = "Clone Reserved"; break;
                        case 4059: eventLabels[i] = "Clone Reserved"; break;
                        case 4060: eventLabels[i] = "Clone Reserved"; break;
                        case 4061: eventLabels[i] = "Clone Reserved"; break;
                        case 4062: eventLabels[i] = "Clone Reserved"; break;
                        case 4063: eventLabels[i] = "Clone Reserved"; break;
                        case 4064: eventLabels[i] = "Clone Reserved"; break;
                        case 4065: eventLabels[i] = "Clone Reserved"; break;
                        case 4066: eventLabels[i] = "Clone Reserved"; break;
                        case 4067: eventLabels[i] = "Clone Reserved"; break;
                        case 4068: eventLabels[i] = "Clone Reserved"; break;
                        case 4069: eventLabels[i] = "Clone Reserved"; break;
                        case 4070: eventLabels[i] = "Clone Reserved"; break;
                        case 4071: eventLabels[i] = "Clone Reserved"; break;
                        case 4072: eventLabels[i] = "Clone Reserved"; break;
                        case 4073: eventLabels[i] = "Clone Reserved"; break;
                        case 4074: eventLabels[i] = "Clone Reserved"; break;
                        case 4075: eventLabels[i] = "Clone Reserved"; break;
                        case 4076: eventLabels[i] = "Clone Reserved"; break;
                        case 4077: eventLabels[i] = "Clone Reserved"; break;
                        case 4078: eventLabels[i] = "Clone Reserved"; break;
                        case 4079: eventLabels[i] = "Clone Reserved"; break;
                        case 4080: eventLabels[i] = "Clone Reserved"; break;
                        case 4081: eventLabels[i] = "Clone Reserved"; break;
                        case 4082: eventLabels[i] = "Clone Reserved"; break;
                        case 4083: eventLabels[i] = "Clone Reserved"; break;
                        case 4084: eventLabels[i] = "Clone Reserved"; break;
                        case 4085: eventLabels[i] = "Clone Reserved"; break;
                        case 4086: eventLabels[i] = "Clone Reserved"; break;
                        case 4087: eventLabels[i] = "Clone Reserved"; break;
                        case 4088: eventLabels[i] = "Clone Reserved"; break;
                        case 4089: eventLabels[i] = "Clone Reserved"; break;
                        case 4090: eventLabels[i] = "Clone Reserved"; break;
                        case 4091: eventLabels[i] = "Clone Reserved"; break;
                        case 4092: eventLabels[i] = "Clone Reserved"; break;
                        case 4093: eventLabels[i] = "Clone Reserved"; break;
                        case 4094: eventLabels[i] = "Clone Reserved"; break;
                        case 4095: eventLabels[i] = "Clone Reserved"; break;
                        default: eventLabels[i] = ""; break;
                    }
                }
                RomConfig.ApplyCustomLabels(eventLabels, Properties.Settings.Default.CustomEventLabels);
                return eventLabels;
            }
            set
            {
                eventLabels = value;
            }
        }
        public static string[] ActionLabels
        {
            get
            {
                if (actionLabels.Length == 1024)
                    return actionLabels;
                actionLabels = new string[1024];
                for (int i = 0; i < actionLabels.Length; i++)
                {
                    switch (i)
                    {
                        case 0: eventLabels[i] = "Empty"; break;
                        case 1: eventLabels[i] = "Empty"; break;
                        case 2: eventLabels[i] = "Empty"; break;
                        case 3: eventLabels[i] = "Empty"; break;
                        case 4: eventLabels[i] = "Launch Prologue"; break;
                        case 5: eventLabels[i] = "Set 70A7 To Random Tier 1 Consumable"; break;
                        case 6: eventLabels[i] = "Set 70A7 To Random Tier 2 Consumable"; break;
                        case 7: eventLabels[i] = "Set 70A7 To Random Tier 3 Consumable"; break;
                        case 8: eventLabels[i] = "Set 70A7 To Random Tier 4 Consumable"; break;
                        case 9: eventLabels[i] = "Set 70A7 To Random Tier 1 Equip"; break;
                        case 10: eventLabels[i] = "Set 70A7 To Random Tier 2 Equip"; break;
                        case 11: eventLabels[i] = "Set 70A7 To Random Tier 3 Equip"; break;
                        case 12: eventLabels[i] = "Set 70A7 To Random Tier 4 Equip"; break;
                        case 13: eventLabels[i] = "Base Rom Only Fix Map And Party"; break;
                        case 14: eventLabels[i] = "Standard Room Loader"; break;
                        case 15: eventLabels[i] = "Standard Room Loader"; break;
                        case 16: eventLabels[i] = "Fight Remove Permanently"; break;
                        case 17: eventLabels[i] = "Fight Remove Temporarily"; break;
                        case 18: eventLabels[i] = "Fight Do Not Remove"; break;
                        case 19: eventLabels[i] = "Fight Remove Permanently Blink On Run"; break;
                        case 20: eventLabels[i] = "Fight Remove Temporarily Blink On Run"; break;
                        case 21: eventLabels[i] = "Forest Maze Mushroom Grant"; break;
                        case 22: eventLabels[i] = "Better Tip Granter"; break;
                        case 23: eventLabels[i] = "Mushroom Selection"; break;
                        case 24: eventLabels[i] = "Battle Result Check"; break;
                        case 25: eventLabels[i] = "Battle Result Check Blinking"; break;
                        case 26: eventLabels[i] = "Grant Tier 1 Consumable Or Equip"; break;
                        case 27: eventLabels[i] = "Grant Tier 2 Consumable Or Equip"; break;
                        case 28: eventLabels[i] = "Grant Tier 3 Consumable Or Equip"; break;
                        case 29: eventLabels[i] = "Grant Tier 4 Consumable Or Equip"; break;
                        case 30: eventLabels[i] = "Empty"; break;
                        case 31: eventLabels[i] = "Empty"; break;
                        case 32: eventLabels[i] = "Non Coin Chest Container"; break;
                        case 33: eventLabels[i] = "Open Chest"; break;
                        case 34: eventLabels[i] = "Coin Chest Container"; break;
                        case 35: eventLabels[i] = "Mimic Or Slot Chest Container"; break;
                        case 36: eventLabels[i] = "Grant Any Consumable"; break;
                        case 37: eventLabels[i] = "Grant Any Equip"; break;
                        case 38: eventLabels[i] = "Grant Any Consumable Or Equip"; break;
                        case 39: eventLabels[i] = "Grant Any Consumable Or Equip Tier 3 Cap"; break;
                        case 40: eventLabels[i] = "Grant Any Equip Tier 3 Cap"; break;
                        case 41: eventLabels[i] = "Grant Any Consumable Tier 3 Cap"; break;
                        case 42: eventLabels[i] = "Grant Any Consumable Tier 2 Cap"; break;
                        case 43: eventLabels[i] = "Grant Any Equip Tier 2 Cap"; break;
                        case 44: eventLabels[i] = "Grant Any Consumable Or Equip Tier 2 Cap"; break;
                        case 45: eventLabels[i] = "Grant Any Consumable Exclude Worst"; break;
                        case 46: eventLabels[i] = "Grant Any Equip Exclude Worst"; break;
                        case 47: eventLabels[i] = "Grant Any Consumable Or Equip Exclude Worst"; break;
                        case 48: eventLabels[i] = "Grant Any Consumable Exclude Worst Tier 3 Cap"; break;
                        case 49: eventLabels[i] = "Grant Any Equip Exclude Worst Tier 3 Cap"; break;
                        case 50: eventLabels[i] = "Grant Any Equip Or Consumable Exclude Worst Tier 3 Cap"; break;
                        case 51: eventLabels[i] = "Empty"; break;
                        case 52: eventLabels[i] = "Empty"; break;
                        case 53: eventLabels[i] = "Empty"; break;
                        case 54: eventLabels[i] = "Empty"; break;
                        case 55: eventLabels[i] = "Empty"; break;
                        case 56: eventLabels[i] = "Empty"; break;
                        case 57: eventLabels[i] = "Empty"; break;
                        case 58: eventLabels[i] = "Empty"; break;
                        case 59: eventLabels[i] = "Empty"; break;
                        case 60: eventLabels[i] = "Empty"; break;
                        case 61: eventLabels[i] = "Empty"; break;
                        case 62: eventLabels[i] = "Empty"; break;
                        case 63: eventLabels[i] = "Empty"; break;
                        case 64: eventLabels[i] = "Empty"; break;
                        case 65: eventLabels[i] = "Trampoline Subroutine"; break;
                        case 66: eventLabels[i] = "Pipe Down Subroutine"; break;
                        case 67: eventLabels[i] = "Empty"; break;
                        case 68: eventLabels[i] = "Empty"; break;
                        case 69: eventLabels[i] = "Empty"; break;
                        case 70: eventLabels[i] = "Empty"; break;
                        case 71: eventLabels[i] = "Empty"; break;
                        case 72: eventLabels[i] = "Empty"; break;
                        case 73: eventLabels[i] = "Empty"; break;
                        case 74: eventLabels[i] = "Empty"; break;
                        case 75: eventLabels[i] = "Empty"; break;
                        case 76: eventLabels[i] = "Empty"; break;
                        case 77: eventLabels[i] = "Empty"; break;
                        case 78: eventLabels[i] = "Unknown"; break;
                        case 79: eventLabels[i] = "Unknown"; break;
                        case 80: eventLabels[i] = "Save Block Subroutine"; break;
                        case 81: eventLabels[i] = "Mario Lands Subroutine"; break;
                        case 82: eventLabels[i] = "Three Musty Fears Greaper Dialog"; break;
                        case 83: eventLabels[i] = "Three Musty Fears Boo Dialog"; break;
                        case 84: eventLabels[i] = "Three Musty Fears Bones Dialog"; break;
                        case 85: eventLabels[i] = "Invisible Item Check 1"; break;
                        case 86: eventLabels[i] = "Invisible Item Check 2"; break;
                        case 87: eventLabels[i] = "Invisible Item Check 3"; break;
                        case 88: eventLabels[i] = "Invisible Item Check 1 Container"; break;
                        case 89: eventLabels[i] = "Invisible Item Check 2 Container"; break;
                        case 90: eventLabels[i] = "Invisible Item Check 3 Container"; break;
                        case 91: eventLabels[i] = "Invisible Item Summoner"; break;
                        case 92: eventLabels[i] = "Pipe Vault Closed Note"; break;
                        case 93: eventLabels[i] = "Background Event For Slot Machine"; break;
                        case 94: eventLabels[i] = "Out Of Order Note"; break;
                        case 95: eventLabels[i] = "Revert All Clone Chests Mimic 1"; break;
                        case 96: eventLabels[i] = "Revert All Clone Chests Mimic 2"; break;
                        case 97: eventLabels[i] = "Empty"; break;
                        case 98: eventLabels[i] = "Empty"; break;
                        case 99: eventLabels[i] = "Empty"; break;
                        case 100: eventLabels[i] = "Empty"; break;
                        case 101: eventLabels[i] = "Empty"; break;
                        case 102: eventLabels[i] = "Empty"; break;
                        case 103: eventLabels[i] = "Empty"; break;
                        case 104: eventLabels[i] = "Empty"; break;
                        case 105: eventLabels[i] = "Empty"; break;
                        case 106: eventLabels[i] = "Empty"; break;
                        case 107: eventLabels[i] = "Empty"; break;
                        case 108: eventLabels[i] = "Empty"; break;
                        case 109: eventLabels[i] = "Empty"; break;
                        case 110: eventLabels[i] = "Empty"; break;
                        case 111: eventLabels[i] = "Empty"; break;
                        case 112: eventLabels[i] = "Empty"; break;
                        case 113: eventLabels[i] = "Empty"; break;
                        case 114: eventLabels[i] = "Empty"; break;
                        case 115: eventLabels[i] = "Empty"; break;
                        case 116: eventLabels[i] = "Empty"; break;
                        case 117: eventLabels[i] = "Empty"; break;
                        case 118: eventLabels[i] = "Empty"; break;
                        case 119: eventLabels[i] = "Empty"; break;
                        case 120: eventLabels[i] = "Empty"; break;
                        case 121: eventLabels[i] = "Empty"; break;
                        case 122: eventLabels[i] = "Empty"; break;
                        case 123: eventLabels[i] = "Empty"; break;
                        case 124: eventLabels[i] = "Empty"; break;
                        case 125: eventLabels[i] = "Empty"; break;
                        case 126: eventLabels[i] = "Empty"; break;
                        case 127: eventLabels[i] = "Empty"; break;
                        case 128: eventLabels[i] = "Abort Attract Mode"; break;
                        case 129: eventLabels[i] = "Empty"; break;
                        case 130: eventLabels[i] = "Empty"; break;
                        case 131: eventLabels[i] = "Empty"; break;
                        case 132: eventLabels[i] = "Empty"; break;
                        case 133: eventLabels[i] = "Empty"; break;
                        case 134: eventLabels[i] = "Empty"; break;
                        case 135: eventLabels[i] = "Empty"; break;
                        case 136: eventLabels[i] = "Empty"; break;
                        case 137: eventLabels[i] = "Empty"; break;
                        case 138: eventLabels[i] = "Empty"; break;
                        case 139: eventLabels[i] = "Empty"; break;
                        case 140: eventLabels[i] = "Empty"; break;
                        case 141: eventLabels[i] = "Empty"; break;
                        case 142: eventLabels[i] = "Empty"; break;
                        case 143: eventLabels[i] = "Empty"; break;
                        case 144: eventLabels[i] = "Empty"; break;
                        case 145: eventLabels[i] = "Empty"; break;
                        case 146: eventLabels[i] = "Empty"; break;
                        case 147: eventLabels[i] = "Empty"; break;
                        case 148: eventLabels[i] = "Empty"; break;
                        case 149: eventLabels[i] = "Empty"; break;
                        case 150: eventLabels[i] = "Empty"; break;
                        case 151: eventLabels[i] = "Empty"; break;
                        case 152: eventLabels[i] = "Empty"; break;
                        case 153: eventLabels[i] = "Empty"; break;
                        case 154: eventLabels[i] = "Npc Quest 7 Container"; break;
                        case 155: eventLabels[i] = "Packet Decider Container"; break;
                        case 156: eventLabels[i] = "Packet Decider"; break;
                        case 157: eventLabels[i] = "Npc Quest Grant 1 Frog Coin"; break;
                        case 158: eventLabels[i] = "Npc Quest Grant Multi Frog Coin"; break;
                        case 159: eventLabels[i] = "Npc Quest Grant Coins"; break;
                        case 160: eventLabels[i] = "Npc Quest Grant Item"; break;
                        case 161: eventLabels[i] = "Npc Quest Grant Beetlemania"; break;
                        case 162: eventLabels[i] = "Chest Grant Beetlemania"; break;
                        case 163: eventLabels[i] = "Chest Grant Star Piece"; break;
                        case 164: eventLabels[i] = "Npc Quest Grant Star Piece"; break;
                        case 165: eventLabels[i] = "Freestanding Grant Item Bag"; break;
                        case 166: eventLabels[i] = "Freestanding Grant Star Piece"; break;
                        case 167: eventLabels[i] = "Boss Grant Star Piece"; break;
                        case 168: eventLabels[i] = "Boss Grant Star Piece Container"; break;
                        case 169: eventLabels[i] = "Mimic 1 Grant Star Piece Container"; break;
                        case 170: eventLabels[i] = "Mimic 2 Grant Star Piece Container"; break;
                        case 171: eventLabels[i] = "Mimic 3 Grant Star Piece Container"; break;
                        case 172: eventLabels[i] = "Chest 1 Container"; break;
                        case 173: eventLabels[i] = "Chest 2 Container"; break;
                        case 174: eventLabels[i] = "Chest 3 Container"; break;
                        case 175: eventLabels[i] = "Chest 4 Container"; break;
                        case 176: eventLabels[i] = "Chest 5 Container"; break;
                        case 177: eventLabels[i] = "Chest 6 Container"; break;
                        case 178: eventLabels[i] = "Npc Quest 1 Container"; break;
                        case 179: eventLabels[i] = "Npc Quest 2 Container"; break;
                        case 180: eventLabels[i] = "Npc Quest 3 Container"; break;
                        case 181: eventLabels[i] = "Npc Quest 4 Container"; break;
                        case 182: eventLabels[i] = "Npc Quest 5 Container"; break;
                        case 183: eventLabels[i] = "Npc Quest 6 Container"; break;
                        case 184: eventLabels[i] = "Npc Quest Grant Single Fireworks"; break;
                        case 185: eventLabels[i] = "Npc Quest Grant Progressive Fireworks"; break;
                        case 186: eventLabels[i] = "Party Join Logic"; break;
                        case 187: eventLabels[i] = "Mario Joins"; break;
                        case 188: eventLabels[i] = "Mallow Joins"; break;
                        case 189: eventLabels[i] = "Geno Joins"; break;
                        case 190: eventLabels[i] = "Bowser Joins"; break;
                        case 191: eventLabels[i] = "Toadstool Joins"; break;
                        case 192: eventLabels[i] = "Gating And Party Join Logic"; break;
                        case 193: eventLabels[i] = "Mario Joins Container"; break;
                        case 194: eventLabels[i] = "Mallow Joins Container"; break;
                        case 195: eventLabels[i] = "Geno Joins Container"; break;
                        case 196: eventLabels[i] = "Bowser Joins Container"; break;
                        case 197: eventLabels[i] = "Toadstool Joins Container"; break;
                        case 198: eventLabels[i] = "Unlock Tower If Gated By Moleville"; break;
                        case 199: eventLabels[i] = "Unlock Bandits If Gated By Mushroom Way"; break;
                        case 200: eventLabels[i] = "Unlock Forest If Gated By Marrymore Character"; break;
                        case 201: eventLabels[i] = "Unlock Forest If Gated By Moleville Character"; break;
                        case 202: eventLabels[i] = "Unlock Forest If Gated By Mushroom Way Character"; break;
                        case 203: eventLabels[i] = "Unlock Forest If Gated By Cricket Pie"; break;
                        case 204: eventLabels[i] = "Unlock Marrymore If Gated By Booster Hill"; break;
                        case 205: eventLabels[i] = "Unlock Marrymore If Gated By Tower Boss"; break;
                        case 206: eventLabels[i] = "Unlock Sea If Gated By Star Pieces"; break;
                        case 207: eventLabels[i] = "Unlock Keep If Gated By Star Pieces"; break;
                        case 208: eventLabels[i] = "Unlock Keep If Gated By Volcano Boss"; break;
                        case 209: eventLabels[i] = "Unlock Switch Menu If Enough Members"; break;
                        case 210: eventLabels[i] = "Unlock Seaside Boss If Gated By Ship Boss"; break;
                        case 211: eventLabels[i] = "Unlock Pipe Vault If Gated By Forest Maze"; break;
                        case 212: eventLabels[i] = "Npc Quest 7 Container"; break;
                        case 213: eventLabels[i] = "Booster Hill Prize Container Event"; break;
                        case 214: eventLabels[i] = "Hill Get Flower"; break;
                        case 215: eventLabels[i] = "Hill Item"; break;
                        case 216: eventLabels[i] = "Get Flower From Npc"; break;
                        case 217: eventLabels[i] = "Hill Fireworks"; break;
                        case 218: eventLabels[i] = "Hill Beetlemania"; break;
                        case 219: eventLabels[i] = "Hill Grant Logic"; break;
                        case 220: eventLabels[i] = "Empty"; break;
                        case 221: eventLabels[i] = "Empty"; break;
                        case 222: eventLabels[i] = "Empty"; break;
                        case 223: eventLabels[i] = "Empty"; break;
                        case 224: eventLabels[i] = "Empty"; break;
                        case 225: eventLabels[i] = "Check Voucher Unlock"; break;
                        case 226: eventLabels[i] = "Npc Quest 7 Grant"; break;
                        case 227: eventLabels[i] = "Freestanding 15 Grant"; break;
                        case 228: eventLabels[i] = "Freestanding 14 Grant"; break;
                        case 229: eventLabels[i] = "Freestanding 13 Grant"; break;
                        case 230: eventLabels[i] = "Freestanding 12 Grant"; break;
                        case 231: eventLabels[i] = "Freestanding 11 Grant"; break;
                        case 232: eventLabels[i] = "Freestanding 10 Grant"; break;
                        case 233: eventLabels[i] = "Freestanding 9 Grant"; break;
                        case 234: eventLabels[i] = "Freestanding 8 Grant"; break;
                        case 235: eventLabels[i] = "Freestanding 7 Grant"; break;
                        case 236: eventLabels[i] = "Freestanding 6 Grant"; break;
                        case 237: eventLabels[i] = "Freestanding 5 Grant"; break;
                        case 238: eventLabels[i] = "Freestanding 4 Grant"; break;
                        case 239: eventLabels[i] = "Freestanding 3 Grant"; break;
                        case 240: eventLabels[i] = "Freestanding 2 Grant"; break;
                        case 241: eventLabels[i] = "Freestanding 1 Grant"; break;
                        case 242: eventLabels[i] = "Chest 6 Grant"; break;
                        case 243: eventLabels[i] = "Chest 5 Grant"; break;
                        case 244: eventLabels[i] = "Chest 4 Grant"; break;
                        case 245: eventLabels[i] = "Chest 3 Grant"; break;
                        case 246: eventLabels[i] = "Chest 2 Grant"; break;
                        case 247: eventLabels[i] = "Chest 1 Grant"; break;
                        case 248: eventLabels[i] = "Npc Quest 6 Grant"; break;
                        case 249: eventLabels[i] = "Npc Quest 5 Grant"; break;
                        case 250: eventLabels[i] = "Npc Quest 4 Grant"; break;
                        case 251: eventLabels[i] = "Npc Quest 3 Grant"; break;
                        case 252: eventLabels[i] = "Npc Quest 2 Grant"; break;
                        case 253: eventLabels[i] = "Npc Quest 1 Grant"; break;
                        case 254: eventLabels[i] = "Exp Star Hit Subroutine"; break;
                        case 255: eventLabels[i] = "Exp Star Hit"; break;
                        case 256: eventLabels[i] = "Return"; break;
                        case 257: eventLabels[i] = "Fade In Async"; break;
                        case 258: eventLabels[i] = "Empty"; break;
                        case 259: eventLabels[i] = "Unknown"; break;
                        case 260: eventLabels[i] = "Unknown"; break;
                        case 261: eventLabels[i] = "Fade Music Room Loader"; break;
                        case 262: eventLabels[i] = "Fade Music Room Loader"; break;
                        case 263: eventLabels[i] = "Bounce On Bed"; break;
                        case 264: eventLabels[i] = "Return"; break;
                        case 265: eventLabels[i] = "Occupied Mk Inn Loader"; break;
                        case 266: eventLabels[i] = "Unknown"; break;
                        case 267: eventLabels[i] = "Unknown"; break;
                        case 268: eventLabels[i] = "Unknown"; break;
                        case 269: eventLabels[i] = "Pipe Up Subroutine"; break;
                        case 270: eventLabels[i] = "Trampoline Or Pipe Subroutine"; break;
                        case 271: eventLabels[i] = "Unknown"; break;
                        case 272: eventLabels[i] = "Pause Active Until A Pressed"; break;
                        case 273: eventLabels[i] = "Sleep In Inns"; break;
                        case 274: eventLabels[i] = "Check If Have Enough Coins"; break;
                        case 275: eventLabels[i] = "Unknown"; break;
                        case 276: eventLabels[i] = "Refocus Camera On Self"; break;
                        case 277: eventLabels[i] = "Unknown"; break;
                        case 278: eventLabels[i] = "Unknown"; break;
                        case 279: eventLabels[i] = "Unknown"; break;
                        case 280: eventLabels[i] = "Sleep In Nimbus Inn"; break;
                        case 281: eventLabels[i] = "Clear Exp Star Bits"; break;
                        case 282: eventLabels[i] = "Unknown Pipe Vault"; break;
                        case 283: eventLabels[i] = "Get Frog Coin No Dialog Possibly Unused"; break;
                        case 284: eventLabels[i] = "Open Mushroom Kingdom Shop"; break;
                        case 285: eventLabels[i] = "Unknown"; break;
                        case 286: eventLabels[i] = "Await B Press"; break;
                        case 287: eventLabels[i] = "Reset Game"; break;
                        case 288: eventLabels[i] = "Unknown Rose Town"; break;
                        case 289: eventLabels[i] = "Inns Container"; break;
                        case 290: eventLabels[i] = "Mushroom Kingdom Shop Logic"; break;
                        case 291: eventLabels[i] = "Mushroom Kingdom Outer Castle Guards"; break;
                        case 292: eventLabels[i] = "Mushroom Kingdom West Blue Toad"; break;
                        case 293: eventLabels[i] = "Unused"; break;
                        case 294: eventLabels[i] = "Mushroom Kingdom Inn Npc"; break;
                        case 295: eventLabels[i] = "Go To Mushroom Kingdom Outside"; break;
                        case 296: eventLabels[i] = "Mushroom Kingdom Grandma"; break;
                        case 297: eventLabels[i] = "Mushroom Kingdom Running Kid"; break;
                        case 298: eventLabels[i] = "Mushroom Kingdom Pink Toad"; break;
                        case 299: eventLabels[i] = "Empty"; break;
                        case 300: eventLabels[i] = "Generic No Help Message"; break;
                        case 301: eventLabels[i] = "Mushroom Kingdom Mom"; break;
                        case 302: eventLabels[i] = "Mushroom Kingdom Dad"; break;
                        case 303: eventLabels[i] = "Mushroom Kingdom Jumping Kid"; break;
                        case 304: eventLabels[i] = "Unknown"; break;
                        case 305: eventLabels[i] = "Unknown"; break;
                        case 306: eventLabels[i] = "Mushroom Kingdom Brother"; break;
                        case 307: eventLabels[i] = "Unknown"; break;
                        case 308: eventLabels[i] = "Empty"; break;
                        case 309: eventLabels[i] = "Empty"; break;
                        case 310: eventLabels[i] = "Mushroom Kingdom Grandpa"; break;
                        case 311: eventLabels[i] = "Mushroom Kingdom East Guard"; break;
                        case 312: eventLabels[i] = "Mushroom Kingdom Occupied Running Kid"; break;
                        case 313: eventLabels[i] = "Mushroom Kingdom Occupied Grandma"; break;
                        case 314: eventLabels[i] = "Empty"; break;
                        case 315: eventLabels[i] = "Empty"; break;
                        case 316: eventLabels[i] = "Mushroom Kingdom Occupied Dad"; break;
                        case 317: eventLabels[i] = "Mushroom Kingdom Occupied Mom"; break;
                        case 318: eventLabels[i] = "Mushroom Kingdom Occupied Castle Toad"; break;
                        case 319: eventLabels[i] = "Toadstool Antechamber Loader"; break;
                        case 320: eventLabels[i] = "Mushroom Kingdom Main Hall Loader"; break;
                        case 321: eventLabels[i] = "Bellhop While Guiding"; break;
                        case 322: eventLabels[i] = "Mushroom Kingdom Throne Room Loader"; break;
                        case 323: eventLabels[i] = "Unknown"; break;
                        case 324: eventLabels[i] = "Kingdom Main Hall Flip Veranda"; break;
                        case 325: eventLabels[i] = "Detect Main Hall Door Opened"; break;
                        case 326: eventLabels[i] = "Mushroom Kingdom Castle Generic Toad"; break;
                        case 327: eventLabels[i] = "Mushroom Kingdom Castle Throne Room Toad"; break;
                        case 328: eventLabels[i] = "Detect Main Hall Door Opened"; break;
                        case 329: eventLabels[i] = "Kingdom Main Hall Flip Upper"; break;
                        case 330: eventLabels[i] = "Chancellor"; break;
                        case 331: eventLabels[i] = "Empty"; break;
                        case 332: eventLabels[i] = "Empty"; break;
                        case 333: eventLabels[i] = "Empty"; break;
                        case 334: eventLabels[i] = "Empty"; break;
                        case 335: eventLabels[i] = "Unknown"; break;
                        case 336: eventLabels[i] = "Unknown"; break;
                        case 337: eventLabels[i] = "Mushroom Kingdom Shop Bookshelf"; break;
                        case 338: eventLabels[i] = "Mushroom Kingdom Shopkeeper"; break;
                        case 339: eventLabels[i] = "Mushroom Kingdom Occupied Raz Raini House Loader"; break;
                        case 340: eventLabels[i] = "Mushroom Kingdom Occupied Raz Raini House Shake"; break;
                        case 341: eventLabels[i] = "Empty"; break;
                        case 342: eventLabels[i] = "Empty"; break;
                        case 343: eventLabels[i] = "Empty"; break;
                        case 344: eventLabels[i] = "Mushroom Kingdom Raz Raini House Loader"; break;
                        case 345: eventLabels[i] = "Mushroom Kingdom Toadstools Room Guard"; break;
                        case 346: eventLabels[i] = "Toadstools Room Item"; break;
                        case 347: eventLabels[i] = "Toadstools Room Loader"; break;
                        case 348: eventLabels[i] = "Mushroom Kingdom Main Hall Toad"; break;
                        case 349: eventLabels[i] = "Mushroom Kingdom Antechamber Exit"; break;
                        case 350: eventLabels[i] = "Kingdom Hallway Shyguy"; break;
                        case 351: eventLabels[i] = "Gameboy Kid"; break;
                        case 352: eventLabels[i] = "Mushroom Kingdom Occupied Shopkeeper"; break;
                        case 353: eventLabels[i] = "Boss Battle"; break;
                        case 354: eventLabels[i] = "Boss Battle Container"; break;
                        case 355: eventLabels[i] = "Boss Hunt Bit Setter"; break;
                        case 356: eventLabels[i] = "Boss Hunt Bit Setter Container"; break;
                        case 357: eventLabels[i] = "Exp Star Music Experiment"; break;
                        case 358: eventLabels[i] = "Mushroom Kingdom Npc Behind House"; break;
                        case 359: eventLabels[i] = "Chest Clones"; break;
                        case 360: eventLabels[i] = "Empty"; break;
                        case 361: eventLabels[i] = "Empty"; break;
                        case 362: eventLabels[i] = "Empty"; break;
                        case 363: eventLabels[i] = "Empty"; break;
                        case 364: eventLabels[i] = "Empty"; break;
                        case 365: eventLabels[i] = "Empty"; break;
                        case 366: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Forced Off Minion"; break;
                        case 367: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Forced Off Minion"; break;
                        case 368: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Loader"; break;
                        case 369: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Exit"; break;
                        case 370: eventLabels[i] = "Empty"; break;
                        case 371: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Loader"; break;
                        case 372: eventLabels[i] = "Mushroom Kingdom Boss Fight Cutscene"; break;
                        case 373: eventLabels[i] = "Mushroom Kingdom Boss Fight"; break;
                        case 374: eventLabels[i] = "Empty"; break;
                        case 375: eventLabels[i] = "Talk To Chancellor After Mushroom Kingdom Boss"; break;
                        case 376: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Loader"; break;
                        case 377: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Repeating Shysters Position"; break;
                        case 378: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Shyster Chasing Toad"; break;
                        case 379: eventLabels[i] = "Mushroom Kingdom Occupied Guest Room Grant"; break;
                        case 380: eventLabels[i] = "Mushroom Kingdom Occupied Vault Guard Toad"; break;
                        case 381: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Antechamber Fight"; break;
                        case 382: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Loader"; break;
                        case 383: eventLabels[i] = "Toad Wishes You Well"; break;
                        case 384: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Antechamber Loader"; break;
                        case 385: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Antechamber Toad"; break;
                        case 386: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Toad 1"; break;
                        case 387: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Toad 2"; break;
                        case 388: eventLabels[i] = "Mushroom Kingdom Occupied Toadstools Room Toad 3"; break;
                        case 389: eventLabels[i] = "Mushroom Kingdom Occupied Left Stairway Shyster"; break;
                        case 390: eventLabels[i] = "Mushroom Kingdom Occupied Left Stairway Toad"; break;
                        case 391: eventLabels[i] = "Mushroom Kingdom Occupied Left Stairway Loader"; break;
                        case 392: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Repeating Shysters Position"; break;
                        case 393: eventLabels[i] = "Mushroom Kingdom During Mack Jumping Kids House 1F Loader"; break;
                        case 394: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Pink Toad"; break;
                        case 395: eventLabels[i] = "Wallet Toad 2"; break;
                        case 396: eventLabels[i] = "Mushroom Kingdom Occupied Rescued Eastern Guard"; break;
                        case 397: eventLabels[i] = "Heal In Toadstools Room"; break;
                        case 398: eventLabels[i] = "Empty"; break;
                        case 399: eventLabels[i] = "Empty"; break;
                        case 400: eventLabels[i] = "Guest Room Guard"; break;
                        case 401: eventLabels[i] = "Guest Room Antechamber Loader"; break;
                        case 402: eventLabels[i] = "Shyster Harassing Eastern Guard"; break;
                        case 403: eventLabels[i] = "Shyster Harassing Wallet Guy"; break;
                        case 404: eventLabels[i] = "Mushroom Kingdom Occupied Shop Loader"; break;
                        case 405: eventLabels[i] = "Table Shyster"; break;
                        case 406: eventLabels[i] = "Younger Brother"; break;
                        case 407: eventLabels[i] = "Countertop Shyster"; break;
                        case 408: eventLabels[i] = "Mushroom Kingdom Occupied Older Brother"; break;
                        case 409: eventLabels[i] = "Mushroom Kingdom Occupied Jumping Kids House 2F Loader"; break;
                        case 410: eventLabels[i] = "Bed Shyster"; break;
                        case 411: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Repeating Shysters"; break;
                        case 412: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Repeating Shysters"; break;
                        case 413: eventLabels[i] = "Clear Temp 7044 0"; break;
                        case 414: eventLabels[i] = "Set Temp 7044 0"; break;
                        case 415: eventLabels[i] = "Pipe Vault Room 1 Exit"; break;
                        case 416: eventLabels[i] = "Pipe Vault Thwomp Room Entrance"; break;
                        case 417: eventLabels[i] = "Pipe Vault Thwomp Room Exit Pipe"; break;
                        case 418: eventLabels[i] = "Pipe Vault Pipes Room Entrance Pipe"; break;
                        case 419: eventLabels[i] = "Empty"; break;
                        case 420: eventLabels[i] = "Pipe Vault Crouch Room Exit Trampoline"; break;
                        case 421: eventLabels[i] = "Pipe Vault Pipes Room Exit Pipe"; break;
                        case 422: eventLabels[i] = "Pipe Vault Platforming Room Entrance Pipe"; break;
                        case 423: eventLabels[i] = "Pipe Vault Platforming Room Exit Pipe"; break;
                        case 424: eventLabels[i] = "Pipe Vault Red Room Entrance Pipe"; break;
                        case 425: eventLabels[i] = "Pipe Vault Red Room Exit Pipe"; break;
                        case 426: eventLabels[i] = "Pipe Vault Chompweed Room Entrance Pipe"; break;
                        case 427: eventLabels[i] = "Pipe Vault Chompweed Room Exit Pipe"; break;
                        case 428: eventLabels[i] = "Pipe Vault Thwomp Room Loader"; break;
                        case 429: eventLabels[i] = "Pipe Vault Thwomp Room Loader Background"; break;
                        case 430: eventLabels[i] = "Pipe Vault Mario Hit By Thwomp"; break;
                        case 431: eventLabels[i] = "Pipe Vault Goomba Thumpin Entrance Pipe"; break;
                        case 432: eventLabels[i] = "Pipe Vault Goomba Thumpin Exit Trampoline"; break;
                        case 433: eventLabels[i] = "Pipe Vault Chompweed"; break;
                        case 434: eventLabels[i] = "Pipe Vault Red Room Loader"; break;
                        case 435: eventLabels[i] = "Pipe Vault Room 1 Loader"; break;
                        case 436: eventLabels[i] = "Pipe Vault Fireball 1"; break;
                        case 437: eventLabels[i] = "Pipe Vault Fireball 2"; break;
                        case 438: eventLabels[i] = "Pipe Vault Fireball 3"; break;
                        case 439: eventLabels[i] = "Pipe Vault Fireball 4"; break;
                        case 440: eventLabels[i] = "Pipe Vault Fireball Background"; break;
                        case 441: eventLabels[i] = "Pipe Vault Chompweed Room Chompweeds"; break;
                        case 442: eventLabels[i] = "Empty"; break;
                        case 443: eventLabels[i] = "Pipe Vault Chompweed Room Loader"; break;
                        case 444: eventLabels[i] = "Goomba Thumpin Administrator"; break;
                        case 445: eventLabels[i] = "Goomba Thumpin Begins"; break;
                        case 446: eventLabels[i] = "Goomba Thumpin Scorekeeping"; break;
                        case 447: eventLabels[i] = "Goomba Thumpin Spawns"; break;
                        case 448: eventLabels[i] = "Goomba Thumpin Goomba 1"; break;
                        case 449: eventLabels[i] = "Goomba Thumpin Goomba 2"; break;
                        case 450: eventLabels[i] = "Goomba Thumpin Goomba 3"; break;
                        case 451: eventLabels[i] = "Goomba Thumpin Goomba 4"; break;
                        case 452: eventLabels[i] = "Empty"; break;
                        case 453: eventLabels[i] = "Empty"; break;
                        case 454: eventLabels[i] = "Goomba Thumpin Room Loader"; break;
                        case 455: eventLabels[i] = "Resummon Pipe Vault Enemies"; break;
                        case 456: eventLabels[i] = "Yoshi Talks To Other Yoshi"; break;
                        case 457: eventLabels[i] = "Mushroom Derby Unknown"; break;
                        case 458: eventLabels[i] = "Mushroom Derby Begins"; break;
                        case 459: eventLabels[i] = "Upper Right Yoshi"; break;
                        case 460: eventLabels[i] = "Cookie Storage Yoshi"; break;
                        case 461: eventLabels[i] = "Yoshi On Track"; break;
                        case 462: eventLabels[i] = "Yoshi Mom"; break;
                        case 463: eventLabels[i] = "Free Cookie Yoshi"; break;
                        case 464: eventLabels[i] = "Empty"; break;
                        case 465: eventLabels[i] = "Mushroom Derby Business Logic"; break;
                        case 466: eventLabels[i] = "Mushroom Derby Business Logic Extension"; break;
                        case 467: eventLabels[i] = "Pipe Vault Platforming Room Loader"; break;
                        case 468: eventLabels[i] = "Mushroom Derby Use Yoshi Cookie"; break;
                        case 469: eventLabels[i] = "Yoster Isle Background"; break;
                        case 470: eventLabels[i] = "Green Yoshi"; break;
                        case 471: eventLabels[i] = "Boshi"; break;
                        case 472: eventLabels[i] = "Empty"; break;
                        case 473: eventLabels[i] = "Empty"; break;
                        case 474: eventLabels[i] = "Empty"; break;
                        case 475: eventLabels[i] = "Mushroom Derby Unknown"; break;
                        case 476: eventLabels[i] = "Initiate Mushroom Derby From Talking To Boshi"; break;
                        case 477: eventLabels[i] = "Dismount Yoshi 1"; break;
                        case 478: eventLabels[i] = "Dismount Yoshi 2"; break;
                        case 479: eventLabels[i] = "Dismount Yoshi 3"; break;
                        case 480: eventLabels[i] = "Dismount Yoshi 4"; break;
                        case 481: eventLabels[i] = "Empty"; break;
                        case 482: eventLabels[i] = "Yoster Isle Unknown"; break;
                        case 483: eventLabels[i] = "Empty"; break;
                        case 484: eventLabels[i] = "Empty"; break;
                        case 485: eventLabels[i] = "Pipe Vault Crouch Room Entrance Pipe"; break;
                        case 486: eventLabels[i] = "Empty"; break;
                        case 487: eventLabels[i] = "Pipe Vault Chompweed Room Exit Pipe Reverse"; break;
                        case 488: eventLabels[i] = "Red Room Piranha 1"; break;
                        case 489: eventLabels[i] = "Red Room Piranha 2"; break;
                        case 490: eventLabels[i] = "Red Room Piranha 3"; break;
                        case 491: eventLabels[i] = "Red Room Piranha 4"; break;
                        case 492: eventLabels[i] = "Pipe Vault Piranha Timer 1"; break;
                        case 493: eventLabels[i] = "Pipe Vault Piranha Bit"; break;
                        case 494: eventLabels[i] = "Pipe Vault Piranha Timer 2"; break;
                        case 495: eventLabels[i] = "Pipe Vault Piranha Timer 3"; break;
                        case 496: eventLabels[i] = "Pipe Vault Piranha Timer 4"; break;
                        case 497: eventLabels[i] = "Pipe Vault Piranha Timer 5"; break;
                        case 498: eventLabels[i] = "Pipe Vault First Goomba"; break;
                        case 499: eventLabels[i] = "Pipe Vault Entrance Trampoline"; break;
                        case 500: eventLabels[i] = "Pipe Vault Hidden Platform"; break;
                        case 501: eventLabels[i] = "Empty"; break;
                        case 502: eventLabels[i] = "Pipe Vault Crouch Item Init"; break;
                        case 503: eventLabels[i] = "Pipe Vault Crouch Item Confirm"; break;
                        case 504: eventLabels[i] = "Pipe Vault Small Coin"; break;
                        case 505: eventLabels[i] = "Pipe Vault Mario Thwomp Tumble"; break;
                        case 506: eventLabels[i] = "Pipe Vault Summon First Goomba"; break;
                        case 507: eventLabels[i] = "Pipe Vault Piranha Bit"; break;
                        case 508: eventLabels[i] = "Unknown"; break;
                        case 509: eventLabels[i] = "Pipe Vault Crouch Item Reset"; break;
                        case 510: eventLabels[i] = "Pipe Vault Crouch Room Clear Bits"; break;
                        case 511: eventLabels[i] = "Empty"; break;
                        case 512: eventLabels[i] = "Rose Town Occupied Inn Loader"; break;
                        case 513: eventLabels[i] = "Empty"; break;
                        case 514: eventLabels[i] = "Gaz Item Grant"; break;
                        case 515: eventLabels[i] = "Empty"; break;
                        case 516: eventLabels[i] = "Occupied Rose Town Gaz"; break;
                        case 517: eventLabels[i] = "Rose Town Occupied Exit"; break;
                        case 518: eventLabels[i] = "Rose Town Occupied Stairway"; break;
                        case 519: eventLabels[i] = "Empty"; break;
                        case 520: eventLabels[i] = "Rose Town Occupied Exterior Pink Toad"; break;
                        case 521: eventLabels[i] = "Rose Town Occupied Exterior Blue Toad Left"; break;
                        case 522: eventLabels[i] = "Empty"; break;
                        case 523: eventLabels[i] = "Empty"; break;
                        case 524: eventLabels[i] = "Rose Town Occupied Exterior Grandpa"; break;
                        case 525: eventLabels[i] = "Rose Town Item Shop"; break;
                        case 526: eventLabels[i] = "Rose Town Equip Shop"; break;
                        case 527: eventLabels[i] = "Rose Town Shop Red Toad"; break;
                        case 528: eventLabels[i] = "Rose Town Shop Yellow Toad"; break;
                        case 529: eventLabels[i] = "Rose Town Occupied Exterior Loader"; break;
                        case 530: eventLabels[i] = "Rose Town Occupied Background 1"; break;
                        case 531: eventLabels[i] = "Rose Town Occupied Inn 2F Loader"; break;
                        case 532: eventLabels[i] = "Empty"; break;
                        case 533: eventLabels[i] = "Empty"; break;
                        case 534: eventLabels[i] = "Rose Town Dad"; break;
                        case 535: eventLabels[i] = "Rose Town Son"; break;
                        case 536: eventLabels[i] = "Empty"; break;
                        case 537: eventLabels[i] = "Rose Town Treasure House 2F Loader"; break;
                        case 538: eventLabels[i] = "Rose Town Pink Toad In House"; break;
                        case 539: eventLabels[i] = "Rose Town Shop Unknown"; break;
                        case 540: eventLabels[i] = "Unused Hint Dialog"; break;
                        case 541: eventLabels[i] = "Debug Dialog"; break;
                        case 542: eventLabels[i] = "Rose Town Occupied Grandma"; break;
                        case 543: eventLabels[i] = "Rose Town Occupied Kid 1"; break;
                        case 544: eventLabels[i] = "Rose Town Occupied Kid 2"; break;
                        case 545: eventLabels[i] = "Rose Town Occupied Kid 3"; break;
                        case 546: eventLabels[i] = "Rose Town Occupied Blue Toad Right"; break;
                        case 547: eventLabels[i] = "Rose Town Occupied Arrow Control 1"; break;
                        case 548: eventLabels[i] = "Rose Town Occupied Arrow Animate"; break;
                        case 549: eventLabels[i] = "Rose Town Occupied Arrow Control 2"; break;
                        case 550: eventLabels[i] = "Rose Town Occupied Arrow Control 3"; break;
                        case 551: eventLabels[i] = "Rose Town Occupied Mods"; break;
                        case 552: eventLabels[i] = "Rose Town Occupied Intro Toad Movement"; break;
                        case 553: eventLabels[i] = "Rose Town Occupied Arrow Control 4"; break;
                        case 554: eventLabels[i] = "Rose Town Occupied Exterior Yellow Toad"; break;
                        case 555: eventLabels[i] = "Rose Town Inn Toad Item Grant"; break;
                        case 556: eventLabels[i] = "Rose Town Liberated Loader"; break;
                        case 557: eventLabels[i] = "Rose Town Liberated Loader Background"; break;
                        case 558: eventLabels[i] = "Rose Town Shop Exit"; break;
                        case 559: eventLabels[i] = "Rose Town Couples House Exit"; break;
                        case 560: eventLabels[i] = "Old Key Item Manager"; break;
                        case 561: eventLabels[i] = "Place Link In Rose Town"; break;
                        case 562: eventLabels[i] = "Rose Town Liberated Kids Indoors"; break;
                        case 563: eventLabels[i] = "Summons Husband In Rose Town Couples House"; break;
                        case 564: eventLabels[i] = "Rose Town Liberated Kid Outdoors"; break;
                        case 565: eventLabels[i] = "Rose Town Liberated 3Rd Kid Outdoors"; break;
                        case 566: eventLabels[i] = "Rose Town Liberated Grandpa"; break;
                        case 567: eventLabels[i] = "Rose Town Liberated Grandma"; break;
                        case 568: eventLabels[i] = "Rose Rown Liberated Water Pump House Loader"; break;
                        case 569: eventLabels[i] = "Rose Town Liberated Pink Toad"; break;
                        case 570: eventLabels[i] = "Rose Town Liberated Right Blue Toad"; break;
                        case 571: eventLabels[i] = "Rose Town Liberated Yellow Toad"; break;
                        case 572: eventLabels[i] = "Rose Town Liberated Husband"; break;
                        case 573: eventLabels[i] = "Rose Town Liberated Wife"; break;
                        case 574: eventLabels[i] = "Empty"; break;
                        case 575: eventLabels[i] = "Rose Town Liberated Couples House Loader"; break;
                        case 576: eventLabels[i] = "Rose Town Treasure House Chest 1"; break;
                        case 577: eventLabels[i] = "Rose Town Treasure House Chest 2"; break;
                        case 578: eventLabels[i] = "Rose Town Liberated Upper Hidden Npc"; break;
                        case 579: eventLabels[i] = "Rose Town Liberated Left Blue Toad"; break;
                        case 580: eventLabels[i] = "Rose Town Occupied Treasure House 1F Loader"; break;
                        case 581: eventLabels[i] = "Rose Town Liberated Lower Hidden Npc"; break;
                        case 582: eventLabels[i] = "Rose Town Occupied Treasure House Bedroom Chest"; break;
                        case 583: eventLabels[i] = "Rose Town Liberated Treasure House Bedroom Chest"; break;
                        case 584: eventLabels[i] = "Goomba Thumpin Gold Goomba 1"; break;
                        case 585: eventLabels[i] = "Goomba Thumpin Gold Goomba 2"; break;
                        case 586: eventLabels[i] = "Goomba Thumpin Gold Goomba 3"; break;
                        case 587: eventLabels[i] = "Goomba Thumpin Gold Goomba 4"; break;
                        case 588: eventLabels[i] = "Goomba Thumpin Spiny 1"; break;
                        case 589: eventLabels[i] = "Goomba Thumpin Spiny 2"; break;
                        case 590: eventLabels[i] = "Goomba Thumpin Spiny 3"; break;
                        case 591: eventLabels[i] = "Goomba Thumpin Spiny 4"; break;
                        case 592: eventLabels[i] = "Mines Boss Room Loader Before Defeat"; break;
                        case 593: eventLabels[i] = "Mines Boss Room Loader After Defeat"; break;
                        case 594: eventLabels[i] = "Mines Boss Shoves You"; break;
                        case 595: eventLabels[i] = "Mines Boss Room Exit"; break;
                        case 596: eventLabels[i] = "Mines Boss Room Background Explosions"; break;
                        case 597: eventLabels[i] = "Mines Boss Room Explosion Recoil"; break;
                        case 598: eventLabels[i] = "Mines Initiate Final Boss Fight"; break;
                        case 599: eventLabels[i] = "Mines Boss Room Entrance Reverse"; break;
                        case 600: eventLabels[i] = "Marrymore Occupied Chapel Loader"; break;
                        case 601: eventLabels[i] = "Marrymore Back Door Enter Chapel"; break;
                        case 602: eventLabels[i] = "Marrymore Inn Manager"; break;
                        case 603: eventLabels[i] = "Marrymore Bellhop Lobby While Guest"; break;
                        case 604: eventLabels[i] = "Marrymore Inn Bright Card Enthusiast"; break;
                        case 605: eventLabels[i] = "Marrymore Inn Lobby Guest 1"; break;
                        case 606: eventLabels[i] = "Marrymore Inn Lobby Guest 2"; break;
                        case 607: eventLabels[i] = "Locked Door"; break;
                        case 608: eventLabels[i] = "Marrymore Inn 3F Hallway Loader"; break;
                        case 609: eventLabels[i] = "Marrymore Inn 3F Hallway Bellhop"; break;
                        case 610: eventLabels[i] = "Marrymore Occupied Exterior Loader"; break;
                        case 611: eventLabels[i] = "Marrymore Inn Lobby Loader"; break;
                        case 612: eventLabels[i] = "Marrymore Inn 2F Hallway Loader"; break;
                        case 613: eventLabels[i] = "Marrymore Suite Loader"; break;
                        case 614: eventLabels[i] = "Marrymore Suite Tip Bellhop"; break;
                        case 615: eventLabels[i] = "Marrymore Lamp"; break;
                        case 616: eventLabels[i] = "Marrymore Inn Lobby Exit"; break;
                        case 617: eventLabels[i] = "Mario As Bellhop Main Event"; break;
                        case 618: eventLabels[i] = "Mario As Bellhop Tries To Go Upstairs Without Guest"; break;
                        case 619: eventLabels[i] = "Real Bellhop Blocks Exit 1"; break;
                        case 620: eventLabels[i] = "Real Bellhop Blocks Exit 2"; break;
                        case 621: eventLabels[i] = "Marrymore Inn Elderly Guest"; break;
                        case 622: eventLabels[i] = "Marrymore Inn Elderly Guest Tip Subroutine 1"; break;
                        case 623: eventLabels[i] = "Marrymore Inn Employed Guest Leaves"; break;
                        case 624: eventLabels[i] = "Marrymore Inn Lobby Stairs"; break;
                        case 625: eventLabels[i] = "Marrymore Inn Something"; break;
                        case 626: eventLabels[i] = "Marrymore Inn Elderly Guest Tip Subroutine Flowerbox"; break;
                        case 627: eventLabels[i] = "Marrymore Sanctuary Exit To Antechamber"; break;
                        case 628: eventLabels[i] = "Marrymore Kitchen Loader"; break;
                        case 629: eventLabels[i] = "Empty"; break;
                        case 630: eventLabels[i] = "Marrymore Kitchen Chef 1"; break;
                        case 631: eventLabels[i] = "Marrymore Kitchen Chef 2"; break;
                        case 632: eventLabels[i] = "Marrymore Exterior Chapel Locked Front Door"; break;
                        case 633: eventLabels[i] = "Marrymore Chapel Lobby Exit To Exterior"; break;
                        case 634: eventLabels[i] = "Empty"; break;
                        case 635: eventLabels[i] = "Marrymore Inn Elderly Guest Tip Sunroutine 3"; break;
                        case 636: eventLabels[i] = "Empty"; break;
                        case 637: eventLabels[i] = "Empty"; break;
                        case 638: eventLabels[i] = "Empty"; break;
                        case 639: eventLabels[i] = "Empty"; break;
                        case 640: eventLabels[i] = "Empty"; break;
                        case 641: eventLabels[i] = "Marrymore Antechamber Loader Extension"; break;
                        case 642: eventLabels[i] = "Marrymore Antechamber Entrance Reverse"; break;
                        case 643: eventLabels[i] = "Empty"; break;
                        case 644: eventLabels[i] = "Empty"; break;
                        case 645: eventLabels[i] = "Empty"; break;
                        case 646: eventLabels[i] = "Marrymore Shop Event Container"; break;
                        case 647: eventLabels[i] = "Marrymore Sanctuary Candle 1"; break;
                        case 648: eventLabels[i] = "Marrymore Sanctuary Candle 2"; break;
                        case 649: eventLabels[i] = "Marrymore Sanctuary Candle 3"; break;
                        case 650: eventLabels[i] = "Marrymore Sanctuary Candle 4"; break;
                        case 651: eventLabels[i] = "Marrymore Sanctuary Candle 5"; break;
                        case 652: eventLabels[i] = "Marrymore Sanctuary Candle 6"; break;
                        case 653: eventLabels[i] = "Marrymore Sanctuary Candle 7"; break;
                        case 654: eventLabels[i] = "Marrymore Sanctuary Candle 8"; break;
                        case 655: eventLabels[i] = "Marrymore Gear Grant Crown"; break;
                        case 656: eventLabels[i] = "Empty"; break;
                        case 657: eventLabels[i] = "Empty"; break;
                        case 658: eventLabels[i] = "Empty"; break;
                        case 659: eventLabels[i] = "Empty"; break;
                        case 660: eventLabels[i] = "Empty"; break;
                        case 661: eventLabels[i] = "Bowsers Keep Button Room Forfeit"; break;
                        case 662: eventLabels[i] = "Empty"; break;
                        case 663: eventLabels[i] = "Initiate Marrymore Boss Fight If All Gear Collected"; break;
                        case 664: eventLabels[i] = "Empty"; break;
                        case 665: eventLabels[i] = "Empty"; break;
                        case 666: eventLabels[i] = "Empty"; break;
                        case 667: eventLabels[i] = "Empty"; break;
                        case 668: eventLabels[i] = "Summon Marrymore Boss To Room"; break;
                        case 669: eventLabels[i] = "Enter Unoccupied Marrymore Sanctuary"; break;
                        case 670: eventLabels[i] = "Marrymore Unoccupied Exterior Loader"; break;
                        case 671: eventLabels[i] = "Marrymore Back Area Exit To Exterior"; break;
                        case 672: eventLabels[i] = "Marrymore Occupied Exterior Chapel Front Entrance"; break;
                        case 673: eventLabels[i] = "Marrymore Chapel Lobby Exit To Antechamber"; break;
                        case 674: eventLabels[i] = "Marrymore Unoccupied Exterior Open Front Chapel Entrance"; break;
                        case 675: eventLabels[i] = "Empty"; break;
                        case 676: eventLabels[i] = "Empty"; break;
                        case 677: eventLabels[i] = "Marrymore Unoccupied Sanctuary Loader"; break;
                        case 678: eventLabels[i] = "Marrymore Jump On Organ Pipe"; break;
                        case 679: eventLabels[i] = "Marrymore Liberated Exterior Pathway Red Toad"; break;
                        case 680: eventLabels[i] = "Marrymore Liberated Exterior Pathway Yellow Toad"; break;
                        case 681: eventLabels[i] = "Marrymore Liberated Exterior Kid"; break;
                        case 682: eventLabels[i] = "Marrymore Liberated Exterior Mom"; break;
                        case 683: eventLabels[i] = "Marrymore Liberated Exterior Green Toad"; break;
                        case 684: eventLabels[i] = "Marrymore Liberated Exterior Husband"; break;
                        case 685: eventLabels[i] = "Marrymore Liberated Exterior Wife"; break;
                        case 686: eventLabels[i] = "Marrymore Liberated Exterior Red Toad"; break;
                        case 687: eventLabels[i] = "Empty"; break;
                        case 688: eventLabels[i] = "Marrymore Raz"; break;
                        case 689: eventLabels[i] = "Marrymore Raini"; break;
                        case 690: eventLabels[i] = "Marrymore Red Toad 1"; break;
                        case 691: eventLabels[i] = "Marrymore Yellow Toad 1"; break;
                        case 692: eventLabels[i] = "Empty"; break;
                        case 693: eventLabels[i] = "Marrymore Grey Toad"; break;
                        case 694: eventLabels[i] = "Marrymore Red Toad 2"; break;
                        case 695: eventLabels[i] = "Marrymore Green Kid"; break;
                        case 696: eventLabels[i] = "Marrymore Yellow Toad 2"; break;
                        case 697: eventLabels[i] = "Marrymore Entrance Toad"; break;
                        case 698: eventLabels[i] = "Marrymore Photographer"; break;
                        case 699: eventLabels[i] = "Empty"; break;
                        case 700: eventLabels[i] = "Empty"; break;
                        case 701: eventLabels[i] = "Pastor Mario"; break;
                        case 702: eventLabels[i] = "Marrymore Take Photo"; break;
                        case 703: eventLabels[i] = "Empty"; break;
                        case 704: eventLabels[i] = "Empty"; break;
                        case 705: eventLabels[i] = "Marrymore Liberated Chapel Green Toad"; break;
                        case 706: eventLabels[i] = "Marrymore Liberated Chapel Pink Kid"; break;
                        case 707: eventLabels[i] = "Marrymore Raz Raini"; break;
                        case 708: eventLabels[i] = "Marrymore Tip Decision Subroutine"; break;
                        case 709: eventLabels[i] = "Empty"; break;
                        case 710: eventLabels[i] = "Empty"; break;
                        case 711: eventLabels[i] = "Empty"; break;
                        case 712: eventLabels[i] = "Empty"; break;
                        case 713: eventLabels[i] = "Empty"; break;
                        case 714: eventLabels[i] = "Empty"; break;
                        case 715: eventLabels[i] = "Empty"; break;
                        case 716: eventLabels[i] = "Enter Jumping Kids House"; break;
                        case 717: eventLabels[i] = "Empty"; break;
                        case 718: eventLabels[i] = "Empty"; break;
                        case 719: eventLabels[i] = "Empty"; break;
                        case 720: eventLabels[i] = "Old Star Piece Script"; break;
                        case 721: eventLabels[i] = "Peachs Grandma"; break;
                        case 722: eventLabels[i] = "Empty"; break;
                        case 723: eventLabels[i] = "Mushroom Kingdom Unoccupied Exterior Loader"; break;
                        case 724: eventLabels[i] = "Nimbus Croco House Loader"; break;
                        case 725: eventLabels[i] = "Empty"; break;
                        case 726: eventLabels[i] = "Empty"; break;
                        case 727: eventLabels[i] = "Empty"; break;
                        case 728: eventLabels[i] = "Empty"; break;
                        case 729: eventLabels[i] = "Several Marrymore Room Loaders"; break;
                        case 730: eventLabels[i] = "Empty"; break;
                        case 731: eventLabels[i] = "Empty"; break;
                        case 732: eventLabels[i] = "Empty"; break;
                        case 733: eventLabels[i] = "Empty"; break;
                        case 734: eventLabels[i] = "Mway Chest"; break;
                        case 735: eventLabels[i] = "Forest Underground Chest"; break;
                        case 736: eventLabels[i] = "Rose Town Inn Sleep Subroutine"; break;
                        case 737: eventLabels[i] = "Garros House Loader"; break;
                        case 738: eventLabels[i] = "Nimbus Land Final Boss Fight Town Square Loader"; break;
                        case 739: eventLabels[i] = "Nimbus Land Inn Hint Guy"; break;
                        case 740: eventLabels[i] = "Nimbus Land Occupied Castle Front Entrance"; break;
                        case 741: eventLabels[i] = "Empty"; break;
                        case 742: eventLabels[i] = "Nimbus Land Liberated Castle Main Hallway Woman"; break;
                        case 743: eventLabels[i] = "Nimbus Land Liberated Castle Main Hallway Man"; break;
                        case 744: eventLabels[i] = "Nimbus Land Liberated Castle Inner Cellar Reward"; break;
                        case 745: eventLabels[i] = "Mushroom Kingdom Inn Sleeping Guy"; break;
                        case 746: eventLabels[i] = "Mushroom Kingdom Inn 2F Downward Stairs"; break;
                        case 747: eventLabels[i] = "Mushroom Kingdom Inn 2F Loader"; break;
                        case 748: eventLabels[i] = "Empty"; break;
                        case 749: eventLabels[i] = "Vine Field"; break;
                        case 750: eventLabels[i] = "Vine Field"; break;
                        case 751: eventLabels[i] = "Vine Field"; break;
                        case 752: eventLabels[i] = "Vine Field"; break;
                        case 753: eventLabels[i] = "Rose Town Innkeeper Over Counter"; break;
                        case 754: eventLabels[i] = "Mushroom Kingdom Shop Basement Stairway"; break;
                        case 755: eventLabels[i] = "Mushroom Way Area 03 Shuffled Npc Animation Loader"; break;
                        case 756: eventLabels[i] = "Bandits Way Area 02 Shuffled Npc Animation Loader"; break;
                        case 757: eventLabels[i] = "Bandits Way Area 01 Shuffled Npc Animation Loader"; break;
                        case 758: eventLabels[i] = "Bandits Way Area 03 Shuffled Npc Animation Loader"; break;
                        case 759: eventLabels[i] = "Bandits Way Area 04 Shuffled Npc Animation Loader"; break;
                        case 760: eventLabels[i] = "Bandits Way Area 05 Shuffled Npc Animation Loader"; break;
                        case 761: eventLabels[i] = "Mushroom Kingdom Occupied Throne Room Shuffled Npc Animation Loader"; break;
                        case 762: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Shuffled Npc Animation Loader"; break;
                        case 763: eventLabels[i] = "Mushroom Kingdom Occupied Throne Antechamber Shuffled Npc Animation Loader"; break;
                        case 764: eventLabels[i] = "Mushroom Kingdom Occupied Throne Antechamber Loader"; break;
                        case 765: eventLabels[i] = "Mushroom Kingdom Occupied Main Hall Shuffled Npc Animation Loader"; break;
                        case 766: eventLabels[i] = "Mushroom Kingdom Occupied Stairway Shuffled Npc Animation Loader"; break;
                        case 767: eventLabels[i] = "Mushroom Kingdom Occupied East Hall Loader"; break;
                        case 768: eventLabels[i] = "Mushroom Kingdom Occupied East Hall Shuffled Npc Animation Loader"; break;
                        case 769: eventLabels[i] = "Mushroom Kingdom Occupied Peachs Antechamber Shuffled Npc Animation Loader"; break;
                        case 770: eventLabels[i] = "Mushroom Kingdom Occupied Jumping Kids House 1F Shuffled Npc Animation Loader"; break;
                        case 771: eventLabels[i] = "Mushroom Kingdom Occupied Jumping Kids House 2F Shuffled Npc Animation Loader"; break;
                        case 772: eventLabels[i] = "Kero Sewers Belome Room Shuffled Npc Animation Loader"; break;
                        case 773: eventLabels[i] = "Kero Sewers Belome Room Loader Container"; break;
                        case 774: eventLabels[i] = "Forest Maze Boss Room Loader"; break;
                        case 775: eventLabels[i] = "Forest Maze Boss Room Shuffled Npc Animation Loader"; break;
                        case 776: eventLabels[i] = "Mines Trampoline Room Loader"; break;
                        case 777: eventLabels[i] = "Mines Trampoline Room Shuffled Npc Animation Loader"; break;
                        case 778: eventLabels[i] = "Mines Left Of Trampoline Room Loader"; break;
                        case 779: eventLabels[i] = "Mines Left Of Trampoline Room Shuffled Npc Animation Loader"; break;
                        case 780: eventLabels[i] = "Mines Tiny Room 2 Left Of Trampoline Room Loader"; break;
                        case 781: eventLabels[i] = "Mines Tiny Room 2 Left Of Trampoline Room Shuffled Npc Animation Loader"; break;
                        case 782: eventLabels[i] = "Mines Room That Splits To Pa Mole Path Loader"; break;
                        case 783: eventLabels[i] = "Mines Room That Splits To Pa Mole Path Shuffled Npc Animation Loader"; break;
                        case 784: eventLabels[i] = "Mines Small North Room In Miniboss Path Loader"; break;
                        case 785: eventLabels[i] = "Mines Small North Room In Miniboss Path Shuffled Npc Animation Loader"; break;
                        case 786: eventLabels[i] = "Mines Long Room In Miniboss Path Loader"; break;
                        case 787: eventLabels[i] = "Mines Long Room In Miniboss Path Shuffled Npc Animation Loader"; break;
                        case 788: eventLabels[i] = "Mines Boss Room Shuffled Npc Animation Loader"; break;
                        case 789: eventLabels[i] = "Tower Curtain Game Room Shuffled Npc Animation Loader"; break;
                        case 790: eventLabels[i] = "Marrymore Occupied Sanctuary Shuffled Npc Animation Loader"; break;
                        case 791: eventLabels[i] = "Tower Ancestor Game Room Shuffled Npc Animation Loader"; break;
                        case 792: eventLabels[i] = "Tower First Bobomb Staircase Shuffled Npc Animation Loader"; break;
                        case 793: eventLabels[i] = "Tower First Bobomb Staircase Loader"; break;
                        case 794: eventLabels[i] = "Tower Balcony Shuffled Npc Animation Loader"; break;
                        case 795: eventLabels[i] = "Ending Credits Chapel Shuffled Npc Animation Loader"; break;
                        case 796: eventLabels[i] = "Marrymore Kitchen Shuffled Npc Animation Loader"; break;
                        case 797: eventLabels[i] = "Tower Lobby Shuffled Npc Animation Loader"; break;
                        case 798: eventLabels[i] = "Tower First Rail Room Shuffled Npc Animation Loader"; break;
                        case 799: eventLabels[i] = "Tower Jumping Spookum Room Shuffled Npc Animation Loader"; break;
                        case 800: eventLabels[i] = "Ship Password Room Shuffled Npc Animation Loader"; break;
                        case 801: eventLabels[i] = "Ship Boss Room Shuffled Npc Animation Loader"; break;
                        case 802: eventLabels[i] = "Seaside Occupied Beach Shuffled Npc Animation Loader"; break;
                        case 803: eventLabels[i] = "Ship 1St Preboss Battle Room Shuffled Npc Animation Loader"; break;
                        case 804: eventLabels[i] = "Ship 2Nd Preboss Battle Room Shuffled Npc Animation Loader"; break;
                        case 805: eventLabels[i] = "Seaside Occupied Elder House 1F Shuffled Npc Animation Loader"; break;
                        case 806: eventLabels[i] = "Seaside Occupied Exterior Shuffled Npc Animation Loader"; break;
                        case 807: eventLabels[i] = "Seaside Occupied Inn 1F Shuffled Npc Animation Loader"; break;
                        case 808: eventLabels[i] = "Seaside Occupied Inn 2F Shuffled Npc Animation Loader"; break;
                        case 809: eventLabels[i] = "Seaside Occupied Bomb Shop Shuffled Npc Animation Loader"; break;
                        case 810: eventLabels[i] = "Seaside Occupied Wpn Arm Shop Shuffled Npc Animation Loader"; break;
                        case 811: eventLabels[i] = "Seaside Occupied Health Store Shuffled Npc Animation Loader"; break;
                        case 812: eventLabels[i] = "Seaside Occupied Mushroom Boy Shop Shuffled Npc Animation Loader"; break;
                        case 813: eventLabels[i] = "Seaside Occupied Accessory Shop Shuffled Npc Animation Loader"; break;
                        case 814: eventLabels[i] = "Temple Boss Room Shuffled Npc Animation Loader"; break;
                        case 815: eventLabels[i] = "Dojo Shuffled Npc Animation Loader"; break;
                        case 816: eventLabels[i] = "Monstro Superboss Shuffled Npc Animation Loader"; break;
                        case 817: eventLabels[i] = "Bean Valley Boss Room Shuffled Npc Animation Loader"; break;
                        case 818: eventLabels[i] = "Nimbus Castle Statue Polisher Boss Room Shuffled Npc Animation Loader"; break;
                        case 819: eventLabels[i] = "Nimbus Castle Statue Polishing Room Shuffled Npc Animation Loader"; break;
                        case 820: eventLabels[i] = "Nimbus Castle Final Hallway Shuffled Npc Animation Loader"; break;
                        case 821: eventLabels[i] = "Garros House Shuffled Npc Animation Loader"; break;
                        case 822: eventLabels[i] = "Nimbus Land Occupied Exterior Final Boss Room Shuffled Npc Animation Loader"; break;
                        case 823: eventLabels[i] = "Nimbus Castle Main Hallway Shuffled Npc Animation Loader"; break;
                        case 824: eventLabels[i] = "Nimbus Castle Occupied 4Way Path Shuffled Npc Animation Loader"; break;
                        case 825: eventLabels[i] = "Nimbus Castle Throne Room Antechamber Shuffled Npc Animation Loader"; break;
                        case 826: eventLabels[i] = "Nimbus Castle Occupied Throne Room Shuffled Npc Animation Loader"; break;
                        case 827: eventLabels[i] = "Nimbus Castle Single Bird Statue Room Shuffled Npc Animation Loader"; break;
                        case 828: eventLabels[i] = "Nimbus Castle Single Bird Statue Room Loader"; break;
                        case 829: eventLabels[i] = "Nimbus Castle Early West Shaman Path Shuffled Npc Animation Loader"; break;
                        case 830: eventLabels[i] = "Nimbus Castle Early East Shaman Path Shuffled Npc Animation Loader"; break;
                        case 831: eventLabels[i] = "Nimbus Castle Liberated Throne Room Shuffled Npc Animation Loader"; break;
                        case 832: eventLabels[i] = "Nimbus Land Hot Springs Shuffled Npc Animation Loader"; break;
                        case 833: eventLabels[i] = "Nimbus Castle Liberated Inner Cellar Hallway Loader"; break;
                        case 834: eventLabels[i] = "Nimbus Castle Liberated Inner Cellar Hallway Shuffled Npc Animation Loader"; break;
                        case 835: eventLabels[i] = "Nimbus Castle Liberated 5 Door Room Shuffled Npc Animation Loader"; break;
                        case 836: eventLabels[i] = "Nimbus Castle Liberated 4Way Path Shuffled Npc Animation Loader"; break;
                        case 837: eventLabels[i] = "Nimbus Castle Liberated 4Way Path Loader"; break;
                        case 838: eventLabels[i] = "Nimbus Castle First Post Throne Hallway Shuffled Npc Animation Loader"; break;
                        case 839: eventLabels[i] = "Nimbus Castle Second Post Throne Hallway Shuffled Npc Animation Loader"; break;
                        case 840: eventLabels[i] = "Volcano First Boss Room Shuffled Npc Animation Loader"; break;
                        case 841: eventLabels[i] = "Volcano Final Pre Exit Room Loader"; break;
                        case 842: eventLabels[i] = "Volcano Final Pre Exit Room Shuffled Npc Animation Loader"; break;
                        case 843: eventLabels[i] = "Volcano Post Boss Room With Enemy Warps Shuffled Npc Animation Loader"; break;
                        case 844: eventLabels[i] = "Volcano Exit Room Shuffled Npc Animation Loader"; break;
                        case 845: eventLabels[i] = "Volcano Brief Henchman Room Shuffled Npc Animation Loader"; break;
                        case 846: eventLabels[i] = "Keep Battle Door 1C Shuffled Npc Animation Loader"; break;
                        case 847: eventLabels[i] = "Keep First Boss Room Shuffled Npc Animation Loader"; break;
                        case 848: eventLabels[i] = "Keep Battle Door 2B Shuffled Npc Animation Loader"; break;
                        case 849: eventLabels[i] = "Keep Battle Door 2C Shuffled Npc Animation Loader"; break;
                        case 850: eventLabels[i] = "Keep Battle Door 1A Shuffled Npc Animation Loader"; break;
                        case 851: eventLabels[i] = "Keep Battle Door 1B Shuffled Npc Animation Loader"; break;
                        case 852: eventLabels[i] = "Keep Battle Door 2A Shuffled Npc Animation Loader"; break;
                        case 853: eventLabels[i] = "Keep Final Boss Room Shuffled Npc Animation Loader"; break;
                        case 854: eventLabels[i] = "Abyss 1St Boss Room Shuffled Npc Animation Loader"; break;
                        case 855: eventLabels[i] = "Inner Factory 1St Room Shuffled Npc Animation Loader"; break;
                        case 856: eventLabels[i] = "Inner Factory 2Nd Room Shuffled Npc Animation Loader"; break;
                        case 857: eventLabels[i] = "Inner Factory 3Rd Room Shuffled Npc Animation Loader"; break;
                        case 858: eventLabels[i] = "Inner Factory 4Th Room Shuffled Npc Animation Loader"; break;
                        case 859: eventLabels[i] = "Inner Factory 1St Room Post Fight Shuffled Npc Animation Loader"; break;
                        case 860: eventLabels[i] = "Mines Boss Shove Subroutine"; break;
                        case 861: eventLabels[i] = "Dojo 1St Boss Challenge Subroutine"; break;
                        case 862: eventLabels[i] = "Dojo 2Nd Boss Challenge Subroutine"; break;
                        case 863: eventLabels[i] = "Dojo 2Nd Boss Challenge Deescalate"; break;
                        case 864: eventLabels[i] = "Dojo 3Rd Boss Challenge Subroutine"; break;
                        case 865: eventLabels[i] = "Dojo 3Rd Boss Challenge Deescalate"; break;
                        case 866: eventLabels[i] = "Dojo 4Th Boss Challenge Subroutine"; break;
                        case 867: eventLabels[i] = "Dojo 5Th Boss Challenge Subroutine"; break;
                        case 868: eventLabels[i] = "Dojo 5Th Boss Challenge Deescalate"; break;
                        case 869: eventLabels[i] = "Test Script 3"; break;
                        case 870: eventLabels[i] = "Test Script 4"; break;
                        case 871: eventLabels[i] = "Test Script 5"; break;
                        case 872: eventLabels[i] = "Test Script 6"; break;
                        case 873: eventLabels[i] = "Test Script 7"; break;
                        case 874: eventLabels[i] = "Test Script 8"; break;
                        case 875: eventLabels[i] = "Test Script 9"; break;
                        case 876: eventLabels[i] = "Test Script 10"; break;
                        case 877: eventLabels[i] = "Test Script 11"; break;
                        case 878: eventLabels[i] = "Tower Exterior Shuffled Npc Animation Loader"; break;
                        case 879: eventLabels[i] = "Ship Trampoline Loader Override"; break;
                        case 880: eventLabels[i] = "Booster Pass Secret Room Shuffled Npc Animation Loader"; break;
                        case 881: eventLabels[i] = "Booster Pass Seesaw Chest Room Shuffled Npc Animation Loader"; break;
                        case 882: eventLabels[i] = "Chest Flower Item Collection"; break;
                        case 883: eventLabels[i] = "Chest Item Bag Packet"; break;
                        case 884: eventLabels[i] = "Chest Feather Packet"; break;
                        case 885: eventLabels[i] = "Chest Star Piece Packet"; break;
                        case 886: eventLabels[i] = "Chest Ring Packet"; break;
                        case 887: eventLabels[i] = "Chest Brooch Packet"; break;
                        case 888: eventLabels[i] = "Chest Shoes Packet"; break;
                        case 889: eventLabels[i] = "Chest Banana Peel Packet"; break;
                        case 890: eventLabels[i] = "Chest Crown Packet"; break;
                        case 891: eventLabels[i] = "Chest Bomb Packet"; break;
                        case 892: eventLabels[i] = "Chest Egg Packet"; break;
                        case 893: eventLabels[i] = "Chest Cookie Packet"; break;
                        case 894: eventLabels[i] = "Chest Berry Packet"; break;
                        case 895: eventLabels[i] = "Chest Card Packet"; break;
                        case 896: eventLabels[i] = "Chest Green Item Collection"; break;
                        case 897: eventLabels[i] = "Chest Red Item Collection"; break;
                        case 898: eventLabels[i] = "Chest Blue Item Collection"; break;
                        case 899: eventLabels[i] = "Chest Yellow Item Collection"; break;
                        case 900: eventLabels[i] = "Chest Spell 1"; break;
                        case 901: eventLabels[i] = "Chest Spell 2"; break;
                        case 902: eventLabels[i] = "Chest Spell 3"; break;
                        case 903: eventLabels[i] = "Chest Spell 4"; break;
                        case 904: eventLabels[i] = "Chest Spell 5"; break;
                        case 905: eventLabels[i] = "Chest Spell 6"; break;
                        case 906: eventLabels[i] = "Chest Spell 7"; break;
                        case 907: eventLabels[i] = "Chest Spell 8"; break;
                        case 908: eventLabels[i] = "Chest Spell 9"; break;
                        case 909: eventLabels[i] = "Chest Spell 10"; break;
                        case 910: eventLabels[i] = "Chest Spell 11"; break;
                        case 911: eventLabels[i] = "Chest Spell 12"; break;
                        case 912: eventLabels[i] = "Chest Spell 13"; break;
                        case 913: eventLabels[i] = "Chest Spell 14"; break;
                        case 914: eventLabels[i] = "Chest Spell 15"; break;
                        case 915: eventLabels[i] = "Chest Spell 16"; break;
                        case 916: eventLabels[i] = "Chest Spell 17"; break;
                        case 917: eventLabels[i] = "Chest Beetle Packet"; break;
                        case 918: eventLabels[i] = "Chest Spell 18"; break;
                        case 919: eventLabels[i] = "Chest Spell 19"; break;
                        case 920: eventLabels[i] = "Chest Spell 20"; break;
                        case 921: eventLabels[i] = "Chest Spell 21"; break;
                        case 922: eventLabels[i] = "Chest Spell 22"; break;
                        case 923: eventLabels[i] = "Chest Spell 23"; break;
                        case 924: eventLabels[i] = "Chest Spell 24"; break;
                        case 925: eventLabels[i] = "Chest Spell 25"; break;
                        case 926: eventLabels[i] = "Chest Spell 26"; break;
                        case 927: eventLabels[i] = "Chest Spell 27"; break;
                        case 928: eventLabels[i] = "Unused"; break;
                        case 929: eventLabels[i] = "Unused"; break;
                        case 930: eventLabels[i] = "Yoshi Cookie Storage Business Logic"; break;
                        case 931: eventLabels[i] = "Initatie Yoshi Race For Gambling"; break;
                        case 932: eventLabels[i] = "Fat Yoshi"; break;
                        case 933: eventLabels[i] = "Fat Yoshi Present Generator"; break;
                        case 934: eventLabels[i] = "Progressive Firework Chest Packet"; break;
                        case 935: eventLabels[i] = "Marrymore Inn Regular Room Loader"; break;
                        case 936: eventLabels[i] = "Peck Subroutine Left Statue"; break;
                        case 937: eventLabels[i] = "Peck Subroutine Middle Statue"; break;
                        case 938: eventLabels[i] = "Peck Subroutine Right Statue"; break;
                        case 939: eventLabels[i] = "Statue Subroutine 1"; break;
                        case 940: eventLabels[i] = "Statue Subroutine 2"; break;
                        case 941: eventLabels[i] = "Keep First Boss Set Script"; break;
                        case 942: eventLabels[i] = "Keep First Boss Summon Chest"; break;
                        case 943: eventLabels[i] = "Keep Second Boss Animation Subroutine"; break;
                        case 944: eventLabels[i] = "Final Boss Animation Subroutine 1"; break;
                        case 945: eventLabels[i] = "Final Boss Animation Subroutine 2"; break;
                        case 946: eventLabels[i] = "Final Boss Animation Subroutine 3"; break;
                        case 947: eventLabels[i] = "Frogfucius Hint Main Checks"; break;
                        case 948: eventLabels[i] = "Frogfucius Hint Expansion"; break;
                        case 949: eventLabels[i] = "Frogfucius Hint Treasure Chests"; break;
                        case 950: eventLabels[i] = "Chest Glove Packet"; break;
                        case 951: eventLabels[i] = "Crystal Chest Packet"; break;
                        case 952: eventLabels[i] = "Npc Spell 1"; break;
                        case 953: eventLabels[i] = "Npc Spell 2"; break;
                        case 954: eventLabels[i] = "Npc Spell 3"; break;
                        case 955: eventLabels[i] = "Npc Spell 4"; break;
                        case 956: eventLabels[i] = "Npc Spell 5"; break;
                        case 957: eventLabels[i] = "Npc Spell 6"; break;
                        case 958: eventLabels[i] = "Npc Spell 7"; break;
                        case 959: eventLabels[i] = "Npc Spell 8"; break;
                        case 960: eventLabels[i] = "Npc Spell 9"; break;
                        case 961: eventLabels[i] = "Npc Spell 10"; break;
                        case 962: eventLabels[i] = "Npc Spell 11"; break;
                        case 963: eventLabels[i] = "Npc Spell 12"; break;
                        case 964: eventLabels[i] = "Npc Spell 13"; break;
                        case 965: eventLabels[i] = "Npc Spell 14"; break;
                        case 966: eventLabels[i] = "Npc Spell 16"; break;
                        case 967: eventLabels[i] = "Npc Spell 17"; break;
                        case 968: eventLabels[i] = "Npc Spell 18"; break;
                        case 969: eventLabels[i] = "Npc Spell 19"; break;
                        case 970: eventLabels[i] = "Npc Spell 20"; break;
                        case 971: eventLabels[i] = "Npc Spell 21"; break;
                        case 972: eventLabels[i] = "Npc Spell 22"; break;
                        case 973: eventLabels[i] = "Npc Spell 23"; break;
                        case 974: eventLabels[i] = "Npc Spell 24"; break;
                        case 975: eventLabels[i] = "Npc Spell 25"; break;
                        case 976: eventLabels[i] = "Npc Spell 26"; break;
                        case 977: eventLabels[i] = "Npc Spell 27"; break;
                        case 978: eventLabels[i] = "Freestanding Spell 1"; break;
                        case 979: eventLabels[i] = "Frogfucius Hint Optional Marrymore"; break;
                        case 980: eventLabels[i] = "Frogfucius Hint Marrymore Suite"; break;
                        case 981: eventLabels[i] = "Frogfucius Hint Optional 1"; break;
                        case 982: eventLabels[i] = "Frogfucius Hint Optional 2"; break;
                        case 983: eventLabels[i] = "Frogfucius Hint Optional 3"; break;
                        case 984: eventLabels[i] = "Frogfucius Hint Optional 4"; break;
                        case 985: eventLabels[i] = "Frogfucius Hint Optional 5"; break;
                        case 986: eventLabels[i] = "Frogfucius Hint Optional 6"; break;
                        case 987: eventLabels[i] = "Frogfucius Hint Optional 7"; break;
                        case 988: eventLabels[i] = "Frogfucius Hint Optional 8"; break;
                        case 989: eventLabels[i] = "Frogfucius Hint Optional 9"; break;
                        case 990: eventLabels[i] = "Frogfucius Hint Optional 10"; break;
                        case 991: eventLabels[i] = "Frogfucius Hint Dialogues"; break;
                        case 992: eventLabels[i] = "Freestanding Spell 2"; break;
                        case 993: eventLabels[i] = "Freestanding Spell 3"; break;
                        case 994: eventLabels[i] = "Freestanding Spell 4"; break;
                        case 995: eventLabels[i] = "Freestanding Spell 5"; break;
                        case 996: eventLabels[i] = "Freestanding Spell 6"; break;
                        case 997: eventLabels[i] = "Freestanding Spell 7"; break;
                        case 998: eventLabels[i] = "Set Star Hill As Checked"; break;
                        case 999: eventLabels[i] = "Freestanding Spell 8"; break;
                        case 1000: eventLabels[i] = "Freestanding Spell 9"; break;
                        case 1001: eventLabels[i] = "Freestanding Spell 10"; break;
                        case 1002: eventLabels[i] = "Freestanding Spell 11"; break;
                        case 1003: eventLabels[i] = "Freestanding Spell 12"; break;
                        case 1004: eventLabels[i] = "Freestanding Spell 13"; break;
                        case 1005: eventLabels[i] = "Freestanding Spell 14"; break;
                        case 1006: eventLabels[i] = "Freestanding Spell 16"; break;
                        case 1007: eventLabels[i] = "Freestanding Spell 17"; break;
                        case 1008: eventLabels[i] = "Post Mines Boss Subroutine"; break;
                        case 1009: eventLabels[i] = "Unknown"; break;
                        case 1010: eventLabels[i] = "Shyster Subroutine"; break;
                        case 1011: eventLabels[i] = "Post Mines Boss Check If Won"; break;
                        case 1012: eventLabels[i] = "Freestanding Spell 18"; break;
                        case 1013: eventLabels[i] = "Freestanding Spell 19"; break;
                        case 1014: eventLabels[i] = "Freestanding Spell 20"; break;
                        case 1015: eventLabels[i] = "Freestanding Spell 21"; break;
                        case 1016: eventLabels[i] = "Freestanding Spell 22"; break;
                        case 1017: eventLabels[i] = "Freestanding Spell 23"; break;
                        case 1018: eventLabels[i] = "Freestanding Spell 24"; break;
                        case 1019: eventLabels[i] = "Freestanding Spell 25"; break;
                        case 1020: eventLabels[i] = "Freestanding Spell 26"; break;
                        case 1021: eventLabels[i] = "Freestanding Spell 27"; break;
                        case 1022: eventLabels[i] = "Hill River Spell 1"; break;
                        case 1023: eventLabels[i] = "Hill River Spell 2"; break;
                        case 1024: eventLabels[i] = "Hill River Spell 3"; break;
                        case 1025: eventLabels[i] = "Hill River Spell 4"; break;
                        case 1026: eventLabels[i] = "Hill River Spell 5"; break;
                        case 1027: eventLabels[i] = "Hill River Spell 6"; break;
                        case 1028: eventLabels[i] = "Hill River Spell 7"; break;
                        case 1029: eventLabels[i] = "Hill River Spell 8"; break;
                        case 1030: eventLabels[i] = "Hill River Spell 9"; break;
                        case 1031: eventLabels[i] = "Hill River Spell 10"; break;
                        case 1032: eventLabels[i] = "Hill River Spell 11"; break;
                        case 1033: eventLabels[i] = "Hill River Spell 12"; break;
                        case 1034: eventLabels[i] = "Hill River Spell 13"; break;
                        case 1035: eventLabels[i] = "Hill River Spell 14"; break;
                        case 1036: eventLabels[i] = "Hill River Spell 16"; break;
                        case 1037: eventLabels[i] = "Hill River Spell 17"; break;
                        case 1038: eventLabels[i] = "Hill River Spell 18"; break;
                        case 1039: eventLabels[i] = "Hill River Spell 19"; break;
                        case 1040: eventLabels[i] = "Hill River Spell 20"; break;
                        case 1041: eventLabels[i] = "Hill River Spell 21"; break;
                        case 1042: eventLabels[i] = "Hill River Spell 22"; break;
                        case 1043: eventLabels[i] = "Hill River Spell 23"; break;
                        case 1044: eventLabels[i] = "Hill River Spell 24"; break;
                        case 1045: eventLabels[i] = "Hill River Spell 25"; break;
                        case 1046: eventLabels[i] = "Hill River Spell 26"; break;
                        case 1047: eventLabels[i] = "Hill River Spell 27"; break;
                        case 1048: eventLabels[i] = "Npc Spell 15"; break;
                        case 1049: eventLabels[i] = "Freestanding Spell 15"; break;
                        case 1050: eventLabels[i] = "Hill River Spell 15"; break;
                        case 1051: eventLabels[i] = "Empty"; break;
                        case 1052: eventLabels[i] = "Empty"; break;
                        case 1053: eventLabels[i] = "Empty"; break;
                        case 1054: eventLabels[i] = "Empty"; break;
                        case 1055: eventLabels[i] = "Empty"; break;
                        case 1056: eventLabels[i] = "Empty"; break;
                        case 1057: eventLabels[i] = "Empty"; break;
                        case 1058: eventLabels[i] = "Empty"; break;
                        case 1059: eventLabels[i] = "Empty"; break;
                        case 1060: eventLabels[i] = "Empty"; break;
                        case 1061: eventLabels[i] = "Empty"; break;
                        case 1062: eventLabels[i] = "Empty"; break;
                        case 1063: eventLabels[i] = "Empty"; break;
                        case 1064: eventLabels[i] = "Empty"; break;
                        case 1065: eventLabels[i] = "Empty"; break;
                        case 1066: eventLabels[i] = "Empty"; break;
                        case 1067: eventLabels[i] = "Empty"; break;
                        case 1068: eventLabels[i] = "Empty"; break;
                        case 1069: eventLabels[i] = "Empty"; break;
                        case 1070: eventLabels[i] = "Empty"; break;
                        case 1071: eventLabels[i] = "Begin Melody Bay Tadpoles"; break;
                        case 1072: eventLabels[i] = "Melody Bay Loader"; break;
                        case 1073: eventLabels[i] = "Melody Bay Jump On Tadpoles"; break;
                        case 1074: eventLabels[i] = "Melody Bay Song Judged"; break;
                        case 1075: eventLabels[i] = "Toadofsky"; break;
                        case 1076: eventLabels[i] = "Empty"; break;
                        case 1077: eventLabels[i] = "Empty"; break;
                        case 1078: eventLabels[i] = "Melody Bay Final Song"; break;
                        case 1079: eventLabels[i] = "Melody Bay Song 1 Validator"; break;
                        case 1080: eventLabels[i] = "Melody Bay Song 2 Validator"; break;
                        case 1081: eventLabels[i] = "Melody Bay Song 3 Validator"; break;
                        case 1082: eventLabels[i] = "Melody Bay Song 1 Input"; break;
                        case 1083: eventLabels[i] = "Melody Bay Song 2 Input"; break;
                        case 1084: eventLabels[i] = "Melody Bay Song 3 Input"; break;
                        case 1085: eventLabels[i] = "Melody Bay Jump Animation"; break;
                        case 1086: eventLabels[i] = "Melody Bay Swim Animation"; break;
                        case 1087: eventLabels[i] = "Melody Bay Exit Water Animation"; break;
                        case 1088: eventLabels[i] = "Melody Bay Third Song Hint"; break;
                        case 1089: eventLabels[i] = "Empty"; break;
                        case 1090: eventLabels[i] = "Empty"; break;
                        case 1091: eventLabels[i] = "Empty"; break;
                        case 1092: eventLabels[i] = "Empty"; break;
                        case 1093: eventLabels[i] = "Empty"; break;
                        case 1094: eventLabels[i] = "Empty"; break;
                        case 1095: eventLabels[i] = "Empty"; break;
                        case 1096: eventLabels[i] = "Empty"; break;
                        case 1097: eventLabels[i] = "Empty"; break;
                        case 1098: eventLabels[i] = "Empty"; break;
                        case 1099: eventLabels[i] = "Empty"; break;
                        case 1100: eventLabels[i] = "Empty"; break;
                        case 1101: eventLabels[i] = "Empty"; break;
                        case 1102: eventLabels[i] = "Empty"; break;
                        case 1103: eventLabels[i] = "Empty"; break;
                        case 1104: eventLabels[i] = "Tadpole Pond Loader"; break;
                        case 1105: eventLabels[i] = "Tadpole Bridge Summon"; break;
                        case 1106: eventLabels[i] = "Tadpole Bridge Summon"; break;
                        case 1107: eventLabels[i] = "Tadpole Bridge Jumping"; break;
                        case 1108: eventLabels[i] = "Frogfucius Scroll"; break;
                        case 1109: eventLabels[i] = "Empty"; break;
                        case 1110: eventLabels[i] = "Empty"; break;
                        case 1111: eventLabels[i] = "Frogfucius"; break;
                        case 1112: eventLabels[i] = "Frog Coin Emporium"; break;
                        case 1113: eventLabels[i] = "Song Hint Tadpole"; break;
                        case 1114: eventLabels[i] = "Summon Tadpole Shops"; break;
                        case 1115: eventLabels[i] = "Summon Hint Tadpole"; break;
                        case 1116: eventLabels[i] = "Juice Bar"; break;
                        case 1117: eventLabels[i] = "Empty"; break;
                        case 1118: eventLabels[i] = "Empty"; break;
                        case 1119: eventLabels[i] = "Seaside Occupied Exterior Loader"; break;
                        case 1120: eventLabels[i] = "Empty"; break;
                        case 1121: eventLabels[i] = "Seaside Occupied Inn 1F Loader"; break;
                        case 1122: eventLabels[i] = "Seaside Occupied Inn 2F Loader"; break;
                        case 1123: eventLabels[i] = "Seaside Occupied Elders House Loader"; break;
                        case 1124: eventLabels[i] = "Frog Shop Room Loader"; break;
                        case 1125: eventLabels[i] = "Seaside Occupied Bomb Shop Loader"; break;
                        case 1126: eventLabels[i] = "Seaside Occupied Armor Shop Loader"; break;
                        case 1127: eventLabels[i] = "Seaside Occupied Health Store Loader"; break;
                        case 1128: eventLabels[i] = "Seaside Occupied Mushroom Boy Shop Loader"; break;
                        case 1129: eventLabels[i] = "Seaside Occupied Accessory Shop Loader"; break;
                        case 1130: eventLabels[i] = "Empty"; break;
                        case 1131: eventLabels[i] = "Empty"; break;
                        case 1132: eventLabels[i] = "Seaside Occupied Innkeeper"; break;
                        case 1133: eventLabels[i] = "Seaside Occupied Accessory Shop Occupant"; break;
                        case 1134: eventLabels[i] = "Fake Elder"; break;
                        case 1135: eventLabels[i] = "Seaside Occupied Mushroom Boy Shop Occupant 1"; break;
                        case 1136: eventLabels[i] = "Seaside Occupied Mushroom Boy Shop Occupant 2"; break;
                        case 1137: eventLabels[i] = "Seaside Occupied Health Store Occupant"; break;
                        case 1138: eventLabels[i] = "Seaside Occupied Wpn Arm Shop Occupant 1"; break;
                        case 1139: eventLabels[i] = "Seaside Occupied Wpn Arm Shop Occupant 2"; break;
                        case 1140: eventLabels[i] = "Seaside Occupied Bomb Shop"; break;
                        case 1141: eventLabels[i] = "Seaside Occupied Bomb Shop Customer"; break;
                        case 1142: eventLabels[i] = "Seaside Shed Guard 1"; break;
                        case 1143: eventLabels[i] = "Seaside Shed Guard 2"; break;
                        case 1144: eventLabels[i] = "Shed Window"; break;
                        case 1145: eventLabels[i] = "Seaside Occupied Beach Loader"; break;
                        case 1146: eventLabels[i] = "Seaside Initiate Boss Fight"; break;
                        case 1147: eventLabels[i] = "Seaside Initiate Boss Fight Animation"; break;
                        case 1148: eventLabels[i] = "Frog Shop"; break;
                        case 1149: eventLabels[i] = "Empty"; break;
                        case 1150: eventLabels[i] = "Empty"; break;
                        case 1151: eventLabels[i] = "Empty"; break;
                        case 1152: eventLabels[i] = "Empty"; break;
                        case 1153: eventLabels[i] = "Seaside Liberated Inn 1F Loader"; break;
                        case 1154: eventLabels[i] = "Empty"; break;
                        case 1155: eventLabels[i] = "Seaside Liberated Elders House Loader"; break;
                        case 1156: eventLabels[i] = "Empty"; break;
                        case 1157: eventLabels[i] = "Empty"; break;
                        case 1158: eventLabels[i] = "Seaside Liberated Wpn Arm Shop Loader"; break;
                        case 1159: eventLabels[i] = "Seaside Liberated Health Store Loader"; break;
                        case 1160: eventLabels[i] = "Seaside Liberated Mushroom Boy Loader"; break;
                        case 1161: eventLabels[i] = "Seaside Liberated Accessory Shop Loader"; break;
                        case 1162: eventLabels[i] = "Seaside Liberated Shed Loader"; break;
                        case 1163: eventLabels[i] = "Seaside Liberated Beach"; break;
                        case 1164: eventLabels[i] = "Empty"; break;
                        case 1165: eventLabels[i] = "Seaside Liberated Beach Letter"; break;
                        case 1166: eventLabels[i] = "Shed Key Door"; break;
                        case 1167: eventLabels[i] = "Seaside Elder"; break;
                        case 1168: eventLabels[i] = "Seaside Liberated Innkeeper"; break;
                        case 1169: eventLabels[i] = "Open Lands End If Gated By Elder"; break;
                        case 1170: eventLabels[i] = "Seaside Health Food Shop"; break;
                        case 1171: eventLabels[i] = "Seaside Accessory Shop"; break;
                        case 1172: eventLabels[i] = "Mushroom Boy"; break;
                        case 1173: eventLabels[i] = "Seaside Weapon Shop"; break;
                        case 1174: eventLabels[i] = "Seaside Armor Shop"; break;
                        case 1175: eventLabels[i] = "Empty"; break;
                        case 1176: eventLabels[i] = "Empty"; break;
                        case 1177: eventLabels[i] = "Empty"; break;
                        case 1178: eventLabels[i] = "Seaside Grant Shed Item"; break;
                        case 1179: eventLabels[i] = "Juice Bar No Card"; break;
                        case 1180: eventLabels[i] = "Juice Bar Alto Card"; break;
                        case 1181: eventLabels[i] = "Juice Bar Tenor Card"; break;
                        case 1182: eventLabels[i] = "Juice Bar Soprano Card"; break;
                        case 1183: eventLabels[i] = "Volcano Item Shop"; break;
                        case 1184: eventLabels[i] = "Volcano Armor Shop"; break;
                        case 1185: eventLabels[i] = "Toad Shop"; break;
                        case 1186: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1187: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1188: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1189: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1190: eventLabels[i] = "Henchman Battle Pack Selector"; break;
                        case 1191: eventLabels[i] = "Ending Credits Cliff Shuffled Npc Animation Loader"; break;
                        case 1192: eventLabels[i] = "Ending Credits Keep Shuffled Npc Animation Loader"; break;
                        case 1193: eventLabels[i] = "Ending Credits Yoster Shuffled Npc Animation Loader"; break;
                        case 1194: eventLabels[i] = "Mushroom Way Boss Unlocks"; break;
                        case 1195: eventLabels[i] = "Bandits Way Boss Unlocks"; break;
                        case 1196: eventLabels[i] = "Mushroom Kingdom Boss Unlocks"; break;
                        case 1197: eventLabels[i] = "Kero Sewer Boss Unlocks"; break;
                        case 1198: eventLabels[i] = "Forest Maze Boss Unlocks"; break;
                        case 1199: eventLabels[i] = "Outer Mnes Boss Unlocks"; break;
                        case 1200: eventLabels[i] = "Inner Mines Boss Unlocks"; break;
                        case 1201: eventLabels[i] = "Tower Curtain Boss Unlocks"; break;
                        case 1202: eventLabels[i] = "Postgame Tower Curtain Boss Unlocks"; break;
                        case 1203: eventLabels[i] = "Tower Balcony Boss Unlocks"; break;
                        case 1204: eventLabels[i] = "Chapel Boss Unlocks"; break;
                        case 1205: eventLabels[i] = "Postgame Chapel Boss Unlocks"; break;
                        case 1206: eventLabels[i] = "Seaside Boss Unlocks"; break;
                        case 1207: eventLabels[i] = "Ship Mid Boss Unlocks"; break;
                        case 1208: eventLabels[i] = "Ship End Boss Unlocks"; break;
                        case 1209: eventLabels[i] = "Postgame Ship End Boss Unlocks"; break;
                        case 1210: eventLabels[i] = "Cloud Boss Unlocks"; break;
                        case 1211: eventLabels[i] = "Temple Boss Unlocks"; break;
                        case 1212: eventLabels[i] = "Postgame Temple Boss Unlocks"; break;
                        case 1213: eventLabels[i] = "Dojo 1 Boss Unlocks"; break;
                        case 1214: eventLabels[i] = "Dojo 2 Boss Unlocks"; break;
                        case 1215: eventLabels[i] = "Dojo 3 Boss Unlocks"; break;
                        case 1216: eventLabels[i] = "Dojo 4 Boss Unlocks"; break;
                        case 1217: eventLabels[i] = "Dojo 5 Boss Unlocks"; break;
                        case 1218: eventLabels[i] = "Monstro Sealed Boss Unlocks"; break;
                        case 1219: eventLabels[i] = "Postgame Monstro Sealed Boss Unlocks"; break;
                        case 1220: eventLabels[i] = "Starting Character 1"; break;
                        case 1221: eventLabels[i] = "Starting Character 2"; break;
                        case 1222: eventLabels[i] = "Starting Character 3"; break;
                        case 1223: eventLabels[i] = "Starting Character 4"; break;
                        case 1224: eventLabels[i] = "Starting Character 5"; break;
                        case 1225: eventLabels[i] = "Mushroom Way Character"; break;
                        case 1226: eventLabels[i] = "Forest Maze Character"; break;
                        case 1227: eventLabels[i] = "Moleville Character"; break;
                        case 1228: eventLabels[i] = "Marrymore Character"; break;
                        case 1229: eventLabels[i] = "Bean Valley Boss Unlocks"; break;
                        case 1230: eventLabels[i] = "Statue Boss Unlocks"; break;
                        case 1231: eventLabels[i] = "Egg Boss Unlocks"; break;
                        case 1232: eventLabels[i] = "Nimbus Boss Unlocks"; break;
                        case 1233: eventLabels[i] = "Volcano Mid Boss Unlocks"; break;
                        case 1234: eventLabels[i] = "Volcano Boss Unlocks"; break;
                        case 1235: eventLabels[i] = "Obstacle Course Boss Unlocks"; break;
                        case 1236: eventLabels[i] = "Keep 1 Boss Unlocks"; break;
                        case 1237: eventLabels[i] = "Keep Chandelier Boss Unlocks"; break;
                        case 1238: eventLabels[i] = "Keep Exit Boss Unlocks"; break;
                        case 1239: eventLabels[i] = "Outer Factory 1 Boss Unlocks"; break;
                        case 1240: eventLabels[i] = "Outer Factory 2 Boss Unlocks"; break;
                        case 1241: eventLabels[i] = "Inner Factory 1 Boss Unlocks"; break;
                        case 1242: eventLabels[i] = "Inner Factory 2 Boss Unlocks"; break;
                        case 1243: eventLabels[i] = "Inner Factory 3 Boss Unlocks"; break;
                        case 1244: eventLabels[i] = "Inner Factory 4 Boss Unlocks"; break;
                        case 1245: eventLabels[i] = "Inner Factory 5 Boss Unlocks"; break;
                        case 1246: eventLabels[i] = "Invisible Grant 1"; break;
                        case 1247: eventLabels[i] = "Invisible Grant 2"; break;
                        case 1248: eventLabels[i] = "Invisible Grant 3"; break;
                        case 1249: eventLabels[i] = "Mimic 1 Boss Unlocks"; break;
                        case 1250: eventLabels[i] = "Mimic 2 Boss Unlocks"; break;
                        case 1251: eventLabels[i] = "Mimic 3 Boss Unlocks"; break;
                        case 1252: eventLabels[i] = "Flag Specific Housekeeping Game Start"; break;
                        case 1253: eventLabels[i] = "Postgame Mines Boss Unlocks"; break;
                        case 1254: eventLabels[i] = "Unlock Sewer By Rfc"; break;
                        case 1255: eventLabels[i] = "Unlock Forest By Pie"; break;
                        case 1256: eventLabels[i] = "Unlock Moleville If Gated By Boshi"; break;
                        case 1257: eventLabels[i] = "Empty"; break;
                        case 1258: eventLabels[i] = "Empty"; break;
                        case 1259: eventLabels[i] = "Empty"; break;
                        case 1260: eventLabels[i] = "Empty"; break;
                        case 1261: eventLabels[i] = "Empty"; break;
                        case 1262: eventLabels[i] = "Empty"; break;
                        case 1263: eventLabels[i] = "Empty"; break;
                        case 1264: eventLabels[i] = "Empty"; break;
                        case 1265: eventLabels[i] = "Empty"; break;
                        case 1266: eventLabels[i] = "Empty"; break;
                        case 1267: eventLabels[i] = "Empty"; break;
                        case 1268: eventLabels[i] = "Empty"; break;
                        case 1269: eventLabels[i] = "Empty"; break;
                        case 1270: eventLabels[i] = "Empty"; break;
                        case 1271: eventLabels[i] = "Empty"; break;
                        case 1272: eventLabels[i] = "Empty"; break;
                        case 1273: eventLabels[i] = "Empty"; break;
                        case 1274: eventLabels[i] = "Ship Boss Room Rightmost Henchman"; break;
                        case 1275: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Henchman"; break;
                        case 1276: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Henchman"; break;
                        case 1277: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Henchman"; break;
                        case 1278: eventLabels[i] = "Mushroom Kingdom Occupied Exterior Henchman"; break;
                        case 1279: eventLabels[i] = "Empty"; break;
                        case 1280: eventLabels[i] = "Empty"; break;
                        case 1281: eventLabels[i] = "Empty"; break;
                        case 1282: eventLabels[i] = "Tower Balcony Loader After Marrymore"; break;
                        case 1283: eventLabels[i] = "Tower Balcony Loader Before Marrymore"; break;
                        case 1284: eventLabels[i] = "Empty"; break;
                        case 1285: eventLabels[i] = "Empty"; break;
                        case 1286: eventLabels[i] = "Empty"; break;
                        case 1287: eventLabels[i] = "Empty"; break;
                        case 1288: eventLabels[i] = "Empty"; break;
                        case 1289: eventLabels[i] = "Empty"; break;
                        case 1290: eventLabels[i] = "Empty"; break;
                        case 1291: eventLabels[i] = "Empty"; break;
                        case 1292: eventLabels[i] = "Empty"; break;
                        case 1293: eventLabels[i] = "Collect Freestanding Small Coin"; break;
                        case 1294: eventLabels[i] = "Collect Freestanding Small Frog Coin"; break;
                        case 1295: eventLabels[i] = "Tower Checkerboard Room Loader"; break;
                        case 1296: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1297: eventLabels[i] = "Empty"; break;
                        case 1298: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1299: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1300: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1301: eventLabels[i] = "Empty"; break;
                        case 1302: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1303: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1304: eventLabels[i] = "Empty"; break;
                        case 1305: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1306: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1307: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1308: eventLabels[i] = "Tower Checkerboard Room Fireball Launcher"; break;
                        case 1309: eventLabels[i] = "Empty"; break;
                        case 1310: eventLabels[i] = "Tower Checkerboard Collect Key Item"; break;
                        case 1311: eventLabels[i] = "Tower Checkerboard Locked Door"; break;
                        case 1312: eventLabels[i] = "Tower Lobby Loader"; break;
                        case 1313: eventLabels[i] = "Empty"; break;
                        case 1314: eventLabels[i] = "Tower Boss 1 Hides Behind Doorway In Lobby 1"; break;
                        case 1315: eventLabels[i] = "Tower Boss 1 Hides Behind Doorway In Lobby 2"; break;
                        case 1316: eventLabels[i] = "Lobby Portrait 1"; break;
                        case 1317: eventLabels[i] = "Lobby Portrait 2"; break;
                        case 1318: eventLabels[i] = "Lobby Portrait 3"; break;
                        case 1319: eventLabels[i] = "Lobby Portrait 4"; break;
                        case 1320: eventLabels[i] = "Lobby Portrait 5"; break;
                        case 1321: eventLabels[i] = "Lobby Portrait 6"; break;
                        case 1322: eventLabels[i] = "Nimbus 5 Door Chest Liberated"; break;
                        case 1323: eventLabels[i] = "Tower Lobby Henchman"; break;
                        case 1324: eventLabels[i] = "Empty"; break;
                        case 1325: eventLabels[i] = "Empty"; break;
                        case 1326: eventLabels[i] = "Empty"; break;
                        case 1327: eventLabels[i] = "Empty"; break;
                        case 1328: eventLabels[i] = "Tower Exterior Loader"; break;
                        case 1329: eventLabels[i] = "Hill Unlocks"; break;
                        case 1330: eventLabels[i] = "Tower Exterior Door"; break;
                        case 1331: eventLabels[i] = "Tower Break Down Door"; break;
                        case 1332: eventLabels[i] = "Portrait Game 1"; break;
                        case 1333: eventLabels[i] = "Portrait Game 2"; break;
                        case 1334: eventLabels[i] = "Portrait Game 3"; break;
                        case 1335: eventLabels[i] = "Portrait Game 4"; break;
                        case 1336: eventLabels[i] = "Portrait Game 5"; break;
                        case 1337: eventLabels[i] = "Portrait Game 6"; break;
                        case 1338: eventLabels[i] = "Portrait Game Incorrect"; break;
                        case 1339: eventLabels[i] = "Portrait Game Room Loader"; break;
                        case 1340: eventLabels[i] = "Portrait Game Room Locked Door"; break;
                        case 1341: eventLabels[i] = "Elder Key Prize Room Loader"; break;
                        case 1342: eventLabels[i] = "Elder Key Prize Granter"; break;
                        case 1343: eventLabels[i] = "Portrait Game Instructions"; break;
                        case 1344: eventLabels[i] = "Tower Henchman 2 Room Loader"; break;
                        case 1345: eventLabels[i] = "Empty"; break;
                        case 1346: eventLabels[i] = "Tower Henchman 2"; break;
                        case 1347: eventLabels[i] = "Tower Henchman 2 Room Hidden Item"; break;
                        case 1348: eventLabels[i] = "Empty"; break;
                        case 1349: eventLabels[i] = "Empty"; break;
                        case 1350: eventLabels[i] = "Empty"; break;
                        case 1351: eventLabels[i] = "Empty"; break;
                        case 1352: eventLabels[i] = "Empty"; break;
                        case 1353: eventLabels[i] = "Tower Checkerboard Room Locked Door"; break;
                        case 1354: eventLabels[i] = "Empty"; break;
                        case 1355: eventLabels[i] = "Empty"; break;
                        case 1356: eventLabels[i] = "Empty"; break;
                        case 1357: eventLabels[i] = "Empty"; break;
                        case 1358: eventLabels[i] = "Curtain Game Begins Npcs Walk Into Room"; break;
                        case 1359: eventLabels[i] = "Curtain Game Room Loader"; break;
                        case 1360: eventLabels[i] = "Curtain 1"; break;
                        case 1361: eventLabels[i] = "Curtain 2"; break;
                        case 1362: eventLabels[i] = "Curtain 3"; break;
                        case 1363: eventLabels[i] = "Curtain 4"; break;
                        case 1364: eventLabels[i] = "Curtain Room Exit To Balcony"; break;
                        case 1365: eventLabels[i] = "Curtain Game Business Logic 1"; break;
                        case 1366: eventLabels[i] = "Curtain Game Business Logic 2"; break;
                        case 1367: eventLabels[i] = "Curtain Game Success 1"; break;
                        case 1368: eventLabels[i] = "Curtain Game Success 2"; break;
                        case 1369: eventLabels[i] = "Curtain Game Success Failure Fight Boss"; break;
                        case 1370: eventLabels[i] = "Curtain Game Success Failure General"; break;
                        case 1371: eventLabels[i] = "Unlock Marrymore If Gated By Tower Balcony Fight"; break;
                        case 1372: eventLabels[i] = "Toad Voucher Grant"; break;
                        case 1373: eventLabels[i] = "Empty"; break;
                        case 1374: eventLabels[i] = "Empty"; break;
                        case 1375: eventLabels[i] = "Empty"; break;
                        case 1376: eventLabels[i] = "Empty"; break;
                        case 1377: eventLabels[i] = "Empty"; break;
                        case 1378: eventLabels[i] = "Empty"; break;
                        case 1379: eventLabels[i] = "Empty"; break;
                        case 1380: eventLabels[i] = "Empty"; break;
                        case 1381: eventLabels[i] = "Empty"; break;
                        case 1382: eventLabels[i] = "Empty"; break;
                        case 1383: eventLabels[i] = "Empty"; break;
                        case 1384: eventLabels[i] = "Empty"; break;
                        case 1385: eventLabels[i] = "Vista Hill Loader"; break;
                        case 1386: eventLabels[i] = "Vista Hill Loader Continued"; break;
                        case 1387: eventLabels[i] = "Empty"; break;
                        case 1388: eventLabels[i] = "Empty"; break;
                        case 1389: eventLabels[i] = "Empty"; break;
                        case 1390: eventLabels[i] = "Empty"; break;
                        case 1391: eventLabels[i] = "Empty"; break;
                        case 1392: eventLabels[i] = "Marios House Interior Loader"; break;
                        case 1393: eventLabels[i] = "Empty"; break;
                        case 1394: eventLabels[i] = "Four Digit Coin Value Handler"; break;
                        case 1395: eventLabels[i] = "Marios House Lamp"; break;
                        case 1396: eventLabels[i] = "Empty"; break;
                        case 1397: eventLabels[i] = "Empty"; break;
                        case 1398: eventLabels[i] = "Empty"; break;
                        case 1399: eventLabels[i] = "Empty"; break;
                        case 1400: eventLabels[i] = "Empty"; break;
                        case 1401: eventLabels[i] = "Empty"; break;
                        case 1402: eventLabels[i] = "Empty"; break;
                        case 1403: eventLabels[i] = "Empty"; break;
                        case 1404: eventLabels[i] = "Empty"; break;
                        case 1405: eventLabels[i] = "Empty"; break;
                        case 1406: eventLabels[i] = "Marios Pad Open Door"; break;
                        case 1407: eventLabels[i] = "Marios Pad Close Door"; break;
                        case 1408: eventLabels[i] = "Marios Pad Exterior Loader"; break;
                        case 1409: eventLabels[i] = "Empty"; break;
                        case 1410: eventLabels[i] = "Empty"; break;
                        case 1411: eventLabels[i] = "Empty"; break;
                        case 1412: eventLabels[i] = "Empty"; break;
                        case 1413: eventLabels[i] = "Empty"; break;
                        case 1414: eventLabels[i] = "Empty"; break;
                        case 1415: eventLabels[i] = "Empty"; break;
                        case 1416: eventLabels[i] = "Empty"; break;
                        case 1417: eventLabels[i] = "Empty"; break;
                        case 1418: eventLabels[i] = "Empty"; break;
                        case 1419: eventLabels[i] = "Mushroom Way 1 Exit To World Map"; break;
                        case 1420: eventLabels[i] = "Empty"; break;
                        case 1421: eventLabels[i] = "Empty"; break;
                        case 1422: eventLabels[i] = "Rescue Toad Mushroom Way 2"; break;
                        case 1423: eventLabels[i] = "Mushroom Way 2 Loader"; break;
                        case 1424: eventLabels[i] = "Mushroom Way 2 Lone Troopa"; break;
                        case 1425: eventLabels[i] = "Summon Left Goomba In Mushroom Way 2"; break;
                        case 1426: eventLabels[i] = "Summon Right Goomba In Mushroom Way 2"; break;
                        case 1427: eventLabels[i] = "Mushroom Way 1 Loader"; break;
                        case 1428: eventLabels[i] = "Rescue Toad Mushroom Way 1"; break;
                        case 1429: eventLabels[i] = "Summon Jumping Goomba Mushroom Way 2"; break;
                        case 1430: eventLabels[i] = "Mushroom Way 2 Spinning Flower"; break;
                        case 1431: eventLabels[i] = "Summon Middle Goomba In Mushroom Way 2"; break;
                        case 1432: eventLabels[i] = "Rescue Toad Extended"; break;
                        case 1433: eventLabels[i] = "Clone Reserved"; break;
                        case 1434: eventLabels[i] = "Clone Reserved"; break;
                        case 1435: eventLabels[i] = "Clone Reserved"; break;
                        case 1436: eventLabels[i] = "Clone Reserved"; break;
                        case 1437: eventLabels[i] = "Clone Reserved"; break;
                        case 1438: eventLabels[i] = "Clone Reserved"; break;
                        case 1439: eventLabels[i] = "Clone Reserved"; break;
                        case 1440: eventLabels[i] = "Clone Reserved"; break;
                        case 1441: eventLabels[i] = "Clone Reserved"; break;
                        case 1442: eventLabels[i] = "Clone Reserved"; break;
                        case 1443: eventLabels[i] = "Clone Reserved"; break;
                        case 1444: eventLabels[i] = "Clone Reserved"; break;
                        case 1445: eventLabels[i] = "Clone Reserved"; break;
                        case 1446: eventLabels[i] = "Clone Reserved"; break;
                        case 1447: eventLabels[i] = "Clone Reserved"; break;
                        case 1448: eventLabels[i] = "Clone Reserved"; break;
                        case 1449: eventLabels[i] = "Clone Reserved"; break;
                        case 1450: eventLabels[i] = "Clone Reserved"; break;
                        case 1451: eventLabels[i] = "Clone Reserved"; break;
                        case 1452: eventLabels[i] = "Clone Reserved"; break;
                        case 1453: eventLabels[i] = "Clone Reserved"; break;
                        case 1454: eventLabels[i] = "Clone Reserved"; break;
                        case 1455: eventLabels[i] = "Clone Reserved"; break;
                        case 1456: eventLabels[i] = "Clone Reserved"; break;
                        case 1457: eventLabels[i] = "Clone Reserved"; break;
                        case 1458: eventLabels[i] = "Clone Reserved"; break;
                        case 1459: eventLabels[i] = "Clone Reserved"; break;
                        case 1460: eventLabels[i] = "Clone Reserved"; break;
                        case 1461: eventLabels[i] = "Clone Reserved"; break;
                        case 1462: eventLabels[i] = "Clone Reserved"; break;
                        case 1463: eventLabels[i] = "Clone Reserved"; break;
                        case 1464: eventLabels[i] = "Clone Reserved"; break;
                        case 1465: eventLabels[i] = "Clone Reserved"; break;
                        case 1466: eventLabels[i] = "Clone Reserved"; break;
                        case 1467: eventLabels[i] = "Clone Reserved"; break;
                        case 1468: eventLabels[i] = "Clone Reserved"; break;
                        case 1469: eventLabels[i] = "Clone Reserved"; break;
                        case 1470: eventLabels[i] = "Clone Reserved"; break;
                        case 1471: eventLabels[i] = "Clone Reserved"; break;
                        case 1472: eventLabels[i] = "Clone Reserved"; break;
                        case 1473: eventLabels[i] = "Clone Reserved"; break;
                        case 1474: eventLabels[i] = "Clone Reserved"; break;
                        case 1475: eventLabels[i] = "Clone Reserved"; break;
                        case 1476: eventLabels[i] = "Clone Reserved"; break;
                        case 1477: eventLabels[i] = "Clone Reserved"; break;
                        case 1478: eventLabels[i] = "Clone Reserved"; break;
                        case 1479: eventLabels[i] = "Clone Reserved"; break;
                        case 1480: eventLabels[i] = "Clone Reserved"; break;
                        case 1481: eventLabels[i] = "Clone Reserved"; break;
                        case 1482: eventLabels[i] = "Clone Reserved"; break;
                        case 1483: eventLabels[i] = "Clone Reserved"; break;
                        case 1484: eventLabels[i] = "Clone Reserved"; break;
                        case 1485: eventLabels[i] = "Clone Reserved"; break;
                        case 1486: eventLabels[i] = "Clone Reserved"; break;
                        case 1487: eventLabels[i] = "Clone Reserved"; break;
                        case 1488: eventLabels[i] = "Clone Reserved"; break;
                        case 1489: eventLabels[i] = "Clone Reserved"; break;
                        case 1490: eventLabels[i] = "Clone Reserved"; break;
                        case 1491: eventLabels[i] = "Clone Reserved"; break;
                        case 1492: eventLabels[i] = "Clone Reserved"; break;
                        case 1493: eventLabels[i] = "Clone Reserved"; break;
                        case 1494: eventLabels[i] = "Clone Reserved"; break;
                        case 1495: eventLabels[i] = "Clone Reserved"; break;
                        case 1496: eventLabels[i] = "Clone Reserved"; break;
                        case 1497: eventLabels[i] = "Clone Reserved"; break;
                        case 1498: eventLabels[i] = "Clone Reserved"; break;
                        case 1499: eventLabels[i] = "Clone Reserved"; break;
                        case 1500: eventLabels[i] = "Clone Reserved"; break;
                        case 1501: eventLabels[i] = "Clone Reserved"; break;
                        case 1502: eventLabels[i] = "Clone Reserved"; break;
                        case 1503: eventLabels[i] = "Clone Reserved"; break;
                        case 1504: eventLabels[i] = "Clone Reserved"; break;
                        case 1505: eventLabels[i] = "Clone Reserved"; break;
                        case 1506: eventLabels[i] = "Clone Reserved"; break;
                        case 1507: eventLabels[i] = "Clone Reserved"; break;
                        case 1508: eventLabels[i] = "Clone Reserved"; break;
                        case 1509: eventLabels[i] = "Clone Reserved"; break;
                        case 1510: eventLabels[i] = "Clone Reserved"; break;
                        case 1511: eventLabels[i] = "Clone Reserved"; break;
                        case 1512: eventLabels[i] = "Clone Reserved"; break;
                        case 1513: eventLabels[i] = "Clone Reserved"; break;
                        case 1514: eventLabels[i] = "Clone Reserved"; break;
                        case 1515: eventLabels[i] = "Clone Reserved"; break;
                        case 1516: eventLabels[i] = "Clone Reserved"; break;
                        case 1517: eventLabels[i] = "Clone Reserved"; break;
                        case 1518: eventLabels[i] = "Clone Reserved"; break;
                        case 1519: eventLabels[i] = "Clone Reserved"; break;
                        case 1520: eventLabels[i] = "Clone Reserved"; break;
                        case 1521: eventLabels[i] = "Clone Reserved"; break;
                        case 1522: eventLabels[i] = "Clone Reserved"; break;
                        case 1523: eventLabels[i] = "Clone Reserved"; break;
                        case 1524: eventLabels[i] = "Clone Reserved"; break;
                        case 1525: eventLabels[i] = "Clone Reserved"; break;
                        case 1526: eventLabels[i] = "Clone Reserved"; break;
                        case 1527: eventLabels[i] = "Clone Reserved"; break;
                        case 1528: eventLabels[i] = "Clone Reserved"; break;
                        case 1529: eventLabels[i] = "Clone Reserved"; break;
                        case 1530: eventLabels[i] = "Clone Reserved"; break;
                        case 1531: eventLabels[i] = "Clone Reserved"; break;
                        case 1532: eventLabels[i] = "Clone Reserved"; break;
                        case 1533: eventLabels[i] = "Clone Reserved"; break;
                        case 1534: eventLabels[i] = "Clone Reserved"; break;
                        case 1535: eventLabels[i] = "Clone Reserved"; break;
                        case 1536: eventLabels[i] = "Empty"; break;
                        case 1537: eventLabels[i] = "Spinning Flower Core Logic"; break;
                        case 1538: eventLabels[i] = "Bandits Way Star Chest Camera And Dogs"; break;
                        case 1539: eventLabels[i] = "Empty"; break;
                        case 1540: eventLabels[i] = "Unknown"; break;
                        case 1541: eventLabels[i] = "Unknown"; break;
                        case 1542: eventLabels[i] = "Forest Maze Pipe"; break;
                        case 1543: eventLabels[i] = "Chest Camera Shift"; break;
                        case 1544: eventLabels[i] = "Sand Whirlpool"; break;
                        case 1545: eventLabels[i] = "Sand Whirlpool"; break;
                        case 1546: eventLabels[i] = "Lands End First Two Chests"; break;
                        case 1547: eventLabels[i] = "Lands End Third Chest"; break;
                        case 1548: eventLabels[i] = "Empty"; break;
                        case 1549: eventLabels[i] = "Sky Bridge Donut Lift"; break;
                        case 1550: eventLabels[i] = "Clear Bucket Warp Bit"; break;
                        case 1551: eventLabels[i] = "Bank 1F Return Event"; break;
                        case 1552: eventLabels[i] = "Forest Tree Trunk Area Loader"; break;
                        case 1553: eventLabels[i] = "Forest Tree Trunk Area Loader Contd"; break;
                        case 1554: eventLabels[i] = "Forest First Wiggler Room Loader"; break;
                        case 1555: eventLabels[i] = "Forest First Wiggler Room Loader Contd"; break;
                        case 1556: eventLabels[i] = "Wiggler Jump"; break;
                        case 1557: eventLabels[i] = "Forest Maze Past Trunk Area Room Loader"; break;
                        case 1558: eventLabels[i] = "Lands End Spinny Flower 1"; break;
                        case 1559: eventLabels[i] = "Lands End Spinny Flower 2"; break;
                        case 1560: eventLabels[i] = "Lands End Spinny Flower 3"; break;
                        case 1561: eventLabels[i] = "Lands End Geckit Cannon Room Loader"; break;
                        case 1562: eventLabels[i] = "Lands End Cannon"; break;
                        case 1563: eventLabels[i] = "Lands End Mario Oob"; break;
                        case 1564: eventLabels[i] = "Lands End Cannon Contd"; break;
                        case 1565: eventLabels[i] = "Empty"; break;
                        case 1566: eventLabels[i] = "Lands End Dog Pit"; break;
                        case 1567: eventLabels[i] = "Lands End 2 Loader"; break;
                        case 1568: eventLabels[i] = "Midas River Begin Barrel Section"; break;
                        case 1569: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1570: eventLabels[i] = "Midas River Fish"; break;
                        case 1571: eventLabels[i] = "Midas River Barrel Section Business Logic"; break;
                        case 1572: eventLabels[i] = "Midas River Coin"; break;
                        case 1573: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1574: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1575: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1576: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1577: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1578: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1579: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1580: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1581: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1582: eventLabels[i] = "Lands End Trampoline To Sewer"; break;
                        case 1583: eventLabels[i] = "Lands End Underground Trampoline To Desert"; break;
                        case 1584: eventLabels[i] = "Temple Final Room Loader"; break;
                        case 1585: eventLabels[i] = "Midas River Barrel Subroutine"; break;
                        case 1586: eventLabels[i] = "Midas River Barrel Fish Movement"; break;
                        case 1587: eventLabels[i] = "Bandits Way 4 Right Chest"; break;
                        case 1588: eventLabels[i] = "Lands End Grotto Chest"; break;
                        case 1589: eventLabels[i] = "Lands End Grotto Trampoline To Surface"; break;
                        case 1590: eventLabels[i] = "Sewer Pipe To Lands End Subroutine"; break;
                        case 1591: eventLabels[i] = "Lands End Grotto Barrel Kick"; break;
                        case 1592: eventLabels[i] = "Belome Statue"; break;
                        case 1593: eventLabels[i] = "Empty"; break;
                        case 1594: eventLabels[i] = "Empty"; break;
                        case 1595: eventLabels[i] = "Empty"; break;
                        case 1596: eventLabels[i] = "Empty"; break;
                        case 1597: eventLabels[i] = "Empty"; break;
                        case 1598: eventLabels[i] = "Empty"; break;
                        case 1599: eventLabels[i] = "Empty"; break;
                        case 1600: eventLabels[i] = "Empty"; break;
                        case 1601: eventLabels[i] = "Lands End 1St Room Exit To World Map"; break;
                        case 1602: eventLabels[i] = "Exp Star Subroutine Cancel Npc Event Do Not Remove From Level"; break;
                        case 1603: eventLabels[i] = "Exp Star Subroutine Cancel Tile Event"; break;
                        case 1604: eventLabels[i] = "Exp Star Subroutine Cancel Npc Event Remove From Level"; break;
                        case 1605: eventLabels[i] = "Tower Exterior Cancel Exp Star"; break;
                        case 1606: eventLabels[i] = "Empty"; break;
                        case 1607: eventLabels[i] = "Empty"; break;
                        case 1608: eventLabels[i] = "Empty"; break;
                        case 1609: eventLabels[i] = "Empty"; break;
                        case 1610: eventLabels[i] = "Empty"; break;
                        case 1611: eventLabels[i] = "Empty"; break;
                        case 1612: eventLabels[i] = "Summon Geckits In Cannon Room"; break;
                        case 1613: eventLabels[i] = "Empty"; break;
                        case 1614: eventLabels[i] = "Moleville Swap Shop Loader"; break;
                        case 1615: eventLabels[i] = "Moleville Swap Shop Tutorial"; break;
                        case 1616: eventLabels[i] = "Moleville Inn Loader"; break;
                        case 1617: eventLabels[i] = "Moleville Occupied Pa Mole In House"; break;
                        case 1618: eventLabels[i] = "Empty"; break;
                        case 1619: eventLabels[i] = "Occupied Moleville Exterior Npc Trigger Cutscene"; break;
                        case 1620: eventLabels[i] = "Occupied Moleville Exterior Npc At Mtn Base"; break;
                        case 1621: eventLabels[i] = "Occupied Moleville Exterior Npc At Mtn Top"; break;
                        case 1622: eventLabels[i] = "Bucket Warp"; break;
                        case 1623: eventLabels[i] = "Belome Fortune Brick"; break;
                        case 1624: eventLabels[i] = "Moleville Shop"; break;
                        case 1625: eventLabels[i] = "Moleville Tower Unlock Condition Hint"; break;
                        case 1626: eventLabels[i] = "Moleville Carbo Cookie Trader"; break;
                        case 1627: eventLabels[i] = "Dyna House Loader"; break;
                        case 1628: eventLabels[i] = "Moleville Inn Girl"; break;
                        case 1629: eventLabels[i] = "Ma Mole"; break;
                        case 1630: eventLabels[i] = "Moleville Liberated Pa Mole In House"; break;
                        case 1631: eventLabels[i] = "Dyna In House"; break;
                        case 1632: eventLabels[i] = "Moleville Minecart Freeplay Ending Landing"; break;
                        case 1633: eventLabels[i] = "Moleville Inn"; break;
                        case 1634: eventLabels[i] = "Fireworks House Left Girl"; break;
                        case 1635: eventLabels[i] = "Fireworks House Right Girl"; break;
                        case 1636: eventLabels[i] = "Moleville Swap Shop Logic"; break;
                        case 1637: eventLabels[i] = "Moleville Swap Shop Girl"; break;
                        case 1638: eventLabels[i] = "Moleville Liberated Npc At Mtn Base 1"; break;
                        case 1639: eventLabels[i] = "Moleville Liberated Npc At Mtn Base 2"; break;
                        case 1640: eventLabels[i] = "Initiate Minecart Freeplay"; break;
                        case 1641: eventLabels[i] = "Tells You Minecart Pb"; break;
                        case 1642: eventLabels[i] = "Booster Pass Secret Hint Guy"; break;
                        case 1643: eventLabels[i] = "Purtend Store"; break;
                        case 1644: eventLabels[i] = "Moleville Occupied Exterior Loader"; break;
                        case 1645: eventLabels[i] = "Bucket Girl"; break;
                        case 1646: eventLabels[i] = "Moleville Song Hint Girl"; break;
                        case 1647: eventLabels[i] = "Moleville Minecart Freeplay Entrance"; break;
                        case 1648: eventLabels[i] = "Minecart Ending"; break;
                        case 1649: eventLabels[i] = "Moleville Liberated Exterior Loader"; break;
                        case 1650: eventLabels[i] = "Moleville Liberated Exterior Loader Contd"; break;
                        case 1651: eventLabels[i] = "Mario Crash Thru Moleville Roof"; break;
                        case 1652: eventLabels[i] = "Empty"; break;
                        case 1653: eventLabels[i] = "Exit Barrel Count Timer"; break;
                        case 1654: eventLabels[i] = "Empty"; break;
                        case 1655: eventLabels[i] = "Empty"; break;
                        case 1656: eventLabels[i] = "Empty"; break;
                        case 1657: eventLabels[i] = "Empty"; break;
                        case 1658: eventLabels[i] = "Empty"; break;
                        case 1659: eventLabels[i] = "Empty"; break;
                        case 1660: eventLabels[i] = "Empty"; break;
                        case 1661: eventLabels[i] = "Empty"; break;
                        case 1662: eventLabels[i] = "Empty"; break;
                        case 1663: eventLabels[i] = "Empty"; break;
                        case 1664: eventLabels[i] = "Empty"; break;
                        case 1665: eventLabels[i] = "Empty"; break;
                        case 1666: eventLabels[i] = "Empty"; break;
                        case 1667: eventLabels[i] = "Empty"; break;
                        case 1668: eventLabels[i] = "Empty"; break;
                        case 1669: eventLabels[i] = "Nimbus Final Hallway Miniboss Collision"; break;
                        case 1670: eventLabels[i] = "Lands End 2 Summon Invisible Platform"; break;
                        case 1671: eventLabels[i] = "Lands End 1 Invisible Platform"; break;
                        case 1672: eventLabels[i] = "Lands End 2 Summon Invisible Platform"; break;
                        case 1673: eventLabels[i] = "Lands End 2 Invisible Platform Upper"; break;
                        case 1674: eventLabels[i] = "Lands End Enter Grotto"; break;
                        case 1675: eventLabels[i] = "Mario Bumped Off Cannon"; break;
                        case 1676: eventLabels[i] = "Lands End Grotto Room 1 Loader"; break;
                        case 1677: eventLabels[i] = "Temple Pipe To Monstro"; break;
                        case 1678: eventLabels[i] = "Open Lands End Grotto"; break;
                        case 1679: eventLabels[i] = "Lands End Trampoline In Lower Underground Gecko Room"; break;
                        case 1680: eventLabels[i] = "Temple Pipe To Fortune Result Room"; break;
                        case 1681: eventLabels[i] = "Temple Trampoline In Fortune Result Room"; break;
                        case 1682: eventLabels[i] = "Trampoline Shaman"; break;
                        case 1683: eventLabels[i] = "Temple Exit Warp Trampoline"; break;
                        case 1684: eventLabels[i] = "Temple Elevator Lower Exit"; break;
                        case 1685: eventLabels[i] = "Temple Fortune Head 1"; break;
                        case 1686: eventLabels[i] = "Temple Fortune Head 2"; break;
                        case 1687: eventLabels[i] = "Temple Fortune Head 3"; break;
                        case 1688: eventLabels[i] = "Temple Fortune Heads Room Loader"; break;
                        case 1689: eventLabels[i] = "Temple Pipe To Boss Fight"; break;
                        case 1690: eventLabels[i] = "Temple Boss Room Trampoline"; break;
                        case 1691: eventLabels[i] = "Empty"; break;
                        case 1692: eventLabels[i] = "Temple Fortune Scroll"; break;
                        case 1693: eventLabels[i] = "Temple Final Fortune Head"; break;
                        case 1694: eventLabels[i] = "Temple Elevator"; break;
                        case 1695: eventLabels[i] = "Bandits Way Goomba"; break;
                        case 1696: eventLabels[i] = "Bandits Way Chest Platforms 1"; break;
                        case 1697: eventLabels[i] = "Bandits Way Chest Platforms 2"; break;
                        case 1698: eventLabels[i] = "Bandits Way 4 Loader"; break;
                        case 1699: eventLabels[i] = "Bandits Way 4 Loader Background"; break;
                        case 1700: eventLabels[i] = "Bandits Way 2 Left Platform"; break;
                        case 1701: eventLabels[i] = "Bandits Way 2 Right Platform"; break;
                        case 1702: eventLabels[i] = "Bandits Way 2 Loader"; break;
                        case 1703: eventLabels[i] = "Bandits Way 2 Spinny Flower 1"; break;
                        case 1704: eventLabels[i] = "Bandits Way 2 Spinny Flower 2"; break;
                        case 1705: eventLabels[i] = "Bandits Way 2 Dogs Background"; break;
                        case 1706: eventLabels[i] = "Bandits Way Left Chest Star Check"; break;
                        case 1707: eventLabels[i] = "Bandits Way 5 Loader Background"; break;
                        case 1708: eventLabels[i] = "Bandits Way 5 Loader"; break;
                        case 1709: eventLabels[i] = "Bandits Way 5 Loader Background 2"; break;
                        case 1710: eventLabels[i] = "Bandits Way 5 Loader Background Boss Fight"; break;
                        case 1711: eventLabels[i] = "Bandits Way Trampoline"; break;
                        case 1712: eventLabels[i] = "Bandits Way 2 Dog"; break;
                        case 1713: eventLabels[i] = "Bandits Way 3 Loader"; break;
                        case 1714: eventLabels[i] = "Bandits Way 1 Loader"; break;
                        case 1715: eventLabels[i] = "Bandits Way 4 Platform Subroutine"; break;
                        case 1716: eventLabels[i] = "Bandits Way 5 Chase Catch Boss"; break;
                        case 1717: eventLabels[i] = "Bandits Way 4 Manage Dog Collision"; break;
                        case 1718: eventLabels[i] = "Empty"; break;
                        case 1719: eventLabels[i] = "Empty"; break;
                        case 1720: eventLabels[i] = "Empty"; break;
                        case 1721: eventLabels[i] = "Empty"; break;
                        case 1722: eventLabels[i] = "Sky Bridge Room Loader"; break;
                        case 1723: eventLabels[i] = "Empty"; break;
                        case 1724: eventLabels[i] = "Empty"; break;
                        case 1725: eventLabels[i] = "Empty"; break;
                        case 1726: eventLabels[i] = "Empty"; break;
                        case 1727: eventLabels[i] = "Empty"; break;
                        case 1728: eventLabels[i] = "Empty"; break;
                        case 1729: eventLabels[i] = "Empty"; break;
                        case 1730: eventLabels[i] = "Empty"; break;
                        case 1731: eventLabels[i] = "Empty"; break;
                        case 1732: eventLabels[i] = "Sky Bridge Background"; break;
                        case 1733: eventLabels[i] = "Empty"; break;
                        case 1734: eventLabels[i] = "Empty"; break;
                        case 1735: eventLabels[i] = "Empty"; break;
                        case 1736: eventLabels[i] = "Empty"; break;
                        case 1737: eventLabels[i] = "Sky Bridge Donut Lift"; break;
                        case 1738: eventLabels[i] = "Empty"; break;
                        case 1739: eventLabels[i] = "Refocus Camera"; break;
                        case 1740: eventLabels[i] = "Empty"; break;
                        case 1741: eventLabels[i] = "Empty"; break;
                        case 1742: eventLabels[i] = "Empty"; break;
                        case 1743: eventLabels[i] = "Empty"; break;
                        case 1744: eventLabels[i] = "Empty"; break;
                        case 1745: eventLabels[i] = "Whirlpool Shogun"; break;
                        case 1746: eventLabels[i] = "Empty"; break;
                        case 1747: eventLabels[i] = "Empty"; break;
                        case 1748: eventLabels[i] = "Mines Postgame Fight"; break;
                        case 1749: eventLabels[i] = "Ship Postgame Boss"; break;
                        case 1750: eventLabels[i] = "Temple Boss Postgame"; break;
                        case 1751: eventLabels[i] = "Lands End Desert 1 Left Whirlpool"; break;
                        case 1752: eventLabels[i] = "Lands End Desert 1 Right Whirlpool"; break;
                        case 1753: eventLabels[i] = "Lands End Final Whirlpool 1"; break;
                        case 1754: eventLabels[i] = "Lands End Final Whirlpool 2"; break;
                        case 1755: eventLabels[i] = "Lands End Shy Away Whirlpool 1"; break;
                        case 1756: eventLabels[i] = "Lands End Shy Away Whirlpool 2"; break;
                        case 1757: eventLabels[i] = "Lands End Shy Away Whirlpool 3"; break;
                        case 1758: eventLabels[i] = "Lands End Penultimate Whirlpool 1"; break;
                        case 1759: eventLabels[i] = "Lands End Penultimate Whirlpool 2"; break;
                        case 1760: eventLabels[i] = "Lands End Stage 2 Whirlpool 1"; break;
                        case 1761: eventLabels[i] = "Lands End Stage 2 Whirlpool 2"; break;
                        case 1762: eventLabels[i] = "Lands End Stage 2 Whirlpool 3"; break;
                        case 1763: eventLabels[i] = "Lands End Bee Whirlpool 1"; break;
                        case 1764: eventLabels[i] = "Lands End Bee Whirlpool 2"; break;
                        case 1765: eventLabels[i] = "Lands End Bee Whirlpool 3"; break;
                        case 1766: eventLabels[i] = "Temple Elevator Room Loader"; break;
                        case 1767: eventLabels[i] = "Temple Fortune Results Room Gate Opens"; break;
                        case 1768: eventLabels[i] = "Temple Boss"; break;
                        case 1769: eventLabels[i] = "Temple Summon Green Button"; break;
                        case 1770: eventLabels[i] = "Temple Fortune Results Room Loader"; break;
                        case 1771: eventLabels[i] = "Temple Boss Room Loader"; break;
                        case 1772: eventLabels[i] = "Lands End Bullet Bill"; break;
                        case 1773: eventLabels[i] = "Lands End Bullet Bill Background"; break;
                        case 1774: eventLabels[i] = "Empty"; break;
                        case 1775: eventLabels[i] = "Sky Troopa Platform"; break;
                        case 1777: eventLabels[i] = "Lands End Cliff Loader"; break;
                        case 1778: eventLabels[i] = "Temple Generic Pipe Room Loader"; break;
                        case 1779: eventLabels[i] = "Lands End Underground 1 Loader"; break;
                        case 1780: eventLabels[i] = "Lands End Flower Loader"; break;
                        case 1781: eventLabels[i] = "Empty"; break;
                        case 1782: eventLabels[i] = "Lands End Desert 1 Loader"; break;
                        case 1783: eventLabels[i] = "Lands End Final Whirlpool Room Loader"; break;
                        case 1784: eventLabels[i] = "Lands End Desert 1 Left Whirlpool Subroutine"; break;
                        case 1785: eventLabels[i] = "Lands End Final Whirlpool 1 Subroutine"; break;
                        case 1786: eventLabels[i] = "Lands End Shy Away Whirlpool 1 Subroutine"; break;
                        case 1787: eventLabels[i] = "Lands End Desert 1 Right Whirlpool Subroutine"; break;
                        case 1788: eventLabels[i] = "Lands End Underground Dog Wall Room Loader Background"; break;
                        case 1789: eventLabels[i] = "Whirlpool Shogun Subroutine"; break;
                        case 1790: eventLabels[i] = "Lands End Underground Upper Pit Room Loader Background"; break;
                        case 1791: eventLabels[i] = "Lands End Underground Dog Wall Room Loader"; break;
                        case 1792: eventLabels[i] = "Lands End Underground Upper Pit Room Loader"; break;
                        case 1793: eventLabels[i] = "Lands End Purchasable Chest 1 Subroutine"; break;
                        case 1794: eventLabels[i] = "Lands End Buy Chest"; break;
                        case 1795: eventLabels[i] = "Lands End Underground Lower Level Loader"; break;
                        case 1796: eventLabels[i] = "Lands End Desert 1 Trampoline"; break;
                        case 1797: eventLabels[i] = "Lands End Sky Bridge Room Exit To Desert"; break;
                        case 1798: eventLabels[i] = "Lands End Cliff Mouse Hint"; break;
                        case 1799: eventLabels[i] = "Temple Final Fortune Scroll"; break;
                        case 1800: eventLabels[i] = "Temple Mouse Monstro Town Access Hint"; break;
                        case 1801: eventLabels[i] = "Freestanding Flower"; break;
                        case 1802: eventLabels[i] = "Empty"; break;
                        case 1803: eventLabels[i] = "Empty"; break;
                        case 1804: eventLabels[i] = "Empty"; break;
                        case 1805: eventLabels[i] = "Temple 3 Fortune Shaman"; break;
                        case 1806: eventLabels[i] = "Temple Fortune Results Dog Fight"; break;
                        case 1807: eventLabels[i] = "Temple Fortune Results Shy Away Fight"; break;
                        case 1808: eventLabels[i] = "Belome Fortune Prize Chest 1 Subroutine"; break;
                        case 1809: eventLabels[i] = "Lands End Cliff Exit To World Map"; break;
                        case 1810: eventLabels[i] = "Temple Vault Loader"; break;
                        case 1811: eventLabels[i] = "Temple Four Chest Room Loader"; break;
                        case 1812: eventLabels[i] = "Empty"; break;
                        case 1813: eventLabels[i] = "Save Box In Rooms With Exp Stars"; break;
                        case 1814: eventLabels[i] = "Start Troopa Cliff Timer"; break;
                        case 1815: eventLabels[i] = "Troopa Cliff Timer"; break;
                        case 1816: eventLabels[i] = "Troopa Cliff Finish"; break;
                        case 1817: eventLabels[i] = "Troopa Cliff Fall"; break;
                        case 1818: eventLabels[i] = "Lands End Desert Mouse"; break;
                        case 1819: eventLabels[i] = "Shy Away Early Lands End"; break;
                        case 1820: eventLabels[i] = "Empty"; break;
                        case 1821: eventLabels[i] = "Empty"; break;
                        case 1822: eventLabels[i] = "Empty"; break;
                        case 1823: eventLabels[i] = "Lands End Grotto First Room Upper Chest"; break;
                        case 1824: eventLabels[i] = "Keep Set Platform Properties"; break;
                        case 1825: eventLabels[i] = "Keep Rotating Room Loader"; break;
                        case 1826: eventLabels[i] = "Keep Invisible Floor Room Loader"; break;
                        case 1827: eventLabels[i] = "Keep Linear Platform Room Loader"; break;
                        case 1828: eventLabels[i] = "Keep Mario Falls In Lava"; break;
                        case 1829: eventLabels[i] = "Keep Display Remaining Tries"; break;
                        case 1830: eventLabels[i] = "Keep Handle Room Reload After Lava Fall"; break;
                        case 1831: eventLabels[i] = "Keep Invisible Floor Room Background 1"; break;
                        case 1832: eventLabels[i] = "Keep Invisible Floor Room Background 2"; break;
                        case 1833: eventLabels[i] = "Keep Linear Platform Room Background"; break;
                        case 1834: eventLabels[i] = "Keep Cannonball"; break;
                        case 1835: eventLabels[i] = "Keep Cannonball Room Loader"; break;
                        case 1836: eventLabels[i] = "Keep Donkey Room Loader"; break;
                        case 1837: eventLabels[i] = "Unknown"; break;
                        case 1838: eventLabels[i] = "Empty"; break;
                        case 1839: eventLabels[i] = "Unknown"; break;
                        case 1840: eventLabels[i] = "Platform Subroutine"; break;
                        case 1841: eventLabels[i] = "Keep Invisible Floor Chest 1"; break;
                        case 1842: eventLabels[i] = "Keep Invisible Floor Coin 1"; break;
                        case 1843: eventLabels[i] = "Keep Invisible Floor Show Floor"; break;
                        case 1844: eventLabels[i] = "Summon Cloud Boss"; break;
                        case 1845: eventLabels[i] = "Cloud Boss"; break;
                        case 1846: eventLabels[i] = "Safe Donut Lift Jump"; break;
                        case 1847: eventLabels[i] = "Cannonball Room Bomb 1"; break;
                        case 1848: eventLabels[i] = "Cannonball Room Bomb 2"; break;
                        case 1849: eventLabels[i] = "Cannonball Room Bomb 1 Contd"; break;
                        case 1850: eventLabels[i] = "Cannonball Room Bomb 2 Contd"; break;
                        case 1851: eventLabels[i] = "Lands End Grotto Directional Bit"; break;
                        case 1852: eventLabels[i] = "Sky Bridge Admin Shaman"; break;
                        case 1853: eventLabels[i] = "Sky Bridge Ride Shaman"; break;
                        case 1854: eventLabels[i] = "Keep Donkey Room Background"; break;
                        case 1855: eventLabels[i] = "Keep Donkey Room Barrel"; break;
                        case 1856: eventLabels[i] = "Moleville Shop Loader"; break;
                        case 1857: eventLabels[i] = "Moleville Shop Exit To Exterior"; break;
                        case 1858: eventLabels[i] = "Moleville Inn Exit To Exterior"; break;
                        case 1859: eventLabels[i] = "Fireworks House Exit To Exterior"; break;
                        case 1860: eventLabels[i] = "Moleville Swap Shop Exit To Exterior"; break;
                        case 1861: eventLabels[i] = "Keep Donkey Room Donkey"; break;
                        case 1862: eventLabels[i] = "Croco Shop 1"; break;
                        case 1863: eventLabels[i] = "Croco Shop 2"; break;
                        case 1864: eventLabels[i] = "Bowser Door Ultimate Failure Animation"; break;
                        case 1865: eventLabels[i] = "Empty"; break;
                        case 1866: eventLabels[i] = "Keep Invisible Floor Chest 2"; break;
                        case 1867: eventLabels[i] = "Empty"; break;
                        case 1868: eventLabels[i] = "Lands End Flower Room Exit To Sky Bridge"; break;
                        case 1869: eventLabels[i] = "Sky Bridge Loader"; break;
                        case 1870: eventLabels[i] = "Keep Invisible Floor Chest 3"; break;
                        case 1871: eventLabels[i] = "Fireworks House Loader"; break;
                        case 1872: eventLabels[i] = "Fireworks House Buy Item"; break;
                        case 1873: eventLabels[i] = "Midas River Sign After Bucket Warp"; break;
                        case 1874: eventLabels[i] = "Temple Elevator Room Shaman"; break;
                        case 1875: eventLabels[i] = "Keep Rotating Room Platform 1"; break;
                        case 1876: eventLabels[i] = "Keep Rotating Room Platform 2"; break;
                        case 1877: eventLabels[i] = "Keep Rotating Room Loader Contd"; break;
                        case 1878: eventLabels[i] = "Keep Cannonball Room Exit To Previous"; break;
                        case 1879: eventLabels[i] = "Keep Linear Platform Room Exit To Previous"; break;
                        case 1880: eventLabels[i] = "Keep Invisible Floor Chest 4"; break;
                        case 1881: eventLabels[i] = "Keep Invisible Floor Coin 2"; break;
                        case 1882: eventLabels[i] = "Keep Invisible Floor Coin 3"; break;
                        case 1883: eventLabels[i] = "Whirlpool Shogun 1"; break;
                        case 1884: eventLabels[i] = "Whirlpool Shogun 2"; break;
                        case 1885: eventLabels[i] = "Whirlpool Shogun 3"; break;
                        case 1886: eventLabels[i] = "Whirlpool Shogun 4"; break;
                        case 1887: eventLabels[i] = "Whirlpool Shogun 5"; break;
                        case 1888: eventLabels[i] = "Abyss Axem Pit Room Loader"; break;
                        case 1889: eventLabels[i] = "Abyss Side Treasure Rooms Loader"; break;
                        case 1890: eventLabels[i] = "Determine Side Treasure Room To Load"; break;
                        case 1891: eventLabels[i] = "Abyss Big Conveyor Room Loader"; break;
                        case 1892: eventLabels[i] = "Abyss Boss 1 Defeated Temp Room Loader"; break;
                        case 1893: eventLabels[i] = "Abyss Boss 2 Room Loader"; break;
                        case 1894: eventLabels[i] = "Abyss Boss 2"; break;
                        case 1895: eventLabels[i] = "Abyss After Boss 1 Trampoline Backward"; break;
                        case 1896: eventLabels[i] = "Abyss Axem Pit Trampoline"; break;
                        case 1897: eventLabels[i] = "Abyss Upper Machine Yarid Room Loader"; break;
                        case 1898: eventLabels[i] = "Abyss Boss 2 Room Trampoline"; break;
                        case 1899: eventLabels[i] = "Abyss Axem Pit Room Fall"; break;
                        case 1900: eventLabels[i] = "Abyss Big Conveyor Room Fall"; break;
                        case 1901: eventLabels[i] = "Abyss Axem Pit Platforms"; break;
                        case 1902: eventLabels[i] = "Abyss Exit To Side Treasure Rooms"; break;
                        case 1903: eventLabels[i] = "Abyss Side Treasure Rooms Exit"; break;
                        case 1904: eventLabels[i] = "Abyss Machine Yarid Upper"; break;
                        case 1905: eventLabels[i] = "Abyss Exit To Boss 2 Room"; break;
                        case 1906: eventLabels[i] = "Turn Off Mario Shadow"; break;
                        case 1907: eventLabels[i] = "Abyss Machine Yarid Lower"; break;
                        case 1908: eventLabels[i] = "Abyss Machine Axem Red"; break;
                        case 1909: eventLabels[i] = "Abyss Conveyor Belt Jabit Or Bowyer"; break;
                        case 1910: eventLabels[i] = "Abyss Conveyor Belt Shyper"; break;
                        case 1911: eventLabels[i] = "Abyss Machine Mack"; break;
                        case 1912: eventLabels[i] = "Abyss Machine Arrow Hit"; break;
                        case 1913: eventLabels[i] = "Abyss Machine Arrow Animate"; break;
                        case 1914: eventLabels[i] = "Abyss Machine Arrow Reset"; break;
                        case 1915: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1916: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1917: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1918: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1919: eventLabels[i] = "Abyss Big Conveyor Platform"; break;
                        case 1920: eventLabels[i] = "Abyss Big Conveyor Checkpoint"; break;
                        case 1921: eventLabels[i] = "Abyss Machine Bowyer"; break;
                        case 1922: eventLabels[i] = "Abyss Set Machine Bowyer Spawn Point"; break;
                        case 1923: eventLabels[i] = "Abyss Set Machine Bowyer Spawn Point"; break;
                        case 1924: eventLabels[i] = "World Map Inner Factory"; break;
                        case 1925: eventLabels[i] = "Postgame Tower Fight"; break;
                        case 1926: eventLabels[i] = "Tower Balcony Loader"; break;
                        case 1927: eventLabels[i] = "Tower Balcony Jump Off"; break;
                        case 1928: eventLabels[i] = "Balcony Is Locked"; break;
                        case 1929: eventLabels[i] = "Keep Invisible Floor Coin 4"; break;
                        case 1930: eventLabels[i] = "Mackskip Maybe"; break;
                        case 1931: eventLabels[i] = "Treasure Chest Failure Mimic Fight"; break;
                        case 1932: eventLabels[i] = "Belome Fortune Prize Chest 2"; break;
                        case 1933: eventLabels[i] = "Belome Fortune Prize Chest 3"; break;
                        case 1934: eventLabels[i] = "Belome Fortune Prize Chest 4"; break;
                        case 1935: eventLabels[i] = "Keep Rotating Room Exit To Previous"; break;
                        case 1936: eventLabels[i] = "Keep Rotating Room Chest 1"; break;
                        case 1937: eventLabels[i] = "Keep Rotating Room Chest 2"; break;
                        case 1938: eventLabels[i] = "Keep Rotating Room Chest 3"; break;
                        case 1939: eventLabels[i] = "Keep Rotating Room Chest 4"; break;
                        case 1940: eventLabels[i] = "Keep Rotating Room Chest 5"; break;
                        case 1941: eventLabels[i] = "Keep Rotating Room Chest 6"; break;
                        case 1942: eventLabels[i] = "Keep Vertical Platform Room Exit To Previous"; break;
                        case 1943: eventLabels[i] = "Keep Invisible Floor Room Exit"; break;
                        case 1944: eventLabels[i] = "Keep Chewy Battle Room Exit"; break;
                        case 1945: eventLabels[i] = "Keep Cannonball Room Exit"; break;
                        case 1946: eventLabels[i] = "Keep Donkey Room Exit To Previous"; break;
                        case 1947: eventLabels[i] = "Keep Linear Platform Room Exit"; break;
                        case 1948: eventLabels[i] = "Keep Terra Corra Battle Room Exit"; break;
                        case 1949: eventLabels[i] = "Keep Alley Rat Battle Room Exit"; break;
                        case 1950: eventLabels[i] = "Keep Goomba Battle Room Exit"; break;
                        case 1951: eventLabels[i] = "Keep Barrel Count Room Exit Container"; break;
                        case 1952: eventLabels[i] = "Keep Enter Marathon Puzzle Room"; break;
                        case 1953: eventLabels[i] = "Keep Quiz Room Exit Container"; break;
                        case 1954: eventLabels[i] = "Keep Enter Barrel Count Room"; break;
                        case 1955: eventLabels[i] = "Keep Coin Game Room Exit Container"; break;
                        case 1956: eventLabels[i] = "Keep Enter Button Game Room"; break;
                        case 1957: eventLabels[i] = "Keep Door 5 Container"; break;
                        case 1958: eventLabels[i] = "Keep Enter Vertical Platform Room"; break;
                        case 1959: eventLabels[i] = "Keep Door 4 Container"; break;
                        case 1960: eventLabels[i] = "Keep Enter Invisible Floor Room"; break;
                        case 1961: eventLabels[i] = "Keep Door 6 Container"; break;
                        case 1962: eventLabels[i] = "Keep Enter Terra Cotta Battle Room"; break;
                        case 1963: eventLabels[i] = "Keep Door 3 Container"; break;
                        case 1964: eventLabels[i] = "Keep Enter Goomba Battle Room"; break;
                        case 1965: eventLabels[i] = "Keep Door 1 Container"; break;
                        case 1966: eventLabels[i] = "Keep Enter Quiz Room"; break;
                        case 1967: eventLabels[i] = "Keep Door 2 Container"; break;
                        case 1968: eventLabels[i] = "Keep Enter Coin Game Room"; break;
                        case 1969: eventLabels[i] = "Check If Star Pieces For Factory Boss Collected"; break;
                        case 1970: eventLabels[i] = "Boshi Odds Calculator"; break;
                        case 1971: eventLabels[i] = "Mushroom Boy Grants Rock Candy"; break;
                        case 1972: eventLabels[i] = "Mushroom Boy Odds"; break;
                        case 1973: eventLabels[i] = "Clone Reserved"; break;
                        case 1974: eventLabels[i] = "Clone Reserved"; break;
                        case 1975: eventLabels[i] = "Clone Reserved"; break;
                        case 1976: eventLabels[i] = "Clone Reserved"; break;
                        case 1977: eventLabels[i] = "Clone Reserved"; break;
                        case 1978: eventLabels[i] = "Clone Reserved"; break;
                        case 1979: eventLabels[i] = "Clone Reserved"; break;
                        case 1980: eventLabels[i] = "Clone Reserved"; break;
                        case 1981: eventLabels[i] = "Clone Reserved"; break;
                        case 1982: eventLabels[i] = "Clone Reserved"; break;
                        case 1983: eventLabels[i] = "Clone Reserved"; break;
                        case 1984: eventLabels[i] = "Clone Reserved"; break;
                        case 1985: eventLabels[i] = "Clone Reserved"; break;
                        case 1986: eventLabels[i] = "Clone Reserved"; break;
                        case 1987: eventLabels[i] = "Clone Reserved"; break;
                        case 1988: eventLabels[i] = "Clone Reserved"; break;
                        case 1989: eventLabels[i] = "Clone Reserved"; break;
                        case 1990: eventLabels[i] = "Clone Reserved"; break;
                        case 1991: eventLabels[i] = "Clone Reserved"; break;
                        case 1992: eventLabels[i] = "Clone Reserved"; break;
                        case 1993: eventLabels[i] = "Clone Reserved"; break;
                        case 1994: eventLabels[i] = "Clone Reserved"; break;
                        case 1995: eventLabels[i] = "Clone Reserved"; break;
                        case 1996: eventLabels[i] = "Clone Reserved"; break;
                        case 1997: eventLabels[i] = "Clone Reserved"; break;
                        case 1998: eventLabels[i] = "Clone Reserved"; break;
                        case 1999: eventLabels[i] = "Clone Reserved"; break;
                        case 2000: eventLabels[i] = "Clone Reserved"; break;
                        case 2001: eventLabels[i] = "Clone Reserved"; break;
                        case 2002: eventLabels[i] = "Clone Reserved"; break;
                        case 2003: eventLabels[i] = "Clone Reserved"; break;
                        case 2004: eventLabels[i] = "Clone Reserved"; break;
                        case 2005: eventLabels[i] = "Clone Reserved"; break;
                        case 2006: eventLabels[i] = "Clone Reserved"; break;
                        case 2007: eventLabels[i] = "Clone Reserved"; break;
                        case 2008: eventLabels[i] = "Clone Reserved"; break;
                        case 2009: eventLabels[i] = "Clone Reserved"; break;
                        case 2010: eventLabels[i] = "Clone Reserved"; break;
                        case 2011: eventLabels[i] = "Clone Reserved"; break;
                        case 2012: eventLabels[i] = "Clone Reserved"; break;
                        case 2013: eventLabels[i] = "Clone Reserved"; break;
                        case 2014: eventLabels[i] = "Clone Reserved"; break;
                        case 2015: eventLabels[i] = "Clone Reserved"; break;
                        case 2016: eventLabels[i] = "Clone Reserved"; break;
                        case 2017: eventLabels[i] = "Clone Reserved"; break;
                        case 2018: eventLabels[i] = "Clone Reserved"; break;
                        case 2019: eventLabels[i] = "Clone Reserved"; break;
                        case 2020: eventLabels[i] = "Clone Reserved"; break;
                        case 2021: eventLabels[i] = "Clone Reserved"; break;
                        case 2022: eventLabels[i] = "Clone Reserved"; break;
                        case 2023: eventLabels[i] = "Clone Reserved"; break;
                        case 2024: eventLabels[i] = "Clone Reserved"; break;
                        case 2025: eventLabels[i] = "Clone Reserved"; break;
                        case 2026: eventLabels[i] = "Clone Reserved"; break;
                        case 2027: eventLabels[i] = "Clone Reserved"; break;
                        case 2028: eventLabels[i] = "Clone Reserved"; break;
                        case 2029: eventLabels[i] = "Clone Reserved"; break;
                        case 2030: eventLabels[i] = "Clone Reserved"; break;
                        case 2031: eventLabels[i] = "Clone Reserved"; break;
                        case 2032: eventLabels[i] = "Clone Reserved"; break;
                        case 2033: eventLabels[i] = "Clone Reserved"; break;
                        case 2034: eventLabels[i] = "Clone Reserved"; break;
                        case 2035: eventLabels[i] = "Clone Reserved"; break;
                        case 2036: eventLabels[i] = "Clone Reserved"; break;
                        case 2037: eventLabels[i] = "Clone Reserved"; break;
                        case 2038: eventLabels[i] = "Clone Reserved"; break;
                        case 2039: eventLabels[i] = "Clone Reserved"; break;
                        case 2040: eventLabels[i] = "Clone Reserved"; break;
                        case 2041: eventLabels[i] = "Clone Reserved"; break;
                        case 2042: eventLabels[i] = "Clone Reserved"; break;
                        case 2043: eventLabels[i] = "Clone Reserved"; break;
                        case 2044: eventLabels[i] = "Clone Reserved"; break;
                        case 2045: eventLabels[i] = "Clone Reserved"; break;
                        case 2046: eventLabels[i] = "Clone Reserved"; break;
                        case 2047: eventLabels[i] = "Clone Reserved"; break;
                        case 2048: eventLabels[i] = "Monstro Town Exterior Loader"; break;
                        case 2049: eventLabels[i] = "Monstro Super Jump House Loader"; break;
                        case 2050: eventLabels[i] = "Monstro Thwomp"; break;
                        case 2051: eventLabels[i] = "Monstro Shop Loader"; break;
                        case 2052: eventLabels[i] = "Chapel Postgame Boss"; break;
                        case 2053: eventLabels[i] = "Monstro Goombette Shop"; break;
                        case 2054: eventLabels[i] = "Monstro Main Shop"; break;
                        case 2055: eventLabels[i] = "Monstro Trampoline"; break;
                        case 2056: eventLabels[i] = "Monstro Ledge Item"; break;
                        case 2057: eventLabels[i] = "Monstromama House 1F Loader"; break;
                        case 2058: eventLabels[i] = "Monstro Fan Setting"; break;
                        case 2059: eventLabels[i] = "Monstromama"; break;
                        case 2060: eventLabels[i] = "Monstromama House 2F Loader"; break;
                        case 2061: eventLabels[i] = "Monstro Town Star"; break;
                        case 2062: eventLabels[i] = "Monstro Mimic"; break;
                        case 2063: eventLabels[i] = "Super Jump Prize Grant"; break;
                        case 2064: eventLabels[i] = "Dojo Loader"; break;
                        case 2065: eventLabels[i] = "Dojo Loader First Time Animation"; break;
                        case 2066: eventLabels[i] = "Dojo Boss 1"; break;
                        case 2067: eventLabels[i] = "Dojo Fight 1 Finished"; break;
                        case 2068: eventLabels[i] = "Dojo Boss 2"; break;
                        case 2069: eventLabels[i] = "Monstro Mouse"; break;
                        case 2070: eventLabels[i] = "Monstromama House Exit To Exterior"; break;
                        case 2071: eventLabels[i] = "Empty"; break;
                        case 2072: eventLabels[i] = "Empty"; break;
                        case 2073: eventLabels[i] = "Empty"; break;
                        case 2074: eventLabels[i] = "Enter Monstro Sealed Room"; break;
                        case 2075: eventLabels[i] = "Monstro Sealed Door"; break;
                        case 2076: eventLabels[i] = "Dojo Boss 3"; break;
                        case 2077: eventLabels[i] = "Dojo Boss 4"; break;
                        case 2078: eventLabels[i] = "Monstro Save Box"; break;
                        case 2079: eventLabels[i] = "Monstro Town Exterior Loader From Save Box"; break;
                        case 2080: eventLabels[i] = "Musty Fears Room Loader"; break;
                        case 2081: eventLabels[i] = "Musty Fears Lamp"; break;
                        case 2082: eventLabels[i] = "Nimbus Missable Chest 1"; break;
                        case 2083: eventLabels[i] = "Musty Fears Away Note"; break;
                        case 2084: eventLabels[i] = "Marios Room Invisible Item"; break;
                        case 2085: eventLabels[i] = "Empty"; break;
                        case 2086: eventLabels[i] = "Monstro Piranha"; break;
                        case 2087: eventLabels[i] = "Empty"; break;
                        case 2088: eventLabels[i] = "Empty"; break;
                        case 2089: eventLabels[i] = "Sky Troopas Ad"; break;
                        case 2090: eventLabels[i] = "Monstro Entrance Loader"; break;
                        case 2091: eventLabels[i] = "Empty"; break;
                        case 2092: eventLabels[i] = "Monstro Town Back Exit"; break;
                        case 2093: eventLabels[i] = "Empty"; break;
                        case 2094: eventLabels[i] = "Empty"; break;
                        case 2095: eventLabels[i] = "Empty"; break;
                        case 2096: eventLabels[i] = "Hino Mart Loader"; break;
                        case 2097: eventLabels[i] = "Move Hinopio To Item Shop"; break;
                        case 2098: eventLabels[i] = "Move Hinopio To Inn"; break;
                        case 2099: eventLabels[i] = "Move Hinopio To Armor Shop"; break;
                        case 2100: eventLabels[i] = "Hinopio"; break;
                        case 2101: eventLabels[i] = "Empty"; break;
                        case 2102: eventLabels[i] = "Empty"; break;
                        case 2103: eventLabels[i] = "Empty"; break;
                        case 2104: eventLabels[i] = "Empty"; break;
                        case 2105: eventLabels[i] = "Empty"; break;
                        case 2106: eventLabels[i] = "Empty"; break;
                        case 2107: eventLabels[i] = "Empty"; break;
                        case 2108: eventLabels[i] = "Nimbus Castle Statue Polisher Boss Fight Room Loader"; break;
                        case 2109: eventLabels[i] = "Empty"; break;
                        case 2110: eventLabels[i] = "Empty"; break;
                        case 2111: eventLabels[i] = "Empty"; break;
                        case 2112: eventLabels[i] = "Nimbus Castle Statue Game Room Loader"; break;
                        case 2113: eventLabels[i] = "Empty"; break;
                        case 2114: eventLabels[i] = "Empty"; break;
                        case 2115: eventLabels[i] = "Statue 1 Shake"; break;
                        case 2116: eventLabels[i] = "Statue 2 Shake"; break;
                        case 2117: eventLabels[i] = "Statue 4 Shake"; break;
                        case 2118: eventLabels[i] = "Initiate Statue Polisher Manual Boss Fight"; break;
                        case 2119: eventLabels[i] = "Empty"; break;
                        case 2120: eventLabels[i] = "Empty"; break;
                        case 2121: eventLabels[i] = "Empty"; break;
                        case 2122: eventLabels[i] = "Star Hill Star Piece"; break;
                        case 2123: eventLabels[i] = "Empty"; break;
                        case 2124: eventLabels[i] = "Choose Marrymore Sanctuary State"; break;
                        case 2125: eventLabels[i] = "Empty"; break;
                        case 2126: eventLabels[i] = "Empty"; break;
                        case 2127: eventLabels[i] = "Empty"; break;
                        case 2128: eventLabels[i] = "Empty"; break;
                        case 2129: eventLabels[i] = "Empty"; break;
                        case 2130: eventLabels[i] = "Empty"; break;
                        case 2131: eventLabels[i] = "Empty"; break;
                        case 2132: eventLabels[i] = "Empty"; break;
                        case 2133: eventLabels[i] = "Nimbus Castle Statue Polisher Boss Fight Room Exit To 4Way Path"; break;
                        case 2134: eventLabels[i] = "Empty"; break;
                        case 2135: eventLabels[i] = "Empty"; break;
                        case 2136: eventLabels[i] = "Empty"; break;
                        case 2137: eventLabels[i] = "Empty"; break;
                        case 2138: eventLabels[i] = "Empty"; break;
                        case 2139: eventLabels[i] = "Empty"; break;
                        case 2140: eventLabels[i] = "Empty"; break;
                        case 2141: eventLabels[i] = "Empty"; break;
                        case 2142: eventLabels[i] = "Empty"; break;
                        case 2143: eventLabels[i] = "Empty"; break;
                        case 2144: eventLabels[i] = "Keep 2Nd Room Loader"; break;
                        case 2145: eventLabels[i] = "Keep Donut Bridge Room Loader"; break;
                        case 2146: eventLabels[i] = "Keep Donut Lift"; break;
                        case 2147: eventLabels[i] = "Keep Original Throne Room Loader"; break;
                        case 2148: eventLabels[i] = "Keep Move Goombas In Original Throne Room"; break;
                        case 2149: eventLabels[i] = "Keep Resummon Enemies On Exit"; break;
                        case 2150: eventLabels[i] = "Empty"; break;
                        case 2151: eventLabels[i] = "Empty"; break;
                        case 2152: eventLabels[i] = "Empty"; break;
                        case 2153: eventLabels[i] = "Empty"; break;
                        case 2154: eventLabels[i] = "Empty"; break;
                        case 2155: eventLabels[i] = "Empty"; break;
                        case 2156: eventLabels[i] = "Empty"; break;
                        case 2157: eventLabels[i] = "Empty"; break;
                        case 2158: eventLabels[i] = "Empty"; break;
                        case 2159: eventLabels[i] = "Empty"; break;
                        case 2160: eventLabels[i] = "Keep Terra Cotta Battle Room Loader"; break;
                        case 2161: eventLabels[i] = "Keep Terra Cotta Battle Room Summon 1St Battle"; break;
                        case 2162: eventLabels[i] = "Keep Terra Cotta Battle Room Summon 2Nd Battle"; break;
                        case 2163: eventLabels[i] = "Keep Terra Cotta Battle Room Summon 3Rd Battle"; break;
                        case 2164: eventLabels[i] = "Keep Terra Cotta Battle Room Summon 4Th Battle"; break;
                        case 2165: eventLabels[i] = "Keep Alley Rat Battle Room Loader"; break;
                        case 2166: eventLabels[i] = "Keep Alley Rat Battle Room Summon 1St Battle"; break;
                        case 2167: eventLabels[i] = "Keep Alley Rat Battle Room Summon 2Nd Battle"; break;
                        case 2168: eventLabels[i] = "Keep Alley Rat Battle Room Summon 3Rd Battle"; break;
                        case 2169: eventLabels[i] = "Keep Alley Rat Battle Room Summon 4Th Battle"; break;
                        case 2170: eventLabels[i] = "Keep Bobomb Battle Room Loader"; break;
                        case 2171: eventLabels[i] = "Keep Bobomb Battle Room Summon 1St Battle"; break;
                        case 2172: eventLabels[i] = "Keep Bobomb Battle Room Summon 2Nd Battle"; break;
                        case 2173: eventLabels[i] = "Keep Bobomb Battle Room Summon 3Rd Battle"; break;
                        case 2174: eventLabels[i] = "Keep Bobomb Battle Room Summon 4Th Battle"; break;
                        case 2175: eventLabels[i] = "Keep Goomba Battle Room Loader"; break;
                        case 2176: eventLabels[i] = "Keep Goomba Battle Room Summon 1St Battle"; break;
                        case 2177: eventLabels[i] = "Keep Goomba Battle Room Summon 2Nd Battle"; break;
                        case 2178: eventLabels[i] = "Keep Goomba Battle Room Summon 3Rd Battle"; break;
                        case 2179: eventLabels[i] = "Keep Goomba Battle Room Summon 4Th Battle"; break;
                        case 2180: eventLabels[i] = "Keep Chewy Battle Room Loader"; break;
                        case 2181: eventLabels[i] = "Keep Chewy Battle Room Summon 1St Battle"; break;
                        case 2182: eventLabels[i] = "Keep Chewy Battle Room Summon 2Nd Battle"; break;
                        case 2183: eventLabels[i] = "Keep Chewy Battle Room Summon 3Rd Battle"; break;
                        case 2184: eventLabels[i] = "Keep Chewy Battle Room Summon 4Th Battle"; break;
                        case 2185: eventLabels[i] = "Keep Sparky Battle Room Loader"; break;
                        case 2186: eventLabels[i] = "Keep Sparky Battle Room Summon 1St Battle"; break;
                        case 2187: eventLabels[i] = "Keep Sparky Battle Room Summon 2Nd Battle"; break;
                        case 2188: eventLabels[i] = "Keep Sparky Battle Room Summon 3Rd Battle"; break;
                        case 2189: eventLabels[i] = "Keep Sparky Battle Room Summon 4Th Battle"; break;
                        case 2190: eventLabels[i] = "Battle Door Mimic Boss Animation"; break;
                        case 2191: eventLabels[i] = "Empty"; break;
                        case 2192: eventLabels[i] = "Empty"; break;
                        case 2193: eventLabels[i] = "Empty"; break;
                        case 2194: eventLabels[i] = "Empty"; break;
                        case 2195: eventLabels[i] = "Empty"; break;
                        case 2196: eventLabels[i] = "Empty"; break;
                        case 2197: eventLabels[i] = "Empty"; break;
                        case 2198: eventLabels[i] = "Empty"; break;
                        case 2199: eventLabels[i] = "Empty"; break;
                        case 2200: eventLabels[i] = "Empty"; break;
                        case 2201: eventLabels[i] = "Empty"; break;
                        case 2202: eventLabels[i] = "Empty"; break;
                        case 2203: eventLabels[i] = "Empty"; break;
                        case 2204: eventLabels[i] = "Empty"; break;
                        case 2205: eventLabels[i] = "Empty"; break;
                        case 2206: eventLabels[i] = "Empty"; break;
                        case 2207: eventLabels[i] = "Empty"; break;
                        case 2208: eventLabels[i] = "Keep 1St Boss Room Loader"; break;
                        case 2209: eventLabels[i] = "Keep 1St Boss Fight"; break;
                        case 2210: eventLabels[i] = "Keep 1St Boss Heals You"; break;
                        case 2211: eventLabels[i] = "Empty"; break;
                        case 2212: eventLabels[i] = "Empty"; break;
                        case 2213: eventLabels[i] = "Empty"; break;
                        case 2214: eventLabels[i] = "Empty"; break;
                        case 2215: eventLabels[i] = "Empty"; break;
                        case 2216: eventLabels[i] = "Empty"; break;
                        case 2217: eventLabels[i] = "Empty"; break;
                        case 2218: eventLabels[i] = "Empty"; break;
                        case 2219: eventLabels[i] = "Empty"; break;
                        case 2220: eventLabels[i] = "Empty"; break;
                        case 2221: eventLabels[i] = "Empty"; break;
                        case 2222: eventLabels[i] = "Empty"; break;
                        case 2223: eventLabels[i] = "Empty"; break;
                        case 2224: eventLabels[i] = "Keep Final Boss Room Loader"; break;
                        case 2225: eventLabels[i] = "Keep 2Nd Boss"; break;
                        case 2226: eventLabels[i] = "Keep 3Rd Boss"; break;
                        case 2227: eventLabels[i] = "Empty"; break;
                        case 2228: eventLabels[i] = "Keep Dark Room Loader"; break;
                        case 2229: eventLabels[i] = "Keep Dark Room Summon Goomba 1"; break;
                        case 2230: eventLabels[i] = "Keep Dark Room Summon Goomba 2"; break;
                        case 2231: eventLabels[i] = "Keep Dark Room Summon Goomba 3"; break;
                        case 2232: eventLabels[i] = "Empty"; break;
                        case 2233: eventLabels[i] = "Keep 1St Room Loader"; break;
                        case 2234: eventLabels[i] = "Empty"; break;
                        case 2235: eventLabels[i] = "Empty"; break;
                        case 2236: eventLabels[i] = "Empty"; break;
                        case 2237: eventLabels[i] = "Empty"; break;
                        case 2238: eventLabels[i] = "Empty"; break;
                        case 2239: eventLabels[i] = "Empty"; break;
                        case 2240: eventLabels[i] = "Sets Seaside Inn State"; break;
                        case 2241: eventLabels[i] = "Sets Seaside Elders House State"; break;
                        case 2242: eventLabels[i] = "Sets Seaside Wpn Arm Shop State 1"; break;
                        case 2243: eventLabels[i] = "Sets Seaside Wpn Arm Shop State 2"; break;
                        case 2244: eventLabels[i] = "Sets Seaside Health Store State"; break;
                        case 2245: eventLabels[i] = "Sets Mushroom Boy Shop State"; break;
                        case 2246: eventLabels[i] = "Sets Seaside Accessory Shop State"; break;
                        case 2247: eventLabels[i] = "Dojo Boss 5"; break;
                        case 2248: eventLabels[i] = "Empty"; break;
                        case 2249: eventLabels[i] = "Empty"; break;
                        case 2250: eventLabels[i] = "Empty"; break;
                        case 2251: eventLabels[i] = "Empty"; break;
                        case 2252: eventLabels[i] = "Empty"; break;
                        case 2253: eventLabels[i] = "Empty"; break;
                        case 2254: eventLabels[i] = "Empty"; break;
                        case 2255: eventLabels[i] = "Empty"; break;
                        case 2256: eventLabels[i] = "Empty"; break;
                        case 2257: eventLabels[i] = "Empty"; break;
                        case 2258: eventLabels[i] = "Empty"; break;
                        case 2259: eventLabels[i] = "Empty"; break;
                        case 2260: eventLabels[i] = "Empty"; break;
                        case 2261: eventLabels[i] = "Empty"; break;
                        case 2262: eventLabels[i] = "Empty"; break;
                        case 2263: eventLabels[i] = "Empty"; break;
                        case 2264: eventLabels[i] = "Empty"; break;
                        case 2265: eventLabels[i] = "Empty"; break;
                        case 2266: eventLabels[i] = "Empty"; break;
                        case 2267: eventLabels[i] = "Empty"; break;
                        case 2268: eventLabels[i] = "Empty"; break;
                        case 2269: eventLabels[i] = "Empty"; break;
                        case 2270: eventLabels[i] = "Empty"; break;
                        case 2271: eventLabels[i] = "Empty"; break;
                        case 2272: eventLabels[i] = "Moleville Treasure Shop"; break;
                        case 2273: eventLabels[i] = "Empty"; break;
                        case 2274: eventLabels[i] = "Empty"; break;
                        case 2275: eventLabels[i] = "Empty"; break;
                        case 2276: eventLabels[i] = "Empty"; break;
                        case 2277: eventLabels[i] = "Empty"; break;
                        case 2278: eventLabels[i] = "Balcony Loader After Nimbus Castle"; break;
                        case 2279: eventLabels[i] = "Empty"; break;
                        case 2280: eventLabels[i] = "Empty"; break;
                        case 2281: eventLabels[i] = "Empty"; break;
                        case 2282: eventLabels[i] = "Empty"; break;
                        case 2283: eventLabels[i] = "Empty"; break;
                        case 2284: eventLabels[i] = "Empty"; break;
                        case 2285: eventLabels[i] = "Empty"; break;
                        case 2286: eventLabels[i] = "Empty"; break;
                        case 2287: eventLabels[i] = "Empty"; break;
                        case 2288: eventLabels[i] = "Empty"; break;
                        case 2289: eventLabels[i] = "Empty"; break;
                        case 2290: eventLabels[i] = "Empty"; break;
                        case 2291: eventLabels[i] = "Empty"; break;
                        case 2292: eventLabels[i] = "Ending Credits Toadofsky"; break;
                        case 2293: eventLabels[i] = "Empty"; break;
                        case 2294: eventLabels[i] = "Ending Credits Wedding Loader"; break;
                        case 2295: eventLabels[i] = "Ending Credits Wedding Logic"; break;
                        case 2296: eventLabels[i] = "Empty"; break;
                        case 2297: eventLabels[i] = "Empty"; break;
                        case 2298: eventLabels[i] = "Empty"; break;
                        case 2299: eventLabels[i] = "Empty"; break;
                        case 2300: eventLabels[i] = "Empty"; break;
                        case 2301: eventLabels[i] = "Empty"; break;
                        case 2302: eventLabels[i] = "Empty"; break;
                        case 2303: eventLabels[i] = "Empty"; break;
                        case 2304: eventLabels[i] = "Bank 1F Return Event 2"; break;
                        case 2305: eventLabels[i] = "Slot Chest Template"; break;
                        case 2306: eventLabels[i] = "Empty"; break;
                        case 2307: eventLabels[i] = "Tower Button"; break;
                        case 2308: eventLabels[i] = "Booster Pass 1St Room Loader"; break;
                        case 2309: eventLabels[i] = "Booster Pass Lakitu Tosses Spiny"; break;
                        case 2310: eventLabels[i] = "Empty"; break;
                        case 2311: eventLabels[i] = "Booster Pass Artichoker Encounter 1"; break;
                        case 2312: eventLabels[i] = "Booster Pass Spiny Coin Button"; break;
                        case 2313: eventLabels[i] = "Booster Pass Artichoker Encounter 2"; break;
                        case 2314: eventLabels[i] = "Empty"; break;
                        case 2315: eventLabels[i] = "Tower Parachute Room Loader"; break;
                        case 2316: eventLabels[i] = "Gardener Exterior Loader"; break;
                        case 2317: eventLabels[i] = "Gardener Cloud Loader"; break;
                        case 2318: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2319: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2320: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2321: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2322: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2323: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2324: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2325: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2326: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2327: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2328: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2329: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2330: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2331: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2332: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2333: eventLabels[i] = "Booster Pass 2Nd Room Spiny Summoner"; break;
                        case 2334: eventLabels[i] = "Empty"; break;
                        case 2335: eventLabels[i] = "Tower First Staircase Loader"; break;
                        case 2336: eventLabels[i] = "Tower First Staircase Spookum Direction 1"; break;
                        case 2337: eventLabels[i] = "Tower First Staircase Spookum Direction 2"; break;
                        case 2338: eventLabels[i] = "Tower Button Room Loader"; break;
                        case 2339: eventLabels[i] = "Tower First Staircase Controls Npc Behind Curtain"; break;
                        case 2340: eventLabels[i] = "Tower Seesaw Chest Room Loader"; break;
                        case 2341: eventLabels[i] = "Tower Seesaw Chest"; break;
                        case 2342: eventLabels[i] = "Tower Seesaw Chest Contd"; break;
                        case 2343: eventLabels[i] = "Tower Seesaw Room Set Origin"; break;
                        case 2344: eventLabels[i] = "Tower Thwomp Seesaw Room Loader"; break;
                        case 2345: eventLabels[i] = "Tower Thwomp Seesaw"; break;
                        case 2346: eventLabels[i] = "Tower Thwomp Seesaw Contd"; break;
                        case 2347: eventLabels[i] = "Tower Top Floor Dummy Chest"; break;
                        case 2348: eventLabels[i] = "Tower Bullet Bill Room Loader"; break;
                        case 2349: eventLabels[i] = "Tower Spookum Jumps Out"; break;
                        case 2350: eventLabels[i] = "Climb Gardener Beanstalk"; break;
                        case 2351: eventLabels[i] = "Tower Start Bullet Bills Animation"; break;
                        case 2352: eventLabels[i] = "Tower Start Bullet Bills"; break;
                        case 2353: eventLabels[i] = "Tower Henchman 3"; break;
                        case 2354: eventLabels[i] = "Empty"; break;
                        case 2355: eventLabels[i] = "Empty"; break;
                        case 2356: eventLabels[i] = "Empty"; break;
                        case 2357: eventLabels[i] = "Empty"; break;
                        case 2358: eventLabels[i] = "Tower Thwomp Seesaw Room Loader Contd"; break;
                        case 2359: eventLabels[i] = "Abyss 1St Save Room Loader"; break;
                        case 2360: eventLabels[i] = "Abyss 1St Trampoline Catcher Loader"; break;
                        case 2361: eventLabels[i] = "Abyss Ameboid Button Room Loader"; break;
                        case 2362: eventLabels[i] = "Abyss Four Bolt Room Loader"; break;
                        case 2363: eventLabels[i] = "Abyss 1St Boss Room Loader"; break;
                        case 2364: eventLabels[i] = "Tower Top Floor Chest Room Loader"; break;
                        case 2365: eventLabels[i] = "Empty"; break;
                        case 2366: eventLabels[i] = "Empty"; break;
                        case 2367: eventLabels[i] = "Empty"; break;
                        case 2368: eventLabels[i] = "Empty"; break;
                        case 2369: eventLabels[i] = "Abyss Bolt"; break;
                        case 2370: eventLabels[i] = "Abyss Bolt"; break;
                        case 2371: eventLabels[i] = "Abyss Bolt"; break;
                        case 2372: eventLabels[i] = "Abyss Bolt"; break;
                        case 2373: eventLabels[i] = "Empty"; break;
                        case 2374: eventLabels[i] = "Empty"; break;
                        case 2375: eventLabels[i] = "Empty"; break;
                        case 2376: eventLabels[i] = "Empty"; break;
                        case 2377: eventLabels[i] = "Empty"; break;
                        case 2378: eventLabels[i] = "Tower Parachute Room Hidden Item"; break;
                        case 2379: eventLabels[i] = "Abyss 1St Save Room Background"; break;
                        case 2380: eventLabels[i] = "Abyss Bolt Near Side"; break;
                        case 2381: eventLabels[i] = "Abyss Bolt Far Side"; break;
                        case 2382: eventLabels[i] = "Abyss Bolt Near Side"; break;
                        case 2383: eventLabels[i] = "Abyss Bolt Far Side"; break;
                        case 2384: eventLabels[i] = "Gardeners House Loader"; break;
                        case 2385: eventLabels[i] = "Abyss Four Bolt Room Background"; break;
                        case 2386: eventLabels[i] = "Abyss Four Bolt Room Bolt"; break;
                        case 2387: eventLabels[i] = "Bean Valley Boss Prize Pickup"; break;
                        case 2388: eventLabels[i] = "Abyss Ameboid Button"; break;
                        case 2389: eventLabels[i] = "Empty"; break;
                        case 2390: eventLabels[i] = "Abyss 1St Save Point"; break;
                        case 2391: eventLabels[i] = "Beanstalk From Inside Gardeners House"; break;
                        case 2392: eventLabels[i] = "Gardener"; break;
                        case 2393: eventLabels[i] = "Abyss Exit Trampoline"; break;
                        case 2394: eventLabels[i] = "Empty"; break;
                        case 2395: eventLabels[i] = "Empty"; break;
                        case 2396: eventLabels[i] = "Empty"; break;
                        case 2397: eventLabels[i] = "Empty"; break;
                        case 2398: eventLabels[i] = "Empty"; break;
                        case 2399: eventLabels[i] = "Abyss Room 1 Loader"; break;
                        case 2400: eventLabels[i] = "Empty"; break;
                        case 2401: eventLabels[i] = "Begin 8Bit"; break;
                        case 2402: eventLabels[i] = "8Bit Background"; break;
                        case 2403: eventLabels[i] = "8Bit End East"; break;
                        case 2404: eventLabels[i] = "8Bit End West"; break;
                        case 2405: eventLabels[i] = "Star Hill Final Area Loader"; break;
                        case 2406: eventLabels[i] = "Empty"; break;
                        case 2407: eventLabels[i] = "Star Hill Final Exit"; break;
                        case 2408: eventLabels[i] = "Abyss Bolt Near Side"; break;
                        case 2409: eventLabels[i] = "Abyss Room Before 1St Boss Loader"; break;
                        case 2410: eventLabels[i] = "Forest Tree Generic Underground Trampoline"; break;
                        case 2411: eventLabels[i] = "Forest Underground 2 Exit Trampoline"; break;
                        case 2412: eventLabels[i] = "Forest Secret Trampoline"; break;
                        case 2413: eventLabels[i] = "Forest Underground 2 Entrance Trampoline"; break;
                        case 2414: eventLabels[i] = "Forest Underground 1 Exit Trampoline"; break;
                        case 2415: eventLabels[i] = "Forest Underground 1 Entrance Trampoline"; break;
                        case 2416: eventLabels[i] = "Forest Trampoline Business Logic"; break;
                        case 2417: eventLabels[i] = "Tower Chomp Stairway Loader"; break;
                        case 2418: eventLabels[i] = "Forest Underground 1 Loader"; break;
                        case 2419: eventLabels[i] = "Empty"; break;
                        case 2420: eventLabels[i] = "Empty"; break;
                        case 2421: eventLabels[i] = "Empty"; break;
                        case 2422: eventLabels[i] = "Abyss Room Before 1St Boss Lower Trampoline"; break;
                        case 2423: eventLabels[i] = "Abyss Trampoline To 1St Boss"; break;
                        case 2424: eventLabels[i] = "Forest Arrow Hits You"; break;
                        case 2425: eventLabels[i] = "Forest Maze Secret Loader"; break;
                        case 2426: eventLabels[i] = "Forest Mushroom Pickup"; break;
                        case 2427: eventLabels[i] = "Forest Underground 2 Loader"; break;
                        case 2428: eventLabels[i] = "Empty"; break;
                        case 2429: eventLabels[i] = "Forest Unknown Summoner"; break;
                        case 2430: eventLabels[i] = "Forest Premaze Save Room Loader"; break;
                        case 2431: eventLabels[i] = "Forest Maze Area Loader"; break;
                        case 2432: eventLabels[i] = "Forest Maze Transition"; break;
                        case 2433: eventLabels[i] = "Forest Maze Transition"; break;
                        case 2434: eventLabels[i] = "Forest Maze Transition"; break;
                        case 2435: eventLabels[i] = "Forest Maze Transition"; break;
                        case 2436: eventLabels[i] = "Forest Boss Room Exit To Maze"; break;
                        case 2437: eventLabels[i] = "Forest Boss Room Exit To World Map"; break;
                        case 2438: eventLabels[i] = "Forest Secret Trunk"; break;
                        case 2439: eventLabels[i] = "Forest Secret Area Exit"; break;
                        case 2440: eventLabels[i] = "Forest Final Wiggler Pipe"; break;
                        case 2441: eventLabels[i] = "Forest 1St Trunk"; break;
                        case 2442: eventLabels[i] = "Forest Initiate Maze"; break;
                        case 2443: eventLabels[i] = "Forest Room Before Trunks Area Trunk"; break;
                        case 2444: eventLabels[i] = "Forest Premaze Save Room Trunk"; break;
                        case 2445: eventLabels[i] = "Tower Small Save Room Loader"; break;
                        case 2446: eventLabels[i] = "Forest Boss Henchmen Bounce"; break;
                        case 2447: eventLabels[i] = "Forest Summon Fast Amanita"; break;
                        case 2448: eventLabels[i] = "Forest Boss Fight"; break;
                        case 2449: eventLabels[i] = "Forest Trunk Room Rightmost Trunk"; break;
                        case 2450: eventLabels[i] = "Forest Trunk Room Lowest Trunk"; break;
                        case 2451: eventLabels[i] = "Forest Trunk Room Middle Right Trunk"; break;
                        case 2452: eventLabels[i] = "Forest Trunk Room Middle Left Trunk"; break;
                        case 2453: eventLabels[i] = "Forest Trunk Room Upper Left Trunk"; break;
                        case 2454: eventLabels[i] = "Forest Trunk Room Upper Right Trunk"; break;
                        case 2455: eventLabels[i] = "Forest Trunk Room Wiggler Trunk"; break;
                        case 2456: eventLabels[i] = "Awaken Sleeping Wiggler"; break;
                        case 2457: eventLabels[i] = "Star Hill 1St Room Summon South Sackit"; break;
                        case 2458: eventLabels[i] = "Star Hill 1St Room Summon North Sackit"; break;
                        case 2459: eventLabels[i] = "Star Hill 1St Room Summon Northwest Sackit"; break;
                        case 2460: eventLabels[i] = "Star Hill 1St Room Summon Southeast Sackit"; break;
                        case 2461: eventLabels[i] = "Star Hill 2Nd Room Summon North Sackit"; break;
                        case 2462: eventLabels[i] = "Star Hill 2Nd Room Summon East Sackit"; break;
                        case 2463: eventLabels[i] = "Star Hill 2Nd Room Summon West Sackit"; break;
                        case 2464: eventLabels[i] = "Star Hill 2Nd Room Summon Central Sackit"; break;
                        case 2465: eventLabels[i] = "Empty"; break;
                        case 2466: eventLabels[i] = "Bean Valley 1St Room Loader"; break;
                        case 2467: eventLabels[i] = "Bean Valley Pipe To Dead End"; break;
                        case 2468: eventLabels[i] = "Bean Valley Dead End Pipe"; break;
                        case 2469: eventLabels[i] = "Bean Valley 1St Progression Pipe"; break;
                        case 2470: eventLabels[i] = "Bean Valley 1St Progression Pipe Reverse"; break;
                        case 2471: eventLabels[i] = "Bean Valley 2Nd Progression Pipe"; break;
                        case 2472: eventLabels[i] = "Bean Valley 2Nd Progression Pipe Reverse"; break;
                        case 2473: eventLabels[i] = "Bean Valley Pipe To 1St Chest"; break;
                        case 2474: eventLabels[i] = "Bean Valley 1St Chest Pipe"; break;
                        case 2475: eventLabels[i] = "Star Hill 3Rd Room Summon Sackit"; break;
                        case 2476: eventLabels[i] = "Bean Valley 5 Pipe Area Loader"; break;
                        case 2477: eventLabels[i] = "Bean Valley Piranha Plant Animations"; break;
                        case 2478: eventLabels[i] = "Bean Valley Beanstalk Room Loader"; break;
                        case 2479: eventLabels[i] = "Bean Valley Bottom Left Piranha"; break;
                        case 2480: eventLabels[i] = "Bean Valley Bottom Right Piranha"; break;
                        case 2481: eventLabels[i] = "Bean Valley Rightmost Piranha"; break;
                        case 2482: eventLabels[i] = "Bean Valley Top Piranha"; break;
                        case 2483: eventLabels[i] = "Bean Valley Leftmost Piranha"; break;
                        case 2484: eventLabels[i] = "Bean Valley Top Pipe"; break;
                        case 2485: eventLabels[i] = "Bean Valley Leftmost Pipe"; break;
                        case 2486: eventLabels[i] = "Bean Valley Bottom Left Pipe"; break;
                        case 2487: eventLabels[i] = "Bean Valley Rightmost Pipe"; break;
                        case 2488: eventLabels[i] = "Bean Valley Bottom Right Pipe"; break;
                        case 2489: eventLabels[i] = "Bean Valley Leftmost Pipe Basement Loader"; break;
                        case 2490: eventLabels[i] = "Bean Valley Leftmost Pipe Basement Original Slot Machine"; break;
                        case 2491: eventLabels[i] = "Bean Valley Bottom Left Pipe Basement Original Slot Machine"; break;
                        case 2492: eventLabels[i] = "Bean Valley Bottom Right Pipe Basement Original Slot Machine"; break;
                        case 2493: eventLabels[i] = "Mimic 3"; break;
                        case 2494: eventLabels[i] = "Empty"; break;
                        case 2495: eventLabels[i] = "Empty"; break;
                        case 2496: eventLabels[i] = "Start Game"; break;
                        case 2497: eventLabels[i] = "Additional Gating Logic Start Playing"; break;
                        case 2498: eventLabels[i] = "Empty"; break;
                        case 2499: eventLabels[i] = "Empty"; break;
                        case 2500: eventLabels[i] = "Empty"; break;
                        case 2501: eventLabels[i] = "Empty"; break;
                        case 2502: eventLabels[i] = "Empty"; break;
                        case 2503: eventLabels[i] = "Star Hill 3Rd Room Top Left Flower"; break;
                        case 2504: eventLabels[i] = "Star Hill 3Rd Room Bottom Left Flower"; break;
                        case 2505: eventLabels[i] = "Star Hill 3Rd Room Door Front Flower"; break;
                        case 2506: eventLabels[i] = "Star Hill 3Rd Room Door Back Flower"; break;
                        case 2507: eventLabels[i] = "Star Hill 3Rd Room Top Right Flower"; break;
                        case 2508: eventLabels[i] = "Star Hill 3Rd Room Bottom Right Flower"; break;
                        case 2509: eventLabels[i] = "Star Hill 3Rd Room Open Door"; break;
                        case 2510: eventLabels[i] = "Star Hill 1St Room Top Left Flower"; break;
                        case 2511: eventLabels[i] = "Star Hill 1St Room Bottom Left Flower"; break;
                        case 2512: eventLabels[i] = "Star Hill 1St Room Bottom Middle Flower"; break;
                        case 2513: eventLabels[i] = "Star Hill 1St Room Top Right Flower"; break;
                        case 2514: eventLabels[i] = "Star Hill 1St Room Bottom Right Flower"; break;
                        case 2515: eventLabels[i] = "Star Hill 1St Room Open Door"; break;
                        case 2516: eventLabels[i] = "Star Hill 2Nd Room Top Left Flower"; break;
                        case 2517: eventLabels[i] = "Star Hill 2Nd Room Bottom Left Flower"; break;
                        case 2518: eventLabels[i] = "Star Hill 2Nd Room Central Left Flower"; break;
                        case 2519: eventLabels[i] = "Star Hill 2Nd Room Central Right Flower"; break;
                        case 2520: eventLabels[i] = "Star Hill 2Nd Room Top Right Flower"; break;
                        case 2521: eventLabels[i] = "Star Hill 2Nd Room Bottom Right Flower"; break;
                        case 2522: eventLabels[i] = "Star Hill 2Nd Room Open Door"; break;
                        case 2523: eventLabels[i] = "Star Hill 1St Room Use Door"; break;
                        case 2524: eventLabels[i] = "Star Hill 2Nd Room Loader"; break;
                        case 2525: eventLabels[i] = "Star Hill 2Nd Room Use Door"; break;
                        case 2526: eventLabels[i] = "Star Hill 1St Room Loader"; break;
                        case 2527: eventLabels[i] = "Star Hill 1St Room Wish In Front Of Door"; break;
                        case 2528: eventLabels[i] = "Star Hill 1St Room Wish Southeast Of Door"; break;
                        case 2529: eventLabels[i] = "Star Hill 1St Room Wish Top Left"; break;
                        case 2530: eventLabels[i] = "Star Hill 1St Room Wish Bottom Right"; break;
                        case 2531: eventLabels[i] = "Star Hill 2Nd Room Wish Bottom Right"; break;
                        case 2532: eventLabels[i] = "Star Hill 2Nd Room Wish Bottom Left"; break;
                        case 2533: eventLabels[i] = "Star Hill 2Nd Room Wish In Front Of Door"; break;
                        case 2534: eventLabels[i] = "Star Hill 2Nd Room Wish Top Right"; break;
                        case 2535: eventLabels[i] = "Star Hill 2Nd Room Wish Top Left"; break;
                        case 2536: eventLabels[i] = "Star Hill 3Rd Room Wish Top Left"; break;
                        case 2537: eventLabels[i] = "Star Hill 3Rd Room Wish Behind Door Left"; break;
                        case 2538: eventLabels[i] = "Star Hill 3Rd Room Wish Behind Door Right"; break;
                        case 2539: eventLabels[i] = "Bean Valley Leftmost Pipe Basement Trampoline"; break;
                        case 2540: eventLabels[i] = "Bean Valley Top Pipe Basement Trampoline"; break;
                        case 2541: eventLabels[i] = "Bean Valley Top Pipe Basement Loader"; break;
                        case 2542: eventLabels[i] = "Bean Valley Bottom Left Pipe Basement Trampoline"; break;
                        case 2543: eventLabels[i] = "Bean Valley Bottom Left Pipe Basement Loader"; break;
                        case 2544: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Loader"; break;
                        case 2545: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Trampoline To Five Pipe Room"; break;
                        case 2546: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Trampoline To Lone Chest"; break;
                        case 2547: eventLabels[i] = "Bean Valley Rightmost Pipe"; break;
                        case 2548: eventLabels[i] = "Bean Valley Bottom Right Pipe"; break;
                        case 2549: eventLabels[i] = "Bean Valley Bottom Right Pipe Basement Loader"; break;
                        case 2550: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Geckit Runs At You"; break;
                        case 2551: eventLabels[i] = "Empty"; break;
                        case 2552: eventLabels[i] = "Empty"; break;
                        case 2553: eventLabels[i] = "Empty"; break;
                        case 2554: eventLabels[i] = "Bean Valley Rightmost Pipe Basement Staircase Item"; break;
                        case 2555: eventLabels[i] = "Bean Valley Boss Room Loader"; break;
                        case 2556: eventLabels[i] = "Bean Valley Boss Fight"; break;
                        case 2557: eventLabels[i] = "Bean Valley Waters Boss"; break;
                        case 2558: eventLabels[i] = "Bean Valley Boss Room Pipe"; break;
                        case 2559: eventLabels[i] = "Bean Valley Beanstalk Room Pipe"; break;
                        case 2560: eventLabels[i] = "Empty"; break;
                        case 2561: eventLabels[i] = "Empty"; break;
                        case 2562: eventLabels[i] = "Empty"; break;
                        case 2563: eventLabels[i] = "Reveal Bean Valley Beanstalk"; break;
                        case 2564: eventLabels[i] = "Booster Pass Bush Item"; break;
                        case 2565: eventLabels[i] = "Empty"; break;
                        case 2566: eventLabels[i] = "Empty"; break;
                        case 2567: eventLabels[i] = "Empty"; break;
                        case 2568: eventLabels[i] = "Booster Pass Exit To Secret"; break;
                        case 2569: eventLabels[i] = "Booster Pass Secret Exit"; break;
                        case 2570: eventLabels[i] = "Booster Pass Secret Loader"; break;
                        case 2571: eventLabels[i] = "Booster Pass Secret Background"; break;
                        case 2572: eventLabels[i] = "Booster Pass Exit From Room 1 To Room 2"; break;
                        case 2573: eventLabels[i] = "Empty"; break;
                        case 2574: eventLabels[i] = "Tower First Staircase Chest"; break;
                        case 2575: eventLabels[i] = "Tower 8Bit Music"; break;
                        case 2576: eventLabels[i] = "Tower 8Bit Room Loader"; break;
                        case 2577: eventLabels[i] = "Empty"; break;
                        case 2578: eventLabels[i] = "Booster Tower Small Save Room Back Exit"; break;
                        case 2579: eventLabels[i] = "Empty"; break;
                        case 2580: eventLabels[i] = "Empty"; break;
                        case 2581: eventLabels[i] = "Empty"; break;
                        case 2582: eventLabels[i] = "Empty"; break;
                        case 2583: eventLabels[i] = "Empty"; break;
                        case 2584: eventLabels[i] = "Empty"; break;
                        case 2585: eventLabels[i] = "Empty"; break;
                        case 2586: eventLabels[i] = "Booster Pass Apprentice Fight"; break;
                        case 2587: eventLabels[i] = "Snifit 4"; break;
                        case 2588: eventLabels[i] = "Snifit 5"; break;
                        case 2589: eventLabels[i] = "Snifit 6"; break;
                        case 2590: eventLabels[i] = "Snifit 7"; break;
                        case 2591: eventLabels[i] = "Snifit 8"; break;
                        case 2592: eventLabels[i] = "Abyss Fall Off Before First Boss"; break;
                        case 2593: eventLabels[i] = "Abyss Pre First Boss Bolt"; break;
                        case 2594: eventLabels[i] = "Abyss Pre First Boss Bolt"; break;
                        case 2595: eventLabels[i] = "Abyss Save Room With Chest Loader"; break;
                        case 2596: eventLabels[i] = "Abyss 1St Boss Fight"; break;
                        case 2597: eventLabels[i] = "Abyss Pre First Boss Bolt"; break;
                        case 2598: eventLabels[i] = "Forest Secret Entrance Loader"; break;
                        case 2599: eventLabels[i] = "Empty"; break;
                        case 2600: eventLabels[i] = "Empty"; break;
                        case 2601: eventLabels[i] = "Factory 4Th Room Loader"; break;
                        case 2602: eventLabels[i] = "Bean Valley Exit To World Map"; break;
                        case 2603: eventLabels[i] = "Factory 4Th Boss Fight"; break;
                        case 2604: eventLabels[i] = "Abyss Chest Before 1St Boss"; break;
                        case 2605: eventLabels[i] = "Factory 1St Room Before Fight Loader"; break;
                        case 2606: eventLabels[i] = "Factory 1St Boss"; break;
                        case 2607: eventLabels[i] = "Empty"; break;
                        case 2608: eventLabels[i] = "Factory 1St Room Exit To 2Nd Room"; break;
                        case 2609: eventLabels[i] = "Empty"; break;
                        case 2610: eventLabels[i] = "Empty"; break;
                        case 2611: eventLabels[i] = "Empty"; break;
                        case 2612: eventLabels[i] = "Empty"; break;
                        case 2613: eventLabels[i] = "Empty"; break;
                        case 2614: eventLabels[i] = "Empty"; break;
                        case 2615: eventLabels[i] = "Empty"; break;
                        case 2616: eventLabels[i] = "Factory 4Th Room Green Button"; break;
                        case 2617: eventLabels[i] = "Factory 2Nd Room Loader"; break;
                        case 2618: eventLabels[i] = "Factory 2Nd Boss"; break;
                        case 2619: eventLabels[i] = "Ending Credits Sunset"; break;
                        case 2620: eventLabels[i] = "Factory 3Rd Room Background Npcs Bonk Conveyor"; break;
                        case 2621: eventLabels[i] = "Factory 3Rd Room Loader"; break;
                        case 2622: eventLabels[i] = "Ending Credits Keep"; break;
                        case 2623: eventLabels[i] = "Empty"; break;
                        case 2624: eventLabels[i] = "Empty"; break;
                        case 2625: eventLabels[i] = "Empty"; break;
                        case 2626: eventLabels[i] = "Empty"; break;
                        case 2627: eventLabels[i] = "Factory 3Rd Boss Fight"; break;
                        case 2628: eventLabels[i] = "Ending Credits Sunset Opener"; break;
                        case 2629: eventLabels[i] = "Ending Credits Keep Opener"; break;
                        case 2630: eventLabels[i] = "Blackjack Table"; break;
                        case 2631: eventLabels[i] = "Casino Slot Machine"; break;
                        case 2632: eventLabels[i] = "Blackjack Guy"; break;
                        case 2633: eventLabels[i] = "Casino Interior Loader"; break;
                        case 2634: eventLabels[i] = "Casino Slot Machine"; break;
                        case 2635: eventLabels[i] = "Casino Doorway Loader"; break;
                        case 2636: eventLabels[i] = "Casino Guard"; break;
                        case 2637: eventLabels[i] = "Casino Grate Guy"; break;
                        case 2638: eventLabels[i] = "Empty"; break;
                        case 2639: eventLabels[i] = "Empty"; break;
                        case 2640: eventLabels[i] = "Booster Pass Right Chest"; break;
                        case 2641: eventLabels[i] = "Factory 1St Room Loader After Fight"; break;
                        case 2642: eventLabels[i] = "Empty"; break;
                        case 2643: eventLabels[i] = "Toad Shop"; break;
                        case 2644: eventLabels[i] = "Empty"; break;
                        case 2645: eventLabels[i] = "Casino Subroutine"; break;
                        case 2646: eventLabels[i] = "Casino Grate Guy Await Button"; break;
                        case 2647: eventLabels[i] = "Empty"; break;
                        case 2648: eventLabels[i] = "Casino Exterior Loader"; break;
                        case 2649: eventLabels[i] = "Casino Grate Guy Random Prize Granter"; break;
                        case 2650: eventLabels[i] = "Casino Grate Guy Check If Sidequest Completed"; break;
                        case 2651: eventLabels[i] = "Bucket Warp Check Granter"; break;
                        case 2652: eventLabels[i] = "Seaside Exit To Beach"; break;
                        case 2653: eventLabels[i] = "Empty"; break;
                        case 2654: eventLabels[i] = "Empty"; break;
                        case 2655: eventLabels[i] = "Empty"; break;
                        case 2656: eventLabels[i] = "Empty"; break;
                        case 2657: eventLabels[i] = "Empty"; break;
                        case 2658: eventLabels[i] = "Empty"; break;
                        case 2659: eventLabels[i] = "Empty"; break;
                        case 2660: eventLabels[i] = "Empty"; break;
                        case 2661: eventLabels[i] = "Empty"; break;
                        case 2662: eventLabels[i] = "Empty"; break;
                        case 2663: eventLabels[i] = "Empty"; break;
                        case 2664: eventLabels[i] = "Empty"; break;
                        case 2665: eventLabels[i] = "Empty"; break;
                        case 2666: eventLabels[i] = "Empty"; break;
                        case 2667: eventLabels[i] = "Empty"; break;
                        case 2668: eventLabels[i] = "Knife Guy Second Grant"; break;
                        case 2669: eventLabels[i] = "Empty"; break;
                        case 2670: eventLabels[i] = "Tower Knife Guy Consolation Prize"; break;
                        case 2671: eventLabels[i] = "Tower Knife Guy Check If Sidequest Completed"; break;
                        case 2672: eventLabels[i] = "Tower Knife Guy Minigame Business Logic"; break;
                        case 2673: eventLabels[i] = "Tower Knife Guy Minigame Business Logic Subroutine"; break;
                        case 2674: eventLabels[i] = "Tower Knife Guy Minigame Business Logic Subroutine"; break;
                        case 2675: eventLabels[i] = "Clone Reserved"; break;
                        case 2676: eventLabels[i] = "Clone Reserved"; break;
                        case 2677: eventLabels[i] = "Clone Reserved"; break;
                        case 2678: eventLabels[i] = "Clone Reserved"; break;
                        case 2679: eventLabels[i] = "Clone Reserved"; break;
                        case 2680: eventLabels[i] = "Clone Reserved"; break;
                        case 2681: eventLabels[i] = "Clone Reserved"; break;
                        case 2682: eventLabels[i] = "Clone Reserved"; break;
                        case 2683: eventLabels[i] = "Clone Reserved"; break;
                        case 2684: eventLabels[i] = "Clone Reserved"; break;
                        case 2685: eventLabels[i] = "Clone Reserved"; break;
                        case 2686: eventLabels[i] = "Clone Reserved"; break;
                        case 2687: eventLabels[i] = "Clone Reserved"; break;
                        case 2688: eventLabels[i] = "Clone Reserved"; break;
                        case 2689: eventLabels[i] = "Clone Reserved"; break;
                        case 2690: eventLabels[i] = "Clone Reserved"; break;
                        case 2691: eventLabels[i] = "Clone Reserved"; break;
                        case 2692: eventLabels[i] = "Clone Reserved"; break;
                        case 2693: eventLabels[i] = "Clone Reserved"; break;
                        case 2694: eventLabels[i] = "Clone Reserved"; break;
                        case 2695: eventLabels[i] = "Clone Reserved"; break;
                        case 2696: eventLabels[i] = "Clone Reserved"; break;
                        case 2697: eventLabels[i] = "Clone Reserved"; break;
                        case 2698: eventLabels[i] = "Clone Reserved"; break;
                        case 2699: eventLabels[i] = "Clone Reserved"; break;
                        case 2700: eventLabels[i] = "Clone Reserved"; break;
                        case 2701: eventLabels[i] = "Clone Reserved"; break;
                        case 2702: eventLabels[i] = "Clone Reserved"; break;
                        case 2703: eventLabels[i] = "Clone Reserved"; break;
                        case 2704: eventLabels[i] = "Clone Reserved"; break;
                        case 2705: eventLabels[i] = "Clone Reserved"; break;
                        case 2706: eventLabels[i] = "Clone Reserved"; break;
                        case 2707: eventLabels[i] = "Clone Reserved"; break;
                        case 2708: eventLabels[i] = "Clone Reserved"; break;
                        case 2709: eventLabels[i] = "Clone Reserved"; break;
                        case 2710: eventLabels[i] = "Clone Reserved"; break;
                        case 2711: eventLabels[i] = "Clone Reserved"; break;
                        case 2712: eventLabels[i] = "Clone Reserved"; break;
                        case 2713: eventLabels[i] = "Clone Reserved"; break;
                        case 2714: eventLabels[i] = "Clone Reserved"; break;
                        case 2715: eventLabels[i] = "Clone Reserved"; break;
                        case 2716: eventLabels[i] = "Clone Reserved"; break;
                        case 2717: eventLabels[i] = "Clone Reserved"; break;
                        case 2718: eventLabels[i] = "Clone Reserved"; break;
                        case 2719: eventLabels[i] = "Clone Reserved"; break;
                        case 2720: eventLabels[i] = "Clone Reserved"; break;
                        case 2721: eventLabels[i] = "Clone Reserved"; break;
                        case 2722: eventLabels[i] = "Clone Reserved"; break;
                        case 2723: eventLabels[i] = "Clone Reserved"; break;
                        case 2724: eventLabels[i] = "Clone Reserved"; break;
                        case 2725: eventLabels[i] = "Clone Reserved"; break;
                        case 2726: eventLabels[i] = "Clone Reserved"; break;
                        case 2727: eventLabels[i] = "Clone Reserved"; break;
                        case 2728: eventLabels[i] = "Clone Reserved"; break;
                        case 2729: eventLabels[i] = "Clone Reserved"; break;
                        case 2730: eventLabels[i] = "Clone Reserved"; break;
                        case 2731: eventLabels[i] = "Clone Reserved"; break;
                        case 2732: eventLabels[i] = "Clone Reserved"; break;
                        case 2733: eventLabels[i] = "Clone Reserved"; break;
                        case 2734: eventLabels[i] = "Clone Reserved"; break;
                        case 2735: eventLabels[i] = "Clone Reserved"; break;
                        case 2736: eventLabels[i] = "Clone Reserved"; break;
                        case 2737: eventLabels[i] = "Clone Reserved"; break;
                        case 2738: eventLabels[i] = "Clone Reserved"; break;
                        case 2739: eventLabels[i] = "Clone Reserved"; break;
                        case 2740: eventLabels[i] = "Clone Reserved"; break;
                        case 2741: eventLabels[i] = "Clone Reserved"; break;
                        case 2742: eventLabels[i] = "Clone Reserved"; break;
                        case 2743: eventLabels[i] = "Clone Reserved"; break;
                        case 2744: eventLabels[i] = "Clone Reserved"; break;
                        case 2745: eventLabels[i] = "Clone Reserved"; break;
                        case 2746: eventLabels[i] = "Clone Reserved"; break;
                        case 2747: eventLabels[i] = "Clone Reserved"; break;
                        case 2748: eventLabels[i] = "Clone Reserved"; break;
                        case 2749: eventLabels[i] = "Clone Reserved"; break;
                        case 2750: eventLabels[i] = "Clone Reserved"; break;
                        case 2751: eventLabels[i] = "Clone Reserved"; break;
                        case 2752: eventLabels[i] = "Clone Reserved"; break;
                        case 2753: eventLabels[i] = "Clone Reserved"; break;
                        case 2754: eventLabels[i] = "Clone Reserved"; break;
                        case 2755: eventLabels[i] = "Clone Reserved"; break;
                        case 2756: eventLabels[i] = "Clone Reserved"; break;
                        case 2757: eventLabels[i] = "Clone Reserved"; break;
                        case 2758: eventLabels[i] = "Clone Reserved"; break;
                        case 2759: eventLabels[i] = "Clone Reserved"; break;
                        case 2760: eventLabels[i] = "Clone Reserved"; break;
                        case 2761: eventLabels[i] = "Clone Reserved"; break;
                        case 2762: eventLabels[i] = "Clone Reserved"; break;
                        case 2763: eventLabels[i] = "Clone Reserved"; break;
                        case 2764: eventLabels[i] = "Clone Reserved"; break;
                        case 2765: eventLabels[i] = "Clone Reserved"; break;
                        case 2766: eventLabels[i] = "Clone Reserved"; break;
                        case 2767: eventLabels[i] = "Clone Reserved"; break;
                        case 2768: eventLabels[i] = "Clone Reserved"; break;
                        case 2769: eventLabels[i] = "Clone Reserved"; break;
                        case 2770: eventLabels[i] = "Clone Reserved"; break;
                        case 2771: eventLabels[i] = "Clone Reserved"; break;
                        case 2772: eventLabels[i] = "Clone Reserved"; break;
                        case 2773: eventLabels[i] = "Clone Reserved"; break;
                        case 2774: eventLabels[i] = "Clone Reserved"; break;
                        case 2775: eventLabels[i] = "Clone Reserved"; break;
                        case 2776: eventLabels[i] = "Clone Reserved"; break;
                        case 2777: eventLabels[i] = "Clone Reserved"; break;
                        case 2778: eventLabels[i] = "Clone Reserved"; break;
                        case 2779: eventLabels[i] = "Clone Reserved"; break;
                        case 2780: eventLabels[i] = "Clone Reserved"; break;
                        case 2781: eventLabels[i] = "Clone Reserved"; break;
                        case 2782: eventLabels[i] = "Clone Reserved"; break;
                        case 2783: eventLabels[i] = "Clone Reserved"; break;
                        case 2784: eventLabels[i] = "Clone Reserved"; break;
                        case 2785: eventLabels[i] = "Clone Reserved"; break;
                        case 2786: eventLabels[i] = "Clone Reserved"; break;
                        case 2787: eventLabels[i] = "Clone Reserved"; break;
                        case 2788: eventLabels[i] = "Clone Reserved"; break;
                        case 2789: eventLabels[i] = "Clone Reserved"; break;
                        case 2790: eventLabels[i] = "Clone Reserved"; break;
                        case 2791: eventLabels[i] = "Clone Reserved"; break;
                        case 2792: eventLabels[i] = "Clone Reserved"; break;
                        case 2793: eventLabels[i] = "Star Hill Entrance Loader"; break;
                        case 2794: eventLabels[i] = "Star Hill Marrymore Exit Sign"; break;
                        case 2795: eventLabels[i] = "Star Hill Progress Sign"; break;
                        case 2796: eventLabels[i] = "Star Hill Marrymore Exit Flower"; break;
                        case 2797: eventLabels[i] = "Star Hill Progress Flower"; break;
                        case 2798: eventLabels[i] = "Star Hill Exit To World Map"; break;
                        case 2799: eventLabels[i] = "Star Hill Entrance To 1St Room"; break;
                        case 2800: eventLabels[i] = "Casino Exit To World Map"; break;
                        case 2801: eventLabels[i] = "Bean Valley Exit To Casino"; break;
                        case 2802: eventLabels[i] = "Bean Valley Top Pipe Basement Loader"; break;
                        case 2803: eventLabels[i] = "Bean Valley North Pipe Directional Bit"; break;
                        case 2804: eventLabels[i] = "Bean Valley North Pipe Directional Bit"; break;
                        case 2805: eventLabels[i] = "Tower Apprentice Room Loader"; break;
                        case 2806: eventLabels[i] = "Forest Maze Room Before Trunk Room Loader"; break;
                        case 2807: eventLabels[i] = "Mushroom Way 3 Exit To World Map"; break;
                        case 2808: eventLabels[i] = "Mushroom Way Boss Fight"; break;
                        case 2809: eventLabels[i] = "Mushroom Way Boss Threatens You"; break;
                        case 2810: eventLabels[i] = "Empty"; break;
                        case 2811: eventLabels[i] = "Mushroom Way 3 Lower Quick Spiny"; break;
                        case 2812: eventLabels[i] = "Mushroom Way 3 Upper Quick Spiny"; break;
                        case 2813: eventLabels[i] = "Mushroom Way 3 Summon Spinys"; break;
                        case 2814: eventLabels[i] = "Mushroom Way 3 Loader"; break;
                        case 2815: eventLabels[i] = "Empty"; break;
                        case 2816: eventLabels[i] = "Async No Animation Frog Coin"; break;
                        case 2817: eventLabels[i] = "Async No Animation Flower"; break;
                        case 2818: eventLabels[i] = "Async No Animation 10 Coin"; break;
                        case 2819: eventLabels[i] = "Async No Animation 1 Coin"; break;
                        case 2820: eventLabels[i] = "Async No Animation Item"; break;
                        case 2821: eventLabels[i] = "Async No Animation Star Piece"; break;
                        case 2822: eventLabels[i] = "Async No Animation Mushroom"; break;
                        case 2823: eventLabels[i] = "Clone Reserved"; break;
                        case 2824: eventLabels[i] = "Clone Reserved"; break;
                        case 2825: eventLabels[i] = "Clone Reserved"; break;
                        case 2826: eventLabels[i] = "Clone Reserved"; break;
                        case 2827: eventLabels[i] = "Clone Reserved"; break;
                        case 2828: eventLabels[i] = "Clone Reserved"; break;
                        case 2829: eventLabels[i] = "Clone Reserved"; break;
                        case 2830: eventLabels[i] = "Clone Reserved"; break;
                        case 2831: eventLabels[i] = "Clone Reserved"; break;
                        case 2832: eventLabels[i] = "Clone Reserved"; break;
                        case 2833: eventLabels[i] = "Clone Reserved"; break;
                        case 2834: eventLabels[i] = "Clone Reserved"; break;
                        case 2835: eventLabels[i] = "Clone Reserved"; break;
                        case 2836: eventLabels[i] = "Clone Reserved"; break;
                        case 2837: eventLabels[i] = "Clone Reserved"; break;
                        case 2838: eventLabels[i] = "Clone Reserved"; break;
                        case 2839: eventLabels[i] = "Clone Reserved"; break;
                        case 2840: eventLabels[i] = "Clone Reserved"; break;
                        case 2841: eventLabels[i] = "Clone Reserved"; break;
                        case 2842: eventLabels[i] = "Clone Reserved"; break;
                        case 2843: eventLabels[i] = "Clone Reserved"; break;
                        case 2844: eventLabels[i] = "Clone Reserved"; break;
                        case 2845: eventLabels[i] = "Clone Reserved"; break;
                        case 2846: eventLabels[i] = "Clone Reserved"; break;
                        case 2847: eventLabels[i] = "Clone Reserved"; break;
                        case 2848: eventLabels[i] = "Clone Reserved"; break;
                        case 2849: eventLabels[i] = "Clone Reserved"; break;
                        case 2850: eventLabels[i] = "Clone Reserved"; break;
                        case 2851: eventLabels[i] = "Clone Reserved"; break;
                        case 2852: eventLabels[i] = "Clone Reserved"; break;
                        case 2853: eventLabels[i] = "Clone Reserved"; break;
                        case 2854: eventLabels[i] = "Clone Reserved"; break;
                        case 2855: eventLabels[i] = "Clone Reserved"; break;
                        case 2856: eventLabels[i] = "Clone Reserved"; break;
                        case 2857: eventLabels[i] = "Clone Reserved"; break;
                        case 2858: eventLabels[i] = "Clone Reserved"; break;
                        case 2859: eventLabels[i] = "Clone Reserved"; break;
                        case 2860: eventLabels[i] = "Clone Reserved"; break;
                        case 2861: eventLabels[i] = "Clone Reserved"; break;
                        case 2862: eventLabels[i] = "Clone Reserved"; break;
                        case 2863: eventLabels[i] = "Clone Reserved"; break;
                        case 2864: eventLabels[i] = "Clone Reserved"; break;
                        case 2865: eventLabels[i] = "Clone Reserved"; break;
                        case 2866: eventLabels[i] = "Clone Reserved"; break;
                        case 2867: eventLabels[i] = "Clone Reserved"; break;
                        case 2868: eventLabels[i] = "Clone Reserved"; break;
                        case 2869: eventLabels[i] = "Clone Reserved"; break;
                        case 2870: eventLabels[i] = "Clone Reserved"; break;
                        case 2871: eventLabels[i] = "Clone Reserved"; break;
                        case 2872: eventLabels[i] = "Clone Reserved"; break;
                        case 2873: eventLabels[i] = "Clone Reserved"; break;
                        case 2874: eventLabels[i] = "Clone Reserved"; break;
                        case 2875: eventLabels[i] = "Clone Reserved"; break;
                        case 2876: eventLabels[i] = "Clone Reserved"; break;
                        case 2877: eventLabels[i] = "Clone Reserved"; break;
                        case 2878: eventLabels[i] = "Clone Reserved"; break;
                        case 2879: eventLabels[i] = "Clone Reserved"; break;
                        case 2880: eventLabels[i] = "Clone Reserved"; break;
                        case 2881: eventLabels[i] = "Clone Reserved"; break;
                        case 2882: eventLabels[i] = "Clone Reserved"; break;
                        case 2883: eventLabels[i] = "Clone Reserved"; break;
                        case 2884: eventLabels[i] = "Clone Reserved"; break;
                        case 2885: eventLabels[i] = "Clone Reserved"; break;
                        case 2886: eventLabels[i] = "Clone Reserved"; break;
                        case 2887: eventLabels[i] = "Clone Reserved"; break;
                        case 2888: eventLabels[i] = "Clone Reserved"; break;
                        case 2889: eventLabels[i] = "Clone Reserved"; break;
                        case 2890: eventLabels[i] = "Clone Reserved"; break;
                        case 2891: eventLabels[i] = "Clone Reserved"; break;
                        case 2892: eventLabels[i] = "Clone Reserved"; break;
                        case 2893: eventLabels[i] = "Clone Reserved"; break;
                        case 2894: eventLabels[i] = "Clone Reserved"; break;
                        case 2895: eventLabels[i] = "Clone Reserved"; break;
                        case 2896: eventLabels[i] = "Clone Reserved"; break;
                        case 2897: eventLabels[i] = "Clone Reserved"; break;
                        case 2898: eventLabels[i] = "Clone Reserved"; break;
                        case 2899: eventLabels[i] = "Clone Reserved"; break;
                        case 2900: eventLabels[i] = "Clone Reserved"; break;
                        case 2901: eventLabels[i] = "Clone Reserved"; break;
                        case 2902: eventLabels[i] = "Clone Reserved"; break;
                        case 2903: eventLabels[i] = "Clone Reserved"; break;
                        case 2904: eventLabels[i] = "Clone Reserved"; break;
                        case 2905: eventLabels[i] = "Clone Reserved"; break;
                        case 2906: eventLabels[i] = "Clone Reserved"; break;
                        case 2907: eventLabels[i] = "Clone Reserved"; break;
                        case 2908: eventLabels[i] = "Clone Reserved"; break;
                        case 2909: eventLabels[i] = "Clone Reserved"; break;
                        case 2910: eventLabels[i] = "Clone Reserved"; break;
                        case 2911: eventLabels[i] = "Clone Reserved"; break;
                        case 2912: eventLabels[i] = "Clone Reserved"; break;
                        case 2913: eventLabels[i] = "Clone Reserved"; break;
                        case 2914: eventLabels[i] = "Clone Reserved"; break;
                        case 2915: eventLabels[i] = "Clone Reserved"; break;
                        case 2916: eventLabels[i] = "Clone Reserved"; break;
                        case 2917: eventLabels[i] = "Clone Reserved"; break;
                        case 2918: eventLabels[i] = "Clone Reserved"; break;
                        case 2919: eventLabels[i] = "Clone Reserved"; break;
                        case 2920: eventLabels[i] = "Clone Reserved"; break;
                        case 2921: eventLabels[i] = "Clone Reserved"; break;
                        case 2922: eventLabels[i] = "Clone Reserved"; break;
                        case 2923: eventLabels[i] = "Clone Reserved"; break;
                        case 2924: eventLabels[i] = "Clone Reserved"; break;
                        case 2925: eventLabels[i] = "Clone Reserved"; break;
                        case 2926: eventLabels[i] = "Clone Reserved"; break;
                        case 2927: eventLabels[i] = "Clone Reserved"; break;
                        case 2928: eventLabels[i] = "Clone Reserved"; break;
                        case 2929: eventLabels[i] = "Clone Reserved"; break;
                        case 2930: eventLabels[i] = "Clone Reserved"; break;
                        case 2931: eventLabels[i] = "Clone Reserved"; break;
                        case 2932: eventLabels[i] = "Clone Reserved"; break;
                        case 2933: eventLabels[i] = "Clone Reserved"; break;
                        case 2934: eventLabels[i] = "Clone Reserved"; break;
                        case 2935: eventLabels[i] = "Clone Reserved"; break;
                        case 2936: eventLabels[i] = "Clone Reserved"; break;
                        case 2937: eventLabels[i] = "Clone Reserved"; break;
                        case 2938: eventLabels[i] = "Clone Reserved"; break;
                        case 2939: eventLabels[i] = "Clone Reserved"; break;
                        case 2940: eventLabels[i] = "Clone Reserved"; break;
                        case 2941: eventLabels[i] = "Clone Reserved"; break;
                        case 2942: eventLabels[i] = "Clone Reserved"; break;
                        case 2943: eventLabels[i] = "Clone Reserved"; break;
                        case 2944: eventLabels[i] = "Clone Reserved"; break;
                        case 2945: eventLabels[i] = "Clone Reserved"; break;
                        case 2946: eventLabels[i] = "Clone Reserved"; break;
                        case 2947: eventLabels[i] = "Clone Reserved"; break;
                        case 2948: eventLabels[i] = "Clone Reserved"; break;
                        case 2949: eventLabels[i] = "Clone Reserved"; break;
                        case 2950: eventLabels[i] = "Clone Reserved"; break;
                        case 2951: eventLabels[i] = "Clone Reserved"; break;
                        case 2952: eventLabels[i] = "Clone Reserved"; break;
                        case 2953: eventLabels[i] = "Clone Reserved"; break;
                        case 2954: eventLabels[i] = "Clone Reserved"; break;
                        case 2955: eventLabels[i] = "Clone Reserved"; break;
                        case 2956: eventLabels[i] = "Clone Reserved"; break;
                        case 2957: eventLabels[i] = "Clone Reserved"; break;
                        case 2958: eventLabels[i] = "Clone Reserved"; break;
                        case 2959: eventLabels[i] = "Clone Reserved"; break;
                        case 2960: eventLabels[i] = "Clone Reserved"; break;
                        case 2961: eventLabels[i] = "Clone Reserved"; break;
                        case 2962: eventLabels[i] = "Clone Reserved"; break;
                        case 2963: eventLabels[i] = "Clone Reserved"; break;
                        case 2964: eventLabels[i] = "Clone Reserved"; break;
                        case 2965: eventLabels[i] = "Clone Reserved"; break;
                        case 2966: eventLabels[i] = "Clone Reserved"; break;
                        case 2967: eventLabels[i] = "Clone Reserved"; break;
                        case 2968: eventLabels[i] = "Clone Reserved"; break;
                        case 2969: eventLabels[i] = "Clone Reserved"; break;
                        case 2970: eventLabels[i] = "Clone Reserved"; break;
                        case 2971: eventLabels[i] = "Clone Reserved"; break;
                        case 2972: eventLabels[i] = "Clone Reserved"; break;
                        case 2973: eventLabels[i] = "Clone Reserved"; break;
                        case 2974: eventLabels[i] = "Clone Reserved"; break;
                        case 2975: eventLabels[i] = "Clone Reserved"; break;
                        case 2976: eventLabels[i] = "Clone Reserved"; break;
                        case 2977: eventLabels[i] = "Clone Reserved"; break;
                        case 2978: eventLabels[i] = "Clone Reserved"; break;
                        case 2979: eventLabels[i] = "Clone Reserved"; break;
                        case 2980: eventLabels[i] = "Clone Reserved"; break;
                        case 2981: eventLabels[i] = "Clone Reserved"; break;
                        case 2982: eventLabels[i] = "Clone Reserved"; break;
                        case 2983: eventLabels[i] = "Clone Reserved"; break;
                        case 2984: eventLabels[i] = "Clone Reserved"; break;
                        case 2985: eventLabels[i] = "Clone Reserved"; break;
                        case 2986: eventLabels[i] = "Clone Reserved"; break;
                        case 2987: eventLabels[i] = "Clone Reserved"; break;
                        case 2988: eventLabels[i] = "Clone Reserved"; break;
                        case 2989: eventLabels[i] = "Clone Reserved"; break;
                        case 2990: eventLabels[i] = "Clone Reserved"; break;
                        case 2991: eventLabels[i] = "Clone Reserved"; break;
                        case 2992: eventLabels[i] = "Clone Reserved"; break;
                        case 2993: eventLabels[i] = "Clone Reserved"; break;
                        case 2994: eventLabels[i] = "Clone Reserved"; break;
                        case 2995: eventLabels[i] = "Clone Reserved"; break;
                        case 2996: eventLabels[i] = "Clone Reserved"; break;
                        case 2997: eventLabels[i] = "Clone Reserved"; break;
                        case 2998: eventLabels[i] = "Clone Reserved"; break;
                        case 2999: eventLabels[i] = "Clone Reserved"; break;
                        case 3000: eventLabels[i] = "Clone Reserved"; break;
                        case 3001: eventLabels[i] = "Clone Reserved"; break;
                        case 3002: eventLabels[i] = "Clone Reserved"; break;
                        case 3003: eventLabels[i] = "Clone Reserved"; break;
                        case 3004: eventLabels[i] = "Clone Reserved"; break;
                        case 3005: eventLabels[i] = "Clone Reserved"; break;
                        case 3006: eventLabels[i] = "Clone Reserved"; break;
                        case 3007: eventLabels[i] = "Clone Reserved"; break;
                        case 3008: eventLabels[i] = "Clone Reserved"; break;
                        case 3009: eventLabels[i] = "Clone Reserved"; break;
                        case 3010: eventLabels[i] = "Clone Reserved"; break;
                        case 3011: eventLabels[i] = "Clone Reserved"; break;
                        case 3012: eventLabels[i] = "Clone Reserved"; break;
                        case 3013: eventLabels[i] = "Clone Reserved"; break;
                        case 3014: eventLabels[i] = "Clone Reserved"; break;
                        case 3015: eventLabels[i] = "Clone Reserved"; break;
                        case 3016: eventLabels[i] = "Clone Reserved"; break;
                        case 3017: eventLabels[i] = "Clone Reserved"; break;
                        case 3018: eventLabels[i] = "Clone Reserved"; break;
                        case 3019: eventLabels[i] = "Clone Reserved"; break;
                        case 3020: eventLabels[i] = "Clone Reserved"; break;
                        case 3021: eventLabels[i] = "Clone Reserved"; break;
                        case 3022: eventLabels[i] = "Clone Reserved"; break;
                        case 3023: eventLabels[i] = "Clone Reserved"; break;
                        case 3024: eventLabels[i] = "Clone Reserved"; break;
                        case 3025: eventLabels[i] = "Clone Reserved"; break;
                        case 3026: eventLabels[i] = "Clone Reserved"; break;
                        case 3027: eventLabels[i] = "Clone Reserved"; break;
                        case 3028: eventLabels[i] = "Clone Reserved"; break;
                        case 3029: eventLabels[i] = "Clone Reserved"; break;
                        case 3030: eventLabels[i] = "Clone Reserved"; break;
                        case 3031: eventLabels[i] = "Clone Reserved"; break;
                        case 3032: eventLabels[i] = "Clone Reserved"; break;
                        case 3033: eventLabels[i] = "Clone Reserved"; break;
                        case 3034: eventLabels[i] = "Clone Reserved"; break;
                        case 3035: eventLabels[i] = "Clone Reserved"; break;
                        case 3036: eventLabels[i] = "Clone Reserved"; break;
                        case 3037: eventLabels[i] = "Clone Reserved"; break;
                        case 3038: eventLabels[i] = "Clone Reserved"; break;
                        case 3039: eventLabels[i] = "Clone Reserved"; break;
                        case 3040: eventLabels[i] = "Clone Reserved"; break;
                        case 3041: eventLabels[i] = "Clone Reserved"; break;
                        case 3042: eventLabels[i] = "Clone Reserved"; break;
                        case 3043: eventLabels[i] = "Clone Reserved"; break;
                        case 3044: eventLabels[i] = "Clone Reserved"; break;
                        case 3045: eventLabels[i] = "Clone Reserved"; break;
                        case 3046: eventLabels[i] = "Clone Reserved"; break;
                        case 3047: eventLabels[i] = "Clone Reserved"; break;
                        case 3048: eventLabels[i] = "Clone Reserved"; break;
                        case 3049: eventLabels[i] = "Clone Reserved"; break;
                        case 3050: eventLabels[i] = "Clone Reserved"; break;
                        case 3051: eventLabels[i] = "Clone Reserved"; break;
                        case 3052: eventLabels[i] = "Clone Reserved"; break;
                        case 3053: eventLabels[i] = "Clone Reserved"; break;
                        case 3054: eventLabels[i] = "Clone Reserved"; break;
                        case 3055: eventLabels[i] = "Clone Reserved"; break;
                        case 3056: eventLabels[i] = "Clone Reserved"; break;
                        case 3057: eventLabels[i] = "Clone Reserved"; break;
                        case 3058: eventLabels[i] = "Clone Reserved"; break;
                        case 3059: eventLabels[i] = "Clone Reserved"; break;
                        case 3060: eventLabels[i] = "Clone Reserved"; break;
                        case 3061: eventLabels[i] = "Clone Reserved"; break;
                        case 3062: eventLabels[i] = "Clone Reserved"; break;
                        case 3063: eventLabels[i] = "Clone Reserved"; break;
                        case 3064: eventLabels[i] = "Clone Reserved"; break;
                        case 3065: eventLabels[i] = "Clone Reserved"; break;
                        case 3066: eventLabels[i] = "Clone Reserved"; break;
                        case 3067: eventLabels[i] = "Clone Reserved"; break;
                        case 3068: eventLabels[i] = "Clone Reserved"; break;
                        case 3069: eventLabels[i] = "Clone Reserved"; break;
                        case 3070: eventLabels[i] = "Clone Reserved"; break;
                        case 3071: eventLabels[i] = "Clone Reserved"; break;
                        case 3072: eventLabels[i] = "Flower Star Fc Or Mushroom Chest"; break;
                        case 3073: eventLabels[i] = "Item Chest"; break;
                        case 3074: eventLabels[i] = "Coin Chest Multi Hit 1"; break;
                        case 3075: eventLabels[i] = "Heal Flash"; break;
                        case 3076: eventLabels[i] = "Exp Star Chest Background"; break;
                        case 3077: eventLabels[i] = "Ship Puzzle Mushroom"; break;
                        case 3078: eventLabels[i] = "Mimic Or Slot Chest"; break;
                        case 3079: eventLabels[i] = "Exp Star Levelup Screen"; break;
                        case 3080: eventLabels[i] = "Coin Chest Quick Hit"; break;
                        case 3081: eventLabels[i] = "You Missed"; break;
                        case 3082: eventLabels[i] = "Frog Coin Chest Multi Hit 1"; break;
                        case 3083: eventLabels[i] = "Freestanding Shuffled Frog Coin"; break;
                        case 3084: eventLabels[i] = "Frog Coin Chest Quick Hit"; break;
                        case 3085: eventLabels[i] = "Freestanding Shuffled Coin"; break;
                        case 3086: eventLabels[i] = "Juice Bar Card Upgrade"; break;
                        case 3087: eventLabels[i] = "Progressive Egg Upgrade"; break;
                        case 3088: eventLabels[i] = "Empty"; break;
                        case 3089: eventLabels[i] = "Grant Item From Chest"; break;
                        case 3090: eventLabels[i] = "Open Lands End If Gated By Star Pieces"; break;
                        case 3091: eventLabels[i] = "Multi Frog Coin Chest Single Hit"; break;
                        case 3092: eventLabels[i] = "Star Piece Grant"; break;
                        case 3093: eventLabels[i] = "Open Abyss If Star Piece Threshold Met"; break;
                        case 3094: eventLabels[i] = "Star Piece Chest Animation"; break;
                        case 3095: eventLabels[i] = "Empty"; break;
                        case 3096: eventLabels[i] = "Empty"; break;
                        case 3097: eventLabels[i] = "Juice Bar Card Npc Grant"; break;
                        case 3098: eventLabels[i] = "Progressive Egg Npc Grant"; break;
                        case 3099: eventLabels[i] = "Shuffle Fireworks Chest Grant"; break;
                        case 3100: eventLabels[i] = "Progressive Fireworks Chest Grant"; break;
                        case 3101: eventLabels[i] = "Star Piece Hunt End Game"; break;
                        case 3102: eventLabels[i] = "Exit Jumping Kids House"; break;
                        case 3103: eventLabels[i] = "Enter Mk Guest Room"; break;
                        case 3104: eventLabels[i] = "Exit Mk Guest Room"; break;
                        case 3105: eventLabels[i] = "Enter Mk Staircase"; break;
                        case 3106: eventLabels[i] = "Exit Mk Staircase"; break;
                        case 3107: eventLabels[i] = "Empty"; break;
                        case 3108: eventLabels[i] = "Empty"; break;
                        case 3109: eventLabels[i] = "Freestanding Beetlemania Grant"; break;
                        case 3110: eventLabels[i] = "Freestanding Juice Bar Card Grant"; break;
                        case 3111: eventLabels[i] = "Freestanding Progressive Egg Grant"; break;
                        case 3112: eventLabels[i] = "Freestanding Shuffle Fireworks Grant"; break;
                        case 3113: eventLabels[i] = "Freestanding Progressive Fireworks Grant"; break;
                        case 3114: eventLabels[i] = "Hill Progressive Egg"; break;
                        case 3115: eventLabels[i] = "Hill Progressive Card"; break;
                        case 3116: eventLabels[i] = "Change Music In Moleville Mines When Backtracking"; break;
                        case 3117: eventLabels[i] = "Empty"; break;
                        case 3118: eventLabels[i] = "Water State"; break;
                        case 3119: eventLabels[i] = "Goby Battle"; break;
                        case 3120: eventLabels[i] = "Empty"; break;
                        case 3121: eventLabels[i] = "Sewer Boss Fight"; break;
                        case 3122: eventLabels[i] = "Sewer Boss Room Trampoline"; break;
                        case 3123: eventLabels[i] = "Sewer Drain Water"; break;
                        case 3124: eventLabels[i] = "Mimic 1 Chest"; break;
                        case 3125: eventLabels[i] = "Sewer Pipe To Lands End"; break;
                        case 3126: eventLabels[i] = "Mimic 2 Chest"; break;
                        case 3127: eventLabels[i] = "Sewer Exit Trampoline"; break;
                        case 3128: eventLabels[i] = "Empty"; break;
                        case 3129: eventLabels[i] = "Empty"; break;
                        case 3130: eventLabels[i] = "Sewer Tutorial Note"; break;
                        case 3131: eventLabels[i] = "Moleville Toad In Mines"; break;
                        case 3132: eventLabels[i] = "Moleville Miners Song"; break;
                        case 3133: eventLabels[i] = "Pa Mole In Mines"; break;
                        case 3134: eventLabels[i] = "Resummon Enemies In Sewer"; break;
                        case 3135: eventLabels[i] = "Sewers Generic Loader"; break;
                        case 3136: eventLabels[i] = "Sewers Overworld Pipe"; break;
                        case 3137: eventLabels[i] = "Sewers 1St Water Room Pipe To Tutorial Room"; break;
                        case 3138: eventLabels[i] = "Sewers 1St Water Room Pipe To 3Rd Water Room"; break;
                        case 3139: eventLabels[i] = "Sewers 4 Rat Room Pipe To 1St Water Room"; break;
                        case 3140: eventLabels[i] = "1St Water Toom Pipe To Sewers 4 Rat Room"; break;
                        case 3141: eventLabels[i] = "3Rd Water Room Pipe To 1St Water Room"; break;
                        case 3142: eventLabels[i] = "Pipe To Boss"; break;
                        case 3143: eventLabels[i] = "Rose Way Main Room Platforms"; break;
                        case 3144: eventLabels[i] = "Rose Way Main Room Platforms Background"; break;
                        case 3145: eventLabels[i] = "Sewers Flippable Chest"; break;
                        case 3146: eventLabels[i] = "Freestanding Big Coin"; break;
                        case 3147: eventLabels[i] = "Rose Way Tutorial"; break;
                        case 3148: eventLabels[i] = "Rose Way Main Room Loader"; break;
                        case 3149: eventLabels[i] = "Empty"; break;
                        case 3150: eventLabels[i] = "Rose Way Swing Chest"; break;
                        case 3151: eventLabels[i] = "Rose Way Tossed Shyguys"; break;
                        case 3152: eventLabels[i] = "Rose Way Five Chests"; break;
                        case 3153: eventLabels[i] = "Old Chest Granter"; break;
                        case 3154: eventLabels[i] = "Resummon Rose Way Npcs"; break;
                        case 3155: eventLabels[i] = "Empty"; break;
                        case 3156: eventLabels[i] = "Minecart Room Loader"; break;
                        case 3157: eventLabels[i] = "Minecart Room Loader Background"; break;
                        case 3158: eventLabels[i] = "Item Behind Ship Upper Stairs Tile"; break;
                        case 3159: eventLabels[i] = "Pa Mole After Bambino Bomb"; break;
                        case 3160: eventLabels[i] = "Mines Long Track Room Lower Backward Exit"; break;
                        case 3161: eventLabels[i] = "Mines Check If Shyguy Moved"; break;
                        case 3162: eventLabels[i] = "Mines Area 2 Lower Backward Exit If Mines Cleared"; break;
                        case 3163: eventLabels[i] = "Sewers Tutorial Room Exit To Exterior"; break;
                        case 3164: eventLabels[i] = "Sewers Tutorial Room Pipe To First Water Room"; break;
                        case 3165: eventLabels[i] = "Active Minecart Mario Collision Check"; break;
                        case 3166: eventLabels[i] = "Active Minecart Mario Collision Check Properties"; break;
                        case 3167: eventLabels[i] = "Mines Final Save Room Loader"; break;
                        case 3168: eventLabels[i] = "Sewers 3Rd Water Room Pipe To Water Switch Room"; break;
                        case 3169: eventLabels[i] = "Sewers Stair Room Pipe To Third Water Room"; break;
                        case 3170: eventLabels[i] = "Sewers Four Rat Room Pipe To Stair Room"; break;
                        case 3171: eventLabels[i] = "Sewers Stair Room Pipe To Four Rat Room"; break;
                        case 3172: eventLabels[i] = "Sewers 3Rd Water Room Pipe To Stair Room"; break;
                        case 3173: eventLabels[i] = "Sewers Four Rat Room Pipe To Rat Line Room"; break;
                        case 3174: eventLabels[i] = "Sewers 3Rd Water Room Pipe To Water Switch Room"; break;
                        case 3175: eventLabels[i] = "Sewers Water Switch Room Pipe To 3Rd Water Room"; break;
                        case 3176: eventLabels[i] = "Sewers Rat Line Room Pipe To 3Rd Water Room"; break;
                        case 3177: eventLabels[i] = "Sewers Stair Room Pipe To Four Rat Room"; break;
                        case 3178: eventLabels[i] = "Sewers 3Rd Water Toom Pipe To Rat Line Room"; break;
                        case 3179: eventLabels[i] = "Sewers Four Rat Room Pipe To Stair Room"; break;
                        case 3180: eventLabels[i] = "Sewers Rat Line Room Pipe To Four Rat Room"; break;
                        case 3181: eventLabels[i] = "Sewers Water Switch Room Pipe To 3Rd Water Room"; break;
                        case 3182: eventLabels[i] = "Minecart Paid Lobby Room Loader"; break;
                        case 3183: eventLabels[i] = "Minecart Paid Lobby Trampoline To Exterior"; break;
                        case 3184: eventLabels[i] = "Mines First Room Loader"; break;
                        case 3185: eventLabels[i] = "Pa Mole In Deep Mines"; break;
                        case 3186: eventLabels[i] = "Moles In First Mines Room"; break;
                        case 3187: eventLabels[i] = "Minecart Tutorial"; break;
                        case 3188: eventLabels[i] = "Mount Minecart"; break;
                        case 3189: eventLabels[i] = "Fall To Minecart Room From Lobby"; break;
                        case 3190: eventLabels[i] = "Activate Post Mines Boss First Minecart Session Continued"; break;
                        case 3191: eventLabels[i] = "Activate Post Mines Boss First Minecart Session"; break;
                        case 3192: eventLabels[i] = "Mines Left Henchman"; break;
                        case 3193: eventLabels[i] = "Mines Right Henchman"; break;
                        case 3194: eventLabels[i] = "Mines Center Henchman"; break;
                        case 3195: eventLabels[i] = "Parked Minecart Mario Collision Check"; break;
                        case 3196: eventLabels[i] = "Parked Minecart Mario Collision Check Properties"; break;
                        case 3197: eventLabels[i] = "Mines Final Save Room Exit To Boss Room"; break;
                        case 3198: eventLabels[i] = "Shyguy Cart Pushes Mario Into Smaller Room"; break;
                        case 3199: eventLabels[i] = "Shyguy Cart Prize Grant"; break;
                        case 3200: eventLabels[i] = "Mines Trampoline"; break;
                        case 3201: eventLabels[i] = "Mines 1St Boss Fight"; break;
                        case 3202: eventLabels[i] = "Minecart Room Exit To Boss Room"; break;
                        case 3203: eventLabels[i] = "Empty"; break;
                        case 3204: eventLabels[i] = "Empty"; break;
                        case 3205: eventLabels[i] = "Empty"; break;
                        case 3206: eventLabels[i] = "Sea Pipe To Ship"; break;
                        case 3207: eventLabels[i] = "Ship Exit Trampoline"; break;
                        case 3208: eventLabels[i] = "Water Whirlpool"; break;
                        case 3209: eventLabels[i] = "Sleeping Dry Bones"; break;
                        case 3210: eventLabels[i] = "Ship Trampoline Puzzle Block"; break;
                        case 3211: eventLabels[i] = "Ship 3D Maze Room Loader"; break;
                        case 3212: eventLabels[i] = "Ship 3D Maze Forfeit Listener"; break;
                        case 3213: eventLabels[i] = "Ship Post 1St Boss Trampoline Back Up"; break;
                        case 3214: eventLabels[i] = "Ship 1St Boss"; break;
                        case 3215: eventLabels[i] = "Ship Coin Snake Puzzle Header Coin"; break;
                        case 3216: eventLabels[i] = "Ship Coin Snake Puzzle Tail Coin"; break;
                        case 3217: eventLabels[i] = "Ship Cannonball Puzzle Cannonball"; break;
                        case 3218: eventLabels[i] = "Ship Submit Password"; break;
                        case 3219: eventLabels[i] = "Ship Barrel Puzzle Button"; break;
                        case 3220: eventLabels[i] = "Ship Barrel Puzzle Barrel Movement"; break;
                        case 3221: eventLabels[i] = "Ship 3D Maze Hit Button"; break;
                        case 3222: eventLabels[i] = "Ship Troopa Puzzle Loader"; break;
                        case 3223: eventLabels[i] = "Ship Troopa Puzzle"; break;
                        case 3224: eventLabels[i] = "Ship Password Room Loader"; break;
                        case 3225: eventLabels[i] = "Ship Password Box Dialog"; break;
                        case 3226: eventLabels[i] = "Ship Generic Loader"; break;
                        case 3227: eventLabels[i] = "Ship Clone Room Loader"; break;
                        case 3228: eventLabels[i] = "Ship Clone Control"; break;
                        case 3229: eventLabels[i] = "Ship Clone Transform"; break;
                        case 3230: eventLabels[i] = "Cancel Star In Sea"; break;
                        case 3231: eventLabels[i] = "Ship Cannonball Puzzle Initiator Block"; break;
                        case 3232: eventLabels[i] = "Ship Password Box 1"; break;
                        case 3233: eventLabels[i] = "Ship Password Box 2"; break;
                        case 3234: eventLabels[i] = "Ship Password Box 3"; break;
                        case 3235: eventLabels[i] = "Ship Password Box 4"; break;
                        case 3236: eventLabels[i] = "Ship Password Box 5"; break;
                        case 3237: eventLabels[i] = "Ship Password Box 6"; break;
                        case 3238: eventLabels[i] = "Freestanding Frog Coin"; break;
                        case 3239: eventLabels[i] = "Ship Open Door To Room Behind Box Wall"; break;
                        case 3240: eventLabels[i] = "Ship Troopa Puzzle Hint"; break;
                        case 3241: eventLabels[i] = "Ship Trampoline Puzzle Hint"; break;
                        case 3242: eventLabels[i] = "Ship 3D Maze Hint"; break;
                        case 3243: eventLabels[i] = "Ship Coin Snake Hint"; break;
                        case 3244: eventLabels[i] = "Ship Cannonball Puzzle Hint"; break;
                        case 3245: eventLabels[i] = "Ship Barrel Puzzle Hint"; break;
                        case 3246: eventLabels[i] = "Dry Bones Fight"; break;
                        case 3247: eventLabels[i] = "Item Behind Ship Upper Stairs Granter"; break;
                        case 3248: eventLabels[i] = "Ship Entrance Open Right Door"; break;
                        case 3249: eventLabels[i] = "Ship Entrance Open Left Door"; break;
                        case 3250: eventLabels[i] = "Ship 1St Greaper Room Open Upper Door"; break;
                        case 3251: eventLabels[i] = "Ship 2Nd Greaper Room Open Upper Door"; break;
                        case 3252: eventLabels[i] = "Ship Puzzle Hub Room Open Upper Exit Door"; break;
                        case 3253: eventLabels[i] = "Ship Puzzle Hub Room Open Troopa Puzzle Door"; break;
                        case 3254: eventLabels[i] = "Ship Puzzle Hub Room Open Trampoline Puzzle Door"; break;
                        case 3255: eventLabels[i] = "Ship Puzzle Hub Room Open 3D Maze Door"; break;
                        case 3256: eventLabels[i] = "Ship Puzzle Hub Room Open Lower Exit Door"; break;
                        case 3257: eventLabels[i] = "Ship Puzzle Hub Room Open Cannonball Puzzle Door"; break;
                        case 3258: eventLabels[i] = "Ship Puzzle Hub Room Open Coin Snake Puzzle Door"; break;
                        case 3259: eventLabels[i] = "Ship Shop Room Open Upper Door"; break;
                        case 3260: eventLabels[i] = "Ship Shop Room Open Lower Door"; break;
                        case 3261: eventLabels[i] = "Ship Barrel Puzzle Room Open Exit Door"; break;
                        case 3262: eventLabels[i] = "Ship Password Room Open Door To Boss"; break;
                        case 3263: eventLabels[i] = "Ship Lower First Trampoline Room Open Exit Door"; break;
                        case 3264: eventLabels[i] = "Ship Lower First Drybones Room Open Upper Door"; break;
                        case 3265: eventLabels[i] = "Ship Lower First Drybones Room Open Lower Door"; break;
                        case 3266: eventLabels[i] = "Ship Lower Rat Stairway Open Upper Door"; break;
                        case 3267: eventLabels[i] = "Ship Lower Rat Stairway Open Lower Door"; break;
                        case 3268: eventLabels[i] = "Ship Outer Clone Room Open Left Door"; break;
                        case 3269: eventLabels[i] = "Ship Outer Clone Room Open Right Door"; break;
                        case 3270: eventLabels[i] = "Ship Room With Box Wall Open Right Door"; break;
                        case 3271: eventLabels[i] = "Ship Final Save Room Open Exit Door"; break;
                        case 3272: eventLabels[i] = "Ship 1St Water Room Open Upper Door"; break;
                        case 3273: eventLabels[i] = "Ship 1St Water Room Open Underwater Door"; break;
                        case 3274: eventLabels[i] = "Ship Upper Whirlpool Room Open Underwater Door"; break;
                        case 3275: eventLabels[i] = "Ship Zeostar Stairway Open Underwater Door"; break;
                        case 3276: eventLabels[i] = "Ship Big Water Room Open Upper Door"; break;
                        case 3277: eventLabels[i] = "Ship Big Water Room Open Hidden Door"; break;
                        case 3278: eventLabels[i] = "Ship Open Door To Final Boss Room"; break;
                        case 3279: eventLabels[i] = "Ship Open Door In Final Boss Room"; break;
                        case 3280: eventLabels[i] = "Ship Lower Henchman Room Loader"; break;
                        case 3281: eventLabels[i] = "Ship Upper Henchman Room Loader"; break;
                        case 3282: eventLabels[i] = "Ship Boss Room Loader"; break;
                        case 3283: eventLabels[i] = "Empty"; break;
                        case 3284: eventLabels[i] = "Ship Save Rooms Loader"; break;
                        case 3285: eventLabels[i] = "Sea Single Chest Room Loader"; break;
                        case 3286: eventLabels[i] = "Ship Interact With Boss After Winning"; break;
                        case 3287: eventLabels[i] = "Ship Upper Henchman Room Talk To Guard After Winning"; break;
                        case 3288: eventLabels[i] = "Ship Spawn Prize In Troopa Puzzle Room"; break;
                        case 3289: eventLabels[i] = "Ship Collect Trampoline Prize"; break;
                        case 3290: eventLabels[i] = "Ship Collect 3D Maze Prize"; break;
                        case 3291: eventLabels[i] = "Ship Collect Cannonball Prize"; break;
                        case 3292: eventLabels[i] = "Lower Ship Generic Loader"; break;
                        case 3293: eventLabels[i] = "Ship Bullet Collision"; break;
                        case 3294: eventLabels[i] = "Ship Bullet Collision Background"; break;
                        case 3295: eventLabels[i] = "Ship Collect Barrel Prize"; break;
                        case 3296: eventLabels[i] = "Sea Entrance Trampoline"; break;
                        case 3297: eventLabels[i] = "Sea Shop"; break;
                        case 3298: eventLabels[i] = "Sea Reverse Whirlpool To Lone Chest"; break;
                        case 3299: eventLabels[i] = "Outer Sea Whirlpool"; break;
                        case 3300: eventLabels[i] = "Ship Entrance Note"; break;
                        case 3301: eventLabels[i] = "Ship Boss Room Inner Left Henchman"; break;
                        case 3302: eventLabels[i] = "Ship Boss Room Inner Right Henchman"; break;
                        case 3303: eventLabels[i] = "Ship 1St Save Room Hint Note"; break;
                        case 3304: eventLabels[i] = "Ship 1St Greaper Room Hint Note"; break;
                        case 3305: eventLabels[i] = "Ship 2Nd Greaper Room Hint Note"; break;
                        case 3306: eventLabels[i] = "Ship Lower Henchman Room Loader Continued"; break;
                        case 3307: eventLabels[i] = "Ship Password Tutorial"; break;
                        case 3308: eventLabels[i] = "Ship Boss Room Drink"; break;
                        case 3309: eventLabels[i] = "Ship Spawn Hidden Chest"; break;
                        case 3310: eventLabels[i] = "Ship Hidden Chest"; break;
                        case 3311: eventLabels[i] = "Ship Shop"; break;
                        case 3312: eventLabels[i] = "Sewers 1St Water Room Exit To Rat Line Room"; break;
                        case 3313: eventLabels[i] = "Sewers Rat Line Room Exit To 1St Water Room"; break;
                        case 3314: eventLabels[i] = "Sewers Rat Line Room Exit To 3Rd Water Room"; break;
                        case 3315: eventLabels[i] = "Sewers 3Rd Water Room Exit To Rat Line Room"; break;
                        case 3316: eventLabels[i] = "Ship Boss Room Leftmost Henchman"; break;
                        case 3317: eventLabels[i] = "Mines Final Chest"; break;
                        case 3318: eventLabels[i] = "Set Oerlikon Pack"; break;
                        case 3319: eventLabels[i] = "Set Vomer Pack"; break;
                        case 3320: eventLabels[i] = "Empty"; break;
                        case 3321: eventLabels[i] = "Volcano Enter 1St Room"; break;
                        case 3322: eventLabels[i] = "Volcano 1St Room Trampoline"; break;
                        case 3323: eventLabels[i] = "Volcano 1St Room Loader"; break;
                        case 3324: eventLabels[i] = "Volcano 3 Lift Room Donut Lift"; break;
                        case 3325: eventLabels[i] = "Stumpet Room Loader"; break;
                        case 3326: eventLabels[i] = "Stumpet Eruption"; break;
                        case 3327: eventLabels[i] = "Stumpet Fight"; break;
                        case 3328: eventLabels[i] = "Volcano Generic Loader 1"; break;
                        case 3329: eventLabels[i] = "Jumping Fireballs"; break;
                        case 3330: eventLabels[i] = "Volcano 1St Boss Room Loader"; break;
                        case 3331: eventLabels[i] = "Volcano 1St Boss Fight"; break;
                        case 3332: eventLabels[i] = "Volcano 1St Boss Path Room Loader"; break;
                        case 3333: eventLabels[i] = "Volcano Generic Loader 2"; break;
                        case 3334: eventLabels[i] = "Volcano Enter Shop Area"; break;
                        case 3335: eventLabels[i] = "Corkpedite Collision"; break;
                        case 3336: eventLabels[i] = "Corkpedite Room Loader"; break;
                        case 3337: eventLabels[i] = "Corkpedite Animation"; break;
                        case 3338: eventLabels[i] = "Volcano Trampoline To 2Nd Boss"; break;
                        case 3339: eventLabels[i] = "Volcano 2Nd Boss Path Room Loader"; break;
                        case 3340: eventLabels[i] = "Volcano 3Rd Boss Path Room Loader"; break;
                        case 3341: eventLabels[i] = "Volcano Small Boss Path Room Loader"; break;
                        case 3342: eventLabels[i] = "Volcano 5Th Boss Path Room Loader"; break;
                        case 3343: eventLabels[i] = "Volcano Final Boss Path Room Loader"; break;
                        case 3344: eventLabels[i] = "Volcano Final Trampoline Room Loader"; break;
                        case 3345: eventLabels[i] = "Volcano Chase Seqeunce"; break;
                        case 3346: eventLabels[i] = "Volcano 1St Boss Screen Tint"; break;
                        case 3347: eventLabels[i] = "Empty"; break;
                        case 3348: eventLabels[i] = "Keep Door Reward Chest"; break;
                        case 3349: eventLabels[i] = "Keep 6 Door Lobby Exit To Prev Room"; break;
                        case 3350: eventLabels[i] = "Keep All Door Paths Exit To Reward Room"; break;
                        case 3351: eventLabels[i] = "Empty"; break;
                        case 3352: eventLabels[i] = "Dr Topper Quiz"; break;
                        case 3353: eventLabels[i] = "Keep Enter Ball Solitaire Room"; break;
                        case 3354: eventLabels[i] = "Keep Barrel Count Loader"; break;
                        case 3355: eventLabels[i] = "Keep Barrel Count Loader Contd"; break;
                        case 3356: eventLabels[i] = "Keep Respawn In Lobby Upon Failure"; break;
                        case 3357: eventLabels[i] = "Keep Button Game Loader"; break;
                        case 3358: eventLabels[i] = "Keep Ball Solitaire Loader"; break;
                        case 3359: eventLabels[i] = "Keep Initiate Coin Game"; break;
                        case 3360: eventLabels[i] = "Keep Coin Game Chest"; break;
                        case 3361: eventLabels[i] = "Keep Exit Completed Doors To Boss Antechamber"; break;
                        case 3362: eventLabels[i] = "Keep Button Game Press Button"; break;
                        case 3363: eventLabels[i] = "Keep Ball Solitaire Kick Ball"; break;
                        case 3364: eventLabels[i] = "Keep Logic Game Loader"; break;
                        case 3365: eventLabels[i] = "Keep Logic Game Finalize Answer"; break;
                        case 3366: eventLabels[i] = "Keep Logic Game Boo"; break;
                        case 3367: eventLabels[i] = "Keep Logic Game Goo"; break;
                        case 3368: eventLabels[i] = "Keep Logic Game Bones"; break;
                        case 3369: eventLabels[i] = "Keep Logic Game Kipp"; break;
                        case 3370: eventLabels[i] = "Volcano Bridge Donut Lift"; break;
                        case 3371: eventLabels[i] = "Volcano Bridge Donut Lift No Falling"; break;
                        case 3372: eventLabels[i] = "Keep Get Crushed By Huge Thwomp"; break;
                        case 3373: eventLabels[i] = "Keep Thwomp Room Loader"; break;
                        case 3374: eventLabels[i] = "Keep Thwomp Room Background"; break;
                        case 3375: eventLabels[i] = "Keep Set Door Order"; break;
                        case 3376: eventLabels[i] = "Keep 6 Door Lobby Loader"; break;
                        case 3377: eventLabels[i] = "Keep Open Door 1"; break;
                        case 3378: eventLabels[i] = "Keep Open Door 2"; break;
                        case 3379: eventLabels[i] = "Keep Open Door 3"; break;
                        case 3380: eventLabels[i] = "Keep Open Door 4"; break;
                        case 3381: eventLabels[i] = "Keep Open Door 5"; break;
                        case 3382: eventLabels[i] = "Keep Open Door 6"; break;
                        case 3383: eventLabels[i] = "Ship Trampoline Prize Packet Grant"; break;
                        case 3384: eventLabels[i] = "Ship Troopa Prize Packet Grant"; break;
                        case 3385: eventLabels[i] = "Ship Upper Stairway Item Packet Grant"; break;
                        case 3386: eventLabels[i] = "Ship 3D Maze Spawn Prize"; break;
                        case 3387: eventLabels[i] = "Ship Cannonball Puzzle Spawn Prize"; break;
                        case 3388: eventLabels[i] = "Ship Boss Room Periscope"; break;
                        case 3389: eventLabels[i] = "Ship Barrel Puzzle Spawn Prize"; break;
                        case 3390: eventLabels[i] = "Keep Lava Patform Room Chest Camera"; break;
                        case 3391: eventLabels[i] = "Volcano 1St Save Room Lower Chest"; break;
                        case 3392: eventLabels[i] = "Volcano 1St Save Room Upper Chest"; break;
                        case 3393: eventLabels[i] = "Super Jump Compare For 1St Prize"; break;
                        case 3394: eventLabels[i] = "Super Jump Compare For 2Nd Prize"; break;
                        case 3395: eventLabels[i] = "Midas Cave Beetlemania Granter"; break;
                        case 3396: eventLabels[i] = "Midas Cave Progressive Card Granter"; break;
                        case 3397: eventLabels[i] = "Midas Cave Progressive Egg Granter"; break;
                        case 3398: eventLabels[i] = "Midas Cave Single Firework Granter"; break;
                        case 3399: eventLabels[i] = "Midas Cave Progressive Firework Granter"; break;
                        case 3400: eventLabels[i] = "Restart Music After Star Piece Sequence"; break;
                        case 3401: eventLabels[i] = "Coin Chest Multi Hit 2"; break;
                        case 3402: eventLabels[i] = "Coin Chest Multi Hit 3"; break;
                        case 3403: eventLabels[i] = "Coin Chest Multi Hit 4"; break;
                        case 3404: eventLabels[i] = "Coin Chest Multi Hit 5"; break;
                        case 3405: eventLabels[i] = "Coin Chest Multi Hit 6"; break;
                        case 3406: eventLabels[i] = "Frog Coin Chest Multi Hit 2"; break;
                        case 3407: eventLabels[i] = "Frog Coin Chest Multi Hit 3"; break;
                        case 3408: eventLabels[i] = "Frog Coin Chest Multi Hit 4"; break;
                        case 3409: eventLabels[i] = "Frog Coin Chest Multi Hit 5"; break;
                        case 3410: eventLabels[i] = "Frog Coin Chest Multi Hit 6"; break;
                        case 3411: eventLabels[i] = "Ship Password Correctness Check"; break;
                        case 3412: eventLabels[i] = "Empty"; break;
                        case 3413: eventLabels[i] = "Mines Shyguy Collide With Boxes"; break;
                        case 3414: eventLabels[i] = "Rose Way Main Room 2Nd Freestanding Item"; break;
                        case 3415: eventLabels[i] = "Tower Stacked Chests On Top Floor"; break;
                        case 3416: eventLabels[i] = "Empty"; break;
                        case 3417: eventLabels[i] = "Empty"; break;
                        case 3418: eventLabels[i] = "Empty"; break;
                        case 3419: eventLabels[i] = "Empty"; break;
                        case 3420: eventLabels[i] = "Empty"; break;
                        case 3421: eventLabels[i] = "Empty"; break;
                        case 3422: eventLabels[i] = "Empty"; break;
                        case 3423: eventLabels[i] = "Empty"; break;
                        case 3424: eventLabels[i] = "Empty"; break;
                        case 3425: eventLabels[i] = "Empty"; break;
                        case 3426: eventLabels[i] = "Empty"; break;
                        case 3427: eventLabels[i] = "Empty"; break;
                        case 3428: eventLabels[i] = "Empty"; break;
                        case 3429: eventLabels[i] = "Empty"; break;
                        case 3430: eventLabels[i] = "Empty"; break;
                        case 3431: eventLabels[i] = "Empty"; break;
                        case 3432: eventLabels[i] = "Empty"; break;
                        case 3433: eventLabels[i] = "Empty"; break;
                        case 3434: eventLabels[i] = "Empty"; break;
                        case 3435: eventLabels[i] = "Empty"; break;
                        case 3436: eventLabels[i] = "Empty"; break;
                        case 3437: eventLabels[i] = "Empty"; break;
                        case 3438: eventLabels[i] = "Empty"; break;
                        case 3439: eventLabels[i] = "Empty"; break;
                        case 3440: eventLabels[i] = "Empty"; break;
                        case 3441: eventLabels[i] = "Empty"; break;
                        case 3442: eventLabels[i] = "Empty"; break;
                        case 3443: eventLabels[i] = "Empty"; break;
                        case 3444: eventLabels[i] = "Empty"; break;
                        case 3445: eventLabels[i] = "Empty"; break;
                        case 3446: eventLabels[i] = "Empty"; break;
                        case 3447: eventLabels[i] = "Empty"; break;
                        case 3448: eventLabels[i] = "Empty"; break;
                        case 3449: eventLabels[i] = "Empty"; break;
                        case 3450: eventLabels[i] = "Empty"; break;
                        case 3451: eventLabels[i] = "Empty"; break;
                        case 3452: eventLabels[i] = "Empty"; break;
                        case 3453: eventLabels[i] = "Empty"; break;
                        case 3454: eventLabels[i] = "Empty"; break;
                        case 3455: eventLabels[i] = "Empty"; break;
                        case 3456: eventLabels[i] = "Empty"; break;
                        case 3457: eventLabels[i] = "Empty"; break;
                        case 3458: eventLabels[i] = "Empty"; break;
                        case 3459: eventLabels[i] = "Empty"; break;
                        case 3460: eventLabels[i] = "Empty"; break;
                        case 3461: eventLabels[i] = "Empty"; break;
                        case 3462: eventLabels[i] = "Empty"; break;
                        case 3463: eventLabels[i] = "Empty"; break;
                        case 3464: eventLabels[i] = "Empty"; break;
                        case 3465: eventLabels[i] = "Empty"; break;
                        case 3466: eventLabels[i] = "Empty"; break;
                        case 3467: eventLabels[i] = "Empty"; break;
                        case 3468: eventLabels[i] = "Empty"; break;
                        case 3469: eventLabels[i] = "Empty"; break;
                        case 3470: eventLabels[i] = "Empty"; break;
                        case 3471: eventLabels[i] = "Empty"; break;
                        case 3472: eventLabels[i] = "Empty"; break;
                        case 3473: eventLabels[i] = "Empty"; break;
                        case 3474: eventLabels[i] = "Empty"; break;
                        case 3475: eventLabels[i] = "Empty"; break;
                        case 3476: eventLabels[i] = "Empty"; break;
                        case 3477: eventLabels[i] = "Kingdom Hallway Chest"; break;
                        case 3478: eventLabels[i] = "Midas River Trampoline"; break;
                        case 3479: eventLabels[i] = "Midas River Score Submission"; break;
                        case 3480: eventLabels[i] = "Midas River Waterfall Loader"; break;
                        case 3481: eventLabels[i] = "Midas River Tunnel Warp Check"; break;
                        case 3482: eventLabels[i] = "Midas River Top Tunnel Loader"; break;
                        case 3483: eventLabels[i] = "Midas River Mid Left Or Mid Right Loader"; break;
                        case 3484: eventLabels[i] = "Midas River Bottom Left Loader"; break;
                        case 3485: eventLabels[i] = "Midas River Bottom Right Loader"; break;
                        case 3486: eventLabels[i] = "Midas River Base Area Loader"; break;
                        case 3487: eventLabels[i] = "Midas River Frog Coin"; break;
                        case 3488: eventLabels[i] = "Midas River Coin"; break;
                        case 3489: eventLabels[i] = "Midas River Waterfall Listen For Button Inputs"; break;
                        case 3490: eventLabels[i] = "Midas Small Mario Coord Calc"; break;
                        case 3491: eventLabels[i] = "Midas River Top Tunnel Animation And Exit"; break;
                        case 3492: eventLabels[i] = "Midas River Mid Left Tunnel Animation And Exit"; break;
                        case 3493: eventLabels[i] = "Midas River Mid Right Tunnel Animation And Exit"; break;
                        case 3494: eventLabels[i] = "Midas River Bottom Left Tunnel Animation And Exit"; break;
                        case 3495: eventLabels[i] = "Midas River Bottom Right Tunnel Animation And Exit"; break;
                        case 3496: eventLabels[i] = "Midas River Mid Right Tunnel Animation And Exit Background"; break;
                        case 3497: eventLabels[i] = "Midas River Bottom Left Tunnel Item Granter"; break;
                        case 3498: eventLabels[i] = "Midas River Bottom Right Tunnel Background"; break;
                        case 3499: eventLabels[i] = "Booster Hill 1St Pass Loader"; break;
                        case 3500: eventLabels[i] = "Booster Hill 1St Pass Snifit Jumps"; break;
                        case 3501: eventLabels[i] = "Booster Hill Barrel Interaction"; break;
                        case 3502: eventLabels[i] = "Booster Hill End"; break;
                        case 3503: eventLabels[i] = "Booster Hill Barrel Summoner"; break;
                        case 3504: eventLabels[i] = "Booster Hill Henchman Interaction"; break;
                        case 3505: eventLabels[i] = "Booster Hill Unknown"; break;
                        case 3506: eventLabels[i] = "Booster Hill Get Flower"; break;
                        case 3507: eventLabels[i] = "Booster Hill 2Nd Pass Loader"; break;
                        case 3508: eventLabels[i] = "Booster Hill Return"; break;
                        case 3509: eventLabels[i] = "Empty"; break;
                        case 3510: eventLabels[i] = "Booster Hill Exit To World Map"; break;
                        case 3511: eventLabels[i] = "Booster Hill 2Nd Pass Background"; break;
                        case 3512: eventLabels[i] = "Booster Hill Flower Pickup"; break;
                        case 3513: eventLabels[i] = "Midas River Bottom Right Tunnel Item Granter"; break;
                        case 3514: eventLabels[i] = "Nimbus Castle Egg Room Exit To Previous Room"; break;
                        case 3515: eventLabels[i] = "Nimbus Castle Egg Room Exit To Next Room"; break;
                        case 3516: eventLabels[i] = "Chest Differentiator Npc 3 Or Other"; break;
                        case 3517: eventLabels[i] = "Chest Differentiator Npc 1 2 3 Or Other"; break;
                        case 3518: eventLabels[i] = "Chest Differentiator Npc 2 3 4 5 6 Or Other"; break;
                        case 3519: eventLabels[i] = "Chest Differentiator Npc 4 Or Other"; break;
                        case 3520: eventLabels[i] = "Chest Differentiator Npc 12 13 Or Other Camera A"; break;
                        case 3521: eventLabels[i] = "Chest Differentiator Npc 12 13 Or Other Camera B"; break;
                        case 3522: eventLabels[i] = "Chest Differentiator Npc 9 Or Other Camera A"; break;
                        case 3523: eventLabels[i] = "Empty"; break;
                        case 3524: eventLabels[i] = "Empty"; break;
                        case 3525: eventLabels[i] = "Empty"; break;
                        case 3526: eventLabels[i] = "Empty"; break;
                        case 3527: eventLabels[i] = "Empty"; break;
                        case 3528: eventLabels[i] = "Empty"; break;
                        case 3529: eventLabels[i] = "Empty"; break;
                        case 3530: eventLabels[i] = "Empty"; break;
                        case 3531: eventLabels[i] = "Empty"; break;
                        case 3532: eventLabels[i] = "Empty"; break;
                        case 3533: eventLabels[i] = "Empty"; break;
                        case 3534: eventLabels[i] = "Empty"; break;
                        case 3535: eventLabels[i] = "Empty"; break;
                        case 3536: eventLabels[i] = "Empty"; break;
                        case 3537: eventLabels[i] = "Empty"; break;
                        case 3538: eventLabels[i] = "Empty"; break;
                        case 3539: eventLabels[i] = "Empty"; break;
                        case 3540: eventLabels[i] = "Empty"; break;
                        case 3541: eventLabels[i] = "Empty"; break;
                        case 3542: eventLabels[i] = "Empty"; break;
                        case 3543: eventLabels[i] = "Empty"; break;
                        case 3544: eventLabels[i] = "Empty"; break;
                        case 3545: eventLabels[i] = "Empty"; break;
                        case 3546: eventLabels[i] = "Empty"; break;
                        case 3547: eventLabels[i] = "Empty"; break;
                        case 3548: eventLabels[i] = "Empty"; break;
                        case 3549: eventLabels[i] = "Empty"; break;
                        case 3550: eventLabels[i] = "Empty"; break;
                        case 3551: eventLabels[i] = "Empty"; break;
                        case 3552: eventLabels[i] = "Empty"; break;
                        case 3553: eventLabels[i] = "Empty"; break;
                        case 3554: eventLabels[i] = "Empty"; break;
                        case 3555: eventLabels[i] = "Empty"; break;
                        case 3556: eventLabels[i] = "Empty"; break;
                        case 3557: eventLabels[i] = "Empty"; break;
                        case 3558: eventLabels[i] = "Empty"; break;
                        case 3559: eventLabels[i] = "Empty"; break;
                        case 3560: eventLabels[i] = "Empty"; break;
                        case 3561: eventLabels[i] = "Empty"; break;
                        case 3562: eventLabels[i] = "Empty"; break;
                        case 3563: eventLabels[i] = "Empty"; break;
                        case 3564: eventLabels[i] = "Empty"; break;
                        case 3565: eventLabels[i] = "Empty"; break;
                        case 3566: eventLabels[i] = "Empty"; break;
                        case 3567: eventLabels[i] = "Empty"; break;
                        case 3568: eventLabels[i] = "Empty"; break;
                        case 3569: eventLabels[i] = "Empty"; break;
                        case 3570: eventLabels[i] = "Empty"; break;
                        case 3571: eventLabels[i] = "Empty"; break;
                        case 3572: eventLabels[i] = "Empty"; break;
                        case 3573: eventLabels[i] = "Empty"; break;
                        case 3574: eventLabels[i] = "Empty"; break;
                        case 3575: eventLabels[i] = "Empty"; break;
                        case 3576: eventLabels[i] = "Empty"; break;
                        case 3577: eventLabels[i] = "Empty"; break;
                        case 3578: eventLabels[i] = "Empty"; break;
                        case 3579: eventLabels[i] = "Empty"; break;
                        case 3580: eventLabels[i] = "Empty"; break;
                        case 3581: eventLabels[i] = "Empty"; break;
                        case 3582: eventLabels[i] = "Empty"; break;
                        case 3583: eventLabels[i] = "Empty"; break;
                        case 3584: eventLabels[i] = "Bank 20 Return Event"; break;
                        case 3585: eventLabels[i] = "Nimbus Fade In Async"; break;
                        case 3586: eventLabels[i] = "Nimbus Inn Lobby Loader From Save Point"; break;
                        case 3587: eventLabels[i] = "Set 70Ae To 70A8"; break;
                        case 3588: eventLabels[i] = "Signal Ring Activator"; break;
                        case 3589: eventLabels[i] = "Empty"; break;
                        case 3590: eventLabels[i] = "Rose Town Chimney"; break;
                        case 3591: eventLabels[i] = "Empty"; break;
                        case 3592: eventLabels[i] = "Empty"; break;
                        case 3593: eventLabels[i] = "Get Item From Chapel Henchman 3"; break;
                        case 3594: eventLabels[i] = "Get Item From Chapel Henchman 1"; break;
                        case 3595: eventLabels[i] = "Get Item From Chapel Henchman 2"; break;
                        case 3596: eventLabels[i] = "Empty"; break;
                        case 3597: eventLabels[i] = "Yoster Empty Mailbox"; break;
                        case 3598: eventLabels[i] = "Empty"; break;
                        case 3599: eventLabels[i] = "Mushroom Derby Prize Calculator"; break;
                        case 3600: eventLabels[i] = "Mushroom Derby Goal Tile"; break;
                        case 3601: eventLabels[i] = "Mushroom Derby Yoshi Autoplay"; break;
                        case 3602: eventLabels[i] = "Mushroom Kingdom Raz Raini Note"; break;
                        case 3603: eventLabels[i] = "Empty"; break;
                        case 3604: eventLabels[i] = "Pipe Vault Triple Chest Room Loader"; break;
                        case 3605: eventLabels[i] = "Pipe Vault Pipe To Triple Chest Room"; break;
                        case 3606: eventLabels[i] = "Chest Differentiator Npc 1 Or Other Camera A"; break;
                        case 3607: eventLabels[i] = "Coin Differentiator Npc 8 Through 15"; break;
                        case 3608: eventLabels[i] = "Lands End Purchasable Chest"; break;
                        case 3609: eventLabels[i] = "Keep Invisible Floor Chests"; break;
                        case 3610: eventLabels[i] = "Keep Invisible Floor Coins"; break;
                        case 3611: eventLabels[i] = "Chest Differentiator Npc 2 Or Other"; break;
                        case 3612: eventLabels[i] = "Chest Differentiator Npc 1 Or Other Camera B"; break;
                        case 3613: eventLabels[i] = "Chest Differentiator Npc 11 Or Other"; break;
                        case 3614: eventLabels[i] = "Belome Fortune Prize Chest"; break;
                        case 3615: eventLabels[i] = "Climb Up Valley Beanstalk Into Vine Clouds"; break;
                        case 3616: eventLabels[i] = "Nimbus Inn Loader From Door"; break;
                        case 3617: eventLabels[i] = "Nimbus Inn Bedroom Loader"; break;
                        case 3618: eventLabels[i] = "Nimbus Exterior Open Inn Door"; break;
                        case 3619: eventLabels[i] = "Nimbus Exterior Open Shop Door"; break;
                        case 3620: eventLabels[i] = "Nimbus Exterior Open Garros Door"; break;
                        case 3621: eventLabels[i] = "Nimbus Exterior Open South House Door"; break;
                        case 3622: eventLabels[i] = "Nimbus Exterior Open Northeast House Door"; break;
                        case 3623: eventLabels[i] = "Empty"; break;
                        case 3624: eventLabels[i] = "Nimbus Shop Loader"; break;
                        case 3625: eventLabels[i] = "Empty"; break;
                        case 3626: eventLabels[i] = "Nimbus Shop Chest Camera Shift"; break;
                        case 3627: eventLabels[i] = "Empty"; break;
                        case 3628: eventLabels[i] = "Nimbus Exterior Blue Guy In Front Of Castle Entrance"; break;
                        case 3629: eventLabels[i] = "Nimbus Exterior Blue Guy Near Shop"; break;
                        case 3630: eventLabels[i] = "Nimbus Exterior Blue Guy Near Invisible Path"; break;
                        case 3631: eventLabels[i] = "Nimbus Exterior Blue Guy Near Garros House"; break;
                        case 3632: eventLabels[i] = "Nimbus Exterior Woman Near Invisible Path"; break;
                        case 3633: eventLabels[i] = "Nimbus Exterior Woman Near Inn"; break;
                        case 3634: eventLabels[i] = "Nimbus Exterior Woman Near Entrance"; break;
                        case 3635: eventLabels[i] = "Nimbus Exterior Woman In Front Of Castle Entrance"; break;
                        case 3636: eventLabels[i] = "Nimbus Bird Guard"; break;
                        case 3637: eventLabels[i] = "Temple Backdoor Locked"; break;
                        case 3638: eventLabels[i] = "Empty"; break;
                        case 3639: eventLabels[i] = "Empty"; break;
                        case 3640: eventLabels[i] = "Statue Game"; break;
                        case 3641: eventLabels[i] = "Empty"; break;
                        case 3642: eventLabels[i] = "Nimbus Exterior Occupied Loader"; break;
                        case 3643: eventLabels[i] = "Nimbus Shop"; break;
                        case 3644: eventLabels[i] = "Nimbus Innkeeper"; break;
                        case 3645: eventLabels[i] = "Nimbus Exterior Exit To Vines"; break;
                        case 3646: eventLabels[i] = "Nimbus Exterior Guard Near Entrance"; break;
                        case 3647: eventLabels[i] = "Nimbus Exterior Guard Near Castle"; break;
                        case 3648: eventLabels[i] = "Nimbus Occupied Northeast House Right Guy"; break;
                        case 3649: eventLabels[i] = "Nimbus Occupied Northeast House Left Woman"; break;
                        case 3650: eventLabels[i] = "Nimbus Occupied Northeast House Right Woman"; break;
                        case 3651: eventLabels[i] = "Nimbus Northeast House Croco"; break;
                        case 3652: eventLabels[i] = "Nimbus Occupied Northeast House Left Guard"; break;
                        case 3653: eventLabels[i] = "Nimbus South House Guy"; break;
                        case 3654: eventLabels[i] = "Nimbus South House Woman"; break;
                        case 3655: eventLabels[i] = "Nimbus Exterior Southernmost Blue Guy"; break;
                        case 3656: eventLabels[i] = "Empty"; break;
                        case 3657: eventLabels[i] = "Room Service Menu"; break;
                        case 3658: eventLabels[i] = "Empty"; break;
                        case 3659: eventLabels[i] = "Nimbus Deep Castle Note"; break;
                        case 3660: eventLabels[i] = "Nimbus Repopulate Castle Upon Liberation"; break;
                        case 3661: eventLabels[i] = "Bathrobe"; break;
                        case 3662: eventLabels[i] = "Nimbus Castle Left Fan Room Exit To Bridge Room"; break;
                        case 3663: eventLabels[i] = "Nimbus Castle Left Shaman Room Exit To 5 Door Room"; break;
                        case 3664: eventLabels[i] = "Nimbus Castle Right Shaman Room Exit To 5 Door Room"; break;
                        case 3665: eventLabels[i] = "Nimbus Castle Right Shaman Room Exit To Two Level Chest Room"; break;
                        case 3666: eventLabels[i] = "Nimbus Castle Note Hallway Exit To Two Level Chest Room"; break;
                        case 3667: eventLabels[i] = "Nimbus Castle Antechamber Left Guard"; break;
                        case 3668: eventLabels[i] = "Nimbus Castle Antechamber Right Guard"; break;
                        case 3669: eventLabels[i] = "Nimbus Castle Solo Bird Statue Room Exit To 5 Door Room"; break;
                        case 3670: eventLabels[i] = "Nimbus Castle Main Hall Loader"; break;
                        case 3671: eventLabels[i] = "Nimbus Castle First Post Throne Hall Exit To Throne Room"; break;
                        case 3672: eventLabels[i] = "Nimbus Castle Back Exit Fall"; break;
                        case 3673: eventLabels[i] = "Nimbus Liberated Town Square Loader"; break;
                        case 3674: eventLabels[i] = "Nimbus Castle Two Level Chest Room Lower Chest"; break;
                        case 3675: eventLabels[i] = "Nimbus Castle Bridge Room Lower Npc"; break;
                        case 3676: eventLabels[i] = "Nimbus Castle Two Level Chest Room Female Npc"; break;
                        case 3677: eventLabels[i] = "Royal Bus Platform Loader"; break;
                        case 3678: eventLabels[i] = "Royal Bus Attendant"; break;
                        case 3679: eventLabels[i] = "Nimbus Castle Egg Room Loader"; break;
                        case 3680: eventLabels[i] = "Nimbus Castle Egg Post Defeat"; break;
                        case 3681: eventLabels[i] = "Birdy Becomes Platform"; break;
                        case 3682: eventLabels[i] = "Empty"; break;
                        case 3683: eventLabels[i] = "Vine Instructions"; break;
                        case 3684: eventLabels[i] = "Empty"; break;
                        case 3685: eventLabels[i] = "Nimbus Get Crocos Item"; break;
                        case 3686: eventLabels[i] = "Marrymore Shower"; break;
                        case 3687: eventLabels[i] = "Marrymore Shower Door"; break;
                        case 3688: eventLabels[i] = "Marrymore Service Bell"; break;
                        case 3689: eventLabels[i] = "Link"; break;
                        case 3690: eventLabels[i] = "Nimbus Castle Main Hall Exit To Exterior"; break;
                        case 3691: eventLabels[i] = "Garros House Exit"; break;
                        case 3692: eventLabels[i] = "Nimbus Lower House Exit To Exterior"; break;
                        case 3693: eventLabels[i] = "Nimbus Inn Exit To Exterior"; break;
                        case 3694: eventLabels[i] = "Nimbus Shop Exit"; break;
                        case 3695: eventLabels[i] = "Nimbus Croco House Exit"; break;
                        case 3696: eventLabels[i] = "Nimbus Castle West Lower Hall Loader"; break;
                        case 3697: eventLabels[i] = "Nimbus Castle West Lower Hall Pinwheel Animations"; break;
                        case 3698: eventLabels[i] = "Nimbus Castle West Lower Hall Pinwheel"; break;
                        case 3699: eventLabels[i] = "Nimbus Castle West Lower Hall Mario Blown By Fan Bit"; break;
                        case 3700: eventLabels[i] = "Nimbus Castle West Lower Hall Mario Blown By Fan Bit"; break;
                        case 3701: eventLabels[i] = "Nimbus Castle Left Shaman Room Loader"; break;
                        case 3702: eventLabels[i] = "Nimbus Castle Right Shaman Room Loader"; break;
                        case 3703: eventLabels[i] = "Nimbus Castle Two Level Chest Room Loader"; break;
                        case 3704: eventLabels[i] = "Nimbus Castle Occupied 5 Door Room Loader"; break;
                        case 3705: eventLabels[i] = "Jawful Battle"; break;
                        case 3706: eventLabels[i] = "Activate Jawful Extended Hitboxes"; break;
                        case 3707: eventLabels[i] = "Nimbus Castle West Staircase Loader"; break;
                        case 3708: eventLabels[i] = "Open Castlekey1 Door"; break;
                        case 3709: eventLabels[i] = "Empty"; break;
                        case 3710: eventLabels[i] = "Empty"; break;
                        case 3711: eventLabels[i] = "Nimbus Castle Bridge Room Loader"; break;
                        case 3712: eventLabels[i] = "Nimbus Castle Bridge Room Npc Animations"; break;
                        case 3713: eventLabels[i] = "Nimbus Castle Angled Plant Room Npc Animations"; break;
                        case 3714: eventLabels[i] = "Nimbus Castle Angled Plant Room Loader"; break;
                        case 3715: eventLabels[i] = "Nimbus Castle Angled Plant Room Right Fan Gust Path"; break;
                        case 3716: eventLabels[i] = "Nimbus Castle Angled Plant Room Right Fan Gust"; break;
                        case 3717: eventLabels[i] = "Nimbus Castle Two Level Chest Room Fan Gust Path"; break;
                        case 3718: eventLabels[i] = "Nimbus Castle Angled Plant Room Right Fan Battle"; break;
                        case 3719: eventLabels[i] = "Nimbus Castle Right Red Cellar Woman"; break;
                        case 3720: eventLabels[i] = "Nimbus Castle Outer Cellar Blue Gift Guy"; break;
                        case 3721: eventLabels[i] = "Nimbus Castle Rightmost Outer Cellar Guy"; break;
                        case 3722: eventLabels[i] = "Nimbus Castle Left Cellar Woman"; break;
                        case 3723: eventLabels[i] = "Nimbus Castle Outer Cellar Gift Guard"; break;
                        case 3724: eventLabels[i] = "Nimbus Castle Outer Cellar Loader"; break;
                        case 3725: eventLabels[i] = "Nimbus Castle Note Hallway Loader"; break;
                        case 3726: eventLabels[i] = "Nimbus Castle Antechamber Loader"; break;
                        case 3727: eventLabels[i] = "Nimbus Castle Stairway Guard"; break;
                        case 3728: eventLabels[i] = "Empty"; break;
                        case 3729: eventLabels[i] = "Nimbus Castle Occupied Throne Room Loader"; break;
                        case 3730: eventLabels[i] = "Nimbus Castle Occupied 4 Path Room Loader"; break;
                        case 3731: eventLabels[i] = "Empty"; break;
                        case 3732: eventLabels[i] = "Nimbus Castle Final Chest Hallway Loader"; break;
                        case 3733: eventLabels[i] = "Nimbus Castle Final Chest Hallway Platform"; break;
                        case 3734: eventLabels[i] = "Nimbus Castle Final Chest Hallway Exit To Final Hallway"; break;
                        case 3735: eventLabels[i] = "Nimbus Castle Final Hallway Apply Mod"; break;
                        case 3736: eventLabels[i] = "Nimbus Castle Final Hallway Loader"; break;
                        case 3737: eventLabels[i] = "Nimbus Castle Back Exit Loader"; break;
                        case 3738: eventLabels[i] = "Empty"; break;
                        case 3739: eventLabels[i] = "Nimbus Castle Throne Room Exit To Antechamber"; break;
                        case 3740: eventLabels[i] = "Nimbus Castle Liberated Throne Room Loader"; break;
                        case 3741: eventLabels[i] = "Nimbus Castle Antechamber Exit To Note Hallway"; break;
                        case 3742: eventLabels[i] = "Nimbus Castle Antechamber Exit To Throne Room"; break;
                        case 3743: eventLabels[i] = "Nimbus Castle Right Shaman Hallway Liberated Npc"; break;
                        case 3744: eventLabels[i] = "Nimbus Exterior Shy Away"; break;
                        case 3745: eventLabels[i] = "Nimbus Back Exit Initiate Falling Sequence"; break;
                        case 3746: eventLabels[i] = "Hot Springs Trampoline To Mezzanine"; break;
                        case 3747: eventLabels[i] = "Nimbus Hot Spring Guards"; break;
                        case 3748: eventLabels[i] = "Empty"; break;
                        case 3749: eventLabels[i] = "Nimbus Mezzanine Trampoline To Town Square"; break;
                        case 3750: eventLabels[i] = "Nimbus Mezzanine Fall To Hot Springs"; break;
                        case 3751: eventLabels[i] = "Nimbus Land Hot Springs Lobby Exit"; break;
                        case 3752: eventLabels[i] = "Hot Springs Exit To Lobby"; break;
                        case 3753: eventLabels[i] = "Hot Springs Lobby Loader"; break;
                        case 3754: eventLabels[i] = "Hot Springs Fall To Volcano"; break;
                        case 3755: eventLabels[i] = "Hot Springs Note"; break;
                        case 3756: eventLabels[i] = "Hot Springs Loader"; break;
                        case 3757: eventLabels[i] = "King Nimbus"; break;
                        case 3758: eventLabels[i] = "Queen Nimbus"; break;
                        case 3759: eventLabels[i] = "Nimbus Castle Left Shaman Hallway Liberated Npc"; break;
                        case 3760: eventLabels[i] = "Nimbus Mezzanine Trampoline To World Map"; break;
                        case 3761: eventLabels[i] = "Nimbus Mezzanine Loader"; break;
                        case 3762: eventLabels[i] = "Nimbus Castle Liberated 5 Door Room Loader"; break;
                        case 3763: eventLabels[i] = "Nimbus Back Exit Mario Fall Animation"; break;
                        case 3764: eventLabels[i] = "Nimbus First Fall Room Load 2Nd Room"; break;
                        case 3765: eventLabels[i] = "Bean Valley Upper Chest Room Fall To Lower Chest Room"; break;
                        case 3766: eventLabels[i] = "Bean Valley Lower Chest Room Fall To Hot Springs Mezzanine"; break;
                        case 3767: eventLabels[i] = "Nimbus Castle Angled Plant Room Exit To 4 Path Room"; break;
                        case 3768: eventLabels[i] = "Nimbus Castle Main Hall Exit To 4 Way Path"; break;
                        case 3769: eventLabels[i] = "Nimbus Castle Liberated Bridge Room Loader"; break;
                        case 3770: eventLabels[i] = "Bean Valley 1St Vine Room Loader"; break;
                        case 3771: eventLabels[i] = "Samus"; break;
                        case 3772: eventLabels[i] = "Hot Springs Water"; break;
                        case 3773: eventLabels[i] = "Hot Springs Eject From Water"; break;
                        case 3774: eventLabels[i] = "Hot Springs Reset Ejection Timer"; break;
                        case 3775: eventLabels[i] = "Unused Nimbus Dialog"; break;
                        case 3776: eventLabels[i] = "Empty"; break;
                        case 3777: eventLabels[i] = "Royal Bus Platform Exit"; break;
                        case 3778: eventLabels[i] = "Ball Solitaire Set Puzzle"; break;
                        case 3779: eventLabels[i] = "Bean Valley 1St Vine Room Exit To 2Nd Vine Room"; break;
                        case 3780: eventLabels[i] = "Bean Valley 2Nd Vine Room Exit To East Vine Room"; break;
                        case 3781: eventLabels[i] = "Bean Valley East Vine Room Exit To Nimbus Mezzanine"; break;
                        case 3782: eventLabels[i] = "Bean Valley Upper Chest Room Fall To West Vine Room"; break;
                        case 3783: eventLabels[i] = "Bean Valley East Vine Room Exit To 2Nd Vine Room"; break;
                        case 3784: eventLabels[i] = "Bean Valley 2Nd Vine Room Exit To 1St Vine Room"; break;
                        case 3785: eventLabels[i] = "Bean Valley 1St Vine Room Exit To Ground Level"; break;
                        case 3786: eventLabels[i] = "Bean Valley West Vine Room Exit To Upper Chest Room"; break;
                        case 3787: eventLabels[i] = "Nimbus Mezzanine Fall To East Vine Room"; break;
                        case 3788: eventLabels[i] = "Bean Valley West Vine Room Summon Platform"; break;
                        case 3789: eventLabels[i] = "Bean Valley West Vine Room Platform"; break;
                        case 3790: eventLabels[i] = "Bean Valley 2Nd Vine Room Exit To West Vine Room"; break;
                        case 3791: eventLabels[i] = "Open Factory Final Boss Room"; break;
                        case 3792: eventLabels[i] = "Factory Final Boss Room Loader"; break;
                        case 3793: eventLabels[i] = "Factory Smelter Animation"; break;
                        case 3794: eventLabels[i] = "Factory Final Boss Fight"; break;
                        case 3795: eventLabels[i] = "Empty"; break;
                        case 3796: eventLabels[i] = "Empty"; break;
                        case 3797: eventLabels[i] = "Ending Credits Room Loader"; break;
                        case 3798: eventLabels[i] = "Ending Credits Orange Star"; break;
                        case 3799: eventLabels[i] = "Ending Credits Purple Star"; break;
                        case 3800: eventLabels[i] = "Ending Credits Indigo Star"; break;
                        case 3801: eventLabels[i] = "Ending Credits Red Star"; break;
                        case 3802: eventLabels[i] = "Ending Credits Yellow Star"; break;
                        case 3803: eventLabels[i] = "Ending Credits Green Star"; break;
                        case 3804: eventLabels[i] = "Ending Credits Coronation Npcs"; break;
                        case 3805: eventLabels[i] = "Ending Credits Coronation Loader"; break;
                        case 3806: eventLabels[i] = "Ending Credits Race Npcs"; break;
                        case 3807: eventLabels[i] = "Ending Credits Race Loader"; break;
                        case 3808: eventLabels[i] = "Ending Credits Race Audience"; break;
                        case 3809: eventLabels[i] = "Marrymore Sanctuary Begin Wedding Gear Sequence"; break;
                        case 3810: eventLabels[i] = "Empty"; break;
                        case 3811: eventLabels[i] = "Nimbus Inner Cellar Loader"; break;
                        case 3812: eventLabels[i] = "Empty"; break;
                        case 3813: eventLabels[i] = "Nimbus Inn Guest"; break;
                        case 3814: eventLabels[i] = "Mushroom Kingdom Liberated Loader"; break;
                        case 3815: eventLabels[i] = "Empty"; break;
                        case 3816: eventLabels[i] = "Empty"; break;
                        case 3817: eventLabels[i] = "Empty"; break;
                        case 3818: eventLabels[i] = "World Map Mushroom Way"; break;
                        case 3819: eventLabels[i] = "Lands End First Room Loader"; break;
                        case 3820: eventLabels[i] = "Forced Tower Boss 1 Fight"; break;
                        case 3821: eventLabels[i] = "Empty"; break;
                        case 3822: eventLabels[i] = "Rose Town Sign Item Granter"; break;
                        case 3823: eventLabels[i] = "Yoster Isle Goalpost Item Granter"; break;
                        case 3824: eventLabels[i] = "Yoster Isle Loader"; break;
                        case 3825: eventLabels[i] = "Nimbus Final Chest Room Platform Bit"; break;
                        case 3826: eventLabels[i] = "Empty"; break;
                        case 3827: eventLabels[i] = "Grant Item Standard Sound"; break;
                        case 3828: eventLabels[i] = "Empty"; break;
                        case 3829: eventLabels[i] = "Empty"; break;
                        case 3830: eventLabels[i] = "Mushroom Kingdom Shop Cellar Npc"; break;
                        case 3831: eventLabels[i] = "Mushroom Kingdom Shop Cellar Mod"; break;
                        case 3832: eventLabels[i] = "Empty"; break;
                        case 3833: eventLabels[i] = "Empty"; break;
                        case 3834: eventLabels[i] = "Empty"; break;
                        case 3835: eventLabels[i] = "Empty"; break;
                        case 3836: eventLabels[i] = "Empty"; break;
                        case 3837: eventLabels[i] = "Empty"; break;
                        case 3838: eventLabels[i] = "Keep Anti Softlock Trampoline"; break;
                        case 3839: eventLabels[i] = "Empty"; break;
                        case 3840: eventLabels[i] = "Starter Debug Items"; break;
                        case 3841: eventLabels[i] = "World Map Marios Pad"; break;
                        case 3842: eventLabels[i] = "Booster Hill Star Piece Signal"; break;
                        case 3843: eventLabels[i] = "World Map Mushroom Kingdom"; break;
                        case 3844: eventLabels[i] = "World Map Bandits Way"; break;
                        case 3845: eventLabels[i] = "World Map Kero Sewers"; break;
                        case 3846: eventLabels[i] = "World Map Midas River"; break;
                        case 3847: eventLabels[i] = "World Map Tadpole Pond"; break;
                        case 3848: eventLabels[i] = "World Map Pipe Vault"; break;
                        case 3849: eventLabels[i] = "World Map Rose Way"; break;
                        case 3850: eventLabels[i] = "World Map Rose Town"; break;
                        case 3851: eventLabels[i] = "World Map Forest Maze"; break;
                        case 3852: eventLabels[i] = "World Map Yoster Isle"; break;
                        case 3853: eventLabels[i] = "World Map Moleville"; break;
                        case 3854: eventLabels[i] = "World Map Booster Pass"; break;
                        case 3855: eventLabels[i] = "World Map Booster Tower"; break;
                        case 3856: eventLabels[i] = "World Map Marrymore"; break;
                        case 3857: eventLabels[i] = "World Map Star Hill"; break;
                        case 3858: eventLabels[i] = "World Map Seaside Town"; break;
                        case 3859: eventLabels[i] = "World Map Sea"; break;
                        case 3860: eventLabels[i] = "World Map Ship"; break;
                        case 3861: eventLabels[i] = "World Map Lands End"; break;
                        case 3862: eventLabels[i] = "World Map Montro Town"; break;
                        case 3863: eventLabels[i] = "World Map Bean Valley"; break;
                        case 3864: eventLabels[i] = "World Map Nimbus Land"; break;
                        case 3865: eventLabels[i] = "World Map Barrel Volcano"; break;
                        case 3866: eventLabels[i] = "World Map Vista Hill"; break;
                        case 3867: eventLabels[i] = "World Map Booster Hill"; break;
                        case 3868: eventLabels[i] = "World Map Bowsers Keep"; break;
                        case 3869: eventLabels[i] = "World Map Abyss"; break;
                        case 3870: eventLabels[i] = "World Map Grate Guys Casino"; break;
                        case 3871: eventLabels[i] = "Nimbus Castle Two Chest Room Guard"; break;
                        case 3872: eventLabels[i] = "Nimbus Castle 5 Door Room Left Guard"; break;
                        case 3873: eventLabels[i] = "Nimbus Castle 5 Door Room Right Guard"; break;
                        case 3874: eventLabels[i] = "Nimbus Castle Bridge Room Guard"; break;
                        case 3875: eventLabels[i] = "Nimbus Unused Dialog"; break;
                        case 3876: eventLabels[i] = "Nimbus Castlle 4 Way Path Left Guard"; break;
                        case 3877: eventLabels[i] = "Nimbus Castle Two Chest Room Upper Chest"; break;
                        case 3878: eventLabels[i] = "Casino Trampoline"; break;
                        case 3879: eventLabels[i] = "Nimbus Castle Bridge Room Chest"; break;
                        case 3880: eventLabels[i] = "Sea Chests"; break;
                        case 3881: eventLabels[i] = "Chest Differentiator Npc 1 Or Other"; break;
                        case 3882: eventLabels[i] = "Chest Differentiator Npc 3 4 Or Other"; break;
                        case 3883: eventLabels[i] = "Inner Factory Exit Trampoline"; break;
                        case 3884: eventLabels[i] = "Ball Solitaire Set Puzzle Configuration Value"; break;
                        case 3885: eventLabels[i] = "End Game"; break;
                        case 3886: eventLabels[i] = "End Game Container From Alt Win Conditions"; break;
                        case 3887: eventLabels[i] = "Marios Pad Star Piece Signal"; break;
                        case 3888: eventLabels[i] = "Mushroom Way Star Piece Signal"; break;
                        case 3889: eventLabels[i] = "Mushroom Kingdom Star Piece Signal"; break;
                        case 3890: eventLabels[i] = "Bandits Way Star Piece Signal"; break;
                        case 3891: eventLabels[i] = "Sewers Star Piece Signal"; break;
                        case 3892: eventLabels[i] = "Midas River Star Piece Signal"; break;
                        case 3893: eventLabels[i] = "Tadpole Pond Star Piece Signal"; break;
                        case 3894: eventLabels[i] = "Rose Way Star Piece Signal"; break;
                        case 3895: eventLabels[i] = "Rose Town Star Piece Signal"; break;
                        case 3896: eventLabels[i] = "Forest Maze Star Piece Signal"; break;
                        case 3897: eventLabels[i] = "Moleville Star Piece Signal"; break;
                        case 3898: eventLabels[i] = "Booster Pass Star Piece Signal"; break;
                        case 3899: eventLabels[i] = "Booster Tower Star Piece Signal"; break;
                        case 3900: eventLabels[i] = "Pipe Vault Star Piece Signal"; break;
                        case 3901: eventLabels[i] = "Yoster Isle Star Piece Signal"; break;
                        case 3902: eventLabels[i] = "Marrymore Star Piece Signal"; break;
                        case 3903: eventLabels[i] = "Star Hill Star Piece Signal"; break;
                        case 3904: eventLabels[i] = "Seaside Town Star Piece Signal"; break;
                        case 3905: eventLabels[i] = "Sea Star Piece Signal"; break;
                        case 3906: eventLabels[i] = "Ship Star Piece Signal"; break;
                        case 3907: eventLabels[i] = "Lands End Star Piece Signal"; break;
                        case 3908: eventLabels[i] = "Temple Star Piece Signal"; break;
                        case 3909: eventLabels[i] = "Monstro Star Piece Signal"; break;
                        case 3910: eventLabels[i] = "Casino Star Piece Signal"; break;
                        case 3911: eventLabels[i] = "Bean Valley Star Piece Signal"; break;
                        case 3912: eventLabels[i] = "Nimbus Star Piece Signal"; break;
                        case 3913: eventLabels[i] = "Volcano Star Piece Signal"; break;
                        case 3914: eventLabels[i] = "Keep Star Piece Signal"; break;
                        case 3915: eventLabels[i] = "Factory Star Piece Signal"; break;
                        case 3916: eventLabels[i] = "Inner Factory Star Piece Signal"; break;
                        case 3917: eventLabels[i] = "Rose Way Back Entrance Loader"; break;
                        case 3918: eventLabels[i] = "Forest Maze Entrance Loader"; break;
                        case 3919: eventLabels[i] = "Booster Pass Back Entrance Loader"; break;
                        case 3920: eventLabels[i] = "Sea Save Room Loader"; break;
                        case 3921: eventLabels[i] = "Ship First Save Room Loader"; break;
                        case 3922: eventLabels[i] = "Temple Set Signal Ring Directional Bit"; break;
                        case 3923: eventLabels[i] = "Volcano Save Room Loader"; break;
                        case 3924: eventLabels[i] = "Keep 1St Save Room Loader"; break;
                        case 3925: eventLabels[i] = "Factory Save Room Loaders"; break;
                        case 3926: eventLabels[i] = "Temple Back Entrance"; break;
                        case 3927: eventLabels[i] = "Nimbus Castle Exit Hallway Save Room Loader"; break;
                        case 3928: eventLabels[i] = "Nimbus Castlle 4 Way Path Right Guard"; break;
                        case 3929: eventLabels[i] = "Lands End Purchasable Chest 2 Subroutine"; break;
                        case 3930: eventLabels[i] = "Marrymore Gear Preloader"; break;
                        case 3931: eventLabels[i] = "Get Shoes"; break;
                        case 3932: eventLabels[i] = "Get Brooch"; break;
                        case 3933: eventLabels[i] = "Get Ring"; break;
                        case 3934: eventLabels[i] = "Get Crown"; break;
                        case 3935: eventLabels[i] = "Freestanding Shoes"; break;
                        case 3936: eventLabels[i] = "Freestanding Brooch"; break;
                        case 3937: eventLabels[i] = "Freestanding Ring"; break;
                        case 3938: eventLabels[i] = "Freestanding Crown"; break;
                        case 3939: eventLabels[i] = "River Shoes"; break;
                        case 3940: eventLabels[i] = "River Brooch"; break;
                        case 3941: eventLabels[i] = "River Ring"; break;
                        case 3942: eventLabels[i] = "River Crown"; break;
                        case 3943: eventLabels[i] = "Shoes Chest"; break;
                        case 3944: eventLabels[i] = "Brooch Chest"; break;
                        case 3945: eventLabels[i] = "Ring Chest"; break;
                        case 3946: eventLabels[i] = "Crown Chest"; break;
                        case 3947: eventLabels[i] = "Empty"; break;
                        case 3948: eventLabels[i] = "Empty"; break;
                        case 3949: eventLabels[i] = "Empty"; break;
                        case 3950: eventLabels[i] = "Post Final Boss Init"; break;
                        case 3951: eventLabels[i] = "Star Piece Credits Init"; break;
                        case 3952: eventLabels[i] = "Clone Reserved"; break;
                        case 3953: eventLabels[i] = "Clone Reserved"; break;
                        case 3954: eventLabels[i] = "Clone Reserved"; break;
                        case 3955: eventLabels[i] = "Clone Reserved"; break;
                        case 3956: eventLabels[i] = "Clone Reserved"; break;
                        case 3957: eventLabels[i] = "Clone Reserved"; break;
                        case 3958: eventLabels[i] = "Clone Reserved"; break;
                        case 3959: eventLabels[i] = "Clone Reserved"; break;
                        case 3960: eventLabels[i] = "Clone Reserved"; break;
                        case 3961: eventLabels[i] = "Clone Reserved"; break;
                        case 3962: eventLabels[i] = "Clone Reserved"; break;
                        case 3963: eventLabels[i] = "Clone Reserved"; break;
                        case 3964: eventLabels[i] = "Clone Reserved"; break;
                        case 3965: eventLabels[i] = "Clone Reserved"; break;
                        case 3966: eventLabels[i] = "Clone Reserved"; break;
                        case 3967: eventLabels[i] = "Clone Reserved"; break;
                        case 3968: eventLabels[i] = "Clone Reserved"; break;
                        case 3969: eventLabels[i] = "Clone Reserved"; break;
                        case 3970: eventLabels[i] = "Clone Reserved"; break;
                        case 3971: eventLabels[i] = "Clone Reserved"; break;
                        case 3972: eventLabels[i] = "Clone Reserved"; break;
                        case 3973: eventLabels[i] = "Clone Reserved"; break;
                        case 3974: eventLabels[i] = "Clone Reserved"; break;
                        case 3975: eventLabels[i] = "Clone Reserved"; break;
                        case 3976: eventLabels[i] = "Clone Reserved"; break;
                        case 3977: eventLabels[i] = "Clone Reserved"; break;
                        case 3978: eventLabels[i] = "Clone Reserved"; break;
                        case 3979: eventLabels[i] = "Clone Reserved"; break;
                        case 3980: eventLabels[i] = "Clone Reserved"; break;
                        case 3981: eventLabels[i] = "Clone Reserved"; break;
                        case 3982: eventLabels[i] = "Clone Reserved"; break;
                        case 3983: eventLabels[i] = "Clone Reserved"; break;
                        case 3984: eventLabels[i] = "Clone Reserved"; break;
                        case 3985: eventLabels[i] = "Clone Reserved"; break;
                        case 3986: eventLabels[i] = "Clone Reserved"; break;
                        case 3987: eventLabels[i] = "Clone Reservedclone Reserved"; break;
                        case 3988: eventLabels[i] = "Clone Reserved"; break;
                        case 3989: eventLabels[i] = "Clone Reserved"; break;
                        case 3990: eventLabels[i] = "Clone Reserved"; break;
                        case 3991: eventLabels[i] = "Clone Reserved"; break;
                        case 3992: eventLabels[i] = "Clone Reserved"; break;
                        case 3993: eventLabels[i] = "Clone Reserved"; break;
                        case 3994: eventLabels[i] = "Clone Reserved"; break;
                        case 3995: eventLabels[i] = "Clone Reserved"; break;
                        case 3996: eventLabels[i] = "Clone Reserved"; break;
                        case 3997: eventLabels[i] = "Clone Reserved"; break;
                        case 3998: eventLabels[i] = "Clone Reserved"; break;
                        case 3999: eventLabels[i] = "Clone Reserved"; break;
                        case 4000: eventLabels[i] = "Clone Reserved"; break;
                        case 4001: eventLabels[i] = "Clone Reserved"; break;
                        case 4002: eventLabels[i] = "Clone Reserved"; break;
                        case 4003: eventLabels[i] = "Clone Reserved"; break;
                        case 4004: eventLabels[i] = "Clone Reserved"; break;
                        case 4005: eventLabels[i] = "Clone Reserved"; break;
                        case 4006: eventLabels[i] = "Clone Reserved"; break;
                        case 4007: eventLabels[i] = "Clone Reserved"; break;
                        case 4008: eventLabels[i] = "Clone Reserved"; break;
                        case 4009: eventLabels[i] = "Clone Reserved"; break;
                        case 4010: eventLabels[i] = "Clone Reserved"; break;
                        case 4011: eventLabels[i] = "Clone Reserved"; break;
                        case 4012: eventLabels[i] = "Clone Reserved"; break;
                        case 4013: eventLabels[i] = "Clone Reserved"; break;
                        case 4014: eventLabels[i] = "Clone Reserved"; break;
                        case 4015: eventLabels[i] = "Clone Reserved"; break;
                        case 4016: eventLabels[i] = "Clone Reserved"; break;
                        case 4017: eventLabels[i] = "Clone Reserved"; break;
                        case 4018: eventLabels[i] = "Clone Reserved"; break;
                        case 4019: eventLabels[i] = "Clone Reserved"; break;
                        case 4020: eventLabels[i] = "Clone Reserved"; break;
                        case 4021: eventLabels[i] = "Clone Reserved"; break;
                        case 4022: eventLabels[i] = "Clone Reserved"; break;
                        case 4023: eventLabels[i] = "Clone Reserved"; break;
                        case 4024: eventLabels[i] = "Clone Reserved"; break;
                        case 4025: eventLabels[i] = "Clone Reserved"; break;
                        case 4026: eventLabels[i] = "Clone Reserved"; break;
                        case 4027: eventLabels[i] = "Clone Reserved"; break;
                        case 4028: eventLabels[i] = "Clone Reserved"; break;
                        case 4029: eventLabels[i] = "Clone Reserved"; break;
                        case 4030: eventLabels[i] = "Clone Reserved"; break;
                        case 4031: eventLabels[i] = "Clone Reserved"; break;
                        case 4032: eventLabels[i] = "Clone Reserved"; break;
                        case 4033: eventLabels[i] = "Clone Reserved"; break;
                        case 4034: eventLabels[i] = "Clone Reserved"; break;
                        case 4035: eventLabels[i] = "Clone Reserved"; break;
                        case 4036: eventLabels[i] = "Clone Reserved"; break;
                        case 4037: eventLabels[i] = "Clone Reserved"; break;
                        case 4038: eventLabels[i] = "Clone Reserved"; break;
                        case 4039: eventLabels[i] = "Clone Reserved"; break;
                        case 4040: eventLabels[i] = "Clone Reserved"; break;
                        case 4041: eventLabels[i] = "Clone Reserved"; break;
                        case 4042: eventLabels[i] = "Clone Reserved"; break;
                        case 4043: eventLabels[i] = "Clone Reserved"; break;
                        case 4044: eventLabels[i] = "Clone Reserved"; break;
                        case 4045: eventLabels[i] = "Clone Reserved"; break;
                        case 4046: eventLabels[i] = "Clone Reserved"; break;
                        case 4047: eventLabels[i] = "Clone Reserved"; break;
                        case 4048: eventLabels[i] = "Clone Reserved"; break;
                        case 4049: eventLabels[i] = "Clone Reserved"; break;
                        case 4050: eventLabels[i] = "Clone Reserved"; break;
                        case 4051: eventLabels[i] = "Clone Reserved"; break;
                        case 4052: eventLabels[i] = "Clone Reserved"; break;
                        case 4053: eventLabels[i] = "Clone Reserved"; break;
                        case 4054: eventLabels[i] = "Clone Reserved"; break;
                        case 4055: eventLabels[i] = "Clone Reserved"; break;
                        case 4056: eventLabels[i] = "Clone Reserved"; break;
                        case 4057: eventLabels[i] = "Clone Reserved"; break;
                        case 4058: eventLabels[i] = "Clone Reserved"; break;
                        case 4059: eventLabels[i] = "Clone Reserved"; break;
                        case 4060: eventLabels[i] = "Clone Reserved"; break;
                        case 4061: eventLabels[i] = "Clone Reserved"; break;
                        case 4062: eventLabels[i] = "Clone Reserved"; break;
                        case 4063: eventLabels[i] = "Clone Reserved"; break;
                        case 4064: eventLabels[i] = "Clone Reserved"; break;
                        case 4065: eventLabels[i] = "Clone Reserved"; break;
                        case 4066: eventLabels[i] = "Clone Reserved"; break;
                        case 4067: eventLabels[i] = "Clone Reserved"; break;
                        case 4068: eventLabels[i] = "Clone Reserved"; break;
                        case 4069: eventLabels[i] = "Clone Reserved"; break;
                        case 4070: eventLabels[i] = "Clone Reserved"; break;
                        case 4071: eventLabels[i] = "Clone Reserved"; break;
                        case 4072: eventLabels[i] = "Clone Reserved"; break;
                        case 4073: eventLabels[i] = "Clone Reserved"; break;
                        case 4074: eventLabels[i] = "Clone Reserved"; break;
                        case 4075: eventLabels[i] = "Clone Reserved"; break;
                        case 4076: eventLabels[i] = "Clone Reserved"; break;
                        case 4077: eventLabels[i] = "Clone Reserved"; break;
                        case 4078: eventLabels[i] = "Clone Reserved"; break;
                        case 4079: eventLabels[i] = "Clone Reserved"; break;
                        case 4080: eventLabels[i] = "Clone Reserved"; break;
                        case 4081: eventLabels[i] = "Clone Reserved"; break;
                        case 4082: eventLabels[i] = "Clone Reserved"; break;
                        case 4083: eventLabels[i] = "Clone Reserved"; break;
                        case 4084: eventLabels[i] = "Clone Reserved"; break;
                        case 4085: eventLabels[i] = "Clone Reserved"; break;
                        case 4086: eventLabels[i] = "Clone Reserved"; break;
                        case 4087: eventLabels[i] = "Clone Reserved"; break;
                        case 4088: eventLabels[i] = "Clone Reserved"; break;
                        case 4089: eventLabels[i] = "Clone Reserved"; break;
                        case 4090: eventLabels[i] = "Clone Reserved"; break;
                        case 4091: eventLabels[i] = "Clone Reserved"; break;
                        case 4092: eventLabels[i] = "Clone Reserved"; break;
                        case 4093: eventLabels[i] = "Clone Reserved"; break;
                        case 4094: eventLabels[i] = "Clone Reserved"; break;
                        case 4095: eventLabels[i] = "Clone Reserved"; break;
                        default: actionLabels[i] = ""; break;
                    }
                }
                RomConfig.ApplyCustomLabels(actionLabels, Properties.Settings.Default.CustomActionLabels);
                return actionLabels;
            }
            set
            {
                actionLabels = value;
            }
        }


        public static int[][] EventOpcodes = new int[][]
        {
            new int[]   // 0
            {
                0x00,0x30,0x31,0x32,0x39,0x3A,0x3B,0x3D,
                0x3E,0x3F,0x42,0xF2,0xF3,0xF4,0xF5,0xF6,
                0xF7,0xF8,0xFD,0xFD,0xFD,0xFD,0xFD,0xFD,
                0xFD,0xFD
            },
            new int[]   // 1
            {
                0x34,0x35
            },
            new int[]   // 2
            {
                0x36,0x54,0x56,0xCE,0xFD,0xFD,0xFD
            },
            new int[]   // 3
            {
                0x50,0x51,0x52,0x53,0x57,0xFD,0xFD,0xFD,
                0xFD,0xFD,0xFD,0xFD,0xFD,0xFD
            },
            new int[]   // 4
            {
                0x49,0x4A
            },
            new int[]   // 5
            {
                0x4B,0x68,0x6A,0x6B
            },
            new int[]   // 6
            {
                0x4C,0x4F,0xFB,0xFC,0xFD,0xFD,0xFD
            },
            new int[]   // 7
            {
                0x60,0x61,0x62,0x63,0x64,0x65,0x66,0x67
            },
            new int[]   // 8
            {
                0x40,0x44,0x45,0x46,0x47,0x4E,0xD0,0xD1,
                0xFD,0xFD,0xFD,0xFD,0xFD,0xFD,0xFD,0xFD,
                0xFD,0xFD,0xFD
            },
            new int[]   // 9
            {
                0xD2,0xD3,0xD4,0xD5,0xD7,0xF9,0xFA
            },
            new int[]   // 10
            {
                0x70,0x71,0x72,0x73,0x74,0x75,0x76,0x77,
                0x78,0x79,0x7A,0x7B,0x7C,0x7D,0x7E,0x80,
                0x81,0x82,0x83,0x84,0x89,0x8A,0x87,0x8F,
                0xFD,0xFD
            },
            new int[]   // 11
            {
                0x90,0x91,0x92,0x93,0x94,0x95,0x97,0x98,
                0x9B,0x9C,0x9D,0x9E,0xFD,0xFD,0xFD,0xFD,
                0xFD,0xFD
            },
            new int[]   // 12
            {
                0xA0,0xA4,0xA8,0xA9,0xAA,0xAB,0xB0,0xB1,
                0xB2,0xB3,0xB5,0xB7,0xBB,0xBC,0xBD,0xC2,
                0xD6,0xD8,0xDC,0xE0,0xE1,0xE4,0xE5,0xE8,
                0xE9,0xFD,0xFD
            },
            new int[]   // 13
            {
                0x37,0x38,0x55,0x58,0xA3,0xA7,0xAC,0xAD,
                0xAE,0xAF,0xB4,0xB6,0xB8,0xB9,0xBA,
                0xC0,0xC1,0xC3,0xC4,0xC5,0xC6,0xC7,
                0xC8,0xBF,0xBE,0xC9,0xCA,0xCB,0xDB,0xDF,0xE2,0xE3,
                0xE6,0xE7,0xEA,0xEB,0xEC,0xED,0xEE,0xEF,
                0xFD,0xFD,0xFD,0xFD,0xFD,0xFD,0xFD,0xFD,
                0xFD,0xFD,0xFD,0xFD,0xFD
            },
            new int[]   // 14
            {
                0x5B,0x7F,0xF0,0xF1,0xFD,0xFD
            },
            new int[]   // 15
            {
                0xFE,0xFF
            }
        };
        public static int[][] EventParams = new int[][]
        {
            new int[]   // 0
            {
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x32,0x33,0x34,0x3D,0x3E,0xF0,
                0xF9,0xFA
            },
            new int[]   // 1
            {
                0x00,0x00
            },
            new int[]   // 2
            {
                0x00,0x00,0x00,0x00,0x4B,0x5B,0x64
            },
            new int[]   // 3
            {
                0x00,0x00,0x00,0x00,0x00,0x50,0x51,0x52,
                0x53,0x54,0x55,0x56,0x57,0x5C
            },
            new int[]   // 4
            {
                0x00,0x00
            },
            new int[]   // 5
            {
                0x00,0x00,0x00,0x00
            },
            new int[]   // 6
            {
                0x00,0x00,0x00,0x00,0x4A,0x4C,0x65
            },
            new int[]   // 7
            {
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00
            },
            new int[]   // 8
            {
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x43,0x46,0x4D,0x4E,0x4F,0x66,0x67,0xF8,
                0x40,0x41,0x42
            },
            new int[]   // 9
            {
                0x00,0x00,0x00,0x00,0x00,0x00,0x00
            },
            new int[]   // 10
            {
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x30,0x31
            },
            new int[]   // 11
            {
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x94,0x96,0x97,0x9C,
                0xA4,0xA5
            },
            new int[]   // 12
            {
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0xB6,0xB7
            },
            new int[]   // 13
            {
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                0x58,0x59,0x5A,0x5D,0x5E,0xAC,0xB0,0xB1,
                0xB2,0xB3,0xB4,0xB5,0xB8
            },
            new int[]   // 14
            {
                0x00,0x00,0x00,0x00,0x60,0x61
            },
            new int[]   // 15
            {
                0x00,0x00
            }
        };
        public static int[][] ActionOpcodes = new int[][]
            {
                new int[]   // 0
                {
                    0x00,0x01,0x02,0x03,0x04,0x05,0x06,0x07,
                    0x0A,0x0B,0x0C,0x13,0x15,0x3D,0x09,0xFD,
                    0xFD,0xFD,0xFD
                },
                new int[]   // 1
                {
                    0x0D,0x0E,0x0F
                },
                new int[]   // 2
                {
                    0x08,0x10,0x85,0x86,0x3A,0x3B,0xD0
                },
                new int[]   // 3
                {
                    0x26,0x27,0x28
                },
                new int[]   // 4
                {
                    0x40,0x41,0x42,0x43,0x44,0x45,0x46,0x47,
                    0x48,0x4A,0x4B
                },
                new int[]   // 5
                {
                    0x50,0x51,0x52,0x53,0x54,0x55,0x56,0x57,
                    0x58,0x59,0x5A,0x5B,0x5C,0x5D,0x7E,0x7F
                },
                new int[]   // 6
                {
                    0x60,0x61,0x62,0x63,0x64,0x65,0x66,0x67,
                    0x68,0x69,0x6A,0x6B
                },
                new int[]   // 7
                {
                    0x70,0x71,0x72,0x73,0x74,0x75,0x76,0x77,
                    0x78,0x79,0x7A,0x7B,0x7C,0x7D
                },
                new int[]   // 8
                {
                    0x80,0x81,0x82,0x83,0x84,0x87,0x90,0x91,
                    0x92,0x93,0x94,0x95,0x88,0x89,0x8A,0x98,0x99
                },
                new int[]   // 9
                {
                    0x9B,0x9C,0x9D,0x9E,0xFD
                },
                new int[]   // 10
                {
                    0xA0,0xA4,0xA8,0xA9,0xAA,0xAB,0xB0,0xB1,
                    0xB2,0xB3,0xB5,0xB7,0xBB,0xBC,0xBD,0xC2,
                    0xD6,0xD8,0xDC,0xE0,0xE1,0xE4,0xE5,0xE8,
                    0xE9,0xFD
                },
                new int[]   // 11
                {
                    0xA3,0xA7,0xAC,0xAD,0xAE,0xAF,0xB4,0xB6,
                    0xB8,0xB9,0xBA,0xC0,0xC1,0xC3,
                    0xC4,0xC5,0xC6,0xBF,0xBE,0xCA,0xCB,0xDB,0xDF,0xE2,
                    0xE3,0xE6,0xE7,0xEA,0xEB,0xEC,0xED,0xEE,
                    0xEF,0xFD,0xFD,0xFD,0xFD,0xFD,0xFD
                },
                new int[]   // 12
                {
                    0xD2,0xD3,0xD4,0xD7,0xF9,0xFA
                },
                new int[]   // 13
                {
                    0xF2,0xF3,0xF4,0xF5,0xF6,
                    0xF7,0xF8,0x11,0x12,0x14,0xFD,0xFD,0xFD,0xFD,0xFD,0xFD,
                    0xFD,0xFD,0xFD,0xFD,0xFD
                },
                new int[]   // 14
                {
                    0xF0,0xF1
                },
                new int[]   // 15
                {
                    0xFE,0xFF
                },
                new int[]   // 16 Objects
                {
                    0x3E,0x3F,0xFD,0xFD
                },
                new int[]   // 17 Unknown ASM
                {
                    0x21,0x22,0x2A,0x3C
                }
            };
        public static int[][] ActionParams = new int[][]
            {
                new int[]   // 0
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x01,
                    0x02,0x03,0x0F
                },
                new int[]   // 1
                {
                    0x00,0x00,0x00
                },
                new int[]   // 2
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00
                },
                new int[]   // 3
                {
                    0x00,0x00,0x00
                },
                new int[]   // 4
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00
                },
                new int[]   // 5
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00
                },
                new int[]   // 6
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00
                },
                new int[]   // 7
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00
                },
                new int[]   // 8
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00
                },
                new int[]   // 9
                {
                    0x00,0x00,0x00,0x00,0x9E
                },
                new int[]   // 10
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0xB6
                },
                new int[]   // 11
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0xB0,0xB1,0xB2,0xB3,0xB4,0xB5
                },
                new int[]   // 12
                {
                    0x00,0x00,0x00,0x00,0x00,0x00
                },
                new int[]   // 13
                {
                    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x00,0x00,0x04,0x05,0x06,0x07,0x08,0x09,
                    0x0A,0x0B,0x0C,0x0D,0x0E
                },
                new int[]   // 14
                {
                    0x00,0x00
                },
                new int[]   // 15
                {
                    0x00,0x00
                },
                new int[]   // 16 Objects
                {
                    0x00,0x00,0x3E,0x3D
                },
                new int[]   // 17 Unknown ASM
                {
                    0x00,0x00,0x00,0x00
                },
            };
        public static string[] EventNames(int index)
        {
            switch (index)
            {
                case 0:
                    return new string[] 
                    {
                    "Objects (allies, NPCs, screens)...",      // 0x00 - 0x2F
                    "Freeze all NPCs until return",			// 0x30
                    "Unfreeze all NPCs",			// 0x31
                    "If object {xx} present in current level...", // 0x32
                    "If Mario on top of object {xx}...",    // 0x39
                    "If object A & B < (x,y) steps and infinite Z coords apart...",			// 0x3A
                    "If object A & B < (x,y,z) steps apart...",			// 0x3B
                    "If Mario is in the air...",			// 0x3D
                    "Create NPC @ object {xx}'s (x,y,z)...",			// 0x3E
                    "Create NPC @ (x,y,z) of $7010-15...",			// 0x3F
                    "If Mario is on top of an object...",			// 0x42
                    "Object {xx}'s presence in level {xx} is...",			// 0xF2
                    "Object {xx}'s event trigger in level {xx} is...",			// 0xF3
                    "Summon object @ $70A8 to current level",			// 0xF4
                    "Remove object @ $70A8 in current level",			// 0xF5
                    "Enable event trigger for object @ 70A8",			// 0xF6
                    "Disable event trigger for object @ 70A8",			// 0xF7
                    "If object {xx} is present in level {xx}...",			// 0xF8
                    /********FD OPTIONS********/
                    "Remember last object",			// 0x32
                    "If object {xx}'s action script running...",			// 0x33
                    "If object {xx} is underwater...",			// 0x34
                    "If object {xx} is in the air...",			// 0x3D
                    "Create NPC + event {xx} @ (x,y,z) of $7010-15...",			// 0x3E
                    "If object {xx}'s event trigger in level {xx} is...",  // 0xF0
                    "Mario glowing begins",			// 0xF9
                    "Mario glowing stops"			// 0xFA
                                        };
                case 1:
                    return new string[] 
                    {
                    "Enable buttons {xx} only, reset @ return...",			// 0x34
                    "Enable buttons {xx} only...",			// 0x35
                                        };
                case 2:
                    return new string[]
                    {
                    "Add or remove character {xx} in party...",			// 0x36
                    "Equip item {xx} to character {xx}...",			// 0x54
                    "Character {xx}'s HP -= memory $7000",			// 0x56
                    "Character {xx} learns {xx}",			// 0xCE
                    /********FD OPTIONS********/
                    "Experience += experience packet",			// 0x4B
                    "Restore all HP",			// 0x5B
                    "Experience packet = memory $7000"			// 0x64
                    };
                case 3:
                    return new string[] 
                    { 
                    "Store 1 of item {xx} to inventory...",			// 0x50
                    "Remove 1 of item {xx} from inventory...",			// 0x51
                    "Coins += ...",			// 0x52
                    "Frog coins += ...",			// 0x53
                    "FP -= memory $7000",			// 0x57
                    /********FD OPTIONS********/
                    "Store memory $70A7 to item inventory",			// 0x50
                    "Store memory $70A7 to equipment inventory",			// 0x51
                    "Coins += memory $7000",			// 0x52
                    "Coins -= memory $7000",			// 0x53
                    "Frog coins += memory $7000",			// 0x54
                    "Frog coins -= memory $7000",			// 0x55
                    "Current FP += memory $7000",			// 0x56
                    "Maximum FP += memory $7000",			// 0x57
                    "Restore all FP"			// 0x5C
                    };
                case 4:
                    return new string[] 
                    { 
                    "Engage in battle with pack @ $700E",			// 0x49
                    "Engage in battle with pack {xx}..."			// 0x4A
                    };
                case 5:
                    return new string[] 
                    { 
                    "Open location...",			// 0x4B
                    "Open level...",			// 0x68
                    "Apply tile mod to level...",			// 0x6A
                    "Apply solid mod to level..."			// 0x6B
                    };
                case 6:
                    return new string[] 
                    { 
                    "Open shop menu...",			// 0x4C
                    "Open menu/run event sequence...",			// 0x4F
                    "Reset game, choose game",			// 0xFB
                    "Reset game",			// 0xFC
                    /********FD OPTIONS********/
                    "Open save game menu",			// 0x4A
                    "Run menu tutorial...",			// 0x4C
                    "Run level-up bonus sequence"			// 0x65
                    };
                case 7:
                    return new string[] 
                    { 
                    "Run dialogue...",			// 0x60
                    "Run dialogue @ memory $7000...",			// 0x61
                    "Run dialogue for {xx} duration...",			// 0x62
                    "Append to dialogue @ memory $7000...",			// 0x63
                    "Close dialogue",			// 0x64
                    "Un-sync dialogue",			// 0x65
                    "If dialogue option B selected...",			// 0x66
                    "If dialogue option B / C selected..."			// 0x67
                    };
                case 8:
                    return new string[] 
                    { 
                    "Run background event...",			// 0x40
                    "Run background event, pause...",         // 0x44
                    "Run background event, pause (return on exit)...",         // 0x45
                    "Stop background event...",  // 0x46
                    "Resume background event...", // 0x47
                    "Run event sequence...",			// 0x4E
                    "Run event...",			// 0xD0
                    "Run event as subroutine...",			// 0xD1
                    /********FD OPTIONS********/
                    "Stop all background events", // 0x43
                    "Run event at return...",  // 0x46
                    "Run star piece sequence...",			// 0x4D
                    "Run moleville mountain sequence",			// 0x4E
                    "Run moleville mountain intro sequence",			// 0x4F
                    "Display pre-game intro title...",			// 0x66
                    "Run ending credit sequence",			// 0x67
                    "Exor crashes into keep",			// 0xF8
                    "Move script to main thread",    // 0x40
                    "Move script to background thread 1",    // 0x41
                    "Move script to background thread 2"    // 0x42
                    };
                case 9:
                    return new string[] 
                    { 
                    "Jump to address...",			// 0xD2
                    "Jump to subroutine...",			// 0xD3
                    "Loop start, count = ...",			// 0xD4
                    "Loop start, timer = ...",          // 0xD5
                    "Loop end",			// 0xD7
                    "Jump to start of script",			// 0xF9
                    "Jump to start of script"			// 0xFA
                    };
                case 10:
                    return new string[] 
                    {
                    "Fade in from black (sync)",			// 0x70
                    "Fade in from black (async)",			// 0x71
                    "Fade in from black (sync) for {xx} duration...",			// 0x72
                    "Fade in from black (async) for {xx} duration...",			// 0x73
                    "Fade out to black (sync)",			// 0x74
                    "Fade out to black (async)",			// 0x75
                    "Fade out to black (sync) for {xx} duration...",			// 0x76
                    "Fade out to black (async) for {xx} duration...",			// 0x77
                    "Fade in from {xx} color...",			// 0x78
                    "Fade out to {xx} color...",			// 0x79
                    "Star mask, expand from screen center",			// 0x7A
                    "Star mask, shrink to screen center",			// 0x7B
                    "Circle mask, expand from screen center",			// 0x7C
                    "Circle mask, shrink to screen center",			// 0x7D
                    "Initiate battle mask",			// 0x7E
                    "Tint layers {xx} with {xx} color...",			// 0x80
                    "Priority set = ...",			// 0x81
                    "Reset priority set",			// 0x82
                    "Screen flashes with {xx} color...",			// 0x83
                    "Pixellate layers {xx} by {xx} amount...",			// 0x84
                    "Palette set morphs to {xx} set...",			// 0x89
                    "Palette set = ...",			// 0x8A
                    "Circle mask, shrink to object {xx} (non-static)...", // 0x87
                    "Circle mask, shrink to object {xx} (static)...",	    // 0x8F
                    /********FD OPTIONS********/
                    "Unfreeze screen",			// 0x30
                    "Freeze screen"			// 0x31
                    };
                case 11:
                    return new string[] 
                    {
                    "Play music {xx} at current volume...",			// 0x90
                    "Play music {xx} at default volume...",			// 0x91
                    "Fade in music {xx} ...",			// 0x92
                    "Fade out current music",			// 0x93
                    "Stop current music",			// 0x94
                    "Fade out current music to {xx} volume...",			// 0x95
                    "Adjust music tempo by {xx} amount...",			// 0x97
                    "Adjust music pitch by {xx} amount...",			// 0x98
                    "Stop current sound",			// 0x9B
                    "Play {xx} sound (ch.6,7)...",			// 0x9C
                    "Play {xx} sound (ch.6,7) with {xx} speaker balance...",			// 0x9D
                    "Fade out current sound to {xx} volume...",			// 0x9E
                    /********FD OPTIONS********/
                    "Deactivate {xx} sound channels...",        // 0x94
                    "If audio memory $69 >= ...",        // 0x96
                    "If audio memory $69 = ...",        // 0x97
                    "Play {xx} sound (ch.4,5)...",             // 0x9E
                    "Lower current music tempo",			// 0xA4
                    "Slide current music tempo to default"			// 0xA5
                    };
                case 12:
                    return new string[] 
                    { 
                    "Memory $704x bit {xx} set...",			// 0xA0-0xA2
                    "Memory $704x bit {xx} clear...",			// 0xA4-0xA6
                    "Memory $70Ax = ...",			// 0xA8
                    "Memory $70Ax += ...",			// 0xA9
                    "Memory $70Ax += 1...",			// 0xAA
                    "Memory $70Ax -= 1...",			// 0xAB
                    "Memory $7xxx = ...",         // 0xB0
                    "Memory $7xxx += ...",			// 0xB1
                    "Memory $7xxx += 1...",// 0xB2
                    "Memory $7xxx -= 1...",// 0xB3
                    "Memory $70Ax = memory $7000...",         // 0xB5
                    "Memory $7xxx = random # between 0 and {xx}...",			// 0xB7
                    "Memory $7xxx = memory $7000...",        // 0xBB
                    "Memory $7xxx = memory $7xxx...",      // 0xBC
                    "Memory $7xxx <=> memory $7xxx...",			// 0xBD
                    "Memory $7xxx compare to {xx}...",			// 0xC2
                    "Object memory = memory $7xxx...",   // 0xD6
                    "If memory $704x bit {xx} set...",			// 0xD8-0xDA
                    "If memory $704x bit {xx} clear...",// 0xDC-0xDE
                    "If memory $70Ax = ...",			// 0xE0
                    "If memory $70Ax != ...",			// 0xE1
                    "If memory $7xxx = ...",			// 0xE4
                    "If memory $7xxx != ...",			// 0xE5
                    "If random # between 0 and 255 > 128...",			// 0xE8
                    "If random # between 0 and 255 > 66...",			// 0xE9
                    /********FD OPTIONS********/
                    "Memory $7xxx shift left {xx} times...",			// 0xB6
                    "Generate random # between 0 and memory $7xxx..."			// 0xB7
                    };
                case 13:
                    return new string[] 
                    {
                    "Memory $7000 = party capacity",			// 0x37
                    "Memory $7000 = character in {xx} slot...",			// 0x38
                    "Memory $7000 = # of open item slots",			// 0x55
                    "Memory $7000 = current FP",			// 0x58
                    "Memory $704x [x is @ $7000] bit {xx} set...",			// 0xA3
                    "Memory $704x [x is @ $7000] bit {xx} clear...",			// 0xA7
                    "Memory $7000 = ...",			// 0xAC
                    "Memory $7000 += ...",			// 0xAD
                    "Memory $7000 += 1",			// 0xAE
                    "Memory $7000 -= 1",			// 0xAF
                    "Memory $7000 = memory $70Ax...",			// 0xB4
                    "Memory $7000 = random # between 0 and {xx}...",			// 0xB6
                    "Memory $7000 += memory $7xxx...",			// 0xB8
                    "Memory $7000 -= memory $7xxx...",			// 0xB9
                    "Memory $7000 = memory $7xxx...",			// 0xBA
                    "Memory $7000 compare to {xx}...",			// 0xC0
                    "Memory $7000 compare to $7xxx...",			// 0xC1
                    "Memory $7000 = current level",			// 0xC3
                    "Memory $7000 = object's X coord...",			// 0xC4
                    "Memory $7000 = object's Y coord...",			// 0xC5
                    "Memory $7000 = object's Z coord...",			// 0xC6
                    "Memory $7010-15 = (x,y,z) of object...",          // 0xC7
                    "Memory $7016-1B = (x,y,z) of object...",          // 0xC8
                    "Memory $7010-15 = memory $7016-1B",			// 0xBF
                    "Memory $7016-1B = memory $7010-15",			// 0xBE
                    "Memory $7000 = F coord of object...",            // 0xC9
                    "Memory $7000 = pressed button",			// 0xCA
                    "Memory $7000 = tapped button",			// 0xCB
                    "If Memory $704x [x @ $7000] bit {xx} set...",			// 0xDB
                    "If Memory $704x [x @ $7000] bit {xx} clear...",			// 0xDF
                    "If memory $7000 =...",			// 0xE2
                    "If memory $7000 !=...",			// 0xE3
                    "If memory $7000 all bits {xx} clear...",			// 0xE6
                    "If memory $7000 any bits {xx} set...",			// 0xE7
                    "If loaded memory = 0...",			// 0xEA
                    "If loaded memory != 0...",			// 0xEB
                    "If comparison result is: >=...",			// 0xEC
                    "If comparison result is: <...",			// 0xED
                    "If loaded memory < 0...",			// 0xEE
                    "If loaded memory >= 0...",			// 0xEF
                    /********FD OPTIONS********/
                    "Memory $7000 = quantity of item {xx} in inventory...",			// 0x58
                    "Memory $7000 = coins",			// 0x59
                    "Memory $7000 = frog coins",			// 0x5A
                    "Memory $7000 = equipment {xx} of {xx} character...",			// 0x5D
                    "Memory $7000 = quantity of item @ memory $70A7",			// 0x5E
                    "Memory $7000 = memory $7Fxxxx...",			// 0xAC
                    "Memory $7000 &= {xx}...",			// 0xB0
                    "Memory $7000 |= {xx}...",			// 0xB1
                    "Memory $7000 ^= {xx}...",			// 0xB2
                    "Memory $7000 &= memory $7xxx...",			// 0xB3
                    "Memory $7000 |= memory $7xxx...",			// 0xB4
                    "Memory $7000 ^= memory $7xxx...",			// 0xB5
                    "Memory $7000 = Moleville Mountain timer"			// 0xB8
                    };
                case 14:
                    return new string[] 
                    { 
                    "Pause script if menu open",           // 0x5B
                    "Pause script until screen effect done", // 0x7F
                    "Pause script for {xx} frames...",			// 0xF0
                    "Pause script for {xxxx} frames...",			// 0xF1
                    /********FD OPTIONS********/
                    "Pause script, resume on next dialogue page A",			// 0x60
                    "Pause script, resume on next dialogue page B",			// 0x61
                    };
                case 15:
                    return new string[] 
                    {
                    "Return",			// 0xFE
                    "Return all"			// 0xFF
                    };
                default:
                    return new string[] { };
            }
        }
        public static string[] ActionNames(int index)
        {
            switch (index)
            {
                case 0:
                    return new string[] 
                    { 
                    "Visibility on",			// 0x00
                    "Visibility off",			// 0x01
                    "Sequence playback on",			// 0x02
                    "Sequence playback off",			// 0x03
                    "Sequence looping on",			// 0x04
                    "Sequence looping off",			// 0x05
                    "Fixed F coord on",			// 0x06
                    "Fixed F coord off",			// 0x07
                    "Solidity bits = ...",			// 0x0A
                    "Solidity set {xx} bits...",			// 0x0B
                    "Solidity clear {xx} bits...",			// 0x0C
                    "VRAM priority = ...",			// 0x13
                    "Movement set {xx} bits...",			// 0x15
                    "If in air...",			// 0x3D
                    "Reset properties",			// 0x09
                    /********FD OPTIONS********/
                    "Shadow on/off",			// 0x00 + 0x01
                    "Floating on",			// 0x02
                    "Floating off",			// 0x03
                    "Priority = ...",			// 0x0F
                    };
                case 1:
                    return new string[] 
                    { 
                    "Palette row = ...",			// 0x0D
                    "Palette row += ...",			// 0x0E
                    "Palette row += 1",			// 0x0F
                    };
                case 2:
                    return new string[]
                    {
                    "Animation/sequence = ...",			// 0x08
                    "Walking/sequence speed = ...",			// 0x10
                    "Maximize sequence speed",			// 0x85
                    "Maximize sequence speed",			// 0x86
                    "If object A & B < (x,y) steps apart...",			// 0x3A
                    "If object A & B < (x,y) steps apart & same Z coord...",	// 0x3B
                    "Action script = ...",			// 0xD0
                    };
                case 3:
                    return new string[] 
                    { 
                    "Embedded animation routine ($26)...",			// 0x26
                    "Embedded animation routine ($27)...",			// 0x27
                    "Embedded animation routine ($28)...",			// 0x28
                    };
                case 4:
                    return new string[] 
                    { 
                    "Walk 1 step east",			// 0x40
                    "Walk 1 step southeast",			// 0x41
                    "Walk 1 step south",			// 0x42
                    "Walk 1 step southwest",			// 0x43
                    "Walk 1 step west",			// 0x44
                    "Walk 1 step northwest",			// 0x45
                    "Walk 1 step north",			// 0x46
                    "Walk 1 step northeast",			// 0x47
                    "Walk 1 step in F direction",			// 0x48
                    "Z coord += 1 step",			// 0x4A
                    "Z coord -= 1 step",			// 0x4B
                    };
                case 5:
                    return new string[] 
                    { 
                    "Walk {xx} steps east...",			// 0x50
                    "Walk {xx} steps southeast...",			// 0x51
                    "Walk {xx} steps south...",			// 0x52
                    "Walk {xx} steps southwest...",			// 0x53
                    "Walk {xx} steps west...",			// 0x54
                    "Walk {xx} steps northwest...",			// 0x55
                    "Walk {xx} steps north...",			// 0x56
                    "Walk {xx} steps northeast...",			// 0x57
                    "Walk {xx} steps in F direction...",			// 0x58
                    "Walk 20 steps in F direction...",			// 0x59
                    "Z coord += {xx} steps...",			// 0x5A
                    "Z coord -= {xx} steps...",			// 0x5B
                    "Z coord += 20 steps",			// 0x5C
                    "Z coord -= 20 steps",			// 0x5D
                    "Jump at {xx} velocity...",			// 0x7E
                    "Jump (+SFX) at {xx} velocity...",			// 0x7F
                    };
                case 6:
                    return new string[] 
                    { 
                    "Walk {xx} pixels east...",			// 0x60
                    "Walk {xx} pixels southeast...",			// 0x61
                    "Walk {xx} pixels south...",			// 0x62
                    "Walk {xx} pixels southwest...",			// 0x63
                    "Walk {xx} pixels west...",			// 0x64
                    "Walk {xx} pixels northwest...",			// 0x65
                    "Walk {xx} pixels north...",			// 0x66
                    "Walk {xx} pixels northeast...",			// 0x67
                    "Walk {xx} pixels in F direction...",			// 0x68
                    "Walk 16 pixels in F direction",			// 0x69
                    "Z coord += {xx} pixels...",			// 0x6A
                    "Z coord -= {xx} pixels...",			// 0x6B
                    };
                case 7:
                    return new string[] 
                    { 
                    "Face east",			// 0x70
                    "Face southeast",			// 0x71
                    "Face south",			// 0x72
                    "Face southwest",			// 0x73
                    "Face west",			// 0x74
                    "Face northwest",			// 0x75
                    "Face north",			// 0x76
                    "Face northeast",			// 0x77
                    "Face Mario",			// 0x78
                    "Turn clockwise 45°",			// 0x79
                    "Turn in random direction",			// 0x7A
                    "Turn clockwise 45° {xx} times...",			// 0x7B
                    "Face east",			// 0x7C
                    "Face southwest",			// 0x7D
                    };
                case 8:
                    return new string[] 
                    { 
                    "Walk to (x,y)...",			// 0x80
                    "Walk (x,y) steps...",			// 0x81
                    "Transfer to (x,y)...",			// 0x82
                    "Transfer (x,y) steps...",			// 0x83
                    "Transfer (x,y) pixels...",			// 0x84
                    "Transfer to (x,y) of object...",			// 0x87
                    "Bounce to (x,y)...",			// 0x90
                    "Bounce (x,y) steps...",			// 0x91
                    "Transfer to (x,y,z)...",			// 0x92
                    "Transfer (x,y,z) steps...",			// 0x93
                    "Transfer (x,y,z) pixels...",			// 0x94
                    "Transfer to (x,y,z) of object...",			// 0x95
                    "Walk to (x,y) of Mem $7016-1B",    // 0x88
                    "Transfer to (x,y) of Mem $7016-1B",    // 0x89
                    "Shift to (x,y) of Mem $7016-1B",    // 0x8A
                    "Walk to (x,y,z) of Mem $7016-1B",    // 0x98
                    "Transfer to (x,y,z) of Mem $7016-1B",    // 0x99
                    };
                case 9:
                    return new string[] 
                    { 
                    "Stop current sound",			// 0x9B
                    "Play sound: {xx} (ch.6,7)...",			// 0x9C
                    "Play sound: {xx} (ch.6,7), speaker balance {xx}...",			// 0x9D
                    "Fade out current sound to volume {xx}...",			// 0x9E
                    "Play sound: {xx} (ch.4,5)...",			// 0x9C
                    };
                case 10:
                    return new string[] 
                    { 
                    "Memory $704x bit {xx} set...",			// 0xA0-0xA2
                    "Memory $704x bit {xx} clear...",			// 0xA4-0xA6
                    "Memory $70Ax = ...",			// 0xA8
                    "Memory $70Ax += ...",			// 0xA9
                    "Memory $70Ax += 1...",// 0xAA
                    "Memory $70Ax -= 1...",// 0xAB
                    "Memory $7xxx = ...",         // 0xB0
                    "Memory $7xxx += ...",			// 0xB1
                    "Memory $7xxx += 1...",// 0xB2
                    "Memory $7xxx -= 1...",// 0xB3
                    "Memory $70Ax = memory $700C...",         // 0xB5
                    "Memory $7xxx = random # between 0 and {xx}...",			// 0xB7
                    "Memory $7xxx = memory $700C...",        // 0xBB
                    "Memory $7xxx = memory $7xxx...",      // 0xBC
                    "Memory $7xxx <=> memory $7xxx...",			// 0xBD
                    "Memory $7xxx compare to...",			// 0xC2
                    "Memory $7xxx load...",   // 0xD6
                    "If memory $704x bit {xx} set...",			// 0xD8-0xDA
                    "If memory $704x bit {xx} clear...",// 0xDC-0xDE
                    "If memory $70Ax = ...",			// 0xE0
                    "If memory $70Ax != ...",			// 0xE1
                    "If memory $7xxx = ...",			// 0xE4
                    "If memory $7xxx != ...",			// 0xE5
                    "If random # between 0 and 255 > 128...",			// 0xE8
                    "If random # between 0 and 255 > 66...",			// 0xE9
                    /********FD OPTIONS********/
                    "Memory $7xxx shift left {xx} times...",			// 0xB6
                    };
                case 11:
                    return new string[] 
                    { 
                    "Memory $704x [x is @ $700C] bit set",			// 0xA3
                    "Memory $704x [x is @ $700C] bit clear",			// 0xA7
                    "Memory $700C = ...",			// 0xAC
                    "Memory $700C += ...",			// 0xAD
                    "Memory $700C += 1",			// 0xAE
                    "Memory $700C -= 1",			// 0xAF
                    "Memory $700C = memory $70Ax...",			// 0xB4
                    "Memory $700C = random # between 0 and {xx}...",			// 0xB6
                    "Memory $700C += memory $7xxx...",			// 0xB8
                    "Memory $700C -= memory $7xxx...",			// 0xB9
                    "Memory $700C = memory $7xxx...",			// 0xBA
                    "Memory $700C compare to {xx}...",			// 0xC0
                    "Memory $700C compare to memory $7xxx...",			// 0xC1
                    "Memory $700C = current level",			// 0xC3
                    "Memory $700C = object's X coord...",			// 0xC4
                    "Memory $700C = object's Y coord...",			// 0xC5
                    "Memory $700C = object's Z coord...",			// 0xC6
                    "Memory $7010-15 = memory $7016-1B",			// 0xBF
                    "Memory $7016-1B = memory $7010-15",			// 0xBE
                    "Memory $700C = pressed button",			// 0xCA
                    "Memory $700C = tapped button",			// 0xCB
                    "If Memory $704x [x @ $700C] bit set...",			// 0xDB
                    "If Memory $704x [x @ $700C] bit clear...",			// 0xDF
                    "If memory $700C =...",			// 0xE2
                    "If memory $700C !=...",			// 0xE3
                    "If memory $700C all bits {xx} clear...",			// 0xE6
                    "If memory $700C any bits {xx} set...",			// 0xE7
                    "If loaded memory = 0...",			// 0xEA
                    "If loaded memory != 0...",			// 0xEB
                    "If comparison result is: >=...",			// 0xEC
                    "If comparison result is: <...",			// 0xED
                    "If loaded memory < 0...",			// 0xEE
                    "If loaded memory >= 0...",			// 0xEF
                    /********FD OPTIONS********/
                    "Memory $700C &= {xx}...",			// 0xB0
                    "Memory $700C |= {xx}...",			// 0xB1
                    "Memory $700C ^= {xx}...",			// 0xB2
                    "Memory $700C &= memory $7xxx...",			// 0xB3
                    "Memory $700C |= memory $7xxx...",			// 0xB4
                    "Memory $700C ^= memory $7xxx...",			// 0xB5
                    };
                case 12:
                    return new string[]
                    {
                    "Jump to address...",			// 0xD2
                    "Jump to subroutine...",			// 0xD3
                    "Loop start, count = ...",			// 0xD4
                    "Loop end",			// 0xD7
                    "Jump to start of script",			// 0xF9
                    "Jump to start of script",			// 0xFA
                    };
                case 13:
                    return new string[]
                    {
                    "Object {xx}'s presence in level {xx} is...",			// 0xF2
                    "Object {xx}'s event trigger is...",			// 0xF3
                    "Summon object @ $70A8 to current level",			// 0xF4
                    "Remove object @ $70A8 in current level",			// 0xF5
                    "Enable event trigger for object @ 70A8",			// 0xF6
                    "Disable event trigger for object @ 70A8",			// 0xF7
                    "If object {xx} is present in level {xx}...",			// 0xF8
                    "Object memory $0D set {xx} bits...",			// 0x11
                    "Object memory $0B set {xx} bits...",			// 0x12
                    "Object memory $0E set {xx} bits...",			// 0x14
                    /********FD OPTIONS********/
                    "Object memory $0E set bit 4",			// 0x04
                    "Object memory $0E clear bit 4",			// 0x05
                    "Object memory $0E set bit 5",			// 0x06
                    "Object memory $0E clear bit 5",			// 0x07
                    "Object memory $09 set bit 7",			// 0x08
                    "Object memory $09 clear bit 7",			// 0x09
                    "Object memory $08 set bit 4",			// 0x0A
                    "Object memory $08 clear bit 3,4",			// 0x0B
                    "Object memory $30 clear bit 4",			// 0x0C
                    "Object memory $30 set bit 4",			// 0x0D
                    "Object memory $09 clear bit 4,6, set bit 5",			// 0x0E
                    };
                case 14:
                    return new string[] 
                    { 
                    "Pause script for {xx} frames...",			// 0xF0
                    "Pause script for {xxxx} frames...",			// 0xF1
                    };
                case 15:
                    return new string[] 
                    { 
                    "Return queue",			// 0xFE
                    "Return all"			// 0xFF
                    };
                case 16:
                    return new string[]
                    {
                    "Create NPC @ object {xx}'s (x,y,z)...",			// 0x3E
                    "Create NPC @ (x,y,z) of $7010-15...",			// 0x3F
                    /********FD OPTIONS********/
                    "Create NPC + event {xx} @ (x,y,z) of $7010-15...",			// 0x3E
                    "If object {xx} is in the air...",			// 0x3D
                    };
                case 17:
                    return new string[]
                    {
                    "BPL: 26,x 27,x 28,x",			// 0x21
                    "BMI: 26,x 27,x 28,x",			// 0x22
                    "BPL: 26,x 27,x",			// 0x2A
                    "If unknown condition...",			// 0x3C
                    };
                default:
                    return new string[] { };
            }
        }
        #endregion
        #region Keystrokes
        public static string[] Keystrokes = new string[]
        {
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            " ","!","“","”","", "", "‘","’","(",")","", "", ",","-",".","/",
			"0","1","2","3","4","5","6","7","8","9","~","", "", "", "", "?",
            "@","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O",
			"P","Q","R","S","T","U","V","W","X","Y","Z","", "", "", "", "", 
            "", "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o",
			"p","q","r","s","t","u","v","w","x","y","z","", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", ":",";",
			"<",">","", "#","+","×","%","", "", "", "*","'","&","", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
        };
        public static string[] KeystrokesMenu = new string[]
        {
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            " ","", "", "", "", "", "", "", "", "", ".",":",",","", ".","/",
            "0","1","2","3","4","5","6","7","8","9","~","", "", "", "", "?",
            "", "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O",
            "P","Q","R","S","T","U","V","W","X","Y","Z","", "", "", "", "", 
            "", "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o",
            "p","q","r","s","t","u","v","w","x","y","z","!","#","-","’","", 
            ":",".","“","”","", "", "", "", "", "", "", "", "", "", ":",";",
            "<",">","", "#","+","×","%","", "", "", "*","'","", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
        };
        public static string[] KeystrokesDesc = new string[]
        {
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
			"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            " ","!","“","”","", "", "‘","’","(",")","", "", ",","-",".","/",
            "0","1","2","3","4","5","6","7","8","9","~","", "", "", "", "?",
            "", "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O",
            "P","Q","R","S","T","U","V","W","X","Y","Z","", "", "", "", "", 
            "", "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o",
            "p","q","r","s","t","u","v","w","x","y","z","", "", "-","’","", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "&","", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
        };
        public static string[] KeystrokesBonus = new string[]
        {
			"G","H","E","F","C","D","A","B","I","J","K","L","M","N","O","P",
			"W","X","U","V","S","T","Q","R","Y","Z","!","?",".","*","@",""
        };
        #endregion
        #endregion
        #region Functions
        // numerize
        public static string Numerize(string item, int index, int length)
        {
            return "{" + index.ToString("d" + length) + "}  " + item;
        }
        public static string Numerize(string[] list, int index, int length)
        {
            return "{" + index.ToString("d" + length) + "}  " + list[index];
        }
        public static string Numerize(string[] list, int index)
        {
            if (index >= list.Length)
                return "ERROR: OUT OF BOUNDS INDEX";
            int length = (list.Length - 1).ToString().Length;
            return "{" + index.ToString("d" + length) + "}  " + list[index];
        }
        public static string[] Numerize(int length, string[] list)
        {
            string[] temp = new string[list.Length];
            for (int i = 0; i < list.Length; i++)
                temp[i] = "{" + i.ToString("d" + length) + "}  " + list[i];
            return temp;
        }
        public static string[] Numerize(string[] list)
        {
            int length = (list.Length - 1).ToString().Length;
            string[] temp = new string[list.Length];
            for (int i = 0; i < list.Length; i++)
                temp[i] = "{" + i.ToString("d" + length) + "}  " + list[i];
            return temp;
        }
        public static string[] NumerizeHex(string[] list)
        {
            int length = (list.Length - 1).ToString().Length;
            string[] temp = new string[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = "{" + i.ToString("X" + length).Substring(1) + "}  ";
                if (!list[i].StartsWith("{"))
                    temp[i] += list[i];
            }
            return temp;
        }

        public static string[] Numerize(int start, int end, string[] list)
        {
            int length = (list.Length - 1).ToString().Length;
            string[] temp = new string[end - start];
            for (int i = start; i < list.Length && i < end; i++)
                temp[i - start] = "{" + i.ToString("d" + length) + "}  " + list[i];
            return temp;
        }
        public static string[] Numerize(StringCollection list)
        {
            return Numerize(Convert(list));
        }
        public static string Numerize(StringCollection list, int index)
        {
            return Numerize(Convert(list), index);
        }
        public static string[] Numerize(object[] list)
        {
            return Numerize(Convert(list));
        }
        public static string RemoveTag(string item)
        {
            if (item.StartsWith("{"))
            {
                while (item.Length > 0 && !item.StartsWith(" "))
                    item = item.Remove(0, 1);
                item = item.Trim();
            }
            return item;
        }
        // conversion
        public static string[] Convert(StringCollection list)
        {
            string[] temp = new string[list.Count];
            list.CopyTo(temp, 0);
            return temp;
        }
        public static string[] Convert(object[] list)
        {
            string[] temp = new string[list.Length];
            for (int i = 0; i < list.Length; i++)
                temp[i] = list[i].ToString();
            return temp;
        }
        /// <summary>
        /// Converts any array to a string array.
        /// </summary>
        /// <param name="list">The array to convert.</param>
        /// <param name="length">The number of elements that the string array will contain.</param>
        /// <param name="startIndex">The index of each string to start at.</param>
        /// <returns></returns>
        public static string[] Convert(object[] list, int length, int startIndex)
        {
            string[] temp = new string[length];
            for (int i = 0; i < list.Length && i < length; i++)
                temp[i] = list[i].ToString().Substring(startIndex);
            return temp;
        }
        public static string[] Convert(object[] list, int length)
        {
            return Convert(list, length, 0);
        }
        public static string[] Convert(ComboBox.ObjectCollection list)
        {
            object[] array = new object[list.Count];
            list.CopyTo(array, 0);
            return Convert(array, list.Count, 0);
        }
        // transformation
        public static string[] Resize(string[] list, int count)
        {
            string[] temp = new string[count];
            for (int i = 0; i < list.Length && i < count; i++)
                temp[i] = list[i];
            return temp;
        }
        public static string[] Copy(string[] source)
        {
            if (source == null)
                return null;
            string[] temp = new string[source.Length];
            source.CopyTo(temp, 0);
            return temp;
        }
        public static string ToTitleCase(string source)
        {
            TextInfo textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(source.ToLower());
        }
        public static int IndexOf(string[] list, string item)
        {
            for (int i = 0; i < list.Length; i++)
                if (list[i] == item)
                    return i;
            return -1;
        }
        #endregion

        /// <summary>
        /// Resizes a label array if the configured count exceeds its current length.
        /// New entries are filled with numbered placeholders.
        /// </summary>
        private static string[] ResizeIfNeeded(string[] array, int requiredCount, string prefix)
        {
            if (array.Length >= requiredCount)
                return array;
            string[] resized = new string[requiredCount];
            Array.Copy(array, resized, array.Length);
            for (int i = array.Length; i < requiredCount; i++)
                resized[i] = prefix + i;
            return resized;
        }

        /// <summary>
        /// Applies all custom label overlays from Settings to the simple field arrays.
        /// Call this after loading settings or when settings change.
        /// </summary>
        public static void ApplyCustomLabelOverlays()
        {
            var settings = Properties.Settings.Default;
            // Resize arrays if RomConfig counts exceed hardcoded sizes
            NPCPackets = ResizeIfNeeded(NPCPackets, RomConfig.NPCPacketCount, "Packet ");
            RomConfig.ApplyCustomLabels(SpriteNames, settings.CustomSpriteNames);
            RomConfig.ApplyCustomLabels(NPCPackets, settings.CustomPacketNames);
            RomConfig.ApplyCustomLabels(BattleEventNames, settings.CustomBattleEventNames);
            RomConfig.ApplyCustomLabels(LevelNames, settings.CustomLevelNames);
            RomConfig.ApplyCustomLabels(MusicNames, settings.CustomMusicNames);
            RomConfig.ApplyCustomLabels(SoundNames, settings.CustomSoundNames);
            RomConfig.ApplyCustomLabels(BattleSoundNames, settings.CustomBattleSoundNames);
            RomConfig.ApplyCustomLabels(BattlefieldNames, settings.CustomBattlefieldNames);
            RomConfig.ApplyCustomLabels(EffectNames, settings.CustomEffectNames);
            // Force re-evaluation of lazy-init properties by resetting them
            monsterBehaviors = new string[0];
            eventLabels = new string[0];
            actionLabels = new string[0];
        }
    }
}
