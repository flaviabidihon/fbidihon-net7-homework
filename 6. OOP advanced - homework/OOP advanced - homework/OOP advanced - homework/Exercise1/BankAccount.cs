using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOP_advanced___homework.Exercise1
{
    public class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        private decimal balance;
        private List<Transaction> transactions = new List<Transaction>();

        public BankAccount(int accountNumber, string accountHolder, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }


        public void Deposit(decimal amount)
        {
            this.balance += amount;
            this.transactions.Add(new Transaction("Deposited:", amount));
        }

        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
            this.transactions.Add(new Transaction("Withdrew:", amount));
        }

        public decimal GetBalance()
        {
            return this.balance;
        }

        public List<Transaction> GetTransactionHistory()
        {
            return this.transactions.OrderBy(t => t._timestamp).ToList();
        }
    }
}
