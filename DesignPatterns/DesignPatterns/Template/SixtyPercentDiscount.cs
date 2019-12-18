using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class SixtyPercentDiscount : Sale
    {
        private const decimal durationDiscount = 0.6m;

        public override decimal Operate(decimal priceNetto)
        {
            return priceNetto * durationDiscount;
        }
    }
}
