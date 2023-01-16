using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise7
{
    public static class Exercise7
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var query = numbers.Where(x => x % 2 == 0).Select(x => x * x).Sum();
            Console.WriteLine(query);
        }
    }
}
