namespace Myprysm.Converter.NewtonsoftJson;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Myprysm.Converter.Abstractions;
using Myprysm.Converter.Abstractions.Exceptions;
using Newtonsoft.Json;

public class NewtonsoftJsonConverter : IConverter
{
    private readonly ILogger<NewtonsoftJsonConverter> logger;
    private readonly JsonSerializer serializer;

    public NewtonsoftJsonConverter(
        IOptions<NewtonsoftJsonConverterOptions> options,
        ILogger<NewtonsoftJsonConverter> logger)
    {
        this.logger = logger;
        this.serializer = JsonSerializer.Create(options.Value.JsonSerializerSettings);
    }

    public object? Read(Stream data, Type type)
    {
        try
        {
            using var sr = new StreamReader(data, IConverter.DefaultEncoding);
            using var reader = new JsonTextReader(sr);

            return this.serializer.Deserialize(reader, type);
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "An error occured while reading stream to {Type}", type);
            throw new ConversionReadException($"An error occured while reading stream to {type}", exception);
        }
    }

    public void WriteToStream(object? data, Stream stream)
    {
        try
        {
            using var sw = new StreamWriter(stream, IConverter.DefaultEncoding, -1, true);
            using var writer = new JsonTextWriter(sw);

            this.serializer.Serialize(writer, data);
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "An error occured while write {Type} to stream", data?.GetType());
            throw new ConversionWriteException($"An error occured while writing {data?.GetType()} to stream", exception);
        }
    }
}
