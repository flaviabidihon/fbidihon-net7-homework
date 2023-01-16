using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise5
{
    public static class ExtensionMethod
    {
        public static string ToFullDateString(this DateTime date)
        {
            return date.ToString("MM/dd/yyyy hh:mm:ss");
        }
    }
}
