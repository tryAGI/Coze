
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_info")]
        public global::Coze.PropertiesDataPropertiesBasicInfo? BasicInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("benefit_info")]
        public global::System.Collections.Generic.IList<global::Coze.PropertiesDataPropertiesBenefitInfoItems>? BenefitInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesData" /> class.
        /// </summary>
        /// <param name="basicInfo"></param>
        /// <param name="benefitInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesData(
            global::Coze.PropertiesDataPropertiesBasicInfo? basicInfo,
            global::System.Collections.Generic.IList<global::Coze.PropertiesDataPropertiesBenefitInfoItems>? benefitInfo)
        {
            this.BasicInfo = basicInfo;
            this.BenefitInfo = benefitInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesData" /> class.
        /// </summary>
        public PropertiesData()
        {
        }
    }
}