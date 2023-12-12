using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class BankAccount
    {
        public int cashMoney = 10000;
        public string CardNumber {  get; set; }
        public string CardPin { get; set; }
        public BankAccount(string _cardNumber, string _cardPin)
        {
            CardNumber = _cardNumber;
            CardPin = _cardPin;
        }

        public bool Authenticate(string _pin)
        {// Method to check pincode
            if (CardPin == _pin)
            {
                return true;
            }
            return false;
        }

        public void Subtract(int _amount)
        {
            cashMoney -= _amount;
        }
    }
}
