using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace GovApi.Core.Models
{
    internal class ParameterDictionary : List<KeyValuePair<string, string>>
    {
        public void Add(string key, string value)
        {
            Add(new KeyValuePair<string, string>(key, value));
        }

        public void SafeAdd(string key, string value)
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value)) return;
            Add(key, value);
        }

        /// <summary>
        /// Converts each item to [key]=[value] and then joins each with "&amp;"
        /// </summary>
        /// <returns></returns>
        public string ToQueryString()
        {
            var parameters = this.Where(parameter => parameter.Value != null)
                .Select(parameter => $"{parameter.Key}={WebUtility.UrlEncode(parameter.Value)}");

            return string.Join("&", parameters);
        }
    }
}
