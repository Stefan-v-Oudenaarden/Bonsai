using System.Collections;
using System.Collections.Generic;

namespace BonsaiGenerators
{
    public class RandomTable : RandomGenerator, IEnumerable<string>
    {
        public List<string> Entries { get; set; } = new();

        public RandomTable()
        {
        }

        public RandomTable(string search, RandomGenerator replace, string prefix = "", string suffix = "")
        {
            Replacements.Add((search, replace));
            Prefix = prefix;
            Suffix = suffix;
        }

        public RandomTable(List<(string, RandomGenerator)> replacements, string prefix = "", string suffix = "")
        {
            Replacements = replacements;
            Prefix = prefix;
            Suffix = suffix;
        }

        public RandomTable(string prefix, string suffix = "")
        {
            Prefix = prefix;
            Suffix = suffix;
        }

        public void Add(string entry)
        {
            Entries.Add(entry);
        }

        public IEnumerator<string> GetEnumerator()
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

            var randomElement = Entries.RandomElement();
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