using System;
using Visitor.v2.Interfaces;
using Visitor.v2.Places;

namespace Visitor.v2.Peoples
{
    public class Visitor : IVisitor
    {
        public void Visit(IPlace place)
        {
            switch(place)
            {
                case City city:
                    Console.WriteLine("I am visiting the city!");
                    break;
                case Museum museum:
                    Console.WriteLine("I am visiting the museum!");
                    break;
                case Park park:
                    // falls through
                default:
                    Console.WriteLine("I am visiting the park!");
                    break;
            }
        }
    }
}
