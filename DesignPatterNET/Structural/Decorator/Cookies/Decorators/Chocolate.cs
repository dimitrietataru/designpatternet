using Decorator.Interfaces;
using System;

namespace Decorator.Cookies.Decorators
{
    public class Chocolate : CookieDecorator
    {
        public Chocolate(Cookie cookie) : base(cookie) { }

        public override string GetDescription() => $"{base.GetDescription()} + chocolate";
        public void Eat() => Console.WriteLine("Eating chocolate");
    }
}
