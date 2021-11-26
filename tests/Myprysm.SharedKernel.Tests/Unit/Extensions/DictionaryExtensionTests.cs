namespace Myprysm.SharedKernel.Tests.Unit.Extensions;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using FluentAssertions;
using Myprysm.SharedKernel.Extensions;
using Myprysm.Testing;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Integration)]
public class DictionaryExtensionTests
{
    [Test]
    public void ShouldReturnValue_WhenValueAlreadyExists()
    {
        // Arrange
        var subject = new Dictionary<string, string>
        {
            ["foo"] = "bar",
        };

        // Assert
        subject.GetOrAdd("foo", "baz").Should().Be("bar");
    }

    [Test]
    public void ShouldAddValue_WhenValueIsAbsent()
    {
        // Arrange
        var subject = new Dictionary<string, string>();

        // Assert
        subject.GetOrAdd("foo", "baz").Should().Be("baz");
    }

    [Test]
    public void ShouldCallFactoryWithKey_WhenValueIsAbsent()
    {
        // Arrange
        var subject = new Dictionary<string, string>();
        var counter = 0;

        // Act
        var value = subject.GetOrAdd(
            "foo",
            () =>
            {
                counter = 1;
                return "baz";
            });

        // Assert
        value.Should().Be("baz");
        counter.Should().Be(1);
    }

    [Test]
    public void ShouldNotCallFactory_WhenValueIsPresent()
    {
        // Arrange
        var subject = new Dictionary<string, string>
        {
            ["foo"] = "bar",
        };
        var counter = 0;

        // Act
        var value = subject.GetOrAdd(
            "foo",
            [ExcludeFromCodeCoverage]() =>
            {
                counter = 1;
                return "baz";
            });

        // Assert
        value.Should().Be("bar");
        counter.Should().Be(0);
    }
}
