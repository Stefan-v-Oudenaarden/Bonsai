using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsaiGenerators
{
    public abstract class RandomNameGenerator : RandomGenerator
    {
        public abstract string FullName();

        public abstract string FemaleFullName();

        public abstract string MaleFullName();

        public override string ToString()
        {
            return Next();
        }

        public override string Next(string Seed = "")
        {
            if (Seed != "")
            {
                Genie.SetSeed(Seed);
            }

            var randomElement = FullName();

            return $"{Prefix}{randomElement}{Suffix}";
        }
    }
}