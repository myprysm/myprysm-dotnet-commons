namespace Myprysm.FileService.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

public class FileAlreadyExistsException : ManagedException
{
    public FileAlreadyExistsException(string container, string path)
        : base($"{container}/{path}")
    {
    }
}
