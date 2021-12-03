#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Interfaces](index.md#Myprysm_SharedKernel_Interfaces 'Myprysm.SharedKernel.Interfaces')
## IWriter&lt;TRequest&gt; Interface
Writer that writes the provided output to any medium.  
```csharp
public interface IWriter<in TRequest>
    where TRequest : Myprysm.SharedKernel.Interfaces.IWriterRequest
```
#### Type parameters
<a name='Myprysm_SharedKernel_Interfaces_IWriter_TRequest__TRequest'></a>
`TRequest`  
  
### Methods
<a name='Myprysm_SharedKernel_Interfaces_IWriter_TRequest__WriteAsync(TRequest_System_Threading_CancellationToken)'></a>
## IWriter&lt;TRequest&gt;.WriteAsync(TRequest, CancellationToken) Method
Writes the provided output asynchronously.  
```csharp
System.Threading.Tasks.Task WriteAsync(TRequest output, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_SharedKernel_Interfaces_IWriter_TRequest__WriteAsync(TRequest_System_Threading_CancellationToken)_output'></a>
`output` [TRequest](Myprysm_SharedKernel_Interfaces_IWriter_TRequest_.md#Myprysm_SharedKernel_Interfaces_IWriter_TRequest__TRequest 'Myprysm.SharedKernel.Interfaces.IWriter&lt;TRequest&gt;.TRequest')  
The output to write.
  
<a name='Myprysm_SharedKernel_Interfaces_IWriter_TRequest__WriteAsync(TRequest_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
Completes when the output is written.
  
