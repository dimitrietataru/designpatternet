using Prototype.Interfaces;
using System;

namespace Prototype
{
    public class Prototype : IPrototype, ICloneable
    {
        private int size;

        public Prototype(int size) => this.size = size;

        public void SetSize(int size) => this.size = size;

        public void PrintSize() => Console.WriteLine($"Size: {size}");

        public object Clone() => MemberwiseClone();

        public Prototype CloneManually() => new Prototype(size);
    }
}
