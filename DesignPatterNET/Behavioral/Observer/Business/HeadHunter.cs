using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Business
{
    public class HeadHunter : ISubject
    {
        private List<IObserver> users;
        private List<string> jobs;

        public HeadHunter()
        {
            users = new List<IObserver>();
            jobs = new List<string>();
        }

        public void RegisterObserver(IObserver observer) => users.Add(observer);
        public void RegisterObservers(List<IObserver> observers) => users.AddRange(observers);
        public void RemoveObserver(IObserver observer) => users.Remove(observer);
        public void NotifyAllObservers() => users.ForEach(user => user.Update(this));

        public void AddJob(string job)
        {
            Console.WriteLine($"A new job was added: {job}");
            jobs.Add(job);
            NotifyAllObservers();
        }

        public void ShowUsers()
        {
            Console.WriteLine($"Users to notify: {String.Join(", ", users)}");
        }
    }
}
