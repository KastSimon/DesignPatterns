using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor {
    public class VisitorMain {

        public void Main() {
            List<IProdukt> vermögen = new List<IProdukt>();
            vermögen.Add(new GartenStuhl());
            vermögen.Add(new Bohrmaschine());
            DiscountedPrice d = new DiscountedPrice();
            foreach(var item in vermögen) {
                item.Accept(d);
            }
            DiscountedPriceTotal dt = new DiscountedPriceTotal();
            foreach(var item in vermögen) {
                item.Accept(dt);
            }
        }
    }
}
