namespace Myprysm.AspNetCore.Testing.Tests.Integration;

using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.AspNetCore.Testing.TestApi;
using NUnit.Framework;

[TestFixture]
public class IntegrationTestsTests : IntegrationTests<Program>
{
    protected override WebApplicationFactory<Program> CreateFactory()
    {
        return TestApiSetup.Factory;
    }

    [Test]
    public void Services_ProvideApiServices()
    {
        // Arrange + Act
        var response = this.Services.GetRequiredService<Response>();

        // Assert
        response.Answer.Should().Be(1);
    }
}
