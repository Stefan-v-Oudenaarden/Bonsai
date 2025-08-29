namespace Blazor_WASM.Models
{
    public class NamesGeneratorItem
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public Type Generator { get; set; }
        public string CardImage { get; set; }
    }

    public static class RealNamesStaticModel
    {
        //Country code list / easy access to wikimedia flag svg through country link
        // https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2

        public static List<NamesGeneratorItem> RealNamesGeneratorList =
        [
            new() { Name = "global", DisplayName = "All", CardImage = "assets/flags/globe.svg", Generator = typeof(AllRealNames) },

            new() { Name = "american", DisplayName = "American", CardImage = "assets/flags/us.svg", Generator = typeof(AmericanNames) },
            new() { Name = "chinese", DisplayName = "Chinese", CardImage = "assets/flags/cn.svg", Generator = typeof(ChineseNames) },
            new() { Name = "dutch", DisplayName = "Dutch", CardImage = "assets/flags/nl.svg", Generator = typeof(DutchNames) },
            new() { Name = "french", DisplayName = "French", CardImage = "assets/flags/fr.svg", Generator = typeof(FrenchNames) },
            new() { Name = "greek", DisplayName = "Greek", CardImage = "assets/flags/gr.svg", Generator = typeof(GreekNames) },
            new() { Name = "korean", DisplayName = "Korean", CardImage = "assets/flags/kr.svg", Generator = typeof(KoreanNames) },
            new() { Name = "latin-american", DisplayName = "Latin American", CardImage = "assets/img/latin-america-map.png", Generator = typeof(LatinAmericanNames) },
            new() { Name = "nigerean", DisplayName = "Nigerian", CardImage = "assets/flags/ng.svg", Generator = typeof(NigerianNames) },
        ];
    }
}