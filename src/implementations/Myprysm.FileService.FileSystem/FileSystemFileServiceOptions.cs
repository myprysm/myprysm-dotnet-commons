namespace Myprysm.FileService.FileSystem;

using Myprysm.FileService.Abstractions;

/// <summary>
/// Options for a <see cref="FileSystemFileService"/>.
/// </summary>
public class FileSystemFileServiceOptions : FileServiceOptions
{
    /// <summary>
    /// The local directory to manage the files. Defaults to the temporary directory.
    /// </summary>
    public string Directory { get; set; } = Path.GetTempPath();
}
