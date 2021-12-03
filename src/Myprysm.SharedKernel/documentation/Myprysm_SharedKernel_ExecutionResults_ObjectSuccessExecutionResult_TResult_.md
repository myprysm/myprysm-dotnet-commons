#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ExecutionResults](index.md#Myprysm_SharedKernel_ExecutionResults 'Myprysm.SharedKernel.ExecutionResults')
## ObjectSuccessExecutionResult&lt;TResult&gt; Class
Success execution result with a value.  
```csharp
public class ObjectSuccessExecutionResult<TResult> : Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult
```
#### Type parameters
<a name='Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult__TResult'></a>
`TResult`  
The type of the result value
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExecutionResult](Myprysm_SharedKernel_ExecutionResults_ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult') &#129106; [SuccessExecutionResult](Myprysm_SharedKernel_ExecutionResults_SuccessExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult') &#129106; ObjectSuccessExecutionResult&lt;TResult&gt;  
### Fields
<a name='Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult__MessageTemplate'></a>
## ObjectSuccessExecutionResult&lt;TResult&gt;.MessageTemplate Field
The success message template.  
```csharp
public const string MessageTemplate = Successful execution: {0};
```
#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
### Properties
<a name='Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult__Result'></a>
## ObjectSuccessExecutionResult&lt;TResult&gt;.Result Property
The result returned by the execution.  
```csharp
public TResult Result { get; }
```
#### Property Value
[TResult](Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult_.md#Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult__TResult 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult&lt;TResult&gt;.TResult')
  
### Methods
<a name='Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult__ToString()'></a>
## ObjectSuccessExecutionResult&lt;TResult&gt;.ToString() Method
Returns a string representation of this [ExecutionResult](Myprysm_SharedKernel_ExecutionResults_ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult').  
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of this result.
  
