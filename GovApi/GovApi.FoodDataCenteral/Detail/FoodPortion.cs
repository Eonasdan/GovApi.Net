using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
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
}