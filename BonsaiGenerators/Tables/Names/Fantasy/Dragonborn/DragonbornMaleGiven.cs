namespace BonsaiGenerators.Tables.Names.Fantasy.Dragonborn
{
    internal class DragonbornMaleGiven : RandomGenerator
    {
        public static readonly RandomTable Fragment1 = new()
        {
            "Ar",
            "B'",
            "Bala",
            "Bha",
            "D'",
            "Do",
            "G",
            "G'",
            "He",
            "K",
            "K'",
            "L'",
            "Med",
            "Na",
            "P'",
            "Pa",
            "Rho",
            "Sha",
            "She",
            "T'",
            "To",
        };

        public static readonly RandomTable Fragment2 = new()
        {
            "darr",
            "dinn",
            "gar",
            "hesh",
            "jhan",
            "mash",
            "naar",
            "rash",
            "rash",
            "rinn",
            "riv",
            "sar",
            "skan",
            "trin",
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