namespace Myprysm.Converter.Abstractions.Tests.Unit;

using FluentAssertions;
using Myprysm.Converter.Abstractions;
using Myprysm.Testing.NUnit;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class TracedConverterTests
{
    [Test]
    public void ReadStream_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        using var data = new MemoryStream();
        var type = typeof(string);
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.Read(data, type);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.Read));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", type.FullName));
    }

    [Test]
    public void ReadStream_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .ReadThrows(new Exception(message))
            .Build();
        using var data = new MemoryStream();
        var type = typeof(string);
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.Read(data, type);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void ReadByteArray_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = Array.Empty<byte>();
        var type = typeof(string);
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.Read(data, type);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.Read));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", type.FullName));
    }

    [Test]
    public void ReadByteArray_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .ReadThrows(new Exception(message))
            .Build();
        var data = Array.Empty<byte>();
        var type = typeof(string);
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.Read(data, type);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void ReadString_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = string.Empty;
        var type = typeof(string);
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.Read(data, type);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.Read));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", type.FullName));
    }

    [Test]
    public void ReadString_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .ReadThrows(new Exception(message))
            .Build();
        var data = string.Empty;
        var type = typeof(string);
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.Read(data, type);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void ReadStreamAs_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        using var data = new MemoryStream();
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.Read<string>(data);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.Read));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", typeof(string).FullName));
    }

    [Test]
    public void ReadStreamAs_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .ReadThrows(new Exception(message))
            .Build();
        using var data = new MemoryStream();
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.Read<string>(data);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void ReadByteArrayAs_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = Array.Empty<byte>();
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.Read<string>(data);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.Read));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", typeof(string).FullName));
    }

    [Test]
    public void ReadByteArrayAs_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .ReadThrows(new Exception(message))
            .Build();
        var data = Array.Empty<byte>();
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.Read<string>(data);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void ReadStringAs_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.Read<string>(data);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.Read));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", typeof(string).FullName));
    }

    [Test]
    public void ReadStringAs_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .ReadThrows(new Exception(message))
            .Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.Read<string>(data);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void WriteToStream_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(success);
        using var stream = new MemoryStream();

        // Act
        converter.WriteToStream(data, stream);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.WriteToStream));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", typeof(string).FullName));
    }

    [Test]
    public void WriteNullToStream_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = (object?)null;
        var (converter, collector) = GetSut(success);
        using var stream = new MemoryStream();

        // Act
        converter.WriteToStream(data, stream);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.WriteToStream));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", "null"));
    }

    [Test]
    public void WriteToStream_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .WriteThrows(new Exception(message))
            .Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(failure);
        using var stream = new MemoryStream();

        // Act
        var actual = () => converter.WriteToStream(data, stream);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void WriteBytes_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.WriteBytes(data);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.WriteBytes));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", typeof(string).FullName));
    }

    [Test]
    public void WriteNullBytes_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = (object?)null;
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.WriteBytes(data);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.WriteBytes));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", "null"));
    }

    [Test]
    public void WriteBytes_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .WriteThrows(new Exception(message))
            .Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.WriteBytes(data);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void WriteString_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.WriteString(data);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.WriteString));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", typeof(string).FullName));
    }

    [Test]
    public void WriteNullString_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = (object?)null;
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.WriteString(data);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.WriteString));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", "null"));
    }

    [Test]
    public void WriteString_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .WriteThrows(new Exception(message))
            .Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.WriteString(data);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void Convert_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = string.Empty;
        var type = typeof(string);
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.Convert(data, type);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.Convert));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", type.FullName));
    }

    [Test]
    public void Convert_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .WriteThrows(new Exception(message))
            .Build();
        var data = string.Empty;
        var type = typeof(string);
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.Convert(data, type);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public void ConvertAs_TagsConvertedType()
    {
        // Arrange
        var success = FakeConverter.Builder.Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(success);

        // Act
        _ = converter.Convert<string>(data);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IConverter.Convert));
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>("converter.type", typeof(string).FullName));
    }

    [Test]
    public void ConvertAs_WhenExceptionIsThrown_LogsError()
    {
        // Arrange
        var message = "A message";
        var failure = FakeConverter.Builder
            .WriteThrows(new Exception(message))
            .Build();
        var data = string.Empty;
        var (converter, collector) = GetSut(failure);

        // Act
        var actual = () => converter.Convert<string>(data);

        // Assert
        actual.Should().Throw<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    private static (TracedConverter converter, CollectorTracer tracer) GetSut(IConverter @delegate)
    {
        var tracer = new DefaultTracer(new TracerIdentity("TracedConverter", null));
        var collector = new CollectorTracer(tracer);
        var converter = new TracedConverter(@delegate, collector);

        return (converter, collector);
    }
}
