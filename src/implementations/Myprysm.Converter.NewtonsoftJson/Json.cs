namespace Myprysm.Converter.NewtonsoftJson;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

public static class Json
{
    private static readonly Lazy<JsonSerializerSettings> LazyDefaultSettings =
        new(CreateDefaultSerializer);

    public static JsonSerializerSettings DefaultSettings => LazyDefaultSettings.Value;

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
