namespace System.Collections.Generic.Internal
{
    internal class ReadOnlyEnumerableWrapper<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> _source;

        internal ReadOnlyEnumerableWrapper(IEnumerable<T> source)
        {
            _source = source ?? throw new ArgumentNullException(nameof(source));
        }

        public IEnumerator<T> GetEnumerator() => _source.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _source.GetEnumerator();
    }
}
