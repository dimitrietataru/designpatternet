namespace Visitor.v2.Interfaces
{
    public interface IPlace
    {
        void Accept(IVisitor visitor);
    }
}
