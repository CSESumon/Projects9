using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Account
    {
        public string Number { set; get; }
        public string OpeningDate { set; get; }
        public double Balance { private set; get; }

       
        public string Deposite(double amount)
        {
            Balance += amount;
            return "Deposited";
        }
        public string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return "Withdrawed";
            }
            else
            {
                return "No Sufficient balance to withdraw";
            }
        }
    }
}
