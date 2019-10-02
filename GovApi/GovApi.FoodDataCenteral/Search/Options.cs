using GovApi.Core;
using GovApi.Core.Models;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Search
{
    /// <summary>
    /// Search request parameters. Note that <seealso cref="PagingSortingOptions.Limit"/>
    /// and <seealso cref="PagingSortingOptions.Skip"/> are not used.
    /// </summary>
    public class Options : PagingSortingOptions
    {
        public Options()
        {
            
        }

        /// <summary>
        ///Search query (general text). Api field generalSearchInput
        /// </summary>
        [JsonProperty("generalSearchInput")]
        public string Term { get; set; }

        /// <summary>
        /// Specific data types to include in search.. Api field includeDataTypes
        /// </summary>
        [JsonProperty("includeDataTypes")]
        public IncludeDataTypes IncludeDataTypes { get; set; }

        /// <summary>
        /// The list of ingredients (as it appears on the product label).
        /// </summary>
        public string Ingredients { get; set; }

        /// <summary>
        /// Brand owner for the food.
        /// </summary>
        public string BrandOwner { get; set; }

        /// <summary>
        /// When true, the search will only return foods that contain all of the words that were entered in the search field.
        /// </summary>
        public bool RequiredAllWords { get; set; }

        internal string ConvertToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
