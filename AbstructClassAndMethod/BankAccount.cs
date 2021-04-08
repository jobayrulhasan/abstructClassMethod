using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassAndMethod
{
    public abstract class BankAccount
    {
        public BankAccount(string accountNo, string customerName) : this() //Next constructor should be call
        {
            AccountNo = accountNo;
            CustomerName = customerName;
        }
        public BankAccount()
        {
            Balance = 0;
        }
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Diposited";
        }
        public virtual string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return "Withdrawn";
            }
            return "Insufficient balance";
        }
        public abstract void Transfer(string from, string to, double amount);
    }
}
