using Mediator.Interfaces;

namespace Mediator.Colleagues
{
    public class ColleagueB : AbstractColleague
    {
        public ColleagueB(IMediator mediator) => this.mediator = mediator;

        public override void Act()
        {
            mediator.Fight();
            mediator.Register(this);
        }
    }
}
