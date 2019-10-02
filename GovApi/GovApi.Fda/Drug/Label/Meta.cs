using System;
using Newtonsoft.Json;

namespace GovApi.Fda.Drug.Label
{
    public class Meta
    {
        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("results")]
        public MetaResult MetaResult { get; set; }
    }
}