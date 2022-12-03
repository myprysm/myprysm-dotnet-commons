#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ExecutionResults](index.md#Myprysm.SharedKernel.ExecutionResults 'Myprysm.SharedKernel.ExecutionResults')

## ObjectSuccessExecutionResult<TResult> Class

Success execution result with a value.

```csharp
public class ObjectSuccessExecutionResult<TResult> : Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult
```
#### Type parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.TResult'></a>

`TResult`

The type of the result value

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult') &#129106; [SuccessExecutionResult](Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult') &#129106; ObjectSuccessExecutionResult<TResult>
### Fields

<a name='Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.MessageTemplate'></a>

## ObjectSuccessExecutionResult<TResult>.MessageTemplate Field

The success message template.

```csharp
public const string MessageTemplate = "Successful execution: {0}";
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Properties

<a name='Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.Result'></a>

## ObjectSuccessExecutionResult<TResult>.Result Property

The result returned by the execution.

```csharp
public TResult Result { get; }
```

#### Property Value
[TResult](Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.md#Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.TResult 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult<TResult>.TResult')
### Methods

<a name='Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.ToString()'></a>

## ObjectSuccessExecutionResult<TResult>.ToString() Method

Returns a string representation of this [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult').

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of this result.