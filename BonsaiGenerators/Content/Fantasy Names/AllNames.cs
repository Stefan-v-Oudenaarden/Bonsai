using System.Collections.Generic;

namespace BonsaiGenerators.Content
{
    public class AllFantasyNames : RandomNameGenerator
    {
        private static readonly List<RandomNameGenerator> NameGenerators = new List<RandomNameGenerator>()
        {
            new DragonbornNames(),
            new HumanNames(),
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
    }
}