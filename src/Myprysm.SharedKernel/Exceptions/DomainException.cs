namespace Myprysm.SharedKernel.Exceptions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents an exceptional case encountered as part of the domain of an application.
///
/// You can an should specialize this exception when an unhandled case happens in your domain.
/// </summary>
[ExcludeFromCodeCoverage]
public class DomainException : ManagedException
{
    /// <summary>
    /// Creates an empty <see cref="DomainException"/>.
    /// </summary>
    public DomainException()
    {
    }

    /// <summary>
    /// Creates a new <see cref="DomainException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    public DomainException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Creates a new <see cref="DomainException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    /// <param name="innerException">The source exception of the conflict.</param>
    public DomainException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
