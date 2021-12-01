#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions.Exceptions](index.md#Myprysm_FileService_Abstractions_Exceptions 'Myprysm.FileService.Abstractions.Exceptions')
## FileNotFoundException Class
Exception thrown when a file cannot be found at the requested location in an [IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService').  
```csharp
public class FileNotFoundException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [Myprysm.SharedKernel.Exceptions.ManagedException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.ManagedException 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; FileNotFoundException  
### Constructors
<a name='Myprysm_FileService_Abstractions_Exceptions_FileNotFoundException_FileNotFoundException(string_string)'></a>
## FileNotFoundException.FileNotFoundException(string, string) Constructor
Creates an instance of [FileNotFoundException](Myprysm_FileService_Abstractions_Exceptions_FileNotFoundException.md 'Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException').  
```csharp
public FileNotFoundException(string container, string path);
```
#### Parameters
<a name='Myprysm_FileService_Abstractions_Exceptions_FileNotFoundException_FileNotFoundException(string_string)_container'></a>
`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The container in which the existence check happened.
  
<a name='Myprysm_FileService_Abstractions_Exceptions_FileNotFoundException_FileNotFoundException(string_string)_path'></a>
`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The conflicting path.
  
  
