using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Triangle triangle = new Triangle(1, 2, 3, 1);
            Console.WriteLine(triangle.GetArea());
            Console.ReadLine();

        }
    }
}
