
#nullable enable

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::Coze.ChatSDKRequestAuth? Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Coze.ChatSDKRequestConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Coze.ChatSDKRequestUi Ui { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Coze.ChatSDKRequestUserInfo UserInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequest" /> class.
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="config"></param>
        /// <param name="ui"></param>
        /// <param name="userInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSDKRequest(
            global::Coze.ChatSDKRequestConfig config,
            global::Coze.ChatSDKRequestUi ui,
            global::Coze.ChatSDKRequestUserInfo userInfo,
            global::Coze.ChatSDKRequestAuth? auth)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Ui = ui ?? throw new global::System.ArgumentNullException(nameof(ui));
            this.UserInfo = userInfo ?? throw new global::System.ArgumentNullException(nameof(userInfo));
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequest" /> class.
        /// </summary>
        public ChatSDKRequest()
        {
        }
    }
}