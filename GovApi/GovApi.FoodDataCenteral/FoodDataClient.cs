using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GovApi.Core;
using GovApi.FoodDataCentral.Detail;
using GovApi.FoodDataCentral.Search;
using JetBrains.Annotations;

namespace GovApi.FoodDataCentral
{
    [UsedImplicitly]
    public class FoodDataClient : JsonBaseClient
    {
        private readonly string _apiKey;
        private static Uri _searchApi;
        
        public FoodDataClient(string apiKey) : base("https://@api.nal.usda.gov/fdc/v1/")
        {
            _apiKey = apiKey;
            _searchApi = new Uri($"search?api_key={apiKey}", UriKind.Relative);
        }

        [PublicAPI]
        public async Task<FoodDataSearchResult> SearchAsync(FoodDataSearchOptions foodDataSearchOptions)
        {
            if (foodDataSearchOptions == null || string.IsNullOrEmpty(foodDataSearchOptions.Term)) 
                return new FoodDataSearchResult(); //technically, the api does return results without any criteria but why?

            var content = new StringContent(foodDataSearchOptions.ConvertToJson(), Encoding.UTF8, "application/json");
            var json = await PostAsync($"search?api_key={_apiKey}", content);

            return FoodDataSearchResult.FromJson(json);
        }

        [PublicAPI]
        public async Task<FoodDataDetailResult> DetailsAsync(int id)
        {
            if (id == 0) return new FoodDataDetailResult();

            var json = await GetAsync($"{id}/?api_key={_apiKey}");

            return FoodDataDetailResult.FromJson(json);
        }

        [PublicAPI]
        public async Task<FoodDataDetailResult> DetailsAsync(long id)
        {
            return await DetailsAsync(Convert.ToInt32(id));
        }
    }
}
