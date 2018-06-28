using Bridge.Interfaces;

namespace Bridge.Remotes
{
    public class AbstractRemoteController
    {
        private readonly ITv tv;

        public AbstractRemoteController(ITv tv) => this.tv = tv;

        public void TurnOn() => tv.On();
        public void TurnOff() => tv.Off();
        public void SwitchChannel(int channel) => tv.Switch(channel);
    }
}
