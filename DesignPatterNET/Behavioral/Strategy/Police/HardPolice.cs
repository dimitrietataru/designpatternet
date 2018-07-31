using Strategy.Interfaces;
using System;

namespace Strategy.Police
{
    public class HardPolice : IStrategy
    {
        public void ProcessSpeed(int speed) =>
            Console.WriteLine($"You speed is {speed}, hard police gives you a ticket!");
    }
}
