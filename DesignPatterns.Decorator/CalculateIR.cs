using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class CalculateIR : ICalculateTax
    {
        private readonly ICalculateTax _calculateTax;

        public CalculateIR(ICalculateTax calculateTax)
        {
            _calculateTax = calculateTax;   
        }

        public double Calculate(double value)
        {
            return value * 0.3 + this.CalculateOther(value);
        }

        public double CalculateOther(double value)
        {
            if (_calculateTax == null)
                return 0;

            return _calculateTax.Calculate(value);
        }
    }
}
