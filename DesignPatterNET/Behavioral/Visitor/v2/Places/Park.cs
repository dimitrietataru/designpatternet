using System;
using Visitor.v2.Interfaces;

namespace Visitor.v2.Places
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
