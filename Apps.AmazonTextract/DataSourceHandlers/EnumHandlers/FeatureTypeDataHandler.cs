using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.AmazonTextract.DataSourceHandlers.EnumHandlers;

public class FeatureTypeDataHandler : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData()
        => new List<DataSourceItem>()
        {
            new DataSourceItem("TABLES", "Tables" ),
            new DataSourceItem("FORMS", "Forms" ),
            new DataSourceItem("SIGNATURES", "Signatures" ),
            new DataSourceItem("LAYOUT", "Layout" ),
        };
}