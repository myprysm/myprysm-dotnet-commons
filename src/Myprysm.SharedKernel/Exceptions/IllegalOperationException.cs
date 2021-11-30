namespace Myprysm.SharedKernel.Exceptions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents an illegal operation request in the current procedure. 
/// </summary>
[ExcludeFromCodeCoverage]
public class IllegalOperationException : ManagedException
{
    /// <summary>
    /// Creates an empty <see cref="IllegalOperationException"/>.
    /// </summary>
    public IllegalOperationException()
    {
    }

    /// <summary>
    /// Creates a new <see cref="IllegalOperationException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    public IllegalOperationException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Creates a new <see cref="IllegalOperationException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    /// <param name="innerException">The source exception of the conflict.</param>
    public IllegalOperationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
