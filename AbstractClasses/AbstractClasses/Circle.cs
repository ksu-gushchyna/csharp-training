using System;

namespace AbstractClasses
{
    class Circle : Figure
    {
        //инициализируем параметр Side из базового класса
        public Circle(double circleSide) : base(circleSide) 
        {                       
        }
        internal override double GetArea() 
        {
            return Math.PI * Side * Side;
        }

        internal override double GetPerimeter() 
        {
            return 2 * Math.PI * Side;        
        }
    }
}
