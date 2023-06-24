namespace Myprysm.SharedKernel.Tests.Unit.ExecutionResults;

using FluentAssertions;
using Myprysm.SharedKernel.ExecutionResults;
using Myprysm.SharedKernel.Extensions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

public class NotFoundExecutionResultTests : FixtureTests
{
    [Test]
    public void EmptyNotFoundResultIsAlwaysTheSame()
    {
        // Arrange
        var result1 = ExecutionResult.NotFound();
        var result2 = ExecutionResult.NotFound();

        // Assert
        result1.Should().Be(result2);
    }

    [Test]
    public void NotFoundResultIsNotSuccess()
    {
        // Assert
        ExecutionResult.NotFound().IsSuccess.Should().BeFalse();
    }

    [Test]
    public void ToStringEmptyNotFoundResult()
    {
        // Assert
        ExecutionResult.NotFound().ToString().Should().Be(NotFoundExecutionResult.DefaultMessage);
    }

    [Test]
    public void NotFoundResultContainsErrors()
    {
        // Arrange
        var errors = new[] { this.A<string>(), this.A<string>(), };

        // Act
        var result = ExecutionResult.NotFound(errors);

        // Assert
        result.As<NotFoundExecutionResult>().Errors.Should().BeEquivalentTo(errors);
    }

    [Test]
    public void ToStringNotFoundResult()
    {
        // Arrange
        var errors = new[] { this.A<string>(), this.A<string>(), };

        // Act
        var result = ExecutionResult.NotFound(errors);

        // Assert
        var expected = NotFoundExecutionResult.MessageTemplate.Fmt(string.Join(", ", errors));
        result.ToString().Should().Be(expected);
    }
}
