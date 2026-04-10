#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 查询工作流基本信息<br/>
        /// {"0":{"ops":[{"insert":"查询工作流的基本信息，包括工作流名称、描述、创建者信息等。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="includeInputOutput"></param>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.OpenAPIGetWorkflowInfoResponse> OpenAPIGetWorkflowInfoAsync(
            string workflowId,
            bool? includeInputOutput = default,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}