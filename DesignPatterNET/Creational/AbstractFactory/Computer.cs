using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class Computer
    {
        private protected readonly ICpu cpu;

        public Computer(ICpuFactory factory)
        {
            cpu = factory.ProduceCpu();
            cpu.Process();
        }
    }
}
