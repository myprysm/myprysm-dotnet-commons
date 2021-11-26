namespace Myprysm.Converter.Abstractions;

using Myprysm.Tracing.Abstractions;

public class TracedConverter : IConverter
{
    private readonly IConverter delegated;
    private readonly ITracer tracer;

    public TracedConverter(
        IConverter delegated,
        ITracer tracer)
    {
        this.delegated = delegated;
        this.tracer = tracer;
    }

    public object? Read(Stream data, Type type)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Read));
        trace?.AddTag("converter.type", type.ToString());

        try
        {
            return this.delegated.Read(data, type);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public void WriteToStream(object? data, Stream stream)
    {
        using var trace = this.tracer.StartTrace(nameof(this.WriteToStream));
        trace?.AddTag("converter.type", data?.GetType().Name ?? "null");

        try
        {
            this.delegated.WriteToStream(data, stream);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }
}
