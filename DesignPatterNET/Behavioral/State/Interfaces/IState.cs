using State.States;

namespace State.Interfaces
{
    public interface IState
    {
        void SaySomething(StateContext context);
    }
}
