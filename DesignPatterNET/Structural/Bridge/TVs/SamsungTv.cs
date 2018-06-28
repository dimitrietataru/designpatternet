using Bridge.Interfaces;
using System;

namespace Bridge.TVs
{
    public class SamsungTv : ITv
    {
        public void On() => Console.WriteLine("Samsung ON");

        public void Off() => Console.WriteLine("Samsung OFF");

        public void Switch(int channel) => Console.WriteLine($"Samsung channel {channel}");
    }
}
