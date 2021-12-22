namespace Myprysm.Converter.SystemTextJson;

using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Myprysm.Converter.Abstractions;
using Myprysm.Converter.Abstractions.Exceptions;

internal class SystemTextJsonConverter : IConverter
{
    private readonly ILogger<SystemTextJsonConverter> logger;
    private readonly SystemTextJsonConverterOptions options;

    public SystemTextJsonConverter(
        IOptions<SystemTextJsonConverterOptions> options,
        ILogger<SystemTextJsonConverter> logger)
    {
        this.logger = logger;
        this.options = options.Value;
    }

    public object? Read(Stream data, Type type)
    {
        try
        {
            return JsonSerializer.Deserialize(data, type, this.options.JsonSerializerSettings);
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
            JsonSerializer.Serialize(stream, data, this.options.JsonSerializerSettings);
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "An error occured while write {Type} to stream", data?.GetType());
            throw new ConversionWriteException($"An error occured while writing {data?.GetType()} to stream", exception);
        }
    }
}
