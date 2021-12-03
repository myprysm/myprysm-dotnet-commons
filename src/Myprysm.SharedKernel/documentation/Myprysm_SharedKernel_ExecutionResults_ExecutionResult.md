#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ExecutionResults](index.md#Myprysm_SharedKernel_ExecutionResults 'Myprysm.SharedKernel.ExecutionResults')
## ExecutionResult Class
Represents the execution result of a procedure.  
```csharp
public abstract class ExecutionResult :
Myprysm.SharedKernel.ExecutionResults.IExecutionResult
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExecutionResult  

Derived  
&#8627; [FailedExecutionResult](Myprysm_SharedKernel_ExecutionResults_FailedExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult')  
&#8627; [SuccessExecutionResult](Myprysm_SharedKernel_ExecutionResults_SuccessExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult')  

Implements [IExecutionResult](Myprysm_SharedKernel_ExecutionResults_IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult')  
### Properties
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_IsSuccess'></a>
## ExecutionResult.IsSuccess Property
Indicates whether the procedure executed successfully.  
```csharp
public abstract bool IsSuccess { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Implements [IsSuccess](Myprysm_SharedKernel_ExecutionResults_IExecutionResult.md#Myprysm_SharedKernel_ExecutionResults_IExecutionResult_IsSuccess 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult.IsSuccess')  
  
### Methods
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Failed()'></a>
## ExecutionResult.Failed() Method
Returns a failed execution result.  
```csharp
public static Myprysm.SharedKernel.ExecutionResults.IExecutionResult Failed();
```
#### Returns
[IExecutionResult](Myprysm_SharedKernel_ExecutionResults_IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult')  
The failed execution result.
  
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Failed(string__)'></a>
## ExecutionResult.Failed(string[]) Method
Returns a failed execution result with the provided errors.  
```csharp
public static Myprysm.SharedKernel.ExecutionResults.IExecutionResult Failed(params string[] errors);
```
#### Parameters
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Failed(string__)_errors'></a>
`errors` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The errors to report.
  
#### Returns
[IExecutionResult](Myprysm_SharedKernel_ExecutionResults_IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult')  
A failed execution result containing the provided errors as a reason.
  
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Failed(System_Collections_Generic_IEnumerable_string_)'></a>
## ExecutionResult.Failed(IEnumerable&lt;string&gt;) Method
Returns a failed execution result with the provided errors.  
```csharp
public static Myprysm.SharedKernel.ExecutionResults.IExecutionResult Failed(System.Collections.Generic.IEnumerable<string> errors);
```
#### Parameters
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Failed(System_Collections_Generic_IEnumerable_string_)_errors'></a>
`errors` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The errors to report.
  
#### Returns
[IExecutionResult](Myprysm_SharedKernel_ExecutionResults_IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult')  
A failed execution result containing the provided errors as a reason.
  
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Success()'></a>
## ExecutionResult.Success() Method
Returns a successful execution result.   
```csharp
public static Myprysm.SharedKernel.ExecutionResults.IExecutionResult Success();
```
#### Returns
[IExecutionResult](Myprysm_SharedKernel_ExecutionResults_IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult')  
The successful execution result.
  
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Success_TResult_(TResult)'></a>
## ExecutionResult.Success&lt;TResult&gt;(TResult) Method
Returns a successful execution result holding a value.  
```csharp
public static Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult<TResult> Success<TResult>(TResult result);
```
#### Type parameters
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Success_TResult_(TResult)_TResult'></a>
`TResult`  
The type of the result.
  
#### Parameters
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Success_TResult_(TResult)_result'></a>
`result` [TResult](Myprysm_SharedKernel_ExecutionResults_ExecutionResult.md#Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Success_TResult_(TResult)_TResult 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success&lt;TResult&gt;(TResult).TResult')  
The value held by the result.
  
#### Returns
[Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult&lt;](Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult_.md 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult&lt;TResult&gt;')[TResult](Myprysm_SharedKernel_ExecutionResults_ExecutionResult.md#Myprysm_SharedKernel_ExecutionResults_ExecutionResult_Success_TResult_(TResult)_TResult 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success&lt;TResult&gt;(TResult).TResult')[&gt;](Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult_.md 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult&lt;TResult&gt;')  
An object representing the success of a procedure with the provided result as a context.
  
<a name='Myprysm_SharedKernel_ExecutionResults_ExecutionResult_ToString()'></a>
## ExecutionResult.ToString() Method
Returns a string representation of this [ExecutionResult](Myprysm_SharedKernel_ExecutionResults_ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult').  
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of this result.
  
