#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Interfaces](index.md#Myprysm_SharedKernel_Interfaces 'Myprysm.SharedKernel.Interfaces')
## IReader&lt;TRequest,TResponse&gt; Interface
Reader that reads the requested output from the given request asynchronously.  
```csharp
public interface IReader<in TRequest,TResponse>
    where TRequest : Myprysm.SharedKernel.Interfaces.IReaderInput
    where TResponse : notnull
```
#### Type parameters
<a name='Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse__TRequest'></a>
`TRequest`  
The request type.
  
<a name='Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse__TResponse'></a>
`TResponse`  
The response type.
  
### Methods
<a name='Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse__ReadAsync(TRequest_System_Threading_CancellationToken)'></a>
## IReader&lt;TRequest,TResponse&gt;.ReadAsync(TRequest, CancellationToken) Method
Read asynchronously the output for the given request.  
```csharp
System.Threading.Tasks.Task<TResponse> ReadAsync(TRequest request, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse__ReadAsync(TRequest_System_Threading_CancellationToken)_request'></a>
`request` [TRequest](Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse_.md#Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse__TRequest 'Myprysm.SharedKernel.Interfaces.IReader&lt;TRequest,TResponse&gt;.TRequest')  
The request.
  
<a name='Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse__ReadAsync(TRequest_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse_.md#Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse__TResponse 'Myprysm.SharedKernel.Interfaces.IReader&lt;TRequest,TResponse&gt;.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The output corresponding to the request.
  
