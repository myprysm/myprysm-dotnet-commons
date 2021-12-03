namespace Myprysm.PubSub.Abstractions;

using Microsoft.Extensions.Diagnostics.HealthChecks;

/// <summary>
/// Broker <see cref="IHealthCheck"/> to ensure a <see cref="IBrokerConnection"/> instance can work appropriately.
/// </summary>
public class BrokerHealthCheck : IHealthCheck
{
    private static readonly byte[] Message = { 0x01, };
    private static readonly TimeSpan FromSeconds = TimeSpan.FromSeconds(1);

    private readonly IBrokerConnection broker;
    private readonly PublicationCollectorHandler collector;
    private readonly Topic topic;

    /// <summary>
    /// Creates a new <see cref="BrokerHealthCheck"/>.
    /// </summary>
    /// <param name="broker">The broker to verify the health.</param>
    public BrokerHealthCheck(IBrokerConnection broker)
    {
        this.broker = broker;
        this.collector = new PublicationCollectorHandler();
        this.topic = new Topic(Guid.NewGuid().ToString().Replace("-", string.Empty));
    }


    /// <inheritdoc />
    public async Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken cancellationToken = new())
    {
        var ping = await this.Ping(cancellationToken).ConfigureAwait(false);

        return ping ? HealthCheckResult.Healthy() : HealthCheckResult.Unhealthy();
    }

    private async Task<bool> Ping(CancellationToken cancellationToken)
    {
        try
        {
            using var subscription = await this.broker
                .Subscribe(this.topic, this.collector.HandleAsync, cancellation: cancellationToken)
                .ConfigureAwait(false);

            var publication = new Publication(this.topic, Message);
            await this.broker.Publish(publication, cancellationToken).ConfigureAwait(false);

            this.collector.GetMessages(FromSeconds);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
