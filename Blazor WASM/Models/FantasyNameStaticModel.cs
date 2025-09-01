namespace Blazor_WASM.Models
{
    public static class FantasyNameStaticModel
    {
        //Country code list / easy access to wikimedia flag svg through country link
        // https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2

        public static List<NamesGeneratorItem> FantasyNamesGeneratorList =
        [
            new() { Name = "allfantasy", DisplayName = "All", CardImage = "assets/icons/dozen.svg", Generator = typeof(AllFantasyNames) },

            new() { Name = "dragonborn", DisplayName = "Dragon Born", CardImage = "assets/icons/dragon-head.svg", Generator = typeof(DragonbornNames) },
            new() { Name = "fantasyhuman", DisplayName = "Human", CardImage = "assets/icons/person.svg", Generator = typeof(HumanNames) },
            new() { Name = "lotrHobbit", DisplayName = "Lord of the Ring Hobbit", CardImage = "assets/icons/hobbit-door.svg", Generator = typeof(LOTRHobbitNames) },

        ];
    }
}