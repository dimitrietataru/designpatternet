using Bridge.Interfaces;

namespace Bridge.Remotes
{
    public class RemoteController : AbstractRemoteController
    {
        public RemoteController(ITv tv) : base(tv) { }
    }
}
