using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingsAccount : Account
    {
        // must have minimum balance 

        private int sAcctNum;
        private bool sAcctBal;
        
        public int SAcctNum
        {
            get { return this.sAcctNum; }
            set { this.sAcctNum = value; }
        }

        public bool SAcctBal
        {
            get { return this.sAcctBal; }
            set { this.sAcctBal = value; }
        }

        public SavingsAccount()
        {
            //
        }

        public SavingsAccount(int sAcctNum, bool sAcctBal)
        {
            SAcctBal = sAcctBal;
            SAcctNum = sAcctNum;
        }




        //public override void DoSomething()
        //{

        //}

    }
}
