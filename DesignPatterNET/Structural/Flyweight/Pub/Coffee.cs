using Flyweight.Interfaces;
using System;

namespace Flyweight.Pub
{
    public class Coffee : ICoffee
    {
        private readonly string flavor;

        public Coffee(string flavor)
        {
            this.flavor = flavor;
            Console.WriteLine($"{flavor} was created.");
        }

        public string GetFlavor() => flavor;

        public void Serve(Table table)
        {
            Console.WriteLine($"Serving to table {table.Number} - {flavor}");
        }
    }
}
