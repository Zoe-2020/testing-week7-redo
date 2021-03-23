using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestingdemo.MyProject; // note we must reference the project we are testing

namespace UnitTestdemo.MyProject.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator c = new Calculator();


        [Test]
        public void Add()
        {
            Assert.AreEqual(20, c.multiply(5, 4));
        }

        [Test]
        public void div()
        {
            Assert.AreEqual(true, c.divisible(3, 1, 3));
            Assert.AreEqual(true, c.divisible(12, 2, 6));
            Assert.AreEqual(false, c.divisible(100, 5, 3));
            Assert.AreEqual(false, c.divisible(12, 5, 3));

        }

        [Test]
        public void watermelonsDiv()
        {
            Assert.AreEqual(true, c.Q2Div(2, 6));
            Assert.AreEqual(true, c.Q2Div(4, 4));
            Assert.AreEqual(false, c.Q2Div(3, 5));
            Assert.AreEqual(false, c.Q2Div(7, 1));
        }

    }
}

