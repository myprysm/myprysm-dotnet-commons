namespace Myprysm.FileService.Minio;

public class MinioFileServiceOptions
{
    public bool WithSsl { get; set; }

    public string Endpoint { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;

    public string AccessKey { get; set; } = string.Empty;

    public string SecretKey { get; set; } = string.Empty;
}
