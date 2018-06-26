using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            singleton1.Value = "Singleton 1";
            Console.WriteLine($"Value in singleton 1: '{singleton1.Value}'");
            Console.WriteLine($"Value in singleton 2: '{singleton2.Value}'");
        }
    }
}
