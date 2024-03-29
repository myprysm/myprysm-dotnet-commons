#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ExecutionResults](index.md#Myprysm.SharedKernel.ExecutionResults 'Myprysm.SharedKernel.ExecutionResults')

## ExecutionResult Class

Represents the execution result of a procedure.

```csharp
public abstract class ExecutionResult :
Myprysm.SharedKernel.ExecutionResults.IExecutionResult
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExecutionResult

Derived  
&#8627; [FailedExecutionResult](Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult')  
&#8627; [SuccessExecutionResult](Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.SuccessExecutionResult')

Implements [IExecutionResult](Myprysm.SharedKernel.ExecutionResults.IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult')
### Properties

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.IsSuccess'></a>

## ExecutionResult.IsSuccess Property

Indicates whether the procedure executed successfully.

```csharp
public abstract bool IsSuccess { get; }
```

Implements [IsSuccess](Myprysm.SharedKernel.ExecutionResults.IExecutionResult.md#Myprysm.SharedKernel.ExecutionResults.IExecutionResult.IsSuccess 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult.IsSuccess')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Methods

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Conflict()'></a>

## ExecutionResult.Conflict() Method

Returns a conflict execution result.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult Conflict();
```

#### Returns
[ConflictExecutionResult](Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult')  
The conflict execution result.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Conflict(string[])'></a>

## ExecutionResult.Conflict(string[]) Method

Returns a conflict execution result with the provided errors.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult Conflict(params string[] errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Conflict(string[]).errors'></a>

`errors` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The errors to report.

#### Returns
[ConflictExecutionResult](Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult')  
A conflict execution result containing the provided errors as a reason.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Conflict(System.Collections.Generic.IEnumerable_string_)'></a>

## ExecutionResult.Conflict(IEnumerable<string>) Method

Returns a conflict execution result with the provided errors.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult Conflict(System.Collections.Generic.IEnumerable<string> errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Conflict(System.Collections.Generic.IEnumerable_string_).errors'></a>

`errors` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The errors to report.

#### Returns
[ConflictExecutionResult](Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ConflictExecutionResult')  
A conflict execution result containing the provided errors as a reason.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Failed()'></a>

## ExecutionResult.Failed() Method

Returns a failed execution result.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult Failed();
```

#### Returns
[FailedExecutionResult](Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult')  
The failed execution result.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Failed(string[])'></a>

## ExecutionResult.Failed(string[]) Method

Returns a failed execution result with the provided errors.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult Failed(params string[] errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Failed(string[]).errors'></a>

`errors` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The errors to report.

#### Returns
[FailedExecutionResult](Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult')  
A failed execution result containing the provided errors as a reason.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Failed(System.Collections.Generic.IEnumerable_string_)'></a>

## ExecutionResult.Failed(IEnumerable<string>) Method

Returns a failed execution result with the provided errors.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult Failed(System.Collections.Generic.IEnumerable<string> errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Failed(System.Collections.Generic.IEnumerable_string_).errors'></a>

`errors` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The errors to report.

#### Returns
[FailedExecutionResult](Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.FailedExecutionResult')  
A failed execution result containing the provided errors as a reason.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Forbidden()'></a>

## ExecutionResult.Forbidden() Method

Returns a forbidden execution result.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult Forbidden();
```

#### Returns
[ForbiddenExecutionResult](Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult')  
The forbidden execution result.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Forbidden(string[])'></a>

## ExecutionResult.Forbidden(string[]) Method

Returns a forbidden execution result with the provided errors.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult Forbidden(params string[] errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Forbidden(string[]).errors'></a>

`errors` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The errors to report.

#### Returns
[ForbiddenExecutionResult](Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult')  
A forbidden execution result containing the provided errors as a reason.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Forbidden(System.Collections.Generic.IEnumerable_string_)'></a>

## ExecutionResult.Forbidden(IEnumerable<string>) Method

Returns a forbidden execution result with the provided errors.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult Forbidden(System.Collections.Generic.IEnumerable<string> errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Forbidden(System.Collections.Generic.IEnumerable_string_).errors'></a>

`errors` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The errors to report.

#### Returns
[ForbiddenExecutionResult](Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ForbiddenExecutionResult')  
A forbidden execution result containing the provided errors as a reason.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.NotFound()'></a>

## ExecutionResult.NotFound() Method

Returns a not found execution result.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult NotFound();
```

#### Returns
[NotFoundExecutionResult](Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult')  
The not found execution result.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.NotFound(string[])'></a>

## ExecutionResult.NotFound(string[]) Method

Returns a not found execution result with the provided errors.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult NotFound(params string[] errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.NotFound(string[]).errors'></a>

`errors` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The errors to report.

#### Returns
[NotFoundExecutionResult](Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult')  
A not found execution result containing the provided errors as a reason.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.NotFound(System.Collections.Generic.IEnumerable_string_)'></a>

## ExecutionResult.NotFound(IEnumerable<string>) Method

Returns a not found execution result with the provided errors.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult NotFound(System.Collections.Generic.IEnumerable<string> errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.NotFound(System.Collections.Generic.IEnumerable_string_).errors'></a>

`errors` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The errors to report.

#### Returns
[NotFoundExecutionResult](Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.NotFoundExecutionResult')  
A not found execution result containing the provided errors as a reason.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success()'></a>

## ExecutionResult.Success() Method

Returns a successful execution result.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.IExecutionResult Success();
```

#### Returns
[IExecutionResult](Myprysm.SharedKernel.ExecutionResults.IExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.IExecutionResult')  
The successful execution result.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success_TResult_(TResult)'></a>

## ExecutionResult.Success<TResult>(TResult) Method

Returns a successful execution result holding a value.

```csharp
public static Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult<TResult> Success<TResult>(TResult result);
```
#### Type parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success_TResult_(TResult).TResult'></a>

`TResult`

The type of the result.
#### Parameters

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success_TResult_(TResult).result'></a>

`result` [TResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md#Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success_TResult_(TResult).TResult 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success<TResult>(TResult).TResult')

The value held by the result.

#### Returns
[Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult&lt;](Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.md 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult<TResult>')[TResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md#Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success_TResult_(TResult).TResult 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult.Success<TResult>(TResult).TResult')[&gt;](Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult_TResult_.md 'Myprysm.SharedKernel.ExecutionResults.ObjectSuccessExecutionResult<TResult>')  
An object representing the success of a procedure with the provided result as a context.

<a name='Myprysm.SharedKernel.ExecutionResults.ExecutionResult.ToString()'></a>

## ExecutionResult.ToString() Method

Returns a string representation of this [ExecutionResult](Myprysm.SharedKernel.ExecutionResults.ExecutionResult.md 'Myprysm.SharedKernel.ExecutionResults.ExecutionResult').

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of this result.