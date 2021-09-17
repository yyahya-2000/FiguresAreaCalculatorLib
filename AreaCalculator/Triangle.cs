using System;

namespace AreaCalculator
{
    class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (!Validator.CheckTriangleValidity(a, b, c))
                throw new ArgumentException("These 3 sides don't form a triangle!");

            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double A { set => a = value; }
        public double B { set => b = value; }
        public double C { set => c = value; }

        public double CalculateArea()
        {
            double s = (0.5) * (a + b + c);
            return Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), 2);
        }

        public string GetFigureInfo()
        {
            double maxLength = Math.Max(Math.Max(a, b), c);
            double minLength = Math.Min(Math.Min(a, b), c);
            double middleLength = a + b + c - maxLength - minLength;

            if (Math.Pow(maxLength, 2) == Math.Pow(minLength, 2) + Math.Pow(middleLength, 2))
                return $"A rectangular triangle, with sides a = {a}, b = {b}, c = {c}, and area = {CalculateArea()}";

            return $"a not rectangular triangle, with sides a = {a}, b = {b}, c = {c}, and area = {CalculateArea()}";
        }
    }
}
