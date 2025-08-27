using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Substances
{
    internal class FantasyMetals : RandomTable
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
            "Mithril",
            "Orichalcum",
            "Adamantium",
            "Moonsilver",
            "Soulsteel",
            "Starmetal",
            "Cold-Iron",
            "Meteor-Iron",
        };

        public FantasyMetals()
        {
            Entries = materials;
        }
    }
}