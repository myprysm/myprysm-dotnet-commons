# Myprysm MinIO ImageService

Implementation of an [IImageService](../../abstractions/Myprysm.ImageService.Abstractions/README.md)
that stores the content in remote MinIO/S3 instance.

## Configuration and usage

You can load the latest version of this converter from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.imageservice.imagesharp).

You can inject the `IImageService` in your application by using the `DependencyInjectionExtensions`.

You may provide a custom `MemoryPoolKind` depending on your hosting requirements.

## Documentation

The API documentation is available [here](documentation/index.md).
