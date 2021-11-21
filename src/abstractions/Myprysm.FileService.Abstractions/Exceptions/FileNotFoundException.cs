namespace Myprysm.FileService.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

public class FileNotFoundException : ManagedException
{
    public FileNotFoundException(string message)
        : base(message)
    {
    }
}
