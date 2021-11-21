namespace Myprysm.Tracing.Abstractions;

using System.Diagnostics.CodeAnalysis;

public class StartupTracerOptions
{
    public List<TracerIdentity> OnStartup { get; [ExcludeFromCodeCoverage] set; } = new();
}
