using Proxy.Interfaces;

namespace Proxy
{
    public class BusinessAgent
    {
        private readonly ICheatingWife cheatingWife;

        public BusinessAgent() => cheatingWife = new HouseWife();
        public BusinessAgent(ICheatingWife cheatingWife) => this.cheatingWife = cheatingWife;

        public void SeduceMan() => cheatingWife.SeduceMan();
        public void HappyWithMan() => cheatingWife.HappyWithMan();
    }
}
