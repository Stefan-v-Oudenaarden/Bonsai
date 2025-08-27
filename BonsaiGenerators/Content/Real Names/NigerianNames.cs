using BonsaiGenerators.Tables.Names.Real.Nigerian;

namespace BonsaiGenerators.Content
{
    public class NigerianNames : RandomNameGenerator
    {
        private static readonly NigerianFamily FamilyName = new();
        private static readonly NigerianFemaleGiven FemaleGivenName = new();
        private static readonly NigerianMaleGiven MaleGivenName = new();

        private static readonly RandomGenerator GivenName = new RandomTableMixed
        {
            MaleGivenName,
            FemaleGivenName
        };

        public override string FemaleFullName()
        {
            return $"{FemaleGivenName} {FamilyName}";
        }

        public override string MaleFullName()
        {
            return $"{MaleGivenName} {FamilyName}";
        }

        public override string FullName()
        {
            return $"{GivenName} {FamilyName}";
        }
    }
}