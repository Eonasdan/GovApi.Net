using System;
using System.Linq;
using System.Threading.Tasks;
using GovApi.Fda.Drug.Label;
using GovApi.FoodDataCentral;
using GovApi.FoodDataCentral.Search;

namespace GovApi.Example
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await TestFoodDataAsync();
            await TestFdaAsync();
        }

        private static async Task TestFdaAsync()
        {
            using var client = new Fda.FdaClient();
            var searchResult = await client.SearchAsync(new FdaLabelSearchOptions //search for drugs that cause drowsiness when used
            {
                WhenUsing = "drowsiness"
            });
            var breakpoint = 1;
        }

        private static async Task TestFoodDataAsync()
        {
            using var client = new FoodDataClient("DEMO_KEY");
            var searchAsync = await client.SearchAsync(new FoodDataSearchOptions
            {
                Term = "chocolate",
                IncludeDataTypes = new IncludeDataTypes
                {
                    Branded = true,
                    Foundation = true,
                    Legacy = true,
                    Survey = false
                }
            });
            var breakpoint = 1;

            var detailsAsync = await client.DetailsAsync(searchAsync.Foods.FirstOrDefault().FdcId);

            breakpoint = 1;
        }

    }
}
