#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm.SharedKernel.Exceptions 'Myprysm.SharedKernel.Exceptions').[ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')

## ValidationException.ValidationExceptionBuilder Class

A builder for a [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')  
that allows to configure fluently an exceptional validation case.

```csharp
public class ValidationException.ValidationExceptionBuilder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValidationExceptionBuilder
### Methods

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.Build()'></a>

## ValidationException.ValidationExceptionBuilder.Build() Method

Build the [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException') represented by this builder.

```csharp
public Myprysm.SharedKernel.Exceptions.ValidationException Build();
```

#### Returns
[ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')  
The exception represented by this builder.

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.WithError(string,string)'></a>

## ValidationException.ValidationExceptionBuilder.WithError(string, string) Method

Adds the error message to the provided key.

```csharp
public Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder WithError(string key, string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.WithError(string,string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the error.

<a name='Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.WithError(string,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the error.

#### Returns
[ValidationExceptionBuilder](Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder.md 'Myprysm.SharedKernel.Exceptions.ValidationException.ValidationExceptionBuilder')  
This builder.