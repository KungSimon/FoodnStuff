using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class BankAccount
    {
        public int CashMoney { get; set; }
        public int CardNumber {  get; set; }
        public int CardPin { get; set; }
        public BankAccount(int _cardNumber, int _cardPin, int _cashMoney)
        {
            CardNumber = _cardNumber;
            CardPin = _cardPin;
            CashMoney = _cashMoney;
        }
    }
}
