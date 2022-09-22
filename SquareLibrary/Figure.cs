using System;
using System.Collections.Generic;

namespace SquareLibrary
{
    /// <summary>
    /// Фигура.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Список сторон.
        /// </summary>
        protected List<int> Sides { get; set; }

        /// <summary>
        /// Радиус.
        /// </summary>
        protected int Radius { get; set; }

        /// <summary>
        /// Создать новую фигуру.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public Figure(int radius)
        {         
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может быть <= 0", nameof(radius));
            }

            Radius = radius;
        }

        /// <summary>
        /// Создать новую фигуру.
        /// </summary>
        /// <param name="sides">Список сторон.</param>
        public Figure(List<int> sides)
        {
            Sides = sides ?? throw new ArgumentNullException("Стороны не могут быть null", nameof(sides));
        }

        /// <summary>
        /// Получить периметр.
        /// </summary>
        /// <returns>Периметр.</returns>
        public virtual int GetPerimeter()
        {
            return default;  
        }

        /// <summary>
        /// Получить площадь.
        /// </summary>
        /// <returns>Площадь.</returns>
        public virtual double GetSquare()
        {
            return default;
        }
    }
}
