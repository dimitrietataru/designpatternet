using Strategy.Interfaces;
using System;

namespace Strategy.Police
{
    public class NicePolice : IStrategy
    {
        public void ProcessSpeed(int speed) =>
            Console.WriteLine($"You speed is {speed}, nice police waves at you!");
    }
}
