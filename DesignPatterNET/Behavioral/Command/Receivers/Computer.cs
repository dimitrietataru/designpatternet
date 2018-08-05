using System;

namespace Command.Receivers
{
    public class Computer
    {
        public void ShutDown() => Console.WriteLine("Shut down");
        public void Restart() => Console.WriteLine("Restart");
    }
}
