using Blazor_WASM.Models;
using System.Security.Cryptography;

namespace Blazor_WASM.Pages
{
    public partial class NamesDetails
    {
        [Parameter]
        public string? Culture { get; set; }

        private string CultureDisplayName = "";
        private RandomNameGenerator generator = new DutchNames();

        private List<string> Names = new();

        protected override void OnParametersSet()
        {
            var culture = (Culture ?? "default").ToLower();

            var RealNamesGeneratorList = RealNamesStaticModel.RealNamesGeneratorList;

            var NameGeneratorItem = RealNamesGeneratorList.Find((item => item.Name == culture));
            if (NameGeneratorItem != null)
            {
                generator = (RandomNameGenerator?)Activator.CreateInstance(NameGeneratorItem.Generator);

                CultureDisplayName = NameGeneratorItem.DisplayName;
            }
            else
            {
                generator = new AllRealNames();
                CultureDisplayName = "Error, Country/Culture not found.";
            }

            Generate();
        }

        protected void Generate()
        {
            Names.Clear();
            for (int i = 0; i < 20; i++)
            {
                Names.Add(generator.FullName());
            }
        }
    }
}