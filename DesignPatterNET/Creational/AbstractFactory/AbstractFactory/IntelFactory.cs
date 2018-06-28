using AbstractFactory.CPUs;
using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactory
{
    public class IntelFactory : ICpuFactory
    {
        public ICpu ProduceCpu() => new Intel();
    }
}
