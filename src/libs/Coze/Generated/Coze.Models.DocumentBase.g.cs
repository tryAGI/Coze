
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentBase
    {
        /// <summary>
        /// 图片类型，人工标注时的图片描述，目前只支持openapi调用
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Coze.SourceInfo SourceInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_rule")]
        public global::Coze.UpdateRule? UpdateRule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBase" /> class.
        /// </summary>
        /// <param name="caption">
        /// 图片类型，人工标注时的图片描述，目前只支持openapi调用
        /// </param>
        /// <param name="name"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="updateRule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentBase(
            string name,
            global::Coze.SourceInfo sourceInfo,
            string? caption,
            global::Coze.UpdateRule? updateRule)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceInfo = sourceInfo ?? throw new global::System.ArgumentNullException(nameof(sourceInfo));
            this.Caption = caption;
            this.UpdateRule = updateRule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBase" /> class.
        /// </summary>
        public DocumentBase()
        {
        }
    }
}