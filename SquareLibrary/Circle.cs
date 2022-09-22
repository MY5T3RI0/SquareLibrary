using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Создать новый круг.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public Circle(int radius) : base(radius)
        {
            if (radius < 1)
            {
                throw new ArgumentException("Радиус не может быть меньше 1",nameof(radius));
            }
        }

        /// <summary>
        /// Рассчитать периметр.
        /// </summary>
        /// <returns>Периметр.</returns>
        public override float GetPerimeter()
        {
            return (float)(Math.PI * 2 * Radius);            

        }

        /// <summary>
        /// Рассчитать площадь.
        /// </summary>
        /// <returns>Площадь.</returns>
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
