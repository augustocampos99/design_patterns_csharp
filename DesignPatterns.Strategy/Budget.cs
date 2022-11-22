using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Budget
    {
        public Budget()
        {
        }

        public Budget(double value)
        {
            this.Value = value;
        }
        public double Value { get; set; }
    }
}
