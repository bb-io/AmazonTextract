using Amazon;
using Apps.AmazonTextract.Constants;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Connections;

namespace Apps.AmazonTextract.Connections;

public class ConnectionDefinition : IConnectionDefinition
{
    public IEnumerable<ConnectionPropertyGroup> ConnectionPropertyGroups => new List<ConnectionPropertyGroup>
    {
        new()
        {
            Name = "Developer API key",
            AuthenticationType = ConnectionAuthenticationType.Undefined,
            ConnectionProperties = new List<ConnectionProperty>
            {
                new(CredsNames.AccessKey) { DisplayName = "Access key" },
                new(CredsNames.AccessSecret) { DisplayName = "Access secret", Sensitive = true },
                new(CredsNames.Region) { DisplayName = "Region", DataItems = RegionEndpoint.EnumerableAllRegions.Select(x => new ConnectionPropertyValue(x.SystemName, x.SystemName))  }
            }
        }
    };

    public IEnumerable<AuthenticationCredentialsProvider> CreateAuthorizationCredentialsProviders(
        Dictionary<string, string> values) =>
        values.Select(x => new AuthenticationCredentialsProvider(x.Key, x.Value)).ToList();
}