
#nullable enable

namespace Coze
{
    public partial class CozeClient
    {

        private static readonly global::Coze.AutoSDKServer[] s_OpenAPIRemoveAppCollaboratorServers = new global::Coze.AutoSDKServer[]
        {            new global::Coze.AutoSDKServer(
                id: "https-api-coze-com",
                name: "International",
                url: "https://api.coze.com/",
                description: "International"),
            new global::Coze.AutoSDKServer(
                id: "https-api-coze-cn",
                name: "China",
                url: "https://api.coze.cn/",
                description: "China"),
        };


        private static readonly global::Coze.EndPointSecurityRequirement s_OpenAPIRemoveAppCollaboratorSecurityRequirement0 =
            new global::Coze.EndPointSecurityRequirement
            {
                Authorizations = new global::Coze.EndPointAuthorizationRequirement[]
                {                    new global::Coze.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Token",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Coze.EndPointSecurityRequirement[] s_OpenAPIRemoveAppCollaboratorSecurityRequirements =
            new global::Coze.EndPointSecurityRequirement[]
            {                s_OpenAPIRemoveAppCollaboratorSecurityRequirement0,
            };
        partial void PrepareOpenAPIRemoveAppCollaboratorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string appId,
            ref string userId,
            object request);
        partial void PrepareOpenAPIRemoveAppCollaboratorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string appId,
            string userId,
            object request);
        partial void ProcessOpenAPIRemoveAppCollaboratorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIRemoveAppCollaboratorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 删除应用协作者<br/>
        /// {"0":{"ops":[{"insert":"删除扣子应用的协作者。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"删除协作者时，扣子会将该协作者创建的工作流、插件等资源转移给应用的所有者。\n"},{"attributes":{"anchor":"3dc926e4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能删除一位协作者。如需删除多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"使用个人访问令牌时，只有应用的所有者和协作者有权删除。使用 OAuth 应用和服务访问令牌时，只需要有对应权限点即可。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Coze.OpenAPIRemoveAppCollaboratorResponse> OpenAPIRemoveAppCollaboratorAsync(
            string appId,
            string userId,

            object request,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIRemoveAppCollaboratorArguments(
                httpClient: HttpClient,
                appId: ref appId,
                userId: ref userId,
                request: request);


            var __authorizations = global::Coze.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OpenAPIRemoveAppCollaboratorSecurityRequirements,
                operationName: "OpenAPIRemoveAppCollaboratorAsync");

            using var __timeoutCancellationTokenSource = global::Coze.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Coze.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Coze.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Coze.PathBuilder(
                                path: $"/v1/apps/{appId}/collaborators/{userId}",
                                baseUri: ResolveBaseUri(
                                servers: s_OpenAPIRemoveAppCollaboratorServers,
                                defaultBaseUrl: "https://api.coze.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::Coze.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Delete,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Coze.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareOpenAPIRemoveAppCollaboratorRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    appId: appId,
                    userId: userId,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Coze.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Coze.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenAPIRemoveAppCollaborator",
                                methodName: "OpenAPIRemoveAppCollaboratorAsync",
                                pathTemplate: "$\"/v1/apps/{appId}/collaborators/{userId}\"",
                                httpMethod: "DELETE",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Coze.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Coze.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenAPIRemoveAppCollaborator",
                                methodName: "OpenAPIRemoveAppCollaboratorAsync",
                                pathTemplate: "$\"/v1/apps/{appId}/collaborators/{userId}\"",
                                httpMethod: "DELETE",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Coze.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Coze.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Coze.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Coze.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenAPIRemoveAppCollaborator",
                                methodName: "OpenAPIRemoveAppCollaboratorAsync",
                                pathTemplate: "$\"/v1/apps/{appId}/collaborators/{userId}\"",
                                httpMethod: "DELETE",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Coze.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessOpenAPIRemoveAppCollaboratorResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Coze.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Coze.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenAPIRemoveAppCollaborator",
                                methodName: "OpenAPIRemoveAppCollaboratorAsync",
                                pathTemplate: "$\"/v1/apps/{appId}/collaborators/{userId}\"",
                                httpMethod: "DELETE",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Coze.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Coze.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OpenAPIRemoveAppCollaborator",
                                methodName: "OpenAPIRemoveAppCollaboratorAsync",
                                pathTemplate: "$\"/v1/apps/{appId}/collaborators/{userId}\"",
                                httpMethod: "DELETE",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessOpenAPIRemoveAppCollaboratorResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Coze.OpenAPIRemoveAppCollaboratorResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Coze.OpenAPIRemoveAppCollaboratorResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// 删除应用协作者<br/>
        /// {"0":{"ops":[{"insert":"删除扣子应用的协作者。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"删除协作者时，扣子会将该协作者创建的工作流、插件等资源转移给应用的所有者。\n"},{"attributes":{"anchor":"3dc926e4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"主账号内的所有子账号共享同一 API 的流控额度，单个 API 的流控限制为 5 QPS。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能删除一位协作者。如需删除多位，请依次发送请求。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"使用个人访问令牌时，只有应用的所有者和协作者有权删除。使用 OAuth 应用和服务访问令牌时，只需要有对应权限点即可。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Coze.OpenAPIRemoveAppCollaboratorResponse> OpenAPIRemoveAppCollaboratorAsync(
            string appId,
            string userId,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new object
            {
            };

            return await OpenAPIRemoveAppCollaboratorAsync(
                appId: appId,
                userId: userId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}