namespace Myprysm.Converter.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

public class ConversionWriteException : ManagedException
{
    public ConversionWriteException(string message, Exception baseException) : base(message, baseException)
    {
    }
}
