namespace Myprysm.FileService.FileSystem;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

internal static class FileServiceFileSystemConstants
{
    public static readonly Assembly Assembly = typeof(FileServiceFileSystemConstants).Assembly;
    public static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    public static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    public static readonly string TracerName = typeof(FileServiceFileSystemConstants).Assembly.FullName ?? "Myprysm.FileService.FileSystem";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
