namespace Myprysm.Converter.Abstractions;

using Myprysm.Tracing.Abstractions;

internal class TracedConverter : IConverter
{
    private readonly IConverter delegated;
    private readonly ITracer tracer;

    internal TracedConverter(
        IConverter delegated,
        ITracer tracer)
    {
        this.delegated = delegated;
        this.tracer = tracer;
    }

    public object? Read(Stream data, Type type)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Read));
        trace?.AddTag("converter.type", type.FullName);

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

    public object? Read(byte[] data, Type type)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Read));
        trace?.AddTag("converter.type", type.FullName);

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

    public object? Read(string data, Type type)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Read));
        trace?.AddTag("converter.type", type.FullName);

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

    public TObj? Read<TObj>(Stream data)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Read));
        trace?.AddTag("converter.type", typeof(TObj).ToString());

        try
        {
            return this.delegated.Read<TObj>(data);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public TObj? Read<TObj>(byte[] data)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Read));
        trace?.AddTag("converter.type", typeof(TObj).ToString());

        try
        {
            return this.delegated.Read<TObj>(data);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public TObj? Read<TObj>(string data)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Read));
        trace?.AddTag("converter.type", typeof(TObj).ToString());

        try
        {
            return this.delegated.Read<TObj>(data);
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
        trace?.AddTag("converter.type", data?.GetType().FullName ?? "null");

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

    public byte[] WriteBytes(object? data)
    {
        using var trace = this.tracer.StartTrace(nameof(this.WriteBytes));
        trace?.AddTag("converter.type", data?.GetType().FullName ?? "null");

        try
        {
            return this.delegated.WriteBytes(data);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public string WriteString(object? data)
    {
        using var trace = this.tracer.StartTrace(nameof(this.WriteString));
        trace?.AddTag("converter.type", data?.GetType().FullName ?? "null");

        try
        {
            return this.delegated.WriteString(data);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public object? Convert(object data, Type type)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Convert));
        trace?.AddTag("converter.type", type.FullName);

        try
        {
            return this.delegated.Convert(data, type);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public TObj? Convert<TObj>(object data)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Convert));
        trace?.AddTag("converter.type", typeof(TObj).ToString());

        try
        {
            return this.delegated.Convert<TObj>(data);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }
}
