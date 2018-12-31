namespace System.Collections.Generic.Internal
{
    internal class ReadOnlyCollectionWrapper<T> : IReadOnlyCollection<T>
    {
        private readonly ICollection<T> _source;

        internal ReadOnlyCollectionWrapper(ICollection<T> source)
        {
            _source = source ?? throw new ArgumentNullException(nameof(source));
        }

        public int Count => _source.Count;

        public IEnumerator<T> GetEnumerator() => _source.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _source.GetEnumerator();
    }
}
