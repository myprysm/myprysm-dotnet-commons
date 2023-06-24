#### [Myprysm.SharedKernel](index.md 'index')

## Myprysm.SharedKernel Assembly
### Namespaces

<a name='Myprysm.SharedKernel.Exceptions'></a>

## Myprysm.SharedKernel.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [ConflictException](Myprysm.SharedKernel.Exceptions.ConflictException.md 'Myprysm.SharedKernel.Exceptions.ConflictException') | Represents an exceptional case<br/>when a conflict occurs while processing a resource.<br/><br/>The conflict can be of any source, e.g. a resource version lock check failed<br/>or an identical resource got created/updated at the same time. |
| [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') | Represents an exceptional case encountered as part of the domain of an application.<br/><br/>You can an should specialize this exception when an unhandled case happens in your domain. |
| [ForbiddenException](Myprysm.SharedKernel.Exceptions.ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException') | Represents an exceptional case when the current user cannot perform the requested procedure. |
| [IllegalOperationException](Myprysm.SharedKernel.Exceptions.IllegalOperationException.md 'Myprysm.SharedKernel.Exceptions.IllegalOperationException') | Represents an illegal operation request in the current procedure. |
| [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') | Represents an exceptional case that is considered to be managed in the context of the application. |
| [NotFoundException](Myprysm.SharedKernel.Exceptions.NotFoundException.md 'Myprysm.SharedKernel.Exceptions.NotFoundException') | Represents an exceptional case when a resource could not be found during a procedure. |
| [NotImplementedException](Myprysm.SharedKernel.Exceptions.NotImplementedException.md 'Myprysm.SharedKernel.Exceptions.NotImplementedException') | Represents an operation that has not been yet implemented. |
| [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException') | Represents an exceptional case<br/>when a resource is considered invalid as part of a validation procedure. |
| [ValidationException.ValidationExceptionBuilder](Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.md 'Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder') | A builder for a [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')<br/>that allows to configure fluently an exceptional validation case. |

<a name='Myprysm.SharedKernel.ExecutionResults'></a>

## Myprysm.SharedKernel.ExecutionResults Namespace

| Classes | |
| :--- | :--- |
| [ConflictExecutionResult](Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult') | Represents a failed execution because the current operation created a conflict between some resource.<br/><br/>Can carry errors associated with the failure. |
| [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult') | Represents the execution result of a procedure. |
| [FailedExecutionResult](Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult') | Represents a failed execution for a task/process/handler.<br/><br/>Can carry errors associated with the failure. |
| [ForbiddenExecutionResult](Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult') | Represents a failed execution because the current user is forbidden to access a resource.<br/><br/>Can carry errors associated with the failure. |
| [NotFoundExecutionResult](Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult') | Represents a failed execution because a resource could not be found.<br/><br/>Can carry errors associated with the failure. |
| [ObjectSuccessExecutionResult&lt;TResult&gt;](Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.md 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult<TResult>') | Success execution result with a value. |
| [SuccessExecutionResult](Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult') | Generic success execution result |

| Interfaces | |
| :--- | :--- |
| [IExecutionResult](Myprysm.SharedKernel.ExecutionResults.IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult') | Represents the execution result of a procedure. |

<a name='Myprysm.SharedKernel.Extensions'></a>

## Myprysm.SharedKernel.Extensions Namespace

| Classes | |
| :--- | :--- |
| [CollectionExtensions](Myprysm.SharedKernel.Extensions.CollectionExtensions.md 'Myprysm.SharedKernel.Extensions.CollectionExtensions') | Extensions for [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') and assimilated. |
| [DictionaryExtensions](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md 'Myprysm.SharedKernel.Extensions.DictionaryExtensions') | Extension methods for Dictionary. |
| [StringExtensions](Myprysm.SharedKernel.Extensions.StringExtensions.md 'Myprysm.SharedKernel.Extensions.StringExtensions') | [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') extensions. |
| [TypeExtensions](Myprysm.SharedKernel.Extensions.TypeExtensions.md 'Myprysm.SharedKernel.Extensions.TypeExtensions') | [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') extensions. |

<a name='Myprysm.SharedKernel.Interfaces'></a>

## Myprysm.SharedKernel.Interfaces Namespace

| Interfaces | |
| :--- | :--- |
| [IReader&lt;TRequest,TResponse&gt;](Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.md 'Myprysm.SharedKernel.Interfaces.IReader<TRequest,TResponse>') | Reader that reads the requested output from the given request asynchronously. |
| [IReaderInput](Myprysm.SharedKernel.Interfaces.IReaderInput.md 'Myprysm.SharedKernel.Interfaces.IReaderInput') | [IReader&lt;TRequest,TResponse&gt;](Myprysm.SharedKernel.Interfaces.IReader_TRequest,TResponse_.md 'Myprysm.SharedKernel.Interfaces.IReader<TRequest,TResponse>') request marker interface. |
| [IWriter&lt;TRequest&gt;](Myprysm.SharedKernel.Interfaces.IWriter_TRequest_.md 'Myprysm.SharedKernel.Interfaces.IWriter<TRequest>') | Writer that writes the provided output to any medium. |
| [IWriterRequest](Myprysm.SharedKernel.Interfaces.IWriterRequest.md 'Myprysm.SharedKernel.Interfaces.IWriterRequest') | [IWriter&lt;TRequest&gt;](Myprysm.SharedKernel.Interfaces.IWriter_TRequest_.md 'Myprysm.SharedKernel.Interfaces.IWriter<TRequest>') output marker interface. |

<a name='Myprysm.SharedKernel.ValueObjects'></a>

## Myprysm.SharedKernel.ValueObjects Namespace

| Classes | |
| :--- | :--- |
| [SingleValueObject&lt;T&gt;](Myprysm.SharedKernel.ValueObjects.SingleValueObject_T_.md 'Myprysm.SharedKernel.ValueObjects.SingleValueObject<T>') | Represents a value object that holds a single value and cannot or should not be represented by a C# 9.0 record. |
| [ValueObject](Myprysm.SharedKernel.ValueObjects.ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject') | Represents a value object that cannot or should not be represented by a C# 9.0 record. |

| Interfaces | |
| :--- | :--- |
| [ISingleValueObject](Myprysm.SharedKernel.ValueObjects.ISingleValueObject.md 'Myprysm.SharedKernel.ValueObjects.ISingleValueObject') | Represents an object holding a single value. |
