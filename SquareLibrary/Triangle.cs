using System;
using System.Collections.Generic;

namespace SquareLibrary
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Создать новый треугольник.
        /// </summary>
        /// <param name="a">Сторона "a"</param>
        /// <param name="b">Сторона "b"</param>
        /// <param name="c">Сторона "c"</param>
        public Triangle(int a, int b, int c) : base(new List<int> { a, b, c })
        {
            if (a < 1)
            {
                throw new ArgumentException("Сторона не может быть меньше 1", nameof(a));
            }
            if (b < 1)
            {
                throw new ArgumentException("Сторона не может быть меньше 1", nameof(b));
            }
            if (c < 1)
            {
                throw new ArgumentException("Сторона не может быть меньше 1", nameof(c));
            }

            if (!(a + b > c && a +c > b && b +c > a))
            {
                throw new ArgumentException("Треугольник не существует");
            }
                
        }

        /// <summary>
        /// Расчитать периметр.
        /// </summary>
        /// <returns>Периметр.</returns>
        public override double GetPerimeter()
        {
            int result = 0;

            foreach (var side in Sides)
            {
                result += side;
            }

            return result;
        }

        /// <summary>
        /// Расчитать площадь.
        /// </summary>
        /// <returns>Площадь.</returns>
        public override double GetSquare()
        {
            double semiperimeter = GetPerimeter()/2;
            double result =
                Math.Sqrt(semiperimeter * (semiperimeter - Sides[0]) * (semiperimeter - Sides[1]) * (semiperimeter - Sides[2]));
            return result;
        }
    }
}
