namespace Myprysm.PubSub.AzureStorageQueue;

using Myprysm.PubSub.Abstractions;

public class AzureStorageQueuePubSubOptions : PubSubOptions
{
    public string ConnectionString { get; set; } = "UseDevelopmentStorage=true";

    public TimeSpan MaxPollingInterval { get; set; } = TimeSpan.FromSeconds(1);

    public int MaxBatchSize { get; set; } = 32;

    public int MaxDequeueCount { get; set; } = 5;
}
