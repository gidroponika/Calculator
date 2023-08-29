using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    internal class Calculator
    {
        public event EventHandler DividedByZero = null;
        public void InvokeEvent()
        {
            DividedByZero?.Invoke(this, EventArgs.Empty);
        }

        public double Add(double a, double b) => a + b;

        public double Sub(double a, double b) => a - b;

        public double Mul(double a, double b) => a * b;

        public double? Div(double a, double b)
        {
            double? result;
            if (b != 0)
            {
                result = a / b;
            }
            else
            {
                result = null;
                InvokeEvent();
            }
            return result;
        }
    }
}
