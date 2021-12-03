namespace Myprysm.Converter.NewtonsoftJson.ValueObjects;

using Newtonsoft.Json;

/// <summary>
/// <see cref="JsonSerializerSettings"/> extensions.
/// </summary>
public static class JsonSerializerSettingsExtensions
{
    /// <summary>
    /// Configure the <see cref="SingleValueObjectConverter"/> on the given <see cref="JsonSerializerSettings"/>.
    /// </summary>
    /// <param name="settings">The settings to configure the <see cref="SingleValueObjectConverter"/>.</param>
    /// <returns>The configured settings for fluent APIs.</returns>
    public static JsonSerializerSettings ConfigureValueObjectConverters(this JsonSerializerSettings settings)
    {
        if (!settings.Converters.Any(c => c is SingleValueObjectConverter))
        {
            settings.Converters.Add(new SingleValueObjectConverter());
        }

        return settings;
    }
}
