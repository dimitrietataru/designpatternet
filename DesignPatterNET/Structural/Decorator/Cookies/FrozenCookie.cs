using Decorator.Interfaces;

namespace Decorator.Cookies
{
    public class FrozenCookie : AbstractCookie
    {
        public override string GetDescription() => "Frozen cookie";
    }
}
