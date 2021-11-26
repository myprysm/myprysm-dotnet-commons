namespace Myprysm.PubSub.Abstractions;

using System.Collections.Concurrent;
using System.Diagnostics;

public class PublicationCollectorHandler
{
    private readonly BlockingCollection<Publication> receivedPublications;

    public PublicationCollectorHandler()
    {
        this.receivedPublications = new BlockingCollection<Publication>();
    }

    public Task HandleAsync(Publication publication)
    {
        this.receivedPublications.Add(publication);
        return Task.CompletedTask;
    }

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
