using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public abstract class Sale
    {


        public decimal GetTotal(decimal priceNetto)
        {
            return Operate(priceNetto);
        }

        public abstract decimal Operate(decimal priceNetto);

    }
}
