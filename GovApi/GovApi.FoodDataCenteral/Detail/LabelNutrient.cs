using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class LabelNutrient
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}