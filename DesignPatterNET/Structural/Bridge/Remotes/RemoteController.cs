using Bridge.Interfaces;
using System;

namespace Bridge.Remotes
{
    public class RemoteController : AbstractRemoteController
    {
        public RemoteController(ITv tv) : base(tv) { }

        public void SetChannel(int channel)
        {
            SwitchChannel(channel);
            Console.WriteLine("Remote control channel switch");
        }
    }
}
