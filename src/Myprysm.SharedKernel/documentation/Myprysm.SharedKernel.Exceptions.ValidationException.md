#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm.SharedKernel.Exceptions 'Myprysm.SharedKernel.Exceptions')

## ValidationException Class

Represents an exceptional case  
when a resource is considered invalid as part of a validation procedure.

```csharp
public class ValidationException : Myprysm.SharedKernel.Exceptions.DomainException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') &#129106; ValidationException

### Remarks
You can use this exception as a flow control exception.
### Properties

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.Errors'></a>

## ValidationException.Errors Property

The errors reporting during the validation procedure.

```csharp
public System.Collections.Generic.IDictionary<string,System.Collections.Generic.IEnumerable<string>> Errors { get; }
```

#### Property Value
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')
### Methods

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.Builder()'></a>

## ValidationException.Builder() Method

Creates a new [ValidationExceptionBuilder](Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.md 'Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder')  
that allows to configure multiple errors for multiple keys.

```csharp
public static Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder Builder();
```

#### Returns
[ValidationExceptionBuilder](Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.md 'Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder')  
The [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException') builder.

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.For(string,string)'></a>

## ValidationException.For(string, string) Method

Creates a [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException') with the provided error message for the provide key.

```csharp
public static Myprysm.SharedKernel.Exceptions.ValidationException For(string key, string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.For(string,string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the error incurring the [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException').

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.For(string,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason why the error has been thrown.

#### Returns
[ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')  
The validation exception.

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.With(System.Collections.Generic.IDictionary_string,System.Collections.Generic.IEnumerable_string__)'></a>

## ValidationException.With(IDictionary<string,IEnumerable<string>>) Method

Creates a [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException') with the provided errors dictionary.  
  
Exceptional values should be reported as an enumeration of failures to validate against a given property.

```csharp
public static Myprysm.SharedKernel.Exceptions.ValidationException With(System.Collections.Generic.IDictionary<string,System.Collections.Generic.IEnumerable<string>> errors);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.With(System.Collections.Generic.IDictionary_string,System.Collections.Generic.IEnumerable_string__).errors'></a>

`errors` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

The errors incurring the [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException').

#### Returns
[ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')  
The validation exception.

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.WithError(string,string)'></a>

## ValidationException.WithError(string, string) Method

Creates a new [ValidationExceptionBuilder](Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.md 'Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder') initialized with the provided key and message  
that allows to configure multiple errors for multiple keys.

```csharp
public static Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder WithError(string key, string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.WithError(string,string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.WithError(string,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[ValidationExceptionBuilder](Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.md 'Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder')  
The [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException') builder.