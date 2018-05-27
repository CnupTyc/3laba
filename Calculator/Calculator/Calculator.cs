using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator_
    {
        public double Sum(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public double Sub(double a, double b)
        {
            double c = a - b;
            return c;
        }
        public double Mul(double a, double b)
        {
            double c = a * b;
            return c;
        }
        public double Div(double a, double b)
        {
            double c = a / b;
            return c;
        }
        public double Stepen(double a, double b)
        {
            double c = Math.Pow(a, b);
            return c;
        }
        public double Sqrt(double a, double b)
        {
            double c = Math.Pow(a, 1 / b);
            return c;
        }
    }
}
