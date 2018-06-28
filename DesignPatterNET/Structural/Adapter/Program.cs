using Adapter.Adapters;
using Adapter.Fruits;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Orange orange = new Orange();

            apple.GetColor("green");
            orange.GetColor("red");

            AppleAdapter appleAdapter = new AppleAdapter(orange);
            OrangeAdapter orangeAdapter = new OrangeAdapter(apple);
            
            appleAdapter.GetColor("blue");
            orangeAdapter.GetColor("yellow");
        }
    }
}
