namespace Myprysm.Converter.SystemTextJson;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

internal static class SystemTextJsonConverterConstants
{
    public static readonly Assembly Assembly = typeof(SystemTextJsonConverterConstants).Assembly;
    public static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    public static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    public static readonly string TracerName = typeof(SystemTextJsonConverterConstants).Assembly.FullName ?? "Myprysm.Converter.SystemTextJson";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
