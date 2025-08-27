using BonsaiGenerators.Tables.Names.Real.French;

namespace BonsaiGenerators.Content
{
    public class FrenchNames : RandomNameGenerator
    {
        private static readonly FrenchFamily FamilyName = new();
        private static readonly FrenchMaleGiven MaleGivenName = new();
        private static readonly FrenchFemaleGiven FemaleGivenName = new();

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