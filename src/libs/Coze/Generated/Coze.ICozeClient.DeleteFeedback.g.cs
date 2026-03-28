#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 删除消息评价<br/>
        /// {"0":{"ops":[{"insert":"删除指定消息的评价。\n"},{"attributes":{"anchor":"be10635a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"仅会话创建者能删除对应会话中消息的评价。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.DeleteFeedbackResponse> DeleteFeedbackAsync(
            string conversationId,
            string messageId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 删除消息评价<br/>
        /// {"0":{"ops":[{"insert":"删除指定消息的评价。\n"},{"attributes":{"anchor":"be10635a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"仅会话创建者能删除对应会话中消息的评价。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.DeleteFeedbackResponse> DeleteFeedbackAsync(
            string conversationId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}