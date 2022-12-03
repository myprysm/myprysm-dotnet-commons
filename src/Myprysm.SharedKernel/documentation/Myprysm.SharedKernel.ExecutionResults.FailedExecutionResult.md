#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ExecutionResults](index.md#Myprysm.SharedKernel.ExecutionResults 'Myprysm.SharedKernel.ExecutionResults')

## FailedExecutionResult Class

Represents a failed execution for a task/process/handler.  
  
Can carry errors associated with the failure.

```csharp
public class FailedExecutionResult : Myprysm.SharedKernel.ExecutionResults.ExecutionResult
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult') &#129106; FailedExecutionResult
### Fields

<a name='Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.DefaultMessage'></a>

## FailedExecutionResult.DefaultMessage Field

The default error message.

```csharp
public const string DefaultMessage = "Failed execution";
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.MessageTemplate'></a>

## FailedExecutionResult.MessageTemplate Field

The error message template.

```csharp
public const string MessageTemplate = "Failed execution due to: {0}";
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Properties

<a name='Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.Errors'></a>

## FailedExecutionResult.Errors Property

The errors held by this failed execution.

```csharp
public System.Collections.Generic.IEnumerable<string> Errors { get; }
```

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.IsSuccess'></a>

## FailedExecutionResult.IsSuccess Property

Indicates whether the procedure executed successfully.

```csharp
public override bool IsSuccess { get; }
```

Implements [IsSuccess](Myprysm.SharedKernel.ExecutionResults.IExecutionResult.md#Myprysm.SharedKernel.ExecutionResults.IExecutionResult.IsSuccess 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult.IsSuccess')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.ToString()'></a>

## FailedExecutionResult.ToString() Method

Returns a string representation of this [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult').

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of this result.