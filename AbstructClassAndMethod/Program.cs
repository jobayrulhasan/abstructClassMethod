using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount save = new SavingAccount("SAV-78542", "Jamal Uddin", 4582.12);
            save.Deposit(5000);
            CeckingAccount ceck = new CeckingAccount("CH-74512", "Jomela Khatun", 5632.12);
            save.Transfer("", "", 452.33);
            ceck.Deposit(3000);

            //BankAccount bank = new BankAccount();
            //bank.AccountNo = "BAN-45632";
            //bank.CustomerName = "Mainul Islam";
            //bank.Deposit(3000);
            BankAccount bank = save;
            bank.Transfer("", "", 450.56);

            List<BankAccount> acca = new List<BankAccount>();
            acca.Add(bank);
            acca.Add(save);
            acca.Add(ceck);
            foreach (BankAccount bankAccount in acca)
            {
                bankAccount.Withdraw(1000);
            }

            Console.ReadKey();
        }
    }
}
