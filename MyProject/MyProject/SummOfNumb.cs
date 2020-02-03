using System;

namespace MyProject
{
    class SummOfNumb
    {
        private int number;
        public int GetSumm(int number)
        {
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
