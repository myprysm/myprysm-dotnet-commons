namespace Myprysm.Converter.NewtonsoftJson;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions;
using Myprysm.Tracing.Abstractions;
using Newtonsoft.Json;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds a NewtonsoftJson <see cref="IConverter"/>
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configureOptions">The options configuration action.</param>
    /// <param name="configureJson">The serializer options configuration.</param>
    /// <returns></returns>
    public static IServiceCollection AddNewtonsoftJsonConverter(
        this IServiceCollection services,
        Action<NewtonsoftJsonConverterOptions> configureOptions,
        Action<JsonSerializerSettings>? configureJson = null)
    {
        return services
            .Configure<NewtonsoftJsonConverterOptions>(options =>
            {
                configureOptions(options);
                configureJson?.Invoke(options.JsonSerializerSettings);
            })
            .TryAddDefaultTracer()
            .RegisterTracerOnStartup(NewtonsoftJsonConverterConstants.TracerIdentity)
            .AddSingleton<NewtonsoftJsonConverter>()
            .AddSingleton(sp => sp.CreateConverter<NewtonsoftJsonConverterOptions>(
                NewtonsoftJsonConverterConstants.TracerIdentity,
                p => p.GetRequiredService<NewtonsoftJsonConverter>()));
    }

    /// <summary>
    /// Adds a NewtonsoftJson <see cref="IConverter"/> with default settings.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddNewtonsoftJsonConverter(this IServiceCollection services) =>
        services.AddNewtonsoftJsonConverter(_ => { });

    /// <summary>
    /// Adds a NewtonsoftJson <see cref="IConverter"/> and customize the <see cref="JsonSerializerSettings"/>.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configure">The <see cref="JsonSerializerSettings"/> configuration action.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddNewtonsoftJsonConverter(
        this IServiceCollection services,
        Action<JsonSerializerSettings> configure) =>
        services.AddNewtonsoftJsonConverter(options => configure(options.JsonSerializerSettings));

    /// <summary>
    /// Adds a NewtonsoftJson <see cref="IConverter"/> with the provided configuration section
    /// and customize the <see cref="JsonSerializerSettings"/>.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configurationSection">The configuration section.</param>
    /// <param name="configureJson">The <see cref="JsonSerializerSettings"/> configuration action.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddNewtonsoftJsonConverter(
        this IServiceCollection services,
        IConfiguration configurationSection,
        Action<JsonSerializerSettings>? configureJson = null) =>
        services.AddNewtonsoftJsonConverter(configurationSection.Bind, configureJson);
}
