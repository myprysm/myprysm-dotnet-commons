#### [Myprysm.FileService.Abstractions](index.md 'index')

## Myprysm.FileService.Abstractions Assembly
### Namespaces

<a name='Myprysm.FileService.Abstractions'></a>

## Myprysm.FileService.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [DependencyInjection](Myprysm.FileService.Abstractions.DependencyInjection.md 'Myprysm.FileService.Abstractions.DependencyInjection') | Dependency injection extensions |
| [FileDownload](Myprysm.FileService.Abstractions.FileDownload.md 'Myprysm.FileService.Abstractions.FileDownload') | A [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') file downloaded from an [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService'). |
| [FileServiceHealthCheck](Myprysm.FileService.Abstractions.FileServiceHealthCheck.md 'Myprysm.FileService.Abstractions.FileServiceHealthCheck') | File service [Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck') to ensure a [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService') instance can work appropriately. |
| [FileServiceOptions](Myprysm.FileService.Abstractions.FileServiceOptions.md 'Myprysm.FileService.Abstractions.FileServiceOptions') | Base file service options.<br/><br/>You should extend those options and use the dependency injection extensions if you want to enable tracing |

| Interfaces | |
| :--- | :--- |
| [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService') | Handle file uploads and downloads in a given container. |

<a name='Myprysm.FileService.Abstractions.Exceptions'></a>

## Myprysm.FileService.Abstractions.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [FileAlreadyExistsException](Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException.md 'Myprysm.FileService.Abstractions.Exceptions.FileAlreadyExistsException') | Exception thrown when a file already exists at the requested location in an [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService'). |
| [FileNotFoundException](Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException.md 'Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException') | Exception thrown when a file cannot be found at the requested location in an [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService'). |

<a name='Myprysm.FileService.Abstractions.ValueObjects'></a>

## Myprysm.FileService.Abstractions.ValueObjects Namespace

| Classes | |
| :--- | :--- |
| [ETag](Myprysm.FileService.Abstractions.ValueObjects.ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag') | An ETag used for cache control. |
