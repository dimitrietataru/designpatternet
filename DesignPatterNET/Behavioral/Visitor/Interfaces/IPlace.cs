namespace Visitor.Interfaces
{
    public interface IPlace
    {
        void Accept(IVisitor visitor);
    }
}
