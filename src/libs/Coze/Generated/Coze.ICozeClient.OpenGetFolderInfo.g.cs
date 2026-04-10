#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 查询文件夹详情<br/>
        /// {"0":{"ops":[{"insert":"工作空间中的用户可以查询工作空间中指定文件夹的详情，包括文件夹的名称、描述、所属工作空间、文件夹创建者的 UID等。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.OpenGetFolderInfoResponse> OpenGetFolderInfoAsync(
            string folderId,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}