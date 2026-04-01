namespace Coze.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static CozeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("COZE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("COZE_API_KEY environment variable is not found.");

        var client = new CozeClient(apiKey);
        
        return client;
    }

    private static string GetBotId() =>
        Environment.GetEnvironmentVariable("COZE_BOT_ID") is { Length: > 0 } botId
            ? botId
            : throw new AssertInconclusiveException("COZE_BOT_ID environment variable is not found.");
}
