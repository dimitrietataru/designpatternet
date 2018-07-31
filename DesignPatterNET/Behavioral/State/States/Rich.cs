using State.Interfaces;
using System;

namespace State.States
{
    public class Rich : IState
    {
        public void SaySomething(StateContext context)
        {
            Console.WriteLine("I am rich!");
            context.ChangeState(new Poor());
        }
    }
}
