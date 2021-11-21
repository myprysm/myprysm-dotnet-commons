namespace Myprysm.Converter.Tests.Integration;

using System.Diagnostics.CodeAnalysis;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions;
using Myprysm.Testing;
using NUnit.Framework;

[Category(Categories.Integration)]
public abstract class ConverterTests : ServiceTests
{
    private IConverter Converter => this.Services.GetRequiredService<IConverter>();

    [Test]
    public void CanReadByteArray_FromConverterWriteBytes()
    {
        // Arrange
        var shape = this.A<Shape>();
        var serializedShape = this.Converter.WriteBytes(shape);

        // Act
        var actualShape = this.Converter.Read<Shape>(serializedShape);

        // Assert
        actualShape.Should().BeEquivalentTo(shape);
    }

    [Test]
    public void CanReadByteArray_FromConverterWriteStream()
    {
        // Arrange
        var shape = this.A<Shape>();
        using var stream = new MemoryStream();
        this.Converter.WriteToStream(shape, stream);
        stream.Position = 0;

        // Act
        var actualShape = this.Converter.Read<Shape>(stream);

        // Assert
        actualShape.Should().BeEquivalentTo(shape);
    }

    [Test]
    public void CanReadString_FromConverterWriteString()
    {
        // Arrange
        var shape = this.A<Shape>();
        var serializedShape = this.Converter.WriteString(shape);

        // Act
        var actualShape = this.Converter.Read<Shape>(serializedShape);

        // Assert
        actualShape.Should().BeEquivalentTo(shape);
    }

    [Test]
    public void Convert_ConvertsToAnotherObjectOfTheSameShape()
    {
        // Arrange
        var shape = this.A<Shape>();

        // Act
        var actual = this.Converter.Convert<SimilarShape>(shape);

        // Assert
        actual.Should().BeEquivalentTo(shape);
    }

    [Test]
    public void Convert_WhenShapesDontMatch_ReturnsObjectWithEmptyProperties()
    {
        // Arrange
        var shape = this.A<Shape>();

        // Act
        var actual = this.Converter.Convert<NotShape>(shape);

        // Assert
        actual.Should().NotBeNull();
        actual!.A.Should().BeNull();
        actual.B.Should().BeNull();
        actual.Name.Should().Be(shape.Name);
    }

    private class Shape
    {
        public int? X { get; set; }

        public int? Y { get; set; }

        public string? Name { get; set; }
    }

    private class SimilarShape
    {
        public int? X { get; set; }

        public int? Y { get; set; }

        public string? Name { get; set; }
    }

    private class NotShape
    {
        [ExcludeFromCodeCoverage]
        public int? A { get; set; }

        [ExcludeFromCodeCoverage]
        public int? B { get; set; }

        [ExcludeFromCodeCoverage]
        public string? Name { get; set; }
    }
}
