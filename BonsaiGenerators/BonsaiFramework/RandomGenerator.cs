using System;
using System.Collections.Generic;

namespace BonsaiGenerators
{
    public abstract class RandomGenerator
    {
        public string Prefix { get; set; }
        public string Suffix { get; set; }

        public List<(string, RandomGenerator)> Replacements { get; set; } = new();

        public void AddReplacement(string search, RandomGenerator replace)
        {
            Replacements.Add((search, replace));
        }

        public void AddReplacements(List<(string, RandomGenerator)> replacements)
        {
            Replacements.AddRange(replacements);
        }

        public override abstract string ToString();

        public abstract string Next(string Seed = "");

        public string DynamicInterpolation(string Seed = "")
        {
            return DynamicInterpolation(Next(Seed), Replacements);
        }

        public string DynamicInterpolation(List<(string, RandomGenerator)> Replacements, string Seed = "")
        {
            return DynamicInterpolation(Next(Seed), Replacements);
        }

        public static string DynamicInterpolation(string input, List<(string, RandomGenerator)> Replacements)
        {
            foreach (var (key, generator) in Replacements)
            {
                while (input.Contains(key))
                {
                    var candidate = generator.Next();
                    if (!input.Contains(candidate))
                    {
                        input = input.ReplaceFirst(key, generator.Next());
                    }
                }
            }

            return input;
        }
    }
}