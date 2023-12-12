using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class BankAccount
    {
        private int cashMoney = 10000;
        public int CashMoney
        {
            get
            {
                return cashMoney;
            }
            set
            {
                cashMoney = value;
            }
        }
        public string CardNumber {  get; set; }
        public string CardPin { get; set; }
        public BankAccount(string _cardNumber, string _cardPin, int _cashMoney)
        {
            CardNumber = _cardNumber;
            CardPin = _cardPin;
            CashMoney = _cashMoney;
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
            CashMoney -= _amount;
        }
    }
}
