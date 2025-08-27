using System.Collections.Generic;

namespace BonsaiGenerators.Content
{
    public class AllRealNames : RandomNameGenerator
    {
        private static readonly List<RandomNameGenerator> NameGenerators = new List<RandomNameGenerator>()
        {
            new AmericanNames(),
            new ChineseNames(),
            new DutchNames(),
            new FrenchNames(),
            new GreekNames(),
            new KoreanNames(),
            new LatinAmericanNames(),
            new NigerianNames(),
        };

        public override string FemaleFullName()
        {
            return NameGenerators.RandomElement().FemaleFullName();
        }

        public override string MaleFullName()
        {
            return NameGenerators.RandomElement().MaleFullName();
        }

        public override string FullName()
        {
            return NameGenerators.RandomElement().FullName();
        }

        public override string ToString()
        {
            return FullName();
        }
    }
}