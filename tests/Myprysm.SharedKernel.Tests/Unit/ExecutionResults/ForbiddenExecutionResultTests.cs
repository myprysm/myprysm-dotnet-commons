namespace Myprysm.SharedKernel.Tests.Unit.ExecutionResults;

using FluentAssertions;
using Myprysm.SharedKernel.ExecutionResults;
using Myprysm.SharedKernel.Extensions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

public class ForbiddenExecutionResultTests : FixtureTests
{
    [Test]
    public void EmptyForbiddenResultIsAlwaysTheSame()
    {
        // Arrange
        var result1 = ExecutionResult.Forbidden();
        var result2 = ExecutionResult.Forbidden();

        // Assert
        result1.Should().Be(result2);
    }

    [Test]
    public void ForbiddenResultIsNotSuccess()
    {
        // Assert
        ExecutionResult.Forbidden().IsSuccess.Should().BeFalse();
    }

    [Test]
    public void ToStringEmptyForbiddenResult()
    {
        // Assert
        ExecutionResult.Forbidden().ToString().Should().Be(ForbiddenExecutionResult.DefaultMessage);
    }

    [Test]
    public void ForbiddenResultContainsErrors()
    {
        // Arrange
        var errors = new[] { this.A<string>(), this.A<string>(), };

        // Act
        var result = ExecutionResult.Forbidden(errors);

        // Assert
        result.As<ForbiddenExecutionResult>().Errors.Should().BeEquivalentTo(errors);
    }

    [Test]
    public void ToStringForbiddenResult()
    {
        // Arrange
        var errors = new[] { this.A<string>(), this.A<string>(), };

        // Act
        var result = ExecutionResult.Forbidden(errors);

        // Assert
        var expected = ForbiddenExecutionResult.MessageTemplate.Fmt(string.Join(", ", errors));
        result.ToString().Should().Be(expected);
    }
}
