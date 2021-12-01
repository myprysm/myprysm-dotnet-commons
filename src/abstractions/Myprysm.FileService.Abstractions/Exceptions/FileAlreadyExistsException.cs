namespace Myprysm.FileService.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

/// <summary>
/// Exception thrown when a file already exists at the requested location in an <see cref="IFileService"/>.
/// </summary>
public class FileAlreadyExistsException : ManagedException
{
    /// <summary>
    /// Creates an instance of <see cref="FileAlreadyExistsException"/>.
    /// </summary>
    /// <param name="container">The container in which the existence check happened.</param>
    /// <param name="path">The conflicting path.</param>
    public FileAlreadyExistsException(string container, string path)
        : base($"{container}/{path}")
    {
    }
}
