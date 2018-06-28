using Decorator.Interfaces;

namespace Decorator.Cookies
{
    public class BakedCookie : Cookie
    {
        public override string GetDescription() => "Baked cookie";
    }
}
