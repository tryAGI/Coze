
#nullable enable

namespace Coze
{
    public partial class CozeClient
    {
        partial void PrepareOpenAPIUpdateEnterpriseMemberArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterpriseId,
            ref string userId,
            global::Coze.OpenAPIUpdateEnterpriseMemberRequest request);
        partial void PrepareOpenAPIUpdateEnterpriseMemberRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterpriseId,
            string userId,
            global::Coze.OpenAPIUpdateEnterpriseMemberRequest request);
        partial void ProcessOpenAPIUpdateEnterpriseMemberResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIUpdateEnterpriseMemberResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 修改企业员工的角色<br/>
        /// {"0":{"ops":[{"insert":"修改企业员工的角色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"企业员工角色包括企业管理员和企业普通成员，你可以通过本 API 修改企业员工的角色。\n"},{"attributes":{"anchor":"5fb118b3","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"不能修改访客的角色。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Coze.OpenAPIUpdateEnterpriseMemberResponse> OpenAPIUpdateEnterpriseMemberAsync(
            string enterpriseId,
            string userId,

            global::Coze.OpenAPIUpdateEnterpriseMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIUpdateEnterpriseMemberArguments(
                httpClient: HttpClient,
                enterpriseId: ref enterpriseId,
                userId: ref userId,
                request: request);

            var __pathBuilder = new global::Coze.PathBuilder(
                path: $"/v1/enterprises/{enterpriseId}/members/{userId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOpenAPIUpdateEnterpriseMemberRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                enterpriseId: enterpriseId,
                userId: userId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIUpdateEnterpriseMemberResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessOpenAPIUpdateEnterpriseMemberResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Coze.OpenAPIUpdateEnterpriseMemberResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Coze.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Coze.OpenAPIUpdateEnterpriseMemberResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Coze.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// 修改企业员工的角色<br/>
        /// {"0":{"ops":[{"insert":"修改企业员工的角色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"企业员工角色包括企业管理员和企业普通成员，你可以通过本 API 修改企业员工的角色。\n"},{"attributes":{"anchor":"5fb118b3","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"不能修改访客的角色。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Coze.OpenAPIUpdateEnterpriseMemberResponse> OpenAPIUpdateEnterpriseMemberAsync(
            string enterpriseId,
            string userId,
            global::Coze.OpenAPIUpdateEnterpriseMemberRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Coze.OpenAPIUpdateEnterpriseMemberRequest
            {
                Role = role,
            };

            return await OpenAPIUpdateEnterpriseMemberAsync(
                enterpriseId: enterpriseId,
                userId: userId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}