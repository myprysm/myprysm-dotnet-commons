namespace Myprysm.FileService.FileSystem.Tests.Integration;

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions.Testing.Integration;
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

    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string?>
        {
            [nameof(FileSystemFileServiceOptions.Directory)] = this.testDirectory,
        };

        configuration.AddInMemoryCollection(config);
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddFileSystemFileService(configuration);
    }
}
