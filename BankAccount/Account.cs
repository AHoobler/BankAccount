using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {
        //fields

        //properties
        public double AcctBalance { get; set; }
        public double AcctDeposit { get; set; }
        public double AcctWithdraw { get; set; }


        public Account()
        {
            //
        }

        public Account (double acctBalance, double acctDeposit, double acctWithdraw)
        {
            AcctBalance = acctBalance;
            AcctDeposit = acctDeposit;
            AcctWithdraw = acctWithdraw;
        }
   


        public abstract void DoSomething();


    }
}
