using AbstractFactory.AbstractFactories;
using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer(GetFactory(CpuType.Amd));
            Computer computer2 = new Computer(GetFactory(CpuType.Intel));

            Computer computer3 = new Computer(new AmdFactory());
            Computer computer4 = new Computer(new IntelFactory());
        }

        private static ICpuFactory GetFactory(CpuType type)
        {
            switch (type)
            {
                case CpuType.Amd:
                    return new AmdFactory();
                case CpuType.Intel:
                    return new IntelFactory();
                default:
                    throw new EntryPointNotFoundException();
            }
        }
    }
}
