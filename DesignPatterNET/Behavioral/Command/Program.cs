using Command.Commands;
using Command.Interfaces;
using Command.Invokers;
using Command.Receivers;
using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            var computer = new Computer();
            ICommand shutdown = new Shutdown(computer);
            ICommand restart = new Restart(computer);

            Switch sw = new Switch();
            sw.Execute(shutdown);
            sw.Execute(restart);

            Console.WriteLine($"Executed {sw.Commands()} commands.");
        }
    }
}
