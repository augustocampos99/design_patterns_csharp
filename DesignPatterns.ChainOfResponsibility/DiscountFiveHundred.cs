using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class DiscountFiveHundred : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double Calculate(double value)
        {
            if(value >= 500)
                return value * 0.3;

            return this.NextDiscount.Calculate(value);
        }


    }
}
