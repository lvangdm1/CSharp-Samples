using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class SavingsAccount: BankAccountProtected
    {
        protected override void ApplyPenalties()
        {
            Console.WriteLine("Savings Account Applying Penalties");
        }
        protected override void CalculateFinalInterest() 
        {
            Console.WriteLine("Savings Account Calculate Final Interest");
        }
        protected override void DeleteAccountFromDB()
        {
            Console.WriteLine("Savings Account Deleting Account for DB");
        }
    }
}
