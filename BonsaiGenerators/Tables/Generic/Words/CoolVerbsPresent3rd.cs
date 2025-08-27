using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class CoolVerbsPresent3rd : RandomTable
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
            "Accuses",
            "Analyzes",
            "Annihilates",
            "Apprehends",
            "Attains",
            "Breaks",
            "Challenges",
            "Conceals",
            "Contradicts",
            "Crowns",
            "Crushes",
            "Defeats",
            "Derides",
            "Dominates",
            "Embraces",
            "Engulfs",
            "Enlightens",
            "Entombs",
            "Plunges Into",
            "Evades",
            "Evokes",
            "Excises",
            "Forgives",
            "Guides",
            "Heals",
            "Invokes",
            "Isolates",
            "Lampoons",
            "Manipulates",
            "Negates",
            "Occupies",
            "Perceives",
            "Protects",
            "Punctures",
            "Purges",
            "Questions",
            "Ravages",
            "Renounces",
            "Repairs",
            "Repells",
            "Returns",
            "Scours",
            "Seals",
            "Shatters",
            "Shoulders",
            "Shrouds",
            "Subdues",
            "Transcends",
            "Undoes",
            "Unmakes",
            "Vanquishes",
            "Veils",
            "Witnesses",
        };

        public CoolVerbsPresent3rd()
        {
            Entries = words;
        }
    }
}