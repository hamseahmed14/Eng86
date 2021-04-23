using NUnit.Framework;
using CalculatorLib;
using System;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3, 4, 7)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, -7, -10)]
        [TestCase(-3, 7, 4)]
        [Test]
        public void AddTest(int a, int b, int expected)
        {
            var result = Calculator.Add(a, b);
            Assert.AreEqual(result, expected);
        }

        [TestCase(3, 4, 12)]
        [TestCase(7, 0, 0)]
        [TestCase(-3, -7, 21)]
        [TestCase(10, -7, -70)]
        [Test]
        public void MultiplyTest(int a, int b, int expected)
        {
            var result = Calculator.Multiply(a, b);
            Assert.AreEqual(result, expected);
        }

        [TestCase(12, 4, 3)]
       
        [TestCase(9, 4, 2)]
        [TestCase(-10, 7, -1)]
        [TestCase(7, -3, -2)]
        [TestCase(-7, -3, 2)]
        [Test]
        public void DivideTest(int a, int b, int expected)
        {
            var result = Calculator.Divide(a, b);
            Assert.AreEqual(result, expected);
        }

        [TestCase(10, 0, 0)]
        [Test]
        public void DivideByZeroTest(int a, int b, int expected)
        {
            var ex = Assert.Throws<ArgumentException>(() => Calculator.Divide(a,b));
            Assert.AreEqual("Cannot divide by zero",ex.Message);
        }
    }
}