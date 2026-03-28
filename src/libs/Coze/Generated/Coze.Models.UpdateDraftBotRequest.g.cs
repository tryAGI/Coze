
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDraftBotRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_file_id")]
        public string? IconFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge")]
        public global::Coze.PropertiesKnowledge? Knowledge { get; set; }

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
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateDraftBotRequest" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="description"></param>
        /// <param name="iconFileId"></param>
        /// <param name="knowledge"></param>
        /// <param name="mediaConfig"></param>
        /// <param name="modelInfoConfig"></param>
        /// <param name="name"></param>
        /// <param name="onboardingInfo"></param>
        /// <param name="pluginIdList"></param>
        /// <param name="promptInfo"></param>
        /// <param name="suggestReplyInfo"></param>
        /// <param name="workflowIdList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDraftBotRequest(
            string botId,
            string? description,
            string? iconFileId,
            global::Coze.PropertiesKnowledge? knowledge,
            global::Coze.PropertiesMediaConfig? mediaConfig,
            global::Coze.PropertiesModelInfoConfig? modelInfoConfig,
            string? name,
            global::Coze.PropertiesOnboardingInfo? onboardingInfo,
            global::Coze.PropertiesPluginIdList? pluginIdList,
            global::Coze.PropertiesPromptInfo? promptInfo,
            global::Coze.PropertiesSuggestReplyInfo? suggestReplyInfo,
            global::Coze.PropertiesWorkflowIdList? workflowIdList)
        {
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.Description = description;
            this.IconFileId = iconFileId;
            this.Knowledge = knowledge;
            this.MediaConfig = mediaConfig;
            this.ModelInfoConfig = modelInfoConfig;
            this.Name = name;
            this.OnboardingInfo = onboardingInfo;
            this.PluginIdList = pluginIdList;
            this.PromptInfo = promptInfo;
            this.SuggestReplyInfo = suggestReplyInfo;
            this.WorkflowIdList = workflowIdList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDraftBotRequest" /> class.
        /// </summary>
        public UpdateDraftBotRequest()
        {
        }
    }
}