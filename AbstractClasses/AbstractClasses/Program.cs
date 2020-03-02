using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //объект triangle
            Triangle triangle = new Triangle(1, 2, 3, 1);
            Console.WriteLine("Triangle Area" + triangle.GetArea());
            Console.WriteLine("Triangle Perimeter: " + triangle.GetPerimeter());

            
            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
            Console.WriteLine("Triangle Perimeter: " + triangle.GetPerimeter());

            Circle circle = new Circle(3);
            Console.WriteLine("Rectangle Area: " + circle.GetArea());
            Console.WriteLine("Triangle Perimeter: " + triangle.GetPerimeter());

            Square square = new Square(3);
            Console.WriteLine("Rectangle Area: " + square.GetArea());
            Console.WriteLine("Triangle Perimeter: " + triangle.GetPerimeter());

            //перегрузка
            Calc calc = new Calc();
            Console.WriteLine(calc.Add(1, 1));
            Console.WriteLine(calc.Add(1.1, 1.1));
            Console.WriteLine(calc.Add(1, 2, 3));

            //переопределение
            EngineerCalc engineer = new EngineerCalc();
            //метод из базового класса
            Console.WriteLine(engineer.Add(1.1, 1));
            //переопределенный метод
            Console.WriteLine(engineer.Add(1, 1));

            //sealed
            TriagCalc triagCalc = new TriagCalc();
            Console.WriteLine(triagCalc.Add(1, 2));

            Console.ReadLine();

        }
    }
}
