using Iterator.Interfaces;

namespace Iterator
{
    public class Collection<T> : IContainer
        where T : class
    {
        private readonly T[] items;

        public Collection(T[] items) => this.items = items;

        public IIterator GetIterator() => new CollectionIterator<T>(items);
        
        private class CollectionIterator<TInner> : IIterator
            where TInner : class
        {
            private readonly TInner[] items;
            private int index = 0;

            public CollectionIterator(TInner[] items) => this.items = items;

            public bool HasNext() => index < items.Length;

            public object Next() => HasNext() ? items[index++] : null;
        }
    }
}
