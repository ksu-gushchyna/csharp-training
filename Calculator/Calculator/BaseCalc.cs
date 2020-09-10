using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    abstract class BaseCalc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public double IntToDouble(int a)
        {
            double result = (double) a;
            return result;
        }

        protected abstract double Sqrt(int sqrt, int num);
    }
}
