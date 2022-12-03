#### [Myprysm.FileService.Minio](index.md 'index')
### [Myprysm.FileService.Minio](index.md#Myprysm.FileService.Minio 'Myprysm.FileService.Minio')

## MinioFileServiceOptions Class

[MinioFileService](Myprysm.FileService.Minio.MinioFileService.md 'Myprysm.FileService.Minio.MinioFileService') options to manage files with a remote MinIO/S3 instance.

```csharp
public class MinioFileServiceOptions : Myprysm.FileService.Abstractions.FileServiceOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.FileService.Abstractions.FileServiceOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.FileService.Abstractions.FileServiceOptions 'Myprysm.FileService.Abstractions.FileServiceOptions') &#129106; MinioFileServiceOptions
### Properties

<a name='Myprysm.FileService.Minio.MinioFileServiceOptions.AccessKey'></a>

## MinioFileServiceOptions.AccessKey Property

Gets or sets the remote MinIO/S3 access key.

```csharp
public string AccessKey { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.FileService.Minio.MinioFileServiceOptions.Endpoint'></a>

## MinioFileServiceOptions.Endpoint Property

Gets or sets the remote MinIO/S3 endpoint.

```csharp
public string Endpoint { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.FileService.Minio.MinioFileServiceOptions.Region'></a>

## MinioFileServiceOptions.Region Property

Gets or sets the remote MinIO/S3 region.

```csharp
public string Region { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.FileService.Minio.MinioFileServiceOptions.SecretKey'></a>

## MinioFileServiceOptions.SecretKey Property

Gets or sets the remote MinIO/S3 secret key.

```csharp
public string SecretKey { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.FileService.Minio.MinioFileServiceOptions.WithSsl'></a>

## MinioFileServiceOptions.WithSsl Property

Enables SSL/TLS with the remote MinIO/S3 instance.

```csharp
public bool WithSsl { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')