using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class BankManager
    {
        public List<BankAccount> BankAccounts = new List<BankAccount>();
        public BankManager()
        {
            BankAccounts.Add(new BankAccount(0000, 0000, 1000));
            BankAccounts.Add(new BankAccount(1111, 1111, 1000));
            BankAccounts.Add(new BankAccount(2222, 2222, 1000));
            BankAccounts.Add(new BankAccount(3333, 3333, 1000));
            BankAccounts.Add(new BankAccount(4444, 4444, 1000));
        }

        public bool TryLogin(int number, int pin)
        {
            foreach (BankAccount account in BankAccounts)
            {
                if (account.CardPin == pin && account.CardNumber == number)
                {
                    // Maybe we also add which account is active.
                    return true;
                }
            }
            return false;
        }
    }
}
