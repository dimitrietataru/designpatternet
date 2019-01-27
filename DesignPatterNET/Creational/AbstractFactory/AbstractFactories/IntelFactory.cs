using AbstractFactory.Cpus;
using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactories
{
    public class IntelFactory : ICpuFactory
    {
        public ICpu ProduceCpu() => new Intel();
    }
}
