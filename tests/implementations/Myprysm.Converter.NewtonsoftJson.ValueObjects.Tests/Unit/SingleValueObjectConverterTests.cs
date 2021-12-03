namespace Myprysm.Converter.NewtonsoftJson.ValueObjects.Tests.Unit;

using System.Diagnostics.CodeAnalysis;
using System.IO;
using FluentAssertions;
using Myprysm.SharedKernel.ValueObjects;
using Myprysm.Testing.NUnit;
using Newtonsoft.Json;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class SingleValueObjectConverterTests
{
    [Test]
    public void WriteJsonDoesNothingWhenValueIsNotSingleValueObject()
    {
        // Arrange
        var converter = new SingleValueObjectConverter();

        // Assert
        converter.WriteJson(new JsonTextWriter(TextWriter.Null), null, new JsonSerializer());
    }

    [Test]
    public void ReadJsonReturnsNullWhenContentIsNull()
    {
        // Arrange
        var converter = new SingleValueObjectConverter();

        // Assert
        converter
            .ReadJson(new JsonTextReader(TextReader.Null), typeof(StringSVO), null, new JsonSerializer())
            .Should()
            .BeNull();
    }
}

[ExcludeFromCodeCoverage]
internal class StringSVO : SingleValueObject<string>
{
    public StringSVO(string value) : base(value)
    {
    }
}
