using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private Employee anEmployee;
        private void saveButton_Click(object sender, EventArgs e)
        {
            anEmployee = new Employee();
            anEmployee.ID = idEntryTextBox.Text;
            anEmployee.Name = nameEntryTextBox.Text;
            anEmployee.Email = emailEntryTextBox.Text;
            Salary salary = new Salary();
            salary.Basic = Convert.ToDouble(basicentryTextBox.Text);
            salary.percentageOfMedical = Convert.ToDouble(medicalEntryTextBox.Text);
            salary.percentOfConveyence = Convert.ToDouble(conveyanceentryTextBox.Text);
            anEmployee.EmployeeSalary = salary;
            MessageBox.Show("Infornmation has been added");
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

        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementTextBox.Text = anEmployee.EmployeeSalary.NoOfIncrement.ToString();
            basicDisplayTextBox.Text = anEmployee.EmployeeSalary.Basic.ToString();
            medicalDisplayTextBox.Text = anEmployee.EmployeeSalary.GetMedical().ToString();
            conveyenceDisplayTextBox.Text = anEmployee.EmployeeSalary.GetConveyence().ToString();
            totalDisplayTextBox.Text = anEmployee.EmployeeSalary.CalculateSalary().ToString();
        }
    }
}
