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
            int a = 36;
            int b = 12;
            Console.WriteLine($"GCD of {a} and {b} is " + calculate.GetGcd(a, b));

            //Problem 2: Написать программу, которая находит сумму цифр произвольного целого числа.
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Problem #2");
            int testNumb = 4441;
            SummOfNumb summ = new SummOfNumb();
            Console.WriteLine("Summ of numerals of the " + testNumb + " number is: " + summ.GetSumm(testNumb));
            

            //Problem 3: Написать программу проверки того, что заданное число Х - простое (т.е. не делится без остатка ни на какие числа, кроме себя и 1). Число X задавать в коде программы.
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Problem #3");
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.IsNumberPrime(1);
            primeNumber.IsNumberPrime(2);
            primeNumber.IsNumberPrime(3);
            primeNumber.IsNumberPrime(10);
            primeNumber.IsNumberPrime(79);
            Console.ReadLine();
            

        }
    }
}
