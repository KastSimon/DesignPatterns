namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(GartenStuhl g);
        void Visit(Bohrmaschine b);
    }
}