using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class Food
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Code used for the source (e.g. 4 means calculated or imputed)
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Description of the source
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// An information source from which we can obtain food nutrient values
        /// </summary>
        [JsonProperty("foodNutrientSource", NullValueHandling = NullValueHandling.Ignore)]
        public Food FoodNutrientSource { get; set; }
    }
}