namespace Myprysm.AspNetCore.Testing.Tests.Integration;

using System.Threading.Tasks;
using NUnit.Framework;

[SetUpFixture]
public class TestApiSetup
{
    public static TestFactory Factory { get; private set; } = null!;

    [OneTimeSetUp]
    public void CreateApi()
    {
        Factory = new TestFactory();
    }

    [OneTimeTearDown]
    public async Task TearDownApi()
    {
        await Factory.DisposeAsync();
    }
}
