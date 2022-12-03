#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions.ValueObjects](index.md#Myprysm.FileService.Abstractions.ValueObjects 'Myprysm.FileService.Abstractions.ValueObjects')

## ETag Class

An ETag used for cache control.

```csharp
public class ETag : Myprysm.SharedKernel.ValueObjects.SingleValueObject<string>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.SharedKernel.ValueObjects.ValueObject](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.ValueObject 'Myprysm.SharedKernel.ValueObjects.ValueObject') &#129106; [Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.SingleValueObject-1 'Myprysm.SharedKernel.ValueObjects.SingleValueObject`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.SingleValueObject-1 'Myprysm.SharedKernel.ValueObjects.SingleValueObject`1') &#129106; ETag
### Constructors

<a name='Myprysm.FileService.Abstractions.ValueObjects.ETag.ETag(string)'></a>

## ETag(string) Constructor

Creates a new [ETag](Myprysm.FileService.Abstractions.ValueObjects.ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag') with the provided value.

```csharp
public ETag(string value);
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.ValueObjects.ETag.ETag(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.
### Fields

<a name='Myprysm.FileService.Abstractions.ValueObjects.ETag.All'></a>

## ETag.All Field

The representation for All ("*").

```csharp
public static readonly ETag All;
```

#### Field Value
[ETag](Myprysm.FileService.Abstractions.ValueObjects.ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag')
### Methods

<a name='Myprysm.FileService.Abstractions.ValueObjects.ETag.From(string)'></a>

## ETag.From(string) Method

Factory method to create an [ETag](Myprysm.FileService.Abstractions.ValueObjects.ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag') with the provided value.

```csharp
public static Myprysm.FileService.Abstractions.ValueObjects.ETag From(string etag);
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.ValueObjects.ETag.From(string).etag'></a>

`etag` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

#### Returns
[ETag](Myprysm.FileService.Abstractions.ValueObjects.ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag')  
The [ETag](Myprysm.FileService.Abstractions.ValueObjects.ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag') with the value.