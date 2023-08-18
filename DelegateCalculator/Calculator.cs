using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    internal static class Calculator
    {
        public static double Add(double a, double b) => a + b;

        public static double Sub(double a, double b) => a - b;

        public static double Mul(double a, double b) => a * b;

        public static double Div(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("division by zero is not possible");
                return 0;
            }
        }
    }
}
