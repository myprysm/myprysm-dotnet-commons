#### [Myprysm.FileService.Abstractions](index.md 'index')
### Namespaces
<a name='Myprysm_FileService_Abstractions'></a>
## Myprysm.FileService.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [DependencyInjection](Myprysm_FileService_Abstractions_DependencyInjection.md 'Myprysm.FileService.Abstractions.DependencyInjection') | Dependency injection extensions<br/> |
| [FileDownload](Myprysm_FileService_Abstractions_FileDownload.md 'Myprysm.FileService.Abstractions.FileDownload') | A [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') file downloaded from an [IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService').<br/> |
| [FileServiceHealthCheck](Myprysm_FileService_Abstractions_FileServiceHealthCheck.md 'Myprysm.FileService.Abstractions.FileServiceHealthCheck') | File service [Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck') to ensure a [IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService') instance can work appropriately.<br/> |
| [FileServiceOptions](Myprysm_FileService_Abstractions_FileServiceOptions.md 'Myprysm.FileService.Abstractions.FileServiceOptions') | Base file service options.<br/><br/>You should extend those options and use the dependency injection extensions if you want to enable tracing<br/> |

| Interfaces | |
| :--- | :--- |
| [IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService') | Handle file uploads and downloads in a given container.<br/> |
  
<a name='Myprysm_FileService_Abstractions_Exceptions'></a>
## Myprysm.FileService.Abstractions.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [FileAlreadyExistsException](Myprysm_FileService_Abstractions_Exceptions_FileAlreadyExistsException.md 'Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException') | Exception thrown when a file already exists at the requested location in an [IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService').<br/> |
| [FileNotFoundException](Myprysm_FileService_Abstractions_Exceptions_FileNotFoundException.md 'Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException') | Exception thrown when a file cannot be found at the requested location in an [IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService').<br/> |
  
<a name='Myprysm_FileService_Abstractions_ValueObjects'></a>
## Myprysm.FileService.Abstractions.ValueObjects Namespace

| Classes | |
| :--- | :--- |
| [ETag](Myprysm_FileService_Abstractions_ValueObjects_ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag') | An ETag used for cache control.<br/> |
  
