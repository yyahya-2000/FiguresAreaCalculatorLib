using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTests
{

    [TestClass]
    public class TriangleTest
    {
        IFigure circle = Factory.CreateTriangle(5, 13, 12);
        [TestMethod()]
        public void CalculateTriangleAreaTest()
        {
            double actualTriangleArea = circle.CalculateArea();
            double expectedTriangleArea = 30;
            Assert.AreEqual(expectedTriangleArea, actualTriangleArea);
        }

        [TestMethod()]
        public void GetTriangleInfoTest()
        {
            string acualTriangleInfo = circle.GetFigureInfo();
            string expectedTriangleInfo = $"A rectangular triangle, with sides a = 5, b = 13, c = 12, and area = 30";
            Assert.AreEqual(expectedTriangleInfo, acualTriangleInfo);
        }
    }
}
