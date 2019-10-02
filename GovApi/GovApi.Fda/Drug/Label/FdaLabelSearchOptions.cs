using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace GovApi.Fda.Drug.Label
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    public class FdaLabelSearchOptions
    {
        ///<summary>
        ///The Set ID, A globally unique identifier (GUID) for the labeling, stable across all versions or revisions.
        ///</summary>
        [JsonProperty("set_id")]
        public string SetId { get; set; }

        ///<summary>
        ///The document ID, A globally unique identifier (GUID) for the particular revision of a labeling document.
        ///</summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        ///<summary>
        ///A sequentially increasing number identifying the particular version of a document, starting with 1.
        ///</summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        ///<summary>
        ///Date reference to the particular version of the labeling document.
        ///</summary>
        [JsonProperty("effective_time")]
        public string EffectiveTime { get; set; }

        ///<summary>
        ///Information about whether the drug is a controlled substance, the types of abuse that can occur with the drug, and adverse reactions pertinent to those types of abuse.
        ///</summary>
        [JsonProperty("drug_abuse_and_dependence")]
        public string DrugAbuseAndDependence { get; set; }

        ///<summary>
        ///Information about the schedule in which the drug is controlled by the Drug Enforcement Administration, if applicable.
        ///</summary>
        [JsonProperty("controlled_substance")]
        public string ControlledSubstance { get; set; }

        ///<summary>
        ///Information about the types of abuse that can occur with the drug and adverse reactions pertinent to those types of abuse, primarily based on human data. May include descriptions of particularly susceptible patient populations.
        ///</summary>
        [JsonProperty("abuse")]
        public string Abuse { get; set; }

        ///<summary>
        ///Information about characteristic effects resulting from both psychological and physical dependence that occur with the drug, the quantity of drug over a period of time that may lead to tolerance or dependence, details of adverse effects related to chronic abuse and the effects of abrupt withdrawal, procedures necessary to diagnose the dependent state, and principles of treating the effects of abrupt withdrawal.
        ///</summary>
        [JsonProperty("dependence")]
        public string Dependence { get; set; }

        ///<summary>
        ///Information about signs, symptoms, and laboratory findings of acute overdosage and the general principles of overdose treatment.
        ///</summary>
        [JsonProperty("overdosage")]
        public string Overdosage { get; set; }

        ///<summary>
        ///Information about undesirable effects, reasonably associated with use of the drug, that may occur as part of the pharmacological action of the drug or may be unpredictable in its occurrence. Adverse reactions include those that occur with the drug, and if applicable, with drugs in the same pharmacologically active and chemically related class. There is considerable variation in the listing of adverse reactions. They may be categorized by organ system, by severity of reaction, by frequency, by toxicological mechanism, or by a combination of these.
        ///</summary>
        [JsonProperty("adverse_reactions")]
        public string AdverseReactions { get; set; }

        ///<summary>
        ///Information about and practical guidance on preventing clinically significant drug/drug and drug/food interactions that may occur in people taking the drug.
        ///</summary>
        [JsonProperty("drug_interactions")]
        public string DrugInteractions { get; set; }

        ///<summary>
        ///Information about any known interference by the drug with laboratory tests.
        ///</summary>
        [JsonProperty("drug_and_or_laboratory_test_interactions")]
        public string DrugAndOrLaboratoryTestInteractions { get; set; }

        ///<summary>
        ///Information about the clinical pharmacology and actions of the drug in humans.
        ///</summary>
        [JsonProperty("clinical_pharmacology")]
        public string ClinicalPharmacology { get; set; }

        ///<summary>
        ///Information about the established mechanism(s) of the drug's action in humans at various levels (for example receptor, membrane, tissue, organ, whole body). If the mechanism of action is not known, this field contains a statement about the lack of information.
        ///</summary>
        [JsonProperty("mechanism_of_action")]
        public string MechanismOfAction { get; set; }

        ///<summary>
        ///Information about any biochemical or physiologic pharmacologic effects of the drug or active metabolites related to the drugÕs clinical effect in preventing, diagnosing, mitigating, curing, or treating disease, or those related to adverse effects or toxicity.
        ///</summary>
        [JsonProperty("pharmacodynamics")]
        public string Pharmacodynamics { get; set; }

        ///<summary>
        ///Information about the clinically significant pharmacokinetics of a drug or active metabolites, for instance pertinent absorption, distribution, metabolism, and excretion parameters.
        ///</summary>
        [JsonProperty("pharmacokinetics")]
        public string Pharmacokinetics { get; set; }

        ///<summary>
        ///A statement of each of the drug productÕs indications for use, such as for the treatment, prevention, mitigation, cure, or diagnosis of a disease or condition, or of a manifestation of a recognized disease or condition, or for the relief of symptoms associated with a recognized disease or condition. This field may also describe any relevant limitations of use.
        ///</summary>
        [JsonProperty("indications_and_usage")]
        public string IndicationsAndUsage { get; set; }

        ///<summary>
        ///Information about situations in which the drug product is contraindicated or should not be used because the risk of use clearly outweighs any possible benefit, including the type and nature of reactions that have been reported.
        ///</summary>
        [JsonProperty("contraindications")]
        public string Contraindications { get; set; }

        ///<summary>
        ///Information about the drug product’s dosage and administration recommendations, including starting dose, dose range, titration regimens, and any other clinically significant information that affects dosing recommendations.
        ///</summary>
        [JsonProperty("dosage_and_administration")]
        public string DosageAndAdministration { get; set; }

        ///<summary>
        ///Information about all available dosage forms and strengths for the drug product to which the labeling applies. This field may contain descriptions of product appearance.
        ///</summary>
        [JsonProperty("dosage_forms_and_strengths")]
        public string DosageFormsAndStrengths { get; set; }

        ///<summary>
        ///Information about the drug product’s indications for use.
        ///</summary>
        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        ///<summary>
        ///General information about the drug product, including the proprietary and established name of the drug, the type of dosage form and route of administration to which the label applies, qualitative and quantitative ingredient information, the pharmacologic or therapeutic class of the drug, and the chemical name and structural formula of the drug.
        ///</summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        ///<summary>
        ///A list of the active, medicinal ingredients in the drug product.
        ///</summary>
        [JsonProperty("active_ingredient")]
        public string ActiveIngredient { get; set; }

        ///<summary>
        ///A list of inactive, non-medicinal ingredients in a drug product.
        ///</summary>
        [JsonProperty("inactive_ingredient")]
        public string InactiveIngredient { get; set; }

        ///<summary>
        ///Usually a list of ingredients in a drug product.
        ///</summary>
        [JsonProperty("spl_product_data_elements")]
        public string SplProductDataElements { get; set; }

        ///<summary>
        ///Information necessary for patients to use the drug safely and effectively.
        ///</summary>
        [JsonProperty("spl_patient_package_insert")]
        public string SplPatientPackageInsert { get; set; }

        ///<summary>
        ///Information necessary for patients to use the drug safely and effectively, such as precautions concerning driving or the concomitant use of other substances that may have harmful additive effects.
        ///</summary>
        [JsonProperty("information_for_patients")]
        public string InformationForPatients { get; set; }

        ///<summary>
        ///Documentation forthcoming.
        ///</summary>
        [JsonProperty("information_for_owners_or_caregivers")]
        public string InformationForOwnersOrCaregivers { get; set; }

        ///<summary>
        ///Information about safe handling and use of the drug product.
        ///</summary>
        [JsonProperty("instructions_for_use")]
        public string InstructionsForUse { get; set; }

        ///<summary>
        ///Information about when a doctor should be consulted about existing conditions or symptoms before using the drug product, including all warnings for persons with certain preexisting conditions (excluding pregnancy) and all warnings for persons experiencing certain symptoms. The warnings under this heading are those intended only for situations in which consumers should not use the product until a doctor is consulted.
        ///</summary>
        [JsonProperty("ask_doctor")]
        public string AskDoctor { get; set; }

        ///<summary>
        ///Information about when a doctor or pharmacist should be consulted about drug/drug or drug/food interactions before using a drug product.
        ///</summary>
        [JsonProperty("ask_doctor_or_pharmacist")]
        public string AskDoctorOrPharmacist { get; set; }

        ///<summary>
        ///Information about all contraindications for use. These contraindications are absolute and are intended for situations in which consumers should not use the product unless a prior diagnosis has been established by a doctor or for situations in which certain consumers should not use the product under any circumstances regardless of whether a doctor or health professional is consulted.
        ///</summary>
        [JsonProperty("do_not_use")]
        public string DoNotUse { get; set; }

        ///<summary>
        ///Information pertaining to whether the product should be kept out of the reach of children, and instructions about what to do in the case of accidental contact or ingestion, if appropriate.
        ///</summary>
        [JsonProperty("keep_out_of_reach_of_children")]
        public string KeepOutOfReachOfChildren { get; set; }

        ///<summary>
        ///Information about safe use and handling of the product that may not have been specified in another field.
        ///</summary>
        [JsonProperty("other_safety_information")]
        public string OtherSafetyInformation { get; set; }

        ///<summary>
        ///A telephone number of a source to answer questions about a drug product. Sometimes available days and times are also noted.
        ///</summary>
        [JsonProperty("questions")]
        public string Questions { get; set; }

        ///<summary>
        ///Information about when use of the drug product should be discontinued immediately and a doctor consulted. Includes information about any signs of toxicity or other reactions that would necessitate immediately discontinuing use of the product.
        ///</summary>
        [JsonProperty("stop_use")]
        public string StopUse { get; set; }

        ///<summary>
        ///Information about side effects that people may experience, and the substances (e.g. alcohol) or activities (e.g. operating machinery, driving a car) to avoid while using the drug product.
        ///</summary>
        [JsonProperty("when_using")]
        public string WhenUsing { get; set; }

        ///<summary>
        ///Information or instructions to patients about safe use of the drug product, sometimes including a reference to a patient medication guide or counseling materials.
        ///</summary>
        [JsonProperty("patient_medication_information")]
        public string PatientMedicationInformation { get; set; }

        ///<summary>
        ///Information about the patient medication guide that accompanies the drug product. Certain drugs must be dispensed with an accompanying medication guide. This field may contain information about when to consult the medication guide and the contents of the medication guide.
        ///</summary>
        // ReSharper disable once StringLiteralTypo
        [JsonProperty("spl_medguide")]
        public string SplMedGuide { get; set; }

        ///<summary>
        ///Information about use of the drug by patients in specific populations, including pregnant women and nursing mothers, pediatric patients, and geriatric patients.
        ///</summary>
        [JsonProperty("use_in_specific_populations")]
        public string UseInSpecificPopulations { get; set; }

        ///<summary>
        ///Information about effects the drug may have on pregnant women or on a fetus. This field may be omitted if the drug is not absorbed systemically and the drug is not known to have a potential for indirect harm to the fetus. It may contain information about the established pregnancy category classification for the drug. (That information is nominally listed in the <see cref="TeratogenicEffects"/> field, but may be listed here instead.)
        ///</summary>
        [JsonProperty("pregnancy")]
        public string Pregnancy { get; set; }

        ///<summary>
        ///Pregnancy category A: Adequate and well-controlled studies in pregnant women have failed to demonstrate a risk to the fetus in the first trimester of pregnancy, and there is no evidence of a risk in later trimesters. Pregnancy category B: Animal reproduction studies have failed to demonstrate a risk to the fetus and there are no adequate and well-controlled studies in pregnant women. Pregnancy category C: Animal reproduction studies have shown an adverse effect on the fetus, there are no adequate and well-controlled studies in humans, and the benefits from the use of the drug in pregnant women may be acceptable despite its potential risks. Pregnancy category D: There is positive evidence of human fetal risk based on adverse reaction data from investigational or marketing experience or studies in humans, but the potential benefits from the use of the drug in pregnant women may be acceptable despite its potential risks (for example, if the drug is needed in a life-threatening situation or serious disease for which safer drugs cannot be used or are ineffective). Pregnancy category X: Studies in animals or humans have demonstrated fetal abnormalities or there is positive evidence of fetal risk based on adverse reaction reports from investigational or marketing experience, or both, and the risk of the use of the drug in a pregnant woman clearly outweighs any possible benefit (for example, safer drugs or other forms of therapy are available).
        ///</summary>
        [JsonProperty("teratogenic_effects")]
        public string TeratogenicEffects { get; set; }

        ///<summary>
        ///Information about the drug’s use during labor or delivery, whether or not the use is stated in the indications section of the labeling, including the effect of the drug on the mother and fetus, on the duration of labor or delivery, on the possibility of delivery-related interventions, and the effect of the drug on the later growth, development, and functional maturation of the child.
        ///</summary>
        [JsonProperty("labor_and_delivery")]
        public string LaborAndDelivery { get; set; }

        ///<summary>
        ///Information about excretion of the drug in human milk and effects on the nursing infant, including pertinent adverse effects observed in animal offspring.
        ///</summary>
        [JsonProperty("nursing_mothers")]
        public string NursingMothers { get; set; }

        ///<summary>
        ///Documentation forthcoming.
        ///</summary>
        [JsonProperty("pregnancy_or_breast_feeding")]
        public string PregnancyOrBreastFeeding { get; set; }

        ///<summary>
        ///Information about any limitations on any pediatric indications, needs for specific monitoring, hazards associated with use of the drug in any subsets of the pediatric population (such as neonates, infants, children, or adolescents), differences between pediatric and adult responses to the drug, and other information related to the safe and effective pediatric use of the drug.
        ///</summary>
        [JsonProperty("pediatric_use")]
        public string PediatricUse { get; set; }

        ///<summary>
        ///Information about any limitations on any geriatric indications, needs for specific monitoring, hazards associated with use of the drug in the geriatric population.
        ///</summary>
        [JsonProperty("geriatric_use")]
        public string GeriatricUse { get; set; }

        ///<summary>
        ///Information about toxicology in non-human subjects.
        ///</summary>
        [JsonProperty("nonclinical_toxicology")]
        public string NonclinicalToxicology { get; set; }

        ///<summary>
        ///Information about carcinogenic, mutagenic, or fertility impairment potential revealed by studies in animals. Information from human data about such potential is part of the warnings field.
        ///</summary>
        [JsonProperty("carcinogenesis_and_mutagenesis_and_impairment_of_fertility")]
        public string CarcinogenesisAndMutagenesisAndImpairmentOfFertility { get; set; }

        ///<summary>
        ///Information from studies of the drug in animals, if the data were not relevant to nor included in other parts of the labeling. Most labels do not contain this field.
        ///</summary>
        [JsonProperty("animal_pharmacology_and_or_toxicology")]
        public string AnimalPharmacologyAndOrToxicology { get; set; }

        ///<summary>
        ///This field may contain references to clinical studies in place of detailed discussion in other sections of the labeling.
        ///</summary>
        [JsonProperty("clinical_studies")]
        public string ClinicalStudies { get; set; }

        ///<summary>
        ///This field may contain references when prescription drug labeling must summarize or otherwise relay on a recommendation by an authoritative scientific body, or on a standardized methodology, scale, or technique, because the information is important to prescribing decisions.
        ///</summary>
        [JsonProperty("references")]
        public string References { get; set; }

        ///<summary>
        ///Information about the available dosage forms to which the labeling applies, and for which the manufacturer or distributor is responsible. This field ordinarily includes the strength of the dosage form (in metric units), the units in which the dosage form is available for prescribing, appropriate information to facilitate identification of the dosage forms (such as shape, color, coating, scoring, and National Drug Code), and special handling and storage condition information.
        ///</summary>
        [JsonProperty("how_supplied")]
        public string HowSupplied { get; set; }

        ///<summary>
        ///Information about safe storage and handling of the drug product.
        ///</summary>
        [JsonProperty("storage_and_handling")]
        public string StorageAndHandling { get; set; }

        ///<summary>
        ///Documentation forthcoming.
        ///</summary>
        [JsonProperty("safe_handling_warning")]
        public string SafeHandlingWarning { get; set; }

        ///<summary>
        ///Information about contraindications or serious warnings, particularly those that may lead to death or serious injury.
        ///</summary>
        [JsonProperty("boxed_warning")]
        public string BoxedWarning { get; set; }

        ///<summary>
        ///When a drug can pose a hazard to human health by contact, inhalation, ingestion, injection, or by any exposure, this field contains information which can prevent or decrease the possibility of harm.
        ///</summary>
        [JsonProperty("user_safety_warnings")]
        public string UserSafetyWarnings { get; set; }

        ///<summary>
        ///Information about any special care to be exercised for safe and effective use of the drug.
        ///</summary>
        [JsonProperty("precautions")]
        public string Precautions { get; set; }

        ///<summary>
        ///Information about serious adverse reactions and potential safety hazards, including limitations in use imposed by those hazards and steps that should be taken if they occur.
        ///</summary>
        [JsonProperty("warnings")]
        public string Warnings { get; set; }

        ///<summary>
        ///Information about any special care to be exercised for safe and effective use of the drug.
        ///</summary>
        [JsonProperty("general_precautions")]
        public string GeneralPrecautions { get; set; }

        ///<summary>
        ///Information on laboratory tests helpful in following the patient’s response to the drug or in identifying possible adverse reactions. If appropriate, information may be provided on such factors as the range of normal and abnormal values expected in the particular situation and the recommended frequency with which tests should be performed before, during, and after therapy.
        ///</summary>
        [JsonProperty("laboratory_tests")]
        public string LaboratoryTests { get; set; }

        ///<summary>
        ///A list of the section(s) that contain substantive changes that have been approved by FDA in the product labeling. The headings and subheadings, if appropriate, affected by the change are listed together with each section’s identifying number and the month and year on which the change was incorporated in the labeling.
        ///</summary>
        [JsonProperty("recent_major_changes")]
        public string RecentMajorChanges { get; set; }

        ///<summary>
        ///Documentation forthcoming.
        ///</summary>
        [JsonProperty("microbiology")]
        public string Microbiology { get; set; }

        ///<summary>
        ///The content of the principal display panel of the product package, usually including the product’s name, dosage forms, and other key information about the drug product.
        ///</summary>
        [JsonProperty("package_label_principal_display_panel")]
        public string PackageLabelPrincipalDisplayPanel { get; set; }

        ///<summary>
        ///Information not classified as belonging to one of the other fields. Approximately 40% of labeling with effective_time between June 2009 and August 2014 have information in this field.
        ///</summary>
        [JsonProperty("spl_unclassified_section")]
        public string SplUnclassifiedSection { get; set; }

        ///<summary>
        ///"This corresponds to the NDA, ANDA, or BLA number reported by the labeler for products which have the corresponding Marketing Category designated. If the designated Marketing Category is OTC Monograph Final or OTC Monograph Not Final, then the application number will be the CFR citation corresponding to the appropriate Monograph (e.g. “part 341”). For unapproved drugs, this field will be null.
        /// Values follow this pattern:
        /// ^[BLA|ANDA|NDA]{3,4}
        /// [0-9]{6}$"
        ///</summary>
        [JsonProperty("openfda.application_number")]
        public List<string> ApplicationNumbers { get; set; } = new List<string>();

        ///<summary>
        ///Brand or trade name of the drug product.
        ///</summary>
        [JsonProperty("openfda.brand_name")]
        public List<string> BrandNames { get; set; } = new List<string>();

        ///<summary>
        ///Generic name(s) of the drug product.
        ///</summary>
        [JsonProperty("openfda.generic_name")]
        public List<string> GenericNames { get; set; } = new List<string>();

        ///<summary>
        ///Name of manufacturer or company that makes this drug product, corresponding to the labeler code segment of the NDC.
        ///</summary>
        [JsonProperty("openfda.manufacturer_name")]
        public List<string> ManufacturerNames { get; set; } = new List<string>();

        ///<summary>
        ///"Unique identifier applied to a drug concept within the National Drug File Reference Terminology (NDF-RT).
        /// Values follow this pattern:
        /// ^[N] [0-9]{10}$"
        ///</summary>
        [JsonProperty("openfda.nui")]
        public List<string> NUIs { get; set; } = new List<string>();

        ///<summary>
        ///"This number, known as the NDC, identifies the labeler, product, and trade package size. The first segment, the labeler code, is assigned by the FDA. A labeler is any firm that manufactures (including re-packers or re labelers), or distributes (under its own name) the drug.
        /// Values follow this pattern:
        /// ^[0-9]{5,4}-[0-9]{4,3}-[0-9]{1,2}$"
        ///</summary>
        [JsonProperty("openfda.package_ndc")]
        public List<string> PackageNDCs { get; set; } = new List<string>();

        ///<summary>
        ///Chemical structure classification of the drug product’s pharmacologic class. Takes the form of the classification, followed by [Chemical/Ingredient] (such as Thiazides [Chemical/Ingredient] or `Antibodies, Monoclonal [Chemical/Ingredient].
        ///</summary>
        // ReSharper disable once StringLiteralTypo
        [JsonProperty("openfda.pharm_class_cs")]
        public List<string> ChemicalStructureClassifications { get; set; } = new List<string>();

        ///<summary>
        ///Established pharmacologic class associated with an approved indication of an active moiety (generic drug) that the FDA has determined to be scientifically valid and clinically meaningful. Takes the form of the pharmacologic class, followed by [EPC] (such as Thiazide Diuretic [EPC] or Tumor Necrosis Factor Blocker [EPC].
        ///</summary>
        // ReSharper disable once StringLiteralTypo
        [JsonProperty("openfda.pharm_class_epc")]
        public List<string> EstablishedPharmacologicClassifications { get; set; } = new List<string>();

        ///<summary>
        ///Physiologic effect or pharmacodynamic effect—tissue, organ, or organ system level functional activity—of the drug’s established pharmacologic class. Takes the form of the effect, followed by [PE] (such as Increased Diuresis [PE] or Decreased Cytokine Activity [PE].
        ///</summary>
        // ReSharper disable once StringLiteralTypo
        [JsonProperty("openfda.pharm_class_pe")]
        public List<string> PhysiologicEffects { get; set; } = new List<string>();

        ///<summary>
        ///Mechanism of action of the drug—molecular, subcellular, or cellular functional activity—of the drug’s established pharmacologic class. Takes the form of the mechanism of action, followed by [MoA] (such as Calcium Channel Antagonists [MoA] or Tumor Necrosis Factor Receptor Blocking Activity [MoA].
        ///</summary>
        // ReSharper disable once StringLiteralTypo
        [JsonProperty("openfda.pharm_class_moa")]
        public List<string> MechanismOfActionClassifications { get; set; } = new List<string>();

        ///<summary>
        ///"The labeler manufacturer code and product code segments of the NDC number, separated by a hyphen.
        /// Values follow this pattern:
        /// ^[0-9]{5,4}-[0-9]{4,3}$"
        ///</summary>
        [JsonProperty("openfda.product_ndc")]
        public List<string> ProductNDCs { get; set; } = new List<string>();

        ///<summary>
        ///
        ///</summary>
        [JsonProperty("openfda.product_type")]
        public List<string> ProductTypes { get; set; } = new List<string>();

        ///<summary>
        ///The route of administration of the drug product.
        ///</summary>
        [JsonProperty("openfda.route")]
        public List<string> Routes { get; set; } = new List<string>();

        ///<summary>
        ///"The RxNorm Concept Unique Identifier. RxCUI is a unique number that describes a semantic concept about the drug product, including its ingredients, strength, and dose forms.
        /// Values follow this pattern:
        /// ^[0-9]{6}$"
        ///</summary>
        // ReSharper disable once StringLiteralTypo
        [JsonProperty("openfda.rxcui")]
        public List<string> RxcCUIs { get; set; } = new List<string>();

        ///<summary>
        ///"Unique identifier for a particular version of a Structured Product Label for a product. Also referred to as the document ID.
        /// Values follow this pattern:
        /// ^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"
        ///</summary>
        [JsonProperty("openfda.spl_id")]
        public List<string> StructuredProductLabelIds { get; set; } = new List<string>();

        ///<summary>
        ///"Unique identifier for the Structured Product Label for a product, which is stable across versions of the label. Also referred to as the set ID.
        /// Values follow this pattern:
        /// ^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"
        ///</summary>
        [JsonProperty("openfda.spl_set_id")]
        public List<string> StructuredProductLabelSetId { get; set; } = new List<string>();

        ///<summary>
        ///The list of active ingredients of a drug product.
        ///</summary>
        [JsonProperty("openfda.substance_name")]
        public List<string> SubstanceNames { get; set; } = new List<string>();

        ///<summary>
        ///"Unique Ingredient Identifier, which is a non-proprietary, free, unique, unambiguous, non-semantic, alphanumeric identifier based on a substance’s molecular structure and/or descriptive information.
        /// Values follow this pattern:
        /// ^[A-Z0-9]{10}$"
        ///</summary>
        [JsonProperty("openfda.unii")]
        public List<string> UniqueIngredientIdentifiers { get; set; } = new List<string>();

        ///<summary>
        ///Universal Product Code
        ///</summary>
        [JsonProperty("openfda.upc")]
        public List<string> UPCs { get; set; } = new List<string>();

    }
}
