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

using System.Collections.Concurrent;
using System.Reflection;

/// <summary>
/// Represents a value object that cannot or should not be represented by a C# 9.0 record.
/// </summary>
/// <remarks>See https://github.com/eventflow/EventFlow/blob/develop-v1/Source/EventFlow/ValueObjects/ValueObject.cs</remarks>
public abstract class ValueObject
{
    private static readonly ConcurrentDictionary<Type, IReadOnlyCollection<PropertyInfo>> TypeProperties = new();

    /// <summary>
    /// Verifies that this <see cref="ValueObject"/> is equal to the other object by values.
    /// </summary>
    /// <param name="obj">The other object.</param>
    /// <returns><code>true</code> when both objects are equal by value.</returns>
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (this.GetType() != obj.GetType())
        {
            return false;
        }

        var other = obj as ValueObject;
        return other != null && this.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    /// <summary>
    /// Returns the hash code of this value object,
    /// using all the available instance/public properties.
    /// </summary>
    /// <returns>The hash code for this value object.</returns>
    public override int GetHashCode()
    {
        unchecked
        {
            return this.GetEqualityComponents()
                .Aggregate(17, (current, obj) => current * 23 + (obj?.GetHashCode() ?? 0));
        }
    }

    /// <summary>
    /// Verifies that two <see cref="ValueObject"/> are equal to each other.
    /// </summary>
    /// <param name="left">The left side object.</param>
    /// <param name="right">The right side object.</param>
    /// <returns><code>true</code> when the left side is equal to the right side by value.</returns>
    public static bool operator ==(ValueObject? left, ValueObject? right)
    {
        return Equals(left, right);
    }

    /// <summary>
    /// Verifies that two <see cref="ValueObject"/> are different from each other.
    /// </summary>
    /// <param name="left">The left side object.</param>
    /// <param name="right">The right side object.</param>
    /// <returns><code>true</code> when the left side is equal to the right side by value.</returns>
    public static bool operator !=(ValueObject? left, ValueObject? right)
    {
        return !Equals(left, right);
    }

    /// <summary>
    /// Returns a string representation of this value object.
    ///
    /// It enumerates a human-readable version of all properties available from <see cref="ValueObject.GetProperties"/>.
    /// </summary>
    /// <returns></returns>
    public override string? ToString()
    {
        return $"{{{string.Join(", ", this.GetProperties().Select(f => $"{f.Name}: {f.GetValue(this)}"))}}}";
    }

    /// <summary>
    /// Returns all the values in sequence that should be used to verify
    /// that this <see cref="ValueObject"/> is equal to another <see cref="ValueObject"/>.
    /// </summary>
    /// <returns>The sequence of values to verify the equality.</returns>
    protected virtual IEnumerable<object?> GetEqualityComponents()
    {
        return this.GetProperties().Select(x => x.GetValue(this));
    }

    /// <summary>
    /// Returns the <see cref="PropertyInfo"/> used to verify
    /// that this <see cref="ValueObject"/> is equal to another <see cref="ValueObject"/>.
    /// </summary>
    /// <returns>The <see cref="PropertyInfo"/> used during the default equality procedure.</returns>
    protected virtual IEnumerable<PropertyInfo> GetProperties()
    {
        return TypeProperties.GetOrAdd(
            this.GetType(),
            t => t
                .GetTypeInfo()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .OrderBy(p => p.Name)
                .ToList());
    }
}
