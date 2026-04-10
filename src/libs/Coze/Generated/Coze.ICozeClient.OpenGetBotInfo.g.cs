#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 查看智能体配置<br/>
        /// {"0":{"ops":[{"insert":"查看指定智能体的配置信息，你可以查看该智能体已发布版本的配置，或当前草稿版本的配置。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="isPublished"></param>
        /// <param name="botId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.OpenGetBotInfoResponse> OpenGetBotInfoAsync(
            string botId,
            bool? isPublished = default,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}