using ChainOfResponsability.Interfaces;
using System;

namespace ChainOfResponsability.Chains
{
    public class C : AbstractChain
    {
        public C(int threshold) => Threshold = threshold;

        protected override void WriteMessage(string message) => Console.WriteLine($"C: {message}");
    }
}
