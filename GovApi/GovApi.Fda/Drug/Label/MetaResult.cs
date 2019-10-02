using Newtonsoft.Json;

namespace GovApi.Fda.Drug.Label
{
    public class MetaResult
    {
        [JsonProperty("skip")]
        public long Skip { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }
}