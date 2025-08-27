using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonsaiGenerators
{
    internal static class Extensions
    {
        public static T RandomElement<T>(this List<T> list)
        {
            return list[Genie.Next(0, list.Count)];
        }

        public static TKey RandomElementWeighted<TKey>(this Dictionary<TKey, int> dictionary)
        {
            TKey element = dictionary.FirstOrDefault().Key;

            var totalWeight = dictionary.Sum(kvp => kvp.Value);
            var r = Genie.Next(totalWeight);

            foreach (var (key, value) in dictionary)
            {
                if (r >= value)
                {
                    r -= value;
                }
                else
                {
                    element = key;
                    break;
                }
            }

            return element;
        }

        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int position = text.IndexOf(search);

            if (position < 0)
            {
                return text;
            }

            return $"{text.Substring(0, position)}{replace}{text[(position + search.Length)..]}";
        }

        public static string BulkReplace(this string text, List<(string search, string replace)> replacements)
        {
            foreach (var (search, replace) in replacements)
            {
                text = text.Replace(search, replace);
            }

            return text;
        }

        public static string CapitalizeFirstChar(this string text)
        {
            return $"{text[0].ToString().ToUpper()}{text[1..]}";
        }

        public static int GetAsciiValueSum(this string text)
        {
            return text.Sum(c => c);
        }
    }
}