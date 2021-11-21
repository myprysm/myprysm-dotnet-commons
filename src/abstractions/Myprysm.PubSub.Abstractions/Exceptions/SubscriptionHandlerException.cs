namespace Myprysm.PubSub.Abstractions.Exceptions;

using System.Diagnostics.CodeAnalysis;
using Myprysm.SharedKernel.Exceptions;

[ExcludeFromCodeCoverage]
public class SubscriptionHandlerException : ManagedException
{
    public SubscriptionHandlerException()
    {
    }

    public SubscriptionHandlerException(string message) : base(message)
    {
    }

    public SubscriptionHandlerException(string message, Exception baseException) : base(message, baseException)
    {
    }
}
