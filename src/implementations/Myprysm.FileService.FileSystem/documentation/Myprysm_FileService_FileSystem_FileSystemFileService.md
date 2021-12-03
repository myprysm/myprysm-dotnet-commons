#### [Myprysm.FileService.FileSystem](index.md 'index')
### [Myprysm.FileService.FileSystem](index.md#Myprysm_FileService_FileSystem 'Myprysm.FileService.FileSystem')
## FileSystemFileService Class
An [Myprysm.FileService.Abstractions.IFileService](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.IFileService 'Myprysm.FileService.Abstractions.IFileService') implementation that manages files in a local directory.  
```csharp
public class FileSystemFileService :
Myprysm.FileService.Abstractions.IFileService
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FileSystemFileService  

Implements [Myprysm.FileService.Abstractions.IFileService](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.IFileService 'Myprysm.FileService.Abstractions.IFileService')  
### Constructors
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_FileSystemFileService(Microsoft_Extensions_Options_IOptions_Myprysm_FileService_FileSystem_FileSystemFileServiceOptions_)'></a>
## FileSystemFileService.FileSystemFileService(IOptions&lt;FileSystemFileServiceOptions&gt;) Constructor
Creates a new [FileSystemFileService](Myprysm_FileService_FileSystem_FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService') with the given options.  
```csharp
public FileSystemFileService(Microsoft.Extensions.Options.IOptions<Myprysm.FileService.FileSystem.FileSystemFileServiceOptions> options);
```
#### Parameters
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_FileSystemFileService(Microsoft_Extensions_Options_IOptions_Myprysm_FileService_FileSystem_FileSystemFileServiceOptions_)_options'></a>
`options` [Microsoft.Extensions.Options.IOptions&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Options.IOptions-1 'Microsoft.Extensions.Options.IOptions`1')[FileSystemFileServiceOptions](Myprysm_FileService_FileSystem_FileSystemFileServiceOptions.md 'Myprysm.FileService.FileSystem.FileSystemFileServiceOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Options.IOptions-1 'Microsoft.Extensions.Options.IOptions`1')  
The options for the file service.
  
  
### Methods
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_CreateContainer(string_System_Threading_CancellationToken)'></a>
## FileSystemFileService.CreateContainer(string, CancellationToken) Method
Create a new storage container if it does not exist already.  
```csharp
public System.Threading.Tasks.Task CreateContainer(string container, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_CreateContainer(string_System_Threading_CancellationToken)_container'></a>
`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The storage container.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_CreateContainer(string_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
When the container is created.

Implements [CreateContainer(string, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.IFileService.CreateContainer#Myprysm_FileService_Abstractions_IFileService_CreateContainer_System_String,System_Threading_CancellationToken_ 'Myprysm.FileService.Abstractions.IFileService.CreateContainer(System.String,System.Threading.CancellationToken)')  
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_DownloadFile(string_string_System_Threading_CancellationToken)'></a>
## FileSystemFileService.DownloadFile(string, string, CancellationToken) Method
Download the file in the given container at the given path.  
```csharp
public System.Threading.Tasks.Task<Myprysm.FileService.Abstractions.FileDownload> DownloadFile(string container, string path, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_DownloadFile(string_string_System_Threading_CancellationToken)_container'></a>
`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The storage container.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_DownloadFile(string_string_System_Threading_CancellationToken)_path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path of the file to download.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_DownloadFile(string_string_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Myprysm.FileService.Abstractions.FileDownload](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.FileDownload 'Myprysm.FileService.Abstractions.FileDownload')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The [Myprysm.FileService.Abstractions.FileDownload](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.FileDownload 'Myprysm.FileService.Abstractions.FileDownload').
#### Exceptions
[Myprysm.SharedKernel.Exceptions.NotFoundException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.NotFoundException 'Myprysm.SharedKernel.Exceptions.NotFoundException')  
When the requested path cannot be found in the container.

Implements [DownloadFile(string, string, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.IFileService.DownloadFile#Myprysm_FileService_Abstractions_IFileService_DownloadFile_System_String,System_String,System_Threading_CancellationToken_ 'Myprysm.FileService.Abstractions.IFileService.DownloadFile(System.String,System.String,System.Threading.CancellationToken)')  
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_RemoveContainer(string_System_Threading_CancellationToken)'></a>
## FileSystemFileService.RemoveContainer(string, CancellationToken) Method
Remove an existing storage container if it exists.  
```csharp
public System.Threading.Tasks.Task RemoveContainer(string container, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_RemoveContainer(string_System_Threading_CancellationToken)_container'></a>
`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The storage container.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_RemoveContainer(string_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
When the container is removed.

Implements [RemoveContainer(string, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.IFileService.RemoveContainer#Myprysm_FileService_Abstractions_IFileService_RemoveContainer_System_String,System_Threading_CancellationToken_ 'Myprysm.FileService.Abstractions.IFileService.RemoveContainer(System.String,System.Threading.CancellationToken)')  
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_RemoveFile(string_string_System_Threading_CancellationToken)'></a>
## FileSystemFileService.RemoveFile(string, string, CancellationToken) Method
Remove the file in the given container at the given path.  
```csharp
public System.Threading.Tasks.Task RemoveFile(string container, string path, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_RemoveFile(string_string_System_Threading_CancellationToken)_container'></a>
`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The storage container.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_RemoveFile(string_string_System_Threading_CancellationToken)_path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path of the file to remove.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_RemoveFile(string_string_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
When the file is deleted (even if it did not exist).

Implements [RemoveFile(string, string, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.IFileService.RemoveFile#Myprysm_FileService_Abstractions_IFileService_RemoveFile_System_String,System_String,System_Threading_CancellationToken_ 'Myprysm.FileService.Abstractions.IFileService.RemoveFile(System.String,System.String,System.Threading.CancellationToken)')  
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_UploadFile(string_string_System_IO_Stream_string_long_bool_System_Threading_CancellationToken)'></a>
## FileSystemFileService.UploadFile(string, string, Stream, string, long, bool, CancellationToken) Method
Upload the file in the given container at the given path.  
```csharp
public System.Threading.Tasks.Task UploadFile(string container, string path, System.IO.Stream content, string contentType, long contentLength, bool overwriteExistingFile=false, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_UploadFile(string_string_System_IO_Stream_string_long_bool_System_Threading_CancellationToken)_container'></a>
`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The storage container.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_UploadFile(string_string_System_IO_Stream_string_long_bool_System_Threading_CancellationToken)_path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The path to store the file in the container.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_UploadFile(string_string_System_IO_Stream_string_long_bool_System_Threading_CancellationToken)_content'></a>
`content` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')  
The file stream.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_UploadFile(string_string_System_IO_Stream_string_long_bool_System_Threading_CancellationToken)_contentType'></a>
`contentType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The content type of the file.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_UploadFile(string_string_System_IO_Stream_string_long_bool_System_Threading_CancellationToken)_contentLength'></a>
`contentLength` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The size of the file.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_UploadFile(string_string_System_IO_Stream_string_long_bool_System_Threading_CancellationToken)_overwriteExistingFile'></a>
`overwriteExistingFile` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Indicates whether an exception should be thrown if a file already exists at the requested path in the container.
  
<a name='Myprysm_FileService_FileSystem_FileSystemFileService_UploadFile(string_string_System_IO_Stream_string_long_bool_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
Completes when the file is uploaded.
#### Exceptions
[Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException 'Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException')  
When a file already exists at the requested path in the container.

Implements [UploadFile(string, string, Stream, string, long, bool, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.IFileService.UploadFile#Myprysm_FileService_Abstractions_IFileService_UploadFile_System_String,System_String,System_IO_Stream,System_String,System_Int64,System_Boolean,System_Threading_CancellationToken_ 'Myprysm.FileService.Abstractions.IFileService.UploadFile(System.String,System.String,System.IO.Stream,System.String,System.Int64,System.Boolean,System.Threading.CancellationToken)')  
  
