namespace Myprysm.PubSub.Abstractions;

public class PubSubOptions
{
    public bool WithTracing { get; set; } = true;
    
    public SubscriptionExceptionHandler GlobalSubscriptionExceptionHandler = delegate { };
}
