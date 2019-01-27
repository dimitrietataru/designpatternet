using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands
{
    public class Restart : ICommand
    {
        private readonly Computer computer;

        public Restart(Computer computer) => this.computer = computer;

        public void Execute() => computer.Restart();
    }
}
