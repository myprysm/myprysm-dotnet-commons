#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Extensions](index.md#Myprysm_SharedKernel_Extensions 'Myprysm.SharedKernel.Extensions')
## DictionaryExtensions Class
Extension methods for Dictionary.  
```csharp
public static class DictionaryExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DictionaryExtensions  
### Methods
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)'></a>
## DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, Func&lt;TKey,TValue&gt;) Method
Gets a value from the dictionary with given key. Returns default value if can not find.  
```csharp
public static TValue GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dictionary, TKey key, System.Func<TKey,TValue> factory);
```
#### Type parameters
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_TKey'></a>
`TKey`  
Type of the key
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_TValue'></a>
`TValue`  
Type of the value
  
#### Parameters
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_dictionary'></a>
`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TKey,TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TKey,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to check and get
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_key'></a>
`key` [TKey](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TKey,TValue&gt;).TKey')  
Key to find the value
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_factory'></a>
`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TKey,TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TKey,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
A factory method used to create the value if not found in the dictionary
  
#### Returns
[TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TKey_TValue_)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TKey,TValue&gt;).TValue')  
Value if found, default if can not found.
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)'></a>
## DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, Func&lt;TValue&gt;) Method
Gets a value from the dictionary with given key. Returns default value if can not find.  
```csharp
public static TValue GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dictionary, TKey key, System.Func<TValue> factory);
```
#### Type parameters
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_TKey'></a>
`TKey`  
Type of the key
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_TValue'></a>
`TValue`  
Type of the value
  
#### Parameters
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_dictionary'></a>
`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to check and get
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_key'></a>
`key` [TKey](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue&gt;).TKey')  
Key to find the value
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_factory'></a>
`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
A factory method used to create the value if not found in the dictionary
  
#### Returns
[TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_System_Func_TValue_)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, System.Func&lt;TValue&gt;).TValue')  
Value if found, default if can not found.
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)'></a>
## DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, TKey, TValue) Method
Gets a value from the dictionary with given key. Returns default value if can not find.  
```csharp
public static TValue GetOrAdd<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> dictionary, TKey key, TValue value);
```
#### Type parameters
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TKey'></a>
`TKey`  
Type of the key
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TValue'></a>
`TValue`  
Type of the value
  
#### Parameters
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_dictionary'></a>
`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
Dictionary to check and get
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_key'></a>
`key` [TKey](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TKey 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TKey')  
Key to find the value
  
<a name='Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_value'></a>
`value` [TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')  
The value if not present in the dictionary
  
#### Returns
[TValue](Myprysm_SharedKernel_Extensions_DictionaryExtensions.md#Myprysm_SharedKernel_Extensions_DictionaryExtensions_GetOrAdd_TKey_TValue_(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue)_TValue 'Myprysm.SharedKernel.Extensions.DictionaryExtensions.GetOrAdd&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue).TValue')  
Value if found, default if can not found.
  
