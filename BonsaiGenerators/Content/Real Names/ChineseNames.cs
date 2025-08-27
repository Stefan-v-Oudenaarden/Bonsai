using BonsaiGenerators.Tables.Names.Real.Chinese;

namespace BonsaiGenerators.Content
{
    public class ChineseNames : RandomNameGenerator
    {
        private static readonly ChineseFamily FamilyName = new();
        private static readonly ChineseMaleGiven MaleGivenName = new();
        private static readonly ChineseFemaleGiven FemaleGivenName = new();

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