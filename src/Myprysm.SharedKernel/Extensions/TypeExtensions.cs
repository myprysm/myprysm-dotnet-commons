// The MIT License (MIT)
// 
// Copyright (c) 2015-2020 Rasmus Mikkelsen
// Copyright (c) 2015-2020 eBay Software Foundation
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

namespace Myprysm.SharedKernel.Extensions;

using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

/// <summary>
/// <see cref="Type"/> extensions.
/// </summary>
public static class TypeExtensions
{
    private static readonly ConcurrentDictionary<Type, string> PrettyPrintCache = new();

    /// <summary>
    ///     Get all types implementing the open generic type in the given assembly.
    /// </summary>
    /// <param name="openGenericType">The open generic type.</param>
    /// <param name="assembly">The assembly.</param>
    /// <returns>The enumeration of all matching types.</returns>
    [ExcludeFromCodeCoverage]
    public static IEnumerable<Type> GetAllTypesImplementingOpenGenericType(
        this Type openGenericType,
        Assembly assembly)
    {
        return from type in assembly.GetTypes()
               from iFace in type.GetInterfaces()
               let baseType = type.BaseType
               where
                   baseType is { IsGenericType: true, }
                   && openGenericType.IsAssignableFrom(baseType.GetGenericTypeDefinition())
                   || iFace.IsGenericType && openGenericType.IsAssignableFrom(iFace.GetGenericTypeDefinition())
               select type;
    }

    /// <summary>
    /// Pretty print this type as a human-readable string.
    /// </summary>
    /// <param name="type">The type to print.</param>
    /// <returns>The human-readable representation of this type.</returns>
    [ExcludeFromCodeCoverage]
    public static string PrettyPrint(this Type type)
    {
        return PrettyPrintCache.GetOrAdd(
            type,
            t =>
            {
                try
                {
                    return PrettyPrintRecursive(t, 0);
                }
                catch (Exception)
                {
                    return t.Name;
                }
            });
    }

    [ExcludeFromCodeCoverage]
    private static string PrettyPrintRecursive(Type type, int depth)
    {
        if (depth > 3)
        {
            return type.Name;
        }

        var nameParts = type.Name.Split('`');
        if (nameParts.Length == 1)
        {
            return nameParts[0];
        }

        var genericArguments = type.GetTypeInfo().GetGenericArguments();
        return !type.IsConstructedGenericType
            ? $"{nameParts[0]}<{new string(',', genericArguments.Length - 1)}>"
            : $"{nameParts[0]}<{string.Join(",", genericArguments.Select(t => PrettyPrintRecursive(t, depth + 1)))}>";
    }
}
