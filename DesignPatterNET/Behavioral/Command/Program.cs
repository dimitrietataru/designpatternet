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

            Switch s = new Switch();
            s.Execute(shutdown);
            s.Execute(restart);

            Console.WriteLine($"Executed {s.Logs.Count} commands.");
        }
    }
}
