namespace AbstractClasses
{
    class Triangle : Figure
    {
        //поля
        //private double a;
        //private double b;
        //private double c;

        //свойства - метод для управления полями
        public double A { get; set; } = 0;
        public double B { get; set; } = 0;
        public double C { get; set; } = 0;
        public Triangle(double a, double b, double c, double side) : base(side)
        {
            //base - указание на базовый класс Figure
            A = a;
            B = b;
            C = c;           
        }

        internal override double GetArea()
        {
            return 0.5 * A * Side;
        }

        internal override double GetPerimeter()
        {
            return A + B + C;
        }
    }
}
