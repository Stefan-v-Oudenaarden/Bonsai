using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class Adverbs : RandomTable
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
            "Beautifully",
            "Brightly",
            "Brutally",
            "Certainly",
            "Delicately",
            "Deliciously",
            "Delightfully",
            "Dramatically",
            "Dutifully",
            "Eternally",
            "Every Day",
            "Everywhere",
            "Exactly",
            "Firmly",
            "Gladly",
            "Gloriously",
            "Justly",
            "Loudly",
            "Once",
            "Perfectly",
            "Promptyly",
            "Quickly",
            "Regretfully",
            "Silently",
            "Sometimes",
            "Sorrowfully",
            "Sternly",
            "Uneasily",
            "Wickedly",
            "Yearly",
        };

        public Adverbs()
        {
            Entries = words;
        }
    }
}