﻿using Observer.Interfaces;
using System;

namespace Observer.Business
{
    public class JobSeeker : IObserver
    {
        private readonly string Name;

        public JobSeeker(string name) => Name = name;

        public void Update(ISubject s) => Console.WriteLine($"{Name} got notified");
    }
}
