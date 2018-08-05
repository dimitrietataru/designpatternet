using ChainOfResponsability.Interfaces;
using System;

namespace ChainOfResponsability.Chains
{
    public class A : AbstractChain
    {
        public A(int threshold) => Threshold = threshold;

        protected override void WriteMessage(string message) => Console.WriteLine($"A: {message}");
    }
}
