namespace DesignPatterns.Visitor
{
    class DiscountedPrice: IVisitor {
        public void Visit(GartenStuhl g) {
            g.Wert = 60;
            g.Wert *= 0.9;
        }

        public void Visit(Bohrmaschine b) {
            b.Wert = 120;
            b.Wert *= 0.75;
        }
    }
}