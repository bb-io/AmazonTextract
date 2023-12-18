using Blackbird.Applications.Sdk.Common;

namespace Apps.AmazonTextract;

public class Application : IApplication
{
    public string Name
    {
        get => "Amazon Textract";
        set { }
    }

    public T GetInstance<T>()
    {
        throw new NotImplementedException();
    }
}