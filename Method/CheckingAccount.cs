using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class CheckingAccount: BankAccountProtected
    {
        protected override void ApplyPenalties()
        {
            Console.WriteLine("Checking Account Applying Penalties");
        }
        protected override void CalculateFinalInterest()
        {
            Console.WriteLine("Checking Account Calculate Final Interest");
        }
        protected override void DeleteAccountFromDB()
        {
            Console.WriteLine("Checking Account Deleting Account for DB");
        }
    }
}
