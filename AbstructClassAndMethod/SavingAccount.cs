using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassAndMethod
{
   public class SavingAccount:BankAccount
   {
        public SavingAccount(string accountNo, string customerName, double interest) : base(accountNo, customerName) //Relation with base class constructor
        {
            Interest = interest;
        }

        public double Interest { get; set; }

        public override void Transfer(string from, string to, double amount)
        {
           //todo
        }

        public override string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return base.Withdraw(amount);
            }
            return "Insufficient fund";
        }
   }
}
