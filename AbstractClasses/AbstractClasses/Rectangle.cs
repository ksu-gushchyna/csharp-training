namespace AbstractClasses
{
    //наследование
    class Rectangle : Figure
    {
        private double a;
        
        //конструктор
        public Rectangle(double sideA, double sideB) : base(sideB)
        {
            this.a = sideA;
        }
        //полиморфизм
        internal override double GetArea()
        {
            return a * Side;
        }

        internal override double GetPerimeter()
        {
            return 2 * (a + Side);
        }
    }
}
