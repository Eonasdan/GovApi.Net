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
    public class FdaClient : JsonBaseClient
    {
        private readonly string _apiKey;
        
        public FdaClient() : base("https://api.fda.gov")
        { }

        public FdaClient(string apiKey) : this()
        {
            _apiKey = apiKey;
        }

        [System.Diagnostics.Contracts.Pure]
        [UsedImplicitly]
        public async Task<FdaLabelSearchResults> SearchAsync(FdaLabelSearchOptions fdaLabelSearchOptions, PagingSortingOptions pagingOptions = null, string joiner = "AND")
        {
            if (pagingOptions == null) pagingOptions = new PagingSortingOptions();

            var parameterDictionary = new ParameterDictionary
            {
                { "search", fdaLabelSearchOptions.ToQuery(joiner) }
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


            return FdaLabelSearchResults.FromJson(json);
        }
    }
}
