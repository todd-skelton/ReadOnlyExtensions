using System.Collections.Generic.Internal;

namespace System.Collections.Generic
{
    public static class ReadOnlyExtensions
    {
        public static IReadOnlyList<T> AsReadOnly<T>(this IList<T> source) => source is null ? null : new ReadOnlyListWrapper<T>(source);
        public static IReadOnlyCollection<T> AsReadOnly<T>(this ICollection<T> source) => source is null ? null : new ReadOnlyCollectionWrapper<T>(source);
        public static IReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> source) => source is null ? null : new ReadOnlyDictionaryWrapper<TKey, TValue>(source);
    }
}
