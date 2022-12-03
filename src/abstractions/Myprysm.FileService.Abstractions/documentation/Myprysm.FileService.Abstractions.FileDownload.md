#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions](index.md#Myprysm.FileService.Abstractions 'Myprysm.FileService.Abstractions')

## FileDownload Class

A [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') file downloaded from an [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService').

```csharp
public class FileDownload :
System.IDisposable,
System.IEquatable<Myprysm.FileService.Abstractions.FileDownload>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FileDownload

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[FileDownload](Myprysm.FileService.Abstractions.FileDownload.md 'Myprysm.FileService.Abstractions.FileDownload')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
You can extend this record if you need a custom way of disposing resources.
### Constructors

<a name='Myprysm.FileService.Abstractions.FileDownload.FileDownload(System.IO.Stream,Myprysm.FileService.Abstractions.ValueObjects.ETag,NodaTime.Instant,long)'></a>

## FileDownload(Stream, ETag, Instant, long) Constructor

A [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') file downloaded from an [IFileService](Myprysm.FileService.Abstractions.IFileService.md 'Myprysm.FileService.Abstractions.IFileService').

```csharp
public FileDownload(System.IO.Stream Stream, Myprysm.FileService.Abstractions.ValueObjects.ETag ETag, NodaTime.Instant LastModified, long ContentLength);
```
#### Parameters

<a name='Myprysm.FileService.Abstractions.FileDownload.FileDownload(System.IO.Stream,Myprysm.FileService.Abstractions.ValueObjects.ETag,NodaTime.Instant,long).Stream'></a>

`Stream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The stream content of the file.

<a name='Myprysm.FileService.Abstractions.FileDownload.FileDownload(System.IO.Stream,Myprysm.FileService.Abstractions.ValueObjects.ETag,NodaTime.Instant,long).ETag'></a>

`ETag` [ETag](Myprysm.FileService.Abstractions.ValueObjects.ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag')

The [ETag](Myprysm.FileService.Abstractions.FileDownload.md#Myprysm.FileService.Abstractions.FileDownload.ETag 'Myprysm.FileService.Abstractions.FileDownload.ETag').

<a name='Myprysm.FileService.Abstractions.FileDownload.FileDownload(System.IO.Stream,Myprysm.FileService.Abstractions.ValueObjects.ETag,NodaTime.Instant,long).LastModified'></a>

`LastModified` [NodaTime.Instant](https://docs.microsoft.com/en-us/dotnet/api/NodaTime.Instant 'NodaTime.Instant')

The date the file has been modified for the last time.

<a name='Myprysm.FileService.Abstractions.FileDownload.FileDownload(System.IO.Stream,Myprysm.FileService.Abstractions.ValueObjects.ETag,NodaTime.Instant,long).ContentLength'></a>

`ContentLength` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The lenght of the content.

### Remarks
You can extend this record if you need a custom way of disposing resources.
### Properties

<a name='Myprysm.FileService.Abstractions.FileDownload.ContentLength'></a>

## FileDownload.ContentLength Property

The lenght of the content.

```csharp
public long ContentLength { get; set; }
```

#### Property Value
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

<a name='Myprysm.FileService.Abstractions.FileDownload.ETag'></a>

## FileDownload.ETag Property

The [ETag](Myprysm.FileService.Abstractions.FileDownload.md#Myprysm.FileService.Abstractions.FileDownload.ETag 'Myprysm.FileService.Abstractions.FileDownload.ETag').

```csharp
public Myprysm.FileService.Abstractions.ValueObjects.ETag ETag { get; set; }
```

#### Property Value
[ETag](Myprysm.FileService.Abstractions.ValueObjects.ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag')

<a name='Myprysm.FileService.Abstractions.FileDownload.LastModified'></a>

## FileDownload.LastModified Property

The date the file has been modified for the last time.

```csharp
public NodaTime.Instant LastModified { get; set; }
```

#### Property Value
[NodaTime.Instant](https://docs.microsoft.com/en-us/dotnet/api/NodaTime.Instant 'NodaTime.Instant')

<a name='Myprysm.FileService.Abstractions.FileDownload.Stream'></a>

## FileDownload.Stream Property

The stream content of the file.

```csharp
public System.IO.Stream Stream { get; set; }
```

#### Property Value
[System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')
### Methods

<a name='Myprysm.FileService.Abstractions.FileDownload.Dispose()'></a>

## FileDownload.Dispose() Method

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public virtual void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')