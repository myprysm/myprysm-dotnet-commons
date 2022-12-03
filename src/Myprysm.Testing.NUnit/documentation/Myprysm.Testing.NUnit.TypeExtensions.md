#### [Myprysm.Testing.NUnit](index.md 'index')
### [Myprysm.Testing.NUnit](index.md#Myprysm.Testing.NUnit 'Myprysm.Testing.NUnit')

## TypeExtensions Class

Type extensions useful for testing.

```csharp
public static class TypeExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TypeExtensions
### Methods

<a name='Myprysm.Testing.NUnit.TypeExtensions.GetResourceStream(thisSystem.Type,string)'></a>

## TypeExtensions.GetResourceStream(this Type, string) Method

Get a resource located identified by the provided name  
and located in the same namespace/directory as the provided type.

```csharp
public static System.IO.Stream GetResourceStream(this System.Type type, string resource);
```
#### Parameters

<a name='Myprysm.Testing.NUnit.TypeExtensions.GetResourceStream(thisSystem.Type,string).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to locate relatively the resource.

<a name='Myprysm.Testing.NUnit.TypeExtensions.GetResourceStream(thisSystem.Type,string).resource'></a>

`resource` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The resource to get.

#### Returns
[System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')  
The resource as a [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream').

#### Exceptions

[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
When the requested resource does not exist.