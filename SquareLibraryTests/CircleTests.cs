using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetPerimeterTest()
        {
            //Arrange
            var rnd = new Random(DateTime.Now.Millisecond);
            var radius = rnd.Next(1, 100);
            var circle = new Circle(radius);

            //Act
            var actualPerimeter = circle.GetPerimeter();
            var expectedPerimeter = Math.PI * radius * 2;

            //Assert
            Assert.AreEqual(actualPerimeter, expectedPerimeter);
        }

        [TestMethod()]
        public void GetSquareTest()
        {
            //Arrange
            var rnd = new Random(DateTime.Now.Millisecond);
            var radius = rnd.Next(0, 100);
            var circle = new Circle(radius);

            //Act
            var actualPerimeter = circle.GetSquare();
            var expectedPerimeter = Math.PI * Math.Pow(radius, 2);

            //Assert
            Assert.AreEqual(actualPerimeter, expectedPerimeter);
        }
    }
}