using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    /// <summary>
    /// A constituent part of a food (e.g. bone is a component of meat)
    /// </summary>
    public class FoodAttribute
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The actual value of the attribute
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// The type of food attribute to which this value is associated for a specific food
        /// </summary>
        [JsonProperty("foodAttributeType")]
        public FoodAttributeType FoodAttributeType { get; set; }

        /// <summary>
        /// The order the attribute will be displayed on the released food.
        /// </summary>
        [JsonProperty("sequenceNumber")]
        public long SequenceNumber { get; set; }
    }
}