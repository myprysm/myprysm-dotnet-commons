namespace Myprysm.ImageService.ImageSharp;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

public static class ImageServiceImageSharpConstants
{
    public static readonly Assembly Assembly = typeof(ImageServiceImageSharpConstants).Assembly;
    public static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    public static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    public static readonly string TracerName = typeof(ImageServiceImageSharpConstants).Assembly.FullName ?? "Myprysm.ImageService.ImageSharp";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
