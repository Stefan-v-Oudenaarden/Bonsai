using BonsaiGenerators.Tables.Names.Fantasy.LOTRHobbit;

namespace BonsaiGenerators.Content
{
    public class LOTRHobbitNames : RandomNameGenerator
    {
        private static readonly LOTRHobbitFamily FamilyName = new();
        private static readonly LOTRHobbitMaleGiven MaleGivenName = new();
        private static readonly LOTRHobbitFemaleGiven FemaleGivenName = new();

        private static readonly RandomGenerator GivenName = new RandomTableMixed
        {
            MaleGivenName,
            FemaleGivenName
        };

        public override string FullName()
        {
            return $"{GivenName} {FamilyName}";
        }

        public override string FemaleFullName()
        {
            return $"{FemaleGivenName} {FamilyName}";
        }

        public override string MaleFullName()
        {
            return $"{MaleGivenName} {FamilyName}";
        }
    }
}