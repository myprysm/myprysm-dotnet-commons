namespace Myprysm.Converter.NewtonsoftJson.ValueObjects;

using Newtonsoft.Json;

public static class JsonSerializerSettingsExtensions
{
    public static JsonSerializerSettings ConfigureValueObjectConverters(this JsonSerializerSettings settings)
    {
        if (!settings.Converters.Any(c => c is SingleValueObjectConverter))
        {
            settings.Converters.Add(new SingleValueObjectConverter());
        }

        return settings;
    }
}
