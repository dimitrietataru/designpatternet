using Strategy.Interfaces;

namespace Strategy
{
    public class Situation
    {
        private readonly IStrategy strategy;

        public Situation(IStrategy strategy) => this.strategy = strategy;

        public void Handle(int speed) => strategy.ProcessSpeed(speed);
    }
}
