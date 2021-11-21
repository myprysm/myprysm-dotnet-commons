namespace Myprysm.SharedKernel.Tests.Unit.Extensions;

using System.Collections.ObjectModel;
using FluentAssertions;
using Myprysm.SharedKernel.Extensions;
using Myprysm.Testing;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class CollectionExtensionsTests : FixtureTests
{
    [Test]
    public void AddRange()
    {
        // Arrange
        var subject = new Collection<string>();
        var addition = new[] { "A", "B", "C", };

        // Act
        subject.AddRange(addition);

        // Assert
        subject.Should().BeEquivalentTo("A", "B", "C");
    }

    [Test]
    public void RemoveRange()
    {
        // Arrange
        var subject = new Collection<string> { "A", "B", "C", };
        var removal = new[] { "A", "B", };

        // Act
        subject.RemoveRange(removal);

        // Assert
        subject.Should().BeEquivalentTo("C");
    }
}
