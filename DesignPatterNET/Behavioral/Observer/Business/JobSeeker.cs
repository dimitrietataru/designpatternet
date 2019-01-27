using Observer.Interfaces;
using System;

namespace Observer.Business
{
    public class JobSeeker : IObserver
    {
        private readonly string name;

        public JobSeeker(string name) => this.name = name;

        public void Update(ISubject _) => Console.WriteLine($"{name} got notified");
    }
}
