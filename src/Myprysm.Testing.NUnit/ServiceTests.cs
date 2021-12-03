namespace Myprysm.Testing.NUnit;

using global::NUnit.Framework;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

/// <summary>
/// Base class that provides dependency injection and fixture support.
/// </summary>
[Category(Categories.Integration)]
public abstract class ServiceTests : FixtureTests
{
    /// <summary>
    /// The services available for the test.
    /// </summary>
    /// <remarks>
    /// A provider is created for each test.
    /// </remarks>
    protected IServiceProvider Services { get; private set; } = null!;

    /// <summary>
    /// Create the service provider used in each test.
    /// </summary>
    [SetUp]
    public void SetUpDependencyInjection()
    {
        var configurationBuilder = new ConfigurationBuilder();

        this.Configure(configurationBuilder);

        var configuration = configurationBuilder.Build();
        var services = new ServiceCollection()
            .AddLogging()
            .AddSingleton<ILoggerFactory, NullLoggerFactory>()
            .AddScoped<IConfiguration>(_ => configuration);

        this.ConfigureServices(services, configuration);

        this.Services = services.BuildServiceProvider();
    }

    /// <summary>
    /// Implement this method to add configuration to the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <param name="configuration">The configuration to augment.</param>
    protected virtual void Configure(ConfigurationBuilder configuration)
    {
        // Do nothing.
    }

    /// <summary>
    /// Configure the subject under test and its dependencies for each test.
    /// </summary>
    /// <param name="services">The service collection to configure the SUT and its dependencies.</param>
    /// <param name="configuration">The configuration for the test.</param>
    protected abstract void ConfigureServices(IServiceCollection services, IConfiguration configuration);


    /// <summary>
    /// Dispose the <see cref="IServiceProvider"/> use in the test.
    /// </summary>
    [TearDown]
    public void TearDownDependencyInjection()
    {
        this.BeforeDisposeServices();
        ((ServiceProvider)this.Services).Dispose();
    }

    /// <summary>
    /// Run some additional code right before the <see cref="IServiceProvider"/> is disposed for the test.
    /// </summary>
    protected virtual void BeforeDisposeServices()
    {
        // Do nothing.
    }
}
