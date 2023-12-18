using Amazon.Textract.Model;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonTextract.Models.Entities;

public class BlockEntity
{
    [Display("Block ID")]
    public string Id { get; set; }

    [Display("Selection status")]
    public string? SelectionStatus { get; set; }

    public string Text { get; set; }

    [Display("Text type")]
    public string? TextType { get; set; }

    public string Type { get; set; }

    public float? Confidence { get; set; }
    
    public IEnumerable<RelationshipEntity> Relationships { get; set; }

    public BlockEntity(Block block)
    {
        Id = block.Id;
        Type = block.BlockType.ToString();
        Confidence = block.Confidence;
        SelectionStatus = block.SelectionStatus?.ToString();
        Text = block.Text;
        TextType = block.TextType?.ToString();
        Relationships = block.Relationships.Select(x => new RelationshipEntity(x));
    }
}