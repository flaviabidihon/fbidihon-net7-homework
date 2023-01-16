using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise6
{
    public static class ExtensionMethod2
    {
        public static string ToBinary(this int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
