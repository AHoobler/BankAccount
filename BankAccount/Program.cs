using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankInput;

            SavingsAccount newSavings = new SavingsAccount( );
            CheckingAccount newChecking = new CheckingAccount();
            Client newClient = new Client();



            do
            {
                
                Console.WriteLine("What would you like to do?");

                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");

                bankInput = int.Parse(Console.ReadLine());


                
                switch (bankInput)
                {
                    case 1:
                        //method
                        break;
                    case 2:
                        //method
                        break;
                    case 3:
                        //methos=d
                        break;
                    case 4:
                        //method
                        break;
                    case 5:
                        //method
                        break;
                }

                //client info
                newClient.Info();


              
                

            } while (bankInput != 5);
        }
    }
}
