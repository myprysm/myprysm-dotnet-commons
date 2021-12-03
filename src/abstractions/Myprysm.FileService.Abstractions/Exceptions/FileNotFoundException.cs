namespace Myprysm.FileService.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

/// <summary>
/// Exception thrown when a file cannot be found at the requested location in an <see cref="IFileService"/>.
/// </summary>
public class FileNotFoundException : ManagedException
{
    /// <summary>
    /// Creates an instance of <see cref="FileNotFoundException"/>.
    /// </summary>
    /// <param name="container">The container in which the existence check happened.</param>
    /// <param name="path">The conflicting path.</param>
    public FileNotFoundException(string container, string path)
        : base($"{container}/{path}")
    {
    }
}
