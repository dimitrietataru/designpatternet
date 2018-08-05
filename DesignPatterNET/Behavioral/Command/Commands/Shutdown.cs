using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands
{
    public class Shutdown : ICommand
    {
        private Computer Computer { get; set; }

        public Shutdown(Computer computer) => Computer = computer;

        public void Execute() => Computer.ShutDown();
    }
}
