using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Colours
{
    internal class Colours16 : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public Colours16()
        {
            Entries = new()
            {
                "white",
                "black",
                "gray",
                "maroon",
                "red",
                "crimson",
                "orange",
                "yellow",
                "green",
                "lime",
                "blue",
                "teal",
                "purple",
                "brown",
                "olive",
                "pink",
            };
        }
    }
}