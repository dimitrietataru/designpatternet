using Command.Interfaces;
using System.Collections.Generic;

namespace Command.Invokers
{
    class Switch
    {
        public List<ICommand> Logs { get; private set; }

        public Switch() => Logs = new List<ICommand>();

        public void Execute(ICommand command)
        {
            Logs.Add(command);
            command.Execute();
        }
    }
}
