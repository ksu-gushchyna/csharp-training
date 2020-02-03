using System;

namespace MyProject
{
    class PrimeNumber
    {
        //Написать программу проверки того, что заданное число Х - простое (т.е. не делится без остатка ни на какие числа, кроме себя и 1). Число X задавать в коде программы.
        int X;
        string result;

        public string IsNumberPrime(int X) {

            int k = 0;
            if (X == 1) 
            {

                result = "Yes";
            }
            else
            {
                for (int i = 1; i <= X; i++)
                {

                    if (X % i == 0)
                    {
                        k = k + 1;
                        //Console.WriteLine(k);
                    };
                }

                result = k == 2? "Yes" : "No";
            }           

            Console.WriteLine("Is the number " + X + " prime? Result: " + result + " Counter: " + k);
            return result;        
        }
    }
}
