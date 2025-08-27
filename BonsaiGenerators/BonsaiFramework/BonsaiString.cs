using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsaiGenerators
{
    public class BonsaiString : RandomGenerator
    {
        public string Content;

        public BonsaiString(string content)
        {
            Content = content;
        }

        public override string Next(string Seed = "")
        {
            if (Seed != "")
            {
                Genie.SetSeed(Seed);
            }

            return $"{Prefix}{Content}{Suffix}";
        }

        public override string ToString()
        {
            return Next();
        }
    }
}