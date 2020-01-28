using System;

namespace MyProject
{
	class Program
	{
		static void Main(string[] args)
        {
            float a = 36;
            float b = 12;
            float resultA;
            float resultB;


            for (float i = a; i >= 0; i--)
            {

                if (a % i == 0)
                {
                    resultA = i;
                    if (b % i == 0)
                    {
                        resultB = i;
                        if (resultA == resultB)
                        {
                            Console.WriteLine(resultA);
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
