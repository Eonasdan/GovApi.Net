using System;
using System.Threading.Tasks;
using GovApi.Core;
using GovApi.Core.Models;
using GovApi.Fda.Drug.Label;
using GovApi.Fda.Extensions;
using JetBrains.Annotations;

namespace GovApi.Fda
{
    [PublicAPI]
    public class Client : JsonBaseClient
    {
        private readonly string _apiKey;
        
        public Client() : base("https://api.fda.gov")
        { }

        public Client(string apiKey) : this()
        {
            _apiKey = apiKey;
        }

        [System.Diagnostics.Contracts.Pure]
        [UsedImplicitly]
        public async Task<Search> SearchAsync(SearchOptions searchOptions, PagingSortingOptions pagingOptions = null, string joiner = "AND")
        {
            if (pagingOptions == null) pagingOptions = new PagingSortingOptions();

            var parameterDictionary = new ParameterDictionary
            {
                { "search", searchOptions.ToQuery(joiner) }
            };

            if (pagingOptions.Limit != 0)
            {
                parameterDictionary.Add("limit", pagingOptions.Limit.ToString());
            }
            if (pagingOptions.Skip != 0)
            {
                parameterDictionary.Add("skip", pagingOptions.Skip.ToString());
            }

            if (!string.IsNullOrEmpty(_apiKey)) parameterDictionary.Add("api_key", _apiKey);
            
            var json = await GetAsync($"/drug/label.json?{parameterDictionary.ToQueryString()}");


            return Search.FromJson(json);
        }
    }
}
