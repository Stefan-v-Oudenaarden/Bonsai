using BonsaiGenerators.Tables.Names.Real.American;

namespace BonsaiGenerators.Content
{
    public class AmericanNames : RandomNameGenerator
    {
        private static readonly AmericanFamily FamilyName = new();
        private static readonly AmericanMaleGiven MaleGivenName = new();
        private static readonly AmericanFemaleGiven FemaleGivenName = new();

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