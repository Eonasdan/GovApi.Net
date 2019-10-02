using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using GovApi.Fda.Drug.Label;
using Newtonsoft.Json;

namespace GovApi.Fda.Extensions
{
    public static class SearchExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchOptions"></param>
        /// <param name="joiner">Supports "AND" or "OR"</param>
        /// <returns></returns>
        public static string ToQuery(this SearchOptions searchOptions, string joiner = "AND") //todo create complex query search
        {
            var search = new StringBuilder();
            searchOptions.GetType().GetProperties().ToList().ForEach(x =>
            {
                var value = x.GetValue(searchOptions);
                if (value == null) return;

                var propertyAttribute = (JsonPropertyAttribute)x.GetCustomAttributes().FirstOrDefault(z => (Type) z.TypeId == typeof(JsonPropertyAttribute));

                if (propertyAttribute == null) return;
                
                if (value.GetType() == typeof(List<string>))
                {
                    search.Append(
                        string.Join("+", (value as List<string> ?? new List<string>())
                            .Select(y => $"{propertyAttribute.PropertyName}:\"{y}\"")
                            )
                        );
                }
                else
                {
                    search.Append($"{propertyAttribute.PropertyName}:\"{value}\"");
                }

                search.Append($"+{joiner}+");
            });

            return search.ToString().Trim($"+{joiner}+".ToCharArray());
        }
    }
}
