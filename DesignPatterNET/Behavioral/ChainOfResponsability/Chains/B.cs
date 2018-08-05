using ChainOfResponsability.Interfaces;
using System;

namespace ChainOfResponsability.Chains
{
    public class B : AbstractChain
    {
        public B(int threshold) => Threshold = threshold;

        protected override void WriteMessage(string message) => Console.WriteLine($"B: {message}");
    }
}
