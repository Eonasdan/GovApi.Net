using GovApi.Core.Converters;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class InputFoodElement
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("foodDescription")]
        public string FoodDescription { get; set; }

        [JsonProperty("inputFood", NullValueHandling = NullValueHandling.Ignore)]
        public InputFoodInputFood InputFood { get; set; }

        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        [JsonProperty("portionDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string PortionDescription { get; set; }

        [JsonProperty("portionCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? PortionCode { get; set; }

        [JsonProperty("srCode", NullValueHandling = NullValueHandling.Ignore)]
        public long? SrCode { get; set; }

        [JsonProperty("srDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string SrDescription { get; set; }

        [JsonProperty("gramWeight", NullValueHandling = NullValueHandling.Ignore)]
        public long? GramWeight { get; set; }

        [JsonProperty("surveyFlag", NullValueHandling = NullValueHandling.Ignore)]
        public long? SurveyFlag { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }

        [JsonProperty("sequenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? SequenceNumber { get; set; }
    }
}