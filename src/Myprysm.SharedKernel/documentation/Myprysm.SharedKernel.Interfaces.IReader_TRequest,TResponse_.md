#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Interfaces](index.md#Myprysm.SharedKernel.Interfaces 'Myprysm.SharedKernel.Interfaces')

## IReader<TRequest,TResponse> Interface

Reader that reads the requested output from the given request asynchronously.

```csharp
public interface IReader<in TRequest,TResponse>
    where TRequest : Myprysm.SharedKernel.Interfaces.IReaderInput
```
#### Type parameters

<a name='Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.TRequest'></a>

`TRequest`

The request type.

<a name='Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.TResponse'></a>

`TResponse`

The response type.
### Methods

<a name='Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.ReadAsync(TRequest,System.Threading.CancellationToken)'></a>

## IReader<TRequest,TResponse>.ReadAsync(TRequest, CancellationToken) Method

Read asynchronously the output for the given request.

```csharp
System.Threading.Tasks.Task<TResponse?> ReadAsync(TRequest request, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.ReadAsync(TRequest,System.Threading.CancellationToken).request'></a>

`request` [TRequest](Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.md#Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.TRequest 'Myprysm.SharedKernel.Interfaces.IReader<TRequest,TResponse>.TRequest')

The request.

<a name='Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.ReadAsync(TRequest,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.md#Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.TResponse 'Myprysm.SharedKernel.Interfaces.IReader<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The output corresponding to the request.