using Facade.Hardware;

namespace Facade
{
    public class Computer
    {
        private readonly Cpu cpu;
        private readonly Ram ram;
        private readonly Drive hdd;

        public Computer()
        {
            cpu = new Cpu();
            ram = new Ram();
            hdd = new Drive();
        }

        public void Run()
        {
            cpu.Process();
            ram.Load();
            hdd.Read();
        }
    }
}
