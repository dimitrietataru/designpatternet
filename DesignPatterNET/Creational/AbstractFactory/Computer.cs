using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class Computer
    {
        private protected ICpu Cpu { get; set; }

        public Computer(ICpuFactory factory)
        {
            Cpu = factory.ProduceCpu();
            Cpu.Process();
        }
    }
}
