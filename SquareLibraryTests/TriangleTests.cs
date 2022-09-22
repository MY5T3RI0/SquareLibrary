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
        Random rnd = new Random(DateTime.Now.Millisecond);

        [TestInitialize()]
        public void Initialize()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            while (!(a + b > c && a + c > b && b + c > a)) //Исключение случая генерации несуществующего треугольника
            {
                a = rnd.Next(1, 100);
                b = rnd.Next(1, 100);
                c = rnd.Next(1, 100);
            }
            sides = new List<int> { a, b, c };

        }

        [TestMethod()]
        public void GetPerimeterTest()
        {
            //Arrange
            var triangle = new Triangle(sides[0], sides[1], sides[2]);

            //Act
            var actualPerimeter = triangle.GetPerimeter();
            var expectedPerimeter = sides[0] + sides[1] + sides[2];

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
            double perimeter = sides[0] + sides[1] + sides[2];
            double semiPerimeter = perimeter / 2;
            var expectedSquare =
                Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));

            //Assert
            Assert.AreEqual(actualSquare, expectedSquare);
        }

        [TestMethod()]
        public void IsRectangularTest()
        {
            //Arrange
            int a = 0;
            int b = 0;
            int c = 1;
            while (!(Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))) //Создание прямоугольного треугольника
            {
                a = rnd.Next(1, 100);
                b = rnd.Next(1, 100);
                c = rnd.Next(1, 100);
            }

            var triangle = new Triangle(a, b, c);

            //Act
            var test = triangle.IsRectangular();

            //Assert
            Assert.AreEqual(test, true);
        }
    }
}