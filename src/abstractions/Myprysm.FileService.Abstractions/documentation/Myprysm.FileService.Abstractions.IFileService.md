#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions](index.md#Myprysm.FileService.Abstractions 'Myprysm.FileService.Abstractions')

## IFileService Interface

Handle file uploads and downloads in a given container.

```csharp
public interface IFileService
```
### Methods

<a name='Myprysm.FileService.Abstractions.IFileService.CreateContainer(string,System.Threading.CancellationToken)'></a>

## IFileService.CreateContainer(string, CancellationToken) Method

Create a new storage container if it does not exist already.

```csharp
System.Threading.Tasks.Task CreateContainer(string container, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.IFileService.CreateContainer(string,System.Threading.CancellationToken).container'></a>

`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The storage container.

<a name='Myprysm.FileService.Abstractions.IFileService.CreateContainer(string,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
When the container is created.

<a name='Myprysm.FileService.Abstractions.IFileService.DownloadFile(string,string,System.Threading.CancellationToken)'></a>

## IFileService.DownloadFile(string, string, CancellationToken) Method

Download the file in the given container at the given path.

```csharp
System.Threading.Tasks.Task<Myprysm.FileService.Abstractions.FileDownload> DownloadFile(string container, string path, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.IFileService.DownloadFile(string,string,System.Threading.CancellationToken).container'></a>

`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The storage container.

<a name='Myprysm.FileService.Abstractions.IFileService.DownloadFile(string,string,System.Threading.CancellationToken).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the file to download.

<a name='Myprysm.FileService.Abstractions.IFileService.DownloadFile(string,string,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[FileDownload](Myprysm.FileService.Abstractions.FileDownload.md 'Myprysm.FileService.Abstractions.FileDownload')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The [FileDownload](Myprysm.FileService.Abstractions.FileDownload.md 'Myprysm.FileService.Abstractions.FileDownload').

#### Exceptions

[Myprysm.SharedKernel.Exceptions.NotFoundException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.NotFoundException 'Myprysm.SharedKernel.Exceptions.NotFoundException')  
When the requested path cannot be found in the container.

<a name='Myprysm.FileService.Abstractions.IFileService.RemoveContainer(string,System.Threading.CancellationToken)'></a>

## IFileService.RemoveContainer(string, CancellationToken) Method

Remove an existing storage container if it exists.

```csharp
System.Threading.Tasks.Task RemoveContainer(string container, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.IFileService.RemoveContainer(string,System.Threading.CancellationToken).container'></a>

`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The storage container.

<a name='Myprysm.FileService.Abstractions.IFileService.RemoveContainer(string,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
When the container is removed.

<a name='Myprysm.FileService.Abstractions.IFileService.RemoveFile(string,string,System.Threading.CancellationToken)'></a>

## IFileService.RemoveFile(string, string, CancellationToken) Method

Remove the file in the given container at the given path.

```csharp
System.Threading.Tasks.Task RemoveFile(string container, string path, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.IFileService.RemoveFile(string,string,System.Threading.CancellationToken).container'></a>

`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The storage container.

<a name='Myprysm.FileService.Abstractions.IFileService.RemoveFile(string,string,System.Threading.CancellationToken).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the file to remove.

<a name='Myprysm.FileService.Abstractions.IFileService.RemoveFile(string,string,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
When the file is deleted (even if it did not exist).

<a name='Myprysm.FileService.Abstractions.IFileService.UploadFile(string,string,System.IO.Stream,string,long,bool,System.Threading.CancellationToken)'></a>

## IFileService.UploadFile(string, string, Stream, string, long, bool, CancellationToken) Method

Upload the file in the given container at the given path.

```csharp
System.Threading.Tasks.Task UploadFile(string container, string path, System.IO.Stream content, string contentType, long contentLength, bool overwriteExistingFile=false, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.IFileService.UploadFile(string,string,System.IO.Stream,string,long,bool,System.Threading.CancellationToken).container'></a>

`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The storage container.

<a name='Myprysm.FileService.Abstractions.IFileService.UploadFile(string,string,System.IO.Stream,string,long,bool,System.Threading.CancellationToken).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path to store the file in the container.

<a name='Myprysm.FileService.Abstractions.IFileService.UploadFile(string,string,System.IO.Stream,string,long,bool,System.Threading.CancellationToken).content'></a>

`content` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The file stream.

<a name='Myprysm.FileService.Abstractions.IFileService.UploadFile(string,string,System.IO.Stream,string,long,bool,System.Threading.CancellationToken).contentType'></a>

`contentType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The content type of the file.

<a name='Myprysm.FileService.Abstractions.IFileService.UploadFile(string,string,System.IO.Stream,string,long,bool,System.Threading.CancellationToken).contentLength'></a>

`contentLength` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The size of the file.

<a name='Myprysm.FileService.Abstractions.IFileService.UploadFile(string,string,System.IO.Stream,string,long,bool,System.Threading.CancellationToken).overwriteExistingFile'></a>

`overwriteExistingFile` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates whether an exception should be thrown if a file already exists at the requested path in the container.

<a name='Myprysm.FileService.Abstractions.IFileService.UploadFile(string,string,System.IO.Stream,string,long,bool,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
Completes when the file is uploaded.

#### Exceptions

[FileAlreadyExistsException](Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException.md 'Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException')  
When a file already exists at the requested path in the container.