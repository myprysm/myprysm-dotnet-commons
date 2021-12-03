namespace Myprysm.FileService.AzureStorageBlob;

using Myprysm.FileService.Abstractions;

/// <summary>
/// <see cref="AzureStorageBlobFileService"/> options to manage files with an Azure Storage account.
/// </summary>
public class AzureStorageBlobFileServiceOptions : FileServiceOptions
{
    /// <summary>
    /// Gets or sets the connection string to the Azure Storage account.
    /// </summary>
    /// <remarks>
    /// Defaults to the development storage.
    /// </remarks>
    public string ConnectionString { get; set; } = "UseDevelopmentStorage=true";
}
