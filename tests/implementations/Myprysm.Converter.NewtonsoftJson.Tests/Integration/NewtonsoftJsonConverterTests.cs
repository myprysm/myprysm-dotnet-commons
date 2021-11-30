namespace Myprysm.Converter.NewtonsoftJson.Tests.Integration;

using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions.Testing.Integration;
using Myprysm.Converter.NewtonsoftJson;
using NUnit.Framework;

[TestFixture]
public class NewtonsoftJsonConverterTests : ConverterTests
{
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddNewtonsoftJsonConverter(_ => { });
    }

    protected override byte[] GetInvalidData()
    {
        return Encoding.UTF8.GetBytes("I am invalid json");
    }
}
