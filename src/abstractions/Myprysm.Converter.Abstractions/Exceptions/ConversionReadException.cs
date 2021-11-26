namespace Myprysm.Converter.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

public class ConversionReadException : ManagedException
{
    public ConversionReadException(string message, Exception baseException) : base(message, baseException)
    {
    }
}
