using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class CoolGerunds : RandomTable
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
            "Accusing",
            "Analyzing",
            "Annihilating",
            "Apprehending",
            "Attaining",
            "Breaking",
            "Challenging",
            "Concealing",
            "Contradicting",
            "Crowning",
            "Crushing",
            "Defeating",
            "Deriding",
            "Dominating",
            "Embracing",
            "Engulfing",
            "Enlightening",
            "Entombing",
            "Plunging Into",
            "Evading",
            "Evoking",
            "Excising",
            "Forgiving",
            "Gazing",
            "Guiding",
            "Healing",
            "Invoking",
            "Isolating",
            "Lampooning",
            "Manipulating",
            "Negating",
            "Occupying",
            "Perceiving",
            "Protecting",
            "Puncturing",
            "Purging",
            "Questioning",
            "Ravaging",
            "Renouncing",
            "Repairing",
            "Repelling",
            "Returning",
            "Scouring",
            "Sealing",
            "Shattering",
            "Shrouding",
            "Subduing",
            "Transcending",
            "Undoing",
            "Unmaking",
            "Vanquishing",
            "Veiling",
            "Witnesing",
        };

        public CoolGerunds()
        {
            Entries = words;
        }
    }
}