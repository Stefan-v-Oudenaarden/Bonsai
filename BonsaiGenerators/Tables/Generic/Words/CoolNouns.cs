using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class CoolNouns : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public static readonly List<string> words = new()

        {
            "Anvil",
            "Blade",
            "Blossom",
            "Breath",
            "Bridge",
            "Chain",
            "Chariot",
            "Cherry",
            "Chisel",
            "Claw",
            "Cliff",
            "Cloud",
            "Comet",
            "Concordance",
            "Continent",
            "Crown",
            "Word",
            "Dawn",
            "Day",
            "Diamond",
            "Disc",
            "Dome",
            "Dragon",
            "Dusk",
            "Eye",
            "Fang",
            "Feather",
            "Field",
            "Flame",
            "Flower",
            "Forge",
            "Gale",
            "Gaze",
            "Griffon",
            "Hammer",
            "Hand",
            "Ingot",
            "Judge",
            "Lotus",
            "Magistrate",
            "Mask",
            "Master",
            "Meteor",
            "Moon",
            "Mountain",
            "Night",
            "Ocean",
            "Orb",
            "Peach",
            "Pillar",
            "River",
            "Ruby",
            "Aether",
            "Sapphire",
            "Scale",
            "Scar",
            "Shield",
            "Sigil",
            "Smoke",
            "Song",
            "Spear",
            "Spirit",
            "Star",
            "Stone",
            "Storm",
            "Stream",
            "Student",
            "Sun",
            "Talon",
            "Temple",
            "Thorn",
            "Tide",
            "Tome",
            "Tower",
            "Tree",
            "Voice",
            "Wave",
            "Wing",
            "Word",
        };

        public CoolNouns()
        {
            Entries = words;
        }
    }
}