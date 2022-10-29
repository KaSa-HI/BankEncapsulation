using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double dollars) 
        {
            _balance = dollars + _balance;
        }

        public double GetBalance() 
        {
            return _balance;
        }

    }
}
