using State.States;

namespace State
{
    class Program
    {
        static void Main()
        {
            var context = new StateContext();

            context.SaySomething();
            context.SaySomething();
            context.SaySomething();
            context.SaySomething();
        }
    }
}
