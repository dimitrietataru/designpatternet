using Factory.Humans;
using Factory.Interfaces;

namespace Factory.Factory
{
    public class HumanFactory
    {
        public static IHuman GetHuman(string type)
        {
            switch (type)
            {
                case "boy":
                    return new Boy();
                case "girl":
                    // falls through
                default:
                    return new Girl();
            }
        }
    }
}
