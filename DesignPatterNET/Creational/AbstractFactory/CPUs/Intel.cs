using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Cpus
{
    public class Intel : ICpu
    {
        public void Process() => Console.WriteLine("Intel is processing..");
    }
}
