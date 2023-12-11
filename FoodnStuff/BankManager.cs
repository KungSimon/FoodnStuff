using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class BankManager
    {
        private static BankManager instance = null;
        public Dictionary<string, BankAccount> BankAccounts = new Dictionary<string, BankAccount>();
        private BankAccount ActiveAccount;
        private BankManager()
        {
        }
        public static BankManager GetInstance()
        {
            if (instance == null)
            {
                instance = new BankManager();
            }
            return instance;
        }

        public bool TryLogin(string number, string pin)
        {
            BankAccount thisAccount;

                if (BankAccounts.TryGetValue(number, out thisAccount))
                {
                    // check password in account
                    if (thisAccount.Authenticate(pin))
                    {
                        // Successfully logged in by setting ActiveAccount
                        MessageBox.Show("Successfully Logged in");
                        ActiveAccount = thisAccount;
                        return true;
                    }
                }
                else
                {
                // Create Account
                //string dateString = number;
                //DateTime dateValue;
                //if (DateTime.TryParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                //{
                //    // The string is a valid date in the yyyyMMdd format.
                //    DateTime now = DateTime.Now;
                //    int ageInYears = now.Year - dateValue.Year;
                //    if (now.Month < dateValue.Month || (now.Month == dateValue.Month && now.Day < dateValue.Day))
                //    {
                //        ageInYears--;
                //    }
                //    if (ageInYears.ToString() == pin)
                //    {
                //        MessageBox.Show($"Account created with number:{number} and pin:{ageInYears}");
                //        CreateBankAccount(number, pin);
                //        return true;
                //    }
                //}
                CreateBankAccount(number, pin);
                }
                return false;
        }

        private void CreateBankAccount(string number, string pin)
        {
            BankAccounts.Add(number, new BankAccount(number, pin, 0));
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
