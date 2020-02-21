namespace AbstractClasses
{
    abstract class Figure
    {
        protected double Side{get; set;}

        protected double side;
        protected abstract double GetPerimeter();
        internal abstract double GetArea();
    }
}
