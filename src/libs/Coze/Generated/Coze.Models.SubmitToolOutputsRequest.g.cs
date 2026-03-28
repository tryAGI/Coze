
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Coze.ToolOutput> ToolOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRequest" /> class.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="toolOutputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitToolOutputsRequest(
            global::System.Collections.Generic.IList<global::Coze.ToolOutput> toolOutputs,
            bool? stream)
        {
            this.ToolOutputs = toolOutputs ?? throw new global::System.ArgumentNullException(nameof(toolOutputs));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRequest" /> class.
        /// </summary>
        public SubmitToolOutputsRequest()
        {
        }
    }
}