using System.Collections.Generic.Internal;

namespace System.Collections.Generic
{
    /// <summary>
    /// Extension methods to expose collections as read-only.
    /// </summary>
    public static class ReadOnlyExtensions
    {
        /// <summary>
        /// Exposes a list as read-only.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="source">The source list that will be exposed as read-only.</param>
        /// <returns>The exposed read-only list.</returns>
        public static IReadOnlyList<T> AsReadOnly<T>(this IList<T> source) => source is null ? null : new ReadOnlyListWrapper<T>(source);
        /// <summary>
        /// Exposes a collection as read-only.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="source">The source collection that will be exposed as read-only.</param>
        /// <returns>The exposed read-only collection.</returns>
        public static IReadOnlyCollection<T> AsReadOnly<T>(this ICollection<T> source) => source is null ? null : new ReadOnlyCollectionWrapper<T>(source);
        /// <summary>
        /// Exposes a dictionary as read-only.
        /// </summary>
        /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
        /// <param name="source">The source dictionary that will be exposed as read-only.</param>
        /// <returns>The exposed read-only dictionary.</returns>
        public static IReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> source) => source is null ? null : new ReadOnlyDictionaryWrapper<TKey, TValue>(source);
        /// <summary>
        /// Exposes an enumerable as read-only to prevent casting.
        /// </summary>
        /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
        /// <param name="source">The source enumerable that will be exposed as read-only.</param>
        /// <returns>The exposed read-only enumerable.</returns>
        public static IEnumerable<T> AsReadOnly<T>(this IEnumerable<T> source) => source is null ? null : new ReadOnlyEnumerableWrapper<T>(source);
    }
}
