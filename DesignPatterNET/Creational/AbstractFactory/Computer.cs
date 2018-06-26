using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class Computer
    {
        private ICpu Cpu { get; set; }

        public Computer(ICpuFactory factory)
        {
            Cpu = factory.ProduceCpu();
            Cpu.Process();
        }
    }
}
