#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## BrokerCapabilities Class
Capabilities provided by a broker.  
```csharp
public sealed class BrokerCapabilities :
System.IEquatable<Myprysm.PubSub.Abstractions.BrokerCapabilities>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BrokerCapabilities  

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[BrokerCapabilities](Myprysm_PubSub_Abstractions_BrokerCapabilities.md 'Myprysm.PubSub.Abstractions.BrokerCapabilities')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Constructors
<a name='Myprysm_PubSub_Abstractions_BrokerCapabilities_BrokerCapabilities(Myprysm_PubSub_Abstractions_Transport_bool_bool)'></a>
## BrokerCapabilities.BrokerCapabilities(Transport, bool, bool) Constructor
Capabilities provided by a broker.  
```csharp
public BrokerCapabilities(Myprysm.PubSub.Abstractions.Transport Transport, bool Replay, bool SubscriptionGroups);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_BrokerCapabilities_BrokerCapabilities(Myprysm_PubSub_Abstractions_Transport_bool_bool)_Transport'></a>
`Transport` [Transport](Myprysm_PubSub_Abstractions_Transport.md 'Myprysm.PubSub.Abstractions.Transport')  
The type of transport.
  
<a name='Myprysm_PubSub_Abstractions_BrokerCapabilities_BrokerCapabilities(Myprysm_PubSub_Abstractions_Transport_bool_bool)_Replay'></a>
`Replay` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Indicates whether the broker supports replays (API not specified yet).
  
<a name='Myprysm_PubSub_Abstractions_BrokerCapabilities_BrokerCapabilities(Myprysm_PubSub_Abstractions_Transport_bool_bool)_SubscriptionGroups'></a>
`SubscriptionGroups` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Indicates whether the broker supports subscription groups a.k.a. competing consumers.
  
  
### Properties
<a name='Myprysm_PubSub_Abstractions_BrokerCapabilities_Replay'></a>
## BrokerCapabilities.Replay Property
Indicates whether the broker has replay capabilities   
```csharp
public bool Replay { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
  
<a name='Myprysm_PubSub_Abstractions_BrokerCapabilities_SubscriptionGroups'></a>
## BrokerCapabilities.SubscriptionGroups Property
Indicates whether the broker supports grouped subscriptions (group of competing consumers).  
```csharp
public bool SubscriptionGroups { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
  
<a name='Myprysm_PubSub_Abstractions_BrokerCapabilities_Transport'></a>
## BrokerCapabilities.Transport Property
Indicates the supported transport kinds.  
```csharp
public Myprysm.PubSub.Abstractions.Transport Transport { get; }
```
#### Property Value
[Transport](Myprysm_PubSub_Abstractions_Transport.md 'Myprysm.PubSub.Abstractions.Transport')
  
