namespace Myprysm.SharedKernel.Exceptions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents an exceptional case that is considered to be managed in the context of the application.
/// </summary>
[ExcludeFromCodeCoverage]
public class ManagedException : Exception
{
    /// <summary>
    /// Creates an empty <see cref="ManagedException"/>.
    /// </summary>
    public ManagedException()
    {
    }

    /// <summary>
    /// Creates a new <see cref="ManagedException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    public ManagedException(string message) : base(message)
    {
    }

    /// <summary>
    /// Creates a new <see cref="ManagedException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    /// <param name="innerException">The source exception of the conflict.</param>
    public ManagedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
