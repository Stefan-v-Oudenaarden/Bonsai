using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Numbers
{
    internal class OrdinalNumbers100 : RandomTable
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
            "fifty-first",
            "fifty-second",
            "fifty-third",
            "fifty-fourth",
            "fifty-fifth",
            "fifty-sixth",
            "fifty-seventh",
            "fifty-eighth",
            "fifty-ninth",
            "sixtieth",
            "sixty-first",
            "sixty-second",
            "sixty-third",
            "sixty-fourth",
            "sixty-fifth",
            "sixty-sixth",
            "sixty-seventh",
            "sixty-eighth",
            "sixty-ninth",
            "seventieth",
            "seventy-first",
            "seventy-second",
            "seventy-third",
            "seventy-fourth",
            "seventy-fifth",
            "seventy-sixth",
            "seventy-seventh",
            "seventy-eighth",
            "seventy-ninth",
            "eightieth",
            "eighty-first",
            "eighty-second",
            "eighty-third",
            "eighty-fourth",
            "eighty-fifth",
            "eighty-sixth",
            "eighty-seventh",
            "eighty-eighth",
            "eighty-ninth",
            "ninetieth",
            "ninety-first",
            "ninety-second",
            "ninety-third",
            "ninety-fourth",
            "ninety-fifth",
            "ninety-sixth",
            "ninety-seventh",
            "ninety-eighth",
            "ninety-ninth",
            "one hundredth",
        };

        public OrdinalNumbers100()
        {
            Entries = Numbers;
        }
    }
}