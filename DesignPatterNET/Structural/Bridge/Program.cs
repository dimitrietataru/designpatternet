using Bridge.Interfaces;
using Bridge.Remotes;
using Bridge.TVs;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ITv samsung = new SamsungTv();
            ITv sony = new SonyTv();

            AbstractRemoteController rc = new RemoteController(samsung);
            rc.TurnOn();
            rc.SwitchChannel(100);
            rc.TurnOff();

            rc = new RemoteController(sony);
            rc.TurnOn();
            rc.SwitchChannel(100);
            rc.TurnOff();
        }
    }
}
