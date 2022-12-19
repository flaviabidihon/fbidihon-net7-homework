using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro___homework
{
    public class Calculator
    {       
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
