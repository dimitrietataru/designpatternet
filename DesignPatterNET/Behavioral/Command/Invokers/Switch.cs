using Command.Interfaces;
using System.Collections.Generic;

namespace Command.Invokers
{
    class Switch
    {
        public List<ICommand> logs;

        public Switch() => logs = new List<ICommand>();

        public void Execute(ICommand command)
        {
            logs.Add(command);
            command.Execute();
        }

        public int Commands() => logs.Count;
    }
}
