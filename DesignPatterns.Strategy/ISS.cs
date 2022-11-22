using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class ISS : Itax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.5;
        }
    }
}
