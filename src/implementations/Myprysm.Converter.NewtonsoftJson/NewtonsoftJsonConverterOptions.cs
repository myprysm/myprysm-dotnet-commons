namespace Myprysm.Converter.NewtonsoftJson;

using Myprysm.Converter.Abstractions;
using Newtonsoft.Json;

public class NewtonsoftJsonConverterOptions : ConverterOptions
{
    public JsonSerializerSettings JsonSerializerSettings { get; set; } = Json.DefaultSettings;
}
