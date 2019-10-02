using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    /// <summary>
    /// Units for measuring quantities of foods
    /// </summary>
    public class MeasureUnit
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Name of the unit
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Abbreviated name of the unit
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }
}