namespace Myprysm.SharedKernel.Tests.Unit.ExecutionResults;

using FluentAssertions;
using Myprysm.SharedKernel.ExecutionResults;
using Myprysm.SharedKernel.Extensions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class SuccessExecutionResultTests : FixtureTests
{
    [Test]
    public void EmptySuccessResultIsAlwaysTheSame()
    {
        // Arrange
        var result1 = ExecutionResult.Success();
        var result2 = ExecutionResult.Success();

        // Assert
        result1.Should().Be(result2);
    }

    [Test]
    public void SuccessResultIsSuccess()
    {
        // Assert
        ExecutionResult.Success().IsSuccess.Should().BeTrue();
    }

    [Test]
    public void ToStringEmptySuccessResult()
    {
        // Assert
        ExecutionResult.Success().ToString().Should().Be(SuccessExecutionResult.DefaultMessage);
    }

    [Test]
    public void SuccessResultContainsErrors()
    {
        // Arrange
        var data = this.A<string>();

        // Act
        var result = ExecutionResult.Success(data);

        // Assert
        result.As<ObjectSuccessExecutionResult<string>>().Result.Should().Be(data);
    }

    [Test]
    public void ToStringSuccessResult()
    {
        // Arrange
        var data = this.A<string>();

        // Act
        var result = ExecutionResult.Success(data);

        // Assert
        var expected = ObjectSuccessExecutionResult<string>.MessageTemplate.Fmt(data);
        result.ToString().Should().Be(expected);
    }
}
