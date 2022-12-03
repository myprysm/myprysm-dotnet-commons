#### [Myprysm.FileService.FileSystem](index.md 'index')
### [Myprysm.FileService.FileSystem](index.md#Myprysm.FileService.FileSystem 'Myprysm.FileService.FileSystem')

## FileSystemFileServiceOptions Class

Options for a [FileSystemFileService](Myprysm.FileService.FileSystem.FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService').

```csharp
public class FileSystemFileServiceOptions : Myprysm.FileService.Abstractions.FileServiceOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.FileService.Abstractions.FileServiceOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.FileServiceOptions 'Myprysm.FileService.Abstractions.FileServiceOptions') &#129106; FileSystemFileServiceOptions
### Properties

<a name='Myprysm.FileService.FileSystem.FileSystemFileServiceOptions.Directory'></a>

## FileSystemFileServiceOptions.Directory Property

The local directory to manage the files. Defaults to the temporary directory.

```csharp
public string Directory { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')