using BonsaiGenerators.Tables.Names.Fantasy.Dragonborn;

namespace BonsaiGenerators.Content
{
    public class DragonbornNames : RandomNameGenerator
    {
        private static readonly DragonbornFamily FamilyName = new();
        private static readonly DragonbornMaleGiven MaleGivenName = new();
        private static readonly DragonbornFemaleGiven FemaleGivenName = new();

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