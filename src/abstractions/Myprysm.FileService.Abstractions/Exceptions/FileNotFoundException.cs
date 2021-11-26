namespace Myprysm.FileService.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

public class FileNotFoundException : ManagedException
{
    public FileNotFoundException(string container, string path)
        : base($"{container}/{path}")
    {
    }
}
