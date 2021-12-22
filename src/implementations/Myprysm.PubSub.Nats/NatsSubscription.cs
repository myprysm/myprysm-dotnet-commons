namespace Myprysm.PubSub.Nats;

using System;
using System.Collections.Immutable;
using Microsoft.Extensions.Logging;
using Myprysm.Converter.Abstractions;
using Myprysm.PubSub.Abstractions;
using Myprysm.PubSub.Abstractions.Exceptions;
using Myprysm.Tracing.Abstractions;
using NATS.Client;
using ISubscription = Myprysm.PubSub.Abstractions.ISubscription;

/// <summary>
/// <see cref="ISubscription"/> that receives <see cref="Publication"/> sent by a <see href="https://nats.io/">NATS</see> <see cref="IBrokerConnection"/>.
/// </summary>
public sealed class NatsSubscription : ISubscription
{
    private readonly IAsyncSubscription subscription;
    private readonly bool tracingEnabled;
    private readonly ITracer tracer;
    private readonly ILogger<NatsSubscription> logger;
    private readonly PublicationHandler handler;
    private readonly SubscriptionExceptionHandler exceptionHandler;
    private readonly IConverter converter;
    private readonly Action onDispose;
    private bool disposed;

    internal NatsSubscription(PublicationHandler handler,
        SubscriptionExceptionHandler exceptionHandler,
        IAsyncSubscription subscription,
        bool tracingEnabled,
        IConverter converter,
        ITracer tracer,
        ILogger<NatsSubscription> logger,
        Action onDispose)
    {
        this.subscription = subscription;
        this.tracingEnabled = tracingEnabled;
        this.tracer = tracer;
        this.logger = logger;
        this.handler = handler;
        this.exceptionHandler = exceptionHandler;
        this.converter = converter;
        this.onDispose = onDispose;

        this.subscription.MessageHandler += this.HandleMessage;
        this.subscription.Start();
    }

    private async void HandleMessage(object? _, MsgHandlerEventArgs args)
    {
        using var trace = this.tracingEnabled
            ? this.tracer.StartTrace(nameof(this.HandleMessage), TraceKind.Consumer)
            : null;
        trace?.AddTag("nats_subscription.topic", args.Message.Subject);

        try
        {
            var subject = args.Message.Subject;

            var headers = default(IDictionary<string, string?>?);
            var topic = new Topic(subject);
            if (args.Message.HasHeaders)
            {
                if (args.Message.Header[PubSubNatsConstants.TraceIdHeader] is not null)
                {
                    var traceId = args.Message.Header[PubSubNatsConstants.TraceIdHeader];
                    var traceBaggageValue = args.Message.Header[PubSubNatsConstants.TraceBaggageHeader];
                    var traceBaggage = this.converter.Read<IDictionary<string, string?>>(traceBaggageValue) ?? ImmutableDictionary<string, string?>.Empty;

                    trace?.SetParentId(traceId);
                    foreach (var (key, value) in traceBaggage)
                    {
                        trace?.AddBaggage(key, value);
                    }
                }

                headers = new Dictionary<string, string?>(args.Message.Header.Count);
                foreach (string h in args.Message.Header)
                {
                    if (PubSubNatsConstants.ProtectedHeaders.Contains(h))
                    {
                        continue;
                    }

                    if (args.Message.Header[h] == string.Empty)
                    {
                        headers[h] = null;
                    }
                    else
                    {
                        headers[h] = args.Message.Header[h];
                    }
                }
            }

            var message = new Publication(
                topic,
                args.Message.Data,
                Headers: headers,
                Trace: trace);

            await this.handler.Invoke(message).ConfigureAwait(false);
        }
        catch (SubscriptionHandlerException exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", exception.Message);

            this.exceptionHandler(exception);
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "Error while processing publication on topic {Topic}", args.Message.Subject);
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");

            this.exceptionHandler(exception);
        }
    }

    /// <inheritdoc />
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
