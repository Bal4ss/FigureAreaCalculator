using System;
using FigureAreaCalculator;
using FigureAreaCalculator.Components.Data_Model;
using NUnit.Framework;

namespace FigureAreaCalculatorTest
{
    [TestFixture]
    public class Tests
    {
        private IFigure _circle;
        private IFigure _triangle;

        [SetUp]
        public void SetUp()
        {
            _circle = new Circle(4);
            _triangle = new Triangle(5, 4, 6);
        }
        
        [Test]
        [TestCase(new double[] { 1, 2, 6 })]
        [TestCase(new double[] { -1, -2, -6 })]
        public void CreateFailTriangleTest(double[] incorrectValues)
        {
            try
            {
                _triangle = new Triangle(
                    a: incorrectValues[0],
                    b: incorrectValues[1],
                    c: incorrectValues[2]);
                Assert.Fail("No exception was thrown");
            }
            catch (AggregateException ex)
            {
                Assert.AreEqual(
                    new AggregateException("Impossible triangle side lengths"),
                    ex);
            }
        }

        [Test]
        [TestCase(new double[] { 5, 4, 6 }, 9.921567)]
        [TestCase(new double[] { -5, -4, -6 }, 9.921567)]
        public void TriangleAreaTest(double[] correctValues, double expected)
        {
            _triangle = new Triangle(
                a: correctValues[0],
                b: correctValues[1],
                c: correctValues[2]);
            var result = _triangle.Area();
            Assert.AreEqual(expected, result, 0.0001);
        }
        
        [Test]
        [TestCase(0)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(-5)]
        public void CircleAreaTest(double radius)
        {
            _circle = new Circle(radius);
            var result = _circle.Area();
            
            radius = radius > 0 ? radius : -radius;
            var expected = Math.PI * radius * radius; // S=πr^2
            
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}