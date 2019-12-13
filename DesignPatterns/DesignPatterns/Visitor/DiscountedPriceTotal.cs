using System;

namespace DesignPatterns.Visitor
{
    class DiscountedPriceTotal: IVisitor {
        private double summe;
        public void Visit(GartenStuhl g) {
            summe += g.Wert;
        }

        public void Visit(Bohrmaschine b) {
            summe += b.Wert;
            Console.WriteLine(summe);
        }
    }
}