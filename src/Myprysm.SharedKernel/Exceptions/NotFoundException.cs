namespace Myprysm.SharedKernel.Exceptions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents an exceptional case when a resource could not be found during a procedure.
/// </summary>
[ExcludeFromCodeCoverage]
public class NotFoundException : DomainException
{
    /// <summary>
    /// Creates an empty <see cref="NotFoundException"/>.
    /// </summary>
    public NotFoundException()
    {
    }

    /// <summary>
    /// Creates a new <see cref="NotFoundException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    public NotFoundException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Creates a new <see cref="NotFoundException"/> with the provided message.
    /// </summary>
    /// <param name="message">The reason of the conflict.</param>
    /// <param name="innerException">The source exception of the conflict.</param>
    public NotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Creates a new <see cref="NotFoundException"/> with the provided message.
    /// </summary>
    /// <param name="name">The name of the entity that could not be found.</param>
    /// <param name="key">The key that threw the exception for the entity.</param>
    public NotFoundException(string name, object key)
        : base($"Entity \"{name}\" ({key}) was not found.")
    {
    }
}
