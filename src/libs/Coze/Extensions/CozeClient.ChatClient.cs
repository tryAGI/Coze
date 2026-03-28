#nullable enable

using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.AI;

namespace Coze;

/// <summary>
/// MEAI <see cref="IChatClient"/> implementation for the Coze v3 chat API.
/// <para>
/// Coze is a bot-centric platform: every chat request requires a <c>bot_id</c> and <c>user_id</c>.
/// The <c>bot_id</c> is supplied via the <see cref="WithBotId"/> method or <see cref="ChatOptions.ModelId"/>,
/// while <c>user_id</c> defaults to <c>"meai_user"</c> (overridable via <see cref="ChatOptions.AdditionalProperties"/>).
/// </para>
/// </summary>
public partial class CozeClient : IChatClient
{
    /// <summary>
    /// The default bot ID used for chat requests.
    /// Set via the <see cref="WithBotId"/> method.
    /// </summary>
    private string? _botId;

    /// <summary>
    /// The default user ID used for chat requests.
    /// Set via the <see cref="WithUserId"/> method.
    /// </summary>
    private string _userId = "meai_user";

    private ChatClientMetadata? _chatMetadata;

    /// <summary>
    /// Sets the bot ID to use for MEAI chat requests.
    /// </summary>
    /// <param name="botId">The Coze bot ID.</param>
    /// <returns>This client instance for chaining.</returns>
    public CozeClient WithBotId(string botId)
    {
        _botId = botId ?? throw new ArgumentNullException(nameof(botId));
        return this;
    }

    /// <summary>
    /// Sets the user ID to use for MEAI chat requests.
    /// </summary>
    /// <param name="userId">The Coze user ID.</param>
    /// <returns>This client instance for chaining.</returns>
    public CozeClient WithUserId(string userId)
    {
        _userId = userId ?? throw new ArgumentNullException(nameof(userId));
        return this;
    }

    /// <inheritdoc />
    object? IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(ChatClientMetadata) ? (_chatMetadata ??= new(nameof(CozeClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    /// <inheritdoc />
    async Task<ChatResponse> IChatClient.GetResponseAsync(
        IEnumerable<ChatMessage> messages,
        ChatOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        // Use streaming internally and accumulate the response.
        // This avoids the complexity of polling the non-streaming endpoint.
        var request = CreateChatRequest(messages, options);

        var responseMessage = new ChatMessage
        {
            Role = ChatRole.Assistant,
        };

        var responseText = new StringBuilder();
        var reasoningText = new StringBuilder();
        string? responseId = null;
        string? conversationId = null;
        ChatFinishReason? finishReason = null;
        UsageDetails? usage = null;

        await foreach (var chunk in ChatV3AsStreamAsync(
            request: request,
            conversationId: GetConversationId(options),
            cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            if (chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationMessageDelta ||
                chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationMessageCompleted)
            {
                if (chunk.Data is { } detail)
                {
                    if (detail.Type == "answer" && chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationMessageDelta)
                    {
                        responseText.Append(detail.Content);
                    }
                    else if (detail.Type == "answer" && chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationMessageCompleted)
                    {
                        // Use the completed message content as the final text (most reliable).
                        if (detail.Content is { Length: > 0 })
                        {
                            responseText.Clear();
                            responseText.Append(detail.Content);
                        }

                        responseId = detail.ChatId;
                        conversationId = detail.ConversationId;
                    }

                    if (!string.IsNullOrEmpty(detail.ReasoningContent))
                    {
                        reasoningText.Append(detail.ReasoningContent);
                    }
                }
            }
            else if (chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationChatCompleted)
            {
                finishReason = ChatFinishReason.Stop;
            }
            else if (chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationChatFailed)
            {
                finishReason = new ChatFinishReason("error");
            }
            else if (chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationChatRequiresAction)
            {
                finishReason = ChatFinishReason.ToolCalls;
            }
        }

        if (responseText.Length > 0)
        {
            responseMessage.Contents.Add(new TextContent(responseText.ToString()));
        }

        if (reasoningText.Length > 0)
        {
            responseMessage.Contents.Add(new TextReasoningContent(reasoningText.ToString()));
        }

        // Try to get usage by retrieving the chat detail after streaming completes.
        if (responseId is not null && conversationId is not null)
        {
            usage = await TryGetUsageAsync(conversationId, responseId, cancellationToken).ConfigureAwait(false);
        }

        return new ChatResponse(responseMessage)
        {
            ResponseId = responseId,
            ConversationId = conversationId,
            ModelId = GetBotId(options),
            FinishReason = finishReason,
            Usage = usage,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<ChatResponseUpdate> IChatClient.GetStreamingResponseAsync(
        IEnumerable<ChatMessage> messages,
        ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var request = CreateChatRequest(messages, options);
        string? currentResponseId = null;
        string? currentConversationId = null;

        await foreach (var chunk in ChatV3AsStreamAsync(
            request: request,
            conversationId: GetConversationId(options),
            cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            if (chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationMessageDelta)
            {
                if (chunk.Data is { } detail && detail.Type == "answer")
                {
                    currentResponseId ??= detail.ChatId;
                    currentConversationId ??= detail.ConversationId;

                    var update = new ChatResponseUpdate
                    {
                        ResponseId = detail.ChatId,
                        ConversationId = detail.ConversationId,
                        MessageId = detail.Id,
                        Role = ChatRole.Assistant,
                        ModelId = GetBotId(options),
                        RawRepresentation = chunk,
                    };

                    if (detail.Content is { Length: > 0 })
                    {
                        update.Contents.Add(new TextContent(detail.Content)
                        {
                            RawRepresentation = detail,
                        });
                    }

                    if (!string.IsNullOrEmpty(detail.ReasoningContent))
                    {
                        update.Contents.Add(new TextReasoningContent(detail.ReasoningContent)
                        {
                            RawRepresentation = detail,
                        });
                    }

                    yield return update;
                }
            }
            else if (chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationChatCompleted)
            {
                yield return new ChatResponseUpdate
                {
                    ResponseId = currentResponseId,
                    ConversationId = currentConversationId,
                    Role = ChatRole.Assistant,
                    ModelId = GetBotId(options),
                    FinishReason = ChatFinishReason.Stop,
                    RawRepresentation = chunk,
                };
            }
            else if (chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationChatFailed)
            {
                yield return new ChatResponseUpdate
                {
                    ResponseId = currentResponseId,
                    ConversationId = currentConversationId,
                    Role = ChatRole.Assistant,
                    ModelId = GetBotId(options),
                    FinishReason = new ChatFinishReason("error"),
                    RawRepresentation = chunk,
                };
            }
            else if (chunk.Event == global::Coze.ChatV3ResponseEvent.ConversationChatRequiresAction)
            {
                yield return new ChatResponseUpdate
                {
                    ResponseId = currentResponseId,
                    ConversationId = currentConversationId,
                    Role = ChatRole.Assistant,
                    ModelId = GetBotId(options),
                    FinishReason = ChatFinishReason.ToolCalls,
                    RawRepresentation = chunk,
                };
            }
        }

        // Try to retrieve usage after streaming is complete.
        if (currentResponseId is not null && currentConversationId is not null)
        {
            var usage = await TryGetUsageAsync(currentConversationId, currentResponseId, cancellationToken)
                .ConfigureAwait(false);

            if (usage is not null)
            {
                yield return new ChatResponseUpdate
                {
                    ResponseId = currentResponseId,
                    ConversationId = currentConversationId,
                    Role = ChatRole.Assistant,
                    Contents = [new UsageContent(usage)],
                };
            }
        }
    }

    private async Task<UsageDetails?> TryGetUsageAsync(
        string conversationId,
        string chatId,
        CancellationToken cancellationToken)
    {
        try
        {
            var chatDetail = await RetrieveChatOpenAsync(
                conversationId: conversationId,
                chatId: chatId,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            if (chatDetail.Data?.Usage is { } u)
            {
                return new UsageDetails
                {
                    InputTokenCount = u.InputCount,
                    OutputTokenCount = u.OutputCount,
                    TotalTokenCount = u.TokenCount,
                };
            }
        }
        catch (global::Coze.ApiException)
        {
            // Usage retrieval is best-effort; ignore API errors.
        }
        catch (System.Net.Http.HttpRequestException)
        {
            // Usage retrieval is best-effort; ignore network errors.
        }

        return null;
    }

    private global::Coze.ChatV3Request CreateChatRequest(
        IEnumerable<ChatMessage> chatMessages,
        ChatOptions? options)
    {
        var additionalMessages = new List<global::Coze.EnterMessage2>();

        foreach (var message in chatMessages)
        {
            var role = message.Role == ChatRole.Assistant
                ? global::Coze.EnterMessage2Role.Assistant
                : global::Coze.EnterMessage2Role.User;

            // Determine message type.
            var type = message.Role == ChatRole.Assistant
                ? global::Coze.EnterMessage2Type.Answer
                : global::Coze.EnterMessage2Type.Question;

            // Handle FunctionResultContent (tool results).
            var functionResults = message.Contents.OfType<FunctionResultContent>().ToList();
            if (functionResults.Count > 0)
            {
                foreach (var result in functionResults)
                {
                    var resultText = result.Result switch
                    {
                        string s => s,
                        not null => System.Text.Json.JsonSerializer.Serialize(result.Result),
                        _ => result.Exception?.Message ?? string.Empty,
                    };

                    additionalMessages.Add(new global::Coze.EnterMessage2
                    {
                        Role = global::Coze.EnterMessage2Role.User,
                        Type = global::Coze.EnterMessage2Type.ToolOutput,
                        Content = resultText,
                        ContentType = global::Coze.EnterMessage2ContentType.Text,
                    });
                }

                continue;
            }

            // Handle FunctionCallContent (from assistant messages).
            var functionCalls = message.Contents.OfType<FunctionCallContent>().ToList();
            if (functionCalls.Count > 0)
            {
                foreach (var fc in functionCalls)
                {
                    var argsJson = fc.Arguments is not null
                        ? System.Text.Json.JsonSerializer.Serialize(fc.Arguments)
                        : "{}";

                    additionalMessages.Add(new global::Coze.EnterMessage2
                    {
                        Role = global::Coze.EnterMessage2Role.Assistant,
                        Type = global::Coze.EnterMessage2Type.FunctionCall,
                        Content = argsJson,
                        ContentType = global::Coze.EnterMessage2ContentType.Text,
                    });
                }

                continue;
            }

            // Handle text content.
            var textParts = message.Contents.OfType<TextContent>().ToList();
            if (textParts.Count > 0)
            {
                var text = string.Concat(textParts.Select(t => t.Text));
                if (text.Length > 0)
                {
                    additionalMessages.Add(new global::Coze.EnterMessage2
                    {
                        Role = role,
                        Type = type,
                        Content = text,
                        ContentType = global::Coze.EnterMessage2ContentType.Text,
                    });
                }
            }
        }

        var request = options?.RawRepresentationFactory?.Invoke(this) as global::Coze.ChatV3Request;
        if (request is not null)
        {
            request.BotId ??= GetBotId(options);
            request.UserId ??= GetUserId(options);
            if (request.AdditionalMessages is null)
            {
                request.AdditionalMessages = additionalMessages;
            }
            else
            {
                foreach (var msg in additionalMessages)
                {
                    request.AdditionalMessages.Add(msg);
                }
            }
        }
        else
        {
            request = new global::Coze.ChatV3Request
            {
                BotId = GetBotId(options),
                UserId = GetUserId(options),
                AdditionalMessages = additionalMessages,
                AutoSaveHistory = true,
            };
        }

        return request;
    }

    private string GetBotId(ChatOptions? options)
    {
        if (options?.AdditionalProperties?.TryGetValue("bot_id", out var botIdObj) == true &&
            botIdObj is string botId && botId.Length > 0)
        {
            return botId;
        }

        if (options?.ModelId is { Length: > 0 } modelId)
        {
            return modelId;
        }

        return _botId ?? throw new InvalidOperationException(
            "A bot_id is required for Coze chat requests. " +
            "Set it via WithBotId(), ChatOptions.ModelId, or ChatOptions.AdditionalProperties[\"bot_id\"].");
    }

    private string GetUserId(ChatOptions? options)
    {
        if (options?.AdditionalProperties?.TryGetValue("user_id", out var userIdObj) == true &&
            userIdObj is string userId && userId.Length > 0)
        {
            return userId;
        }

        return _userId;
    }

    private static string? GetConversationId(ChatOptions? options)
    {
        if (options?.AdditionalProperties?.TryGetValue("conversation_id", out var convIdObj) == true &&
            convIdObj is string convId && convId.Length > 0)
        {
            return convId;
        }

        return null;
    }
}
