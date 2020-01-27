using System;

namespace MyProject
{
	class Program
	{
		static void Main(string[] args)
        {
            float a = 10;
            float b = 5;
            float resultA = 0;
            float resultB = 0;
            float currentResultA;
            float currentResultB;
            int mainResult;

            for (int i = 1, j = 0; i <= a; i++, j++)
            {
                
                if (a % i == 0 & b % j == 0)
                {
                    Console.WriteLine(i + "and" + j);
                }
                Console.ReadLine();
            }
            



            //Class1 class1 = new Class1(3, -5);

            //Console.WriteLine(class1.GetSquare());
        }
	}
}
