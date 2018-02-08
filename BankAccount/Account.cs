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
   
        public virtual void CheckBal()
        {
            Console.WriteLine("Your account balance is" + AcctBalance);
        }

        public virtual void DoDeposit()
        {
            Console.WriteLine("You have made a deposit.");
            Console.WriteLine("Your account balance is now: " + (AcctBalance - AcctDeposit));
        }




        //public abstract void DoSomething();


    }
}
