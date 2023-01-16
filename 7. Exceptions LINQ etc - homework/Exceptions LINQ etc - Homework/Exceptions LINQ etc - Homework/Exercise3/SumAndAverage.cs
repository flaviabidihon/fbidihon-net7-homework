using Exceptions_LINQ_etc___Homework.Exercise2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise3
{
    public class SumAndAverage
    {
        public void Calculator()
        {
            List<int> numbers = new List<int>();
            List<string> strings = new List<string>();

            Console.WriteLine("Enter the numbers, separated by a space.");
            string input = Console.ReadLine();
            string[] inputParsed = input.Split(" ");
            strings.AddRange(inputParsed);
            foreach (string s in strings)
            {
                numbers.Add(int.Parse(s));
            }

            try
            {
                IsListEmpty(numbers);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                foreach (string s in strings)
                    IsAValidNumber(s);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                IsSumAnInt(numbers);
            }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine($"Sum: {numbers.Sum()} \nAverage: {numbers.Average()}");
        }

        private void IsListEmpty(List<int> IntList)
        {
            if (IntList.Count == 0)
                throw new DivideByZeroException();
        }

        private void IsAValidNumber(string NumericOrNot)
        {
            if (int.TryParse(NumericOrNot, out _) == false)
                throw new FormatException();
        }

        private void IsSumAnInt(List<int> numbersToSum)
        {
            foreach (int number in numbersToSum)
            {
                if (numbersToSum.Sum() > int.MaxValue)
                    throw new OverflowException();
            }
        }
    }
}
