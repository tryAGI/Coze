# Coze

[![Nuget package](https://img.shields.io/nuget/vpre/Coze)](https://www.nuget.org/packages/Coze/)
[![dotnet](https://github.com/tryAGI/Coze/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Coze/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Coze)](https://github.com/tryAGI/Coze/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Coze OpenAPI specification](https://raw.githubusercontent.com/coze-dev/coze-sdk-gen/main/coze-openapi.yaml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `IChatClient` support for bot-based chat

### Usage
```csharp
using Coze;

using var client = new CozeClient(apiKey);
```

### Microsoft.Extensions.AI

The SDK implements [`IChatClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient):

```csharp
using Coze;
using Microsoft.Extensions.AI;

var botId = Environment.GetEnvironmentVariable("COZE_BOT_ID")!;

IChatClient chatClient = new CozeClient(apiKey)
    .WithBotId(botId)
    .WithUserId("demo-user");

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Reply with only the word ok.")]);

Console.WriteLine(response.Text);
```

Coze chat is bot-centric. You must provide a `bot_id` via `WithBotId(...)`, `ChatOptions.ModelId`, or `ChatOptions.AdditionalProperties["bot_id"]`.

<!-- EXAMPLES:START -->
### Generate
Basic example showing how to create a client and make a request.

```csharp
using var client = new CozeClient(apiKey);
```

### Bots
Examples of listing published bots in a workspace.

```csharp
// To list bots, you need a workspace (space) ID. You can find your workspace ID
// in the Coze dashboard URL when viewing your workspace.
var workspaceId =
    Environment.GetEnvironmentVariable("COZE_WORKSPACE_ID") is { Length: > 0 } value
        ? value
        : throw new AssertInconclusiveException("COZE_WORKSPACE_ID environment variable is not found.");

using var client = new CozeClient(apiKey);

// List published bots in the workspace using `GetSpacePublishedBotsListAsync`.
// This returns bots that have been published and are available for use.
var response = await client.GetSpacePublishedBotsListAsync(
    spaceId: workspaceId,
    pageSize: 10);

// The response contains a `Code` field (0 means success) and a `Data` field
// with the list of bots and total count.

// Each bot in the list has a `BotId`, `BotName`, and optional `Description`.
if (response.Data.SpaceBots is { Count: > 0 } bots)
{
    var firstBot = bots[0];

    Console.WriteLine($"First bot: {firstBot.BotName} (ID: {firstBot.BotId})");
}
```

### Workflows
Examples of listing workflows in a workspace.

```csharp
// To list workflows, you need a workspace ID. You can find your workspace ID
// in the Coze dashboard URL when viewing your workspace.
var workspaceId =
    Environment.GetEnvironmentVariable("COZE_WORKSPACE_ID") is { Length: > 0 } value
        ? value
        : throw new AssertInconclusiveException("COZE_WORKSPACE_ID environment variable is not found.");

using var client = new CozeClient(apiKey);

// List workflows in the workspace using `OpenAPIGetWorkflowListAsync`.
// The `pageNum` parameter starts at 1 (one-based pagination).
var response = await client.OpenAPIGetWorkflowListAsync(
    workspaceId: workspaceId,
    pageNum: 1,
    pageSize: 10);

// The response contains a `Code` field (0 means success) and a `Data` field
// with the workflow items and pagination info.

// Each workflow has a `WorkflowId`, `WorkflowName`, and optional `Description`.
foreach (var workflow in response.Data.Items)
{
    Console.WriteLine($"Workflow: {workflow.WorkflowName} (ID: {workflow.WorkflowId})");
}

Console.WriteLine($"Has more: {response.Data.HasMore}");
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Coze/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Coze/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
