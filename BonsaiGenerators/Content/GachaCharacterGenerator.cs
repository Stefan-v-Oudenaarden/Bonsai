using System.Collections.Generic;
using BonsaiGenerators.Tables.Generic.Creatures;
using BonsaiGenerators.Tables.Generic.Colours;

namespace BonsaiGenerators.Content
{
    public class GachaCharacterGenerator
    {
        private static string _name;
        
        public GachaCharacterGenerator(string name)
        {
            Genie.SetSeed(name);
            _name = name;
        }

        public readonly RandomTableWeighted Rarity = new()
        {
            { "★", 0 },
            { "★★", 0 },
            { "★★★", 0 },
            { "⭐⭐⭐⭐", 0 },
            { "⭐⭐⭐⭐⭐", 5 },
            { "⭐⭐⭐⭐⭐ [🌟]", 5 },
            { "⭐⭐⭐⭐⭐ [✨✨]", 5 },
            { "⭐⭐⭐⭐⭐ [🌠🌠🌠]", 3 },
            { "⭐⭐⭐⭐⭐ [💖💖💖]", 3 },
            { "⭐⭐⭐⭐⭐ [🌌🌌🌌]", 3 },
            { "⭐⭐⭐⭐⭐ [❄️❄️❄️]", 3 },
            { "⭐⭐⭐⭐⭐ [⚡⚡⚡]", 3 },
            { "⭐⭐⭐⭐⭐ [🩸🩸🩸]", 3 },
            { "⭐⭐⭐⭐⭐ [💧💧💧]", 3 },
            { "⭐⭐⭐⭐⭐ [💥💥💥]", 3 },
            { "⭐⭐⭐⭐⭐ [☄️☄️☄️]", 3 },
            { "⭐⭐⭐⭐⭐ [☀️☀️☀️]", 3 },
            { "⭐⭐⭐⭐⭐ [🌕🌕🌕]", 3 },
            { "⭐⭐⭐⭐⭐ [🏴‍☠️🏴‍☠️🏴‍☠️]", 3 },
            { "⭐⭐⭐⭐⭐ [🔥🔥🔥]", 3 },
        };

        public static readonly RandomTableMixedWeighted AnimalOnesie = new("", "-Onesie")
        {
            { "Tiger", 1 },
            { new AnimalsSingleWord(), 4 },
        };

        private static readonly RandomTableMixedWeighted _variants = new()
        {
            { "Winter", 1 },
            { "Summer", 1 },
            { "Beach", 1 },
            { "Hotspring", 1 },
            { "Metal", 1 },
            { "Neon", 1 },
            { "Swimwear", 1 },
            { "Towel", 1 },
            { "Phoned in Brand Tie-in", 5 },
            { "Coca-Cola", 1 },
            { AnimalOnesie, 4 },
            { "Cat Ears", 1 },
            { "Dom", 1 },
            { "Sub", 1 },
            { "Suit", 1 },
            { "Evening Dress", 1 },
            { "Dark", 1 },
            { "Angel", 1 },
            { "Devil", 1 },
            { "Gremlin", 1 },
            { "Chibi", 1 },
            { "Mustache", 1 },
            { "Crossdressing", 1 },
            { "Gender Bent", 1 },
            { "Cyber", 1 },
            { "Clown", 1 },
            { "High School", 1 },
            { "Outdoors", 1 },
            { "Zombie", 1 },
            { "Tastefully Nude [nobody knows how this got past the censors]", 1 },
            { "Functionally Nude [everyone knows how this got past the censors]", 1 },
            { "Gravure", 1 },
            { "American", 1 },
            { "French", 1 },
            { "Traditional Japanese", 5 },
            { "Traditional Japanese, Even More Japanese", 1 },
            { "Traditional Japanese, Even More Japanese, Senbonzakura", 1 },
            { "Punished", 1 },
            { "Legacy [they redid the normal art and now this is super rare]", 1 },
            { "Sentai", 1 },
            { "Idol", 1 },
        };

        public string Variants(int amount)
        {
            var variants = new List<string>();
            while (variants.Count < amount)
            {
                var candidate = _variants.Next();
                if (!variants.Contains(candidate))
                {
                    variants.Add(candidate);
                }
            }
            return string.Join(", ", variants);
        }

        private static readonly RandomTable _artProperties = new("{colours}", new ColoursMany())
        {
            "is Extremely Lewd",
            "basically doesn't wear clothing",
            "is a cheap ripoff from another game",
            "features a completly different artstyle",
            "was drawn by a famous artist",
            "was drawn by a famous hentai artist",
            "notoriously has traced art",
            "is pure and innocent",
            "has a tacticool feeling",
            "is wearing at least 5 weapons",
            "could squash your head with their thighs",
            "is pretty scary, in an anime way",
            "is wearing real designer brand clothing, from a promotion deal",
            "has art so dark it is difficult to make out details on a phone",
            "was repurposed from old concept art for a different character",
            "is basically 90% legs",
            "is doing a classic superhero landing pose",
            "had to be censored in 3 countries",
            "had to be censored in Korea",
            "has a very classy vibe",
            "is inexplicabily black and white",
            "looks like a touhou",
            "has an Escher-esque background",
            "art strikes a good balance between fantasy and realism",
            "poses to show off both chest and ass",
            "has very colourful art",
            "was inspired by renesaince art",
            "looks at home in a period dramas",
            "features animals ears and a fluffy tail",
            "has piercing {colours} eyes",
            "features a lot of {colours} accents",
            "is wearing jeans and a simple plaid shirt",
            "wears cool shades",
            "has the same face as a lot of other characters",
            "is often called a rei-clone",
            "is basically another character but Evil",
            "art is clearly trying too hard to be edgy",
            "has finely toned abs ",
            "has made some people question their sexuality",
            "design is so androgenous people still argue about it online",
        };

        private static readonly RandomTableWeighted _artDescription = new("{_artProperties}", _artProperties)
        {
            { "{_artProperties} and {_artProperties}.", 3 },
            { "{_artProperties}, {_artProperties} and {_artProperties}.", 2 },
            { "{_artProperties}, {_artProperties}, {_artProperties} and {_artProperties}.", 1 },
        };

        public string ArtDescription => _artDescription.Next().CapitalizeFirstChar();

        private static readonly RandomTableWeighted _popularityStatus = new()
        {
            { "Is very popular", 5 },
            { "Is not very popular", 1 },
            { "Has a lot of fan recognition", 1 },
            { "Scored first in the last popularity poll", 1 },
            { "Scored top 3 in the last popularity poll", 2 },
            { "Scored top 5 in the last popularity poll", 3 },
            { "Scored last in the last popularity poll", 1 },
            { "Is almost never used", 1 },
            { "Is in amost every team", 1 },
            { "Is somewhat popular", 1 },
            { "Gets a lot of fan hate", 1 },
            { "Is the least popular", 1 },
            { "Used to be popular", 1 },
            { "Has been gaining popularity", 1 },
            { "Has a mascot status", 1 },
            { "Gets a lot of cosplay", 1 },
            { "Was basically forgotten after 2 months", 1 },
            { "Keeps coming up in internet arguments", 1 },
            { "Was very popular last year", 1 },
            { "Is popular with newer players", 1 },
            { "Is unpopular with newer players", 1 },
            { "Is popular with younger players", 1 },
            { "Is unpopular with younger players", 1 },
            { "Is popular with older players", 1 },
            { "Is unpopular with older players", 1 },
            { "Is popular with men", 1 },
            { "Is unpopular with with men", 1 },
            { "Is popular with women", 1 },
            { "Is unpopular with with women", 1 },
        };

        private static readonly RandomTable _popularityReason = new()
        {
            "are OP",
            "are a free story unlock",
            "keep coming up in the story",
            "have bad stats but good abilities",
            "have good abilities but bad stats",
            "got nerfed",
            "keep getting buffed",
            "are only good for memes",
            "are popular in japan",
            "are popular outside of japan",
            "cannot be acquired anymore",
            "are a rare event only drop",
            "are very expensive",
            "are the writers favourite",
            "have a tie in manga",
            "are a crossover character from another game",
            "feature in the anime",
            "are newbie friendly",
            "take a lot of upgrade materials",
            "are super rare",
            "have a lot of story content",
            "don't have any story content",
            "are required for a secret ending",
            "die tragically in the true ending",
        };

        public readonly RandomTableWeighted Popularity = new(new List<(string, RandomGenerator)>
        {
            ("{popularityReason}",_popularityReason),
            ("{popularityStatus}",_popularityStatus)
        })
        {
            { "{popularityStatus} because they {popularityReason}.", 6 },
            { "{popularityStatus}.", 1 },
            { "{popularityStatus} because of nerds on the internet.", 1 },
            { "{popularityStatus} because they {popularityReason} and {popularityReason}.", 2 },
            { "{popularityStatus} because they {popularityReason} but {popularityReason}.", 2 },
            { "{popularityStatus} because they {popularityReason} or {popularityReason}.", 2 },
        };

        public readonly RandomTableWeighted OptionalPopularity = new(new List<(string, RandomGenerator)>
        {
            ("{popularityReason}",_popularityReason),
            ("{popularityStatus}",_popularityStatus)
        })
        {
            { "{popularityStatus} because they {popularityReason}.", 6 },
            { "{popularityStatus}.", 1 },
            { "{popularityStatus} because of nerds on the internet.", 1 },
            { "", 60 },
        };

        private static readonly RandomTable _fanartReason = new()
        {
            "its all made by a group of $R-2_10$ men",
            "its all made by a group of $R-2_10$ women",
            "its all just memes",
            "its all porn",
            "because of reddits collective thirst",
            "because of discords collective thirst",
            "it all seems to be NTR",
            "it looks like its mostly slash",
            "also twice that amount of lewd fanfic",
            "most of it is secondary roles",
            "also one fanfic that has over $R-2_5$ million words",
            "your parents would not aprove",
            "none with the ship you want",
            "its all weird crossovers",
            "most of it is super impressive cover art",
            "mostly fast sketches",
            "very popular in doujin circles",
            "not popular in doujin circles",
            "its mostly on pixiv",
            "its mostly on tumblr",
            "its all super adorable",
            "very generic",
            "super recognizable",
            "its mostly furry art",
            "why is it so edgy",
            "its mostly about some coffeeshot au",
            "its all about some popular highschool au",
            "its all for the anime instead of the game",
            "shows up a lot in terrible youtube explenation videos",
            "mostly untranslated 4-komas",
            "the art doesn't apreciate their Deep Lore",
        };

        private readonly RandomTableWeighted _fanArt = new("{fanartreason}", _fanartReason)
        {
            { "Doesn't have a a lot of fanart {fanartreason}.", 6 },
            { "Doesn't have a a lot of fanart {fanartreason} and literally all of it is NSFW.", 3 },
            { "Has a lot of fanart, {fanartreason}", 6 },
            { "Doesn't have any fanart yet.", 1 },
            { "Has so much fanart there are entire boorus just for {name}, some of it is even SFW.", 1 },
            { "Has some fanart {fanartreason} and {fanartreason}.", 3 },
            { "Has some fanart {fanartreason} and its sort of scary.", 1 },
            { "Has reasonable amounts of fanart {fanartreason} but why is so much of it catgirls.", 1 },
            { "Has reasonable amounts of fanart {fanartreason} and {fanartreason}.", 3 },
        };

        public string FanArt => _fanArt.Next().Replace("{name}", _name);
    }
}