using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GovApi.Core;
using GovApi.FoodDataCentral.Search;
using JetBrains.Annotations;

namespace GovApi.FoodDataCentral
{
    [UsedImplicitly]
    public class Client : JsonBaseClient
    {
        private readonly string _apiKey;
        private static Uri _searchApi;
        
        public Client(string apiKey) : base("https://@api.nal.usda.gov/fdc/v1/")
        {
            _apiKey = apiKey;
            _searchApi = new Uri($"search?api_key={apiKey}", UriKind.Relative);
        }

        [System.Diagnostics.Contracts.Pure]
        [UsedImplicitly]
        public async Task<Result> SearchAsync(Options options)
        {
            if (options == null || string.IsNullOrEmpty(options.Term)) 
                return new Result(); //technically, the api does return results without any criteria but why?

            var content = new StringContent(options.ConvertToJson(), Encoding.UTF8, "application/json");
            var json = await PostAsync($"search?api_key={_apiKey}", content);

            return Result.FromJson(json);
        }

        public async Task<Detail.Result> DetailsAsync(int id)
        {
            if (id == 0) return new Detail.Result();

            var json = await GetAsync($"{id}/?api_key={_apiKey}");

            return Detail.Result.FromJson(json);
        }

        public async Task<Detail.Result> DetailsAsync(long id)
        {
            return await DetailsAsync(Convert.ToInt32(id));
        }
    }
}
