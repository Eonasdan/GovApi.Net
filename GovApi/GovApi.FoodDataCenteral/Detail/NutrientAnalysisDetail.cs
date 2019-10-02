using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Detail
{
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
}