using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class EngineerCalc : BaseCalc
    {
        public int Sin(int a)
        {
            return (int)Math.Sin(a);
        }
        public int Cos(int a)
        {
            return (int)Math.Cos(a);
        }

        public int Tan(int a)
        {
            return (int) Math.Tan(a);
        }

        public int Ctng(int a)
        {
            return (int)(1/Math.Tan(a));
        }

        protected override double Sqrt(int sqrt, int num)
        {
            switch (sqrt)
            {
                case 3: return Math.Cbrt(num);
                break;

                case 4: return Math.Pow(0.25, num);
                break;

                default: return 0;
            }
        }

        public double GetFourRoot(int num)
        {
            return Sqrt(4, num);
        }

        public double GetCubeRoot(int num)
        {
            return Sqrt(3, num);
        }
    }
}
