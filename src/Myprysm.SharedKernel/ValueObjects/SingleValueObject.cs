// The MIT License (MIT)
// 
// Copyright (c) 2015-2018 Rasmus Mikkelsen
// Copyright (c) 2015-2018 eBay Software Foundation
// https://github.com/eventflow/EventFlow
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Myprysm.SharedKernel.ValueObjects;

using System.Reflection;
using Myprysm.SharedKernel.Extensions;

/// <summary>
/// Represents a value object that holds a single value and cannot or should not be represented by a C# 9.0 record.
/// </summary>
/// <remarks>See https://github.com/eventflow/EventFlow/blob/develop-v1/Source/EventFlow/ValueObjects/SingleValueObject.cs</remarks>
/// <typeparam name="T">The type of the value that is held.</typeparam>
public abstract class SingleValueObject<T> : ValueObject, IComparable, ISingleValueObject
    where T : IComparable
{
    private static readonly Type Type = typeof(T);
    private static readonly TypeInfo TypeInfo = typeof(T).GetTypeInfo();

    /// <summary>
    /// Creates a <see cref="SingleValueObject{T}"/> holding a value of the provided type.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <exception cref="ArgumentException">
    /// When the value is an enum and the provided value is not part of the enum.
    /// </exception>
    protected SingleValueObject(T value)
    {
        if (TypeInfo.IsEnum && !Enum.IsDefined(Type, value))
        {
            throw new ArgumentException($"The value '{value}' isn't defined in enum '{Type.PrettyPrint()}'");
        }

        this.Value = value;
    }

    /// <summary>
    /// The value held by this <see cref="SingleValueObject{T}"/>.
    /// </summary>
    public T Value { get; }

    /// <summary>
    /// Compare this <see cref="SingleValueObject{T}"/> to another object.
    /// </summary>
    /// <param name="obj">The object to compare to.</param>
    /// <returns>A value indicating whether this object is greater/after, same as, or lesser/before than the other provide object.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            throw new ArgumentNullException(nameof(obj));
        }

        var other = obj as SingleValueObject<T>;
        if (other == null)
        {
            throw new ArgumentException(
                $"Cannot compare '{this.GetType().PrettyPrint()}' and '{obj.GetType().PrettyPrint()}'");
        }

        return this.Value.CompareTo(other.Value);
    }

    /// <summary>
    /// Get the value held, boxed as an object if necessary.
    /// </summary>
    /// <returns>The value held, boxed as an object if necessary.</returns>
    public object GetValue()
    {
        return this.Value;
    }

    /// <summary>
    /// Get the value held, boxed as an object if necessary.
    /// </summary>
    /// <returns>The value held, boxed as an object if necessary.</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return this.Value;
    }

    /// <summary>
    /// Get the underlying string representation of the value held.
    /// </summary>
    /// <returns>The underlying string representation of the value held.</returns>
    public override string? ToString()
    {
        return this.Value.ToString();
    }
}
