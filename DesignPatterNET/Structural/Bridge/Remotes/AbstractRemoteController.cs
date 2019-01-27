using Bridge.Interfaces;

namespace Bridge.Remotes
{
    public abstract class AbstractRemoteController
    {
        private readonly ITV tv;

        public AbstractRemoteController(ITV tv) => this.tv = tv;

        public void TurnOn() => tv.On();

        public void TurnOff() => tv.Off();

        public void SwitchChannel(int channel) => tv.Switch(channel);
    }
}
