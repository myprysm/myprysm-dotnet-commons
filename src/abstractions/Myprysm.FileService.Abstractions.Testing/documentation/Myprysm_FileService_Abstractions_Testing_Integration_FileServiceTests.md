#### [Myprysm.FileService.Abstractions.Testing](index.md 'index')
### [Myprysm.FileService.Abstractions.Testing.Integration](index.md#Myprysm_FileService_Abstractions_Testing_Integration 'Myprysm.FileService.Abstractions.Testing.Integration')
## FileServiceTests Class
Base test suite for [Myprysm.FileService.Abstractions.IFileService](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.IFileService 'Myprysm.FileService.Abstractions.IFileService').  
```csharp
public abstract class FileServiceTests : Myprysm.Testing.NUnit.ServiceTests
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Testing.NUnit.FixtureTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.FixtureTests 'Myprysm.Testing.NUnit.FixtureTests') &#129106; [Myprysm.Testing.NUnit.ServiceTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.ServiceTests 'Myprysm.Testing.NUnit.ServiceTests') &#129106; FileServiceTests  
### Methods
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_CreateContainer_AcceptsContent()'></a>
## FileServiceTests.CreateContainer_AcceptsContent() Method
You should ensure that given a container  
When a file is uploaded to this container at a random path  
And the file is downloaded from this container at this random path  
Then the downloaded content is the same as the uploaded content.  
```csharp
public System.Threading.Tasks.Task CreateContainer_AcceptsContent();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_DownloadFile_WhenFileDoesNotExist_ThrowsFileNotFoundException()'></a>
## FileServiceTests.DownloadFile_WhenFileDoesNotExist_ThrowsFileNotFoundException() Method
You should ensure that given a container  
When a non existing file is downloaded  
Then the operation results in a [Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException 'Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException').  
```csharp
public System.Threading.Tasks.Task DownloadFile_WhenFileDoesNotExist_ThrowsFileNotFoundException();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_RemoveContainer_WhenContainerContainsFiles_Succeeds()'></a>
## FileServiceTests.RemoveContainer_WhenContainerContainsFiles_Succeeds() Method
You should ensure that given a container  
When a file is uploaded to this container at a random path  
And the container is deleted  
And the file is downloaded from this container at this random path  
Then the operation results in a [Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException 'Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException').  
```csharp
public System.Threading.Tasks.Task RemoveContainer_WhenContainerContainsFiles_Succeeds();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_RemoveFile_WhenFileDoesNotExist_Succeeds()'></a>
## FileServiceTests.RemoveFile_WhenFileDoesNotExist_Succeeds() Method
You should ensure that given a container  
When a non existing file is deleted  
Then the operation should succeed.  
```csharp
public System.Threading.Tasks.Task RemoveFile_WhenFileDoesNotExist_Succeeds();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_RemoveFile_WhenFileExists_Succeeds()'></a>
## FileServiceTests.RemoveFile_WhenFileExists_Succeeds() Method
You should ensure that given a container  
When a file is uploaded to this container at a random path  
And the file is deleted  
And the file is downloaded from this container at this random path  
Then the operation results in a [Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException 'Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException').  
```csharp
public System.Threading.Tasks.Task RemoveFile_WhenFileExists_Succeeds();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_ResetContent()'></a>
## FileServiceTests.ResetContent() Method
Resets the position of the content used in the tests.  
```csharp
public void ResetContent();
```
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_UploadFile_WhenPathAlreadyExists_ThrowsFileAlreadyExistsException()'></a>
## FileServiceTests.UploadFile_WhenPathAlreadyExists_ThrowsFileAlreadyExistsException() Method
You should ensure that given a container  
When a file is uploaded to this container at a random path  
And another file is uploaded at this random path with the overwrite option disabled  
Then the operation results in a [Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException 'Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException').  
```csharp
public System.Threading.Tasks.Task UploadFile_WhenPathAlreadyExists_ThrowsFileAlreadyExistsException();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_UploadFile_WhenPathAlreadyExistsAndOverrideIsAllowed_Succeeds()'></a>
## FileServiceTests.UploadFile_WhenPathAlreadyExistsAndOverrideIsAllowed_Succeeds() Method
You should ensure that given a container  
When a file is uploaded to this container at a random path  
And another file is uploaded at this random path with the overwrite option enabled  
And the file is downloaded from this container at this random path  
Then the downloaded content is the same as the overwriting content.  
```csharp
public System.Threading.Tasks.Task UploadFile_WhenPathAlreadyExistsAndOverrideIsAllowed_Succeeds();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_UploadFile_WritesContent()'></a>
## FileServiceTests.UploadFile_WritesContent() Method
You should ensure that given a file at a random path  
When this file is uploaded to this random path  
And the file is downloaded from this container at this random path  
Then the downloaded content is the same as the uploaded content.  
```csharp
public System.Threading.Tasks.Task UploadFile_WritesContent();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
### Remarks
The container may or may not exist yet. The operation should succeed either way.
  
<a name='Myprysm_FileService_Abstractions_Testing_Integration_FileServiceTests_UploadFileAtRoot_WritesContent()'></a>
## FileServiceTests.UploadFileAtRoot_WritesContent() Method
You should ensure that given a container  
When this file is uploaded to the root of this container  
And the file is downloaded from the root of this container  
Then the downloaded content is the same as the uploaded content.  
```csharp
public System.Threading.Tasks.Task UploadFileAtRoot_WritesContent();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
### Remarks
The container may or may not exist yet. The operation should succeed either way.
  
