namespace Myprysm.Converter.NewtownsoftJson.Tests.Integration;

using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.NewtonsoftJson;
using Myprysm.Converter.Tests.Integration;
using NUnit.Framework;

[TestFixture]
public class NewtownsoftJsonConverterTests : ConverterTests
{
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddNewtonsoftJsonConverter(options => options.WithTracing = true, _ => { });
    }

    protected override byte[] GetInvalidData()
    {
        return Encoding.UTF8.GetBytes("I am invalid json");
    }
}
