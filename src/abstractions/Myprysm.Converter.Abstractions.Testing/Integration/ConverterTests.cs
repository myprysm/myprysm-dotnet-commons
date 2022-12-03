namespace Myprysm.Converter.Abstractions.Testing.Integration;

using System.Diagnostics.CodeAnalysis;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions.Exceptions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

/// <summary>
/// Base test suite for <see cref="IConverter"/>.
/// </summary>
[Category(Categories.Integration)]
public abstract class ConverterTests : ServiceTests
{
    private IConverter Converter => this.Services.GetRequiredService<IConverter>();

    /// <summary>
    /// Provide invalid data for the converter to validate the exceptions.
    /// </summary>
    /// <returns>A byte array representing invalid data.</returns>
    protected abstract byte[] GetInvalidData();

    /// <summary>
    /// You should ensure that given invalid data
    /// Then the converter throws a <see cref="ConversionReadException"/>.
    /// </summary>
    [Test]
    public void Read_WhenDataIsInvalid_ShouldThrow()
    {
        // Arrange
        var invalidData = this.GetInvalidData();

        // Act
        var act = () => this.Converter.Read<Shape>(invalidData);

        // Assert
        act.Should().Throw<ConversionReadException>();
    }

    /// <summary>
    /// You should ensure that given an already disposed stream
    /// Then the converter throws a <see cref="ConversionWriteException"/>.
    /// </summary>
    [Test]
    public void Write_WhenStreamIsDisposed_ShouldThrow()
    {
        // Arrange
        var shape = this.A<Shape>();
        var stream = new MemoryStream();
        stream.Dispose();

        // Act
        var act = () => this.Converter.WriteToStream(shape, stream);

        // Assert
        act.Should().Throw<ConversionWriteException>();
    }

    /// <summary>
    /// You should ensure that given a <see cref="ConverterTests.Shape"/>,
    /// When the <see cref="ConverterTests.Shape"/> is serialized to byte array
    /// And the byte array is read as a <see cref="ConverterTests.Shape"/>
    /// Then both shapes are equivalent.
    /// </summary>
    [Test]
    public void CanReadShape_FromConverterWriteBytes()
    {
        // Arrange
        var shape = this.A<Shape>();
        var serializedShape = this.Converter.WriteBytes(shape);

        // Act
        var actualShape = this.Converter.Read<Shape>(serializedShape);

        // Assert
        actualShape.Should().BeEquivalentTo(shape);
    }

    /// <summary>
    /// You should ensure that given a <see cref="ConverterTests.Shape"/>,
    /// When the <see cref="ConverterTests.Shape"/> is serialized to Stream
    /// And the Stream is read as a <see cref="ConverterTests.Shape"/>
    /// Then both shapes are equivalent.
    /// </summary>
    [Test]
    public void CanReadShape_FromConverterWriteStream()
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

    /// <summary>
    /// You should ensure that given a <see cref="ConverterTests.Shape"/>,
    /// When the <see cref="ConverterTests.Shape"/> is serialized to string
    /// And the string is read as a <see cref="ConverterTests.Shape"/>
    /// Then both shapes are equivalent.
    /// </summary>
    [Test]
    public void CanReadShape_FromConverterWriteString()
    {
        // Arrange
        var shape = this.A<Shape>();
        var serializedShape = this.Converter.WriteString(shape);

        // Act
        var actualShape = this.Converter.Read<Shape>(serializedShape);

        // Assert
        actualShape.Should().BeEquivalentTo(shape);
    }

    /// <summary>
    /// You should ensure that given a <see cref="ConverterTests.Shape"/>,
    /// When the <see cref="ConverterTests.Shape"/> is converted to <see cref="ConverterTests.SimilarShape"/>
    /// Then both shapes are equivalent.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a <see cref="ConverterTests.Shape"/>,
    /// When the <see cref="ConverterTests.Shape"/> is converted to <see cref="ConverterTests.NotShape"/>
    /// Then the conversion returns a <see cref="ConverterTests.NotShape"/>
    /// And the value of A is null
    /// And the value of B is null
    /// And the value of Name is the same as <see cref="Shape.Name"/>
    /// </summary>
    [Test]
    public void Convert_WhenShapesDontMatch_ButBothShapesAreObjects_ReturnsObjectWithEmptyProperties()
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

    /// <summary>
    /// You should ensure that given a <see cref="ConverterTests.Shape"/>,
    /// When the <see cref="ConverterTests.Shape"/> is converted to an <see cref="IEnumerable{T}"/>
    /// Then the conversion throws a <see cref="ConversionReadException"/>
    /// </summary>
    [Test]
    public void Convert_WhenSourceIsObject_AndTargetIsEnumerable_ShouldThrow()
    {
        // Arrange
        var shape = this.A<Shape>();

        // Act
        var actual = () => this.Converter.Convert<IEnumerable<Shape>>(shape);

        // Assert
        actual.Should().Throw<ConversionReadException>();
    }

    /// <summary>
    /// You should ensure that given a an <see cref="IEnumerable{T}"/>,
    /// When the <see cref="ConverterTests.Shape"/> is converted to <see cref="ConverterTests.Shape"/>
    /// Then the conversion throws a <see cref="ConversionReadException"/>
    /// </summary>
    [Test]
    public void Convert_WhenSourceIsEnumerable_AndTargetIsObject_ShouldThrow()
    {
        // Arrange
        var shape = this.A<Shape>();

        // Act
        var actual = () => this.Converter.Convert<IEnumerable<Shape>>(shape);

        // Assert
        actual.Should().Throw<ConversionReadException>();
    }

    /// <summary>
    /// You should ensure that given a primitive type,
    /// When the <see cref="ConverterTests.Shape"/> is converted to <see cref="ConverterTests.Shape"/>
    /// Then the conversion throws a <see cref="ConversionReadException"/>
    /// </summary>
    [Test]
    public void Convert_WhenSourceIsPrimitive_AndTargetIsObject_ShouldThrow()
    {
        // Arrange
        var value = this.A<string>();

        // Act
        var actual = () => this.Converter.Convert<IEnumerable<Shape>>(value);

        // Assert
        actual.Should().Throw<ConversionReadException>();
    }

    /// <summary>
    /// The base shape used in the test suite.
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// An optional X value.
        /// </summary>
        public int? X { get; set; }

        /// <summary>
        /// An optional Y value.
        /// </summary>
        public int? Y { get; set; }

        /// <summary>
        /// An optional Name value.
        /// </summary>
        public string? Name { get; set; }
    }

    /// <summary>
    /// A similar shape to the <see cref="ConverterTests.Shape"/> used in the test suite.
    /// </summary>
    public class SimilarShape
    {
        /// <summary>
        /// An optional X value.
        /// </summary>
        public int? X { get; set; }

        /// <summary>
        /// An optional Y value.
        /// </summary>
        public int? Y { get; set; }

        /// <summary>
        /// An optional Name value.
        /// </summary>
        public string? Name { get; set; }
    }

    /// <summary>
    /// A shape with some other properties than the <see cref="ConverterTests.Shape"/> used in the test suite.  
    /// </summary>
    public class NotShape
    {
        /// <summary>
        /// An optional A value.
        /// </summary>
        [ExcludeFromCodeCoverage]
        public int? A { get; set; }

        /// <summary>
        /// An optional B value.
        /// </summary>
        [ExcludeFromCodeCoverage]
        public int? B { get; set; }


        /// <summary>
        /// An optional Name value.
        /// </summary>
        [ExcludeFromCodeCoverage]
        public string? Name { get; set; }
    }
}
