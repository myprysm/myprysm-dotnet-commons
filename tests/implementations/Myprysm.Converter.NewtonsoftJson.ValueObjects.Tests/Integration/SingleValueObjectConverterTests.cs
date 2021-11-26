namespace Myprysm.Converter.NewtonsoftJson.ValueObjects.Tests.Integration;

using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions;
using Myprysm.SharedKernel.ValueObjects;
using Myprysm.Testing;
using Newtonsoft.Json;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Integration)]
public class SingleValueObjectConverterTests : ServiceTests
{
    private IConverter Converter => this.Services.GetRequiredService<IConverter>();

    public enum MagicEnum
    {
        Two = 2,
        Zero = 0,
        Three = 3,
        One = 1,
    }

    public class IntSingleValue : SingleValueObject<int>
    {
        public IntSingleValue(int value) : base(value)
        {
        }
    }

    public class WithNullableIntSingleValue
    {
        public IntSingleValue I { get; }

        public WithNullableIntSingleValue(
            IntSingleValue i)
        {
            this.I = i;
        }
    }

    [OneTimeSetUp]
    public void SetUpNewtonsoftConfiguration()
    {
        JsonConvert.DefaultSettings = () => Json.DefaultSettings;
    }

    [Test]
    public void DeserializeNullableIntWithoutValue()
    {
        // Arrange
        var json = this.Converter.WriteString(new { });

        // Act
        var with = JsonConvert.DeserializeObject<WithNullableIntSingleValue>(json);

        // Assert
        with.Should().NotBeNull();
        with!.I.Should().BeNull();
    }

    [Test]
    public void DeserializeNullableIntWithNullValue()
    {
        // Arrange
        var json = "{\"i\":null}";

        // Act
        var with = JsonConvert.DeserializeObject<WithNullableIntSingleValue>(json);

        // Assert
        with.Should().NotBeNull();
        with!.I.Should().BeNull();
    }

    [Test]
    public void DeserializeNullableIntWithValue()
    {
        // Arrange
        var i = this.A<int>();
        var json = this.Converter.WriteString(new { i, });

        // Act
        var with = JsonConvert.DeserializeObject<WithNullableIntSingleValue>(json);

        // Assert
        with.Should().NotBeNull();
        with!.I.Value.Should().Be(i);
    }

    [Test]
    public void SerializeNullableIntWithoutValue()
    {
        // Arrange
        var with = new WithNullableIntSingleValue(null!);

        // Act
        var json = this.Converter.WriteString(with);

        // Assert
        json.Should().Be("{}");
    }

    [Test]
    public void SerializeNullableIntWithValue()
    {
        // Arrange
        var with = new WithNullableIntSingleValue(new IntSingleValue(42));

        // Act
        var json = this.Converter.WriteString(with);

        // Assert
        json.Should().Be("{\"i\":42}");
    }

    [TestCase("test  test", "\"test  test\"")]
    [TestCase("42", "\"42\"")]
    [TestCase("", "\"\"")]
    [TestCase(null, "null")]
    public void StringSerialization(string value, string expectedJson)
    {
        // Arrange
        var stringSvo = new StringSvo(value);

        // Act
        var json = this.Converter.WriteString(stringSvo);

        // Assert
        json.Should().Be(expectedJson);
    }

    [Test]
    public void StringDeserializationEmptyShouldResultInNull()
    {
        // Act
        var stringSvo = JsonConvert.DeserializeObject<StringSvo>(string.Empty);

        // Assert
        stringSvo.Should().BeNull();
    }

    [TestCase("\"\"", "")]
    [TestCase("\"test\"", "test")]
    public void StringDeserialization(string json, string expectedValue)
    {
        // Act
        var stringSvo = JsonConvert.DeserializeObject<StringSvo>(json);

        // Assert
        stringSvo!.Value.Should().Be(expectedValue);
    }

    [TestCase(0, "0")]
    [TestCase(42, "42")]
    [TestCase(-1, "-1")]
    public void IntSerialization(int value, string expectedJson)
    {
        // Arrange
        var intSvo = new IntSvo(value);

        // Act
        var json = this.Converter.WriteString(intSvo);

        // Assert
        json.Should().Be(expectedJson);
    }

    [TestCase("0", 0)]
    [TestCase("42", 42)]
    [TestCase("-1", -1)]
    public void IntDeserialization(string json, int expectedValue)
    {
        // Act
        var intSvo = JsonConvert.DeserializeObject<IntSvo>(json);

        // Assert
        intSvo!.Value.Should().Be(expectedValue);
    }

    [TestCase("\"One\"", MagicEnum.One)]
    [TestCase("1", MagicEnum.One)]
    [TestCase("2", MagicEnum.Two)]
    public void EnumDeserialization(string json, MagicEnum expectedValue)
    {
        // Act
        var intSvo = JsonConvert.DeserializeObject<EnumSvo>(json);

        // Assert
        intSvo!.Value.Should().Be(expectedValue);
    }

    [TestCase(MagicEnum.Zero, "0")]
    [TestCase(MagicEnum.One, "1")]
    [TestCase(MagicEnum.Two, "2")]
    [TestCase(MagicEnum.Three, "3")]
    public void EnumSerialization(int value, string expectedJson)
    {
        // Arrange
        var intSvo = new IntSvo(value);

        // Act
        var json = this.Converter.WriteString(intSvo);

        // Assert
        json.Should().Be(expectedJson);
    }

    public class StringSvo : SingleValueObject<string>
    {
        public StringSvo(string value) : base(value)
        {
        }
    }

    public class IntSvo : SingleValueObject<int>
    {
        public IntSvo(int value) : base(value)
        {
        }
    }

    public class EnumSvo : SingleValueObject<MagicEnum>
    {
        public EnumSvo(MagicEnum value) : base(value)
        {
        }
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddNewtonsoftJsonConverter(settings => { settings.ConfigureValueObjectConverters(); });
    }
}
