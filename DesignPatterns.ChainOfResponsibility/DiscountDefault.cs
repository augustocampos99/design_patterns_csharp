using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class DiscountDefault : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double Calculate(double value)
        {
            return 0;
        }


    }
}
