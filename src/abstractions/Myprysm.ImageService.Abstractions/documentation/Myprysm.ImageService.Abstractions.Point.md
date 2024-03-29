#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions](index.md#Myprysm.ImageService.Abstractions 'Myprysm.ImageService.Abstractions')

## Point Class

Represents a point in a 2-dimensional space.

```csharp
public sealed class Point :
System.IEquatable<Myprysm.ImageService.Abstractions.Point>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Point

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Point](Myprysm.ImageService.Abstractions.Point.md 'Myprysm.ImageService.Abstractions.Point')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')
### Constructors

<a name='Myprysm.ImageService.Abstractions.Point.Point(double,double)'></a>

## Point(double, double) Constructor

Creates a new [Point](Myprysm.ImageService.Abstractions.Point.md 'Myprysm.ImageService.Abstractions.Point').

```csharp
public Point(double x, double y);
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.Point.Point(double,double).x'></a>

`x` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The x coordinate.

<a name='Myprysm.ImageService.Abstractions.Point.Point(double,double).y'></a>

`y` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The y coordinate.
### Properties

<a name='Myprysm.ImageService.Abstractions.Point.X'></a>

## Point.X Property

Gets the x coordinate as double.

```csharp
public double X { get; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='Myprysm.ImageService.Abstractions.Point.XAsInt'></a>

## Point.XAsInt Property

Gets the x coordinate as integer.

```csharp
public int XAsInt { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Myprysm.ImageService.Abstractions.Point.Y'></a>

## Point.Y Property

Gets the y coordinate as double.

```csharp
public double Y { get; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='Myprysm.ImageService.Abstractions.Point.YAsInt'></a>

## Point.YAsInt Property

Gets the y coordinate as integer.

```csharp
public int YAsInt { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')