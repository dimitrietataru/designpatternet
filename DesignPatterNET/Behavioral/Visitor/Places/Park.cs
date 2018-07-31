using System;
using Visitor.Interfaces;

namespace Visitor.Places
{
    public class Park : IPlace
    {
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Park is accepting visitor");
            visitor.Visit(this);
        }
    }
}
