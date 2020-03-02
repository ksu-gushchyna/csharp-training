using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class EngineerCalc : Calc
    {
        //переопределение - расширяем функциональность кода или своя реализация
        //при переопределении сигнатура метода сохраняется
        //сигнатура - название и тип аргументов
        //полиморфизм
        public override sealed int Add(int a, int b)
        {
            Console.WriteLine("Hello from EngineerCalc");
            //return base.Add(a, b);
            return a - b;
        }

        public virtual int Sub(int a, int b) 
        {
            return a - b;
        }
    }
}
