using Adapter.Fruits;

namespace Adapter.Adapters
{
    public class OrangeAdapter : Orange
    {
        private readonly Apple apple;

        public OrangeAdapter(Apple apple) => this.apple = apple;

        public new void GetColor(string color) => apple.GetColor(color);
    }
}
