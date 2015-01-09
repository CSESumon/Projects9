using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class CustomerAndAccount : Form
    {
        public CustomerAndAccount()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Customer aCustomer;
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            aCustomer = new Customer();
            aCustomer.Name = nameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;

            Account anAccount = new Account();
            anAccount.Number = accountNoEntryTextBox.Text;
            anAccount.OpeningDate = openningDateEntryTextBox.Text;

            aCustomer.CustomerAccount= anAccount;

            MessageBox.Show(aCustomer.Name + " has opened an account \n Which account number is " + aCustomer.CustomerAccount.Number + " no");

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.Deposite(amount);
            }
            else
            {
                MessageBox.Show("Create an account");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.Withdraw(amount);
            }
            else
            {
                MessageBox.Show("Create an account");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            customerNameDisplayTextBox.Text = aCustomer.Name;
            emailDisplayTextBox.Text = aCustomer.Email;
            accountnoDisplayTextBox.Text = aCustomer.CustomerAccount.Number;
            openingDateDisplayTextBox.Text = aCustomer.CustomerAccount.OpeningDate;
            balanceDisplayTextBox.Text = aCustomer.CustomerAccount.Balance.ToString();
        }
    }
}
