using System;
using System.Collections.Generic;
using GovApi.Core;
using GovApi.Core.Converters;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
    public class Result
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
        public static Result FromJson(string json) => JsonConvert.DeserializeObject<Result>(json, new BaseJsonSerializerSettings());
    }

    public class FoodComponent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of the food this food component pertains to
        /// </summary>
        [JsonProperty("fdcId")]
        public long FdcId { get; set; }

        /// <summary>
        /// The kind  of component, e.g. bone
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gramWeight")]
        public double GramWeight { get; set; }

        [JsonProperty("dataPoints")]
        public long? DataPoints { get; set; }

        [JsonProperty("minYearAcquired")]
        public long? MinYearAcquired { get; set; }


        /*
         * pct_weight
         * is_refuse
         */

    }

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

    public class Food
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Code used for the source (e.g. 4 means calculated or imputed)
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Description of the source
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// An information source from which we can obtain food nutrient values
        /// </summary>
        [JsonProperty("foodNutrientSource", NullValueHandling = NullValueHandling.Ignore)]
        public Food FoodNutrientSource { get; set; }
    }

    public class FoodNutrient
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("nutrient")]
        public Nutrient Nutrient { get; set; }

        [JsonProperty("foodNutrientDerivation", NullValueHandling = NullValueHandling.Ignore)]
        public Food FoodNutrientDerivation { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>
        /// Number of observations on which the value is based
        /// </summary>
        [JsonProperty("dataPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? DataPoints { get; set; }

        /// <summary>
        /// The maximum amount
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        /// <summary>
        /// The minimum amount
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        /// <summary>
        /// The median amount
        /// </summary>
        [JsonProperty("median", NullValueHandling = NullValueHandling.Ignore)]
        public double? Median { get; set; }

        [JsonProperty("nutrientAnalysisDetails", NullValueHandling = NullValueHandling.Ignore)]
        public List<NutrientAnalysisDetail> NutrientAnalysisDetails { get; set; }

        /// <summary>
        /// Minimum purchase year of all acquisitions used to derive the nutrient value
        /// </summary>
        [JsonProperty("minYearAcquired", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinYearAcquired { get; set; }
    }

    public class Nutrient
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }
    }

    public class NutrientAnalysisDetail
    {
        /// <summary>
        /// ID of the sample food from which the sub sample originated
        /// </summary>
        [JsonProperty("subSampleId")]
        public long SubSampleId { get; set; }

        /// <summary>
        /// Amount of the nutrient
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Nutrient Id from FoodNutrients -> Nutrient -> Id <seealso cref="Nutrient.Id"/>
        /// </summary>
        [JsonProperty("nutrientId")]
        public long NutrientId { get; set; }

        [JsonProperty("nutrientAcquisitionDetails")]
        public List<NutrientAcquisitionDetail> NutrientAcquisitionDetails { get; set; }

        /// <summary>
        /// Lab method used to analyze the nutrient
        /// </summary>
        [JsonProperty("labMethodDescription")]
        public string LabMethodDescription { get; set; }

        /// <summary>
        /// General chemical analysis approach used by the lab method
        /// </summary>
        [JsonProperty("labMethodTechnique")]
        public string LabMethodTechnique { get; set; }

        /// <summary>
        /// Description of the lab method
        /// </summary>
        [JsonProperty("labMethodOriginalDescription")]
        public string LabMethodOriginalDescription { get; set; }
    }

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

    /// <summary>
    /// Measures (for foundation or legacy foods), Portions (for survey foods)
    /// </summary>
    public class FoodPortion
    {
        /// <summary>
        /// ID of the food this food portion pertains to
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The unit used for the measure (e.g. if measure is 3 tsp, the unit is tsp). For food types that do not use measure SR legacy foods and survey (FNDDS) foods), a value of '9999' is assigned to this field.
        /// </summary>
        [JsonProperty("measureUnit")]
        public MeasureUnit MeasureUnit { get; set; }

        /// <summary>
        /// The weight of the measure in grams
        /// </summary>
        [JsonProperty("gramWeight")]
        public double GramWeight { get; set; }

        /// <summary>
        /// The number of observations on which the measure is based
        /// </summary>
        [JsonProperty("dataPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? DataPoints { get; set; }

        /// <summary>
        /// Minimum purchase year of all acquisitions used to derive the measure value
        /// </summary>
        [JsonProperty("minYearAcquired", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinYearAcquired { get; set; }

        /// <summary>
        /// The number of measure units that comprise the measure (e.g. if measure is 3 tsp, the amount is 3). Not defined for survey (FNDDS) foods (amount is instead embedded in portion description).
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }

        /// <summary>
        /// The order the measure will be displayed on the released food.
        /// </summary>
        [JsonProperty("sequenceNumber")]
        public long SequenceNumber { get; set; }

        /// <summary>
        /// Foundation foods: Comments that provide more specificity on the measure. For example, for a pizza measure the dissemination text might be 1 slice is 1/8th of a 14 inch pizza"." Survey (FNDDS) foods: The household description of the portion.  
        /// </summary>
        [JsonProperty("portionDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string PortionDescription { get; set; }

        /// <summary>
        /// Foundation foods: Qualifier of the measure (e.g. related to food shape or form)  (e.g. melted, crushed, diced). Survey (FNDDS) foods: The portion code. SR legacy foods: description of measures, including the unit of measure and the measure modifier (e.g. waffle round (4" dia)). 
        /// </summary>
        [JsonProperty("modifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Modifier { get; set; }
    }

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

    public class LabelNutrient
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    /// <summary>
    /// The multiplication factors to be used when calculating energy from macronutrients for a specific food
    /// </summary>
    public class NutrientConversionFactor
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// ID of the related row in the nutrient_conversion_factor table
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The multiplication factor for protein
        /// </summary>
        [JsonProperty("proteinValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProteinValue { get; set; }

        /// <summary>
        /// The multiplication factor for fat
        /// </summary>
        [JsonProperty("fatValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? FatValue { get; set; }

        /// <summary>
        /// The multiplication factor for carbohydrates
        /// </summary>
        [JsonProperty("carbohydrateValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? CarbohydrateValue { get; set; }
    }

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
