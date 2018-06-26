using Factory.Factory;
using Factory.Interfaces;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman boy = HumanFactory.GetHuman("boy");
            boy.Talk();
            boy.Walk();

            IHuman girl = HumanFactory.GetHuman("girl");
            girl.Talk();
            girl.Walk();
        }
    }
}
