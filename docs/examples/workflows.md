# Workflows

Examples of listing workflows in a workspace.

This example assumes `using Coze;` is in scope and `apiKey` contains your Coze API key.

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