namespace Myprysm.SharedKernel.Tests.Unit.ExecutionResults;

using FluentAssertions;
using Myprysm.SharedKernel.ExecutionResults;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

internal class OtherSuccessResult : ExecutionResult
{
    public override bool IsSuccess => true;
}

[TestFixture]
[Category(Categories.Unit)]
public class ExecutionResultTests : FixtureTests
{
    [Test]
    public void ToStringExecutionResult()
    {
        // Arrange
        var result = new OtherSuccessResult();

        // Assert
        result.ToString().Should().Be($"ExecutionResult - IsSuccess:{result.IsSuccess}");
    }
}
