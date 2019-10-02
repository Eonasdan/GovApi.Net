using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class InputFoodInputFood
    {
        [JsonProperty("foodClass")]
        public string FoodClass { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tableAliasName")]
        public string TableAliasName { get; set; }

        [JsonProperty("fdcId")]
        public long FdcId { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("publicationDate")]
        public string PublicationDate { get; set; }

        [JsonProperty("foodCategory")]
        public Food FoodCategory { get; set; }
    }
}