using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataDrivenTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public double CalculateTotalPrices(double quantity, double prices, double discountRate)
        {
            return quantity * prices * discountRate;
        }
    }
}
