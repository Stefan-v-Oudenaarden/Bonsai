using BonsaiGenerators.Tables.Names.Real.Korean;

namespace BonsaiGenerators.Content
{
    public class KoreanNames : RandomNameGenerator
    {
        private static readonly KoreanFamily FamilyName = new();
        private static readonly KoreanFemaleGiven FemaleGivenName = new();
        private static readonly KoreanMaleGiven MaleGivenName = new();

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