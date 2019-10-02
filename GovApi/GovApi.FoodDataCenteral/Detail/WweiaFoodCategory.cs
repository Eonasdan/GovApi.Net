using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    /// <summary>
    /// Food categories for fndds
    /// </summary>
    public class WweiaFoodCategory
    {
        /// <summary>
        /// Unique identification code
        /// </summary>
        [JsonProperty("wweiaFoodCategoryCode")]
        public long WweiaFoodCategoryCode { get; set; }

        /// <summary>
        /// Description for a WWEIA Category
        /// </summary>
        [JsonProperty("wweiaFoodCategoryDescription")]
        public string WweiaFoodCategoryDescription { get; set; }
    }
}