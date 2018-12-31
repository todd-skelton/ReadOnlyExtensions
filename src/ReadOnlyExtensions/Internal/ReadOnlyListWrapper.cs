namespace System.Collections.Generic.Internal
{
    internal class ReadOnlyListWrapper<T> : IReadOnlyList<T>
    {
        private readonly IList<T> _source;

        internal ReadOnlyListWrapper(IList<T> source)
        {
            _source = source ?? throw new ArgumentNullException(nameof(source));
        }

        public T this[int index] => _source[index];
        public int Count => _source.Count;
        public IEnumerator<T> GetEnumerator() => _source.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _source.GetEnumerator();
    }
}
