using System.Collections.Generic;

namespace Observer.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RegisterObservers(List<IObserver> observers);
        void RemoveObserver(IObserver observer);
        void NotifyAllObservers();
    }
}
