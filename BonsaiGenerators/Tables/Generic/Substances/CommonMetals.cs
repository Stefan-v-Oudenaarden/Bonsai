using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Substances
{
    internal class CommonMetals : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public static readonly List<string> materials = new()
        {
            "iron",
            "steel",
            "copper",
            "bronze",
            "brass",
            "silver",
            "gold",
            "platinum",
            "iridium",
            "antimony",
            "mercury",
            "cobalt",
            "titanium",
            "chrome",
        };

        public CommonMetals()
        {
            Entries = materials;
        }
    }
}