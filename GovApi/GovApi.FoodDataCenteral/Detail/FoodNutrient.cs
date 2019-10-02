using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class FoodNutrient
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("nutrient")]
        public Nutrient Nutrient { get; set; }

        [JsonProperty("foodNutrientDerivation", NullValueHandling = NullValueHandling.Ignore)]
        public Food FoodNutrientDerivation { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>
        /// Number of observations on which the value is based
        /// </summary>
        [JsonProperty("dataPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? DataPoints { get; set; }

        /// <summary>
        /// The maximum amount
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        /// <summary>
        /// The minimum amount
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        /// <summary>
        /// The median amount
        /// </summary>
        [JsonProperty("median", NullValueHandling = NullValueHandling.Ignore)]
        public double? Median { get; set; }

        [JsonProperty("nutrientAnalysisDetails", NullValueHandling = NullValueHandling.Ignore)]
        public List<NutrientAnalysisDetail> NutrientAnalysisDetails { get; set; }

        /// <summary>
        /// Minimum purchase year of all acquisitions used to derive the nutrient value
        /// </summary>
        [JsonProperty("minYearAcquired", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinYearAcquired { get; set; }
    }
}