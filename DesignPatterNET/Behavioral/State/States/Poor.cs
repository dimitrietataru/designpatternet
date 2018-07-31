using State.Interfaces;
using System;

namespace State.States
{
    public class Poor : IState
    {
        public void SaySomething(StateContext context)
        {
            Console.WriteLine("I am poor!");
            context.ChangeState(new Rich());
        }
    }
}
