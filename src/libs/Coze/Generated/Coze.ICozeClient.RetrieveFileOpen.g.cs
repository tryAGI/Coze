#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 查看文件详情<br/>
        /// 查看已上传的文件详情。
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.RetrieveFileOpenResponse> RetrieveFileOpenAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}