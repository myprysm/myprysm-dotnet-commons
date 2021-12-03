#### [Myprysm.SharedKernel](index.md 'index')
### Namespaces
<a name='Myprysm_SharedKernel_Exceptions'></a>
## Myprysm.SharedKernel.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [ConflictException](Myprysm_SharedKernel_Exceptions_ConflictException.md 'Myprysm.SharedKernel.Exceptions.ConflictException') | Represents an exceptional case<br/>when a conflict occurs while processing a resource.<br/><br/>The conflict can be of any source, e.g. a resource version lock check failed<br/>or an identical resource got created/updated at the same time.<br/> |
| [DomainException](Myprysm_SharedKernel_Exceptions_DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') | Represents an exceptional case encountered as part of the domain of an application.<br/><br/>You can an should specialize this exception when an unhandled case happens in your domain.<br/> |
| [ForbiddenException](Myprysm_SharedKernel_Exceptions_ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException') | Represents an exceptional case when the current user cannot perform the requested procedure.<br/> |
| [IllegalOperationException](Myprysm_SharedKernel_Exceptions_IllegalOperationException.md 'Myprysm.SharedKernel.Exceptions.IllegalOperationException') | Represents an illegal operation request in the current procedure. <br/> |
| [ManagedException](Myprysm_SharedKernel_Exceptions_ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') | Represents an exceptional case that is considered to be managed in the context of the application.<br/> |
| [NotFoundException](Myprysm_SharedKernel_Exceptions_NotFoundException.md 'Myprysm.SharedKernel.Exceptions.NotFoundException') | Represents an exceptional case when a resource could not be found during a procedure.<br/> |
| [NotImplementedException](Myprysm_SharedKernel_Exceptions_NotImplementedException.md 'Myprysm.SharedKernel.Exceptions.NotImplementedException') | Represents an operation that has not been yet implemented.<br/> |
| [ValidationException](Myprysm_SharedKernel_Exceptions_ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException') | Represents an exceptional case<br/>when a resource is considered invalid as part of a validation procedure.<br/> |
| [ValidationException.ValidationExceptionBuilder](Myprysm_SharedKernel_Exceptions_ValidationException_ValidationExceptionBuilder.md 'Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder') | A builder for a [ValidationException](Myprysm_SharedKernel_Exceptions_ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')<br/>that allows to configure fluently an exceptional validation case.<br/> |
  
<a name='Myprysm_SharedKernel_ExecutionResults'></a>
## Myprysm.SharedKernel.ExecutionResults Namespace

| Classes | |
| :--- | :--- |
| [ExecutionResult](Myprysm_SharedKernel_ExecutionResults_ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult') | Represents the execution result of a procedure.<br/> |
| [FailedExecutionResult](Myprysm_SharedKernel_ExecutionResults_FailedExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult') | Represents a failed execution for a task/process/handler.<br/><br/>Can carry errors associated with the failure.<br/> |
| [ObjectSuccessExecutionResult&lt;TResult&gt;](Myprysm_SharedKernel_ExecutionResults_ObjectSuccessExecutionResult_TResult_.md 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult&lt;TResult&gt;') | Success execution result with a value.<br/> |
| [SuccessExecutionResult](Myprysm_SharedKernel_ExecutionResults_SuccessExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult') | Generic success execution result<br/> |

| Interfaces | |
| :--- | :--- |
| [IExecutionResult](Myprysm_SharedKernel_ExecutionResults_IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult') | Represents the execution result of a procedure.<br/> |
  
<a name='Myprysm_SharedKernel_Extensions'></a>
## Myprysm.SharedKernel.Extensions Namespace

| Classes | |
| :--- | :--- |
| [CollectionExtensions](Myprysm_SharedKernel_Extensions_CollectionExtensions.md 'Myprysm.SharedKernel.Extensions.CollectionExtensions') | Extensions for [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') and assimilated.<br/> |
| [DictionaryExtensions](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md 'Myprysm.SharedKernel.Extensions.DictionaryExtensions') | Extension methods for Dictionary.<br/> |
| [StringExtensions](Myprysm_SharedKernel_Extensions_StringExtensions.md 'Myprysm.SharedKernel.Extensions.StringExtensions') | [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') extensions.<br/>             |
| [TypeExtensions](Myprysm_SharedKernel_Extensions_TypeExtensions.md 'Myprysm.SharedKernel.Extensions.TypeExtensions') | [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') extensions.<br/>             |
  
<a name='Myprysm_SharedKernel_Interfaces'></a>
## Myprysm.SharedKernel.Interfaces Namespace

| Interfaces | |
| :--- | :--- |
| [IReader&lt;TRequest,TResponse&gt;](Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse_.md 'Myprysm.SharedKernel.Interfaces.IReader&lt;TRequest,TResponse&gt;') | Reader that reads the requested output from the given request asynchronously.<br/> |
| [IReaderInput](Myprysm_SharedKernel_Interfaces_IReaderInput.md 'Myprysm.SharedKernel.Interfaces.IReaderInput') | [IReader&lt;TRequest,TResponse&gt;](Myprysm_SharedKernel_Interfaces_IReader_TRequest_TResponse_.md 'Myprysm.SharedKernel.Interfaces.IReader&lt;TRequest,TResponse&gt;') request marker interface.<br/>             |
| [IWriter&lt;TRequest&gt;](Myprysm_SharedKernel_Interfaces_IWriter_TRequest_.md 'Myprysm.SharedKernel.Interfaces.IWriter&lt;TRequest&gt;') | Writer that writes the provided output to any medium.<br/> |
| [IWriterRequest](Myprysm_SharedKernel_Interfaces_IWriterRequest.md 'Myprysm.SharedKernel.Interfaces.IWriterRequest') | [IWriter&lt;TRequest&gt;](Myprysm_SharedKernel_Interfaces_IWriter_TRequest_.md 'Myprysm.SharedKernel.Interfaces.IWriter&lt;TRequest&gt;') output marker interface.<br/>             |
  
<a name='Myprysm_SharedKernel_ValueObjects'></a>
## Myprysm.SharedKernel.ValueObjects Namespace

| Classes | |
| :--- | :--- |
| [SingleValueObject&lt;T&gt;](Myprysm_SharedKernel_ValueObjects_SingleValueObject_T_.md 'Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;T&gt;') | Represents a value object that holds a single value and cannot or should not be represented by a C# 9.0 record.<br/> |
| [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject') | Represents a value object that cannot or should not be represented by a C# 9.0 record.<br/> |

| Interfaces | |
| :--- | :--- |
| [ISingleValueObject](Myprysm_SharedKernel_ValueObjects_ISingleValueObject.md 'Myprysm.SharedKernel.ValueObjects.ISingleValueObject') | Represents an object holding a single value.<br/> |
  
