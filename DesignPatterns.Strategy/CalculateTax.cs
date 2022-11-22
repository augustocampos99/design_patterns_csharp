using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class CalculateTax
    {
        public double Calculate(Budget budget, Itax tax)
        {
            return tax.Calculate(budget);
        }
    }
}
