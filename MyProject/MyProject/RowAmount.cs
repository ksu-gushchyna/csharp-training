using System;

namespace MyProject
{
    class RowAmount
    {
        //Сосчитать сумму ряда 1! - 2! + 3! - 4! + 5! - : + n! для заданного числа n > 0. Чем шире диапазон возможных значений n, тем лучше. Число n задавать в коде программы.
        private int n;

        private int result,
            previous = 2,
            summ;

        public int GetFactorial(int n)
        {
            if (n == 1 ^ n == 2)
            {
                result = n;
            }

            for (int i = 3; i <= n; i++)
            {
                result = previous * i;
                previous = result;
            }
            return result;
        }

        public int GetSummOfFactorials(int n)
        {
            int previousSumm = this.GetFactorial(1);
            for (int i = 2; i <= n; i++)
            {
                summ = previousSumm + this.GetFactorial(i);
                Console.WriteLine(summ);
                previousSumm = summ;
            }
            return summ;
        }
    }
}
