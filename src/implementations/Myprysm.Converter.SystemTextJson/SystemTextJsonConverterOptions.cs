namespace Myprysm.Converter.SystemTextJson;

using System.Text.Json;
using Myprysm.Converter.Abstractions;

/// <summary>
/// Options for the System.Text.Json <see cref="IConverter"/>.
/// </summary>
public class SystemTextJsonConverterOptions : ConverterOptions
{
    /// <summary>
    /// Gets or sets the settings used by System.Text.Json for serialization.
    /// </summary>
    public JsonSerializerOptions JsonSerializerSettings { get; set; } = new(Json.DefaultSettings);
}
