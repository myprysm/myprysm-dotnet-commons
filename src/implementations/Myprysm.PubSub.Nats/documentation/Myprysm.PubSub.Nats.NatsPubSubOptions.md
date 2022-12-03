#### [Myprysm.PubSub.Nats](index.md 'index')
### [Myprysm.PubSub.Nats](index.md#Myprysm.PubSub.Nats 'Myprysm.PubSub.Nats')

## NatsPubSubOptions Class

[NatsBrokerConnection](Myprysm.PubSub.Nats.NatsBrokerConnection.md 'Myprysm.PubSub.Nats.NatsBrokerConnection') options to send and receive [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication').

```csharp
public class NatsPubSubOptions : Myprysm.PubSub.Abstractions.PubSubOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.PubSub.Abstractions.PubSubOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.PubSubOptions 'Myprysm.PubSub.Abstractions.PubSubOptions') &#129106; NatsPubSubOptions
### Properties

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.KeyStorePassword'></a>

## NatsPubSubOptions.KeyStorePassword Property

Gets or sets the keystore password for the underlying NATS connection.

```csharp
public string KeyStorePassword { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.KeyStorePath'></a>

## NatsPubSubOptions.KeyStorePath Property

Gets or sets the keystore path for the underlying NATS connection.

```csharp
public string KeyStorePath { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.Password'></a>

## NatsPubSubOptions.Password Property

Gets or sets the password for the underlying NATS connection.

```csharp
public string Password { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.TrustAllCertificates'></a>

## NatsPubSubOptions.TrustAllCertificates Property

Disables TLS/SSL certificates validation.

```csharp
public bool TrustAllCertificates { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
Use only for development or at your own risks.

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.TrustStorePassword'></a>

## NatsPubSubOptions.TrustStorePassword Property

Gets or sets the truststore password for the underlying NATS connection.

```csharp
public string TrustStorePassword { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.TrustStorePath'></a>

## NatsPubSubOptions.TrustStorePath Property

Gets or sets the truststore path for the underlying NATS connection.

```csharp
public string TrustStorePath { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.Url'></a>

## NatsPubSubOptions.Url Property

Gets or sets the URL for the underlying NATS connection.

```csharp
public string Url { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.User'></a>

## NatsPubSubOptions.User Property

Gets or sets the user for the underlying NATS connection.

```csharp
public string User { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Nats.NatsPubSubOptions.WithSsl'></a>

## NatsPubSubOptions.WithSsl Property

Enables TLS/SSL for the underlying NATS connection.

```csharp
public bool WithSsl { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')