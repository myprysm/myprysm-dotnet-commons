namespace Myprysm.SharedKernel.Tests.Unit.Exceptions;

using System.Collections.Generic;
using FluentAssertions;
using Myprysm.SharedKernel.Exceptions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class ValidationExceptionTests : FixtureTests
{
    [Test]
    public void With_CreatesException()
    {
        // Arrange
        var errors = this.A<Dictionary<string, IEnumerable<string>>>();

        // Act
        var exception = ValidationException.With(errors);

        // Assert
        exception.Errors.Should().BeEquivalentTo(errors);
    }

    [Test]
    public void For_CreatesExceptionWithSingleError()
    {
        // Arrange
        var field = this.A<string>();
        var error = this.A<string>();

        // Act
        var exception = ValidationException.For(field, error);

        // Assert
        var expected = new Dictionary<string, IEnumerable<string>>
        {
            [field] = new[] { error, },
        };
        exception.Errors.Should().BeEquivalentTo(expected);
    }

    [Test]
    public void WithMultipleErrors()
    {
        // Arrange
        var field1 = this.A<string>();
        var error1 = this.A<string>();
        var field2 = this.A<string>();
        var error2 = this.A<string>();

        // Act
        var exception = ValidationException
            .WithError(field1, error1)
            .WithError(field2, error2)
            .Build();

        // Assert
        var expected = new Dictionary<string, IEnumerable<string>>
        {
            [field1] = new[] { error1, },
            [field2] = new[] { error2, },
        };
        exception.Errors.Should().BeEquivalentTo(expected);
    }
}
