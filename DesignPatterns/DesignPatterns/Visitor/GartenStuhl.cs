namespace DesignPatterns.Visitor
{
    public class GartenStuhl: IProdukt {
        public double Wert { get; set; }

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
}