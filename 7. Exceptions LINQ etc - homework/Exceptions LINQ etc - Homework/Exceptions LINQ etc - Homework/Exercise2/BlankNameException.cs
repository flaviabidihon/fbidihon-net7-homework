using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise2
{
    public class BlankNameException : Exception
    {
        public BlankNameException(string? message) : base(message)
        { }
    }
}
