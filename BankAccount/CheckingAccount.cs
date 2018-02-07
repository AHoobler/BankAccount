using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CheckingAccount : Account
    {



        public double CAcctBal { get; set; }
        public int CAcctNum { get; set; }

        public CheckingAccount()
        {
            //
        }

        public CheckingAccount(double cAcctBal, int cAcctNum)
        {
            CAcctBal = cAcctBal;
            CAcctNum = cAcctNum;
        }

        //public void check



        public override void DoSomething()
        {
            //throw new NotImplementedException();
        }
    }
}
