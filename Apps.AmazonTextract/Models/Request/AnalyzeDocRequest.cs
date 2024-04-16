using Apps.AmazonTextract.DataSourceHandlers.EnumHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.AmazonTextract.Models.Request;

public class AnalyzeDocRequest : FileRequest
{
    [Display("Feature types")]
    [StaticDataSource(typeof(FeatureTypeDataHandler))]
    public IEnumerable<string> FeatureTypes { get; set; }
}