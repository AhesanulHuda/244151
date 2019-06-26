using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
  public class Salary
    {
        public string employeName;
        public int basicAmount;
        public int houseRent;
        public int medicalRent;

        public int totalSalary;

        public int TotalSalary()
        {
            totalSalary = basicAmount + ((basicAmount * houseRent) / 100) + ((basicAmount * medicalRent) / 100);
            return totalSalary;
        }


    }
}
