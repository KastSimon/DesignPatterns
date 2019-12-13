using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor {
    public interface IProdukt {
        double Wert { get; set; }
        void Accept(IVisitor visitor);
    }
}
