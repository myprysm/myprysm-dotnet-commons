namespace Myprysm.Converter.SystemTextJson.ValueObjects;

using System.Text.Json;

/// <summary>
/// <see cref="JsonSerializerOptions"/> extensions.
/// </summary>
public static class JsonSerializerOptionsExtensions
{
    /// <summary>
    /// Configure the <see cref="SingleValueObjectConverter{TSvo,TWrapped}"/> on the given <see cref="JsonSerializerOptions"/>.
    /// </summary>
    /// <param name="settings">The settings to configure the <see cref="SingleValueObjectConverterFactory"/>.</param>
    /// <returns>The configured settings for fluent APIs.</returns>
    public static JsonSerializerOptions ConfigureValueObjectConverters(this JsonSerializerOptions settings)
    {
        if (!settings.Converters.Any(c => c is SingleValueObjectConverterFactory))
        {
            settings.Converters.Add(new SingleValueObjectConverterFactory());
        }

        return settings;
    }
}
