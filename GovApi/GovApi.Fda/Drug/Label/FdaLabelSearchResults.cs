using System.Collections.Generic;
using GovApi.Core;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace GovApi.Fda.Drug.Label
{
    public class FdaLabelSearchResults
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("results")]
        public List<LabelResult> Results { get; set; } = new List<LabelResult>();

        /// <summary>
        /// List of errors.
        /// </summary>
        [JsonProperty("error")]
        public Error Error { get; set; } = new Error();

        /// <summary>
        /// Shortcut to <see cref="Error"/> where message contains "No matches found!"
        /// </summary>
        [PublicAPI]
        public bool NotFound => Error.Message?.Contains("No matches found!") ?? false;

        public static FdaLabelSearchResults FromJson(string json) => JsonConvert.DeserializeObject<FdaLabelSearchResults>(json, new BaseJsonSerializerSettings());
    }
}
