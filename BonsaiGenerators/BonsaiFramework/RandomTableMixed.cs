using System.Collections;
using System.Collections.Generic;

namespace BonsaiGenerators
{
    public class RandomTableMixed : RandomGenerator, IEnumerable<RandomGenerator>
    {
        public List<RandomGenerator> Entries { get; set; } = new();

        public RandomTableMixed()
        {
        }

        public RandomTableMixed(string search, RandomGenerator replace, string prefix = "", string suffix = "")
        {
            Replacements.Add((search, replace));
            Prefix = prefix;
            Suffix = suffix;
        }

        public RandomTableMixed(List<(string, RandomGenerator)> replacements, string prefix = "", string suffix = "")
        {
            Replacements = replacements;
            Prefix = prefix;
            Suffix = suffix;
        }

        public RandomTableMixed(string prefix, string suffix = "")
        {
            Prefix = prefix;
            Suffix = suffix;
        }

        public void Add(string entry)
        {
            Entries.Add(new BonsaiString(entry));
        }

        public void Add(RandomGenerator entry)
        {
            Entries.Add(entry);
        }

        public IEnumerator<RandomGenerator> GetEnumerator()
        {
            return Entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

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

            var randomElement = Entries.RandomElement().ToString();
            randomElement = $"{Prefix}{randomElement}{Suffix}";

            randomElement = DynamicInterpolation(randomElement, Replacements);

            return randomElement;
        }
    }
}