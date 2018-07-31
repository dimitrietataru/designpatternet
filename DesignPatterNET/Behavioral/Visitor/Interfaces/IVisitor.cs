using Visitor.Places;

namespace Visitor.Interfaces
{
    public interface IVisitor
    {
        void Visit(City city);
        void Visit(Museum museum);
        void Visit(Park park);
    }
}
