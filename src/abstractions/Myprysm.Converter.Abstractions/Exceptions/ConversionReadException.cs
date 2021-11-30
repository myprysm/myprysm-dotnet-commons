namespace Myprysm.Converter.Abstractions.Exceptions;

using System.Diagnostics.CodeAnalysis;
using Myprysm.SharedKernel.Exceptions;

/// <summary>
/// Exception thrown when an <see cref="IConverter"/> cannot read data.
/// </summary>
[ExcludeFromCodeCoverage]
public class ConversionReadException : ManagedException
{
    /// <summary>
    /// Create a new <see cref="ConversionReadException"/> with the provided message.
    /// </summary>
    /// <param name="message">The message.</param>
    public ConversionReadException(string message) : base(message)
    {
    }

    /// <summary>
    /// Create a new <see cref="ConversionReadException"/> with the provided message and base exception.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="baseException">The base exception.</param>
    public ConversionReadException(string message, Exception baseException) : base(message, baseException)
    {
    }
}
