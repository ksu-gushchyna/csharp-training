using System;

namespace MyProject
{
    public class CalculateGCD
    {
        /* Условие: Написать программу, которая находит наибольший общий делитель (HOД) двух целых положительных чисел.*/

        //объявление переменных
        private float a;
        private float b;

        private float resultA,
            resultB,
            result,
            j;

        public float GetGCD(float a, float b)
        {
            //условие по какому входному числу будет идти цикл for
            j = a;
            if (a < b)
            {
                j = b;
            }

            //условия проверки невалидных значений
            if ((a == 0 & b == 0) | (a < 0 | b < 0))
            {
                Console.WriteLine("Incorrect value");
            }
            //если значения подаваемые на вход валидные тогда ищем HОД
            else
            {
                for (float i = j; i >= 0; i--)
                {
                    if (a % i == 0)
                    {
                        resultA = i;
                        if (b % i == 0)
                        {
                            resultB = i;
                            if (resultA == resultB)
                            {
                                //Console.WriteLine($"G.C.D. for {a} and {b} is {resultA}");
                                result = resultA;
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
