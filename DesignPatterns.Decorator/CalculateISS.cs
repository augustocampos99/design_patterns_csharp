using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class CalculateISS : ICalculateTax
    {
        private readonly ICalculateTax _calculateTax;

        public CalculateISS(ICalculateTax calculateTax)
        {
            _calculateTax = calculateTax;   
        }

        public double Calculate(double value)
        {
            return value * 0.2 + this.CalculateOther(value);
        }

        public double CalculateOther(double value)
        {
            if (_calculateTax == null)
                return 0;

            return _calculateTax.Calculate(value);
        }
    }
}
