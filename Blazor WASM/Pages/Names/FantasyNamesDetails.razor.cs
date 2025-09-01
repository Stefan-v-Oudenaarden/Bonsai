using Blazor_WASM.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;

namespace Blazor_WASM.Pages.Names
{
    public partial class FantasyNamesDetails
    {
        [Parameter]
        public string? Culture { get; set; }

        public int? NumberOfNames = 10;

        private string CultureDisplayName = "";
        private RandomNameGenerator generator = new HumanNames();
        private List<string> Names = new();
        private List<string> AllNames = new();
        private List<string> MaleNames = new();
        private List<string> FemaleNames = new();
        private string JsonNames = string.Empty;

        protected override void OnParametersSet()
        {
            var culture = (Culture ?? "default").ToLower();

            var FantasyNamesGeneratorList = FantasyNameStaticModel.FantasyNamesGeneratorList;

            var NameGeneratorItem = FantasyNamesGeneratorList.Find((item => item.Name.ToLower() == culture));
            if (NameGeneratorItem != null)
            {
                generator = (RandomNameGenerator?)Activator.CreateInstance(NameGeneratorItem.Generator);

                CultureDisplayName = NameGeneratorItem.DisplayName;
            }
            else
            {
                generator = new AllFantasyNames();
                CultureDisplayName = "Error, Country/Culture not found.";
            }

            Generate();
        }

        protected void Generate()
        {
            Names.Clear();
            MaleNames.Clear();
            FemaleNames.Clear();

            var namesCount = NumberOfNames ?? 10;

            var FemaleNamesCount = namesCount / 2;
            var MaleNamesCount = namesCount - FemaleNamesCount;

            for (int i = 0; i < NumberOfNames; i++)
            {
                FemaleNames.Add(generator.FemaleFullName());
                MaleNames.Add(generator.MaleFullName());
            }

            AllNames = FemaleNames.Concat(MaleNames).OrderBy(_ => Random.Shared.Next()).ToList();

            Names = AllNames.Take(namesCount).ToList();
        }
    }

    internal class NameEntry
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}