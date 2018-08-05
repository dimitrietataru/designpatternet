using ChainOfResponsability.Chains;
using ChainOfResponsability.Interfaces;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main()
        {
            var chain = CreateChain();

            chain.Message("Level 3", AbstractChain.Three);
            chain.Message("Level 2", AbstractChain.Two);
            chain.Message("Level 1", AbstractChain.One);
        }

        private static AbstractChain CreateChain()
        {
            AbstractChain chain1 = new A(AbstractChain.Three);
            AbstractChain chain2 = new B(AbstractChain.Two);
            AbstractChain chain3 = new C(AbstractChain.One);

            chain1.SetNext(chain2);
            chain2.SetNext(chain3);

            return chain1;
        }
    }
}
