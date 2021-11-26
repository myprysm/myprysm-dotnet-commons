namespace Myprysm.PubSub.Nats;

using System;
using Microsoft.Extensions.Logging;
using Myprysm.Converter.Abstractions;
using Myprysm.PubSub.Abstractions;
using Myprysm.PubSub.Abstractions.Exceptions;
using Myprysm.Tracing.Abstractions;
using NATS.Client;
using ISubscription = Myprysm.PubSub.Abstractions.ISubscription;

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

    public NatsSubscription(PublicationHandler handler,
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
            var topic = new Topic(subject);
            var envelope = this.converter.Read<Envelope>(args.Message.Data);

            if (envelope is null)
            {
                this.logger.LogError("Envelope is null in handler for subject {Subject}", args.Message.Subject);
                throw new SubscriptionHandlerException($"Envelope is null in handler for subject {args.Message.Subject}");
            }

            if (envelope.Trace is not null && trace is not null)
            {
                trace.SetParentId(envelope.Trace.Id);
                foreach (var (key, value) in envelope.Trace.Baggage)
                {
                    trace.AddBaggage(key, value);
                }
            }

            var message = new Publication(
                topic,
                envelope.Payload,
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
