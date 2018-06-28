using Bridge.Interfaces;
using Bridge.Remotes;
using Bridge.TVs;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ITv tv = new SamsungTv();

            AbstractRemoteController rc = new RemoteController(tv);
            rc.TurnOn();
            rc.SwitchChannel(100);
            rc.TurnOff();
        }
    }
}
