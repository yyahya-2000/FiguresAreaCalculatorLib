using System;

namespace AreaCalculator
{
    class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            if (!Validator.CheckCircleValidity(radius))
                throw new ArgumentException("These 3 sides don't form a triangle!");

            this.Radius = radius;
        }

        public double Radius { set => radius = value; }

        public double CalculateArea() => Math.Round(Math.PI * Math.Pow(radius, 2), 2);

        public string GetFigureInfo() => $"A circle with radius = {radius} and area = {CalculateArea()}";
    }
}
