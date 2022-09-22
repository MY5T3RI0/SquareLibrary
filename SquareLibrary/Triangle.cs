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
        /// <param name="a">Сторона "a".</param>
        /// <param name="b">Сторона "b".</param>
        /// <param name="c">Сторона "c".</param>
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

        /// <summary>
        /// Получение наибольшей из сторон.
        /// </summary>
        /// <returns>Наибольшая сторона.</returns>
        private int? GetMaxSide()
        {
            if (Sides[0] > Sides[1] && Sides[0] > Sides[2])
                return Sides[0];
            else
            if (Sides[1] > Sides[0] && Sides[1] > Sides[2])
                return Sides[1];
            else
                if (Sides[2] > Sides[0] && Sides[2] > Sides[1])
                return Sides[2];
            else
                return null;
        }

        /// <summary>
        /// Проверка на наличие прямого угла.
        /// </summary>
        /// <returns>Наличие.</returns>
        public bool IsRectangular()
        {
            var MaxSide = GetMaxSide();

            if (MaxSide != null)
            {
                double temp = 0;
                foreach (var side in Sides)
                {
                    if (side != MaxSide)
                    {
                        temp += Math.Pow(side, 2);
                    }
                }

                if (Math.Pow((int)MaxSide, 2) == temp)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
