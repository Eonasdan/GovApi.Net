using System;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class NutrientAcquisitionDetail
    {
        [JsonProperty("sampleUnitId")]
        public long SampleUnitId { get; set; }

        /// <summary>
        /// Date the food was purchased
        /// </summary>
        [JsonProperty("purchaseDate")]
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// City where the food was acquired
        /// </summary>
        [JsonProperty("storeCity")]
        public string StoreCity { get; set; }

        /// <summary>
        /// The state where the food was acquired
        /// </summary>
        [JsonProperty("storeState")]
        public string StoreState { get; set; }
    }
}