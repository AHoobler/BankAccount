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
            string depositInput;
            string balanceInput;
            string withdrawInput;

            SavingsAccount newSavings = new SavingsAccount(10000, 98765);
            CheckingAccount newChecking = new CheckingAccount(5000.00, 12345);
            Client newClient = new Client("Jane", "Doe");


            Console.WriteLine("Welcome to the Bank");
            Console.WriteLine();

            do
            {
                
                Console.WriteLine("What would you like to do?");

                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                bankInput = int.Parse(Console.ReadLine());


                
                switch (bankInput)
                {
                    case 1:
                        newClient.Info();
                        break;
                    case 2:
                        Console.WriteLine("Which account would you like to check the balance for?");
                        Console.WriteLine("Press A for checking account");
                        Console.WriteLine("Press B for savings account");
                        balanceInput = Console.ReadLine();
                        break;


                    case 3:
                        Console.WriteLine("Which account would you like to add money to?");
                        Console.WriteLine("Press A for checking account");
                        Console.WriteLine("Press B for savings account");
                        depositInput = Console.ReadLine();      
                        break;


                    case 4:
                        Console.Write("Which account would you like to remove money from?");
                        Console.WriteLine("Press A for checking account");
                        Console.WriteLine("Press B for savings account");
                        withdrawInput = Console.ReadLine();
                        break;

                }
            } while (bankInput != 5);
            Console.WriteLine("Thank you for using Bank.");
        }
    }
}
