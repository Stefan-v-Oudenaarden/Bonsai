using System.Collections.Generic;
using System.Collections;

namespace BonsaiGenerators
{
    public class RandomTableMixedWeighted : RandomGenerator, IEnumerable<KeyValuePair<RandomGenerator, int>>
    {
        public Dictionary<RandomGenerator, int> Entries { get; set; } = new();

        public RandomTableMixedWeighted()
        {
        }

        public RandomTableMixedWeighted(string search, RandomGenerator replace, string prefix = "", string suffix = "")
        {
            Replacements.Add((search, replace));
            Prefix = prefix;
            Suffix = suffix;
        }

        public RandomTableMixedWeighted(List<(string, RandomGenerator)> replacements, string prefix = "", string suffix = "")
        {
            Replacements = replacements;
            Prefix = prefix;
            Suffix = suffix;
        }

        public RandomTableMixedWeighted(string prefix, string suffix = "")
        {
            Prefix = prefix;
            Suffix = suffix;
        }

        public void Add(string key, int value = 1)
        {
            Entries.Add(new BonsaiString(key), value);
        }

        public void Add(RandomGenerator key, int value = 1)
        {
            Entries.Add(key, value);
        }

        public IEnumerator<KeyValuePair<RandomGenerator, int>> GetEnumerator()
        {
            return Entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string Next(string Seed = "")
        {
            if (Seed != "")
            {
                Genie.SetSeed(Seed);
            }

            var randomElement = Entries.RandomElementWeighted().Next();
            randomElement = $"{Prefix}{randomElement}{Suffix}";

            randomElement = DynamicInterpolation(randomElement, Replacements);

            return randomElement;
        }

        public override string ToString()
        {
            return Next();
        }
    }
}