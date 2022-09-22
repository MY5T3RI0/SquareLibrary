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
    public class TriangleTests
    {
        List<int> sides;

        [TestInitialize()]
        public void Initialize()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            sides = new List<int> { rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100) };
            
        }

        [TestMethod()]
        public void GetPerimeterTest()
        {
            //Arrange
            var triangle = new Triangle(sides[0], sides[1], sides[2]);

            //Act
            var actualPerimeter = triangle.GetPerimeter();
            int expectedPerimeter = sides[0] + sides[1] + sides[2];

            //Assert
            Assert.AreEqual(actualPerimeter, expectedPerimeter);
        }

        [TestMethod()]
        public void GetSquareTest()
        {
            //Arrange
            var triangle = new Triangle(sides[0], sides[1], sides[2]);

            //Act
            var actualSquare = triangle.GetSquare();
            var semiPerimeter = (sides[0] + sides[1] + sides[2])/2;
            var expectedSquare = 
                Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));

            //Assert
            Assert.AreEqual(actualSquare, expectedSquare);
        }
    }
}