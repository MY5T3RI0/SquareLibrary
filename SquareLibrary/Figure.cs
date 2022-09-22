using System;
using System.Collections.Generic;

namespace SquareLibrary
{
    public abstract class Figure
    {
        protected List<int> Sides { get; set; }

        protected int Radius { get; set; }

        public Figure(int radius)
        {         
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может быть <= 0", nameof(radius));
            }

            Radius = radius;
        }

        public Figure(List<int> sides)
        {
            Sides = sides ?? throw new ArgumentNullException("Стороны не могут быть null", nameof(sides));
        }

        public virtual int GetPerimeter()
        {
            return default;  
        }

        public virtual double GetSquare()
        {
            return default;
        }
    }
}
