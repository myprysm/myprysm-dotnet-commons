#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Extensions](index.md#Myprysm.SharedKernel.Extensions 'Myprysm.SharedKernel.Extensions')

## StringExtensions Class

[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') extensions.

```csharp
public static class StringExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StringExtensions
### Methods

<a name='Myprysm.SharedKernel.Extensions.StringExtensions.Fmt(thisstring,object[])'></a>

## StringExtensions.Fmt(this string, object[]) Method

Format fluently a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

```csharp
public static string Fmt(this string subject, params object[] items);
```
#### Parameters

<a name='Myprysm.SharedKernel.Extensions.StringExtensions.Fmt(thisstring,object[]).subject'></a>

`subject` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') subject.

<a name='Myprysm.SharedKernel.Extensions.StringExtensions.Fmt(thisstring,object[]).items'></a>

`items` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The parameter items for the formatting.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The fluently formatted string.