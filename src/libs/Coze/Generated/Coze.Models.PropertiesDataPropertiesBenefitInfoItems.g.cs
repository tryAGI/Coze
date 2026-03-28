
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesBenefitInfoItems
    {
        /// <summary>
        /// 基础值
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic")]
        public global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic? Basic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("benefit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeJsonConverter))]
        public global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType? BenefitType { get; set; }

        /// <summary>
        /// 实际生效总量
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective")]
        public global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective? Effective { get; set; }

        /// <summary>
        /// 扩容值，不一定有
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public global::System.Collections.Generic.IList<global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItems" /> class.
        /// </summary>
        /// <param name="basic">
        /// 基础值
        /// </param>
        /// <param name="benefitType"></param>
        /// <param name="effective">
        /// 实际生效总量
        /// </param>
        /// <param name="extra">
        /// 扩容值，不一定有
        /// </param>
        /// <param name="resourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesDataPropertiesBenefitInfoItems(
            global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic? basic,
            global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType? benefitType,
            global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective? effective,
            global::System.Collections.Generic.IList<global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems>? extra,
            string? resourceId)
        {
            this.Basic = basic;
            this.BenefitType = benefitType;
            this.Effective = effective;
            this.Extra = extra;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItems" /> class.
        /// </summary>
        public PropertiesDataPropertiesBenefitInfoItems()
        {
        }
    }
}