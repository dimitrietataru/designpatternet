using Mediator.Interfaces;

namespace Mediator.Colleagues
{
    public class ColleagueA : AbstractColleague
    {
        public ColleagueA(IMediator mediator) => this.mediator = mediator;

        public override void Act()
        {
            mediator.Talk();
            mediator.Register(this);
        }
    }
}
