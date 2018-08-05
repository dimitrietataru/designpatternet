using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new string[] { "1", "2", "3", "a", "b", "c" };

            var collection = new Collection(items);
            var iterator = collection.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
