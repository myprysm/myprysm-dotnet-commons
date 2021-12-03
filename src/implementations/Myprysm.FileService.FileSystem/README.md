# Myprysm FileSystem FileService

Implementation of an [IFileService](../../abstractions/Myprysm.FileService.Abstractions/README.md)
that stores the content in a operating system local directory.

## Configuration and usage

You can load the latest version of this file service from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.fileservice.filesystem).

You can inject the `IFileService` in your application by using the `DependencyInjectionExtensions`.

You should provide a custom directory as by default the file service will store the content in the current user's temporary directory.

## Additional Information

While this file service may work with shared file systems (NFS or other protocol), it has not been tested for writes concurrency from multiple
instances in separate processes.

## Documentation

The API documentation is available [here](documentation/index.md).
