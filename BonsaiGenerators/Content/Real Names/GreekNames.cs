using BonsaiGenerators.Tables.Names.Real.Greek;

namespace BonsaiGenerators.Content
{
    public class GreekNames : RandomNameGenerator
    {
        private static readonly GreekFemaleFamily FemaleFamilyName = new();
        private static readonly GreekMaleFamily MaleFamilyName = new();
        private static readonly GreekMaleGiven MaleGivenName = new();
        private static readonly GreekFemaleGiven FemaleGivenName = new();

        public override string FemaleFullName()
        {
            return $"{FemaleGivenName} {FemaleFamilyName}";
        }

        public override string MaleFullName()
        {
            return $"{MaleGivenName} {MaleFamilyName}";
        }

        public override string FullName()
        {
            return ToString();
        }

        public override string ToString()
        {
            var coin = Genie.Next(0, 2);
            if (coin == 1)
            {
                return MaleFullName();
            }

            return FemaleFullName();
        }
    }
}