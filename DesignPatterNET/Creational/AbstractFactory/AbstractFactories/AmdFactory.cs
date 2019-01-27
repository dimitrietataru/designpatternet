using AbstractFactory.Cpus;
using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactories
{
    public class AmdFactory : ICpuFactory
    {
        public ICpu ProduceCpu() => new Amd();
    }
}
