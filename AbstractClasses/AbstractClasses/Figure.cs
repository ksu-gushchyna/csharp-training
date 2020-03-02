namespace AbstractClasses
{
    abstract class Figure
    {
        protected double Side{get; set;}

        //protected double side;

        //конструктор
        public Figure(double side) 
        {
            Side = side;            
        }
        internal abstract double GetPerimeter();
        internal abstract double GetArea();
    }
}
