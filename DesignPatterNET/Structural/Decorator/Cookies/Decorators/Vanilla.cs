using Decorator.Interfaces;
using System;

namespace Decorator.Cookies.Decorators
{
    public class Vanilla : CookieDecorator
    {
        public Vanilla(AbstractCookie cookie) : base(cookie) { }

        public override string GetDescription() => $"{base.GetDescription()} + vanilla";
        public void Eat() => Console.WriteLine("Eating vanilla");
    }
}
