using System;
using System.Collections.Generic;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            var mementos = new List<Life.Memento>();
            var life = new Life();

            life.Set(new DateTime(2010, 10, 10));
            mementos.Add(life.Save());

            life.Set(new DateTime(2020, 02, 02));
            mementos.Add(life.Save());

            life.Set(new DateTime(1900, 01, 01, 00, 01, 01));
            mementos.Add(life.Save());

            life.Set(new DateTime(1800, 12, 31, 23, 59, 59));
            mementos.Add(life.Save());

            mementos.ForEach(memento => life.Restore(memento));
        }
    }
}
