#### [Myprysm.FileService.Abstractions](index.md 'index')
### [Myprysm.FileService.Abstractions](index.md#Myprysm_FileService_Abstractions 'Myprysm.FileService.Abstractions')
## FileDownload Class
A [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') file downloaded from an [IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService').  
```csharp
public class FileDownload :
System.IDisposable,
System.IEquatable<Myprysm.FileService.Abstractions.FileDownload>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FileDownload  

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[FileDownload](Myprysm_FileService_Abstractions_FileDownload.md 'Myprysm.FileService.Abstractions.FileDownload')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Remarks
You can extend this record if you need a custom way of disposing resources.  
### Constructors
<a name='Myprysm_FileService_Abstractions_FileDownload_FileDownload(System_IO_Stream_Myprysm_FileService_Abstractions_ValueObjects_ETag_NodaTime_Instant_long)'></a>
## FileDownload.FileDownload(Stream, ETag, Instant, long) Constructor
A [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') file downloaded from an [IFileService](Myprysm_FileService_Abstractions_IFileService.md 'Myprysm.FileService.Abstractions.IFileService').  
```csharp
public FileDownload(System.IO.Stream Stream, Myprysm.FileService.Abstractions.ValueObjects.ETag ETag, NodaTime.Instant LastModified, long ContentLength);
```
#### Parameters
<a name='Myprysm_FileService_Abstractions_FileDownload_FileDownload(System_IO_Stream_Myprysm_FileService_Abstractions_ValueObjects_ETag_NodaTime_Instant_long)_Stream'></a>
`Stream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')  
The stream content of the file.
  
<a name='Myprysm_FileService_Abstractions_FileDownload_FileDownload(System_IO_Stream_Myprysm_FileService_Abstractions_ValueObjects_ETag_NodaTime_Instant_long)_ETag'></a>
`ETag` [ETag](Myprysm_FileService_Abstractions_ValueObjects_ETag.md 'Myprysm.FileService.Abstractions.ValueObjects.ETag')  
The [Myprysm.FileService.Abstractions.FileDownload.ETag](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.FileDownload.ETag 'Myprysm.FileService.Abstractions.FileDownload.ETag').
  
<a name='Myprysm_FileService_Abstractions_FileDownload_FileDownload(System_IO_Stream_Myprysm_FileService_Abstractions_ValueObjects_ETag_NodaTime_Instant_long)_LastModified'></a>
`LastModified` [NodaTime.Instant](https://docs.microsoft.com/en-us/dotnet/api/NodaTime.Instant 'NodaTime.Instant')  
The date the file has been modified for the last time.
  
<a name='Myprysm_FileService_Abstractions_FileDownload_FileDownload(System_IO_Stream_Myprysm_FileService_Abstractions_ValueObjects_ETag_NodaTime_Instant_long)_ContentLength'></a>
`ContentLength` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The lenght of the content.
  
### Remarks
You can extend this record if you need a custom way of disposing resources.  
  
### Methods
<a name='Myprysm_FileService_Abstractions_FileDownload_Dispose()'></a>
## FileDownload.Dispose() Method
Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
```csharp
public virtual void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')  
  
