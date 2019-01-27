using Bridge.Interfaces;

namespace Bridge.Remotes
{
    public class RemoteController : AbstractRemoteController
    {
        public RemoteController(ITV tv)
            : base(tv)
        {
        }
    }
}
