using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.AmazonTextract.DataSourceHandlers.EnumHandlers;

public class FeatureTypeDataHandler : IStaticDataSourceHandler
{
    public Dictionary<string, string> GetData()
        => new()
        {
            { "TABLES", "Tables" },
            { "FORMS", "Forms" },
            { "SIGNATURES", "Signatures" },
            { "LAYOUT", "Layout" },
        };
}