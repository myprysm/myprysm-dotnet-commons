namespace Myprysm.Converter.NewtonsoftJson;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

internal static class NewtonsoftJsonConverterConstants
{
    public static readonly Assembly Assembly = typeof(NewtonsoftJsonConverterConstants).Assembly;
    public static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    public static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    public static readonly string TracerName = typeof(NewtonsoftJsonConverterConstants).Assembly.FullName ?? "Myprysm.Converter.NewtonsoftJson";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
