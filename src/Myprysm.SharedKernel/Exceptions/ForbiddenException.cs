namespace Myprysm.SharedKernel.Exceptions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents an exceptional case when the current user cannot perform the requested procedure.
/// </summary>
[ExcludeFromCodeCoverage]
public class ForbiddenException : DomainException
{
    /// <summary>
    /// Creates an empty <see cref="ForbiddenException"/>.
    /// </summary>
    public ForbiddenException()
    {
    }

    /// <summary>
    /// Creates a new <see cref="ForbiddenException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    public ForbiddenException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Creates a new <see cref="ForbiddenException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    /// <param name="innerException">The source exception of the conflict.</param>
    public ForbiddenException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
