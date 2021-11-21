namespace Myprysm.FileService.Abstractions;

using System.Text;
using Microsoft.Extensions.Diagnostics.HealthChecks;

public class FileServiceHealthCheck : IHealthCheck
{
    private readonly IFileService fileService;
    private readonly string container;

    public FileServiceHealthCheck(IFileService fileService, string container)
    {
        this.fileService = fileService;
        this.container = container;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken cancellationToken = new())
    {
        var ping = await this.Ping(cancellationToken).ConfigureAwait(false);

        return ping ? HealthCheckResult.Healthy() : HealthCheckResult.Unhealthy();
    }

    private async Task<bool> Ping(CancellationToken cancellation)
    {
        var path = $"health-check/{Guid.NewGuid()}";
        try
        {
            await using (var content = new MemoryStream(Encoding.UTF8.GetBytes("1")))
            {
                await this.fileService.CreateContainer(this.container, cancellation).ConfigureAwait(false);
                await this.fileService.UploadFile(this.container, path, content, "text/plain", 1, cancellation: cancellation).ConfigureAwait(false);
            }

            var download = await this.fileService.DownloadFile(this.container, path, cancellation).ConfigureAwait(false);
            download.Dispose();
            await this.fileService.RemoveFile(this.container, path, cancellation).ConfigureAwait(false);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}