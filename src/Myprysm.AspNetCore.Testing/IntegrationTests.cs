namespace Myprysm.AspNetCore.Testing;

using System.Reflection;
using AutoFixture;
using Microsoft.AspNetCore.Mvc.Testing;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

/// <summary>
/// Base integration test to remotely assert the behaviour of an API. 
/// </summary>
/// <typeparam name="TStartup">The entry point of the API under test.</typeparam>
[Category(Categories.Integration)]
public abstract class IntegrationTests<TStartup> : FixtureTests
    where TStartup : class
{
    /// <summary>
    /// The <see cref="HttpClient"/> configured to access the running API.
    /// </summary>
    protected HttpClient Client { get; private set; } = null!;

    /// <summary>
    /// The <see cref="IServiceProvider"/> of the running API.
    /// </summary>
    protected IServiceProvider Services { get; private set; } = null!;

    /// <summary>
    /// Configure the <see cref="Client"/> and <see cref="Services"/> for the current test suite.
    /// </summary>
    [OneTimeSetUp]
    public void SetUpApi()
    {
        var factory = this.CreateFactory();
        this.Client = factory.CreateClient();
        this.Services = factory.Services;
    }

    /// <summary>
    /// Factory method that should provide the <see cref="WebApplicationFactory{TEntryPoint}"/> for the API under test.
    /// You can provide the same factory to multiple test suites.
    /// </summary>
    /// <returns>The factory for the API under test.</returns>
    protected abstract WebApplicationFactory<TStartup> CreateFactory();

    /// <inheritdoc />
    protected override void CustomizeFixture(Fixture fixture)
    {
        fixture.LoadCustomizations(Assembly.GetExecutingAssembly());
    }
}
