using System;

namespace AbstractClasses
{
    class Circle : Figure
    {
        internal override double GetArea() 
        {
            return Math.PI * Side * Side;
        }

        protected override double GetPerimeter() 
        {
            return 2 * Math.PI * Side;        
        }
    }
}
