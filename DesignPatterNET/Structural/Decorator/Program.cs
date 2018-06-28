using Decorator.Cookies;
using Decorator.Cookies.Decorators;
using Decorator.Interfaces;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie c1 = new BakedCookie();
            Console.WriteLine(c1.GetDescription());

            Vanilla c2 = new Vanilla(c1);
            Console.WriteLine(c2.GetDescription());

            Chocolate c3 = new Chocolate(c2);
            Console.WriteLine(c3.GetDescription());

            Cookie c4 = new Chocolate(new Vanilla(new FrozenCookie()));
            Console.WriteLine(c4.GetDescription());
        }
    }
}
