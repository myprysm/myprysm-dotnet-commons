#### [Myprysm.FileService.AzureStorageBlob](index.md 'index')
### [Myprysm.FileService.AzureStorageBlob](index.md#Myprysm_FileService_AzureStorageBlob 'Myprysm.FileService.AzureStorageBlob')
## AzureStorageBlobFileServiceOptions Class
[AzureStorageBlobFileService](Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService') options to manage files with an Azure Storage account.  
            
```csharp
public class AzureStorageBlobFileServiceOptions : Myprysm.FileService.Abstractions.FileServiceOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.FileService.Abstractions.FileServiceOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.FileServiceOptions 'Myprysm.FileService.Abstractions.FileServiceOptions') &#129106; AzureStorageBlobFileServiceOptions  
### Properties
<a name='Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileServiceOptions_ConnectionString'></a>
## AzureStorageBlobFileServiceOptions.ConnectionString Property
Gets or sets the connection string to the Azure Storage account.  
```csharp
public string ConnectionString { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Remarks
Defaults to the development storage.  
  
