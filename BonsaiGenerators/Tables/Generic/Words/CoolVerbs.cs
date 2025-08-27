using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class CoolVerbs : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public static readonly List<string> _entries = new()
        {
            "Accuse",
            "Analyze",
            "Annihilate",
            "Apprehend",
            "Attain",
            "Break",
            "Challenge",
            "Conceal",
            "Contradict",
            "Crown",
            "Crush",
            "Defeat",
            "Deride",
            "Dominate",
            "Embrace",
            "Engulf",
            "Enlighten",
            "Entomb",
            "Plunge Into",
            "Evade",
            "Evoke",
            "Excise",
            "Forgive",
            "Guide",
            "Heal",
            "Invoke",
            "Isolate",
            "Lampoon",
            "Manipulate",
            "Negate",
            "Occupy",
            "Perceive",
            "Protect",
            "Puncture",
            "Purge",
            "Question",
            "Ravage",
            "Renounce",
            "Repair",
            "Repell",
            "Return",
            "Scour",
            "Seal",
            "Shatter",
            "Shoulder",
            "Shroud",
            "Subdue",
            "Transcend",
            "Undo",
            "Unmake",
            "Vanquish",
            "Veil",
            "Witnes",
        };

        public CoolVerbs()
        {
            Entries = _entries;
        }
    }
}