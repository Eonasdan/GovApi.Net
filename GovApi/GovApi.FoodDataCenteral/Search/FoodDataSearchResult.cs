using System.Collections.Generic;
using GovApi.Core;
using Newtonsoft.Json;

namespace GovApi.FoodDataCentral.Search
{
    public class FoodDataSearchResult
    {
        /// <summary>
        /// A copy of the criteria that were used in the search.
        /// </summary>
        [JsonProperty("foodSearchCriteria")]
        public FoodSearchCriteria FoodSearchCriteria { get; set; }

        /// <summary>
        /// The total number of foods found matching the search criteria.
        /// </summary>
        [JsonProperty("totalHits")]
        public long TotalHits { get; set; }

        /// <summary>
        /// The current page of results being returned.
        /// </summary>
        [JsonProperty("currentPage")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// The total number of pages found matching the search criteria.
        /// </summary>
        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// The list of foods found matching the search criteria.
        /// </summary>
        [JsonProperty("foods")]
        public List<Food> Foods { get; set; }

        public static FoodDataSearchResult FromJson(string json) => JsonConvert.DeserializeObject<FoodDataSearchResult>(json, new BaseJsonSerializerSettings());
    }
}
