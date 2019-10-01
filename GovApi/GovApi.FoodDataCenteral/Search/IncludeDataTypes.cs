using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Search
{
    public class IncludeDataTypes
    {
        [JsonProperty("Survey (FNDDS)")]
        public bool Survey { get; set; }

        [JsonProperty("Foundation")]
        public bool Foundation { get; set; }

        [JsonProperty("Branded")]
        public bool Branded { get; set; }

        [JsonProperty("SR Legacy")]
        public bool Legacy { get; set; }
    }
}