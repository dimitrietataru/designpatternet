using System;
using Visitor.Interfaces;

namespace Visitor.Places
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
