using Amazon.Textract.Model;
using Apps.AmazonTextract.Models.Entities;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonTextract.Models.Response;

public class AnalyzeDocumentExpenseResponse
{
    [Display("Expense documents")] public IEnumerable<ExpenseDocumentEntity> ExpenseDocuments { get; set; }

    public AnalyzeDocumentExpenseResponse(AnalyzeExpenseResponse response)
    {
        ExpenseDocuments = response.ExpenseDocuments.Select(x => new ExpenseDocumentEntity(x));
    }
}