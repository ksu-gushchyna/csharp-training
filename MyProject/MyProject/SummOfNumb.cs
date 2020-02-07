using System;

namespace MyProject
{
    public class SummOfNumb
    {
        private int number;
        public int GetSumm(int number)
        {
            //Problem 2: Написать программу, которая находит сумму цифр произвольного целого числа.
            string st = number.ToString();

            int sum = 0;
            for (int i = 0; i < st.Length; i++)
            {
               sum = sum + (int)Char.GetNumericValue(st[i]);
            }
            
            return sum;
        }
    }
}
