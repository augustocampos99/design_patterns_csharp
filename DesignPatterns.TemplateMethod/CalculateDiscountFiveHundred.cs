using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class CalculateDiscountFiveHundred : DiscountTemplate
    {
        public override double CalcDiscount(double value)
        {
            return value * 0.4;
        }

        public override bool Rule(double value)
        {
            return value >= 500;
        }
    }
}
