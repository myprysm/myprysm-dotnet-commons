namespace Myprysm.Converter.Abstractions.Exceptions;

using System.Diagnostics.CodeAnalysis;
using Myprysm.SharedKernel.Exceptions;

/// <summary>
/// Exception thrown when an <see cref="IConverter"/> cannot write data.
/// </summary>
[ExcludeFromCodeCoverage]
public class ConversionWriteException : ManagedException
{
    /// <summary>
    /// Create a new <see cref="ConversionWriteException"/> with the provided message.
    /// </summary>
    /// <param name="message">The message.</param>
    public ConversionWriteException(string message) : base(message)
    {
    }

    /// <summary>
    /// Create a new <see cref="ConversionWriteException"/> with the provided message and base exception.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="baseException">The base exception.</param>
    public ConversionWriteException(string message, Exception baseException) : base(message, baseException)
    {
    }
}
