namespace Myprysm.SharedKernel.Exceptions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents an exceptional case
/// when a conflict occurs while processing a resource.
///
/// The conflict can be of any source, e.g. a resource version lock check failed
/// or an identical resource got created/updated at the same time.
/// </summary>
[ExcludeFromCodeCoverage]
public class ConflictException : DomainException
{
    /// <summary>
    /// Creates an empty <see cref="ConflictException"/>.
    /// </summary>
    public ConflictException()
    {
    }

    /// <summary>
    /// Creates a new <see cref="ConflictException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    public ConflictException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Creates a new <see cref="ConflictException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    /// <param name="innerException">The source exception of the conflict.</param>
    public ConflictException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
