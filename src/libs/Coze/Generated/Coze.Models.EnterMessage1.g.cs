
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterMessage1
    {
        /// <summary>
        /// 内容
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// text/card/object_string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Coze.JsonConverters.EnterMessage1ContentTypeJsonConverter))]
        public global::Coze.EnterMessage1ContentType? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Coze.JsonConverters.EnterMessage1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Coze.EnterMessage1Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Coze.JsonConverters.EnterMessage1TypeJsonConverter))]
        public global::Coze.EnterMessage1Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterMessage1" /> class.
        /// </summary>
        /// <param name="content">
        /// 内容
        /// </param>
        /// <param name="contentType">
        /// text/card/object_string
        /// </param>
        /// <param name="metaData"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterMessage1(
            global::Coze.EnterMessage1Role role,
            string? content,
            global::Coze.EnterMessage1ContentType? contentType,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            global::Coze.EnterMessage1Type? type)
        {
            this.Role = role;
            this.Content = content;
            this.ContentType = contentType;
            this.MetaData = metaData;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterMessage1" /> class.
        /// </summary>
        public EnterMessage1()
        {
        }
    }
}