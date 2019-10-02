using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class FoodAttributeType
    {
        /// <summary>
        /// ID of the type of food attribute to which this value is associated for a specific food
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Name of the attribute associated with the food.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the attribute
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}