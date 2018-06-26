using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.CPUs
{
    public class Amd : ICpu
    {
        public void Process()
        {
            Console.WriteLine("AMD is processing..");
        }
    }
}
