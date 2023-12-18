using Amazon.Textract.Model;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonTextract.Models.Entities;

public class IdentityDocumentFieldEntity
{
    public string? Type { get; set; }
    
    public string Text { get; set; }
    
    [Display("Normalized value type")]
    public string? NormalizedValueType { get; set; }
    
    [Display("Normalized value")]
    public string? NormalizedValue { get; set; }
    
    public float Confidence { get; set; }

    public IdentityDocumentFieldEntity(IdentityDocumentField identityDocumentField)
    {
        Type = identityDocumentField.Type?.Text;
        Confidence = identityDocumentField.ValueDetection.Confidence;
        Text = identityDocumentField.ValueDetection.Text;
        NormalizedValueType = identityDocumentField.ValueDetection.NormalizedValue?.ValueType?.ToString();
        NormalizedValue = identityDocumentField.ValueDetection.NormalizedValue?.Value;
    }

}