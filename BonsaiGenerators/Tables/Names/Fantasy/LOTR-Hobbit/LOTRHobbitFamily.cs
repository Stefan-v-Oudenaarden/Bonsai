using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Names.Fantasy.LOTRHobbit
{
    internal class LOTRHobbitFamily : RandomGenerator
    {
        private static RandomTable _lastName = new()
        {
            "Baggins",
            "Banks",
            "Boffin",
            "Bolger",
            "Bolger",
            "Bracegirdle",
            "Brandagamba",
            "Brandybuck",
            "Bree",
            "Brockhouse",
            "Brown",
            "Brownlock",
            "Bunce",
            "Burrowes",
            "Burrows",
            "Button",
            "Chubb",
            "Chubb-Baggins",
            "Clayhanger",
            "Diggle",
            "Fairbairn",
            "Gamgee",
            "Gammidge",
            "Gardner",
            "Gaukrogers",
            "Gawkroger",
            "Goldworthy",
            "Goodbody",
            "Goodchild",
            "Goold",
            "Greenhand",
            "Grubb",
            "Hayward",
            "Headstrong",
            "Hogpen",
            "Hornblower",
            "Labingi",
            "Lightfoot",
            "Longhole",
            "Lothran",
            "Maggot",
            "Mugwort",
            "Noakes",
            "Oldbuck",
            "Proudfoot",
            "Puddifoot",
            "Roper",
            "Rumble",
            "Sackville",
            "Sandheaver",
            "Sandyman",
            "Smallburrow",
            "Took",
            "Tunnelly",
            "Twofoot",
            "Tûk",
            "Underhill",
            "Whitfoot",
            "Zaragamba",
        };

        private static RandomTableWeighted _secondLastName = new()
        {
            { "", 200 },
            "-Baggins",
            "-Banks",
            "-Boffin",
            "-Bolger",            
            "-Bracegirdle",
            "-Brandagamba",
            "-Brandybuck",
            "-Bree",
            "-Brockhouse",
            "-Brown",
            "-Brownlock",
            "-Bunce",
            "-Burrowes",
            "-Burrows",
            "-Button",
            "-Chubb",
            "-Chubb-Baggins",
            "-Clayhanger",
            "-Diggle",
            "-Fairbairn",
            "-Gamgee",
            "-Gammidge",
            "-Gardner",
            "-Gaukrogers",
            "-Gawkroger",
            "-Goldworthy",
            "-Goodbody",
            "-Goodchild",
            "-Goold",
            "-Greenhand",
            "-Grubb",
            "-Hayward",
            "-Headstrong",
            "-Hogpen",
            "-Hornblower",
            "-Labingi",
            "-Lightfoot",
            "-Longhole",
            "-Lothran",
            "-Maggot",
            "-Mugwort",
            "-Noakes",
            "-Oldbuck",
            "-Proudfoot",
            "-Puddifoot",
            "-Roper",
            "-Rumble",
            "-Sackville",
            "-Sandheaver",
            "-Sandyman",
            "-Smallburrow",
            "-Took",
            "-Tunnelly",
            "-Twofoot",
            "-Tûk",
            "-Underhill",
            "-Whitfoot",
            "-Zaragamba",
        };

        public override string Next(string Seed = "")
        {
            if (Seed != "")
            {
                Genie.SetSeed(Seed);
            }

            var randomElement = $"{_lastName}{_secondLastName}";
            randomElement = $"{Prefix}{randomElement}{Suffix}";

            randomElement = DynamicInterpolation(randomElement, Replacements);

            return randomElement;
        }

        public override string ToString()
        {
            return Next();
        }
    }
}