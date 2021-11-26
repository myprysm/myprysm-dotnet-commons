namespace Myprysm.FileService.Minio;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

public class FileServiceMinioConstants
{
    public static readonly Assembly Assembly = typeof(FileServiceMinioConstants).Assembly;
    public static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    public static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    public static readonly string TracerName = typeof(FileServiceMinioConstants).Assembly.FullName ?? "Myprysm.FileService.Minio";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
