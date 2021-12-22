namespace Myprysm.Converter.SystemTextJson.Tests.Integration;

using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions.Testing.Integration;
using NUnit.Framework;

[TestFixture]
public class SystemTextJsonConverterTests : ConverterTests
{
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddSystemTextJsonConverter(_ => { });
    }

    protected override byte[] GetInvalidData()
    {
        return Encoding.UTF8.GetBytes("I am invalid json");
    }
}
