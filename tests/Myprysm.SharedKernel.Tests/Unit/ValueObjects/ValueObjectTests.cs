namespace Myprysm.SharedKernel.Tests.Unit.ValueObjects;

using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Myprysm.SharedKernel.ValueObjects;
using Myprysm.Testing;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class ValueObjectTests : FixtureTests
{
    public class StringObject : ValueObject
    {
        public string? StringValue { get; set; }
    }

    private class ListObject : ValueObject
    {
        private List<StringObject> StringValues { get; }

        public ListObject(params string[] strings)
        {
            this.StringValues = strings.Select(s => new StringObject { StringValue = s, }).ToList();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return this.StringValues;
        }
    }

    [Test]
    public void SameStringObjectsAreEqual()
    {
        // Arrange
        var str = this.A<string>();
        var stringObject1 = new StringObject { StringValue = str, };
        var stringObject2 = new StringObject { StringValue = str, };

        // Assert
        stringObject1.GetHashCode().Should().Be(stringObject2.GetHashCode());
        stringObject1.Equals(stringObject2).Should().BeTrue();
        (stringObject1 == stringObject2).Should().BeTrue();
    }

    [Test]
    public void ValueObjectToString()
    {
        // Arrange
        var str = this.A<string>();
        var stringObject = new StringObject { StringValue = str, };

        // Assert
        stringObject.ToString().Should().Be($"{{StringValue: {str}}}");
    }

    [Test]
    public void DifferentStringObjectsAreNotEqual()
    {
        // Arrange
        var stringObject1 = new StringObject { StringValue = this.A<string>(), };
        var stringObject2 = new StringObject { StringValue = this.A<string>(), };

        // Assert
        stringObject1.GetHashCode().Should().NotBe(stringObject2.GetHashCode());
        stringObject1.Equals(stringObject2).Should().BeFalse();
        (stringObject1 == stringObject2).Should().BeFalse();
    }

    [Test]
    public void SameListObjectsAreEqual()
    {
        // Arrange
        var values = this.Many<string>().ToArray();
        var listObject1 = new ListObject(values);
        var listObject2 = new ListObject(values);

        // Assert
        listObject1.GetHashCode().Should().Be(listObject2.GetHashCode(), "hash code");
        listObject1.Equals(listObject2).Should().BeTrue("Equals");
        (listObject1 == listObject2).Should().BeTrue("==");
    }

    [Test]
    public void DifferentListObjectsAreNotEqual()
    {
        // Arrange
        var listObject1 = new ListObject(this.Many<string>().ToArray());
        var listObject2 = new ListObject(this.Many<string>().ToArray());

        // Assert
        listObject1.GetHashCode().Should().NotBe(listObject2.GetHashCode(), "hash code");
        listObject1.Equals(listObject2).Should().BeFalse("Equals");
        (listObject1 == listObject2).Should().BeFalse("==");
    }

    [Test]
    public void EqualsDifferentTypes()
    {
        // Arrange
        var obj1 = new StringObject { StringValue = this.A<string>(), };
        var obj2 = new ListObject(this.Many<string>().ToArray());

        // Assert
        obj1.Equals(obj2).Should().BeFalse();
    }

    [Test]
    public void EqualsSameObject()
    {
        // Arrange
        var obj = new StringObject { StringValue = this.A<string>(), };

        // Assert
        obj.Equals(obj).Should().BeTrue();
    }
}
