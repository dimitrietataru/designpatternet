using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Cpus
{
    public class Amd : ICpu
    {
        public void Process() => Console.WriteLine("AMD is processing..");
    }
}
