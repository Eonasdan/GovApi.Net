using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Search
{
    public class FoodSearchCriteria
    {
        [JsonProperty("includeDataTypes")]
        public IncludeDataTypes IncludeDataTypes { get; set; }

        [JsonProperty("generalSearchInput")]
        public string GeneralSearchInput { get; set; }

        [JsonProperty("pageNumber")]
        public long PageNumber { get; set; }

        [JsonProperty("requireAllWords")]
        public bool RequireAllWords { get; set; }
    }
}