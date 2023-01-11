using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise5
{
    public class BankAccountEx5
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Balance cannot have a negative value.");
                }
                _balance = value;
            }
        }

        public BankAccountEx5(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;

            Bank.NumAccounts++;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < _balance)
                _balance -= amount;
        }

        public double GetInterest()
        {
            return Bank.CalculateInterest(Balance);
        }

    }
}
