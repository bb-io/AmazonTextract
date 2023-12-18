using Blackbird.Applications.Sdk.Utils.Sdk.DataSourceHandlers;

namespace Apps.AmazonTextract.DataSourceHandlers.EnumHandlers;

public class FeatureTypeDataHandler : EnumDataHandler
{
    protected override Dictionary<string, string> EnumValues => new()
    {
        { "TABLES", "Tables" },
        { "FORMS", "Forms" },
        { "SIGNATURES", "Signatures" },
        { "LAYOUT", "Layout" },
    };
}