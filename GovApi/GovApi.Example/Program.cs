using System;
using System.Linq;
using System.Threading.Tasks;
using GovApi.FoodDataCentral;
using GovApi.FoodDataCentral.Search;

namespace GovApi.Example
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await TestFoodDataAsync();
        }

        private static async Task TestFoodDataAsync()
        {
            using var client = new Client("DEMO_KEY");
            var searchAsync = await client.SearchAsync(new Options
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
}
