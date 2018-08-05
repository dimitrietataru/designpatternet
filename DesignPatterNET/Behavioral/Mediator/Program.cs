using Mediator.Colleagues;
using Mediator.Interfaces;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            IMediator mediator = new Mediator();

            var talkColleague = new ColleagueA(mediator);
            var fightColleague = new ColleagueB(mediator);

            talkColleague.Act();
            fightColleague.Act();
        }
    }
}
