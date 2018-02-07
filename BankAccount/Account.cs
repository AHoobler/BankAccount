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
        public double AccountBalance { get; set; }
        public int AccountNum { get; set; }



        //constructor
        //public BankAccount()
        //{
        //    //default 
        //}

        //public BankAccount(double accountBalance, int accountNum)
        //{
        //    AccountBalance = accountBalance;
        //    AccountNum = accountNum; 
        //}


        public abstract void DoSomething();


    }
}
