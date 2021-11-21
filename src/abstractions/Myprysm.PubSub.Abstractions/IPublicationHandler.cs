namespace Myprysm.PubSub.Abstractions;

public interface IPublicationHandler
{
    Task HandleAsync(Publication publication);
}