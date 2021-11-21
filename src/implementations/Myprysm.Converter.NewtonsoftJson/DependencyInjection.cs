namespace Myprysm.Converter.NewtonsoftJson;

using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions;
using Newtonsoft.Json;

public static class DependencyInjection
{
    public static IServiceCollection AddNewtonsoftJsonConverter(this IServiceCollection services)
    {
        return services.AddNewtonsoftJsonConverter(_ => { });
    }

    public static IServiceCollection AddNewtonsoftJsonConverter(
        this IServiceCollection services,
        Action<JsonSerializerSettings> configure)
    {
        var settings = Json.DefaultSettings;

        configure(settings);

        var converter = new JsonConverter(settings);

        return services
            .AddSingleton(converter)
            .AddSingleton<IConverter>(converter);
    }
}
