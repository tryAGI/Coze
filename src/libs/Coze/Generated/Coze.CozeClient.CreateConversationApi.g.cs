
#nullable enable

namespace Coze
{
    public partial class CozeClient
    {


        private static readonly global::Coze.EndPointSecurityRequirement s_CreateConversationApiSecurityRequirement0 =
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
        private static readonly global::Coze.EndPointSecurityRequirement[] s_CreateConversationApiSecurityRequirements =
            new global::Coze.EndPointSecurityRequirement[]
            {                s_CreateConversationApiSecurityRequirement0,
            };
        partial void PrepareCreateConversationApiArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Coze.CreateConversationApiRequest request);
        partial void PrepareCreateConversationApiRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Coze.CreateConversationApiRequest request);
        partial void ProcessCreateConversationApiResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateConversationApiResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 创建会话<br/>
        /// {"0":{"ops":[{"insert":"创建一个会话。\n"},{"attributes":{"anchor":"1cb6ef34","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"insert":"会话是智能体和用户之间的基于一个或多个主题的问答交互，一个会话包含一条或多条消息。创建会话时，扣子会同时在会话中创建一个空白的上下文片段，用于存储某个主题的消息。后续发起对话时，上下文片段中的消息是模型可见的消息历史。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以在创建会话时同步写入消息，或者创建会话后另外调用 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/create_message\",\"linkId\":\"hLSw6DHlqH\"}"},"insert":"创建消息 API"},{"insert":" 写入消息。消息默认写入到最新的一个上下文片段中，对话时将作为上下文传递给模型。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"会话、对话、消息和上下文片段的概念说明，可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73\",\"linkId\":\"M21F2iMUtU\",\"newTab\":true}"},"insert":"基础概念"},{"insert":"。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"如果需要将不同业务侧用户的会话互相隔离，请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/session_isolation\",\"linkId\":\"BEUGfANcqg\",\"newTab\":true}"},"insert":"如何实现会话隔离"},{"insert":"。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Coze.CreateConversationApiResponse> CreateConversationApiAsync(

            global::Coze.CreateConversationApiRequest request,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateConversationApiArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Coze.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateConversationApiSecurityRequirements,
                operationName: "CreateConversationApiAsync");

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
                                path: "/v1/conversation/create",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Coze.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
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
                PrepareCreateConversationApiRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "CreateConversationApi",
                                methodName: "CreateConversationApiAsync",
                                pathTemplate: "\"/v1/conversation/create\"",
                                httpMethod: "POST",
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
                                operationId: "CreateConversationApi",
                                methodName: "CreateConversationApiAsync",
                                pathTemplate: "\"/v1/conversation/create\"",
                                httpMethod: "POST",
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
                                operationId: "CreateConversationApi",
                                methodName: "CreateConversationApiAsync",
                                pathTemplate: "\"/v1/conversation/create\"",
                                httpMethod: "POST",
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
                ProcessCreateConversationApiResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Coze.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Coze.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateConversationApi",
                                methodName: "CreateConversationApiAsync",
                                pathTemplate: "\"/v1/conversation/create\"",
                                httpMethod: "POST",
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
                                operationId: "CreateConversationApi",
                                methodName: "CreateConversationApiAsync",
                                pathTemplate: "\"/v1/conversation/create\"",
                                httpMethod: "POST",
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
                                ProcessCreateConversationApiResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Coze.CreateConversationApiResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::Coze.CreateConversationApiResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// 创建会话<br/>
        /// {"0":{"ops":[{"insert":"创建一个会话。\n"},{"attributes":{"anchor":"1cb6ef34","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"insert":"会话是智能体和用户之间的基于一个或多个主题的问答交互，一个会话包含一条或多条消息。创建会话时，扣子会同时在会话中创建一个空白的上下文片段，用于存储某个主题的消息。后续发起对话时，上下文片段中的消息是模型可见的消息历史。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以在创建会话时同步写入消息，或者创建会话后另外调用 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/create_message\",\"linkId\":\"hLSw6DHlqH\"}"},"insert":"创建消息 API"},{"insert":" 写入消息。消息默认写入到最新的一个上下文片段中，对话时将作为上下文传递给模型。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"会话、对话、消息和上下文片段的概念说明，可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73\",\"linkId\":\"M21F2iMUtU\",\"newTab\":true}"},"insert":"基础概念"},{"insert":"。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"如果需要将不同业务侧用户的会话互相隔离，请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/session_isolation\",\"linkId\":\"BEUGfANcqg\",\"newTab\":true}"},"insert":"如何实现会话隔离"},{"insert":"。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="connectorId"></param>
        /// <param name="messages">
        /// 校验最多16个
        /// </param>
        /// <param name="metaData"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Coze.CreateConversationApiResponse> CreateConversationApiAsync(
            string? botId = default,
            string? connectorId = default,
            global::System.Collections.Generic.IList<global::Coze.EnterMessage1>? messages = default,
            global::System.Collections.Generic.Dictionary<string, string>? metaData = default,
            string? name = default,
            global::Coze.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Coze.CreateConversationApiRequest
            {
                BotId = botId,
                ConnectorId = connectorId,
                Messages = messages,
                MetaData = metaData,
                Name = name,
            };

            return await CreateConversationApiAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}