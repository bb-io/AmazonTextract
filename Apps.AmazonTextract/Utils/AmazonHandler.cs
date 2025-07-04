using Amazon.Textract;
using Blackbird.Applications.Sdk.Common.Exceptions;

namespace Apps.AmazonTextract.Utils;

public class AmazonHandler
{
    public static async Task<T> Execute<T>(Func<Task<T>> func)
    {
        try
        {
            return await func();
        }
        catch (AmazonTextractException ex)
        {
            throw new PluginApplicationException(ex.Message, ex);
        }
        catch (Exception ex)
        {
            throw new PluginApplicationException(ex.Message);
        }
    }
}