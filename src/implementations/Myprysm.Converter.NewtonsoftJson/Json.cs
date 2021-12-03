namespace Myprysm.Converter.NewtonsoftJson;

using Myprysm.Converter.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

/// <summary>
/// Configuration class holding the settings uses for NewtonsoftJson by this <see cref="IConverter"/>.
/// </summary>
public static class Json
{
    private static readonly Lazy<JsonSerializerSettings> LazyDefaultSettings = new(CreateDefaultSerializer);

    /// <summary>
    /// The default settings used by the converter.
    /// </summary>
    public static JsonSerializerSettings DefaultSettings => LazyDefaultSettings.Value;

    /// <summary>
    /// Configure the same defaults as used by this <see cref="IConverter"/> on the given settings. 
    /// </summary>
    /// <param name="settings">The settings to configure.</param>
    /// <returns>The configured settings for fluent APIs.</returns>
    public static JsonSerializerSettings ConfigureDefaults(this JsonSerializerSettings settings)
    {
        settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        settings.NullValueHandling = NullValueHandling.Ignore;
        settings.MissingMemberHandling = MissingMemberHandling.Ignore;
        settings.MaxDepth = 32;
        settings.Formatting = Formatting.None;
        settings.TypeNameHandling = TypeNameHandling.None;
        settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        settings.Converters.Add(new StringEnumConverter());

        return settings;
    }

    private static JsonSerializerSettings CreateDefaultSerializer()
    {
        return new JsonSerializerSettings().ConfigureDefaults();
    }
}
