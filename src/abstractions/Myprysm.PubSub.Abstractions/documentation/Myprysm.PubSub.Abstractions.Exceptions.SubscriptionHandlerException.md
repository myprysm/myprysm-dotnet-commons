#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions.Exceptions](index.md#Myprysm.PubSub.Abstractions.Exceptions 'Myprysm.PubSub.Abstractions.Exceptions')

## SubscriptionHandlerException Class

Exception thrown when a [PublicationHandler(Publication)](Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication).md 'Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication)') throws an unmanaged exception.

```csharp
public class SubscriptionHandlerException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [Myprysm.SharedKernel.Exceptions.ManagedException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.ManagedException 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; SubscriptionHandlerException
### Constructors

<a name='Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.SubscriptionHandlerException()'></a>

## SubscriptionHandlerException() Constructor

Creates a new [SubscriptionHandlerException](Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.md 'Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException').

```csharp
public SubscriptionHandlerException();
```

<a name='Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.SubscriptionHandlerException(string,System.Exception)'></a>

## SubscriptionHandlerException(string, Exception) Constructor

Creates a new [SubscriptionHandlerException](Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.md 'Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException') with the given message and base exception.

```csharp
public SubscriptionHandlerException(string message, System.Exception baseException);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.SubscriptionHandlerException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

<a name='Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.SubscriptionHandlerException(string,System.Exception).baseException'></a>

`baseException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The base exception.

<a name='Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.SubscriptionHandlerException(string)'></a>

## SubscriptionHandlerException(string) Constructor

Creates a new [SubscriptionHandlerException](Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.md 'Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException') with the given message.

```csharp
public SubscriptionHandlerException(string message);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.SubscriptionHandlerException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.