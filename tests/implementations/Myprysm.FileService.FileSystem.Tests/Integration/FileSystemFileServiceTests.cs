namespace Myprysm.FileService.FileSystem.Tests.Integration;

using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Tests.Integration;
using NUnit.Framework;

[TestFixture]
public class FileSystemFileServiceTests : FileServiceTests
{
    private string testDirectory = string.Empty;

    [OneTimeSetUp]
    public void GenerateTemporaryDirectory()
    {
        this.testDirectory = Path.Join(Path.GetTempPath(), Guid.NewGuid().ToString());
        Directory.CreateDirectory(this.testDirectory);
    }

    [OneTimeTearDown]
    public void DeleteTemporaryDirectory()
    {
        Directory.Delete(this.testDirectory, true);
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddFileSystemFileService(this.testDirectory);
    }
}
