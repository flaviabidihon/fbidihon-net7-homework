using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise1
{
    public class DateChecker
    {
        public string DateToCheck { get; }
        public DateChecker(string DateToCheck)
        {
            this.DateToCheck = DateToCheck;
        }

        public void RunDateChecker()
        {
            DateTime date = Convert.ToDateTime(DateToCheck);
            if (date < DateTime.Now)
            {
                throw new InvalidDateException("The date you entered is in the past.");
            }
            else Console.WriteLine("The date you entered is in the FUTURE!");
        }
    }
}



