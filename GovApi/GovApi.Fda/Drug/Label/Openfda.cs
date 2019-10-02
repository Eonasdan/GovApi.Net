using System;
using System.Collections.Generic;
using GovApi.Core.Converters;
using Newtonsoft.Json;

namespace GovApi.Fda.Drug.Label
{
    public class Openfda
    {
        [JsonProperty("product_ndc")]
        public List<string> ProductNdc { get; set; }

        [JsonProperty("package_ndc")]
        public List<string> PackageNdc { get; set; }

        [JsonProperty("generic_name")]
        public List<string> GenericName { get; set; }

        [JsonProperty("spl_set_id")]
        public List<Guid> SplSetId { get; set; }

        [JsonProperty("brand_name")]
        public List<string> BrandName { get; set; }

        [JsonProperty("original_packager_product_ndc", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OriginalPackagerProductNdc { get; set; }

        [JsonProperty("manufacturer_name")]
        public List<string> ManufacturerName { get; set; }

        [JsonProperty("rxcui")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Rxcui { get; set; }

        [JsonProperty("unii")]
        public List<string> Unii { get; set; }

        [JsonProperty("spl_id")]
        public List<Guid> SplId { get; set; }

        [JsonProperty("substance_name")]
        public List<string> SubstanceName { get; set; }

        [JsonProperty("product_type")]
        public List<string> ProductType { get; set; }

        [JsonProperty("route")]
        public List<string> Route { get; set; }

        [JsonProperty("application_number")]
        public List<string> ApplicationNumber { get; set; }

        [JsonProperty("is_original_packager", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool> IsOriginalPackager { get; set; }

        [JsonProperty("upc", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Upc { get; set; }
    }
}