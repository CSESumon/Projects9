using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryIncrementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Employee anEmployee;
        private void saveButton_Click(object sender, EventArgs e)
        {
            anEmployee=new Employee();
            anEmployee.EmployeeId = idEntryTextBox.Text;
            anEmployee.EmployeeName = nameEntryTextBox.Text;
            anEmployee.EmployeeEmail = emailEntryTextBox.Text;
             
            Salary aSalary =new Salary();
            aSalary.SalaryBasic = Convert.ToDouble(basicentryTextBox.Text);
            aSalary.SalaryMedical = Convert.ToDouble(medicalEntryTextBox.Text);
            aSalary.SalaryConveyance = Convert.ToDouble(conveyanceentryTextBox.Text);

            anEmployee.EmployeeSalary = aSalary;

            MessageBox.Show("Data has been saved");

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementTextBox.Text = anEmployee.EmployeeSalary.NoOfIncrement.ToString();
            basicDisplayTextBox.Text = anEmployee.EmployeeSalary.SalaryBasic.ToString();
            medicalDisplayTextBox.Text = anEmployee.EmployeeSalary.GetMedical().ToString();
            conveyenceDisplayTextBox.Text = anEmployee.EmployeeSalary.GetConveyance().ToString();
            totalDisplayTextBox.Text = anEmployee.EmployeeSalary.TotalSalary().ToString();
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            if (anEmployee != null)
            {
                double amount = Convert.ToDouble(incrementAmountTextBox.Text);
                anEmployee.EmployeeSalary.IncrementSalary(amount);
                MessageBox.Show("Salary has been increased");
            }
            else
            {
                MessageBox.Show("Please fiil all field required");
            }
        }
    }
}
