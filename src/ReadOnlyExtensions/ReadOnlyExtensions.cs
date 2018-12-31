using System.Collections.Generic.ReadOnlyExtensions.Internal;

namespace System.Collections.Generic.ReadOnlyExtensions
{
    public static class ReadOnlyExtensions
    {
        public static IReadOnlyList<T> AsReadOnly<T>(this IList<T> source) => new ReadOnlyListWrapper<T>(source);
        public static IReadOnlyCollection<T> AsReadOnly<T>(this ICollection<T> source) => new ReadOnlyCollectionWrapper<T>(source);
        public static IReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> source) => new ReadOnlyDictionaryWrapper<TKey, TValue>(source);
    }

    public class MyClass
    {
        // internal collection that can be manipulated
        private readonly ICollection<Item> _items = new HashSet<Item>();

        // exposed collection that is read only
        public IReadOnlyCollection<Item> Items => _items.AsReadOnly();

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }
    }

    public class Item
    {
        public int Id { get; }
    }
}
