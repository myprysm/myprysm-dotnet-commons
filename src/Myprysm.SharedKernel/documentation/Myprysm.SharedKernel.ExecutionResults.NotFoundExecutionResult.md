#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ExecutionResults](index.md#Myprysm.SharedKernel.ExecutionResults 'Myprysm.SharedKernel.ExecutionResults')

## NotFoundExecutionResult Class

Represents a failed execution because a resource could not be found.  
  
Can carry errors associated with the failure.

```csharp
public class NotFoundExecutionResult : Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult') &#129106; [FailedExecutionResult](Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult') &#129106; NotFoundExecutionResult
### Methods

<a name='Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult.ToString()'></a>

## NotFoundExecutionResult.ToString() Method

Returns a string representation of this [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult').

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of this result.