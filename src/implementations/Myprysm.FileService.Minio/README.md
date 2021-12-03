# Myprysm MinIO FileService

Implementation of an [IFileService](../../abstractions/Myprysm.FileService.Abstractions/README.md)
that stores the content in remote MinIO/S3 instance.

## Configuration and usage

You can load the latest version of this file service from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.fileservice.minio).

You can inject the `IFileService` in your application by using the `DependencyInjectionExtensions`.

You should provide the appropriate options to connect to the remote MinIO/S3 instance.

## Documentation

The API documentation is available [here](documentation/index.md).
