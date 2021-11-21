namespace Myprysm.FileService.FileSystem;

public class FileSystemFileServiceOptions
{
    public string Directory { get; set; } = Path.GetTempPath();
}
