using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class AgitatedCalmAdjectives : RandomTable
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
            "Abating",
            "Calm",
            "Calming",
            "Churning",
            "Clear",
            "Clouded",
            "Driving",
            "Dwindeling",
            "Ebbing",
            "Fair",
            "Falling",
            "Halcyon",
            "Holy",
            "Hushed",
            "Loud",
            "Quiet",
            "Raging",
            "Receding",
            "Reeling",
            "Relenting",
            "Relentless",
            "Roiling",
            "Seething",
            "Serene",
            "Silent",
            "Sinking",
            "Still",
            "Subsiding",
            "Sullen",
            "Swirling",
            "Tranquil",
            "Unholy",
            "Vile",
            "Whirling",
            "Wispering",
        };

        public AgitatedCalmAdjectives()
        {
            Entries = words;
        }
    }
}