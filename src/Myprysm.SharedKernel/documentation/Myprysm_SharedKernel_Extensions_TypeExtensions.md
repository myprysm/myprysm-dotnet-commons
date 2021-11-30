#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Extensions](index.md#Myprysm_SharedKernel_Extensions 'Myprysm.SharedKernel.Extensions')
## TypeExtensions Class
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') extensions.  
            
```csharp
public static class TypeExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TypeExtensions  
### Methods
<a name='Myprysm_SharedKernel_Extensions_TypeExtensions_GetAllTypesImplementingOpenGenericType(System_Type_System_Reflection_Assembly)'></a>
## TypeExtensions.GetAllTypesImplementingOpenGenericType(Type, Assembly) Method
Get all types implementing the open generic type in the given assembly.  
```csharp
public static System.Collections.Generic.IEnumerable<System.Type> GetAllTypesImplementingOpenGenericType(this System.Type openGenericType, System.Reflection.Assembly assembly);
```
#### Parameters
<a name='Myprysm_SharedKernel_Extensions_TypeExtensions_GetAllTypesImplementingOpenGenericType(System_Type_System_Reflection_Assembly)_openGenericType'></a>
`openGenericType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The open generic type.
  
<a name='Myprysm_SharedKernel_Extensions_TypeExtensions_GetAllTypesImplementingOpenGenericType(System_Type_System_Reflection_Assembly)_assembly'></a>
`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')  
The assembly.
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The enumeration of all matching types.
  
<a name='Myprysm_SharedKernel_Extensions_TypeExtensions_PrettyPrint(System_Type)'></a>
## TypeExtensions.PrettyPrint(Type) Method
Pretty print this type as a human-readable string.  
```csharp
public static string PrettyPrint(this System.Type type);
```
#### Parameters
<a name='Myprysm_SharedKernel_Extensions_TypeExtensions_PrettyPrint(System_Type)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type to print.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The human-readable representation of this type.
  
