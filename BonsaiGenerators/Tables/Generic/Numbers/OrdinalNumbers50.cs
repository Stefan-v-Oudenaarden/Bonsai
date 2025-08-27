using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Numbers
{
    internal class OrdinalNumbers50 : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public static readonly List<string> Numbers = new()
        {
            "first",
            "second",
            "third",
            "fourth",
            "fifth",
            "sixth",
            "seventh",
            "eighth",
            "ninth",
            "tenth",
            "eleventh",
            "twelfth",
            "thirteenth",
            "fourteenth",
            "fifteenth",
            "sixteenth",
            "seventeenth",
            "eighteenth",
            "nineteenth",
            "twentieth",
            "twenty-first",
            "twenty-second",
            "twenty-third",
            "twenty-fourth",
            "twenty-fifth",
            "twenty-sixth",
            "twenty-seventh",
            "twenty-eighth",
            "twenty-ninth",
            "thirtieth",
            "thirty-first",
            "thirty-second",
            "thirty-third",
            "thirty-fourth",
            "thirty-fifth",
            "thirty-sixth",
            "thirty-seventh",
            "thirty-eighth",
            "thirty-ninth",
            "fourtieth",
            "forty-first",
            "forty-second",
            "forty-third",
            "forty-fourth",
            "forty-fifth",
            "forty-sixth",
            "forty-seventh",
            "forty-eighth",
            "forty-ninth",
            "fiftieth",
        };

        public OrdinalNumbers50()
        {
            Entries = Numbers;
        }
    }
}