﻿
namespace Calc
{
    class Calc
    {
        //перегрузка
        //vertual - ключ. слово для переопределения метода в дочернем EngineerCalc классе
        public virtual int Add(int a, int b) 
        {
            return a + b;            
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
