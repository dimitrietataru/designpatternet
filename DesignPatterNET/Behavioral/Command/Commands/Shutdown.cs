using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands
{
    public class Shutdown : ICommand
    {
        private readonly Computer computer;

        public Shutdown(Computer computer) => this.computer = computer;

        public void Execute() => computer.ShutDown();
    }
}
