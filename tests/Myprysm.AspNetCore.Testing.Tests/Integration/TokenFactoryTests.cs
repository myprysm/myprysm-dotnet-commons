namespace Myprysm.AspNetCore.Testing.Tests.Integration;

using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

[TestFixture]
public class TokenFactoryTests : IntegrationTests<Program>
{
    protected override WebApplicationFactory<Program> CreateFactory()
    {
        return TestApiSetup.Factory;
    }

    [Test]
    public async Task GenerateToken_TokenWithoutScope_ShouldAuthenticateDefaultResource()
    {
        // Arrange
        var token = MockJwtTokens.GenerateJwtToken(new Claim("sub", "A user"));
        this.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        // Act
        var response = await this.Client.GetAsync("authorized");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var content = await response.Content.ReadFromJsonAsync<Response>();

        content.Should().NotBeNull();
        content!.Answer.Should().Be(42);
    }

    [Test]
    public async Task GenerateToken_TokenWithoutScope_ShouldAuthenticateAnonymousResource()
    {
        // Arrange
        var token = MockJwtTokens.GenerateJwtToken(new Claim("sub", "A user"));
        this.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        // Act
        var response = await this.Client.GetAsync("anonymous");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var content = await response.Content.ReadFromJsonAsync<Response>();

        content.Should().NotBeNull();
        content!.Answer.Should().Be(3);
    }

    [Test]
    public async Task GenerateToken_TokenWithoutScope_ShouldRejectScopedResource()
    {
        // Arrange
        var token = MockJwtTokens.GenerateJwtToken(new Claim("sub", "A user"));
        this.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        // Act
        var response = await this.Client.GetAsync("authorized/scoped");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Test]
    public async Task GenerateToken_TokenWithScope_ShouldAuthenticateDefaultResource()
    {
        // Arrange
        var token = MockJwtTokens.GenerateJwtToken(
            new Claim("sub", "A user"),
            new Claim("scope", "custom:claim"));
        this.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        // Act
        var response = await this.Client.GetAsync("authorized");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var content = await response.Content.ReadFromJsonAsync<Response>();

        content.Should().NotBeNull();
        content!.Answer.Should().Be(42);
    }

    [Test]
    public async Task GenerateToken_TokenWithScope_ShouldAuthenticateScopedResource()
    {
        // Arrange
        var token = MockJwtTokens.GenerateJwtToken(
            new Claim("sub", "A user"),
            new Claim("scope", "custom:claim"));
        this.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        // Act
        var response = await this.Client.GetAsync("authorized/scoped");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var content = await response.Content.ReadFromJsonAsync<Response>();

        content.Should().NotBeNull();
        content!.Answer.Should().Be(69);
    }

    [Test]
    public async Task GenerateToken_TokenWithScope_ShouldAuthenticateAnonymousResource()
    {
        // Arrange
        var token = MockJwtTokens.GenerateJwtToken(
            new Claim("sub", "A user"),
            new Claim("scope", "custom:claim"));
        this.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        // Act
        var response = await this.Client.GetAsync("anonymous");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var content = await response.Content.ReadFromJsonAsync<Response>();

        content.Should().NotBeNull();
        content!.Answer.Should().Be(3);
    }
}
