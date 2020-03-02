using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class TriagCalc : EngineerCalc
    {
        public override int Sub(int a, int b)
        {
            return a - 2 * b;
        }

        //seald метод нельзя переопределять
        //public override int Add(int a, int b)
        //{
        //    return 4 * a + b;
        //}
    }
}
