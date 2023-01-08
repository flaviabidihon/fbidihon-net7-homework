using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise1
{
    public class Transaction
    {
        public DateTime _timestamp;
        public string _type;
        public decimal _amount;

        public Transaction(string type, decimal amount)
        {
            _timestamp = DateTime.Now;
            _type = type;
            _amount = amount;
        }
    }
}
