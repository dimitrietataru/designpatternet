using Composite.Interfaces;
using System;

namespace Composite.Components
{
    public class Leaf : IComponent
    {
        private readonly string name;

        public Leaf(string name) => this.name = name;

        public void Show() => Console.WriteLine($"Leaf {name}");
    }
}
