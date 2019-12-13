namespace DesignPatterns.Visitor
{
    public class Bohrmaschine: IProdukt {
        public double Wert { get; set; }

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
}