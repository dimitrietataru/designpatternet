using AbstractFactory.CPUs;
using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactory
{
    public class AmdFactory : ICpuFactory
    {
        public ICpu ProduceCpu() => new Amd();
    }
}
