namespace Myprysm.PubSub.AzureStorageQueue;

using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

internal class AzureStorageQueueMessageLockHolder : IDisposable
{
    private readonly QueueMessage message;
    private readonly QueueClient queueClient;
    private readonly CancellationTokenSource cancellationTokenSource;
    private bool disposed;

    internal AzureStorageQueueMessageLockHolder(QueueMessage message, QueueClient queueClient)
    {
        this.message = message;
        this.queueClient = queueClient;
        this.cancellationTokenSource = new CancellationTokenSource();
        this.Start();
    }

    private void Start()
    {
        Task.Run(async () =>
            {
                while (!this.cancellationTokenSource.IsCancellationRequested)
                {
                    try
                    {
                        var visibilityTimeSpan = this.message.NextVisibleOn - DateTime.UtcNow;
                        if (!visibilityTimeSpan.HasValue)
                        {
                            return;
                        }

                        var nextRenewInterval = visibilityTimeSpan / 2;
                        await Task.Delay(nextRenewInterval.Value, this.cancellationTokenSource.Token).ConfigureAwait(false);
                        await this.queueClient
                            .UpdateMessageAsync(
                                this.message.MessageId,
                                this.message.PopReceipt,
                                visibilityTimeout: visibilityTimeSpan.Value,
                                cancellationToken: this.cancellationTokenSource.Token)
                            .ConfigureAwait(false);
                    }
                    catch (OperationCanceledException)
                    {
                        return;
                    }
                }
            })
            .ConfigureAwait(false);
    }


    public void Dispose()
    {
        if (this.disposed)
        {
            return;
        }

        this.disposed = true;
        this.cancellationTokenSource.Cancel();
        this.cancellationTokenSource.Dispose();
    }
}
