using Apps.AmazonTextract.Invocables;
using Apps.AmazonTextract.Models.Request;
using Apps.AmazonTextract.Models.Response;
using Apps.AmazonTextract.Utils;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;

namespace Apps.AmazonTextract.Actions;

[ActionList]
public class AnalysisActions : AppInvocable
{
    private readonly IFileManagementClient _fileManagementClient;

    public AnalysisActions(InvocationContext invocationContext, IFileManagementClient fileManagementClient) : base(
        invocationContext)
    {
        _fileManagementClient = fileManagementClient;
    }

    [Action("Analyze document", Description = "Analyze an input document for relationships between detected items")]
    public async Task<BlocksResponse> AnalyzeDocumet([ActionParameter] AnalyzeDocRequest input)
    {
        var file = await _fileManagementClient.DownloadAsync(input.File);

        var memoryStream = new MemoryStream();
        await file.CopyToAsync(memoryStream);

        var response = await AmazonHandler.Execute(() => Client.AnalyzeDocumentAsync(new()
        {
            FeatureTypes = input.FeatureTypes?.ToList(),
            Document = new()
            {
                Bytes = memoryStream
            }
        }));

        return new(response.Blocks);
    }

    [Action("Analyze expense",
        Description = "Analyze an input document for financially related relationships between text")]
    public async Task<AnalyzeDocumentExpenseResponse> AnalyzeExpense([ActionParameter] FileRequest fileInput)
    {
        var file = await _fileManagementClient.DownloadAsync(fileInput.File);

        var memoryStream = new MemoryStream();
        await file.CopyToAsync(memoryStream);

        var response = await AmazonHandler.Execute(() => Client.AnalyzeExpenseAsync(new()
        {
            Document = new()
            {
                Bytes = memoryStream
            }
        }));

        return new(response);
    }

    [Action("Analyze identity document", Description = "Analyze identity document for relevant information")]
    public async Task<AnalyzeIdentityDocumentResponse> AnalyzeIdentityDocuments([ActionParameter] FileRequest fileInput)
    {
        var file = await _fileManagementClient.DownloadAsync(fileInput.File);

        var memoryStream = new MemoryStream();
        await file.CopyToAsync(memoryStream);

        var response = await AmazonHandler.Execute(() => Client.AnalyzeIDAsync(new()
        {
            DocumentPages = new()
            {
                new()
                {
                    Bytes = memoryStream
                }
            }
        }));

        return new(response);
    }

    [Action("Detect document text", Description = "Detect text in the input document")]
    public async Task<BlocksResponse> DetectDocumentText([ActionParameter] FileRequest fileInput)
    {
        var file = await _fileManagementClient.DownloadAsync(fileInput.File);

        var memoryStream = new MemoryStream();
        await file.CopyToAsync(memoryStream);

        var response = await AmazonHandler.Execute(() => Client.DetectDocumentTextAsync(new()
        {
            Document = new()
            {
                Bytes = memoryStream
            }
        }));

        return new(response.Blocks);
    }
}