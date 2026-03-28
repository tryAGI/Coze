#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 发布智能体<br/>
        /// {"0":{"ops":[{"insert":"将指定智能体发布到 API、Chat SDK 或者自定义渠道。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.PublishDraftBotResponse> PublishDraftBotAsync(

            global::Coze.PublishDraftBotRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 发布智能体<br/>
        /// {"0":{"ops":[{"insert":"将指定智能体发布到 API、Chat SDK 或者自定义渠道。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="connectorIds"></param>
        /// <param name="connectors"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.PublishDraftBotResponse> PublishDraftBotAsync(
            string botId,
            global::System.Collections.Generic.IList<string> connectorIds,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? connectors = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}