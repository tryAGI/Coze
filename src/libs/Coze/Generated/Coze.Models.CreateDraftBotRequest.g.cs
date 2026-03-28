
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDraftBotRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 头像文件id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_file_id")]
        public string? IconFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_config")]
        public global::Coze.PropertiesMediaConfig? MediaConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_info_config")]
        public global::Coze.PropertiesModelInfoConfig? ModelInfoConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarding_info")]
        public global::Coze.PropertiesOnboardingInfo? OnboardingInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id_list")]
        public global::Coze.PropertiesPluginIdList? PluginIdList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_info")]
        public global::Coze.PropertiesPromptInfo? PromptInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest_reply_info")]
        public global::Coze.PropertiesSuggestReplyInfo? SuggestReplyInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id_list")]
        public global::Coze.PropertiesWorkflowIdList? WorkflowIdList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDraftBotRequest" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="iconFileId">
        /// 头像文件id
        /// </param>
        /// <param name="mediaConfig"></param>
        /// <param name="modelInfoConfig"></param>
        /// <param name="name"></param>
        /// <param name="onboardingInfo"></param>
        /// <param name="pluginIdList"></param>
        /// <param name="promptInfo"></param>
        /// <param name="spaceId"></param>
        /// <param name="suggestReplyInfo"></param>
        /// <param name="workflowIdList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDraftBotRequest(
            string name,
            string spaceId,
            string? description,
            string? iconFileId,
            global::Coze.PropertiesMediaConfig? mediaConfig,
            global::Coze.PropertiesModelInfoConfig? modelInfoConfig,
            global::Coze.PropertiesOnboardingInfo? onboardingInfo,
            global::Coze.PropertiesPluginIdList? pluginIdList,
            global::Coze.PropertiesPromptInfo? promptInfo,
            global::Coze.PropertiesSuggestReplyInfo? suggestReplyInfo,
            global::Coze.PropertiesWorkflowIdList? workflowIdList)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SpaceId = spaceId ?? throw new global::System.ArgumentNullException(nameof(spaceId));
            this.Description = description;
            this.IconFileId = iconFileId;
            this.MediaConfig = mediaConfig;
            this.ModelInfoConfig = modelInfoConfig;
            this.OnboardingInfo = onboardingInfo;
            this.PluginIdList = pluginIdList;
            this.PromptInfo = promptInfo;
            this.SuggestReplyInfo = suggestReplyInfo;
            this.WorkflowIdList = workflowIdList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDraftBotRequest" /> class.
        /// </summary>
        public CreateDraftBotRequest()
        {
        }
    }
}