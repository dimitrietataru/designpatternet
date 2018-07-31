using System;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            var visitor = new Peoples.Visitor();
            var city = new Places.City();
            city.Accept(visitor);

            Console.WriteLine(Environment.NewLine + "past to future" + Environment.NewLine);

            var modernVisitor = new v2.Peoples.Visitor();
            var modernCity = new v2.Places.City();
            modernCity.Accept(modernVisitor);
        }
    }
}
