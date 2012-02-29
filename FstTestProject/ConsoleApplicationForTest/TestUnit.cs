using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationForTest
{
    public class TestUnit
    {
        public Int32 AddInteger(Int32 num1, Int32 num2)
        {
            return num1 + num2;
        }

        public double CalculateTotalPrices(double quanity)
        {
            return 12.5 * quanity;
        }
    }
}
