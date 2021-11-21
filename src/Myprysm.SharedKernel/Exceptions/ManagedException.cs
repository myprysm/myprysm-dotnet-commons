namespace Myprysm.SharedKernel.Exceptions;

using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
public class ManagedException : Exception
{
    public ManagedException()
    {
    }

    public ManagedException(string message) : base(message)
    {
    }

    public ManagedException(string message, Exception baseException) : base(message, baseException)
    {
    }
}
