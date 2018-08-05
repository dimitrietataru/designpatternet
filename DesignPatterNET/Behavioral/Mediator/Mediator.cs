using Mediator.Colleagues;
using Mediator.Interfaces;
using System;

namespace Mediator
{
    public class Mediator : IMediator
    {
        private ColleagueA a;
        private ColleagueB b;

        public void Register(AbstractColleague colleague)
        {
            switch(colleague)
            {
                case ColleagueA a:
                    this.a = a;
                    break;
                case ColleagueB b:
                    this.b = b;
                    break;
                default:
                    break;
            }
        }

        public void Fight() => Console.WriteLine("Mediator is fighting.");
        public void Talk() => Console.WriteLine("Mediator is talking.");
    }
}
