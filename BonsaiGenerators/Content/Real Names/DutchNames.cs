using BonsaiGenerators.Tables.Names.Real.Dutch;

namespace BonsaiGenerators.Content
{
    public class DutchNames : RandomNameGenerator
    {
        private static readonly DutchFamilyNames FamilyName = new();
        private static readonly DutchFemaleGiven MaleGivenName = new();
        private static readonly DutchFemaleGiven FemaleGivenName = new();

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