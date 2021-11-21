namespace Myprysm.PubSub.AzureStorageQueue;

public class AzureStorageQueueBrokerOptions
{
    public string ConnectionString { get; set; } = "UseDevelopmentStorage=true";

    public TimeSpan MaxPollingInterval { get; set; } = TimeSpan.FromSeconds(1);

    public int MaxBatchSize { get; set; } = 32;

    public int MaxDequeueCount { get; set; } = 5;
}
