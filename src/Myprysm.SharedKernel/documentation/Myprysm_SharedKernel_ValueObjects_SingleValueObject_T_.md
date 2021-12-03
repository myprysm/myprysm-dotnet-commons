#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.ValueObjects](index.md#Myprysm_SharedKernel_ValueObjects 'Myprysm.SharedKernel.ValueObjects')
## SingleValueObject&lt;T&gt; Class
Represents a value object that holds a single value and cannot or should not be represented by a C# 9.0 record.  
```csharp
public abstract class SingleValueObject<T> : Myprysm.SharedKernel.ValueObjects.ValueObject,
System.IComparable,
Myprysm.SharedKernel.ValueObjects.ISingleValueObject
    where T : System.IComparable
```
#### Type parameters
<a name='Myprysm_SharedKernel_ValueObjects_SingleValueObject_T__T'></a>
`T`  
The type of the value that is held.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ValueObject](Myprysm_SharedKernel_ValueObjects_ValueObject.md 'Myprysm.SharedKernel.ValueObjects.ValueObject') &#129106; SingleValueObject&lt;T&gt;  

Implements [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable'), [ISingleValueObject](Myprysm_SharedKernel_ValueObjects_ISingleValueObject.md 'Myprysm.SharedKernel.ValueObjects.ISingleValueObject')  
### Remarks
See https://github.com/eventflow/EventFlow/blob/develop-v1/Source/EventFlow/ValueObjects/SingleValueObject.cs
### Properties
<a name='Myprysm_SharedKernel_ValueObjects_SingleValueObject_T__Value'></a>
## SingleValueObject&lt;T&gt;.Value Property
The value held by this [SingleValueObject&lt;T&gt;](Myprysm_SharedKernel_ValueObjects_SingleValueObject_T_.md 'Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;T&gt;').  
```csharp
public T Value { get; }
```
#### Property Value
[T](Myprysm_SharedKernel_ValueObjects_SingleValueObject_T_.md#Myprysm_SharedKernel_ValueObjects_SingleValueObject_T__T 'Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;T&gt;.T')
  
### Methods
<a name='Myprysm_SharedKernel_ValueObjects_SingleValueObject_T__CompareTo(object_)'></a>
## SingleValueObject&lt;T&gt;.CompareTo(object?) Method
Compare this [SingleValueObject&lt;T&gt;](Myprysm_SharedKernel_ValueObjects_SingleValueObject_T_.md 'Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;T&gt;') to another object.  
```csharp
public int CompareTo(object? obj);
```
#### Parameters
<a name='Myprysm_SharedKernel_ValueObjects_SingleValueObject_T__CompareTo(object_)_obj'></a>
`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The object to compare to.
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A value indicating whether this object is greater/after, same as, or lesser/before than the other provide object.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  

Implements [CompareTo(object?)](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable.CompareTo#System_IComparable_CompareTo_System_Object_ 'System.IComparable.CompareTo(System.Object)')  
  
<a name='Myprysm_SharedKernel_ValueObjects_SingleValueObject_T__GetValue()'></a>
## SingleValueObject&lt;T&gt;.GetValue() Method
Get the value held, boxed as an object if necessary.  
```csharp
public object GetValue();
```
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value held, boxed as an object if necessary.

Implements [GetValue()](Myprysm_SharedKernel_ValueObjects_ISingleValueObject.md#Myprysm_SharedKernel_ValueObjects_ISingleValueObject_GetValue() 'Myprysm.SharedKernel.ValueObjects.ISingleValueObject.GetValue()')  
  
<a name='Myprysm_SharedKernel_ValueObjects_SingleValueObject_T__ToString()'></a>
## SingleValueObject&lt;T&gt;.ToString() Method
Get the underlying string representation of the value held.  
```csharp
public override string? ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The underlying string representation of the value held.
  
