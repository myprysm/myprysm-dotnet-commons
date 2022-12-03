#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions](index.md#Myprysm.ImageService.Abstractions 'Myprysm.ImageService.Abstractions')

## ImageMetadata Class

Represents the metadata of an image.

```csharp
public sealed class ImageMetadata :
System.IEquatable<Myprysm.ImageService.Abstractions.ImageMetadata>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ImageMetadata

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ImageMetadata](Myprysm.ImageService.Abstractions.ImageMetadata.md 'Myprysm.ImageService.Abstractions.ImageMetadata')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')
### Constructors

<a name='Myprysm.ImageService.Abstractions.ImageMetadata.ImageMetadata(Myprysm.ImageService.Abstractions.ImageFormat,Myprysm.ImageService.Abstractions.Size,string)'></a>

## ImageMetadata(ImageFormat, Size, string) Constructor

Represents the metadata of an image.

```csharp
public ImageMetadata(Myprysm.ImageService.Abstractions.ImageFormat Format, Myprysm.ImageService.Abstractions.Size Size, string ContentType);
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.ImageMetadata.ImageMetadata(Myprysm.ImageService.Abstractions.ImageFormat,Myprysm.ImageService.Abstractions.Size,string).Format'></a>

`Format` [ImageFormat](Myprysm.ImageService.Abstractions.ImageFormat.md 'Myprysm.ImageService.Abstractions.ImageFormat')

The format of the image.

<a name='Myprysm.ImageService.Abstractions.ImageMetadata.ImageMetadata(Myprysm.ImageService.Abstractions.ImageFormat,Myprysm.ImageService.Abstractions.Size,string).Size'></a>

`Size` [Size](Myprysm.ImageService.Abstractions.Size.md 'Myprysm.ImageService.Abstractions.Size')

The size of the image.

<a name='Myprysm.ImageService.Abstractions.ImageMetadata.ImageMetadata(Myprysm.ImageService.Abstractions.ImageFormat,Myprysm.ImageService.Abstractions.Size,string).ContentType'></a>

`ContentType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The content type of the image.
### Properties

<a name='Myprysm.ImageService.Abstractions.ImageMetadata.ContentType'></a>

## ImageMetadata.ContentType Property

The content type of the image.

```csharp
public string ContentType { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.ImageService.Abstractions.ImageMetadata.Format'></a>

## ImageMetadata.Format Property

The format of the image.

```csharp
public Myprysm.ImageService.Abstractions.ImageFormat Format { get; set; }
```

#### Property Value
[ImageFormat](Myprysm.ImageService.Abstractions.ImageFormat.md 'Myprysm.ImageService.Abstractions.ImageFormat')

<a name='Myprysm.ImageService.Abstractions.ImageMetadata.Size'></a>

## ImageMetadata.Size Property

The size of the image.

```csharp
public Myprysm.ImageService.Abstractions.Size Size { get; set; }
```

#### Property Value
[Size](Myprysm.ImageService.Abstractions.Size.md 'Myprysm.ImageService.Abstractions.Size')