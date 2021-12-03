namespace Myprysm.Converter.Abstractions;

/// <summary>
/// Base converter options.
///
/// You should extend those options and use the dependency injection extensions if you want to enable tracing
/// </summary>
public class ConverterOptions
{
    /// <summary>
    /// Enable tracing with the converter implementation.
    /// </summary>
    /// <remarks>Tracing is enabled by default.</remarks>
    public bool WithTracing { get; set; } = true;
}
