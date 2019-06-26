using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
   public class Calculator
    {
        public double firstNo;
        public double secoundNo;

        public double result;
        public double Add()
        {
            result = firstNo + secoundNo;
            return result;
        }
        public double Subtraction()
        {
            result = firstNo - secoundNo;
            return result;
        }
        public double Multiple()
        {
            result = firstNo * secoundNo;
            return result;
        }
        public double Division()
        {
            result = firstNo / secoundNo;
            return result;
        }
    }
}
