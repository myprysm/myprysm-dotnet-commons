#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ValueObjects](index.md#Myprysm_SharedKernel_ValueObjects 'Myprysm.SharedKernel.ValueObjects')
## ValueObject Class
Represents a value object that cannot or should not be represented by a C# 9.0 record.  
```csharp
public abstract class ValueObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValueObject  

Derived  
&#8627; [SingleValueObject&lt;T&gt;](Myprysm_SharedKernel_ValueObjects_SingleValueObject_T_.md 'Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;T&gt;')  
### Remarks
See https://github.com/eventflow/EventFlow/blob/develop-v1/Source/EventFlow/ValueObjects/ValueObject.cs
### Methods
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_Equals(object_)'></a>
## ValueObject.Equals(object?) Method
Verifies that this [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject') is equal to the other object by values.  
```csharp
public override bool Equals(object? obj);
```
#### Parameters
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_Equals(object_)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The other object.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
```csharp
true```
 when both objects are equal by value.
  
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_GetHashCode()'></a>
## ValueObject.GetHashCode() Method
Returns the hash code of this value object,  
using all the available instance/public properties.  
```csharp
public override int GetHashCode();
```
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The hash code for this value object.
  
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_ToString()'></a>
## ValueObject.ToString() Method
Returns a string representation of this value object.  
  
It enumerates a human-readable version of all properties available from [Myprysm.SharedKernel.ValueObjects.ValueObject.GetProperties](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.ValueObject.GetProperties 'Myprysm.SharedKernel.ValueObjects.ValueObject.GetProperties').  
```csharp
public override string? ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
### Operators
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_op_Equality(Myprysm_SharedKernel_ValueObjects_ValueObject__Myprysm_SharedKernel_ValueObjects_ValueObject_)'></a>
## ValueObject.operator ==(ValueObject?, ValueObject?) Operator
Verifies that two [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject') are equal to each other.  
```csharp
public static bool operator ==(Myprysm.SharedKernel.ValueObjects.ValueObject? left, Myprysm.SharedKernel.ValueObjects.ValueObject? right);
```
#### Parameters
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_op_Equality(Myprysm_SharedKernel_ValueObjects_ValueObject__Myprysm_SharedKernel_ValueObjects_ValueObject_)_left'></a>
`left` [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject')  
The left side object.
  
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_op_Equality(Myprysm_SharedKernel_ValueObjects_ValueObject__Myprysm_SharedKernel_ValueObjects_ValueObject_)_right'></a>
`right` [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject')  
The right side object.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
```csharp
true```
 when the left side is equal to the right side by value.
  
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_op_Inequality(Myprysm_SharedKernel_ValueObjects_ValueObject__Myprysm_SharedKernel_ValueObjects_ValueObject_)'></a>
## ValueObject.operator !=(ValueObject?, ValueObject?) Operator
Verifies that two [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject') are different from each other.  
```csharp
public static bool operator !=(Myprysm.SharedKernel.ValueObjects.ValueObject? left, Myprysm.SharedKernel.ValueObjects.ValueObject? right);
```
#### Parameters
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_op_Inequality(Myprysm_SharedKernel_ValueObjects_ValueObject__Myprysm_SharedKernel_ValueObjects_ValueObject_)_left'></a>
`left` [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject')  
The left side object.
  
<a name='Myprysm_SharedKernel_ValueObjects_ValueObject_op_Inequality(Myprysm_SharedKernel_ValueObjects_ValueObject__Myprysm_SharedKernel_ValueObjects_ValueObject_)_right'></a>
`right` [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject')  
The right side object.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
```csharp
true```
 when the left side is equal to the right side by value.
  
