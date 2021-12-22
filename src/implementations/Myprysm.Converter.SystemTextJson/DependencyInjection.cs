namespace Myprysm.Converter.SystemTextJson;

using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds a SystemTextJson <see cref="IConverter"/>
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configureOptions">The options configuration action.</param>
    /// <param name="configureJson">The serializer options configuration.</param>
    /// <returns></returns>
    public static IServiceCollection AddSystemTextJsonConverter(
        this IServiceCollection services,
        Action<SystemTextJsonConverterOptions> configureOptions,
        Action<JsonSerializerOptions>? configureJson = null)
    {
        return services
            .Configure<SystemTextJsonConverterOptions>(options =>
            {
                configureOptions(options);
                configureJson?.Invoke(options.JsonSerializerSettings);
            })
            .TryAddDefaultTracer()
            .RegisterTracerOnStartup(SystemTextJsonConverterConstants.TracerIdentity)
            .AddSingleton<SystemTextJsonConverter>()
            .AddSingleton(sp => sp.CreateConverter<SystemTextJsonConverterOptions>(
                SystemTextJsonConverterConstants.TracerIdentity,
                p => p.GetRequiredService<SystemTextJsonConverter>()));
    }

    /// <summary>
    /// Adds a SystemTextJson <see cref="IConverter"/> with default settings.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddSystemTextJsonConverter(this IServiceCollection services) =>
        services.AddSystemTextJsonConverter(_ => { });

    /// <summary>
    /// Adds a SystemTextJson <see cref="IConverter"/> and customize the <see cref="JsonSerializerOptions"/>.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configure">The <see cref="JsonSerializerOptions"/> configuration action.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddSystemTextJsonConverter(
        this IServiceCollection services,
        Action<JsonSerializerOptions> configure) =>
        services.AddSystemTextJsonConverter(options => configure(options.JsonSerializerSettings));

    /// <summary>
    /// Adds a SystemTextJson <see cref="IConverter"/> with the provided configuration section
    /// and customize the <see cref="JsonSerializerOptions"/>.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configurationSection">The configuration section.</param>
    /// <param name="configureJson">The <see cref="JsonSerializerOptions"/> configuration action.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddSystemTextJsonConverter(
        this IServiceCollection services,
        IConfiguration configurationSection,
        Action<JsonSerializerOptions>? configureJson = null) =>
        services.AddSystemTextJsonConverter(configurationSection.Bind, configureJson);
}
