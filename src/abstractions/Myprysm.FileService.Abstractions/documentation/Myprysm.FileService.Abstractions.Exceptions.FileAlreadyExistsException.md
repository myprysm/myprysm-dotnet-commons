#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions.Exceptions](index.md#Myprysm.FileService.Abstractions.Exceptions 'Myprysm.FileService.Abstractions.Exceptions')

## FileAlreadyExistsException Class

Exception thrown when a file already exists at the requested location in an [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService').

```csharp
public class FileAlreadyExistsException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [Myprysm.SharedKernel.Exceptions.ManagedException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.ManagedException 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; FileAlreadyExistsException
### Constructors

<a name='Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException.FileAlreadyExistsException(string,string)'></a>

## FileAlreadyExistsException(string, string) Constructor

Creates an instance of [FileAlreadyExistsException](Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException.md 'Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException').

```csharp
public FileAlreadyExistsException(string container, string path);
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException.FileAlreadyExistsException(string,string).container'></a>

`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The container in which the existence check happened.

<a name='Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException.FileAlreadyExistsException(string,string).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The conflicting path.