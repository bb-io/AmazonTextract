using Amazon.Textract.Model;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonTextract.Models.Entities;

public class ExpenseDocumentEntity
{
    public IEnumerable<BlockEntity> Blocks { get; set; }

    [Display("Expense index")]
    public int? ExpenseIndex { get; set; }

    public ExpenseDocumentEntity(ExpenseDocument expenseDocument)
    {
        Blocks = expenseDocument.Blocks.Select(x => new BlockEntity(x));
        ExpenseIndex = expenseDocument.ExpenseIndex;
    }
}