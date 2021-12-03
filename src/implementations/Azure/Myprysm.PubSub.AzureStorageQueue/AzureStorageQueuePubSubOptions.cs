namespace Myprysm.PubSub.AzureStorageQueue;

using Myprysm.PubSub.Abstractions;

/// <summary>
/// <see cref="AzureStorageQueueBrokerConnection"/> options to send and receive <see cref="Publication"/>.
/// </summary>
public class AzureStorageQueuePubSubOptions : PubSubOptions
{
    /// <summary>
    /// Gets or sets the connection string to the Azure Storage account.
    /// </summary>
    /// <remarks>
    /// Defaults to the development storage.
    /// </remarks>
    public string ConnectionString { get; set; } = "UseDevelopmentStorage=true";

    /// <summary>
    /// Gets or sets the maximum interval between two checks for a message on a given queue.
    /// The subscriptions will
    /// </summary>
    public TimeSpan MaxPollingInterval { get; set; } = TimeSpan.FromSeconds(1);

    /// <summary>
    /// Gets or sets the maximum number of messages to process in a single batch.
    /// </summary>
    public int MaxBatchSize { get; set; } = 32;

    /// <summary>
    /// Gets or sets the maximum number of times before a message is move to the related `poison` queue.
    /// </summary>
    public int MaxDequeueCount { get; set; } = 5;
}
