namespace Decorator.Interfaces
{
    public abstract class CookieDecorator : AbstractCookie
    {
        private AbstractCookie cookie;

        protected CookieDecorator(AbstractCookie cookie) => this.cookie = cookie;

        public override string GetDescription() => cookie.GetDescription();
    }
}
