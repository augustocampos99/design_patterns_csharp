using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public  interface IDiscount
    {
        double Calculate(double value);

        public IDiscount NextDiscount { get; set; }
    }
}
