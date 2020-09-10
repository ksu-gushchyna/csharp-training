using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace Calculator
{
    class Calc : BaseCalc
    {
        public int Pow(int a, int b)
        {
            return (int)Math.Pow(IntToDouble(a), IntToDouble(b));
        }

        //перегрузка
        public int Log(int a, int b)
        {
            return (int)Math.Log(IntToDouble(a), IntToDouble(b));
        }

        //перегрузка
        public double Log(double a, double b)
        {
            return Math.Log(a, b);
        }

        //переопределение
        protected override double Sqrt(int sqrt, int num)
        {
            if (sqrt == 2)
            {
                return Math.Sqrt(num);
            }
            throw new InvalidDataException("You need to enter only 2");
            

        }

        public double GetRoot(int num)
        {
            return Sqrt(2, num);
        }

        public double GetInvalidRoot(int num)
        {
            return Sqrt(3, num);
        }
    }
}
