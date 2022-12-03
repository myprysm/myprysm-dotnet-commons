#### [Myprysm.PubSub.AzureStorageQueue](index.md 'index')
### [Myprysm.PubSub.AzureStorageQueue](index.md#Myprysm.PubSub.AzureStorageQueue 'Myprysm.PubSub.AzureStorageQueue')

## AzureStorageQueuePubSubOptions Class

[AzureStorageQueueBrokerConnection](Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection') options to send and receive [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication').

```csharp
public class AzureStorageQueuePubSubOptions : Myprysm.PubSub.Abstractions.PubSubOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.PubSub.Abstractions.PubSubOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.PubSubOptions 'Myprysm.PubSub.Abstractions.PubSubOptions') &#129106; AzureStorageQueuePubSubOptions
### Properties

<a name='Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions.ConnectionString'></a>

## AzureStorageQueuePubSubOptions.ConnectionString Property

Gets or sets the connection string to the Azure Storage account.

```csharp
public string ConnectionString { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
Defaults to the development storage.

<a name='Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions.MaxBatchSize'></a>

## AzureStorageQueuePubSubOptions.MaxBatchSize Property

Gets or sets the maximum number of messages to process in a single batch.

```csharp
public int MaxBatchSize { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions.MaxDequeueCount'></a>

## AzureStorageQueuePubSubOptions.MaxDequeueCount Property

Gets or sets the maximum number of times before a message is move to the related `poison` queue.

```csharp
public int MaxDequeueCount { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions.MaxPollingInterval'></a>

## AzureStorageQueuePubSubOptions.MaxPollingInterval Property

Gets or sets the maximum interval between two checks for a message on a given queue.  
The subscriptions will

```csharp
public System.TimeSpan MaxPollingInterval { get; set; }
```

#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')