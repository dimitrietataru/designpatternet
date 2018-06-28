using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.CPUs
{
    public class Intel : ICpu
    {
        public void Process() => Console.WriteLine("Intel is processing..");
    }
}
