namespace AreaCalculator
{
    public static class Factory
    {
        public static IFigure CreateCircle(double radius) => new Circle(radius);
        public static IFigure CreateTriangle(double a, double b, double c) => new Triangle(a, b, c);
    }
}
