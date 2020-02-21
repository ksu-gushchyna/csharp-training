namespace AbstractClasses
{
    //наследование
    class Rectangle : Figure
    {
        private double a;
        private double b;

        //конструктор
        public Rectangle(double sideA, double sideB)
        {
            this.a = sideA;
            this.b = sideB;
        }
        //полиморфизм
        internal override double GetArea()
        {
            return a * b;
        }

        protected override double GetPerimeter()
        {
            return 2 * (a + b);
        }
    }
}
