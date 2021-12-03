namespace Myprysm.FileService.AzureStorageBlob;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

internal class FileServiceAzureStorageBlobConstants
{
    public static readonly Assembly Assembly = typeof(FileServiceAzureStorageBlobConstants).Assembly;
    public static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    public static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    public static readonly string TracerName = typeof(FileServiceAzureStorageBlobConstants).Assembly.FullName ?? "Myprysm.FileService.AzureStorageBlob";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
