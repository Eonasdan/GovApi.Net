using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class Nutrient
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }
    }
}