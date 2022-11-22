using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public abstract class DiscountTemplate
    {
        public double Calculate(double value)
        {
            if(Rule(value))
            {
                return CalcDiscount(value);
            }

            return 0;
        }

        public abstract bool Rule(double value);
        public abstract double CalcDiscount(double value);
    }
}
