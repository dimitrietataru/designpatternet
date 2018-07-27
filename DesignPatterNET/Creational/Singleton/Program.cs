using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            var instanceOne = Singleton.Instance;
            var instanceTwo = Singleton.Instance;

            instanceOne.Value = "persistent value";
            Console.WriteLine($"Value in 1st instance: '{instanceOne.Value}'");
            Console.WriteLine($"Value in 2nd instance: '{instanceTwo.Value}'");
        }
    }
}
