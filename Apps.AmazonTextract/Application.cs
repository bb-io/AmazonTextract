﻿using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Metadata;

namespace Apps.AmazonTextract;

public class Application : IApplication, ICategoryProvider
{
    public IEnumerable<ApplicationCategory> Categories
    {
        get => [ApplicationCategory.AmazonApps];
        set { }
    }
    
    public T GetInstance<T>()
    {
        throw new NotImplementedException();
    }
}