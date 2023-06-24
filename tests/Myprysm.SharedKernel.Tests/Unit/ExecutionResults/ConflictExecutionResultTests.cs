namespace Myprysm.SharedKernel.Tests.Unit.ExecutionResults;

using FluentAssertions;
using Myprysm.SharedKernel.ExecutionResults;
using Myprysm.SharedKernel.Extensions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

public class ConflictExecutionResultTests : FixtureTests
{
    [Test]
    public void EmptyConflictResultIsAlwaysTheSame()
    {
        // Arrange
        var result1 = ExecutionResult.Conflict();
        var result2 = ExecutionResult.Conflict();

        // Assert
        result1.Should().Be(result2);
    }

    [Test]
    public void ConflictResultIsNotSuccess()
    {
        // Assert
        ExecutionResult.Conflict().IsSuccess.Should().BeFalse();
    }

    [Test]
    public void ToStringEmptyConflictResult()
    {
        // Assert
        ExecutionResult.Conflict().ToString().Should().Be(ConflictExecutionResult.DefaultMessage);
    }

    [Test]
    public void ConflictResultContainsErrors()
    {
        // Arrange
        var errors = new[] { this.A<string>(), this.A<string>(), };

        // Act
        var result = ExecutionResult.Conflict(errors);

        // Assert
        result.As<ConflictExecutionResult>().Errors.Should().BeEquivalentTo(errors);
    }

    [Test]
    public void ToStringConflictResult()
    {
        // Arrange
        var errors = new[] { this.A<string>(), this.A<string>(), };

        // Act
        var result = ExecutionResult.Conflict(errors);

        // Assert
        var expected = ConflictExecutionResult.MessageTemplate.Fmt(string.Join(", ", errors));
        result.ToString().Should().Be(expected);
    }
}
