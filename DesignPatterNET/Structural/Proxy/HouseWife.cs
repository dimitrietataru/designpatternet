using Proxy.Interfaces;
using System;

namespace Proxy
{
    public class HouseWife : ICheatingWife
    {
        public void SeduceMan() => Console.WriteLine("House wife secudes man");
        public void HappyWithMan() => Console.WriteLine("House wife is happy with man");
    }
}
