using System;
using GovApi.Core.Converters;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Search
{
    public class Food
    {
        /// <summary>
        /// Unique ID of the food. Pass this to the Detail endpoint
        /// </summary>
        [JsonProperty("fdcId")]
        public long FdcId { get; set; }

        /// <summary>
        /// The description of the food.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// GTIN or UPC code identifying the food.
        /// </summary>
        [JsonProperty("gtinUpc", NullValueHandling = NullValueHandling.Ignore)]
        public string Upc { get; set; }

        /// <summary>
        /// Date the item was published to FDC.
        /// </summary>
        [JsonProperty("publishedDate")]
        public DateTimeOffset PublishedDate { get; set; }

        /// <summary>
        /// Brand owner for the food.
        /// </summary>
        [JsonProperty("brandOwner", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandOwner { get; set; }

        /// <summary>
        /// The list of ingredients (as it appears on the product label).
        /// </summary>
        [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public string Ingredients { get; set; }

        /// <summary>
        /// Fields that were found matching the criteria.
        /// </summary>
        [JsonProperty("allHighlightFields")]
        public string AllHighlightFields { get; set; }

        /// <summary>
        /// Relative score indicating how well the food matches the search criteria.
        /// </summary>
        [JsonProperty("score")]
        public double Score { get; set; }
        
        /// <summary>
        /// The scientific name of the food.
        /// </summary>
        [JsonProperty("scientificName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScientificName { get; set; }

        /// <summary>
        /// Unique number assigned for foundation foods.
        /// </summary>
        [JsonProperty("ndbNumber", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? NdbNumber { get; set; }

        /// <summary>
        /// Any additional descriptions of the food.
        /// </summary>
        [JsonProperty("additionalDescriptions", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalDescriptions { get; set; }

        /// <summary>
        /// A unique ID identifying the food within FNDDS.
        /// </summary>
        [JsonProperty("foodCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? FoodCode { get; set; }
    }
}