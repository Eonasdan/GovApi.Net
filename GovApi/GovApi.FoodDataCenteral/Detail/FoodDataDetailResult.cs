using System;
using System.Collections.Generic;
using GovApi.Core;
using GovApi.Core.Converters;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class FoodDataDetailResult
    {
        /// <summary>
        /// For internal use only? Not sure why the api exposes this then.
        /// </summary>
        [JsonProperty("foodClass")]
        public string FoodClass { get; set; }

        /// <summary>
        /// Description of the food
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("foodNutrients")]
        public List<FoodNutrient> FoodNutrients { get; set; }

        /// <summary>
        /// A constituent part of a food (e.g. bone is a component of meat)
        /// </summary>
        [JsonProperty("foodComponents")]
        public List<object> FoodComponents { get; set; } //todo I started FoodComponent but none of the examples I tried actually had values here so I am unsure of the data types

        /// <summary>
        /// A constituent part of a food (e.g. bone is a component of meat)
        /// </summary>
        [JsonProperty("foodAttributes")]
        public List<FoodAttribute> FoodAttributes { get; set; }

        [JsonProperty("tableAliasName")]
        public string TableAliasName { get; set; }

        /// <summary>
        /// The source of the data for this food. GDSN (for GS1) or LI (for Label Insight).
        /// </summary>
        [JsonProperty("dataSource", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSource { get; set; }

        #region Branded Only
        /// <summary>
        /// Brand owner for the food. This is only present when the food data type is "branded"
        /// </summary>
        [JsonProperty("brandOwner", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandOwner { get; set; }

        /// <summary>
        /// GTIN or UPC code identifying the food
        /// </summary>
        [JsonProperty("gtinUpc", NullValueHandling = NullValueHandling.Ignore)]
        public string Upc { get; set; }

        /// <summary>
        /// The list of ingredients (as it appears on the product label)
        /// </summary>
        [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public string Ingredients { get; set; }

        /// <summary>
        /// This date reflects when the product data was last modified by the data provider, i.e., the manufacturer
        /// </summary>
        [JsonProperty("modifiedDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// This is the date when the product record was available for inclusion in the database.
        /// </summary>
        [JsonProperty("availableDate", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableDate { get; set; }

        /// <summary>
        /// The amount of the serving size when expressed as gram or ml
        /// </summary>
        [JsonProperty("servingSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? ServingSize { get; set; }

        /// <summary>
        /// The unit used to express the serving size (gram or ml)
        /// </summary>
        [JsonProperty("servingSizeUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string ServingSizeUnit { get; set; }

        /// <summary>
        /// Amount and unit of serving size when expressed in household units
        /// </summary>
        [JsonProperty("householdServingFullText", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseholdServingFullText { get; set; }


        [JsonProperty("labelNutrients", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, LabelNutrient> LabelNutrients { get; set; }

        /// <summary>
        /// The category of the branded food, assigned by GDSN or Label Insight
        /// </summary>
        [JsonProperty("brandedFoodCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandedFoodCategory { get; set; }

        #endregion

        /// <summary>
        /// ID of the food this food nutrient pertains to
        /// </summary>
        [JsonProperty("fdcId")]
        public long FdcId { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Date when the food was published to FoodData Central
        /// </summary>
        [JsonProperty("publicationDate")]
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// Measures (for foundation or legacy foods), Portions (for survey foods)
        /// </summary>
        [JsonProperty("foodPortions")]
        public List<FoodPortion> FoodPortions { get; set; }

        /// <summary>
        /// The multiplication factors to be used when calculating energy from macronutrients for a specific food
        /// </summary>
        [JsonProperty("nutrientConversionFactors", NullValueHandling = NullValueHandling.Ignore)]
        public List<NutrientConversionFactor> NutrientConversionFactors { get; set; }

        [JsonProperty("isHistoricalReference", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHistoricalReference { get; set; }

        /// <summary>
        /// Unique number assigned for the food, different from fdc_id, assigned in SR
        /// </summary>
        [JsonProperty("ndbNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? NdbNumber { get; set; }

        [JsonProperty("foodCategory", NullValueHandling = NullValueHandling.Ignore)]
        public Food FoodCategory { get; set; }

        [JsonProperty("inputFoods", NullValueHandling = NullValueHandling.Ignore)]
        public List<InputFoodElement> InputFoods { get; set; }

        [JsonProperty("scientificName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScientificName { get; set; }

        /// <summary>
        /// Comments on any unusual aspects of the food nutrient. Examples might include why a nutrient value is different than typically expected.
        /// </summary>
        [JsonProperty("footnote", NullValueHandling = NullValueHandling.Ignore)]
        public string Footnote { get; set; }

        #region Survey
        /// <summary>
        /// A unique ID identifying the food within FNDDS
        /// </summary>
        [JsonProperty("foodCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? FoodCode { get; set; }

        /// <summary>
        /// Start date indicates time period corresponding to WWEIA data 
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// End date indicates time period corresponding to WWEIA data 
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Food categories for fndds
        /// </summary>
        [JsonProperty("wweiaFoodCategory", NullValueHandling = NullValueHandling.Ignore)]
        public WweiaFoodCategory WweiaFoodCategory { get; set; }
        #endregion

        [PublicAPI]
        public static FoodDataDetailResult FromJson(string json) => JsonConvert.DeserializeObject<FoodDataDetailResult>(json, new BaseJsonSerializerSettings());
    }
}
