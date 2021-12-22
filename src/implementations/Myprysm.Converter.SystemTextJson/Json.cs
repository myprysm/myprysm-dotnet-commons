namespace Myprysm.Converter.SystemTextJson;

using System.Text.Json;
using System.Text.Json.Serialization;
using Myprysm.Converter.Abstractions;

/// <summary>
/// Configuration class holding the settings uses for NewtonsoftJson by this <see cref="IConverter"/>.
/// </summary>
public static class Json
{
    private static readonly Lazy<JsonSerializerOptions> LazyDefaultSettings = new(CreateDefaultSerializer);

    /// <summary>
    /// The default settings used by the converter.
    /// </summary>
    public static JsonSerializerOptions DefaultSettings => LazyDefaultSettings.Value;

    /// <summary>
    /// Configure the same defaults as used by this <see cref="IConverter"/> on the given settings. 
    /// </summary>
    /// <param name="settings">The settings to configure.</param>
    /// <returns>The configured settings for fluent APIs.</returns>
    public static JsonSerializerOptions ConfigureDefaults(this JsonSerializerOptions settings)
    {
        settings.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        settings.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        settings.UnknownTypeHandling = JsonUnknownTypeHandling.JsonNode;
        settings.MaxDepth = 32;
        settings.WriteIndented = false;
        settings.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        settings.Converters.Add(new JsonStringEnumConverter());

        return settings;
    }

    private static JsonSerializerOptions CreateDefaultSerializer()
    {
        return new JsonSerializerOptions().ConfigureDefaults();
    }
}
