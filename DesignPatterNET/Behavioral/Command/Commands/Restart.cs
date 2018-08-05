using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands
{
    public class Restart : ICommand
    {
        private Computer Computer { get; set; }

        public Restart(Computer computer) => Computer = computer;

        public void Execute() => Computer.Restart();
    }
}
