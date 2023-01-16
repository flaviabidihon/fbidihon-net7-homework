using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise8
{
    public static class Exercise8
    {
        public static void Run()
        {
            var numbers2 = new List<int> { 1, 2, 3, 4, 5 };
            var query2 = numbers2.Select(x => x * x).ToList();
            foreach (int elem in query2)
                Console.WriteLine(elem);
        }
    }
}
