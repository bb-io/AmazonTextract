using Amazon.Textract.Model;
using Apps.AmazonTextract.Models.Entities;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonTextract.Models.Response;

public class AnalyzeIdentityDocumentResponse
{
    [Display("Identity documents")]
    public IEnumerable<IdentityDocumentEntity> IdentityDocuments { get; set; }

    public AnalyzeIdentityDocumentResponse(AnalyzeIDResponse response)
    {
        IdentityDocuments = response.IdentityDocuments.Select(x => new IdentityDocumentEntity(x));
    }

}