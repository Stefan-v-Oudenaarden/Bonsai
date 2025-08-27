using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Numbers
{
    internal class OrdinalNumbers10 : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public static readonly List<string> Numbers = new()
        {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Eighth",
            "Ninth",
            "Tenth",
        };

        public OrdinalNumbers10()
        {
            Entries = Numbers;
        }
    }
}