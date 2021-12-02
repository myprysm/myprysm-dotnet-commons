namespace Myprysm.PubSub.Abstractions.Exceptions;

using System.Diagnostics.CodeAnalysis;
using Myprysm.SharedKernel.Exceptions;

/// <summary>
/// Exception thrown when a <see cref="PublicationHandler"/> throws an unmanaged exception.
/// </summary>
[ExcludeFromCodeCoverage]
public class SubscriptionHandlerException : ManagedException
{
    /// <summary>
    /// Creates a new <see cref="SubscriptionHandlerException"/>.
    /// </summary>
    public SubscriptionHandlerException()
    {
    }

    /// <summary>
    /// Creates a new <see cref="SubscriptionHandlerException"/> with the given message.
    /// </summary>
    /// <param name="message">The message.</param>
    public SubscriptionHandlerException(string message) : base(message)
    {
    }

    /// <summary>
    /// Creates a new <see cref="SubscriptionHandlerException"/> with the given message and base exception.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="baseException">The base exception.</param>
    public SubscriptionHandlerException(string message, Exception baseException) : base(message, baseException)
    {
    }
}
