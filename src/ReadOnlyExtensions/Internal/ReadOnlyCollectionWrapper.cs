namespace System.Collections.Generic.ReadOnlyExtensions.Internal
{
    internal class ReadOnlyCollectionWrapper<T> : IReadOnlyCollection<T>
    {
        private readonly ICollection<T> _source;

        internal ReadOnlyCollectionWrapper(ICollection<T> source)
        {
            _source = source;
        }

        public int Count => _source.Count;

        public IEnumerator<T> GetEnumerator() => _source.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _source.GetEnumerator();
    }
}
