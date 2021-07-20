﻿using System;
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
            _triangle = new Triangle(
                a: incorrectValues[0],
                b: incorrectValues[1],
                c: incorrectValues[2]);
            Assert.Fail();
        }

        [Test]
        [TestCase(new double[] { 5, 4, 6 }, 9.921567)]
        [TestCase(new double[] { -5, -4, -6 }, 9.921567)]
        public void TriangleAreaTest(double[] correctValues, double resultValue)
        {
            _triangle = new Triangle(
                a: correctValues[0],
                b: correctValues[1],
                c: correctValues[2]);
            var result = _triangle.Area();
            Assert.Equals(result, resultValue);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(4, 50.26548245743669)]
        [TestCase(4, 78.53981633974483)]
        public void CircleAreaTest(double radius, double resultValue)
        {
            _circle = new Circle(radius);
            var result = _circle.Area();
            Assert.Equals(result, resultValue);
        }
    }
}