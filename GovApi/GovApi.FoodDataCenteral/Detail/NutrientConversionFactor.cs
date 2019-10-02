using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    /// <summary>
    /// The multiplication factors to be used when calculating energy from macronutrients for a specific food
    /// </summary>
    public class NutrientConversionFactor
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// ID of the related row in the nutrient_conversion_factor table
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The multiplication factor for protein
        /// </summary>
        [JsonProperty("proteinValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProteinValue { get; set; }

        /// <summary>
        /// The multiplication factor for fat
        /// </summary>
        [JsonProperty("fatValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? FatValue { get; set; }

        /// <summary>
        /// The multiplication factor for carbohydrates
        /// </summary>
        [JsonProperty("carbohydrateValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? CarbohydrateValue { get; set; }
    }
}