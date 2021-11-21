namespace Myprysm.Converter.NewtonsoftJson;

using Myprysm.Converter.Abstractions;
using Newtonsoft.Json;

public class JsonConverter : IConverter
{
    private readonly JsonSerializer serializer;

    public JsonConverter(JsonSerializerSettings settings)
    {
        this.serializer = JsonSerializer.Create(settings);
    }

    public object? Read(Stream data, Type type)
    {
        using var sr = new StreamReader(data, IConverter.DefaultEncoding);
        using var reader = new JsonTextReader(sr);

        return this.serializer.Deserialize(reader, type);
    }

    public void WriteToStream(object data, Stream stream)
    {
        using var sw = new StreamWriter(stream, IConverter.DefaultEncoding, -1, true);
        using var writer = new JsonTextWriter(sw);

        this.serializer.Serialize(writer, data);
    }
}
