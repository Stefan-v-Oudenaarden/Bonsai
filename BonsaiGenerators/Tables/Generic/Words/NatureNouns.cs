using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class NatureNouns : RandomTable
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
            "Autumn",
            "Clouds",
            "Dawn",
            "Dusk",
            "Fall",
            "Fog",
            "Gale",
            "Hail",
            "Lightning",
            "Mist",
            "Mistral",
            "Mists",
            "Monsoon",
            "Moon",
            "Moons",
            "Night",
            "Rain",
            "River",
            "Sleet",
            "Smoke",
            "Snow",
            "Spring",
            "Stars",
            "Storm",
            "Stream",
            "Summer",
            "Sun",
            "Suns",
            "Thunder",
            "Vapor",
            "Water",
            "Waters",
            "Waves",
            "Wind",
            "Winter",
        };

        public NatureNouns()
        {
            Entries = words;
        }
    }
}