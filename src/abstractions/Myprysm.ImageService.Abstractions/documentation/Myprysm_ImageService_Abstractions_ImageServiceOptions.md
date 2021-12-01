#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions](index.md#Myprysm_ImageService_Abstractions 'Myprysm.ImageService.Abstractions')
## ImageServiceOptions Class
Base image service options.  
  
You should extend those options and use the dependency injection extensions if you want to enable tracing  
```csharp
public class ImageServiceOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ImageServiceOptions  
### Properties
<a name='Myprysm_ImageService_Abstractions_ImageServiceOptions_WithTracing'></a>
## ImageServiceOptions.WithTracing Property
Enable tracing with the image service implementation.  
```csharp
public bool WithTracing { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Remarks
Tracing is enabled by default.
  
