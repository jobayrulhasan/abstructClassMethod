using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassAndMethod
{
   public class CeckingAccount:BankAccount
   {
        public CeckingAccount(string accountNo, string customerName, double serviceCharge) : base(accountNo, customerName)
        {
            ServiceCharge = serviceCharge;
        }
        public double ServiceCharge { get; set; }

        public override void Transfer(string from, string to, double amount)
        {
            //todo
        }
    }
}
