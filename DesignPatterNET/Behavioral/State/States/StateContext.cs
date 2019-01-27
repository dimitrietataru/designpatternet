using State.Interfaces;

namespace State.States
{
    public class StateContext
    {
        private IState state;

        public StateContext() => state = new Poor();

        public void ChangeState(IState state) => this.state = state;

        public void SaySomething() => state.SaySomething(this);
    }
}
