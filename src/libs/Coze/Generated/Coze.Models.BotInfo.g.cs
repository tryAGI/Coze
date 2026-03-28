
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BotInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_image_info")]
        public global::Coze.BackgroundImageInfo1? BackgroundImageInfo { get; set; }

        /// <summary>
        /// bot id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_mode")]
        public int? BotMode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 默认用户输入类型
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_user_input_type")]
        public string? DefaultUserInputType { get; set; }

        /// <summary>
        /// bot描述
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// bot图像url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge")]
        public global::Coze.CommonKnowledge? Knowledge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_info")]
        public global::Coze.ModelInfo? ModelInfo { get; set; }

        /// <summary>
        /// bot名称
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarding_info")]
        public global::Coze.OnboardingInfoV2? OnboardingInfo { get; set; }

        /// <summary>
        /// owner_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// 插件信息列表
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_info_list")]
        public global::System.Collections.Generic.IList<global::Coze.PluginInfo>? PluginInfoList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_info")]
        public global::Coze.PromptInfo? PromptInfo { get; set; }

        /// <summary>
        /// 快捷指令信息列表
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortcut_commands")]
        public global::System.Collections.Generic.IList<global::Coze.ShortcutCommandInfo>? ShortcutCommands { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// 变量列表
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Coze.Variable>? Variables { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 音色配置
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_info_list")]
        public global::System.Collections.Generic.IList<global::Coze.Voice>? VoiceInfoList { get; set; }

        /// <summary>
        /// workflow信息列表
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_info_list")]
        public global::System.Collections.Generic.IList<global::Coze.WorkflowInfo>? WorkflowInfoList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BotInfo" /> class.
        /// </summary>
        /// <param name="backgroundImageInfo"></param>
        /// <param name="botId">
        /// bot id
        /// </param>
        /// <param name="botMode"></param>
        /// <param name="createTime">
        /// 创建时间
        /// </param>
        /// <param name="defaultUserInputType">
        /// 默认用户输入类型
        /// </param>
        /// <param name="description">
        /// bot描述
        /// </param>
        /// <param name="iconUrl">
        /// bot图像url
        /// </param>
        /// <param name="knowledge"></param>
        /// <param name="modelInfo"></param>
        /// <param name="name">
        /// bot名称
        /// </param>
        /// <param name="onboardingInfo"></param>
        /// <param name="ownerUserId">
        /// owner_id
        /// </param>
        /// <param name="pluginInfoList">
        /// 插件信息列表
        /// </param>
        /// <param name="promptInfo"></param>
        /// <param name="shortcutCommands">
        /// 快捷指令信息列表
        /// </param>
        /// <param name="updateTime">
        /// 更新时间
        /// </param>
        /// <param name="variables">
        /// 变量列表
        /// </param>
        /// <param name="version">
        /// 版本
        /// </param>
        /// <param name="voiceInfoList">
        /// 音色配置
        /// </param>
        /// <param name="workflowInfoList">
        /// workflow信息列表
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BotInfo(
            global::Coze.BackgroundImageInfo1? backgroundImageInfo,
            string? botId,
            int? botMode,
            int? createTime,
            string? defaultUserInputType,
            string? description,
            string? iconUrl,
            global::Coze.CommonKnowledge? knowledge,
            global::Coze.ModelInfo? modelInfo,
            string? name,
            global::Coze.OnboardingInfoV2? onboardingInfo,
            string? ownerUserId,
            global::System.Collections.Generic.IList<global::Coze.PluginInfo>? pluginInfoList,
            global::Coze.PromptInfo? promptInfo,
            global::System.Collections.Generic.IList<global::Coze.ShortcutCommandInfo>? shortcutCommands,
            int? updateTime,
            global::System.Collections.Generic.IList<global::Coze.Variable>? variables,
            string? version,
            global::System.Collections.Generic.IList<global::Coze.Voice>? voiceInfoList,
            global::System.Collections.Generic.IList<global::Coze.WorkflowInfo>? workflowInfoList)
        {
            this.BackgroundImageInfo = backgroundImageInfo;
            this.BotId = botId;
            this.BotMode = botMode;
            this.CreateTime = createTime;
            this.DefaultUserInputType = defaultUserInputType;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.Knowledge = knowledge;
            this.ModelInfo = modelInfo;
            this.Name = name;
            this.OnboardingInfo = onboardingInfo;
            this.OwnerUserId = ownerUserId;
            this.PluginInfoList = pluginInfoList;
            this.PromptInfo = promptInfo;
            this.ShortcutCommands = shortcutCommands;
            this.UpdateTime = updateTime;
            this.Variables = variables;
            this.Version = version;
            this.VoiceInfoList = voiceInfoList;
            this.WorkflowInfoList = workflowInfoList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotInfo" /> class.
        /// </summary>
        public BotInfo()
        {
        }
    }
}