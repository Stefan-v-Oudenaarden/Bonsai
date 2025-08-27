using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class CoolAdjectives : RandomTable
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
            "Ancient",
            "Ardent",
            "Ashen",
            "Bloody",
            "Bright",
            "Brusk",
            "Burning",
            "Celebrated",
            "Cherished",
            "Cold",
            "Dark",
            "Divine",
            "Docile",
            "Ebon",
            "Empty",
            "Endless",
            "Eternal",
            "Failed",
            "Famed",
            "Fragrant",
            "Frozen",
            "Furious",
            "Gentle",
            "Gifted",
            "Gilded",
            "Grand",
            "Heavenly",
            "Hidden",
            "Hopeful",
            "Hot",
            "Immortal",
            "Infinite",
            "Jade",
            "Juggernaut",
            "Liminal",
            "Masked",
            "Painful",
            "Paper",
            "Pure",
            "Recursive",
            "Shining",
            "Silent",
            "Silk",
            "Sleeping",
            "Sorrowful",
            "Sweet",
            "Turbulent",
            "Verdant",
            "Vigilant",
            "Wilful",
            "Radiant",
        };

        public CoolAdjectives()
        {
            Entries = words;
        }
    }
}