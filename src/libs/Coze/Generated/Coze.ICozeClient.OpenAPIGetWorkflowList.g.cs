#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 查询工作流列表<br/>
        /// {"0":{"ops":[{"insert":"查询指定工作空间中的工作流列表及其基本信息。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以查询某个工作空间中的所有工作流或对话流、某个应用关联的工作流或对话流。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="workflowMode"></param>
        /// <param name="appId"></param>
        /// <param name="publishStatus"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.OpenAPIGetWorkflowListResponse> OpenAPIGetWorkflowListAsync(
            string workspaceId,
            int pageNum,
            int? pageSize = default,
            global::Coze.OpenAPIWorkflowMode? workflowMode = default,
            string? appId = default,
            global::Coze.PublishStatus? publishStatus = default,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}