using AbstractFactory.AbstractFactory;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer(GetFactory("amd"));
            Computer computer2 = new Computer(GetFactory("intel"));

            Computer computer3 = new Computer(new AmdFactory());
            Computer computer4 = new Computer(new IntelFactory());
        }

        private static ICpuFactory GetFactory(string type)
        {
            switch(type)
            {
                case "amd":
                    return new AmdFactory();
                case "intel":
                    // fals through
                default:
                    return new IntelFactory();
            }
        }
    }
}
