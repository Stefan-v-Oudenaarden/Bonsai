namespace BonsaiGenerators.Tables.Names.Fantasy.Dragonborn
{
    internal class DragonbornFemaleGiven : RandomGenerator
    {
        public static readonly RandomTable Fragment1 = new()
        {
            "A",
            "A'",
            "Bi",
            "D",
            "D'",
            "Ha",
            "Ka",
            "Ko",
            "Mi",
            "Na",
            "Per",
            "R",
            "R'",
            "S",
            "S'",
            "T",
            "T'",
        };

        public static readonly RandomTable Fragment2 = new()
        {
            "aar",
            "aiann",
            "hava",
            "kra",
            "la",
            "ora",
            "ra",
            "rann",
            "ri",
            "rinn",
            "shann",
            "urina",
            "va",
        };

        public override string Next(string Seed = "")
        {
            if (Seed != "")
            {
                Genie.SetSeed(Seed);
            }

            return $"{Prefix}{Fragment1}{Fragment2}{Suffix}";
        }

        public override string ToString()
        {
            return Next();
        }
    }
}