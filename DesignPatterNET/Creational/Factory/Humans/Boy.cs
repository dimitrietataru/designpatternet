using Factory.Interfaces;
using System;

namespace Factory.Humans
{
    public class Boy : IHuman
    {
        public void Talk() => Console.WriteLine("Boy is talking..");
        public void Walk() => Console.WriteLine("Boy is walking..");
    }
}
