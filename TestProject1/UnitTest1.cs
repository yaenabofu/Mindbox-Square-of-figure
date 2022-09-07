using NUnit.Framework;
using SquareFigureLib;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSquareTest()
        {
            Circle circle = new Circle(2);
            Assert.AreEqual(12.57, circle.GetSquare());

            circle = new Circle(-1);
            Assert.AreEqual(0, circle.GetSquare());

            circle = new Circle();
            Assert.AreEqual(0, circle.GetSquare());

            Triangle triangle = new Triangle(2, 2, 2);
            Assert.AreEqual(2, triangle.GetSquare());

            triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetSquare());

            triangle = new Triangle(2, 0, 2);
            Assert.AreEqual(0, triangle.GetSquare());

            triangle = new Triangle(2, 2, -2);
            Assert.AreEqual(0, triangle.GetSquare());
            Assert.Pass();
        }
    }
}