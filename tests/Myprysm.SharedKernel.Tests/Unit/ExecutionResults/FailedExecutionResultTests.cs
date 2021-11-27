namespace Myprysm.SharedKernel.Tests.Unit.ExecutionResults;

using FluentAssertions;
using Myprysm.SharedKernel.ExecutionResults;
using Myprysm.SharedKernel.Extensions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

public class FailedExecutionResultTests : FixtureTests
{
    [Test]
    public void EmptyFailedResultIsAlwaysTheSame()
    {
        // Arrange
        var result1 = ExecutionResult.Failed();
        var result2 = ExecutionResult.Failed();

        // Assert
        result1.Should().Be(result2);
    }

    [Test]
    public void FailedResultIsNotSuccess()
    {
        // Assert
        ExecutionResult.Failed().IsSuccess.Should().BeFalse();
    }

    [Test]
    public void ToStringEmptyFailedResult()
    {
        // Assert
        ExecutionResult.Failed().ToString().Should().Be(FailedExecutionResult.DefaultMessage);
    }

    [Test]
    public void FailedResultContainsErrors()
    {
        // Arrange
        var errors = new[] { this.A<string>(), this.A<string>(), };

        // Act
        var result = ExecutionResult.Failed(errors);

        // Assert
        result.As<FailedExecutionResult>().Errors.Should().BeEquivalentTo(errors);
    }

    [Test]
    public void ToStringFailedResult()
    {
        // Arrange
        var errors = new[] { this.A<string>(), this.A<string>(), };

        // Act
        var result = ExecutionResult.Failed(errors);

        // Assert
        var expected = FailedExecutionResult.MessageTemplate.Fmt(string.Join(", ", errors));
        result.ToString().Should().Be(expected);
    }
}
