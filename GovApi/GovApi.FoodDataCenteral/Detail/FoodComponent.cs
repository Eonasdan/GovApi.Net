using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class FoodComponent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of the food this food component pertains to
        /// </summary>
        [JsonProperty("fdcId")]
        public long FdcId { get; set; }

        /// <summary>
        /// The kind  of component, e.g. bone
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gramWeight")]
        public double GramWeight { get; set; }

        [JsonProperty("dataPoints")]
        public long? DataPoints { get; set; }

        [JsonProperty("minYearAcquired")]
        public long? MinYearAcquired { get; set; }


        /*
         * pct_weight
         * is_refuse
         */

    }
}