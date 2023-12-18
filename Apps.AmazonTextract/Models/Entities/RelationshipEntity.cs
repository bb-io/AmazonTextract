using Amazon.Textract.Model;
using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonTextract.Models.Entities;

public class RelationshipEntity
{
    [Display("Relationship type")] public string RelationshipType { get; set; }

    [Display("IDs")]
    public IEnumerable<string> Ids { get; set; }

    public RelationshipEntity(Relationship relationship)
    {
        RelationshipType = relationship.Type.ToString();
        Ids = relationship.Ids;
    }
}