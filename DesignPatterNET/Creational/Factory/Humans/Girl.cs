using Factory.Interfaces;
using System;

namespace Factory.Humans
{
    public class Girl : IHuman
    {
        public void Talk() => Console.WriteLine("Girl is talking..");
        public void Walk() => Console.WriteLine("Girl is walking..");
    }
}
