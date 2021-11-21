namespace Myprysm.PubSub.Nats;

using System;
using NATS.Client;
using ISubscription = Myprysm.PubSub.Abstractions.ISubscription;

public sealed class NatsSubscription : ISubscription
{
    private readonly IAsyncSubscription subscription;
    private readonly Action onDispose;
    private bool disposed;

    public NatsSubscription(IAsyncSubscription subscription, Action onDispose)
    {
        this.subscription = subscription;
        this.onDispose = onDispose;
    }
        
    public void Dispose()
    {
        if (this.disposed)
        {
            return;
        }
            
        this.disposed = true;
        this.subscription.Dispose();
        this.onDispose();
    }
}