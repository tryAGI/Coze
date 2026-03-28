#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 查看消息详情<br/>
        /// 查看指定消息的详细信息。
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.RetrieveMessageApiResponse> RetrieveMessageApiAsync(
            string conversationId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}