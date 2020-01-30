using System;
using System.Security.Principal;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problem 1: Написать программу, которая находит наибольший общий делитель (HOД) двух целых положительных чисел.
            Console.WriteLine("Problem #1");
            CalculateGcd calculate = new CalculateGcd();
            calculate.GetGcd(10, 1000);
            calculate.GetGcd(10, -1000);
            calculate.GetGcd(100, 5);
            calculate.GetGcd(0, 0);


            //Problem 2: Написать программу, которая находит сумму цифр произвольного целого числа.
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Problem #2");
            SummOfNumb summ = new SummOfNumb();
            Console.WriteLine("Summ of numerals of number: " + summ.GetSumm(4441));
            Console.ReadLine();



          
        }
    }
}
