using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Bank
    {
        // can create lists of objects
        public List<Client> AllClients { get; set; }
        public List<CheckingAccount> CheckingAccounts { get; set; }
        public List<SavingsAccount> SavingsAccounts { get; set; }

        //methods
        public List<string> DisplayClientNames()
        {
            List<string> clientNames = new List<string>();
            foreach(Client client in AllClients)
            {
                clientNames.Add(client.fName);
            }
            return clientNames; 
        }
    }
}
