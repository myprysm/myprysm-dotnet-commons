#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions](index.md#Myprysm_FileService_Abstractions 'Myprysm.FileService.Abstractions')
## DependencyInjection Class
Dependency injection extensions  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_FileService_Abstractions_DependencyInjection_CreateFileService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_FileService_Abstractions_IFileService_)'></a>
## DependencyInjection.CreateFileService&lt;TOptions&gt;(IServiceProvider, TracerIdentity, Func&lt;IServiceProvider,IFileService&gt;) Method
Create a file service with optional tracing.  
```csharp
public static Myprysm.FileService.Abstractions.IFileService CreateFileService<TOptions>(this System.IServiceProvider provider, Myprysm.Tracing.Abstractions.TracerIdentity identity, System.Func<System.IServiceProvider,Myprysm.FileService.Abstractions.IFileService> factory)
    where TOptions : Myprysm.FileService.Abstractions.FileServiceOptions;
```
#### Type parameters
<a name='Myprysm_FileService_Abstractions_DependencyInjection_CreateFileService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_FileService_Abstractions_IFileService_)_TOptions'></a>
`TOptions`  
The specialized type of [FileServiceOptions](Myprysm_FileService_Abstractions_FileServiceOptions.md 'Myprysm.FileService.Abstractions.FileServiceOptions').
  
#### Parameters
<a name='Myprysm_FileService_Abstractions_DependencyInjection_CreateFileService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_FileService_Abstractions_IFileService_)_provider'></a>
`provider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')  
The service provider.
  
<a name='Myprysm_FileService_Abstractions_DependencyInjection_CreateFileService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_FileService_Abstractions_IFileService_)_identity'></a>
`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')  
The tracer identity (usually for the implementation library).
  
<a name='Myprysm_FileService_Abstractions_DependencyInjection_CreateFileService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_FileService_Abstractions_IFileService_)_factory'></a>
`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The file service factory.
  
#### Returns
[IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService')  
The file service, optionally decorated with tracing.
  
