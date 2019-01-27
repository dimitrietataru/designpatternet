using Bridge.Interfaces;
using Bridge.Remotes;
using Bridge.TVs;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ITV samsung = new SamsungTV();
            ITV sony = new SonyTV();

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
