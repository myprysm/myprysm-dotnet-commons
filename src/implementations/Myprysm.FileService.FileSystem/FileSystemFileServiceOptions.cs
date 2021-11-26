namespace Myprysm.FileService.FileSystem;

using Myprysm.FileService.Abstractions;

public class FileSystemFileServiceOptions : FileServiceOptions
{
    public string Directory { get; set; } = Path.GetTempPath();
}
