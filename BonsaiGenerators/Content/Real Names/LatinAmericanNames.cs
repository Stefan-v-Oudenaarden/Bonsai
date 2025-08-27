using BonsaiGenerators.Tables.Names.Real.LatinAmerican;

namespace BonsaiGenerators.Content
{
    public class LatinAmericanNames : RandomNameGenerator
    {
        private static readonly LatinAmericanFamily FamilyName = new();
        private static readonly LatinAmericanFemaleGiven FemaleGivenName = new();
        private static readonly LatinAmericanMaleGiven MaleGivenName = new();

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