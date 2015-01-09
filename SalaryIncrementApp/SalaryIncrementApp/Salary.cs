using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrementApp
{
    class Salary
    {
        public double SalaryBasic { set; get; }
        public double SalaryMedical { set; get; }
        public double SalaryConveyance { set; get; }
        public double NoOfIncrement { set; get; }

        public double TotalSalary()
        {
            return SalaryBasic + SalaryMedical + SalaryConveyance;
        }

        public double GetMedical()
        {
            return SalaryBasic*SalaryMedical/100;
        }

        public double GetConveyance()
        {
            return SalaryBasic*SalaryConveyance/100;
        }

        public void IncrementSalary(double amount)
        {
            SalaryBasic += amount*SalaryBasic/100;
            NoOfIncrement++;
        }
    }
}
