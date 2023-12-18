using Amazon;
using Amazon.Runtime;
using Amazon.Textract;
using Apps.AmazonTextract.Constants;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;

namespace Apps.AmazonTextract.Api;

public class AppClient : AmazonTextractClient
{
    public AppClient(AuthenticationCredentialsProvider[] creds) : base(GetAwsCreds(creds), new AmazonTextractConfig()
    {
        RegionEndpoint = RegionEndpoint.USWest1,
    })
    {
    }

    private static AWSCredentials GetAwsCreds(AuthenticationCredentialsProvider[] creds)
    {
        var key = creds.Get(CredsNames.AccessKey).Value;
        var secret = creds.Get(CredsNames.AccessSecret).Value;

        return new BasicAWSCredentials(key, secret);
    }
}