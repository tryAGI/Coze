# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Coze SDK implements `IChatClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Installation

```bash
dotnet add package Coze
```

## Bot-Centric Setup

Coze chat requests are bot-centric. Every MEAI chat request needs a `bot_id`, and the SDK also carries a `user_id`.

- Set the default bot with `WithBotId(...)`.
- Set the default user with `WithUserId(...)`.
- Or pass `bot_id`, `user_id`, and `conversation_id` through `ChatOptions.AdditionalProperties`.

If you do not configure a user explicitly, the SDK uses `"meai_user"` by default.

## Chat Completions

```csharp
using Coze;
using Microsoft.Extensions.AI;

var botId = Environment.GetEnvironmentVariable("COZE_BOT_ID")!;

IChatClient client = new CozeClient(apiKey)
    .WithBotId(botId)
    .WithUserId("demo-user");

var response = await client.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Reply with only the word ok.")]);

Console.WriteLine(response.Text);
```

## Streaming

```csharp
using Coze;
using Microsoft.Extensions.AI;

var botId = Environment.GetEnvironmentVariable("COZE_BOT_ID")!;

IChatClient client = new CozeClient(apiKey)
    .WithBotId(botId);

await foreach (var update in client.GetStreamingResponseAsync(
    [new ChatMessage(ChatRole.User, "List three short colors.")]))
{
    Console.Write(update.Text);
}
```

## Reasoning Content

When Coze returns reasoning text, the SDK exposes it as `TextReasoningContent`.

```csharp
using Microsoft.Extensions.AI;

var response = await client.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Explain why the sky looks blue.")]);

foreach (var content in response.Messages.SelectMany(m => m.Contents))
{
    switch (content)
    {
        case TextReasoningContent reasoning:
            Console.WriteLine($"Reasoning: {reasoning.Text}");
            break;
        case TextContent text:
            Console.WriteLine($"Answer: {text.Text}");
            break;
    }
}
```

## Conversation Reuse

To continue an existing Coze conversation, pass `conversation_id` through `AdditionalProperties`.

```csharp
var response = await client.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Continue the previous task.")],
    new ChatOptions
    {
        AdditionalProperties = new AdditionalPropertiesDictionary
        {
            ["conversation_id"] = existingConversationId,
        },
    });
```

## Tool Calling Caveat

The Coze adapter can send MEAI tool results back to Coze and maps Coze requires-action states to `ChatFinishReason.ToolCalls`.

At the moment, Coze's MEAI adapter does not yet surface provider-issued tool calls back as `FunctionCallContent` in the returned MEAI response. In practice, this means `response.CallToolsAsync(options)` style automatic loops are not available yet even though Coze can signal that tool work is required.

## Dependency Injection

```csharp
using Coze;
using Microsoft.Extensions.AI;

var botId = builder.Configuration["Coze:BotId"]!;
var userId = builder.Configuration["Coze:UserId"] ?? "app-user";

builder.Services.AddSingleton<IChatClient>(
    new CozeClient(builder.Configuration["Coze:ApiKey"]!)
        .WithBotId(botId)
        .WithUserId(userId));
```

## Provider Metadata

```csharp
var metadata = client.GetService<ChatClientMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "CozeClient"
Console.WriteLine($"Endpoint: {metadata?.ProviderUri}");
```
