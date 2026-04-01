/*
order: 40
title: MEAI Chat Client
slug: meai-chat-client

Examples of using the Coze SDK through Microsoft.Extensions.AI.
*/

using Microsoft.Extensions.AI;

namespace Coze.IntegrationTests;

public partial class Tests
{
    //// Coze exposes its bot chat API through `Microsoft.Extensions.AI.IChatClient`.
    //// Every request is bot-centric, so the examples configure a `bot_id` first.

    [TestMethod]
    public async Task Example_MeaiChatClient_GetResponse()
    {
        using var client = GetAuthenticatedClient()
            .WithBotId(GetBotId())
            .WithUserId("meai-example-user");

        IChatClient chatClient = client;

        //// `WithBotId(...)` sets the default Coze bot used for MEAI requests.
        var response = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Reply with only the word ok.")]);

        response.Should().NotBeNull();
        response.Text.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public async Task Example_MeaiChatClient_GetStreamingResponse()
    {
        using var client = GetAuthenticatedClient()
            .WithBotId(GetBotId())
            .WithUserId("meai-example-user");

        IChatClient chatClient = client;

        //// Streaming yields incremental text updates as Coze sends answer deltas.
        var updates = chatClient.GetStreamingResponseAsync(
            [new ChatMessage(ChatRole.User, "Reply with only the word ok.")]);

        var deltas = new List<string>();
        await foreach (var update in updates)
        {
            if (!string.IsNullOrWhiteSpace(update.Text))
            {
                deltas.Add(update.Text);
            }
        }

        deltas.Should().NotBeEmpty();
    }

    [TestMethod]
    public void Example_MeaiChatClient_GetServiceReturnsChatClientMetadata()
    {
        using var client = GetAuthenticatedClient();
        IChatClient chatClient = client;

        //// MEAI metadata exposes the provider name and endpoint URI.
        var metadata = chatClient.GetService<ChatClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(CozeClient));
    }

    [TestMethod]
    public void Example_MeaiChatClient_GetServiceReturnsSelf()
    {
        using var client = GetAuthenticatedClient();
        IChatClient chatClient = client;

        //// `GetService<T>()` can also return the underlying SDK client instance.
        var self = chatClient.GetService<CozeClient>();

        self.Should().BeSameAs(client);
    }
}
