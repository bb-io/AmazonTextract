using Amazon.Textract.Model;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonTextract.Models.Entities;

public class IdentityDocumentEntity
{
    public IEnumerable<BlockEntity> Blocks { get; set; }

    [Display("Identity document fields")]
    public IEnumerable<IdentityDocumentFieldEntity> IdentityDocumentFields { get; set; }

    public IdentityDocumentEntity(IdentityDocument identityDocument)
    {
        Blocks = identityDocument.Blocks.Select(x => new BlockEntity(x));
        IdentityDocumentFields =
            identityDocument.IdentityDocumentFields.Select(x => new IdentityDocumentFieldEntity(x));
    }
}