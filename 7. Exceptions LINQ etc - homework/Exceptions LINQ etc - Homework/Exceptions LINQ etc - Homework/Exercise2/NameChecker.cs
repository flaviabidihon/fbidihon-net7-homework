using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise2
{
    public class NameChecker
    {
        public void ReadAndCheckName()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Enter the names you want to check, separated by a space.");
            string[] inputParsed = Console.ReadLine().Split(" ");
            names.AddRange(inputParsed);

            try
            {
                CheckAllNames(names);
                Console.WriteLine("All names are ok.");
            }
            catch(BlankNameException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void CheckAllNames(List<string> names)
        {
            foreach (string name in names)
            {
                if (!IsAValidName(name))
                {
                    throw new BlankNameException("ERROR! Some names are blank.");
                }
            }
        }

        private bool IsAValidName(string name)
        {
            if(String.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            return true;
        }
    }
}
