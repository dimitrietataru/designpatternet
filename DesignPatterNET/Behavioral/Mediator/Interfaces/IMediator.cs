namespace Mediator.Interfaces
{
    public interface IMediator
    {
        void Register(AbstractColleague colleague);
        void Fight();
        void Talk();
    }
}
