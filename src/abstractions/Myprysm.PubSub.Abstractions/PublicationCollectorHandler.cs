namespace Myprysm.PubSub.Abstractions;

using System.Collections.Concurrent;
using System.Diagnostics;

/// <summary>
/// A publication handler that collects the incoming publications. 
/// </summary>
public class PublicationCollectorHandler
{
    private readonly BlockingCollection<Publication> receivedPublications;

    /// <summary>
    /// Creates a new <see cref="PublicationCollectorHandler"/>.0
    /// </summary>
    public PublicationCollectorHandler()
    {
        this.receivedPublications = new BlockingCollection<Publication>();
    }

    /// <summary>
    /// Store the incoming publication.
    /// </summary>
    /// <param name="publication">The incoming publication.</param>
    /// <returns>Succeeds always.</returns>
    public Task HandleAsync(Publication publication)
    {
        this.receivedPublications.Add(publication);
        return Task.CompletedTask;
    }

    /// <summary>
    /// Get the given number of messages from the subscribed topic within the given accepted timeout.
    /// </summary>
    /// <param name="timeout">The timeout before failing the operation.</param>
    /// <param name="count">The number of messages to collect.</param>
    /// <returns>The collected messages.</returns>
    /// <exception cref="TimeoutException">When the collector did not receive enough messages before the timeout.</exception>
    public IReadOnlyCollection<Publication> GetMessages(TimeSpan timeout, int count = 1)
    {
        var publications = new List<Publication>();
        var stopwatch = Stopwatch.StartNew();

        while (publications.Count < count)
        {
            if (stopwatch.Elapsed >= timeout)
            {
                throw new TimeoutException($"Timed out after {stopwatch.Elapsed.TotalSeconds:0.##} seconds");
            }

            if (!this.receivedPublications.TryTake(out var publication, TimeSpan.FromMilliseconds(100)))
            {
                continue;
            }

            publications.Add(publication);
        }

        return publications;
    }
}
