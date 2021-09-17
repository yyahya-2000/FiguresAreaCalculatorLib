using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculator.Tests
{
    [TestClass()]
    public class CircleTest
    {
        IFigure circle = Factory.CreateCircle(10);
        [TestMethod()]
        public void CalculateCircleAreaTest()
        {
            double actualCircleArea = circle.CalculateArea();
            double expectedCircleArea = Math.Round(Math.PI * 100, 2);
            Assert.AreEqual(expectedCircleArea, actualCircleArea);
        }

        [TestMethod()]
        public void GetCircleInfoTest()
        {
            string acualCircleInfo = circle.GetFigureInfo();
            string expectedCircleInfo = $"A circle with radius = 10 and area = {Math.Round(Math.PI * 100, 2)}";
            Assert.AreEqual(expectedCircleInfo, acualCircleInfo);
        }
    }
}