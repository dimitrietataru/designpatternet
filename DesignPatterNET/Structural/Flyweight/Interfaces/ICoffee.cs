using Flyweight.Pub;

namespace Flyweight.Interfaces
{
    public interface ICoffee
    {
        string GetFlavor();
        void Serve(Table table);
    }
}
