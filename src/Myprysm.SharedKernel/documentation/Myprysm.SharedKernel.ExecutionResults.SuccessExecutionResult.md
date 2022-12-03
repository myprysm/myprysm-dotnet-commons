#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ExecutionResults](index.md#Myprysm.SharedKernel.ExecutionResults 'Myprysm.SharedKernel.ExecutionResults')

## SuccessExecutionResult Class

Generic success execution result

```csharp
public class SuccessExecutionResult : Myprysm.SharedKernel.ExecutionResults.ExecutionResult
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult') &#129106; SuccessExecutionResult

Derived  
&#8627; [ObjectSuccessExecutionResult&lt;TResult&gt;](Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.md 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult<TResult>')
### Fields

<a name='Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult.DefaultMessage'></a>

## SuccessExecutionResult.DefaultMessage Field

The default success message.

```csharp
public const string DefaultMessage = "Successful execution";
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Properties

<a name='Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult.IsSuccess'></a>

## SuccessExecutionResult.IsSuccess Property

Indicates whether the procedure executed successfully.

```csharp
public override bool IsSuccess { get; }
```

Implements [IsSuccess](Myprysm.SharedKernel.ExecutionResults.IExecutionResult.md#Myprysm.SharedKernel.ExecutionResults.IExecutionResult.IsSuccess 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult.IsSuccess')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult.ToString()'></a>

## SuccessExecutionResult.ToString() Method

Returns a string representation of this [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult').

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of this result.