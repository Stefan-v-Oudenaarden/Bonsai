using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Names.Real.Korean
{
    internal class KoreanFamily : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public KoreanFamily()
        {
            Entries = new()
            {
                "Ahn",
                "Bae",
                "Baek",
                "Cho",
                "Choi",
                "Chung",
                "Han",
                "Hong",
                "Hwang",
                "Im",
                "Jang",
                "Jeon",
                "Jeong",
                "Jo",
                "Jong",
                "Jung",
                "Kang",
                "Kim",
                "Kwon",
                "Lee",
                "Lim",
                "Oh",
                "Park",
                "Seo",
                "Shin",
                "Song",
                "Yim",
                "Yoo",
                "Yoon",
            };
        }
    }
}