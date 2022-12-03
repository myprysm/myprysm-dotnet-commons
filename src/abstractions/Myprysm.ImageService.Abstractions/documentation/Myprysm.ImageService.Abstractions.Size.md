#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions](index.md#Myprysm.ImageService.Abstractions 'Myprysm.ImageService.Abstractions')

## Size Class

Represents a size as a rectangle of a given width and height.

```csharp
public sealed class Size :
System.IEquatable<Myprysm.ImageService.Abstractions.Size>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Size

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Size](Myprysm.ImageService.Abstractions.Size.md 'Myprysm.ImageService.Abstractions.Size')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')
### Constructors

<a name='Myprysm.ImageService.Abstractions.Size.Size(double,double)'></a>

## Size(double, double) Constructor

Creates a new [Size](Myprysm.ImageService.Abstractions.Size.md 'Myprysm.ImageService.Abstractions.Size').

```csharp
public Size(double width, double height);
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.Size.Size(double,double).width'></a>

`width` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The width.

<a name='Myprysm.ImageService.Abstractions.Size.Size(double,double).height'></a>

`height` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The height.
### Properties

<a name='Myprysm.ImageService.Abstractions.Size.Height'></a>

## Size.Height Property

Gets the height as double.

```csharp
public double Height { get; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='Myprysm.ImageService.Abstractions.Size.HeightAsInt'></a>

## Size.HeightAsInt Property

Gets the height as integer.

```csharp
public int HeightAsInt { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Myprysm.ImageService.Abstractions.Size.Width'></a>

## Size.Width Property

Gets the width as double.

```csharp
public double Width { get; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='Myprysm.ImageService.Abstractions.Size.WidthAsInt'></a>

## Size.WidthAsInt Property

Gets the width as integer.

```csharp
public int WidthAsInt { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')