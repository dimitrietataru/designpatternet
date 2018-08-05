using System;

namespace Memento
{
    public class Life
    {
        private DateTime Time { get; set; }

        public void Set(DateTime time) => Time = time;

        public Memento Save()
        {
            Console.WriteLine("Saving time to memento");
            return new Memento(Time);
        }

        public void Restore(Memento memento)
        {
            Time = DateTime.Parse(memento.Time);
            Console.WriteLine($"Time restored from memento: {Time.ToString("dd MMM yyyy")}");
        }

        public class Memento
        {
            public string Time { get; private set; }

            public Memento(DateTime time) => Time = time.ToString("yyyy-MM-dd");
        }
    }
}
