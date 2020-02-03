using System;

namespace BubbleSorting
{
    class Program
    {
        //static void ChangeArrayElmnts(int[] array) {
        //    int temp;

        //}
        static void Main(string[] args)
        {
            int temp;
            const int SIZE = 10;
            int[] array = new int[SIZE];
            var rand = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = rand.Next(1, 100);
            }

            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(array[i] + " ");
            }

            //processing
            for (int i = 0; i < SIZE - 1; i++)
            {
                for (int j = i + 1; j < SIZE; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }


            Console.WriteLine();
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Array.Sort(array);

            foreach (int elm in array)
            {
                Console.Write(elm + " ");

            };

            Console.WriteLine();

            Array.Reverse(array);

            foreach (int elm in array)
            {
                Console.Write(elm + " ");
            }
            Console.ReadLine();

        }
    }
}