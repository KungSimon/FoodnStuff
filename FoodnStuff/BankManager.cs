using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class BankManager
    {
        private static BankManager instance = null;
        public List<BankAccount> BankAccounts = new List<BankAccount>();
        private BankAccount ActiveAccount;
        private BankManager()
        {
            BankAccounts.Add(new BankAccount(0000, 0000, 1000));
            BankAccounts.Add(new BankAccount(1111, 1111, 1000));
            BankAccounts.Add(new BankAccount(2222, 2222, 1000));
            BankAccounts.Add(new BankAccount(3333, 3333, 1000));
            BankAccounts.Add(new BankAccount(4444, 4444, 1000));
        }
        public static BankManager GetInstance()
        {
            if (instance == null)
            {
                instance = new BankManager();
            }
            return instance;
        }

        public bool TryLogin(int number, int pin)
        {
            foreach (BankAccount account in BankAccounts)
            {
                if (account.CardPin == pin && account.CardNumber == number)
                {
                    ActiveAccount = account;
                    return true;
                }
            }
            return false;
        }

        public void LogOut()
        {
            ActiveAccount = null;
        }

        public bool Pay(int _cost)
        {
            // Failcheck
            if (ActiveAccount == null) return false;
            if (ActiveAccount.CashMoney < _cost) return false;
            // Successfully pay
            ActiveAccount.CashMoney -= _cost;
            return true;
        }
    }
}
