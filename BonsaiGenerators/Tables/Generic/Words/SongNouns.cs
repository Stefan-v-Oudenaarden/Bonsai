using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class SongNouns : RandomTable
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
            "Anthem",
            "Aria",
            "Art",
            "Ballad",
            "Ballad",
            "Cantata",
            "Canticle",
            "Dirge",
            "Echo",
            "Elegy",
            "Fable",
            "Fantasy",
            "Hymn",
            "Lament",
            "Legend",
            "Legend",
            "Myth",
            "Ode",
            "Parable",
            "Poem",
            "Psalm",
            "Romance",
            "Saga",
            "Song",
            "Sonnet",
            "Sound",
            "Story",
            "Tale",
            "Tale",
            "Truth",
            "Verse",
        };

        public SongNouns()
        {
            Entries = words;
        }
    }
}