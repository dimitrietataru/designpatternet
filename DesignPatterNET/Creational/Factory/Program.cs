using Factory.Factories;
using Factory.Interfaces;

namespace Factory
{
    class Program
    {
        static void Main()
        {
            IHuman boy = HumanFactory.GetHuman(type: "boy");
            boy.Talk();
            boy.Walk();

            IHuman girl = HumanFactory.GetHuman(type: "girl");
            girl.Talk();
            girl.Walk();
        }
    }
}
