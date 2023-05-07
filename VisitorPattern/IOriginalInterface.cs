namespace VisitorPattern
{
    interface IOriginalInterface
    {
        void Accept(IVisitor visitor);
    }
}