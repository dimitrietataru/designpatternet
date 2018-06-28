using Bridge.Interfaces;
using System;

namespace Bridge.TVs
{
    public class SonyTv : ITv
    {
        public void On() => Console.WriteLine("Sony ON");

        public void Off() => Console.WriteLine("Sony OFF");

        public void Switch(int channel) => Console.WriteLine($"Sony channel {channel}");
    }
}
