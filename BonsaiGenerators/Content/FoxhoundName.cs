using BonsaiGenerators.Tables.Generic.Creatures;
using BonsaiGenerators.Tables.Misc;

namespace BonsaiGenerators.Content
{
    public class FoxhoundNameGenerator
    {
        private static readonly FoxhoundAdjective Adjective = new();
        private static readonly AnimalsSingleWord Animal = new();

        public string Next()
        {
            return $"{Adjective} {Animal}";
        }
    }
}