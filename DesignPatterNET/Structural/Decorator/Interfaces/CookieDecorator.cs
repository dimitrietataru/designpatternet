namespace Decorator.Interfaces
{
    public abstract class CookieDecorator : Cookie
    {
        private Cookie cookie;

        protected CookieDecorator(Cookie cookie) => this.cookie = cookie;

        public override string GetDescription() => cookie.GetDescription();
    }
}
