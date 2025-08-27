using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Substances
{
    internal class FancyMaterials : RandomTable
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
            "Jade",
            "Silk",
            "Gossamer",
            "Verdigris",
            "Peony",
            "Feather",
            "Saffron",
            "Luminiferous",
            "Pearl",
        };

        public FancyMaterials()
        {
            Entries = materials;
        }
    }
}