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
        }

        /// <summary>
        /// Расчитать периметр.
        /// </summary>
        /// <returns>Периметр.</returns>
        public override int GetPerimeter()
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
            int perimeter = GetPerimeter();
            double result =
                Math.Pow(perimeter * (perimeter - Sides[0]) * (perimeter - Sides[1]) * (perimeter - Sides[2]),
                1 / 2);
            return result;
        }
    }
}
