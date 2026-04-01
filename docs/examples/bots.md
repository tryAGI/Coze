# Bots

Examples of listing published bots in a workspace.

This example assumes `using Coze;` is in scope and `apiKey` contains your Coze API key.

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