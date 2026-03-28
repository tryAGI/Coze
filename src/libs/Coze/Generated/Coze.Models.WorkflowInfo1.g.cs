
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowInfo1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Coze.OpenAPIWorkflowInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Coze.OpenAPIWorkflowOutput? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_detail")]
        public global::Coze.OpenAPIWorkflowBasic? WorkflowDetail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInfo1" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="workflowDetail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowInfo1(
            global::Coze.OpenAPIWorkflowInput? input,
            global::Coze.OpenAPIWorkflowOutput? output,
            global::Coze.OpenAPIWorkflowBasic? workflowDetail)
        {
            this.Input = input;
            this.Output = output;
            this.WorkflowDetail = workflowDetail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInfo1" /> class.
        /// </summary>
        public WorkflowInfo1()
        {
        }
    }
}