namespace Myprysm.PubSub.AzureStorageQueue;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

public static class PubSubAzureStorageQueueConstants
{
    public static readonly Assembly Assembly = typeof(PubSubAzureStorageQueueConstants).Assembly;
    public static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    public static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    public static readonly string TracerName = typeof(PubSubAzureStorageQueueConstants).Assembly.FullName ?? "Myprysm.PubSub.AzureStorageQueue";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
