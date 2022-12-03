#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Extensions](index.md#Myprysm.SharedKernel.Extensions 'Myprysm.SharedKernel.Extensions')

## DictionaryExtensions Class

Extension methods for Dictionary.

```csharp
public static class DictionaryExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DictionaryExtensions
### Methods

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_)'></a>

## DictionaryExtensions.GetOrAdd<TKey,TValue>(this IDictionary<TKey,TValue>, TKey, Func<TKey,TValue>) Method

Gets a value from the dictionary with given key. Returns default value if can not find.

```csharp
public static TValue GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dictionary, TKey key, System.Func<TKey,TValue> factory);
```
#### Type parameters

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).TKey'></a>

`TKey`

Type of the key

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).TValue'></a>

`TValue`

Type of the value
#### Parameters

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).dictionary'></a>

`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TKey,TValue>).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TKey,TValue>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

Dictionary to check and get

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).key'></a>

`key` [TKey](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TKey,TValue>).TKey')

Key to find the value

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).factory'></a>

`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TKey,TValue>).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TKey,TValue>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

A factory method used to create the value if not found in the dictionary

#### Returns
[TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TKey,TValue_).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TKey,TValue>).TValue')  
Value if found, default if can not found.

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_)'></a>

## DictionaryExtensions.GetOrAdd<TKey,TValue>(this IDictionary<TKey,TValue>, TKey, Func<TValue>) Method

Gets a value from the dictionary with given key. Returns default value if can not find.

```csharp
public static TValue GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dictionary, TKey key, System.Func<TValue> factory);
```
#### Type parameters

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).TKey'></a>

`TKey`

Type of the key

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).TValue'></a>

`TValue`

Type of the value
#### Parameters

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).dictionary'></a>

`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TValue>).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TValue>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

Dictionary to check and get

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).key'></a>

`key` [TKey](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TValue>).TKey')

Key to find the value

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).factory'></a>

`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TValue>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

A factory method used to create the value if not found in the dictionary

#### Returns
[TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,System.Func_TValue_).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, System.Func<TValue>).TValue')  
Value if found, default if can not found.

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue)'></a>

## DictionaryExtensions.GetOrAdd<TKey,TValue>(this IDictionary<TKey,TValue>, TKey, TValue) Method

Gets a value from the dictionary with given key. Returns default value if can not find.

```csharp
public static TValue GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dictionary, TKey key, TValue value);
```
#### Type parameters

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TKey'></a>

`TKey`

Type of the key

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TValue'></a>

`TValue`

Type of the value
#### Parameters

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).dictionary'></a>

`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

Dictionary to check and get

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).key'></a>

`key` [TKey](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TKey')

Key to find the value

<a name='Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).value'></a>

`value` [TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TValue')

The value if not present in the dictionary

#### Returns
[TValue](Myprysm.SharedKernel.Extensions.DictionaryExtensions.md#Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue).TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue).TValue')  
Value if found, default if can not found.