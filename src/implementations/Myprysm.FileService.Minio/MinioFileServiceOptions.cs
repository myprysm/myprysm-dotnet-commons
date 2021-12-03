namespace Myprysm.FileService.Minio;

using Myprysm.FileService.Abstractions;

/// <summary>
/// <see cref="MinioFileService"/> options to manage files with a remote MinIO/S3 instance.
/// </summary>
public class MinioFileServiceOptions : FileServiceOptions
{
    /// <summary>
    /// Enables SSL/TLS with the remote MinIO/S3 instance.
    /// </summary>
    public bool WithSsl { get; set; }

    /// <summary>
    /// Gets or sets the remote MinIO/S3 endpoint.
    /// </summary>
    public string Endpoint { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the remote MinIO/S3 region.
    /// </summary>
    public string Region { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the remote MinIO/S3 access key.
    /// </summary>
    public string AccessKey { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the remote MinIO/S3 secret key.
    /// </summary>
    public string SecretKey { get; set; } = string.Empty;
}
