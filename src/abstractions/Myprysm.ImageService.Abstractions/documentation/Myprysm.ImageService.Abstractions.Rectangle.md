#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions](index.md#Myprysm.ImageService.Abstractions 'Myprysm.ImageService.Abstractions')

## Rectangle Class

Represents a rectangle with an origin [Point](Myprysm.ImageService.Abstractions.Rectangle.md#Myprysm.ImageService.Abstractions.Rectangle.Point 'Myprysm.ImageService.Abstractions.Rectangle.Point') and a [Size](Myprysm.ImageService.Abstractions.Rectangle.md#Myprysm.ImageService.Abstractions.Rectangle.Size 'Myprysm.ImageService.Abstractions.Rectangle.Size') dimension.

```csharp
public sealed class Rectangle :
System.IEquatable<Myprysm.ImageService.Abstractions.Rectangle>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Rectangle

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Rectangle](Myprysm.ImageService.Abstractions.Rectangle.md 'Myprysm.ImageService.Abstractions.Rectangle')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')
### Constructors

<a name='Myprysm.ImageService.Abstractions.Rectangle.Rectangle(Myprysm.ImageService.Abstractions.Point,Myprysm.ImageService.Abstractions.Size)'></a>

## Rectangle(Point, Size) Constructor

Represents a rectangle with an origin [Point](Myprysm.ImageService.Abstractions.Rectangle.md#Myprysm.ImageService.Abstractions.Rectangle.Point 'Myprysm.ImageService.Abstractions.Rectangle.Point') and a [Size](Myprysm.ImageService.Abstractions.Rectangle.md#Myprysm.ImageService.Abstractions.Rectangle.Size 'Myprysm.ImageService.Abstractions.Rectangle.Size') dimension.

```csharp
public Rectangle(Myprysm.ImageService.Abstractions.Point Point, Myprysm.ImageService.Abstractions.Size Size);
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.Rectangle.Rectangle(Myprysm.ImageService.Abstractions.Point,Myprysm.ImageService.Abstractions.Size).Point'></a>

`Point` [Point](Myprysm.ImageService.Abstractions.Point.md 'Myprysm.ImageService.Abstractions.Point')

The origin of the rectangle.

<a name='Myprysm.ImageService.Abstractions.Rectangle.Rectangle(Myprysm.ImageService.Abstractions.Point,Myprysm.ImageService.Abstractions.Size).Size'></a>

`Size` [Size](Myprysm.ImageService.Abstractions.Size.md 'Myprysm.ImageService.Abstractions.Size')

The size of the rectangle.
### Properties

<a name='Myprysm.ImageService.Abstractions.Rectangle.Point'></a>

## Rectangle.Point Property

The origin of the rectangle.

```csharp
public Myprysm.ImageService.Abstractions.Point Point { get; set; }
```

#### Property Value
[Point](Myprysm.ImageService.Abstractions.Point.md 'Myprysm.ImageService.Abstractions.Point')

<a name='Myprysm.ImageService.Abstractions.Rectangle.Size'></a>

## Rectangle.Size Property

The size of the rectangle.

```csharp
public Myprysm.ImageService.Abstractions.Size Size { get; set; }
```

#### Property Value
[Size](Myprysm.ImageService.Abstractions.Size.md 'Myprysm.ImageService.Abstractions.Size')