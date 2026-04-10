#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 创建工作空间<br/>
        /// {"0":{"ops":[{"insert":"创建工作空间。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="authorization_"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.OpenCreateSpaceResponse> OpenCreateSpaceAsync(

            global::Coze.OpenCreateSpaceRequest request,
            object? authorization_ = default,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 创建工作空间<br/>
        /// {"0":{"ops":[{"insert":"创建工作空间。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="authorization_"></param>
        /// <param name="cozeAccountId">
        /// 组织id
        /// </param>
        /// <param name="description">
        /// 空间描述
        /// </param>
        /// <param name="iconFileId">
        /// 空间图标，通过上传接口https://www.coze.cn/open/docs/developer_guides/upload_files，未指定文件ID则使用默认头像
        /// </param>
        /// <param name="name">
        /// 空间名称
        /// </param>
        /// <param name="ownerUid">
        /// 空间所有者id，不传则为当前用户
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.OpenCreateSpaceResponse> OpenCreateSpaceAsync(
            string description,
            string name,
            object? authorization_ = default,
            string? cozeAccountId = default,
            string? iconFileId = default,
            string? ownerUid = default,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}