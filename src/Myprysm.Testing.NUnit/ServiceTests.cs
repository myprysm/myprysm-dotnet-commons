namespace Myprysm.Testing.NUnit;

using global::NUnit.Framework;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

[Category(Categories.Integration)]
public abstract class ServiceTests : FixtureTests
{
    protected IServiceProvider Services { get; private set; } = null!;

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

    protected virtual void Configure(ConfigurationBuilder configuration)
    {
        // Do nothing.
    }

    protected abstract void ConfigureServices(IServiceCollection services, IConfiguration configuration);


    [TearDown]
    public void TearDownDependencyInjection()
    {
        this.BeforeDisposeServices();
        ((ServiceProvider)this.Services).Dispose();
    }

    protected virtual void BeforeDisposeServices()
    {
        // Do nothing.
    }
}
