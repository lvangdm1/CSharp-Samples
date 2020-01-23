using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Option: 1
            // This below will only access the Base class.
            // var b = new BankAccountProtected();
            // b.CloseAccount();

            // Option: 2
            // this will access both because Derived SavingsAccount inherits.
            //var s = new SavingsAccount();
            //s.CloseAccount();

            // Option: 3
            // this will access both accounts through Array
            BankAccountProtected[] bankAccts = new BankAccountProtected[2];
            bankAccts[0] = new SavingsAccount();
            bankAccts[1] = new CheckingAccount();

            foreach (BankAccountProtected acct in bankAccts)
            {
                acct.CloseAccount();
            }
        }
    }
}
