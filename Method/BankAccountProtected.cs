using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class BankAccountProtected
    {
        // CloseAccount will run these protected below.
        public void CloseAccount()
        {
            ApplyPenalties();
            CalculateFinalInterest();
            DeleteAccountFromDB();
        }
        protected virtual void ApplyPenalties()
        {
            // deduct from account.
        }
        protected virtual void CalculateFinalInterest()
        {
            // add interest to account.
        }
        protected virtual void DeleteAccountFromDB()
        {
            // send notification to data entry personnel.
        }
    }

}
