#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Interfaces](index.md#Myprysm.SharedKernel.Interfaces 'Myprysm.SharedKernel.Interfaces')

## IWriter<TRequest> Interface

Writer that writes the provided output to any medium.

```csharp
public interface IWriter<in TRequest>
    where TRequest : Myprysm.SharedKernel.Interfaces.IWriterRequest
```
#### Type parameters

<a name='Myprysm.SharedKernel.Interfaces.IWriter_TRequest_.TRequest'></a>

`TRequest`
### Methods

<a name='Myprysm.SharedKernel.Interfaces.IWriter_TRequest_.WriteAsync(TRequest,System.Threading.CancellationToken)'></a>

## IWriter<TRequest>.WriteAsync(TRequest, CancellationToken) Method

Writes the provided output asynchronously.

```csharp
System.Threading.Tasks.Task<Myprysm.SharedKernel.ExecutionResults.IExecutionResult> WriteAsync(TRequest output, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.SharedKernel.Interfaces.IWriter_TRequest_.WriteAsync(TRequest,System.Threading.CancellationToken).output'></a>

`output` [TRequest](Myprysm.SharedKernel.Interfaces.IWriter_TRequest_.md#Myprysm.SharedKernel.Interfaces.IWriter_TRequest_.TRequest 'Myprysm.SharedKernel.Interfaces.IWriter<TRequest>.TRequest')

The output to write.

<a name='Myprysm.SharedKernel.Interfaces.IWriter_TRequest_.WriteAsync(TRequest,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[IExecutionResult](Myprysm.SharedKernel.ExecutionResults.IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
An [IExecutionResult](Myprysm.SharedKernel.ExecutionResults.IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult') indicating whether the operation succeeded.