using BonsaiGenerators.Tables.Generic.Numbers;
using BonsaiGenerators.Tables.Generic.Colours;
using BonsaiGenerators.Tables.Generic.Substances;
using BonsaiGenerators.Tables.Generic.Words;
using System.Collections.Generic;

namespace BonsaiGenerators.Content
{
    public class K6BDAngelNames : RandomGenerator
    {
        public static readonly RandomTable hail = new()
        {
            "Behold :",
            "Witness :"
        };

        public static readonly RandomTable affix = new()
        {
            "Thought",
            "Intent",
            "Truth",
            "Balance",
            "Stability",
            "Equilibrium",
            "Justice",
            "Law",
            "Alacrity",
            "Fervor",
            "Action",
            "Life",
            "Life Everlasting",
            "Razors",
            "Envy",
            "Blight",
            "Ire",
            "Worth",
            "Joy",
            "Excellence",
            "Bliss",
            "Inertia",
            "Honor",
            "Zeal",
        };

        public static readonly RandomTable concepts = new()
        {
            "Fate",
            "Destiny",
            "Samsara",
            "Creation",
            "Fortune",
            "Kismet",
            "Karma",
            "Yisuns Truth",
            "Truth",
            "Faith",
            "Science",
            "Craft",
            "Devotion",
            "Piety",
            "Belief",
            "Life",
            "Doubt",
            "Apostasy",
            "Trust",
            "Law",
            "Hope",
            "Discipline",
            "Craft",
            "Power",
            "Agency",
            "Instrumentality",
            "the End",
            "the Beginning",
            "the Wheel",
            "All Things",
            "Autonomy",
            "Choice",
            "Volition",
            "Sin",
            "Virtue",
            "Love",
            "Hubris",
            "Grace",
        };

        public static readonly RandomTable groupPart = new()
        {
            "Blades",
            "Brain",
            "Castles",
            "Core",
            "Craft",
            "Eyes",
            "Final Song",
            "Final Words",
            "First Word",
            "Heart",
            "Hovels",
            "Last Step",
            "Law",
            "Palaces",
            "Second Breath",
            "Sins",
            "Soul",
            "Spears",
            "Thrones",
            "Flesh",
            "Tongues",
        };

        public static readonly RandomTable groups = new()
        {
            "a River",
            "All",
            "All that Is and Was",
            "Civilization",
            "Darkness",
            "Emptyness",
            "Evil",
            "God",
            "Lies",
            "Mankind",
            "None",
            "Reality",
            "Sin",
            "Space-Time",
            "Swords",
            "the Charitable",
            "the Concordate",
            "the Conquering King",
            "the Dead",
            "the Devils",
            "the Envious",
            "the Faithful",
            "the Fortunate",
            "the Gluttonous",
            "the Gods",
            "the Greedy",
            "the Holy",
            "the Hopeful",
            "the Horizon",
            "the Hungry",
            "the Just",
            "the Living",
            "the Lustful",
            "the Luminiferous Ether",
            "the Meek",
            "the Moon",
            "the Poor",
            "the Proud",
            "the Prudent",
            "the Repentant",
            "the Rising King",
            "the Ruling King",
            "the Servants",
            "the Seven",
            "the Sinful",
            "the Slothful",
            "the Stars",
            "the Sun",
            "the Temperate",
            "the Thorns",
            "the Truthful",
            "the Unborn",
            "the Unbound",
            "the Unfortunate",
            "the Unholy",
            "the Universe",
            "the Unrepentant",
            "the Untruthful",
            "the Unwise",
            "the Unseen",
            "the Virtuous",
            "the Void",
            "the Wicked",
            "the Wise",
            "the World",
            "the Wrathful",
            "Truth",
        };

        public static readonly RandomTable _location = new()
        {
            "a Battlefield",
            "a Beach",
            "a Clearing",
            "a Desert",
            "a Forest",
            "a Funeral Pyre",
            "a Graveyard",
            "a Grove",
            "a Jungle",
            "a Mountain",
            "a Mourning Hall",
            "a Palace",
            "a River",
            "a Star",
            "a Stream",
            "All Creation",
            "All that Is and Was",
            "Endless Rolling Hills",
            "the {OrdinalNumbers50} Hell",
            "the Abyss",
            "the Last Moment",
            "the Moon",
            "the Ocean",
            "the Stars",
            "the Void",
            "Throne",
        };

        public static readonly RandomTable movementPhrase = new()
        {
            "Rising From ",
            "From",
            "Moving Through",
            "Through",
            "Advancing Past",
            "Past",
            "Forever Beyond",
            "Beyond",
            "Trapped Inside  ",
            "Inside of",
            "Trapped Outside",
            "Outside of",
            "Flying Above",
            "Above",
            "Meditating in",
            "in",
        };

        public static readonly RandomTable verbMovement = new()
        {
            "Arrives",
            "Dances",
            "Dies",
            "is Reborn",
            "Leaves",
            "Left",
            "Prays",
            "Returns",
            "Sings",
            "Waits",
        };

        public static readonly RandomTableMixedWeighted adjective = new()
        {
            new Colours16(),
            new FancyMaterials(),
            new CommonMetals(),
            new FantasyMetals(),
            new CoolAdjectives()
        };

        public static readonly RandomTableWeighted _nameRoot = new()
        {
            { "{adjective} {coolNoun} {coolVerbsPresent3rd} {group}", 5 },
            { "{adjective} {coolNoun} of {affix} Shall {coolVerbs} {group}", 3 },
            { "{adjective} {coolNoun} of {affix} Will {coolVerbs} {group}", 3 },
            { "{adjective} {coolNoun} {coolVerbsPresent3rd} the {groupPart} of {group}", 5 },
            { "{adjective} {coolNoun} {coolVerbsPresent3rd} {group}, {adverbs}", 1 },
            { "{adjective} {coolNoun} {coolVerbsPresent3rd} All {group}, {adverbs}", 5 },
            { "{adjective} {coolNoun} {coolVerbsPresent3rd} the {groupPart} of {group}, {adverbs}", 1 },
            { "{adjective} {coolNoun} {coolVerbsPresent3rd} {group} and {group}", 5 },
            { "{adjective} {coolNoun} {coolVerbsPresent3rd} {group} and {coolVerbsPresent3rd} {group}", 5 },
            { "{adjective} {coolNoun} {coolVerbsPresent3rd} {group} and {group}, {adverbs}", 1 },
            { "{adjective} {coolNoun} {verbMovement} to {coolVerbs} {group}", 5 },
            { "{coolGerunds} {concepts}", 1 },
            { "{coolGerunds} {concepts} Shall {coolVerbs} {group}", 3 },
            { "{coolGerunds} {concepts} Will {coolVerbs} {group}", 3 },
            { "{songNouns} of {agitatedCalmAdjectives} {natureNouns} {movementPhrase} {location}", 8 },
            { "{agitatedCalmAdjectives} {natureNouns} {movementPhrase} {location}", 8 },
        };

        private static readonly List<(string, RandomGenerator)> _replacements = new()
        {
            ("{verbMovement}", verbMovement),
            ("{adjective}", adjective),
            ("{coolNoun}", new CoolNouns()),
            ("{coolVerbsPresent3rd}", new CoolVerbsPresent3rd()),
            ("{group}", groups),
            ("{groupPart}", groupPart),
            ("{affix}", affix),
            ("{coolVerbs}", new CoolVerbs()),
            ("{adverbs}", new Adverbs()),
            ("{verbMovement}", verbMovement),
            ("{coolGerunds}", new CoolGerunds()),
            ("{concepts}", concepts),
            ("{songNouns}", new SongNouns()),
            ("{agitatedCalmAdjectives}", new AgitatedCalmAdjectives()),
            ("{natureNouns}", new NatureNouns()),
            ("{movementPhrase}", movementPhrase),
        };

        public string Generate()
        {
            var location = _location
                .DynamicInterpolation(new List<(string, RandomGenerator)> {
                    ("{OrdinalNumbers50}", new OrdinalNumbers50()),
                });

            var name = _nameRoot
                .DynamicInterpolation(_replacements)
                .BulkReplace(new List<(string, string)> {
                    ("{location}", location)
                }).CapitalizeFirstChar();

            int number = Genie.Next(3, 99);

            if (Genie.Next(2) == 1)
            {
                number = Genie.Next(5, 20);
            }

            return $"{number} {name}";
        }

        public string Hail()
        {
            return $"{hail}";
        }

        public override string ToString()
        {
            return Next();
        }

        public override string Next(string Seed = "")
        {
            if (Seed != "")
            {
                Genie.SetSeed(Seed);
            }

            var randomElement = Generate();

            return $"{Prefix}{randomElement}{Suffix}";
        }
    }
}