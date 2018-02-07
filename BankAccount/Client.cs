using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Client
    {
        //3 properites
        private string fName { get; set; }
        private string lName { get; set; }
        private bool memberStatus { get; set; }

        //1 constructor
        public Client()
        {
            //
        }

        public Client(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
            this.memberStatus = memberStatus;
        }


        //1 method
        public void Info()
        {
            Console.WriteLine("Client Name: " + fName + " " + lName );
            Console.WriteLine();
        }
    }
}
