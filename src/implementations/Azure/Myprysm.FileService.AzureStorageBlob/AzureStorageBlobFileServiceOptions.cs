namespace Myprysm.FileService.AzureStorageBlob;

using Myprysm.FileService.Abstractions;

public class AzureStorageBlobFileServiceOptions : FileServiceOptions
{
    public string ConnectionString { get; set; } = "UseDevelopmentStorage=true";
}
