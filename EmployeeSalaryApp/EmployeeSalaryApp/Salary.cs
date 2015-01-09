using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Salary
    {
        public double Basic { set; get; }
        public double percentageOfMedical { set; get; }
        public double percentOfConveyence { set; get; }
        public double NoOfIncrement { set; get; }
         

        public double CalculateSalary()
        {
            return Basic + GetMedical() + GetConveyence();
        }

        public double GetMedical()
        {
            return (Basic*percentageOfMedical)/100;
        }

        public double GetConveyence()
        {
            return (Basic*percentOfConveyence)/100;
        }

        public void IncrementSalary(double amount)
        {
            Basic += (amount*Basic)/100;
            NoOfIncrement++;
        }

      
    }
}
