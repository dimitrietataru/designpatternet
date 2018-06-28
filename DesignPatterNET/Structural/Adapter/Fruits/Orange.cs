using System;

namespace Adapter.Fruits
{
    public class Orange
    {
        public void GetColor(string color) => Console.WriteLine($"Orange's color is: {color}");
    }
}
