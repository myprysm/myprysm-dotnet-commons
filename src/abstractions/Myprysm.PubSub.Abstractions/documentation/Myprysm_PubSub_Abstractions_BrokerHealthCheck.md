#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## BrokerHealthCheck Class
Broker [Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck') to ensure a [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection') instance can work appropriately.  
```csharp
public class BrokerHealthCheck :
Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BrokerHealthCheck  

Implements [Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck')  
### Constructors
<a name='Myprysm_PubSub_Abstractions_BrokerHealthCheck_BrokerHealthCheck(Myprysm_PubSub_Abstractions_IBrokerConnection)'></a>
## BrokerHealthCheck.BrokerHealthCheck(IBrokerConnection) Constructor
Creates a new [BrokerHealthCheck](Myprysm_PubSub_Abstractions_BrokerHealthCheck.md 'Myprysm.PubSub.Abstractions.BrokerHealthCheck').  
```csharp
public BrokerHealthCheck(Myprysm.PubSub.Abstractions.IBrokerConnection broker);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_BrokerHealthCheck_BrokerHealthCheck(Myprysm_PubSub_Abstractions_IBrokerConnection)_broker'></a>
`broker` [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection')  
The broker to verify the health.
  
  
### Methods
<a name='Myprysm_PubSub_Abstractions_BrokerHealthCheck_CheckHealthAsync(Microsoft_Extensions_Diagnostics_HealthChecks_HealthCheckContext_System_Threading_CancellationToken)'></a>
## BrokerHealthCheck.CheckHealthAsync(HealthCheckContext, CancellationToken) Method
Runs the health check, returning the status of the component being checked.  
```csharp
public System.Threading.Tasks.Task<Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult> CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext context, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_BrokerHealthCheck_CheckHealthAsync(Microsoft_Extensions_Diagnostics_HealthChecks_HealthCheckContext_System_Threading_CancellationToken)_context'></a>
`context` [Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext 'Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext')  
A context object associated with the current execution.
  
<a name='Myprysm_PubSub_Abstractions_BrokerHealthCheck_CheckHealthAsync(Microsoft_Extensions_Diagnostics_HealthChecks_HealthCheckContext_System_Threading_CancellationToken)_cancellationToken'></a>
`cancellationToken` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
A [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') that can be used to cancel the health check.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult 'Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') that completes when the health check has finished, yielding the status of the component being checked.

Implements [CheckHealthAsync(HealthCheckContext, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck.CheckHealthAsync#Microsoft_Extensions_Diagnostics_HealthChecks_IHealthCheck_CheckHealthAsync_Microsoft_Extensions_Diagnostics_HealthChecks_HealthCheckContext,System_Threading_CancellationToken_ 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck.CheckHealthAsync(Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckContext,System.Threading.CancellationToken)')  
  
