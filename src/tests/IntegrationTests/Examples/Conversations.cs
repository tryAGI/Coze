/*
order: 30
title: Conversations
slug: conversations

Examples of creating and retrieving conversations.
*/

namespace Coze.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CreateAndRetrieveConversation()
    {
        using var client = GetAuthenticatedClient();

        //// Create a new conversation using `CreateConversationApiAsync`.
        //// You can optionally associate it with a bot and provide metadata.
        var createResponse = await client.CreateConversationApiAsync(
            name: "Test Conversation");

        //// The response contains a `Code` field (0 means success) and a `Data` field
        //// with the created conversation details.
        createResponse.Code.Should().Be(0);
        createResponse.Data.Should().NotBeNull();
        createResponse.Data!.Id.Should().NotBeNullOrEmpty();

        var conversationId = createResponse.Data.Id!;
        Console.WriteLine($"Created conversation: {conversationId}");

        //// Retrieve the conversation by its ID using `RetrieveConversationApiAsync`.
        var retrieveResponse = await client.RetrieveConversationApiAsync(
            conversationId: conversationId);

        //// Verify that the retrieved conversation matches what was created.
        retrieveResponse.Code.Should().Be(0);
        retrieveResponse.Data.Should().NotBeNull();
        retrieveResponse.Data!.Id.Should().Be(conversationId);

        Console.WriteLine($"Retrieved conversation: {retrieveResponse.Data.Id}");
    }

    [TestMethod]
    public async Task Example_ListConversations()
    {
        //// To list conversations, you need a bot ID. You can find your bot ID
        //// in the Coze dashboard when viewing your bot's settings.
        var botId =
            Environment.GetEnvironmentVariable("COZE_BOT_ID") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("COZE_BOT_ID environment variable is not found.");

        using var client = GetAuthenticatedClient();

        //// List conversations for a specific bot using `ListConversationsApiAsync`.
        //// Only conversations created via the API or Chat SDK are returned.
        var response = await client.ListConversationsApiAsync(
            botId: botId,
            pageNum: 1,
            pageSize: 10);

        //// The response contains a `Code` field (0 means success) and a `Data` field
        //// with the conversation list and pagination info.
        response.Code.Should().Be(0);
        response.Data.Should().NotBeNull();

        //// Each conversation has an `Id`, `CreatedAt` timestamp, and optional `Name`.
        if (response.Data!.Conversations is { Count: > 0 } conversations)
        {
            var firstConversation = conversations[0];
            firstConversation.Id.Should().NotBeNullOrEmpty();

            Console.WriteLine($"First conversation: {firstConversation.Id} (Name: {firstConversation.Name})");
        }

        Console.WriteLine($"Has more: {response.Data.HasMore}");
    }
}
