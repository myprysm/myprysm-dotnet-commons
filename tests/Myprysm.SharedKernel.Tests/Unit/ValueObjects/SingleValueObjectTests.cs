namespace Myprysm.SharedKernel.Tests.Unit.ValueObjects;

using System;
using System.Linq;
using FluentAssertions;
using Myprysm.SharedKernel.ValueObjects;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class SingleValueObjectTests : FixtureTests
{
    public class StringSingleValue : SingleValueObject<string>
    {
        public StringSingleValue(string value) : base(value)
        {
        }
    }

    public class IntSingleValue : SingleValueObject<int>
    {
        public IntSingleValue(int value) : base(value)
        {
        }
    }

    public enum MagicEnum
    {
        Two = 2,
        Zero = 0,
        Three = 3,
        One = 1,
    }

    public class MagicEnumSingleValue : SingleValueObject<MagicEnum>
    {
        public MagicEnumSingleValue(MagicEnum value) : base(value)
        {
        }
    }

    [Test]
    public void Ordering()
    {
        // Arrange
        var values = this.Many<string>(10);
        var orderedValues = values.OrderBy(s => s).ToList();
        values.Should().NotEqual(orderedValues); // Data test
        var singleValueObjects = values.Select(s => new StringSingleValue(s)).ToList();

        // Act
        var orderedSingleValueObjects = singleValueObjects.OrderBy(v => v).ToList();

        // Assert
        orderedSingleValueObjects.Select(v => v.Value)
            .Should()
            .BeEquivalentTo(
                orderedValues,
                o => o.WithStrictOrdering());
    }

    [Test]
    public void EnumOrdering()
    {
        // Arrange
        var values = this.Many<MagicEnum>(10);
        var orderedValues = values.OrderBy(s => s).ToList();
        values.Should().NotEqual(orderedValues); // Data test
        var singleValueObjects = values.Select(s => new MagicEnumSingleValue(s)).ToList();

        // Act
        var orderedSingleValueObjects = singleValueObjects.OrderBy(v => v).ToList();

        // Assert
        orderedSingleValueObjects.Select(v => v.Value)
            .Should()
            .BeEquivalentTo(
                orderedValues,
                o => o.WithStrictOrdering());
    }

    [Test]
    public void ProtectAgainstInvalidEnumValues()
    {
        // Act + Assert
        // ReSharper disable once ObjectCreationAsStatement
        var exception = Assert.Throws<ArgumentException>(() => new MagicEnumSingleValue((MagicEnum)42));
        exception!.Message.Should().Be("The value '42' isn't defined in enum 'MagicEnum'");
    }

    [Test]
    public void EnumOrderingManual()
    {
        // Arrange
        var values = new[]
        {
            new MagicEnumSingleValue(MagicEnum.Zero),
            new MagicEnumSingleValue(MagicEnum.Three),
            new MagicEnumSingleValue(MagicEnum.One),
            new MagicEnumSingleValue(MagicEnum.Two),
        };

        // Act
        var orderedValues = values
            .OrderBy(v => v)
            .Select(v => v.Value)
            .ToList();

        // Assert
        orderedValues.Should()
            .BeEquivalentTo(
                new[]
                {
                    MagicEnum.Zero,
                    MagicEnum.One,
                    MagicEnum.Two,
                    MagicEnum.Three,
                },
                o => o.WithStrictOrdering());
    }

    [Test]
    public void NullEquals()
    {
        // Arrange
        var obj = new StringSingleValue(this.A<string>());
        var @null = null as StringSingleValue;

        // Assert
        // ReSharper disable once ExpressionIsAlwaysNull
        obj.Equals(@null).Should().BeFalse();
    }

    [Test]
    public void EqualsForSameValues()
    {
        // Arrange
        var value = this.A<string>();
        var obj1 = new StringSingleValue(value);
        var obj2 = new StringSingleValue(value);

        // Assert
        (obj1 == obj2).Should().BeTrue();
        obj1.Equals(obj2).Should().BeTrue();
    }

    [Test]
    public void EqualsForDifferentValues()
    {
        // Arrange
        var value1 = this.A<string>();
        var value2 = this.A<string>();
        var obj1 = new StringSingleValue(value1);
        var obj2 = new StringSingleValue(value2);

        // Assert
        (obj1 == obj2).Should().BeFalse();
        obj1.Equals(obj2).Should().BeFalse();
    }

    [Test]
    public void ValueObjectToString()
    {
        // Arrange
        var value = this.A<string>();
        var obj = new StringSingleValue(value);

        // Assert
        obj.ToString().Should().Be(value);
    }

    [Test]
    public void CompareTo()
    {
        // Arrange
        var obj1 = new StringSingleValue("a");
        var obj2 = new StringSingleValue("b");

        // Assert
        obj1.CompareTo(obj2).Should().Be(-1);
    }

    [Test]
    public void CompareToNull()
    {
        // Arrange
        var value = this.A<string>();
        var obj = new StringSingleValue(value);

        // Act
        var action = () => obj.CompareTo(null);

        // Assert
        action.Should().Throw<ArgumentNullException>();
    }

    [Test]
    public void CompareToOtherType()
    {
        // Arrange
        var value1 = this.A<string>();
        var obj1 = new StringSingleValue(value1);
        var value2 = this.A<int>();
        var obj2 = new IntSingleValue(value2);

        // Act
        var action = () => obj1.CompareTo(obj2);

        // Assert
        action.Should().Throw<ArgumentException>();
    }
}
