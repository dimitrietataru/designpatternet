using System;
using Visitor.Interfaces;
using Visitor.Places;

namespace Visitor.Peoples
{
    public class Visitor : IVisitor
    {
        public void Visit(City city) => Console.WriteLine("I am visiting the city!");

        public void Visit(Museum museum) => Console.WriteLine("I am visiting the museum!");

        public void Visit(Park park) => Console.WriteLine("I am visiting the park!");
    }
}
