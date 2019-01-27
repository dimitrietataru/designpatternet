using System;
using System.Collections.Generic;
using Visitor.v2.Interfaces;

namespace Visitor.v2.Places
{
    public class City : IPlace
    {
        private readonly List<IPlace> places;

        public City() => places = new List<IPlace> { new Museum(), new Park() };

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("City is acception visitor");
            visitor.Visit(this);
            places.ForEach(place => place.Accept(visitor));
        }
    }
}
