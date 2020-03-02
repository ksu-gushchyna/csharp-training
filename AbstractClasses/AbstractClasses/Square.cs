using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Square : Figure
    {
        public Square(double Side) : base(Side)
        {
        }

        internal override double GetArea() 
        {
            return Side * Side;        
        }

        internal override double GetPerimeter()
        {
            return 4 * Side;
        }


    }
}
