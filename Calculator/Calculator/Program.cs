using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine(calc.Add(3, 2));
            Console.WriteLine(calc.Pow(100, 0));
            

            EngineerCalc engineerCalc = new EngineerCalc();
            Console.WriteLine(engineerCalc.Tan(180));
            Console.WriteLine(engineerCalc.GetCubeRoot(27));


            Console.WriteLine(calc.GetRoot(4));
            Console.WriteLine(calc.GetInvalidRoot(3));

        }
    }
}
