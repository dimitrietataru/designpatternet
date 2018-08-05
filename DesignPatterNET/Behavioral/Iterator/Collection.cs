using Iterator.Interfaces;

namespace Iterator
{
    public class Collection : IContainer
    {
        private string[] Items { get; }

        public Collection(string[] items) => Items = items;

        public IIterator GetIterator() => new CollectionIterator(Items);
        
        private class CollectionIterator : IIterator
        {
            private string[] Items { get; set; }
            private int Index { get; set; }

            public CollectionIterator(string[] collection) => Items = collection;

            public bool HasNext() => (Index < Items.Length);
            public object Next() => HasNext() ? Items[Index++] : null;
        }
    }
}
