using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 2;
            float b = 3;
            float resultA;
            float resultB;
            float i;
            float j;

            if (a > b)
            {
                i = a;
                j = i;
            }
            else
            {
                i = b;
                j = i;
            }


            for (i = j; i >= 0; i--)
            {
                if (a % i == 0)
                {
                    resultA = i;
                    if (b % i == 0)
                    {
                        resultB = i;
                        if (resultA == resultB)
                        {
                            Console.WriteLine($"G.C.D. for {a} and {b} is {resultA}");
                            break;
                        }
                    }
                }
            }

            Console.ReadLine();
            //Class1 class1 = new Class1(3, -5);
            //Console.WriteLine(class1.GetSquare());
        }
    }
}
