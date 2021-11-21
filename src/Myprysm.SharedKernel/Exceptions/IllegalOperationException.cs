namespace Myprysm.SharedKernel.Exceptions;

using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
public class IllegalOperationException : ManagedException
{
    public IllegalOperationException()
    {
    }

    public IllegalOperationException(string message)
        : base(message)
    {
    }

    public IllegalOperationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
