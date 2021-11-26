namespace Myprysm.Converter.NewtonsoftJson;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions;
using Myprysm.Tracing.Abstractions;
using Newtonsoft.Json;

public static class DependencyInjection
{
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
            .RegisterTracerOnStartup(ConverterNewtonsoftJsonConstants.TracerIdentity)
            .AddSingleton<NewtonsoftJsonConverter>()
            .AddSingleton(sp => sp.CreateConverter<NewtonsoftJsonConverterOptions>(
                ConverterNewtonsoftJsonConstants.TracerIdentity,
                p => p.GetRequiredService<NewtonsoftJsonConverter>()));
    }

    public static IServiceCollection AddNewtonsoftJsonConverter(this IServiceCollection services) =>
        services.AddNewtonsoftJsonConverter(_ => { });

    public static IServiceCollection AddNewtonsoftJsonConverter(
        this IServiceCollection services,
        Action<JsonSerializerSettings> configure) =>
        services.AddNewtonsoftJsonConverter(options => configure(options.JsonSerializerSettings));

    public static IServiceCollection AddNewtonsoftJsonConverter(
        this IServiceCollection services,
        IConfiguration configurationSection,
        Action<JsonSerializerSettings>? configureJson = null) =>
        services.AddNewtonsoftJsonConverter(configurationSection.Bind, configureJson);
}
