using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrementApp
{
    class Employee
    {
        public string EmployeeName { set; get; }
        public string EmployeeId { set; get; }
        public string EmployeeEmail { set; get; }
        public Salary EmployeeSalary { set;get; }
    }
}
