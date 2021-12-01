#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions](index.md#Myprysm_FileService_Abstractions 'Myprysm.FileService.Abstractions')
## FileServiceOptions Class
Base file service options.  
  
You should extend those options and use the dependency injection extensions if you want to enable tracing  
```csharp
public class FileServiceOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FileServiceOptions  
### Properties
<a name='Myprysm_FileService_Abstractions_FileServiceOptions_WithTracing'></a>
## FileServiceOptions.WithTracing Property
Enable tracing with the file service implementation.  
```csharp
public bool WithTracing { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Remarks
Tracing is enabled by default.
  
