namespace System.Collections.Generic.Internal
{
    internal class ReadOnlyDictionaryWrapper<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    {
        private readonly IDictionary<TKey, TValue> _source;

        internal ReadOnlyDictionaryWrapper(IDictionary<TKey, TValue> source)
        {
            _source = source ?? throw new ArgumentNullException(nameof(source));
        }

        public TValue this[TKey key] => _source[key];

        public IEnumerable<TKey> Keys => _source.Keys;

        public IEnumerable<TValue> Values => _source.Values;

        public int Count => _source.Count;

        public bool ContainsKey(TKey key) => _source.ContainsKey(key);

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _source.GetEnumerator();

        public bool TryGetValue(TKey key, out TValue value) => _source.TryGetValue(key, out value);

        IEnumerator IEnumerable.GetEnumerator() => _source.GetEnumerator();
    }
}
