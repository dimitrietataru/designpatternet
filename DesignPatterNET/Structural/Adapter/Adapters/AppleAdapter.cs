using Adapter.Fruits;

namespace Adapter.Adapters
{
    public class AppleAdapter : Apple
    {
        private readonly Orange orange;

        public AppleAdapter(Orange orange) => this.orange = orange;

        public new void GetColor(string color) => orange.GetColor(color);
    }
}
