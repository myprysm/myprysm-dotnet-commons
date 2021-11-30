namespace Myprysm.SharedKernel.Extensions;

using System.Collections.Generic;

/// <summary>
/// Extensions for <see cref="ICollection{T}"/> and assimilated.
/// </summary>
public static class CollectionExtensions
{
    /// <summary>
    /// Add the provided items to the collection.
    /// </summary>
    /// <param name="collection">The collection to add items to.</param>
    /// <param name="items">The items.</param>
    /// <typeparam name="T">The type of the items.</typeparam>
    public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
    {
        if (collection is List<T> list)
        {
            list.AddRange(items);
            return;
        }

        foreach (var item in items)
        {
            collection.Add(item);
        }
    }

    /// <summary>
    /// Remove the provide items from the collection.
    /// </summary>
    /// <param name="collection">The collection to remove items from.</param>
    /// <param name="items">The items.</param>
    /// <typeparam name="T">The type of the items.</typeparam>
    public static void RemoveRange<T>(this ICollection<T> collection, IEnumerable<T> items)
    {
        if (collection is List<T> list)
        {
            list.RemoveRange(items);
            return;
        }

        foreach (var item in items)
        {
            collection.Remove(item);
        }
    }
}
