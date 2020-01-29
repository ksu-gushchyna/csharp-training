using System;
using System.Security.Principal;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Условие: Написать программу, которая находит наибольший общий делитель (HOД) двух целых положительных чисел.*/

            CalculateGCD calculate = new CalculateGCD();
            Console.WriteLine("Problem #1: \nGCD is - " + calculate.GetGCD(10, 1000));
            Console.ReadLine();

            //Problem 2: Написать программу, которая находит сумму цифр произвольного целого числа.


            //Console.ReadLine();
            //Class1 class1 = new Class1(3, -5);
            //Console.WriteLine(class1.GetSquare());
        }
    }
}
