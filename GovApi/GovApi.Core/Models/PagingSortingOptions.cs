using Newtonsoft.Json;

namespace GovApi.Core.Models
{
    public class PagingSortingOptions
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Limit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Skip { get; set; }

        public int PageNUmber { get; set; } = 1;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SortDirection { get; set; }
        
    }
}
