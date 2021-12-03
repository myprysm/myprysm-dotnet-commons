namespace Myprysm.Converter.NewtonsoftJson;

using System.Diagnostics.CodeAnalysis;
using Myprysm.Converter.Abstractions;
using Newtonsoft.Json;

/// <summary>
/// Options for the NewtonsoftJson <see cref="IConverter"/>.
/// </summary>
[ExcludeFromCodeCoverage]
public class NewtonsoftJsonConverterOptions : ConverterOptions
{
    /// <summary>
    /// Gets or sets the settings used by NewtonsoftJson for serialization.
    /// </summary>
    public JsonSerializerSettings JsonSerializerSettings { get; set; } = Json.DefaultSettings;
}
