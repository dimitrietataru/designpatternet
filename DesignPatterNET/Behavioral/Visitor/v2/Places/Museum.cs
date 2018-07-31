using System;
using Visitor.v2.Interfaces;

namespace Visitor.v2.Places
{
    public class Museum : IPlace
    {
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Museum is accepting visitor");
            visitor.Visit(this);
        }
    }
}
