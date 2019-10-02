using System;
using System.Collections.Generic;
using GovApi.Core;
using GovApi.Core.Converters;
using Newtonsoft.Json;

namespace GovApi.Fda.Drug.Label
{
    public class Result
    {
        [JsonProperty("effective_time")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long EffectiveTime { get; set; }

        [JsonProperty("purpose")]
        public List<string> Purpose { get; set; }

        [JsonProperty("keep_out_of_reach_of_children")]
        public List<string> KeepOutOfReachOfChildren { get; set; }

        [JsonProperty("questions")]
        public List<string> Questions { get; set; }

        [JsonProperty("when_using")]
        public List<string> WhenUsing { get; set; }

        [JsonProperty("pregnancy_or_breast_feeding")]
        public List<string> PregnancyOrBreastFeeding { get; set; }

        [JsonProperty("storage_and_handling")]
        public List<string> StorageAndHandling { get; set; }

        [JsonProperty("indications_and_usage")]
        public List<string> IndicationsAndUsage { get; set; }

        [JsonProperty("set_id")]
        public Guid SetId { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("ask_doctor_or_pharmacist")]
        public List<string> AskDoctorOrPharmacist { get; set; }

        [JsonProperty("active_ingredient")]
        public List<string> ActiveIngredient { get; set; }

        [JsonProperty("dosage_and_administration_table")]
        public List<string> DosageAndAdministrationTable { get; set; }

        [JsonProperty("inactive_ingredient")]
        public List<string> InactiveIngredient { get; set; }

        [JsonProperty("warnings")]
        public List<string> Warnings { get; set; }

        [JsonProperty("spl_product_data_elements")]
        public List<string> SplProductDataElements { get; set; }

        [JsonProperty("ask_doctor")]
        public List<string> AskDoctor { get; set; }

        [JsonProperty("openfda")]
        public Openfda Openfda { get; set; }

        [JsonProperty("version")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Version { get; set; }

        [JsonProperty("dosage_and_administration")]
        public List<string> DosageAndAdministration { get; set; }

        [JsonProperty("stop_use")]
        public List<string> StopUse { get; set; }

        [JsonProperty("spl_unclassified_section")]
        public List<string> SplUnclassifiedSection { get; set; }

        [JsonProperty("do_not_use")]
        public List<string> DoNotUse { get; set; }

        [JsonProperty("package_label_principal_display_panel")]
        public List<string> PackageLabelPrincipalDisplayPanel { get; set; }

        [JsonProperty("active_ingredient_table", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ActiveIngredientTable { get; set; }

        [JsonProperty("purpose_table", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PurposeTable { get; set; }
    }
}