#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// uibuilder<br/>
        /// {"0":{"ops":[{"insert":"扣子 Web SDK 是一个功能强大的 JavaScript 库，能够将应用中的用户界面打包发布到 Web SDK，方便开发者将其无缝嵌入到各类业务系统中\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UibuilderAsync(

            global::Coze.UibuilderRequest request,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// uibuilder<br/>
        /// {"0":{"ops":[{"insert":"扣子 Web SDK 是一个功能强大的 JavaScript 库，能够将应用中的用户界面打包发布到 Web SDK，方便开发者将其无缝嵌入到各类业务系统中\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="container"></param>
        /// <param name="token"></param>
        /// <param name="ui"></param>
        /// <param name="userInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UibuilderAsync(
            string appId,
            string token,
            string? container = default,
            global::Coze.UibuilderRequestUi? ui = default,
            global::Coze.UibuilderRequestUserInfo? userInfo = default,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}