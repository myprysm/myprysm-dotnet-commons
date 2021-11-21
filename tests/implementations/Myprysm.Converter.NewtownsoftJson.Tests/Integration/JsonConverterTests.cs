namespace Myprysm.Converter.NewtownsoftJson.Tests.Integration;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.NewtonsoftJson;
using Myprysm.Converter.Tests.Integration;
using NUnit.Framework;

[TestFixture]
public class JsonConverterTests : ConverterTests
{
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddNewtonsoftJsonConverter();
    }
}
