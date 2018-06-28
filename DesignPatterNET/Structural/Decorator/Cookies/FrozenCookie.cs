using Decorator.Interfaces;

namespace Decorator.Cookies
{
    public class FrozenCookie : Cookie
    {
        public override string GetDescription() => "Frozen cookie";
    }
}
