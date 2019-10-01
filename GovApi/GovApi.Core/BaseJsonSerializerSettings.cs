using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GovApi.Core
{
    internal class BaseJsonSerializerSettings : JsonSerializerSettings
    {
        public BaseJsonSerializerSettings()
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            DateParseHandling = DateParseHandling.None;
            Converters = new List<JsonConverter>
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            };
        }
    }
}