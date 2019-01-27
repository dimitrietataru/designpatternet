using Factory.Humans;
using Factory.Interfaces;
using System;

namespace Factory.Factories
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
                    return new Girl();
                default:
                    throw new EntryPointNotFoundException();
            }
        }
    }
}
