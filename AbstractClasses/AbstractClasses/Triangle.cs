using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c, double h) {
            this.a = a;
            this.b = b;
            this.c = c;
            Side = h;
        }

        internal override double GetArea()
        {
            return 0.5 * a * Side;
        }

        protected override double GetPerimeter()
        {
            return a + b + c;
        }
    }
}
