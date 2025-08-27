using BonsaiGenerators.Tables.Names.Fantasy.Human;

namespace BonsaiGenerators.Content
{
    public class HumanNames : RandomNameGenerator
    {
        private static readonly HumanFamily FamilyName = new();
        private static readonly HumanMaleGiven MaleGivenName = new();
        private static readonly HumanFemaleGiven FemaleGivenName = new();

        private static readonly RandomGenerator GivenName = new RandomTableMixed
        {
            MaleGivenName,
            FemaleGivenName
        };

        public override string FullName()
        {
            return ToString();
        }

        public override string FemaleFullName()
        {
            return $"{FemaleGivenName} {FamilyName}";
        }

        public override string MaleFullName()
        {
            return $"{MaleGivenName} {FamilyName}";
        }

        public override string ToString()
        {
            return $"{GivenName} {FamilyName}";
        }
    }
}