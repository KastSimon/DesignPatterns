using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class EightyPercentDiscount : Sale
    {
        private const decimal durationDiscount = 0.8m;

        public override decimal Operate(decimal priceNetto)
        {
            return priceNetto * durationDiscount;
        }
    }
}
