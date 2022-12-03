#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions](index.md#Myprysm.FileService.Abstractions 'Myprysm.FileService.Abstractions')

## FileServiceHealthCheck Class

File service [Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck') to ensure a [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService') instance can work appropriately.

```csharp
public class FileServiceHealthCheck :
Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FileServiceHealthCheck

Implements [Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck')
### Constructors

<a name='Myprysm.FileService.Abstractions.FileServiceHealthCheck.FileServiceHealthCheck(Myprysm.FileService.Abstractions.IFileService,string)'></a>

## FileServiceHealthCheck(IFileService, string) Constructor

Creates a new [FileServiceHealthCheck](Myprysm.FileService.Abstractions.FileServiceHealthCheck.md 'Myprysm.FileService.Abstractions.FileServiceHealthCheck') instance.

```csharp
public FileServiceHealthCheck(Myprysm.FileService.Abstractions.IFileService fileService, string container);
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.FileServiceHealthCheck.FileServiceHealthCheck(Myprysm.FileService.Abstractions.IFileService,string).fileService'></a>

`fileService` [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService')

The file service to check.

<a name='Myprysm.FileService.Abstractions.FileServiceHealthCheck.FileServiceHealthCheck(Myprysm.FileService.Abstractions.IFileService,string).container'></a>

`container` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The container used for the health checks (that can help to avoid container pollution).
### Methods

<a name='Myprysm.FileService.Abstractions.FileServiceHealthCheck.CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext,System.Threading.CancellationToken)'></a>

## FileServiceHealthCheck.CheckHealthAsync(HealthCheckContext, CancellationToken) Method

Runs the health check, returning the status of the component being checked.

```csharp
public System.Threading.Tasks.Task<Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult> CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext context, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.FileServiceHealthCheck.CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext,System.Threading.CancellationToken).context'></a>

`context` [Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext 'Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext')

A context object associated with the current execution.

<a name='Myprysm.FileService.Abstractions.FileServiceHealthCheck.CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

A [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') that can be used to cancel the health check.

Implements [CheckHealthAsync(HealthCheckContext, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck.CheckHealthAsync#Microsoft_Extensions_Diagnostics_HealthChecks_IHealthCheck_CheckHealthAsync_Microsoft_Extensions_Diagnostics_HealthChecks_HealthCheckContext,System_Threading_CancellationToken_ 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck.CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext,System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult 'Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') that completes when the health check has finished, yielding the status of the component being checked.