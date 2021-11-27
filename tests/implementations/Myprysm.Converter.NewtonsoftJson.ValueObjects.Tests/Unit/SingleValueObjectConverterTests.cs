namespace Myprysm.Converter.NewtonsoftJson.ValueObjects.Tests.Unit;

using System.IO;
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
}
