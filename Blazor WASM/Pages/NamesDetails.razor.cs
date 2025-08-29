using Blazor_WASM.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;

namespace Blazor_WASM.Pages
{
    public partial class NamesDetails
    {
        [Parameter]
        public string? Culture { get; set; }

        public int? NumberOfNames = 10;

        private string CultureDisplayName = "";
        private RandomNameGenerator generator = new DutchNames();
        private List<string> Names = new();
        private List<string> AllNames = new();
        private List<string> MaleNames = new();
        private List<string> FemaleNames = new();
        private string JsonNames = string.Empty;

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
            GenerateJson();
        }

        protected void GenerateJson()
        {
            var entries = new List<NameEntry>();

            for (int i = 0; i < NumberOfNames; i++)
            {
                string name = "";
                string gender = "";

                if (Random.Shared.Next(2) == 0)
                {
                    name = generator.FemaleFullName();
                    gender = "female";
                }
                else
                {
                    name = generator.MaleFullName();
                    gender = "male";
                }

                var entry = new NameEntry { Gender = gender, Name = name };
                entries.Add(entry);
            }

            JsonNames = JsonSerializer.Serialize(entries, new JsonSerializerOptions() { WriteIndented = true });
            Console.WriteLine(entries);
        }

        protected void NumberInputValueChanged(int i)
        {
        }
    }

    internal class NameEntry
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}